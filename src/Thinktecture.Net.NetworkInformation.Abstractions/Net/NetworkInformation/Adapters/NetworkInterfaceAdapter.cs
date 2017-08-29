#if NETSTANDARD1_3 || NET45 || NET46

using System;
using System.Net.NetworkInformation;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>Provides configuration and statistical information for a network interface.</summary>
	public class NetworkInterfaceAdapter : AbstractionAdapter<NetworkInterface>, INetworkInterface
	{
		/// <summary>Gets the index of the IPv4 loopback interface.</summary>
		/// <returns>A <see cref="T:System.Int32" /> that contains the index for the IPv4 loopback interface.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">This property is not valid on computers running only Ipv6.</exception>
		public static int LoopbackInterfaceIndex => NetworkInterface.LoopbackInterfaceIndex;

		/// <summary>Gets the index of the IPv6 loopback interface.</summary>
		/// <returns>Returns <see cref="T:System.Int32" />.The index for the IPv6 loopback interface.</returns>
		// ReSharper disable once InconsistentNaming
		public static int IPv6LoopbackInterfaceIndex => NetworkInterface.IPv6LoopbackInterfaceIndex;

		/// <summary>Returns objects that describe the network interfaces on the local computer.</summary>
		/// <returns>A <see cref="T:System.Net.NetworkInformation.NetworkInterface" /> array that contains objects that describe the available network interfaces, or an empty array if no interfaces are detected.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">A Windows system function call failed. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Net.NetworkInformation.NetworkInformationPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Access="Read" />
		/// </PermissionSet>
		[NotNull]
		public static INetworkInterface[] GetAllNetworkInterfaces()
		{
			return NetworkInterface.GetAllNetworkInterfaces().ToInterface();
		}

		/// <summary>Indicates whether any network connection is available.</summary>
		/// <returns>true if a network connection is available; otherwise, false.</returns>
		public static bool GetIsNetworkAvailable()
		{
			return NetworkInterface.GetIsNetworkAvailable();
		}

		/// <inheritdoc />
		public string Id => Implementation.Id;

		/// <inheritdoc />
		public string Name => Implementation.Name;

		/// <inheritdoc />
		public string Description => Implementation.Description;

		/// <inheritdoc />
		public OperationalStatus OperationalStatus => Implementation.OperationalStatus;

		/// <inheritdoc />
		public long Speed => Implementation.Speed;

		/// <inheritdoc />
		public bool IsReceiveOnly => Implementation.IsReceiveOnly;

		/// <inheritdoc />
		public bool SupportsMulticast => Implementation.SupportsMulticast;

		/// <inheritdoc />
		public NetworkInterfaceType NetworkInterfaceType => Implementation.NetworkInterfaceType;

		/// <summary>Initializes a new instance of the <see cref="NetworkInterfaceAdapter" /> class.</summary>
		/// <param name="nic">Network interface to be used by the adapter.</param>
		public NetworkInterfaceAdapter([NotNull] NetworkInterface nic)
			: base(nic)
		{
		}

		/// <inheritdoc />
		public IIPInterfaceProperties GetIPProperties()
		{
			return Implementation.GetIPProperties().ToInterface();
		}

		/// <inheritdoc />
		public IIPInterfaceStatistics GetIPStatistics()
		{
			return Implementation.GetIPStatistics().ToInterface();
		}

		/// <inheritdoc />
		public IPhysicalAddress GetPhysicalAddress()
		{
			return Implementation.GetPhysicalAddress().ToInterface();
		}

		/// <inheritdoc />
		public bool Supports(NetworkInterfaceComponent networkInterfaceComponent)
		{
			return Implementation.Supports(networkInterfaceComponent);
		}
	}
}

#endif
