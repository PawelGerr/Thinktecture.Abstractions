#if NETSTANDARD1_3 || NET45 || NET46

using System;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>Provides configuration and statistical information for a network interface.</summary>
	public class NetworkInterfaceAdapter : AbstractionAdapter, INetworkInterface
	{
		private readonly NetworkInterface _nic;

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
		public string Id => _nic.Id;

		/// <inheritdoc />
		public string Name => _nic.Name;

		/// <inheritdoc />
		public string Description => _nic.Description;

		/// <inheritdoc />
		public OperationalStatus OperationalStatus => _nic.OperationalStatus;

		/// <inheritdoc />
		public long Speed => _nic.Speed;

		/// <inheritdoc />
		public bool IsReceiveOnly => _nic.IsReceiveOnly;

		/// <inheritdoc />
		public bool SupportsMulticast => _nic.SupportsMulticast;

		/// <inheritdoc />
		public NetworkInterfaceType NetworkInterfaceType => _nic.NetworkInterfaceType;

		/// <summary>Initializes a new instance of the <see cref="NetworkInterfaceAdapter" /> class.</summary>
		/// <param name="nic">Network interface to be used by the adapter.</param>
		public NetworkInterfaceAdapter(NetworkInterface nic)
			: base(nic)
		{
			if (nic == null)
				throw new ArgumentNullException(nameof(nic));

			_nic = nic;
		}

		/// <inheritdoc />
		public IIPInterfaceProperties GetIPProperties()
		{
			return _nic.GetIPProperties().ToInterface();
		}

		/// <inheritdoc />
		public IIPInterfaceStatistics GetIPStatistics()
		{
			return _nic.GetIPStatistics().ToInterface();
		}

		/// <inheritdoc />
		public IPhysicalAddress GetPhysicalAddress()
		{
			return _nic.GetPhysicalAddress().ToInterface();
		}

		/// <inheritdoc />
		public bool Supports(NetworkInterfaceComponent networkInterfaceComponent)
		{
			return _nic.Supports(networkInterfaceComponent);
		}

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new NetworkInterface UnsafeConvert()
		{
			return _nic;
		}
	}
}

#endif