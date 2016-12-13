#if NETSTANDARD1_3 || NET45 || NET46

using System;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>
	/// Provides information about network interfaces that support Internet Protocol version 4 (IPv4) or Internet Protocol version 6 (IPv6).
	/// </summary>
	public class IPInterfacePropertiesAdapter : AbstractionAdapter, IIPInterfaceProperties
	{
		private readonly IPInterfaceProperties _props;

		/// <inheritdoc />
		public IIPAddressInformationCollection AnycastAddresses => _props.AnycastAddresses.ToInterface();

		/// <inheritdoc />
		public IIPAddressCollection DhcpServerAddresses => _props.DhcpServerAddresses.ToInterface();

		/// <inheritdoc />
		public IIPAddressCollection DnsAddresses => _props.DnsAddresses.ToInterface();

		/// <inheritdoc />
		public string DnsSuffix => _props.DnsSuffix;

		/// <inheritdoc />
		public IGatewayIPAddressInformationCollection GatewayAddresses => _props.GatewayAddresses.ToInterface();

		/// <inheritdoc />
		public bool IsDnsEnabled => _props.IsDnsEnabled;

		/// <inheritdoc />
		public bool IsDynamicDnsEnabled => _props.IsDynamicDnsEnabled;

		/// <inheritdoc />
		public IMulticastIPAddressInformationCollection MulticastAddresses => _props.MulticastAddresses.ToInterface();

		/// <inheritdoc />
		public IUnicastIPAddressInformationCollection UnicastAddresses => _props.UnicastAddresses.ToInterface();

		/// <inheritdoc />
		public IIPAddressCollection WinsServersAddresses => _props.WinsServersAddresses.ToInterface();

		/// <summary>
		/// Initializes new instance of <see cref="IPInterfacePropertiesAdapter"/>.
		/// </summary>
		/// <param name="props">Properties to be used by the adapter.</param>
		public IPInterfacePropertiesAdapter(IPInterfaceProperties props) 
			: base(props)
		{
			if (props == null)
				throw new ArgumentNullException(nameof(props));

			_props = props;
		}

		/// <inheritdoc />
		public IIPv4InterfaceProperties GetIPv4Properties()
		{
			return _props.GetIPv4Properties().ToInterface();
		}

		/// <inheritdoc />
		public IIPv6InterfaceProperties GetIPv6Properties()
		{
			return _props.GetIPv6Properties().ToInterface();
		}

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new IPInterfaceProperties UnsafeConvert()
		{
			return _props;
		}
	}
}

#endif