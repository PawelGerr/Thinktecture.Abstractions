#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;

namespace Thinktecture.Net.NetworkInformation
{
	/// <summary>
	/// Provides information about network interfaces that support Internet Protocol version 4 (IPv4).
	/// </summary>
	public interface IIPv4InterfaceProperties : IAbstraction<IPv4InterfaceProperties>
	{
		/// <summary>
		/// Gets the index of the network interface associated with the Internet Protocol version 4 (IPv4) address.
		/// </summary>
		int Index { get; }

		/// <summary>
		/// Gets a Boolean value that indicates whether this interface has an automatic private IP addressing (APIPA) address.
		/// </summary>
		bool IsAutomaticPrivateAddressingActive { get; }

		/// <summary>
		/// Gets a Boolean value that indicates whether this interface has automatic private IP addressing (APIPA) enabled.
		/// </summary>
		bool IsAutomaticPrivateAddressingEnabled { get; }

		/// <summary>
		/// Gets a Boolean value that indicates whether the interface is configured to use a Dynamic Host Configuration Protocol (DHCP) server to obtain an IP address.
		/// </summary>
		bool IsDhcpEnabled { get; }

		/// <summary>
		/// Gets a Boolean value that indicates whether this interface can forward (route) packets.
		/// </summary>
		bool IsForwardingEnabled { get; }

		/// <summary>
		/// Gets the maximum transmission unit (MTU) for this network interface.
		/// </summary>
		int Mtu { get; }

		/// <summary>
		/// Gets a Boolean value that indicates whether an interface uses Windows Internet Name Service (WINS).
		/// </summary>
		bool UsesWins { get; }
	}
}

#endif
