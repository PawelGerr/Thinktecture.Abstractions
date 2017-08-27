#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;

namespace Thinktecture.Net.NetworkInformation
{
	/// <summary>
	/// Provides information about network interfaces that support Internet Protocol version 6 (IPv6).
	/// </summary>
	public interface IIPv6InterfaceProperties : IAbstraction<IPv6InterfaceProperties>
	{
		/// <summary>
		/// Gets the index of the network interface associated with an Internet Protocol version 6 (IPv6) address.
		/// </summary>
		int Index { get; }

		/// <summary>
		/// Gets the maximum transmission unit (MTU) for this network interface.
		/// </summary>
		int Mtu { get; }

		/// <summary>
		/// Gets the scope ID of the network interface associated with an Internet Protocol version 6 (IPv6) address.
		/// </summary>
		/// <param name="scopeLevel">The scope level.</param>
		/// <returns>The scope ID of the network interface associated with an IPv6 address.</returns>
		long GetScopeId(ScopeLevel scopeLevel);
	}
}

#endif
