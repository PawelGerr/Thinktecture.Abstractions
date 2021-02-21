using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using FluentAssertions;

namespace Thinktecture.Abstractions.Tests
{
   public abstract class IntegrityTestsBase
   {
      private readonly IReadOnlyList<Type> _originalTypes;
      private readonly IReadOnlyList<Type> _abstractionTypes;
      private readonly IReadOnlyList<Type> _adapterTypes;

      protected CustomMappings CustomTypeMappings { get; }
      protected List<Type> ExcludedTypes { get; }
      protected List<MemberInfo> ExcludedMembers { get; }
      protected Func<Type, bool> ExcludeTypeCallback { get; set; }
      protected Func<Type, Type, MemberInfo, bool> ExcludeMemberCallback { get; set; }

      protected IntegrityTestsBase(string assemblyName)
         : this(GetAssembly($"System.{assemblyName}"), GetAssembly($"Thinktecture.{assemblyName}.Abstractions"))
      {
      }

      protected IntegrityTestsBase(Assembly originalAssembly, Assembly abstractionsAssembly)
      {
         _originalTypes = GetOriginalTypes(originalAssembly);
         _abstractionTypes = GetAbstractionTypes(abstractionsAssembly);
         _adapterTypes = GetAdapterTypes(abstractionsAssembly, _abstractionTypes);

         CustomTypeMappings = new CustomMappings();
         ExcludedTypes = new List<Type>();
         ExcludedMembers = new List<MemberInfo>();
      }

      protected void ExcludeMember<T>(string name)
      {
         var members = typeof(T).GetMember(name, BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public);

         members.Should().HaveCount(1, $"member \"{name}\" of type {typeof(T).FullName} should exist only once");

         ExcludedMembers.Add(members[0]);
      }

      protected void ExcludeMembers<T>(string name)
      {
         ExcludeMembers(typeof(T), name);
      }

      protected void ExcludeMembers(Type type, string name)
      {
         var members = type.GetMember(name, BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public);

         members.Should().HaveCountGreaterOrEqualTo(1, $"member \"{name}\" of type {type.FullName} not found");

         ExcludedMembers.AddRange(members);
      }

      protected static Assembly GetAssembly(string name)
      {
         var assembly = Assembly.Load(name);

         if (assembly == null)
            throw new ArgumentException($"Assembly with the name {name} not found.");

         return assembly;
      }

      protected void CheckTypes()
      {
         var types = _originalTypes
                     .Where(t => !ExcludedTypes.Contains(t) && !(ExcludeTypeCallback?.Invoke(t) ?? false))
                     .ToList();
         var abstractions = _abstractionTypes
                            .Where(t => !ExcludedTypes.Contains(t) && !(ExcludeTypeCallback?.Invoke(t) ?? false))
                            .ToList();

         var missingAbstractions = new List<Type>();

         foreach (var t in GetTypes())
         {
            types.Remove(t.Original);

            if (t.Abstraction == null)
            {
               missingAbstractions.Add(t.Original);
            }
            else
            {
               abstractions.Remove(t.Abstraction);
            }
         }

         missingAbstractions.Should().BeEmpty($"abstraction for following {missingAbstractions.Count} type(s) not found: {String.Join(", ", missingAbstractions.Select(t => t.FullName))}");
         types.Should().BeEmpty();
         abstractions.Should().BeEmpty();
      }

      protected void CheckAdapters()
      {
         var abstractions = _abstractionTypes
                            .Where(t => !ExcludedTypes.Contains(t) && !(ExcludeTypeCallback?.Invoke(t) ?? false))
                            .ToList();
         var adapterTypes = _adapterTypes
                            .Where(t => !ExcludedTypes.Contains(t) && !(ExcludeTypeCallback?.Invoke(t) ?? false))
                            .ToList();

         foreach (var abstractionType in abstractions)
         {
            var adapters = FindAdapters(adapterTypes, abstractionType);

            adapters.Should().HaveCount(1, $"abstraction {abstractionType.Name} must have an adapter.");
         }
      }

