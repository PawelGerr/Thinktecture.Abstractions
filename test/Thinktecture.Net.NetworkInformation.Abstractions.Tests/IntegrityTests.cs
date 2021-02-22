using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Reflection;
using Thinktecture.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation.Adapters;
using Xunit;

namespace Thinktecture.Abstractions.Tests
{
   public class IntegrityTests : IntegrityTestsBase
   {
      public IntegrityTests()
         : base("Net.NetworkInformation")
      {
         ExcludedTypes.Add(typeof(IcmpV4Statistics));         // abstract class
         ExcludedTypes.Add(typeof(IcmpV6Statistics));         // abstract class
         ExcludedTypes.Add(typeof(IPGlobalProperties));       // abstract class
         ExcludedTypes.Add(typeof(IPGlobalStatistics));       // abstract class
         ExcludedTypes.Add(typeof(IPv4InterfaceStatistics));  // abstract class
         ExcludedTypes.Add(typeof(TcpConnectionInformation)); // abstract class
         ExcludedTypes.Add(typeof(TcpStatistics));            // abstract class
         ExcludedTypes.Add(typeof(UdpStatistics));            // abstract class

         ExcludedTypes.Add(typeof(NetworkInformationException));

         CustomTypeMappings.Add(typeof(NetworkAddressChangedEventHandler), typeof(EventHandler));
         CustomTypeMappings.Add(typeof(NetworkAvailabilityChangedEventHandler), typeof(EventHandler<INetworkAvailabilityEventArgs>));

         CustomTypeMappings.Add(typeof(NetworkInterface), new List<Type> { typeof(INetworkInterface), typeof(INetworkInterfaceGlobals) });
         CustomTypeMappings.Add(typeof(PhysicalAddress), new List<Type> { typeof(IPhysicalAddress), typeof(IPhysicalAddressGlobals) });

         ExcludeMember<EventArgs>(nameof(EventArgs.Empty));
         ExcludeMember<NetworkChange>("RegisterNetworkChange"); // deprecated

         ExcludeMemberCallback = ExcludeMember;
      }

      private bool ExcludeMember(Type type, Type otherType, MemberInfo memberInfo)
      {
         // is in INetworkInterfaceGlobals
         if (memberInfo.Name == nameof(NetworkInterface.GetAllNetworkInterfaces) ||
             memberInfo.Name == nameof(NetworkInterface.GetIsNetworkAvailable) ||
             memberInfo.Name == nameof(NetworkInterface.LoopbackInterfaceIndex) ||
             memberInfo.Name == nameof(NetworkInterface.IPv6LoopbackInterfaceIndex))
         {
            return type == typeof(NetworkInterface) && otherType == typeof(INetworkInterface);
         }

         // is in INetworkInterface
         if (type == typeof(NetworkInterface) && otherType == typeof(INetworkInterfaceGlobals))
         {
            return memberInfo is MethodInfo methodInfo && !methodInfo.IsStatic ||
                   memberInfo is PropertyInfo propertyInfo && !propertyInfo.GetMethod.IsStatic;
         }

         // is in IPhysicalAddressGlobals
         if (memberInfo.Name == nameof(PhysicalAddress.Parse) ||
#if NET5_0
             memberInfo.Name == nameof(PhysicalAddress.TryParse) ||
#endif
             memberInfo.Name == nameof(PhysicalAddress.None))
         {
            return type == typeof(PhysicalAddress) && otherType == typeof(IPhysicalAddress);
         }

         // is in IPhysicalAddress
         if (type == typeof(PhysicalAddress) && otherType == typeof(IPhysicalAddressGlobals))
         {
            return memberInfo is MethodInfo methodInfo && !methodInfo.IsStatic;
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
         CheckConstructors(typeof(NetworkChange), typeof(NetworkInterfaceGlobals), typeof(PhysicalAddressGlobals));
      }

      [Fact]
      public void Should_contain_all_members()
      {
         CheckMembers();
      }
   }
}
