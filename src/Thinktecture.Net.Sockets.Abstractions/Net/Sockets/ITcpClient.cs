using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Thinktecture.Net.Sockets
{
	/// <summary>
	/// Provides client connections for TCP network services.
	/// </summary>
	public interface ITcpClient : IAbstraction<TcpClient>, IDisposable
	{
		/// <summary>
		/// Gets the amount of data that has been received from the network and is available to be read.
		/// </summary>
		int Available { get; }

		/// <summary>
		/// Gets or sets the underlying Socket.
		/// </summary>
		[CanBeNull]
		ISocket Client { get; set; }

		/// <summary>
		/// Gets a value indicating whether the underlying Socket for a TcpClient is connected to a remote host.
		/// </summary>
		bool Connected { get; }

		/// <summary>
		/// Gets or sets a Boolean value that specifies whether the TcpClient allows only one client to use a port.
		/// </summary>
		bool ExclusiveAddressUse { get; set; }

		/// <summary>
		/// Gets or sets information about the linger state of the associated socket.
		/// </summary>
		[CanBeNull]
		ILingerOption LingerState { get; set; }

		/// <summary>
		/// Gets or sets a value that disables a delay when send or receive buffers are not full.
		/// </summary>
		bool NoDelay { get; set; }

		/// <summary>
		/// Gets or sets the size of the receive buffer.
		/// </summary>
		int ReceiveBufferSize { get; set; }

		/// <summary>
		/// Gets or sets the amount of time a TcpClient will wait to receive data once a read operation is initiated.
		/// </summary>
		int ReceiveTimeout { get; set; }

		/// <summary>
		/// Gets or sets the size of the send buffer.
		/// </summary>
		int SendBufferSize { get; set; }

		/// <summary>
		/// Gets or sets the amount of time a TcpClient will wait for a send operation to complete successfully.
		/// </summary>
		int SendTimeout { get; set; }

		/// <summary>
		/// Connects the client to a remote TCP host using the specified IP address and port number as an asynchronous operation.
		/// </summary>
		/// <param name="address">The IPAddress of the host to which you intend to connect.</param>
		/// <param name="port">The port number to which you intend to connect.</param>
		/// <returns></returns>
		[NotNull]
		Task ConnectAsync([NotNull] IPAddress address, int port);

		/// <summary>
		/// Connects the client to a remote TCP host using the specified IP address and port number as an asynchronous operation.
		/// </summary>
		/// <param name="address">The IPAddress of the host to which you intend to connect.</param>
		/// <param name="port">The port number to which you intend to connect.</param>
		/// <returns></returns>
		[NotNull]
		Task ConnectAsync([NotNull] IIPAddress address, int port);

		/// <summary>
		/// Connects the client to a remote TCP host using the specified IP addresses and port number as an asynchronous operation.
		/// </summary>
		/// <param name="addresses">The IPAddress array of the host to which you intend to connect.</param>
		/// <param name="port">The port number to which you intend to connect.</param>
		/// <returns></returns>
		[NotNull]
		Task ConnectAsync([NotNull] IPAddress[] addresses, int port);

		/// <summary>
		/// Connects the client to a remote TCP host using the specified IP addresses and port number as an asynchronous operation.
		/// </summary>
		/// <param name="addresses">The IPAddress array of the host to which you intend to connect.</param>
		/// <param name="port">The port number to which you intend to connect.</param>
		/// <returns></returns>
		[NotNull]
		Task ConnectAsync([NotNull] IIPAddress[] addresses, int port);

		/// <summary>
		/// Connects the client to the specified TCP port on the specified host as an asynchronous operation.
		/// </summary>
		/// <param name="host">The DNS name of the remote host to which you intend to connect.</param>
		/// <param name="port">The port number of the remote host to which you intend to connect.</param>
		/// <returns></returns>
		[NotNull]
		Task ConnectAsync([NotNull] string host, int port);

		/// <summary>
		/// Returns the NetworkStream used to send and receive data.
		/// </summary>
		/// <returns>The underlying NetworkStream.</returns>
		[NotNull]
		INetworkStream GetStream();
	}
}