      private static IReadOnlyList<Type> FindAdapters(IEnumerable<Type> adapterTypes, Type abstractionType)
      {
         if (abstractionType.IsGenericType && !abstractionType.IsGenericTypeDefinition)
            abstractionType = abstractionType.GetGenericTypeDefinition();

         return adapterTypes
                .Where(adapter =>
                       {
                          foreach (var adapterInterface in GetInterfaces(adapter).Except(GetInterfaces(adapter.BaseType)))
                          {
                             if (abstractionType == adapterInterface)
                                return true;
                          }

                          return false;
                       })
                .ToList().AsReadOnly();
      }

      protected void CheckMembers()
      {
         foreach (var types in GetTypes().Where(t => t.Abstraction != null))
         {
            var originalMembers = GetMembers(types.Original, types.Abstraction).Where(m => !(m is ConstructorInfo));
            var abstractionMembers = GetMembers(types.Abstraction, types.Original).Where(m => !(m is ConstructorInfo));

            foreach (var group in originalMembers.GroupBy(m => m.Name))
            {
               var members = abstractionMembers.Where(m => m.Name == group.Key).ToList();

               members.Should().HaveCountGreaterOrEqualTo(group.Count(), $"the type {types.Abstraction.FullName} should have {group.Count()} member(s) with the name \"{group.Key}\" (reflected type {group.First().ReflectedType.FullName})");
            }
         }
      }

      protected void CheckConstructors(params Type[] skipTypes)
      {
         var adapterTypes = _adapterTypes
                            .Where(t => !ExcludedTypes.Contains(t) && !(ExcludeTypeCallback?.Invoke(t) ?? false))
                            .ToList();

         foreach (var types in GetTypes().Where(t => t.Abstraction != null))
         {
            if (types.Abstraction != null && types.Original != null && !IsStatic(types.Original) && !skipTypes.Contains(types.Original))
            {
               var adapter = FindAdapters(adapterTypes, types.Abstraction).FirstOrDefault();

               if (adapter != null && !skipTypes.Contains(adapter))
               {
                  var adapterConstructors = adapter.GetConstructors();
                  var wrapperConstructor = FindConstructor(adapterConstructors, types.Original);

                  wrapperConstructor.Should().NotBeNull($"The adapter {adapter.Name} of abstraction {types.Abstraction.Name} must have a ctor({types.Original.Name})");

                  var originalConstructors = types.Original.GetConstructors();

                  foreach (var originalCtor in originalConstructors)
                  {
                     if (originalCtor.GetCustomAttribute<ObsoleteAttribute>() == null)
                     {
                        var orginalParams = originalCtor.GetParameters().Select(p => p.ParameterType).ToArray();
                        var adapterCtor = FindConstructor(adapterConstructors, orginalParams);

                        adapterCtor.Should().NotBeNull($"The adapter {adapter.Name} of abstraction {types.Abstraction.Name} must have a ctor({String.Join(", ", orginalParams.Select(p => p.Name))})");
                     }
                  }
               }
            }
         }
      }

      private static bool IsStatic(Type type)
      {
         return type.IsAbstract && type.IsSealed;
      }

      private static ConstructorInfo FindConstructor(IList<ConstructorInfo> constructors, params Type[] args)
      {
         foreach (var ctor in constructors)
         {
            if (IsMatch(ctor, args))
               return ctor;
         }

         return null;
      }

      private static bool IsMatch(ConstructorInfo ctor, Type[] args)
      {
         if (ctor == null)
            throw new ArgumentNullException(nameof(ctor));
         if (args == null)
            throw new ArgumentNullException(nameof(args));

         var parameters = ctor.GetParameters();

         if (parameters.Length != args.Length)
            return false;

         for (var i = 0; i < args.Length; i++)
         {
            var paramType = parameters[i].ParameterType;
            var argType = args[i];

            if (!AreCtorArgTypesEqual(paramType, argType))
               return false;
         }

         return true;
      }

