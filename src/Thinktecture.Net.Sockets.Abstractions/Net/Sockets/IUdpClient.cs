using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Thinktecture.Net.Sockets
{
	/// <summary>
	/// Provides User Datagram Protocol (UDP) network services.
	/// </summary>
	public interface IUdpClient : IAbstraction, IDisposable
	{
		/// <summary>
		/// Gets inner instance of <see cref="UdpClient"/>.
		/// It is not intended to be used directly. Use <see cref="UdpClientExtensions.ToImplementation"/> instead.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		new UdpClient UnsafeConvert();

		/// <summary>
		/// Gets the amount of data received from the network that is available to read.
		/// </summary>
		int Available { get; }

		/// <summary>
		/// Gets or sets the underlying network Socket.
		/// </summary>
		ISocket Client { get; set; }

		/// <summary>
		/// Gets or sets a Boolean value that specifies whether the UdpClient allows Internet Protocol (IP) datagrams to be fragmented.
		/// </summary>
		bool DontFragment { get; set; }

		/// <summary>
		/// Gets or sets a Boolean value that specifies whether the UdpClient may send or receive broadcast packets.
		/// </summary>
		bool EnableBroadcast { get; set; }

		/// <summary>
		/// Gets or sets a Boolean value that specifies whether the UdpClient allows only one client to use a port.
		/// </summary>
		bool ExclusiveAddressUse { get; set; }

		/// <summary>
		/// Gets or sets a Boolean value that specifies whether outgoing multicast packets are delivered to the sending application.
		/// </summary>
		bool MulticastLoopback { get; set; }

		/// <summary>
		/// Gets or sets a value that specifies the Time to Live (TTL) value of Internet Protocol (IP) packets sent by the UdpClient.
		/// </summary>
		short Ttl { get; set; }

		/// <summary>
		/// Leaves a multicast group.
		/// </summary>
		/// <param name="multicastAddr">The IPAddress of the multicast group to leave.</param>
		void DropMulticastGroup(IPAddress multicastAddr);

		/// <summary>
		/// Leaves a multicast group.
		/// </summary>
		/// <param name="multicastAddr">The IPAddress of the multicast group to leave.</param>
		void DropMulticastGroup(IIPAddress multicastAddr);

		/// <summary>
		/// Leaves a multicast group.
		/// </summary>
		/// <param name="multicastAddr">The IPAddress of the multicast group to leave.</param>
		/// <param name="ifindex">The local address of the multicast group to leave.</param>
		void DropMulticastGroup(IPAddress multicastAddr, int ifindex);

		/// <summary>
		/// Leaves a multicast group.
		/// </summary>
		/// <param name="multicastAddr">The IPAddress of the multicast group to leave.</param>
		/// <param name="ifindex">The local address of the multicast group to leave.</param>
		void DropMulticastGroup(IIPAddress multicastAddr, int ifindex);

		/// <summary>
		/// Adds a UdpClient to a multicast group.
		/// </summary>
		/// <param name="ifindex">The interface index associated with the local IP address on which to join the multicast group.</param>
		/// <param name="multicastAddr">The multicast IPAddress of the group you want to join.</param>
		void JoinMulticastGroup(int ifindex, IPAddress multicastAddr);

		/// <summary>
		/// Adds a UdpClient to a multicast group.
		/// </summary>
		/// <param name="ifindex">The interface index associated with the local IP address on which to join the multicast group.</param>
		/// <param name="multicastAddr">The multicast IPAddress of the group you want to join.</param>
		void JoinMulticastGroup(int ifindex, IIPAddress multicastAddr);

		/// <summary>
		/// Adds a UdpClient to a multicast group.
		/// </summary>
		/// <param name="multicastAddr">The multicast IPAddress of the group you want to join.</param>
		void JoinMulticastGroup(IPAddress multicastAddr);

		/// <summary>
		/// Adds a UdpClient to a multicast group.
		/// </summary>
		/// <param name="multicastAddr">The multicast IPAddress of the group you want to join.</param>
		void JoinMulticastGroup(IIPAddress multicastAddr);

		/// <summary>
		/// Adds a UdpClient to a multicast group with the specified Time to Live (TTL).
		/// </summary>
		/// <param name="multicastAddr">The IPAddress of the multicast group to join.</param>
		/// <param name="timeToLive">The Time to Live (TTL), measured in router hops.</param>
		void JoinMulticastGroup(IPAddress multicastAddr, int timeToLive);

		/// <summary>
		/// Adds a UdpClient to a multicast group with the specified Time to Live (TTL).
		/// </summary>
		/// <param name="multicastAddr">The IPAddress of the multicast group to join.</param>
		/// <param name="timeToLive">The Time to Live (TTL), measured in router hops.</param>
		void JoinMulticastGroup(IIPAddress multicastAddr, int timeToLive);

		/// <summary>
		/// Adds a UdpClient to a multicast group.
		/// </summary>
		/// <param name="multicastAddr">The multicast IPAddress of the group you want to join.</param>
		/// <param name="localAddress">The local IPAddress.</param>
		void JoinMulticastGroup(IPAddress multicastAddr, IPAddress localAddress);

		/// <summary>
		/// Adds a UdpClient to a multicast group.
		/// </summary>
		/// <param name="multicastAddr">The multicast IPAddress of the group you want to join.</param>
		/// <param name="localAddress">The local IPAddress.</param>
		void JoinMulticastGroup(IIPAddress multicastAddr, IPAddress localAddress);

		/// <summary>
		/// Adds a UdpClient to a multicast group.
		/// </summary>
		/// <param name="multicastAddr">The multicast IPAddress of the group you want to join.</param>
		/// <param name="localAddress">The local IPAddress.</param>
		void JoinMulticastGroup(IPAddress multicastAddr, IIPAddress localAddress);

		/// <summary>
		/// Adds a UdpClient to a multicast group.
		/// </summary>
		/// <param name="multicastAddr">The multicast IPAddress of the group you want to join.</param>
		/// <param name="localAddress">The local IPAddress.</param>
		void JoinMulticastGroup(IIPAddress multicastAddr, IIPAddress localAddress);

		/// <summary>
		/// Returns a UDP datagram asynchronously that was sent by a remote host.
		/// </summary>
		/// <returns>The task object representing the asynchronous operation.</returns>
		Task<UdpReceiveResult> ReceiveAsync();

		/// <summary>
		/// Sends a UDP datagram asynchronously to a remote host.
		/// </summary>
		/// <param name="datagram">An array of type Byte that specifies the UDP datagram that you intend to send represented as an array of bytes.</param>
		/// <param name="bytes">The number of bytes in the datagram.</param>
		/// <param name="endPoint">An IPEndPoint that represents the host and port to which to send the datagram.</param>
		/// <returns></returns>
		Task<int> SendAsync(byte[] datagram, int bytes, IPEndPoint endPoint);

		/// <summary>
		/// Sends a UDP datagram asynchronously to a remote host.
		/// </summary>
		/// <param name="datagram">An array of type Byte that specifies the UDP datagram that you intend to send represented as an array of bytes.</param>
		/// <param name="bytes">The number of bytes in the datagram.</param>
		/// <param name="endPoint">An IPEndPoint that represents the host and port to which to send the datagram.</param>
		/// <returns></returns>
		Task<int> SendAsync(byte[] datagram, int bytes, IIPEndPoint endPoint);

		/// <summary>
		/// Sends a UDP datagram asynchronously to a remote host.
		/// </summary>
		/// <param name="datagram">An array of type Byte that specifies the UDP datagram that you intend to send represented as an array of bytes.</param>
		/// <param name="bytes">The number of bytes in the datagram.</param>
		/// <param name="hostname">The name of the remote host to which you intend to send the datagram.</param>
		/// <param name="port">The remote port number with which you intend to communicate.</param>
		/// <returns></returns>
		Task<int> SendAsync(byte[] datagram, int bytes, string hostname, int port);
	}
}