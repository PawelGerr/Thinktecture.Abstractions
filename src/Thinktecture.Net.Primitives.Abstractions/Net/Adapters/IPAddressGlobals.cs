#if NETSTANDARD1_3 || NET45

using System.Net;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.Adapters
{
	/// <summary>
	/// Statics of <see cref="IPAddress"/>.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public class IPAddressGlobals : IIPAddressGlobals
	{
		/// <summary>Provides an IP address that indicates that the server must listen for client activity on all network interfaces. This field is read-only.</summary>
		public IIPAddress Any => IPAddressAdapter.Any;

		/// <summary>Provides the IP broadcast address. This field is read-only.</summary>
		public IIPAddress Broadcast => IPAddressAdapter.Broadcast;

		/// <summary>The <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" /> method uses the <see cref="F:System.Net.IPAddress.IPv6Any" /> field to indicate that a <see cref="T:System.Net.Sockets.Socket" /> must listen for client activity on all network interfaces.</summary>
		// ReSharper disable once InconsistentNaming
		public IIPAddress IPv6Any => IPAddressAdapter.IPv6Any;

		/// <summary>Provides the IP loopback address. This property is read-only.</summary>
		// ReSharper disable once InconsistentNaming
		public IIPAddress IPv6Loopback => IPAddressAdapter.IPv6Loopback;

		/// <summary>Provides an IP address that indicates that no network interface should be used. This property is read-only.</summary>
		// ReSharper disable once InconsistentNaming
		public IIPAddress IPv6None => IPAddressAdapter.IPv6None;

		/// <summary>Provides the IP loopback address. This field is read-only.</summary>
		public IIPAddress Loopback => IPAddressAdapter.Loopback;

		/// <summary>Provides an IP address that indicates that no network interface should be used. This field is read-only.</summary>
		public IIPAddress None => IPAddressAdapter.None;

		/// <summary>Converts a short value from host byte order to network byte order.</summary>
		/// <returns>A short value, expressed in network byte order.</returns>
		/// <param name="host">The number to convert, expressed in host byte order. </param>
		public short HostToNetworkOrder(short host)
		{
			return IPAddressAdapter.HostToNetworkOrder(host);
		}

		/// <summary>Converts an integer value from host byte order to network byte order.</summary>
		/// <returns>An integer value, expressed in network byte order.</returns>
		/// <param name="host">The number to convert, expressed in host byte order. </param>
		public int HostToNetworkOrder(int host)
		{
			return IPAddressAdapter.HostToNetworkOrder(host);
		}

		/// <summary>Converts a long value from host byte order to network byte order.</summary>
		/// <returns>A long value, expressed in network byte order.</returns>
		/// <param name="host">The number to convert, expressed in host byte order. </param>
		public long HostToNetworkOrder(long host)
		{
			return IPAddressAdapter.HostToNetworkOrder(host);
		}

		/// <summary>Indicates whether the specified IP address is the loopback address.</summary>
		/// <returns>true if <paramref name="address" /> is the loopback address; otherwise, false.</returns>
		/// <param name="address">An IP address. </param>
		public bool IsLoopback(IPAddress address)
		{
			return IPAddressAdapter.IsLoopback(address);
		}

		/// <summary>Converts a short value from network byte order to host byte order.</summary>
		/// <returns>A short value, expressed in host byte order.</returns>
		/// <param name="network">The number to convert, expressed in network byte order. </param>
		public short NetworkToHostOrder(short network)
		{
			return IPAddressAdapter.NetworkToHostOrder(network);
		}

		/// <summary>Converts an integer value from network byte order to host byte order.</summary>
		/// <returns>An integer value, expressed in host byte order.</returns>
		/// <param name="network">The number to convert, expressed in network byte order. </param>
		public int NetworkToHostOrder(int network)
		{
			return IPAddressAdapter.NetworkToHostOrder(network);
		}

		/// <summary>Converts a long value from network byte order to host byte order.</summary>
		/// <returns>A long value, expressed in host byte order.</returns>
		/// <param name="network">The number to convert, expressed in network byte order. </param>
		public long NetworkToHostOrder(long network)
		{
			return IPAddressAdapter.NetworkToHostOrder(network);
		}

		/// <summary>Converts an IP address string to an <see cref="T:System.Net.IPAddress" /> instance.</summary>
		/// <returns>An <see cref="T:System.Net.IPAddress" /> instance.</returns>
		/// <param name="ipString">A string that contains an IP address in dotted-quad notation for IPv4 and in colon-hexadecimal notation for IPv6. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="ipString" /> is null. </exception>
		/// <exception cref="T:System.FormatException">
		/// <paramref name="ipString" /> is not a valid IP address. </exception>
		public IIPAddress Parse(string ipString)
		{
			return IPAddressAdapter.Parse(ipString);
		}

		/// <summary>Determines whether a string is a valid IP address.</summary>
		/// <returns>true if <paramref name="ipString" /> is a valid IP address; otherwise, false.</returns>
		/// <param name="ipString">The string to validate.</param>
		/// <param name="address">The <see cref="T:System.Net.IPAddress" /> version of the string.</param>
		public bool TryParse(string ipString, out IPAddress address)
		{
			return IPAddressAdapter.TryParse(ipString, out address);
		}

		/// <summary>Determines whether a string is a valid IP address.</summary>
		/// <returns>true if <paramref name="ipString" /> is a valid IP address; otherwise, false.</returns>
		/// <param name="ipString">The string to validate.</param>
		/// <param name="address">The <see cref="T:System.Net.IPAddress" /> version of the string.</param>
		public bool TryParse(string ipString, out IIPAddress address)
		{
			return IPAddressAdapter.TryParse(ipString, out address);
		}
	}
}

#endif