      private static bool AreCtorArgTypesEqual(Type type, Type otherType)
      {
         if (type.IsGenericType && !type.IsGenericTypeDefinition)
            type = type.GetGenericTypeDefinition();

         if (otherType.IsGenericType && !otherType.IsGenericTypeDefinition)
            otherType = otherType.GetGenericTypeDefinition();

         return type == otherType;
      }

      private IReadOnlyList<MemberInfo> GetMembers(Type type, Type otherType)
      {
         if (type == null)
            throw new ArgumentNullException(nameof(type));

         var members = GetAllMembers(type);

         return members
                .Where(m =>
                       {
                          if (m is Type)
                             return false;

                          if (ExcludedMembers.Contains(m))
                             return false;

                          if (ExcludeMemberCallback?.Invoke(type, otherType, m) ?? false)
                             return false;

                          if (m is MethodInfo methodInfo)
                          {
                             if (IsObjectMethod(methodInfo))
                                return false;

                             if (IsPropertyAccessor(members, methodInfo))
                                return false;
                          }

                          return true;
                       })
                .ToList().AsReadOnly();
      }

      private List<MemberInfo> GetAllMembers(Type type)
      {
         if (type == null)
            throw new ArgumentNullException(nameof(type));

         var allMembers = new List<MemberInfo>();

         var interfaces = type.GetInterfaces();

         foreach (var iface in interfaces)
         {
            if (iface.IsPublic)
               AddMembers(allMembers, iface);
         }

         var currentType = type;

         do
         {
            if (currentType != typeof(MarshalByRefObject))
               AddMembers(allMembers, currentType);

            currentType = currentType.BaseType;
         }
         while (currentType != null && currentType != typeof(object));

         return allMembers;
      }

      private void AddMembers(List<MemberInfo> allMembers, Type type)
      {
         var members = type.GetMembers(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly)
                           .Where(newMem => !allMembers.Any(m => AreEqual(newMem, m)));

         allMembers.AddRange(members);
      }

      private static bool AreEqual(MemberInfo member, MemberInfo other)
      {
         if (member.Name != other.Name)
            return false;

         if (member.GetType() != other.GetType())
            return false;

         if (member is MethodInfo methodInfo)
            return AreEqual(methodInfo, (MethodInfo)other);

         return true;
      }

      private static bool AreEqual(MethodInfo method, MethodInfo other)
      {
         var args = method.GetParameters();
         var otherArgs = other.GetParameters();

         if (args.Length != otherArgs.Length)
            return false;

         for (var i = 0; i < args.Length; i++)
         {
            var arg = args[i];
            var otherArg = otherArgs[i];

            if (!AreEqual(arg, otherArg))
               return false;
         }

         return true;
      }

      private static bool AreEqual(ParameterInfo parameter, ParameterInfo other)
      {
         if (parameter.ParameterType == other.ParameterType)
            return true;

         var type = parameter.ParameterType.IsInterface ? parameter.ParameterType.FullName : BuildAbstractionTypeName(parameter.ParameterType);
         var otherType = other.ParameterType.IsInterface ? other.ParameterType.FullName : BuildAbstractionTypeName(other.ParameterType);

         return type == otherType;
      }

      private bool IsPropertyAccessor(IEnumerable<MemberInfo> members, MethodInfo methodInfo)
      {
         if (methodInfo == null)
            throw new ArgumentNullException(nameof(methodInfo));

         if (methodInfo.Name.StartsWith("get_") || methodInfo.Name.StartsWith("set_"))
         {
            var propName = methodInfo.Name.Substring(4);

            return members.Any(mem =>
                               {
                                  if (mem is PropertyInfo propInfo)
                                     return propInfo.Name == propName;

                                  return false;
                               });
         }

         return false;
      }

