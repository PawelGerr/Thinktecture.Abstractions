#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;
using JetBrains.Annotations;

namespace Thinktecture.Net.NetworkInformation
{
	/// <summary>
	/// Provides information about a network interface's unicast address.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface IUnicastIPAddressInformation : IIPAddressInformation, IAbstraction<UnicastIPAddressInformation>
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
		/// Gets the IPv4 mask.
		/// </summary>
		[NotNull]
		// ReSharper disable once InconsistentNaming
		IIPAddress IPv4Mask { get; }

		/// <summary>
		/// Gets the length, in bits, of the prefix or network part of the IP address.
		/// </summary>
		int PrefixLength { get; }

		/// <summary>
		/// Gets a value that identifies the source of a unicast Internet Protocol (IP) address prefix.
		/// </summary>
		PrefixOrigin PrefixOrigin { get; }

		/// <summary>
		/// Gets a value that identifies the source of a unicast Internet Protocol (IP) address suffix.
		/// </summary>
		SuffixOrigin SuffixOrigin { get; }
	}
}

#endif
