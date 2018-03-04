using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FluentAssertions;

namespace Thinktecture
{
	public abstract class IntegrityTestsBase
	{
		private readonly IReadOnlyList<Type> _originalTypes;
		private readonly IReadOnlyList<Type> _abstractionTypes;

		protected Dictionary<Type, Type> CustomMappings { get; }
		protected List<Type> ExcludedTypes { get; }
		protected List<MemberInfo> ExcludedMembers { get; }

		protected IntegrityTestsBase(Type candidateFromOriginalAssembly, Type candidateFromAbstractions)
			: this(candidateFromOriginalAssembly.GetTypeInfo().Assembly, candidateFromAbstractions.GetTypeInfo().Assembly)
		{
		}

		protected IntegrityTestsBase(Assembly originalAssembly, Type candidateFromAbstractions)
			: this(originalAssembly, candidateFromAbstractions.GetTypeInfo().Assembly)
		{
		}

		protected IntegrityTestsBase(Assembly orignalAssembly, Assembly abstractionsAssembly)
		{
			_originalTypes = GetTypes(orignalAssembly);
			_abstractionTypes = GetTypes(abstractionsAssembly);

			CustomMappings = new Dictionary<Type, Type>();
			ExcludedTypes = new List<Type>();
			ExcludedMembers = new List<MemberInfo>();
		}


		protected void ExcludeStaticMember<T>(string name)
		{
			var members = typeof(T).GetMember(name, BindingFlags.Static | BindingFlags.Public);

			members.Should().HaveCount(1, $"static member \"{name}\" of type {typeof(T).FullName} should exist only once");

			ExcludedMembers.Add(members[0]);
		}


		protected void ExcludeStaticMembers(Type type, string name)
		{
			var members = type.GetMember(name, BindingFlags.Static | BindingFlags.Public);

			members.Should().HaveCountGreaterOrEqualTo(1, $"static member \"{name}\" of type {type.FullName} not found");

			ExcludedMembers.AddRange(members);
		}

		protected static Assembly GetAssembly(string name)
		{
			var assemblies = AppDomain.CurrentDomain.GetAssemblies();
			var assembly = assemblies.FirstOrDefault(a => a.GetName().Name == name);

			if (assembly == null)
				throw new ArgumentException($"Assembly with then name {name} not found.");

			return assembly;
		}

		protected void CheckTypes()
		{
			var types = _originalTypes
			            .Where(t => !ExcludedTypes.Contains(t))
			            .ToList();

			foreach (var t in GetTypes())
			{
				t.Abstraction.Should().NotBeNull($"abstraction for type {t.Original.FullName} not found");

				types.Remove(t.Original);
			}

			types.Should().BeEmpty();
		}

		protected void CheckMembers()
		{
			foreach (var types in GetTypes().Where(t => t.Abstraction != null))
			{
				var originalMembers = GetMembers(types.Original);
				var abstractionMembers = GetMembers(types.Abstraction);

				foreach (var group in originalMembers.GroupBy(m => m.Name))
				{
					var members = abstractionMembers.Where(m => m.Name == group.Key).ToList();

					members.Should().HaveCountGreaterOrEqualTo(group.Count(), $"the type {types.Abstraction.FullName} should have {group.Count()} member(s) with the name \"{group.Key}\"");
				}
			}
		}

		private IReadOnlyList<MemberInfo> GetMembers(Type type)
		{
			if (type == null)
				throw new ArgumentNullException(nameof(type));

			var members = GetAllMembers(type);

			return members
			       .Where(m =>
			       {
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

			do
			{
				if (type != typeof(MarshalByRefObject))
					AddMembers(allMembers, type);

				type = type.BaseType;
			} while (type != null && type != typeof(object));

			return allMembers;
		}

		private void AddMembers(List<MemberInfo> allMembers, Type type)
		{
			var members = type.GetMembers(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly)
			                  .Where(m => !ExcludedMembers.Contains(m) && !(m is ConstructorInfo))
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
				if (ExcludedTypes.Contains(originalType))
					continue;

				if (!CustomMappings.TryGetValue(originalType, out var abstractionType))
				{
					var abstractionTypeName = BuildAbstractionTypeName(originalType);
					abstractionType = _abstractionTypes.FirstOrDefault(t => t.FullName == abstractionTypeName);
				}

				yield return (originalType, abstractionType);
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

		private IReadOnlyList<Type> GetTypes(Assembly assembly)
		{
			return assembly
			       .GetTypes()
			       .Where(t => t.IsPublic && !t.IsEnum)
			       .ToList().AsReadOnly();
		}
	}
}
