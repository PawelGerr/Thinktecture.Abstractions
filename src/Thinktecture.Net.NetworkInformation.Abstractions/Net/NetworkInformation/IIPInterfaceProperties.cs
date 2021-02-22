using System.Net.NetworkInformation;
namespace Thinktecture.Net.NetworkInformation
{
	/// <summary>
	/// Provides information about network interfaces that support Internet Protocol version 4 (IPv4) or Internet Protocol version 6 (IPv6).
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public interface IIPInterfaceProperties : IAbstraction<IPInterfaceProperties>
	{
		/// <summary>
		/// Gets the anycast IP addresses assigned to this interface.
		/// </summary>
		IIPAddressInformationCollection AnycastAddresses { get; }

		/// <summary>
		/// Gets the addresses of Dynamic Host Configuration Protocol (DHCP) servers for this interface.
		/// </summary>
		IIPAddressCollection DhcpServerAddresses { get; }

		/// <summary>
		/// Gets the addresses of Domain Name System (DNS) servers for this interface.
		/// </summary>
		IIPAddressCollection DnsAddresses { get; }

		/// <summary>
		/// Gets the Domain Name System (DNS) suffix associated with this interface.
		/// </summary>
		string DnsSuffix { get; }

		/// <summary>
		/// Gets the IPv4 network gateway addresses for this interface.
		/// </summary>
		IGatewayIPAddressInformationCollection GatewayAddresses { get; }

		/// <summary>
		/// Gets a Boolean value that indicates whether NetBt is configured to use DNS name resolution on this interface.
		/// </summary>
		bool IsDnsEnabled { get; }

		/// <summary>
		/// Gets a Boolean value that indicates whether this interface is configured to automatically register its IP address information with the Domain Name System (DNS).
		/// </summary>
		bool IsDynamicDnsEnabled { get; }

		/// <summary>
		/// Gets the multicast addresses assigned to this interface.
		/// </summary>
		IMulticastIPAddressInformationCollection MulticastAddresses { get; }

		/// <summary>
		/// Gets the unicast addresses assigned to this interface.
		/// </summary>
		IUnicastIPAddressInformationCollection UnicastAddresses { get; }

		/// <summary>
		/// Gets the addresses of Windows Internet Name Service (WINS) servers.
		/// </summary>
		IIPAddressCollection WinsServersAddresses { get; }

		/// <summary>
		/// Provides Internet Protocol version 4 (IPv4) configuration data for this network interface.
		/// </summary>
		/// <returns>An IPv4InterfaceProperties object that contains IPv4 configuration data, or null if no data is available for the interface.</returns>
		IIPv4InterfaceProperties GetIPv4Properties();

		/// <summary>
		/// Provides Internet Protocol version 6 (IPv6) configuration data for this network interface.
		/// </summary>
		/// <returns>An IPv6InterfaceProperties object that contains IPv6 configuration data.</returns>
		IIPv6InterfaceProperties GetIPv6Properties();
	}
}
