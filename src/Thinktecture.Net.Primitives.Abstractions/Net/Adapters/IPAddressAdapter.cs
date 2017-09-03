#if NETSTANDARD1_3 || NET45

using System;
using System.Net;
using System.Net.Sockets;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.Adapters
{
	/// <summary>Provides an Internet Protocol (IP) address.</summary>
	// ReSharper disable once InconsistentNaming
	public class IPAddressAdapter : AbstractionAdapter<IPAddress>, IIPAddress
	{
		/// <summary>Provides an IP address that indicates that the server must listen for client activity on all network interfaces. This field is read-only.</summary>
		public static readonly IIPAddress Any = new IPAddressAdapter(IPAddress.Any);

		/// <summary>Provides the IP broadcast address. This field is read-only.</summary>
		public static readonly IIPAddress Broadcast = new IPAddressAdapter(IPAddress.Broadcast);

		/// <summary>The <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" /> method uses the <see cref="F:System.Net.IPAddress.IPv6Any" /> field to indicate that a <see cref="T:System.Net.Sockets.Socket" /> must listen for client activity on all network interfaces.</summary>
		// ReSharper disable once InconsistentNaming
		public static readonly IIPAddress IPv6Any = new IPAddressAdapter(IPAddress.IPv6Any);

		/// <summary>Provides the IP loopback address. This property is read-only.</summary>
		// ReSharper disable once InconsistentNaming
		public static readonly IIPAddress IPv6Loopback = new IPAddressAdapter(IPAddress.IPv6Loopback);

		/// <summary>Provides an IP address that indicates that no network interface should be used. This property is read-only.</summary>
		// ReSharper disable once InconsistentNaming
		public static readonly IIPAddress IPv6None = new IPAddressAdapter(IPAddress.IPv6None);

		/// <summary>Provides the IP loopback address. This field is read-only.</summary>
		public static readonly IIPAddress Loopback = new IPAddressAdapter(IPAddress.Loopback);

		/// <summary>Provides an IP address that indicates that no network interface should be used. This field is read-only.</summary>
		public static readonly IIPAddress None = new IPAddressAdapter(IPAddress.None);

		/// <summary>Converts a short value from host byte order to network byte order.</summary>
		/// <returns>A short value, expressed in network byte order.</returns>
		/// <param name="host">The number to convert, expressed in host byte order. </param>
		public static short HostToNetworkOrder(short host)
		{
			return IPAddress.HostToNetworkOrder(host);
		}

		/// <summary>Converts an integer value from host byte order to network byte order.</summary>
		/// <returns>An integer value, expressed in network byte order.</returns>
		/// <param name="host">The number to convert, expressed in host byte order. </param>
		public static int HostToNetworkOrder(int host)
		{
			return IPAddress.HostToNetworkOrder(host);
		}

		/// <summary>Converts a long value from host byte order to network byte order.</summary>
		/// <returns>A long value, expressed in network byte order.</returns>
		/// <param name="host">The number to convert, expressed in host byte order. </param>
		public static long HostToNetworkOrder(long host)
		{
			return IPAddress.HostToNetworkOrder(host);
		}

		/// <summary>Indicates whether the specified IP address is the loopback address.</summary>
		/// <returns>true if <paramref name="address" /> is the loopback address; otherwise, false.</returns>
		/// <param name="address">An IP address. </param>
		public static bool IsLoopback([NotNull] IPAddress address)
		{
			return IPAddress.IsLoopback(address);
		}

		/// <summary>Converts a short value from network byte order to host byte order.</summary>
		/// <returns>A short value, expressed in host byte order.</returns>
		/// <param name="network">The number to convert, expressed in network byte order. </param>
		public static short NetworkToHostOrder(short network)
		{
			return IPAddress.NetworkToHostOrder(network);
		}

		/// <summary>Converts an integer value from network byte order to host byte order.</summary>
		/// <returns>An integer value, expressed in host byte order.</returns>
		/// <param name="network">The number to convert, expressed in network byte order. </param>
		public static int NetworkToHostOrder(int network)
		{
			return IPAddress.NetworkToHostOrder(network);
		}

		/// <summary>Converts a long value from network byte order to host byte order.</summary>
		/// <returns>A long value, expressed in host byte order.</returns>
		/// <param name="network">The number to convert, expressed in network byte order. </param>
		public static long NetworkToHostOrder(long network)
		{
			return IPAddress.NetworkToHostOrder(network);
		}

		/// <summary>Converts an IP address string to an <see cref="T:System.Net.IPAddress" /> instance.</summary>
		/// <returns>An <see cref="T:System.Net.IPAddress" /> instance.</returns>
		/// <param name="ipString">A string that contains an IP address in dotted-quad notation for IPv4 and in colon-hexadecimal notation for IPv6. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="ipString" /> is null. </exception>
		/// <exception cref="T:System.FormatException">
		/// <paramref name="ipString" /> is not a valid IP address. </exception>
		[NotNull]
		public static IIPAddress Parse([NotNull] string ipString)
		{
			return IPAddress.Parse(ipString).ToInterface();
		}

		/// <summary>Determines whether a string is a valid IP address.</summary>
		/// <returns>true if <paramref name="ipString" /> is a valid IP address; otherwise, false.</returns>
		/// <param name="ipString">The string to validate.</param>
		/// <param name="address">The <see cref="T:System.Net.IPAddress" /> version of the string.</param>
		public static bool TryParse([CanBeNull] string ipString, [CanBeNull] out IPAddress address)
		{
			return IPAddress.TryParse(ipString, out address);
		}

		/// <summary>Determines whether a string is a valid IP address.</summary>
		/// <returns>true if <paramref name="ipString" /> is a valid IP address; otherwise, false.</returns>
		/// <param name="ipString">The string to validate.</param>
		/// <param name="address">The <see cref="T:System.Net.IPAddress" /> version of the string.</param>
		public static bool TryParse([NotNull] string ipString, [CanBeNull] out IIPAddress address)
		{
			var parsed = IPAddress.TryParse(ipString, out var tempAddress);
			address = tempAddress.ToInterface();

			return parsed;
		}

		/// <inheritdoc />
		public AddressFamily AddressFamily => Implementation.AddressFamily;

		/// <inheritdoc />
		public bool IsIPv4MappedToIPv6 => Implementation.IsIPv4MappedToIPv6;

		/// <inheritdoc />
		public bool IsIPv6LinkLocal => Implementation.IsIPv6LinkLocal;

		/// <inheritdoc />
		public bool IsIPv6Multicast => Implementation.IsIPv6Multicast;

		/// <inheritdoc />
		public bool IsIPv6SiteLocal => Implementation.IsIPv6SiteLocal;

		/// <inheritdoc />
		public bool IsIPv6Teredo => Implementation.IsIPv6Teredo;

		/// <inheritdoc />
		public long ScopeId
		{
			get => Implementation.ScopeId;
			set => Implementation.ScopeId = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.IPAddress" /> class with the address specified as a <see cref="T:System.Byte" /> array.</summary>
		/// <param name="address">The byte array value of the IP address. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="address" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="address" /> contains a bad IP address. </exception>
		public IPAddressAdapter([NotNull] byte[] address)
			: this(new IPAddress(address))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.IPAddress" /> class with the address specified as a <see cref="T:System.Byte" /> array and the specified scope identifier.</summary>
		/// <param name="address">The byte array value of the IP address. </param>
		/// <param name="scopeid">The long value of the scope identifier. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="address" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="address" /> contains a bad IP address. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="scopeid" /> &lt; 0 or <paramref name="scopeid" /> &gt; 0x00000000FFFFFFFF </exception>
		public IPAddressAdapter([NotNull] byte[] address, long scopeid)
			: this(new IPAddress(address, scopeid))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.IPAddress" /> class with the address specified as an <see cref="T:System.Int64" />.</summary>
		/// <param name="newAddress">The long value of the IP address. For example, the value 0x2414188f in big-endian format would be the IP address "143.24.20.36". </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="newAddress" /> &lt; 0 or <paramref name="newAddress" /> &gt; 0x00000000FFFFFFFF </exception>
		public IPAddressAdapter(long newAddress)
			: this(new IPAddress(newAddress))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="IPAddressAdapter" /> class.</summary>
		/// <param name="address">Address to be used by the adapter</param>
		public IPAddressAdapter([NotNull] IPAddress address)
			: base(address)
		{
		}

		/// <inheritdoc />
		public byte[] GetAddressBytes()
		{
			return Implementation.GetAddressBytes();
		}

		/// <inheritdoc />
		public IIPAddress MapToIPv4()
		{
			return Implementation.MapToIPv4().ToInterface();
		}

		/// <inheritdoc />
		public IIPAddress MapToIPv6()
		{
			return Implementation.MapToIPv6().ToInterface();
		}
	}
}

#endif