      private bool IsObjectMethod(MethodInfo methodInfo)
      {
         if (methodInfo == null)
            throw new ArgumentNullException(nameof(methodInfo));

         switch (methodInfo.Name)
         {
            case "ToString":
            case "GetHashCode":
            case "GetType":
               return methodInfo.GetParameters().Length == 0;

            case "Equals":
            {
               var parameters = methodInfo.GetParameters();
               return parameters.Length == 1 && parameters[0].ParameterType == typeof(object);
            }
         }

         return false;
      }

      private IEnumerable<(Type Original, Type Abstraction)> GetTypes()
      {
         foreach (var originalType in _originalTypes)
         {
            if (CustomTypeMappings.TryGet(originalType, out var abstractionTypes))
            {
               foreach (var abstractionType in abstractionTypes)
               {
                  yield return (originalType, abstractionType);
               }
            }
            else
            {
               if (ExcludedTypes.Contains(originalType))
                  continue;

               if (ExcludeTypeCallback?.Invoke(originalType) == true)
                  continue;

               var abstractionTypeName = BuildAbstractionTypeName(originalType);
               var abstractionType = _abstractionTypes.FirstOrDefault(t => t.FullName == abstractionTypeName);

               yield return (originalType, abstractionType);
            }
         }
      }

      private static string BuildAbstractionTypeName(Type originalType)
      {
         if (originalType == null)
            throw new ArgumentNullException(nameof(originalType));

         var ns = originalType.Namespace.Split('.');
         ns.Should().HaveCountGreaterOrEqualTo(1);

         ns[0] = "Thinktecture";

         return String.Join(".", ns.Concat(new[] { $"I{originalType.Name}" }));
      }

      private IReadOnlyList<Type> GetOriginalTypes(Assembly assembly)
      {
         return GetTypes(assembly)
                .Where(t => !t.IsInterface)
                .ToList().AsReadOnly();
      }

      private IReadOnlyList<Type> GetAbstractionTypes(Assembly assembly)
      {
         return GetTypes(assembly)
                .Where(t => t.IsInterface)
                .ToList().AsReadOnly();
      }

      private IReadOnlyList<Type> GetAdapterTypes(Assembly abstractionsAssembly, IReadOnlyList<Type> abstractionTypes)
      {
         return GetTypes(abstractionsAssembly)
                .Where(t => !t.IsAbstract)
                .Where(t => abstractionTypes.Any(a => GetInterfaces(t).Contains(TryGetGenericTypeDefinition(a))))
                .ToList().AsReadOnly();
      }

      private static IReadOnlyList<Type> GetInterfaces(Type type)
      {
         return type.GetInterfaces()
                    .Select(TryGetGenericTypeDefinition)
                    .ToList().AsReadOnly();
      }

      private static Type TryGetGenericTypeDefinition(Type i)
      {
         if (i.IsGenericType && !i.IsGenericTypeDefinition)
            return i.GetGenericTypeDefinition();

         return i;
      }

      private IReadOnlyList<Type> GetTypes(Assembly assembly)
      {
         var types = GetForwardedTypes(assembly)
                     .Concat(assembly.GetTypes())
                     .Where(t => !t.IsEnum && !typeof(Exception).IsAssignableFrom(t))
                     .ToList().AsReadOnly();

         types.Should().NotBeEmpty($"the assembly {assembly.GetName().Name} is empty");

         return types;
      }

      private IReadOnlyList<Type> GetForwardedTypes(Assembly assembly)
      {
         var types = new List<Type>();

         using (var stream = File.OpenRead(assembly.Location))
         using (var peReader = new PEReader(stream))
         {
            var reader = peReader.GetMetadataReader();

            foreach (var exportedType in reader.ExportedTypes)
            {
               var exported = reader.GetExportedType(exportedType);

               if (exported.IsForwarder)
               {
                  var name = reader.GetString(exported.Name);
                  var ns = reader.GetString(exported.Namespace);
                  var type = assembly.GetType($"{ns}.{name}");

                  if (type == null)
                     throw new Exception($"Forwarded type {ns}.{name} not found in assembly {assembly.GetName().Name}");

                  types.Add(type);
               }
            }
         }

         return types;
      }
   }
}
