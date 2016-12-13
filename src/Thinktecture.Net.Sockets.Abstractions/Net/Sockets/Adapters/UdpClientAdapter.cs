using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Thinktecture.Net.Sockets.Adapters
{
	/// <summary>
	/// Provides User Datagram Protocol (UDP) network services.
	/// </summary>
	public class UdpClientAdapter : AbstractionAdapter, IUdpClient
	{
		private readonly UdpClient _client;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new UdpClient UnsafeConvert()
		{
			return _client;
		}

		/// <inheritdoc />
		public int Available => _client.Available;

		/// <inheritdoc />
		public ISocket Client
		{
			get { return _client.Client.ToInterface(); }
			set { _client.Client = value.ToImplementation(); }
		}

		/// <inheritdoc />
		public bool DontFragment
		{
			get { return _client.DontFragment; }
			set { _client.DontFragment = value; }
		}

		/// <inheritdoc />
		public bool EnableBroadcast
		{
			get { return _client.EnableBroadcast; }
			set { _client.EnableBroadcast = value; }
		}

		/// <inheritdoc />
		public bool ExclusiveAddressUse
		{
			get { return _client.ExclusiveAddressUse; }
			set { _client.ExclusiveAddressUse = value; }
		}

		/// <inheritdoc />
		public bool MulticastLoopback
		{
			get { return _client.MulticastLoopback; }
			set { _client.MulticastLoopback = value; }
		}

		/// <inheritdoc />
		public short Ttl
		{
			get { return _client.Ttl; }
			set { _client.Ttl = value; }
		}

		/// <summary>
		/// Initializes a new instance of the UdpClient class.
		/// </summary>
		public UdpClientAdapter()
			: this(new UdpClient())
		{
		}

		/// <summary>
		/// Initializes a new instance of the UdpClient class and binds it to the local port number provided.
		/// </summary>
		/// <param name="port">The local port number from which you intend to communicate.</param>
		public UdpClientAdapter(int port)
			: this(new UdpClient(port))
		{
		}

		/// <summary>
		/// Initializes a new instance of the UdpClient class and binds it to the local port number provided.
		/// </summary>
		/// <param name="port">The port on which to listen for incoming connection attempts.</param>
		/// <param name="family">One of the AddressFamily values that specifies the addressing scheme of the socket.</param>
		public UdpClientAdapter(int port, AddressFamily family)
			: this(new UdpClient(port, family))
		{
		}

		/// <summary>
		/// Initializes a new instance of the UdpClient class and binds it to the specified local endpoint.
		/// </summary>
		/// <param name="localEP">An IPEndPoint that respresents the local endpoint to which you bind the UDP connection.</param>
		// ReSharper disable once InconsistentNaming
		public UdpClientAdapter(IPEndPoint localEP)
			: this(new UdpClient(localEP))
		{
		}

		/// <summary>
		/// Initializes a new instance of the UdpClient class and binds it to the specified local endpoint.
		/// </summary>
		/// <param name="localEP">An IPEndPoint that respresents the local endpoint to which you bind the UDP connection.</param>
		// ReSharper disable once InconsistentNaming
		public UdpClientAdapter(IIPEndPoint localEP)
			: this(new UdpClient(localEP.ToImplementation<IPEndPoint>()))
		{
		}

		/// <summary>
		/// Initializes a new instance of the UdpClient class.
		/// </summary>
		/// <param name="family">One of the AddressFamily values that specifies the addressing scheme of the socket.</param>
		public UdpClientAdapter(AddressFamily family)
			: this(new UdpClient(family))
		{
		}

		/// <summary>
		/// Intializes new instance of <see cref="UdpClientAdapter"/>.
		/// </summary>
		/// <param name="client">Client to be used by the adapter.</param>
		public UdpClientAdapter(UdpClient client)
			: base(client)
		{
			if (client == null)
				throw new ArgumentNullException(nameof(client));

			_client = client;
		}

		/// <inheritdoc />
		public void DropMulticastGroup(IPAddress multicastAddr)
		{
			_client.DropMulticastGroup(multicastAddr);
		}

		/// <inheritdoc />
		public void DropMulticastGroup(IIPAddress multicastAddr)
		{
			_client.DropMulticastGroup(multicastAddr.ToImplementation());
		}

		/// <inheritdoc />
		public void DropMulticastGroup(IPAddress multicastAddr, int ifindex)
		{
			_client.DropMulticastGroup(multicastAddr, ifindex);
		}

		/// <inheritdoc />
		public void DropMulticastGroup(IIPAddress multicastAddr, int ifindex)
		{
			_client.DropMulticastGroup(multicastAddr.ToImplementation(), ifindex);
		}

		/// <inheritdoc />
		public void JoinMulticastGroup(int ifindex, IPAddress multicastAddr)
		{
			_client.JoinMulticastGroup(ifindex, multicastAddr);
		}

		/// <inheritdoc />
		public void JoinMulticastGroup(int ifindex, IIPAddress multicastAddr)
		{
			_client.JoinMulticastGroup(ifindex, multicastAddr.ToImplementation());
		}

		/// <inheritdoc />
		public void JoinMulticastGroup(IPAddress multicastAddr)
		{
			_client.JoinMulticastGroup(multicastAddr);
		}

		/// <inheritdoc />
		public void JoinMulticastGroup(IIPAddress multicastAddr)
		{
			_client.JoinMulticastGroup(multicastAddr.ToImplementation());
		}

		/// <inheritdoc />
		public void JoinMulticastGroup(IPAddress multicastAddr, int timeToLive)
		{
			_client.JoinMulticastGroup(multicastAddr, timeToLive);
		}

		/// <inheritdoc />
		public void JoinMulticastGroup(IIPAddress multicastAddr, int timeToLive)
		{
			_client.JoinMulticastGroup(multicastAddr.ToImplementation(), timeToLive);
		}

		/// <inheritdoc />
		public void JoinMulticastGroup(IPAddress multicastAddr, IPAddress localAddress)
		{
			_client.JoinMulticastGroup(multicastAddr, localAddress);
		}

		/// <inheritdoc />
		public void JoinMulticastGroup(IIPAddress multicastAddr, IPAddress localAddress)
		{
			_client.JoinMulticastGroup(multicastAddr.ToImplementation(), localAddress);
		}

		/// <inheritdoc />
		public void JoinMulticastGroup(IPAddress multicastAddr, IIPAddress localAddress)
		{
			_client.JoinMulticastGroup(multicastAddr, localAddress.ToImplementation());
		}

		/// <inheritdoc />
		public void JoinMulticastGroup(IIPAddress multicastAddr, IIPAddress localAddress)
		{
			_client.JoinMulticastGroup(multicastAddr.ToImplementation(), localAddress.ToImplementation());
		}

		/// <inheritdoc />
		public Task<UdpReceiveResult> ReceiveAsync()
		{
			return _client.ReceiveAsync();
		}

		/// <inheritdoc />
		public Task<int> SendAsync(byte[] datagram, int bytes, IPEndPoint endPoint)
		{
			return _client.SendAsync(datagram, bytes, endPoint);
		}

		/// <inheritdoc />
		public Task<int> SendAsync(byte[] datagram, int bytes, IIPEndPoint endPoint)
		{
			return _client.SendAsync(datagram, bytes, endPoint.ToImplementation<IPEndPoint>());
		}

		/// <inheritdoc />
		public Task<int> SendAsync(byte[] datagram, int bytes, string hostname, int port)
		{
			return _client.SendAsync(datagram, bytes, hostname, port);
		}

		/// <inheritdoc />
		public void Dispose()
		{
			((IDisposable) _client).Dispose();
		}
	}
}