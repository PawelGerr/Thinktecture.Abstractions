using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.Sockets.Adapters
{
	/// <summary>
	/// Provides User Datagram Protocol (UDP) network services.
	/// </summary>
	public class UdpClientAdapter : AbstractionAdapter<UdpClient>, IUdpClient
	{
		/// <inheritdoc />
		public int Available => Implementation.Available;

		/// <inheritdoc />
		public ISocket Client
		{
			get => Implementation.Client.ToInterface();
			set => Implementation.Client = value.ToImplementation();
		}

		/// <inheritdoc />
		public bool DontFragment
		{
			get => Implementation.DontFragment;
			set => Implementation.DontFragment = value;
		}

		/// <inheritdoc />
		public bool EnableBroadcast
		{
			get => Implementation.EnableBroadcast;
			set => Implementation.EnableBroadcast = value;
		}

		/// <inheritdoc />
		public bool ExclusiveAddressUse
		{
			get => Implementation.ExclusiveAddressUse;
			set => Implementation.ExclusiveAddressUse = value;
		}

		/// <inheritdoc />
		public bool MulticastLoopback
		{
			get => Implementation.MulticastLoopback;
			set => Implementation.MulticastLoopback = value;
		}

		/// <inheritdoc />
		public short Ttl
		{
			get => Implementation.Ttl;
			set => Implementation.Ttl = value;
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
		public UdpClientAdapter([NotNull] IPEndPoint localEP)
			: this(new UdpClient(localEP))
		{
		}

		/// <summary>
		/// Initializes a new instance of the UdpClient class and binds it to the specified local endpoint.
		/// </summary>
		/// <param name="localEP">An IPEndPoint that respresents the local endpoint to which you bind the UDP connection.</param>
		// ReSharper disable once InconsistentNaming
		public UdpClientAdapter([NotNull] IIPEndPoint localEP)
			: this(localEP.ToImplementation<IPEndPoint>())
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
		public UdpClientAdapter([NotNull] UdpClient client)
			: base(client)
		{
		}

		/// <inheritdoc />
		public void DropMulticastGroup(IPAddress multicastAddr)
		{
			Implementation.DropMulticastGroup(multicastAddr);
		}

		/// <inheritdoc />
		public void DropMulticastGroup(IIPAddress multicastAddr)
		{
			Implementation.DropMulticastGroup(multicastAddr.ToImplementation());
		}

		/// <inheritdoc />
		public void DropMulticastGroup(IPAddress multicastAddr, int ifindex)
		{
			Implementation.DropMulticastGroup(multicastAddr, ifindex);
		}

		/// <inheritdoc />
		public void DropMulticastGroup(IIPAddress multicastAddr, int ifindex)
		{
			Implementation.DropMulticastGroup(multicastAddr.ToImplementation(), ifindex);
		}

		/// <inheritdoc />
		public void JoinMulticastGroup(int ifindex, IPAddress multicastAddr)
		{
			Implementation.JoinMulticastGroup(ifindex, multicastAddr);
		}

		/// <inheritdoc />
		public void JoinMulticastGroup(int ifindex, IIPAddress multicastAddr)
		{
			Implementation.JoinMulticastGroup(ifindex, multicastAddr.ToImplementation());
		}

		/// <inheritdoc />
		public void JoinMulticastGroup(IPAddress multicastAddr)
		{
			Implementation.JoinMulticastGroup(multicastAddr);
		}

		/// <inheritdoc />
		public void JoinMulticastGroup(IIPAddress multicastAddr)
		{
			Implementation.JoinMulticastGroup(multicastAddr.ToImplementation());
		}

		/// <inheritdoc />
		public void JoinMulticastGroup(IPAddress multicastAddr, int timeToLive)
		{
			Implementation.JoinMulticastGroup(multicastAddr, timeToLive);
		}

		/// <inheritdoc />
		public void JoinMulticastGroup(IIPAddress multicastAddr, int timeToLive)
		{
			Implementation.JoinMulticastGroup(multicastAddr.ToImplementation(), timeToLive);
		}

		/// <inheritdoc />
		public void JoinMulticastGroup(IPAddress multicastAddr, IPAddress localAddress)
		{
			Implementation.JoinMulticastGroup(multicastAddr, localAddress);
		}

		/// <inheritdoc />
		public void JoinMulticastGroup(IIPAddress multicastAddr, IPAddress localAddress)
		{
			Implementation.JoinMulticastGroup(multicastAddr.ToImplementation(), localAddress);
		}

		/// <inheritdoc />
		public void JoinMulticastGroup(IPAddress multicastAddr, IIPAddress localAddress)
		{
			Implementation.JoinMulticastGroup(multicastAddr, localAddress.ToImplementation());
		}

		/// <inheritdoc />
		public void JoinMulticastGroup(IIPAddress multicastAddr, IIPAddress localAddress)
		{
			Implementation.JoinMulticastGroup(multicastAddr.ToImplementation(), localAddress.ToImplementation());
		}

		/// <inheritdoc />
		public Task<UdpReceiveResult> ReceiveAsync()
		{
			return Implementation.ReceiveAsync();
		}

		/// <inheritdoc />
		public Task<int> SendAsync(byte[] datagram, int bytes, IPEndPoint endPoint)
		{
			return Implementation.SendAsync(datagram, bytes, endPoint);
		}

		/// <inheritdoc />
		public Task<int> SendAsync(byte[] datagram, int bytes, IIPEndPoint endPoint)
		{
			return Implementation.SendAsync(datagram, bytes, endPoint.ToImplementation<IPEndPoint>());
		}

		/// <inheritdoc />
		public Task<int> SendAsync(byte[] datagram, int bytes, string hostname, int port)
		{
			return Implementation.SendAsync(datagram, bytes, hostname, port);
		}

		/// <inheritdoc />
		public void Dispose()
		{
			((IDisposable)Implementation).Dispose();
		}
	}
}
