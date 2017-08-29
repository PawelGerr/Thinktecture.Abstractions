#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;
using JetBrains.Annotations;

namespace Thinktecture.Net.NetworkInformation
{
	/// <summary>
	/// Provides information about a network interface address.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public interface IIPAddressInformation : IAbstraction<IPAddressInformation>
	{
		/// <summary>
		/// Gets the Internet Protocol (IP) address.
		/// </summary>
		[NotNull]
		IIPAddress Address { get; }

		/// <summary>
		/// Gets a Boolean value that indicates whether the Internet Protocol (IP) address is valid to appear in a Domain Name System (DNS) server database.
		/// </summary>
		bool IsDnsEligible { get; }

		/// <summary>
		/// Gets a Boolean value that indicates whether the Internet Protocol (IP) address is transient (a cluster address).
		/// </summary>
		bool IsTransient { get; }
	}
}

#endif
