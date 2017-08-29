#if NETSTANDARD1_3 || NET45 || NET46

using System;
using System.Net.NetworkInformation;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>
	/// Provides information about network interfaces that support Internet Protocol version 4 (IPv4) or Internet Protocol version 6 (IPv6).
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public class IPInterfacePropertiesAdapter : AbstractionAdapter<IPInterfaceProperties>, IIPInterfaceProperties
	{
		/// <inheritdoc />
		public IIPAddressInformationCollection AnycastAddresses => Implementation.AnycastAddresses.ToInterface();

		/// <inheritdoc />
		public IIPAddressCollection DhcpServerAddresses => Implementation.DhcpServerAddresses.ToInterface();

		/// <inheritdoc />
		public IIPAddressCollection DnsAddresses => Implementation.DnsAddresses.ToInterface();

		/// <inheritdoc />
		public string DnsSuffix => Implementation.DnsSuffix;

		/// <inheritdoc />
		public IGatewayIPAddressInformationCollection GatewayAddresses => Implementation.GatewayAddresses.ToInterface();

		/// <inheritdoc />
		public bool IsDnsEnabled => Implementation.IsDnsEnabled;

		/// <inheritdoc />
		public bool IsDynamicDnsEnabled => Implementation.IsDynamicDnsEnabled;

		/// <inheritdoc />
		public IMulticastIPAddressInformationCollection MulticastAddresses => Implementation.MulticastAddresses.ToInterface();

		/// <inheritdoc />
		public IUnicastIPAddressInformationCollection UnicastAddresses => Implementation.UnicastAddresses.ToInterface();

		/// <inheritdoc />
		public IIPAddressCollection WinsServersAddresses => Implementation.WinsServersAddresses.ToInterface();

		/// <summary>
		/// Initializes new instance of <see cref="IPInterfacePropertiesAdapter"/>.
		/// </summary>
		/// <param name="props">Properties to be used by the adapter.</param>
		public IPInterfacePropertiesAdapter([NotNull] IPInterfaceProperties props)
			: base(props)
		{
		}

		/// <inheritdoc />
		public IIPv4InterfaceProperties GetIPv4Properties()
		{
			return Implementation.GetIPv4Properties().ToInterface();
		}

		/// <inheritdoc />
		public IIPv6InterfaceProperties GetIPv6Properties()
		{
			return Implementation.GetIPv6Properties().ToInterface();
		}
	}
}

#endif
