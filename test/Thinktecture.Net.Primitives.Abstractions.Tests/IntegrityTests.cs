using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using Thinktecture.Net;
using Thinktecture.Net.Adapters;
using Xunit;

namespace Thinktecture.Abstractions.Tests
{
   public class IntegrityTests : IntegrityTestsBase
   {
      public IntegrityTests()
         : base("Net.Primitives")
      {
         ExcludedTypes.Add(typeof(CookieException));
         ExcludedTypes.Add(typeof(SocketException));

         ExcludedTypes.Add(typeof(HttpVersion));

         ExcludedTypes.Add(Type.GetType("System.Net.PathList, System.Net.Primitives, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")); // exists in netcoreapp only

         CustomTypeMappings.Add(typeof(IPAddress), new List<Type> { typeof(IIPAddress), typeof(IIPAddressGlobals) });
         CustomTypeMappings.Add(typeof(IPEndPoint), new List<Type> { typeof(IIPEndPoint), typeof(IIPEndPointGlobals) });

         ExcludeMember<CookieContainer>(nameof(CookieContainer.DefaultCookieLimit));
         ExcludeMember<CookieContainer>(nameof(CookieContainer.DefaultPerDomainCookieLimit));
         ExcludeMember<CookieContainer>(nameof(CookieContainer.DefaultCookieLengthLimit));

         ExcludeMember<CredentialCache>(nameof(CredentialCache.DefaultCredentials));
         ExcludeMember<CredentialCache>(nameof(CredentialCache.DefaultNetworkCredentials));

         ExcludeMember<IPEndPoint>(nameof(IPEndPoint.MinPort));
         ExcludeMember<IPEndPoint>(nameof(IPEndPoint.MaxPort));

#pragma warning disable 618
         ExcludeMember<IPAddress>(nameof(IPAddress.Address)); // deprecated
#pragma warning restore 618

         ExcludeMemberCallback = Exclude;
      }

      private bool Exclude(Type type, Type otherType, MemberInfo member)
      {
         if (type == typeof(IPAddress) && otherType == typeof(IIPAddress))
         {
            return member is MethodInfo methodInfo && methodInfo.IsStatic ||
                   member is FieldInfo fieldInfo && fieldInfo.IsStatic;
         }

         if (type == typeof(IPAddress) && otherType == typeof(IIPAddressGlobals))
         {
            return member is MethodInfo methodInfo && !methodInfo.IsStatic ||
                   member is FieldInfo fieldInfo && !fieldInfo.IsStatic ||
                   member is PropertyInfo propInfo && !propInfo.GetMethod.IsStatic;
         }

         if (type == typeof(IPEndPoint) && otherType == typeof(IIPEndPoint))
         {
            return member is MethodInfo methodInfo && methodInfo.IsStatic ||
                   member is FieldInfo fieldInfo && fieldInfo.IsStatic;
         }

         if (type == typeof(IPEndPoint) && otherType == typeof(IIPEndPointGlobals))
         {
            return member is MethodInfo methodInfo && !methodInfo.IsStatic ||
                   member is FieldInfo fieldInfo && !fieldInfo.IsStatic ||
                   member is PropertyInfo propInfo && !propInfo.GetMethod.IsStatic;
         }

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
         CheckConstructors(typeof(IPAddressGlobals), IIPEndPointGlobals.Instance.GetType());
      }

      [Fact]
      public void Should_contain_all_members()
      {
         CheckMembers();
      }
   }
}
