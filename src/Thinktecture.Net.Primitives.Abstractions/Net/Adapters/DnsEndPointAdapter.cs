#if NETSTANDARD1_3 || NET45

using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.Adapters
{
	/// <summary>Represents a network endpoint as a host name or a string representation of an IP address and a port number.</summary>
	public class DnsEndPointAdapter : EndPointAdapter, IDnsEndPoint
	{
		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		[NotNull]
		protected new DnsEndPoint Implementation { get; }

		/// <inheritdoc />
		[NotNull]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new DnsEndPoint UnsafeConvert()
		{
			return Implementation;
		}

		/// <inheritdoc />
		public string Host => Implementation.Host;

		/// <inheritdoc />
		public int Port => Implementation.Port;

		/// <summary>Initializes a new instance of the <see cref="DnsEndPointAdapter" /> class with the host name or string representation of an IP address and a port number.</summary>
		/// <param name="host">The host name or a string representation of the IP address.</param>
		/// <param name="port">The port number associated with the address, or 0 to specify any available port. <paramref name="port" /> is in host order.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="host" /> parameter contains an empty string.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="host" /> parameter is a null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="port" /> is less than <see cref="F:System.Net.IPEndPoint.MinPort" />.-or- <paramref name="port" /> is greater than <see cref="F:System.Net.IPEndPoint.MaxPort" />. </exception>
		public DnsEndPointAdapter([NotNull] string host, int port)
			: this(new DnsEndPoint(host, port))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="DnsEndPointAdapter" /> class with the host name or string representation of an IP address, a port number, and an address family.</summary>
		/// <param name="host">The host name or a string representation of the IP address.</param>
		/// <param name="port">The port number associated with the address, or 0 to specify any available port. <paramref name="port" /> is in host order.</param>
		/// <param name="addressFamily">One of the <see cref="T:System.Net.Sockets.AddressFamily" /> values.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="host" /> parameter contains an empty string.-or- <paramref name="addressFamily" /> is <see cref="F:System.Net.Sockets.AddressFamily.Unknown" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="host" /> parameter is a null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="port" /> is less than <see cref="F:System.Net.IPEndPoint.MinPort" />.-or- <paramref name="port" /> is greater than <see cref="F:System.Net.IPEndPoint.MaxPort" />.</exception>
		public DnsEndPointAdapter([NotNull] string host, int port, AddressFamily addressFamily)
			: this(new DnsEndPoint(host, port, addressFamily))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="DnsEndPointAdapter" /> class.</summary>
		/// <param name="endpoint">Endpoint to be used by the adapter.</param>
		public DnsEndPointAdapter([NotNull] DnsEndPoint endpoint)
			: base(endpoint)
		{
			Implementation = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
		}
	}
}

#endif
