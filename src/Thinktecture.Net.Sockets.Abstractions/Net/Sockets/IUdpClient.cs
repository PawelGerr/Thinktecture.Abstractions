using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Thinktecture.Net.Sockets
{
	/// <summary>
	/// Provides User Datagram Protocol (UDP) network services.
	/// </summary>
	public interface IUdpClient : IAbstraction<UdpClient>, IDisposable
	{
		/// <summary>
		/// Gets the amount of data received from the network that is available to read.
		/// </summary>
		int Available { get; }

		/// <summary>
		/// Gets or sets the underlying network Socket.
		/// </summary>
		[CanBeNull]
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
		void DropMulticastGroup([NotNull] IPAddress multicastAddr);

		/// <summary>
		/// Leaves a multicast group.
		/// </summary>
		/// <param name="multicastAddr">The IPAddress of the multicast group to leave.</param>
		void DropMulticastGroup([NotNull] IIPAddress multicastAddr);

		/// <summary>
		/// Leaves a multicast group.
		/// </summary>
		/// <param name="multicastAddr">The IPAddress of the multicast group to leave.</param>
		/// <param name="ifindex">The local address of the multicast group to leave.</param>
		void DropMulticastGroup([NotNull] IPAddress multicastAddr, int ifindex);

		/// <summary>
		/// Leaves a multicast group.
		/// </summary>
		/// <param name="multicastAddr">The IPAddress of the multicast group to leave.</param>
		/// <param name="ifindex">The local address of the multicast group to leave.</param>
		void DropMulticastGroup([NotNull] IIPAddress multicastAddr, int ifindex);

		/// <summary>
		/// Adds a UdpClient to a multicast group.
		/// </summary>
		/// <param name="ifindex">The interface index associated with the local IP address on which to join the multicast group.</param>
		/// <param name="multicastAddr">The multicast IPAddress of the group you want to join.</param>
		void JoinMulticastGroup(int ifindex, [NotNull] IPAddress multicastAddr);

		/// <summary>
		/// Adds a UdpClient to a multicast group.
		/// </summary>
		/// <param name="ifindex">The interface index associated with the local IP address on which to join the multicast group.</param>
		/// <param name="multicastAddr">The multicast IPAddress of the group you want to join.</param>
		void JoinMulticastGroup(int ifindex, [NotNull] IIPAddress multicastAddr);

		/// <summary>
		/// Adds a UdpClient to a multicast group.
		/// </summary>
		/// <param name="multicastAddr">The multicast IPAddress of the group you want to join.</param>
		void JoinMulticastGroup([NotNull] IPAddress multicastAddr);

		/// <summary>
		/// Adds a UdpClient to a multicast group.
		/// </summary>
		/// <param name="multicastAddr">The multicast IPAddress of the group you want to join.</param>
		void JoinMulticastGroup([NotNull] IIPAddress multicastAddr);

		/// <summary>
		/// Adds a UdpClient to a multicast group with the specified Time to Live (TTL).
		/// </summary>
		/// <param name="multicastAddr">The IPAddress of the multicast group to join.</param>
		/// <param name="timeToLive">The Time to Live (TTL), measured in router hops.</param>
		void JoinMulticastGroup([NotNull] IPAddress multicastAddr, int timeToLive);

		/// <summary>
		/// Adds a UdpClient to a multicast group with the specified Time to Live (TTL).
		/// </summary>
		/// <param name="multicastAddr">The IPAddress of the multicast group to join.</param>
		/// <param name="timeToLive">The Time to Live (TTL), measured in router hops.</param>
		void JoinMulticastGroup([NotNull] IIPAddress multicastAddr, int timeToLive);

		/// <summary>
		/// Adds a UdpClient to a multicast group.
		/// </summary>
		/// <param name="multicastAddr">The multicast IPAddress of the group you want to join.</param>
		/// <param name="localAddress">The local IPAddress.</param>
		void JoinMulticastGroup([NotNull] IPAddress multicastAddr, [NotNull] IPAddress localAddress);

		/// <summary>
		/// Adds a UdpClient to a multicast group.
		/// </summary>
		/// <param name="multicastAddr">The multicast IPAddress of the group you want to join.</param>
		/// <param name="localAddress">The local IPAddress.</param>
		void JoinMulticastGroup([NotNull] IIPAddress multicastAddr, [NotNull] IPAddress localAddress);

		/// <summary>
		/// Adds a UdpClient to a multicast group.
		/// </summary>
		/// <param name="multicastAddr">The multicast IPAddress of the group you want to join.</param>
		/// <param name="localAddress">The local IPAddress.</param>
		void JoinMulticastGroup([NotNull] IPAddress multicastAddr, [NotNull] IIPAddress localAddress);

		/// <summary>
		/// Adds a UdpClient to a multicast group.
		/// </summary>
		/// <param name="multicastAddr">The multicast IPAddress of the group you want to join.</param>
		/// <param name="localAddress">The local IPAddress.</param>
		void JoinMulticastGroup([NotNull] IIPAddress multicastAddr, [NotNull] IIPAddress localAddress);

		/// <summary>
		/// Returns a UDP datagram asynchronously that was sent by a remote host.
		/// </summary>
		/// <returns>The task object representing the asynchronous operation.</returns>
		[NotNull]
		Task<UdpReceiveResult> ReceiveAsync();

		/// <summary>
		/// Sends a UDP datagram asynchronously to a remote host.
		/// </summary>
		/// <param name="datagram">An array of type Byte that specifies the UDP datagram that you intend to send represented as an array of bytes.</param>
		/// <param name="bytes">The number of bytes in the datagram.</param>
		/// <param name="endPoint">An IPEndPoint that represents the host and port to which to send the datagram.</param>
		/// <returns></returns>
		[NotNull]
		Task<int> SendAsync([NotNull] byte[] datagram, int bytes, [CanBeNull] IPEndPoint endPoint);

		/// <summary>
		/// Sends a UDP datagram asynchronously to a remote host.
		/// </summary>
		/// <param name="datagram">An array of type Byte that specifies the UDP datagram that you intend to send represented as an array of bytes.</param>
		/// <param name="bytes">The number of bytes in the datagram.</param>
		/// <param name="endPoint">An IPEndPoint that represents the host and port to which to send the datagram.</param>
		/// <returns></returns>
		[NotNull]
		Task<int> SendAsync([NotNull] byte[] datagram, int bytes, [CanBeNull] IIPEndPoint endPoint);

		/// <summary>
		/// Sends a UDP datagram asynchronously to a remote host.
		/// </summary>
		/// <param name="datagram">An array of type Byte that specifies the UDP datagram that you intend to send represented as an array of bytes.</param>
		/// <param name="bytes">The number of bytes in the datagram.</param>
		/// <param name="hostname">The name of the remote host to which you intend to send the datagram.</param>
		/// <param name="port">The remote port number with which you intend to communicate.</param>
		/// <returns></returns>
		[NotNull]
		Task<int> SendAsync([NotNull] byte[] datagram, int bytes, [CanBeNull] string hostname, int port);

#if NET46 || NETSTANDARD2_0
		/// <summary>Sends a UDP datagram asynchronously to a remote host.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <param name="datagram">An array of type <see cref="T:System.Byte" /> that specifies the UDP datagram that you intend to send represented as an array of bytes.</param>
		/// <param name="bytes">The number of bytes in the datagram.</param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="datagram" /> is null. </exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Net.Sockets.UdpClient" /> has already established a default remote host. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.UdpClient" /> is closed. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket. See the Remarks section for more information. </exception>
		Task<int> SendAsync(byte[] datagram, int bytes);

		/// <summary>Enables or disables Network Address Translation (NAT) traversal on a <see cref="T:System.Net.Sockets.UdpClient" /> instance.</summary>
		/// <param name="allowed">A Boolean value that specifies whether to enable or disable NAT traversal.</param>
		void AllowNatTraversal(bool allowed);

		/// <summary>Closes the UDP connection.</summary>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket. See the Remarks section for more information. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		void Close();

		/// <summary>Establishes a default remote host using the specified host name and port number.</summary>
		/// <param name="hostname">The DNS name of the remote host to which you intend send data. </param>
		/// <param name="port">The port number on the remote host to which you intend to send data. </param>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.UdpClient" /> is closed. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="port" /> is not between <see cref="F:System.Net.IPEndPoint.MinPort" /> and <see cref="F:System.Net.IPEndPoint.MaxPort" />. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket. See the Remarks section for more information. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Net.SocketPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		void Connect(string hostname, int port);

		/// <summary>Establishes a default remote host using the specified IP address and port number.</summary>
		/// <param name="addr">The <see cref="T:System.Net.IPAddress" /> of the remote host to which you intend to send data. </param>
		/// <param name="port">The port number to which you intend send data. </param>
		/// <exception cref="T:System.ObjectDisposedException">
		/// <see cref="T:System.Net.Sockets.UdpClient" /> is closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="addr" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="port" /> is not between <see cref="F:System.Net.IPEndPoint.MinPort" /> and <see cref="F:System.Net.IPEndPoint.MaxPort" />. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket. See the Remarks section for more information. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Net.SocketPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		void Connect(IPAddress addr, int port);

		/// <summary>Establishes a default remote host using the specified IP address and port number.</summary>
		/// <param name="addr">The <see cref="T:System.Net.IPAddress" /> of the remote host to which you intend to send data. </param>
		/// <param name="port">The port number to which you intend send data. </param>
		/// <exception cref="T:System.ObjectDisposedException">
		/// <see cref="T:System.Net.Sockets.UdpClient" /> is closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="addr" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="port" /> is not between <see cref="F:System.Net.IPEndPoint.MinPort" /> and <see cref="F:System.Net.IPEndPoint.MaxPort" />. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket. See the Remarks section for more information. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Net.SocketPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		void Connect(IIPAddress addr, int port);

		/// <summary>Establishes a default remote host using the specified network endpoint.</summary>
		/// <param name="endPoint">An <see cref="T:System.Net.IPEndPoint" /> that specifies the network endpoint to which you intend to send data. </param>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="endPoint" /> is null. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.UdpClient" /> is closed. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Net.SocketPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		void Connect(IPEndPoint endPoint);

		/// <summary>Establishes a default remote host using the specified network endpoint.</summary>
		/// <param name="endPoint">An <see cref="T:System.Net.IPEndPoint" /> that specifies the network endpoint to which you intend to send data. </param>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="endPoint" /> is null. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.UdpClient" /> is closed. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Net.SocketPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		void Connect(IIPEndPoint endPoint);

		/// <summary>Returns a UDP datagram that was sent by a remote host.</summary>
		/// <returns>An array of type <see cref="T:System.Byte" /> that contains datagram data.</returns>
		/// <param name="remoteEp">An <see cref="T:System.Net.IPEndPoint" /> that represents the remote host from which the data was sent. </param>
		/// <exception cref="T:System.ObjectDisposedException">The underlying <see cref="T:System.Net.Sockets.Socket" />  has been closed. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket. See the Remarks section for more information. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Net.SocketPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		byte[] Receive(ref IPEndPoint remoteEp);

		/// <summary>Returns a UDP datagram that was sent by a remote host.</summary>
		/// <returns>An array of type <see cref="T:System.Byte" /> that contains datagram data.</returns>
		/// <param name="remoteEp">An <see cref="T:System.Net.IPEndPoint" /> that represents the remote host from which the data was sent. </param>
		/// <exception cref="T:System.ObjectDisposedException">The underlying <see cref="T:System.Net.Sockets.Socket" />  has been closed. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket. See the Remarks section for more information. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Net.SocketPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		byte[] Receive(ref IIPEndPoint remoteEp);

		/// <summary>Sends a UDP datagram to the host at the specified remote endpoint.</summary>
		/// <returns>The number of bytes sent.</returns>
		/// <param name="dgram">An array of type <see cref="T:System.Byte" /> that specifies the UDP datagram that you intend to send, represented as an array of bytes. </param>
		/// <param name="bytes">The number of bytes in the datagram. </param>
		/// <param name="endPoint">An <see cref="T:System.Net.IPEndPoint" /> that represents the host and port to which to send the datagram. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="dgram" /> is null. </exception>
		/// <exception cref="T:System.InvalidOperationException">
		/// <see cref="T:System.Net.Sockets.UdpClient" /> has already established a default remote host. </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		/// <see cref="T:System.Net.Sockets.UdpClient" /> is closed. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket. See the Remarks section for more information. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		int Send(byte[] dgram, int bytes, IPEndPoint endPoint);

		/// <summary>Sends a UDP datagram to the host at the specified remote endpoint.</summary>
		/// <returns>The number of bytes sent.</returns>
		/// <param name="dgram">An array of type <see cref="T:System.Byte" /> that specifies the UDP datagram that you intend to send, represented as an array of bytes. </param>
		/// <param name="bytes">The number of bytes in the datagram. </param>
		/// <param name="endPoint">An <see cref="T:System.Net.IPEndPoint" /> that represents the host and port to which to send the datagram. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="dgram" /> is null. </exception>
		/// <exception cref="T:System.InvalidOperationException">
		/// <see cref="T:System.Net.Sockets.UdpClient" /> has already established a default remote host. </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		/// <see cref="T:System.Net.Sockets.UdpClient" /> is closed. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket. See the Remarks section for more information. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		int Send(byte[] dgram, int bytes, IIPEndPoint endPoint);

		/// <summary>Sends a UDP datagram to a specified port on a specified remote host.</summary>
		/// <returns>The number of bytes sent.</returns>
		/// <param name="dgram">An array of type <see cref="T:System.Byte" /> that specifies the UDP datagram that you intend to send represented as an array of bytes. </param>
		/// <param name="bytes">The number of bytes in the datagram. </param>
		/// <param name="hostname">The name of the remote host to which you intend to send the datagram. </param>
		/// <param name="port">The remote port number with which you intend to communicate. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="dgram" /> is null. </exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Net.Sockets.UdpClient" /> has already established a default remote host. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.UdpClient" /> is closed. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket. See the Remarks section for more information. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		int Send(byte[] dgram, int bytes, string hostname, int port);

		/// <summary>Sends a UDP datagram to a remote host.</summary>
		/// <returns>The number of bytes sent.</returns>
		/// <param name="dgram">An array of type <see cref="T:System.Byte" /> that specifies the UDP datagram that you intend to send represented as an array of bytes. </param>
		/// <param name="bytes">The number of bytes in the datagram. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="dgram" /> is null. </exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Net.Sockets.UdpClient" /> has already established a default remote host. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.UdpClient" /> is closed. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket. See the Remarks section for more information. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		int Send(byte[] dgram, int bytes);
#endif
	}
}
