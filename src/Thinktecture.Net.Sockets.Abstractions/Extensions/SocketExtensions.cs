using System.Net.Sockets;
using System.Threading;
using JetBrains.Annotations;
using Thinktecture.Net.Sockets;
using Thinktecture.Net.Sockets.Adapters;
#if NETSTANDARD1_3 || NETSTANDARD2_0
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Thinktecture.Net;

#endif

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="Socket"/>.
	/// </summary>
	public static class SocketExtensions
	{
		/// <summary>
		/// Converts provided socket to <see cref="ISocket"/>.
		/// </summary>
		/// <param name="socket">Socket to convert.</param>
		/// <returns>Converted socket.</returns>
		[CanBeNull]
		public static ISocket ToInterface([CanBeNull] this Socket socket)
		{
			return (socket == null) ? null : new SocketAdapter(socket);
		}

#if NETSTANDARD1_3 || NETSTANDARD2_0
		/// <summary>
		/// Performs an asynchronous operation on to accept an incoming connection attempt on the socket.
		/// </summary>
		/// <param name="socket">The socket that is listening for connections.</param>
		/// <returns>An asynchronous task that completes with a Socket to handle communication with the remote host.</returns>
		public static async Task<ISocket> AcceptAsync(this ISocket socket)
		{
			return (await socket.ToImplementation().AcceptAsync().ConfigureAwait(false)).ToInterface();
		}

		/// <summary>
		/// Performs an asynchronous operation on to accept an incoming connection attempt on the socket.
		/// </summary>
		/// <param name="socket">The socket that is listening for incoming connections.</param>
		/// <param name="acceptSocket">The accepted Socket object. This value may be null.</param>
		/// <returns>An asynchronous task that completes with a Socket to handle communication with the remote host.</returns>
		public static async Task<ISocket> AcceptAsync(this ISocket socket, Socket acceptSocket)
		{
			return (await socket.ToImplementation().AcceptAsync(acceptSocket).ConfigureAwait(false)).ToInterface();
		}

		/// <summary>
		/// Performs an asynchronous operation on to accept an incoming connection attempt on the socket.
		/// </summary>
		/// <param name="socket">The socket that is listening for incoming connections.</param>
		/// <param name="acceptSocket">The accepted Socket object. This value may be null.</param>
		/// <returns>An asynchronous task that completes with a Socket to handle communication with the remote host.</returns>
		public static async Task<ISocket> AcceptAsync(this ISocket socket, ISocket acceptSocket)
		{
			return (await socket.ToImplementation().AcceptAsync(acceptSocket.ToImplementation()).ConfigureAwait(false)).ToInterface();
		}

		/// <summary>
		/// Establishes a connection to a remote host.
		/// </summary>
		/// <param name="socket">The socket that is used for establishing a connection.</param>
		/// <param name="remoteEp">An EndPoint that represents the remote device.</param>
		/// <returns>An asynchronous Task.</returns>
		public static Task ConnectAsync(this ISocket socket, EndPoint remoteEp)
		{
			return socket.ToImplementation().ConnectAsync(remoteEp);
		}

		/// <summary>
		/// Establishes a connection to a remote host.
		/// </summary>
		/// <param name="socket">The socket that is used for establishing a connection.</param>
		/// <param name="remoteEp">An EndPoint that represents the remote device.</param>
		/// <returns>An asynchronous Task.</returns>
		public static Task ConnectAsync(this ISocket socket, IEndPoint remoteEp)
		{
			return socket.ToImplementation().ConnectAsync(remoteEp.ToImplementation());
		}

		/// <summary>
		/// Establishes a connection to a remote host. The host is specified by an IP address and a port number.
		/// </summary>
		/// <param name="socket">The socket to perform the connect operation on.</param>
		/// <param name="address">The IP address of the remote host.</param>
		/// <param name="port">The port number of the remote host.</param>
		/// <returns>An asynchronous Task.</returns>
		public static Task ConnectAsync(this ISocket socket, IPAddress address, int port)
		{
			return socket.ToImplementation().ConnectAsync(address, port);
		}

		/// <summary>
		/// Establishes a connection to a remote host. The host is specified by an IP address and a port number.
		/// </summary>
		/// <param name="socket">The socket to perform the connect operation on.</param>
		/// <param name="address">The IP address of the remote host.</param>
		/// <param name="port">The port number of the remote host.</param>
		/// <returns>An asynchronous Task.</returns>
		public static Task ConnectAsync(this ISocket socket, IIPAddress address, int port)
		{
			return socket.ToImplementation().ConnectAsync(address.ToImplementation(), port);
		}

		/// <summary>
		/// Establishes a connection to a remote host. The host is specified by an array of IP addresses and a port number.
		/// </summary>
		/// <param name="socket">The socket that the connect operation is performed on.</param>
		/// <param name="addresses">The IP addresses of the remote host.</param>
		/// <param name="port">The port number of the remote host.</param>
		/// <returns>A task that represents the asynchronous connect operation.</returns>
		public static Task ConnectAsync(this ISocket socket, IPAddress[] addresses, int port)
		{
			return socket.ToImplementation().ConnectAsync(addresses, port);
		}

		/// <summary>
		/// Establishes a connection to a remote host. The host is specified by an array of IP addresses and a port number.
		/// </summary>
		/// <param name="socket">The socket that the connect operation is performed on.</param>
		/// <param name="addresses">The IP addresses of the remote host.</param>
		/// <param name="port">The port number of the remote host.</param>
		/// <returns>A task that represents the asynchronous connect operation.</returns>
		public static Task ConnectAsync(this ISocket socket, IIPAddress[] addresses, int port)
		{
			return socket.ToImplementation().ConnectAsync(addresses.ToImplementation<IIPAddress, IPAddress>(), port);
		}

		/// <summary>
		/// Establishes a connection to a remote host. The host is specified by a host name and a port number.
		/// </summary>
		/// <param name="socket">The socket to perform the connect operation on.</param>
		/// <param name="host">The name of the remote host.</param>
		/// <param name="port">The port number of the remote host.</param>
		/// <returns>Returns an asynchronous Task.</returns>
		public static Task ConnectAsync(this ISocket socket, string host, int port)
		{
			return socket.ToImplementation().ConnectAsync(host, port);
		}

#if NETCOREAPP2_2
		/// <summary>
		/// Receives data from a connected socket.
		/// </summary>
		/// <param name="socket">The socket to perform the receive operation on.</param>
		/// <param name="buffer">Storage location for the received data.</param>
		/// <param name="socketFlags">A bitwise combination of the <see cref="SocketFlags"/> values.</param>
		/// <param name="cancellationToken">Cancellation token.</param>
		/// <returns>A task that represents the asynchronous receive operation. The value of the TResult parameter contains the number of bytes received.</returns>
		public static ValueTask<int> ReceiveAsync(this ISocket socket, Memory<byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken)
		{
			return socket.ToImplementation().ReceiveAsync(buffer, socketFlags, cancellationToken);
		}

		/// <summary>
		/// Sends data to a connected socket.
		/// </summary>
		/// <param name="socket">The socket to perform the operation on.</param>
		/// <param name="buffer">Bytes to send.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <param name="cancellationToken">Cancellation token.</param>
		/// <returns>An asynchronous task that completes with number of bytes sent to the socket if the operation was successful. Otherwise, the task will complete with an invalid socket error.</returns>
		public static ValueTask<int> SendAsync(this ISocket socket, ReadOnlyMemory<byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken)
		{
			return socket.ToImplementation().SendAsync(buffer, socketFlags, cancellationToken);
		}
#endif

		/// <summary>
		/// Receives data from a connected socket.
		/// </summary>
		/// <param name="socket">The socket to perform the receive operation on.</param>
		/// <param name="buffer">An array that is the storage location for the received data.</param>
		/// <param name="socketFlags">A bitwise combination of the <see cref="SocketFlags"/> values.</param>
		/// <returns>A task that represents the asynchronous receive operation. The value of the TResult parameter contains the number of bytes received.</returns>
		public static Task<int> ReceiveAsync(this ISocket socket, ArraySegment<byte> buffer, SocketFlags socketFlags)
		{
			return socket.ToImplementation().ReceiveAsync(buffer, socketFlags);
		}

		/// <summary>
		///Receives data from a connected socket.
		/// </summary>
		/// <param name="socket">The socket to perform the receive operation on.</param>
		/// <param name="buffers">An array that is the storage location for the received data.</param>
		/// <param name="socketFlags">A bitwise combination of the <see cref="SocketFlags"/> values.</param>
		/// <returns>A task that represents the asynchronous receive operation. The value of the TResult parameter contains the number of bytes received.</returns>
		public static Task<int> ReceiveAsync(this ISocket socket, IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			return socket.ToImplementation().ReceiveAsync(buffers, socketFlags);
		}

		/// <summary>
		/// Receive data from a specified network device.
		/// </summary>
		/// <param name="socket">The socket to perform the ReceiveFrom operation on.</param>
		/// <param name="buffer">An array of type Byte that is the storage location for the received data.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <param name="remoteEndPoint">An EndPoint that represents the source of the data.</param>
		/// <returns>An asynchronous Task that completes with a SocketReceiveFromResult struct.</returns>
		public static Task<SocketReceiveFromResult> ReceiveFromAsync(this ISocket socket, ArraySegment<byte> buffer, SocketFlags socketFlags, EndPoint remoteEndPoint)
		{
			return socket.ToImplementation().ReceiveFromAsync(buffer, socketFlags, remoteEndPoint);
		}

		/// <summary>
		/// Receive data from a specified network device.
		/// </summary>
		/// <param name="socket">The socket to perform the ReceiveFrom operation on.</param>
		/// <param name="buffer">An array of type Byte that is the storage location for the received data.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <param name="remoteEndPoint">An EndPoint that represents the source of the data.</param>
		/// <returns>An asynchronous Task that completes with a SocketReceiveFromResult struct.</returns>
		public static Task<SocketReceiveFromResult> ReceiveFromAsync(this ISocket socket, ArraySegment<byte> buffer, SocketFlags socketFlags, IEndPoint remoteEndPoint)
		{
			return socket.ToImplementation().ReceiveFromAsync(buffer, socketFlags, remoteEndPoint.ToImplementation());
		}

		/// <summary>
		/// Receives the specified number of bytes of data into the specified location of the data buffer, using the specified SocketFlags, and stores the endpoint and packet information.
		/// </summary>
		/// <param name="socket">The socket to perform the operation on.</param>
		/// <param name="buffer">An array that is the storage location for received data.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <param name="remoteEndPoint">An <see cref="EndPoint"/>, that represents the remote server.</param>
		/// <returns>An asynchronous Task that completes with a SocketReceiveMessageFromResult struct.</returns>
		public static Task<SocketReceiveMessageFromResult> ReceiveMessageFromAsync(this ISocket socket, ArraySegment<byte> buffer, SocketFlags socketFlags, EndPoint remoteEndPoint)
		{
			return socket.ToImplementation().ReceiveMessageFromAsync(buffer, socketFlags, remoteEndPoint);
		}

		/// <summary>
		/// Receives the specified number of bytes of data into the specified location of the data buffer, using the specified SocketFlags, and stores the endpoint and packet information.
		/// </summary>
		/// <param name="socket">The socket to perform the operation on.</param>
		/// <param name="buffer">An array that is the storage location for received data.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <param name="remoteEndPoint">An <see cref="EndPoint"/>, that represents the remote server.</param>
		/// <returns>An asynchronous Task that completes with a SocketReceiveMessageFromResult struct.</returns>
		public static Task<SocketReceiveMessageFromResult> ReceiveMessageFromAsync(this ISocket socket, ArraySegment<byte> buffer, SocketFlags socketFlags, IEndPoint remoteEndPoint)
		{
			return socket.ToImplementation().ReceiveMessageFromAsync(buffer, socketFlags, remoteEndPoint.ToImplementation());
		}

		/// <summary>
		/// Sends data to a connected socket.
		/// </summary>
		/// <param name="socket">The socket to perform the operation on.</param>
		/// <param name="buffer">An array of type Byte that contains the data to send.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <returns>An asynchronous task that completes with number of bytes sent to the socket if the operation was successful. Otherwise, the task will complete with an invalid socket error.</returns>
		public static Task<int> SendAsync(this ISocket socket, ArraySegment<byte> buffer, SocketFlags socketFlags)
		{
			return socket.ToImplementation().SendAsync(buffer, socketFlags);
		}

		/// <summary>
		/// Sends data to a connected socket.
		/// </summary>
		/// <param name="socket">The socket to perform the operation on.</param>
		/// <param name="buffers">An array that contains the data to send.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <returns>An asynchronous task that completes with number of bytes sent to the socket if the operation was successful. Otherwise, the task will complete with an invalid socket error.</returns>
		public static Task<int> SendAsync(this ISocket socket, IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			return socket.ToImplementation().SendAsync(buffers, socketFlags);
		}

		/// <summary>
		/// Sends data asynchronously to a specific remote host.
		/// </summary>
		/// <param name="socket">The socket to perform the operation on.</param>
		/// <param name="buffer">An array that contains the data to send.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <param name="remoteEp">An EndPoint that represents the remote device.</param>
		/// <returns>An asynchronous task that completes with number of bytes sent if the operation was successful. Otherwise, the task will complete with an invalid socket error.</returns>
		public static Task<int> SendToAsync(this ISocket socket, ArraySegment<byte> buffer, SocketFlags socketFlags, EndPoint remoteEp)
		{
			return socket.ToImplementation().SendToAsync(buffer, socketFlags, remoteEp);
		}

		/// <summary>
		/// Sends data asynchronously to a specific remote host.
		/// </summary>
		/// <param name="socket">The socket to perform the operation on.</param>
		/// <param name="buffer">An array that contains the data to send.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <param name="remoteEp">An EndPoint that represents the remote device.</param>
		/// <returns>An asynchronous task that completes with number of bytes sent if the operation was successful. Otherwise, the task will complete with an invalid socket error.</returns>
		public static Task<int> SendToAsync(this ISocket socket, ArraySegment<byte> buffer, SocketFlags socketFlags, IEndPoint remoteEp)
		{
			return socket.ToImplementation().SendToAsync(buffer, socketFlags, remoteEp.ToImplementation());
		}
#endif
	}
}
