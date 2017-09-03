#if NETSTANDARD1_3 || NET45

using System.Net;
using System.Net.Sockets;
using JetBrains.Annotations;

namespace Thinktecture.Net
{
	/// <summary>Provides an Internet Protocol (IP) address.</summary>
	// ReSharper disable once InconsistentNaming
	public interface IIPAddress : IAbstraction<IPAddress>
	{
		/// <summary>Gets the address family of the IP address.</summary>
		/// <returns>Returns <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> for IPv4 or <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> for IPv6.</returns>
		AddressFamily AddressFamily { get; }

		/// <summary>Gets whether the IP address is an IPv4-mapped IPv6 address.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the IP address is an IPv4-mapped IPv6 address; otherwise, false.</returns>
		bool IsIPv4MappedToIPv6 { get; }

		/// <summary>Gets whether the address is an IPv6 link local address.</summary>
		/// <returns>true if the IP address is an IPv6 link local address; otherwise, false.</returns>
		bool IsIPv6LinkLocal { get; }

		/// <summary>Gets whether the address is an IPv6 multicast global address.</summary>
		/// <returns>true if the IP address is an IPv6 multicast global address; otherwise, false.</returns>
		bool IsIPv6Multicast { get; }

		/// <summary>Gets whether the address is an IPv6 site local address.</summary>
		/// <returns>true if the IP address is an IPv6 site local address; otherwise, false.</returns>
		bool IsIPv6SiteLocal { get; }

		/// <summary>Gets whether the address is an IPv6 Teredo address.</summary>
		/// <returns>true if the IP address is an IPv6 Teredo address; otherwise, false.</returns>
		bool IsIPv6Teredo { get; }

		/// <summary>Gets or sets the IPv6 address scope identifier.</summary>
		/// <returns>A long integer that specifies the scope of the address.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">AddressFamily = InterNetwork. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <see name="ScopeId" /> &lt; 0- or -<see name="ScopeId" /> &gt; 0x00000000FFFFFFFF  </exception>
		long ScopeId { get; set; }

		/// <summary>Provides a copy of the <see cref="T:System.Net.IPAddress" /> as an array of bytes.</summary>
		/// <returns>A <see cref="T:System.Byte" /> array.</returns>
		[NotNull]
		byte[] GetAddressBytes();

		/// <summary>Maps the <see cref="T:System.Net.IPAddress" /> object to an IPv4 address.</summary>
		/// <returns>Returns <see cref="T:System.Net.IPAddress" />.An IPv4 address.</returns>
		[NotNull]
		IIPAddress MapToIPv4();

		/// <summary>Maps the <see cref="T:System.Net.IPAddress" /> object to an IPv6 address.</summary>
		/// <returns>Returns <see cref="T:System.Net.IPAddress" />.An IPv6 address.</returns>
		[NotNull]
		IIPAddress MapToIPv6();
	}
}

#endif
