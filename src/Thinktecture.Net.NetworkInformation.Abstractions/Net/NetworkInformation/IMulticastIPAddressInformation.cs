#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;

namespace Thinktecture.Net.NetworkInformation
{
	/// <summary>
	/// Provides information about a network interface's multicast address.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface IMulticastIPAddressInformation : IIPAddressInformation, IAbstraction<MulticastIPAddressInformation>
	{
		/// <summary>
		/// Gets the number of seconds remaining during which this address is the preferred address.
		/// </summary>
		long AddressPreferredLifetime { get; }

		/// <summary>
		/// Gets the number of seconds remaining during which this address is valid.
		/// </summary>
		long AddressValidLifetime { get; }

		/// <summary>
		/// Specifies the amount of time remaining on the Dynamic Host Configuration Protocol (DHCP) lease for this IP address.
		/// </summary>
		long DhcpLeaseLifetime { get; }

		/// <summary>
		/// Gets a value that indicates the state of the duplicate address detection algorithm.
		/// </summary>
		DuplicateAddressDetectionState DuplicateAddressDetectionState { get; }

		/// <summary>
		/// Gets a value that identifies the source of a Multicast Internet Protocol (IP) address prefix.
		/// </summary>
		PrefixOrigin PrefixOrigin { get; }

		/// <summary>
		/// Gets a value that identifies the source of a Multicast Internet Protocol (IP) address suffix.
		/// </summary>
		SuffixOrigin SuffixOrigin { get; }
	}
}

#endif
