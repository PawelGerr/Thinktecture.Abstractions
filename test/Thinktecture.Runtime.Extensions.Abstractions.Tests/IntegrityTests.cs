using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Runtime;
using System.Runtime.Versioning;
using System.Security;
using System.Security.Permissions;
using Thinktecture.Diagnostics;
using Thinktecture.Diagnostics.Adapters;
using Xunit;

namespace Thinktecture.Abstractions.Tests
{
   public class IntegrityTests : IntegrityTestsBase
   {
      public IntegrityTests()
         : base("Runtime.Extensions")
      {
         ExcludedTypes.Add(typeof(AssemblyLoadEventArgs));
         ExcludedTypes.Add(typeof(AssemblyLoadEventHandler));

         ExcludedTypes.Add(typeof(MathF));
         ExcludedTypes.Add(typeof(Progress<>));
         ExcludedTypes.Add(typeof(ResolveEventHandler));
         ExcludedTypes.Add(typeof(StringComparer));
         ExcludedTypes.Add(typeof(AppDomain));
         ExcludedTypes.Add(typeof(ApplicationId));
         ExcludedTypes.Add(typeof(ContextBoundObject));
         ExcludedTypes.Add(typeof(ContextStaticAttribute));
         ExcludedTypes.Add(typeof(LoaderOptimizationAttribute));
         ExcludedTypes.Add(typeof(OperatingSystem));
         ExcludedTypes.Add(typeof(StringNormalizationExtensions));
         ExcludedTypes.Add(typeof(SecurityElement));

#pragma warning disable SYSLIB0003
         ExcludedTypes.Add(typeof(CodeAccessSecurityAttribute));
         ExcludedTypes.Add(typeof(SecurityAttribute));
         ExcludedTypes.Add(typeof(SecurityPermissionAttribute));
         ExcludedTypes.Add(typeof(PermissionSet));
#pragma warning restore SYSLIB0003

         ExcludedTypes.Add(typeof(ArrayList));
         ExcludedTypes.Add(typeof(Comparer));
         ExcludedTypes.Add(typeof(Hashtable));
         ExcludedTypes.Add(typeof(FrameworkName));
         ExcludedTypes.Add(typeof(ComponentGuaranteesAttribute));
         ExcludedTypes.Add(typeof(ResourceConsumptionAttribute));
         ExcludedTypes.Add(typeof(ResourceExposureAttribute));
         ExcludedTypes.Add(typeof(VersioningHelper));
         ExcludedTypes.Add(typeof(AssemblyNameProxy));
         ExcludedTypes.Add(typeof(GlobalizationExtensions));

         ExcludedTypes.Add(typeof(BinaryReader));       // IO
         ExcludedTypes.Add(typeof(BinaryWriter));       // IO
         ExcludedTypes.Add(typeof(MemoryStream));       // IO
         ExcludedTypes.Add(typeof(BufferedStream));     // IO
         ExcludedTypes.Add(typeof(IndentedTextWriter)); // IO
         ExcludedTypes.Add(typeof(StreamReader));       // IO
         ExcludedTypes.Add(typeof(StreamWriter));       // IO
         ExcludedTypes.Add(typeof(StringReader));       // IO
         ExcludedTypes.Add(typeof(StringWriter));       // IO
         ExcludedTypes.Add(typeof(TextReader));         // IO
         ExcludedTypes.Add(typeof(TextWriter));         // IO

         ExcludedTypes.Add(typeof(AppDomainSetup));
         ExcludedTypes.Add(typeof(BitOperations));
         ExcludedTypes.Add(typeof(ProfileOptimization));

         CustomTypeMappings.Add(typeof(Stopwatch), new List<Type> { typeof(IStopwatch), typeof(IStopwatchGlobals) });

#pragma warning disable 618
         ExcludeMembers(typeof(Path), nameof(Path.InvalidPathChars)); // deprecated
#pragma warning restore 618

         ExcludeMemberCallback = ExcludeMember;
      }

      private bool ExcludeMember(Type type, Type otherType, MemberInfo member)
      {
         if (otherType == typeof(IStopwatch))
         {
            return member is MethodInfo methodInfo && methodInfo.IsStatic ||
                   member is FieldInfo fieldInfo && fieldInfo.IsStatic;
         }

         if (otherType == typeof(IStopwatchGlobals))
         {
            return member is MethodInfo methodInfo && !methodInfo.IsStatic ||
                   member is PropertyInfo propertyInfo && !propertyInfo.GetMethod.IsStatic ||
                   member is FieldInfo fieldInfo && !fieldInfo.IsStatic;
         }

         if (type == typeof(Environment)
             && member.Name == nameof(Environment.FailFast)
             && member is MethodInfo method && method.GetParameters().Length == 3)
            return true;

         return false;
      }

      [Fact]
      public void Should_contain_all_types()
      {
         CheckTypes();
      }

      [Fact]
      public void Should_contain_all_adapters()
      {
         CheckAdapters();
      }

      [Fact]
      public void Should_contain_all_adapters_constructors()
      {
         CheckConstructors(typeof(StopwatchGlobals));
      }

      [Fact]
      public void Should_contain_all_members()
      {
         CheckMembers();
      }
   }
}
