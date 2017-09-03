#if NETSTANDARD1_3 || NET45

using System.Net;
using JetBrains.Annotations;

namespace Thinktecture.Net
{
	/// <summary>
	/// Statics of <see cref="IPAddress"/>.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public interface IIPAddressGlobals
	{
		/// <summary>Provides an IP address that indicates that the server must listen for client activity on all network interfaces. This field is read-only.</summary>
		[NotNull]
		IIPAddress Any { get; }

		/// <summary>Provides the IP broadcast address. This field is read-only.</summary>
		[NotNull]
		IIPAddress Broadcast { get; }

		/// <summary>The <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" /> method uses the <see cref="F:System.Net.IPAddress.IPv6Any" /> field to indicate that a <see cref="T:System.Net.Sockets.Socket" /> must listen for client activity on all network interfaces.</summary>
		[NotNull]
		// ReSharper disable once InconsistentNaming
		IIPAddress IPv6Any { get; }

		/// <summary>Provides the IP loopback address. This property is read-only.</summary>
		[NotNull]
		// ReSharper disable once InconsistentNaming
		IIPAddress IPv6Loopback { get; }

		/// <summary>Provides an IP address that indicates that no network interface should be used. This property is read-only.</summary>
		[NotNull]
		// ReSharper disable once InconsistentNaming
		IIPAddress IPv6None { get; }

		/// <summary>Provides the IP loopback address. This field is read-only.</summary>
		[NotNull]
		IIPAddress Loopback { get; }

		/// <summary>Provides an IP address that indicates that no network interface should be used. This field is read-only.</summary>
		[NotNull]
		IIPAddress None { get; }

		/// <summary>Converts a short value from host byte order to network byte order.</summary>
		/// <returns>A short value, expressed in network byte order.</returns>
		/// <param name="host">The number to convert, expressed in host byte order. </param>
		short HostToNetworkOrder(short host);

		/// <summary>Converts an integer value from host byte order to network byte order.</summary>
		/// <returns>An integer value, expressed in network byte order.</returns>
		/// <param name="host">The number to convert, expressed in host byte order. </param>
		int HostToNetworkOrder(int host);

		/// <summary>Converts a long value from host byte order to network byte order.</summary>
		/// <returns>A long value, expressed in network byte order.</returns>
		/// <param name="host">The number to convert, expressed in host byte order. </param>
		long HostToNetworkOrder(long host);

		/// <summary>Indicates whether the specified IP address is the loopback address.</summary>
		/// <returns>true if <paramref name="address" /> is the loopback address; otherwise, false.</returns>
		/// <param name="address">An IP address. </param>
		bool IsLoopback([NotNull] IPAddress address);

		/// <summary>Converts a short value from network byte order to host byte order.</summary>
		/// <returns>A short value, expressed in host byte order.</returns>
		/// <param name="network">The number to convert, expressed in network byte order. </param>
		short NetworkToHostOrder(short network);

		/// <summary>Converts an integer value from network byte order to host byte order.</summary>
		/// <returns>An integer value, expressed in host byte order.</returns>
		/// <param name="network">The number to convert, expressed in network byte order. </param>
		int NetworkToHostOrder(int network);

		/// <summary>Converts a long value from network byte order to host byte order.</summary>
		/// <returns>A long value, expressed in host byte order.</returns>
		/// <param name="network">The number to convert, expressed in network byte order. </param>
		long NetworkToHostOrder(long network);

		/// <summary>Converts an IP address string to an <see cref="T:System.Net.IPAddress" /> instance.</summary>
		/// <returns>An <see cref="T:System.Net.IPAddress" /> instance.</returns>
		/// <param name="ipString">A string that contains an IP address in dotted-quad notation for IPv4 and in colon-hexadecimal notation for IPv6. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="ipString" /> is null. </exception>
		/// <exception cref="T:System.FormatException">
		/// <paramref name="ipString" /> is not a valid IP address. </exception>
		[NotNull]
		IIPAddress Parse([NotNull] string ipString);

		/// <summary>Determines whether a string is a valid IP address.</summary>
		/// <returns>true if <paramref name="ipString" /> is a valid IP address; otherwise, false.</returns>
		/// <param name="ipString">The string to validate.</param>
		/// <param name="address">The <see cref="T:System.Net.IPAddress" /> version of the string.</param>
		bool TryParse([CanBeNull] string ipString, [CanBeNull] out IPAddress address);

		/// <summary>Determines whether a string is a valid IP address.</summary>
		/// <returns>true if <paramref name="ipString" /> is a valid IP address; otherwise, false.</returns>
		/// <param name="ipString">The string to validate.</param>
		/// <param name="address">The <see cref="T:System.Net.IPAddress" /> version of the string.</param>
		bool TryParse([NotNull] string ipString, [CanBeNull] out IIPAddress address);
	}
}

#endif
