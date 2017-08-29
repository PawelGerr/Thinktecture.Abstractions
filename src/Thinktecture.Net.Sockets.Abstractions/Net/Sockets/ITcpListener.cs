using System.Net.Sockets;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Thinktecture.Net.Sockets
{
	/// <summary>
	/// Listens for connections from TCP network clients.
	/// </summary>
	public interface ITcpListener : IAbstraction<TcpListener>
	{
		/// <summary>
		/// Gets or sets a Boolean value that specifies whether the TcpListener allows only one underlying socket to listen to a specific port.
		/// </summary>
		bool ExclusiveAddressUse { get; set; }

		/// <summary>
		/// Gets the underlying EndPoint of the current TcpListener.
		/// </summary>
		[NotNull]
		IEndPoint LocalEndpoint { get; }

		/// <summary>
		/// Gets the underlying network Socket.
		/// </summary>
		[NotNull]
		ISocket Server { get; }

		/// <summary>
		/// Accepts a pending connection request as an asynchronous operation.
		/// </summary>
		/// <returns>The task object representing the asynchronous operation. The Result property on the task object returns a Socket used to send and receive data.</returns>
		[NotNull, ItemNotNull]
		Task<ISocket> AcceptSocketAsync();

		/// <summary>
		/// Accepts a pending connection request as an asynchronous operation.
		/// </summary>
		/// <returns>The task object representing the asynchronous operation. The Result property on the task object returns a TcpClient used to send and receive data.</returns>
		[NotNull, ItemNotNull]
		Task<ITcpClient> AcceptTcpClientAsync();

		/// <summary>
		/// Determines if there are pending connection requests.
		/// </summary>
		/// <returns><c>true</c> if connections are pending; otherwise, <c>false</c>.</returns>
		bool Pending();

		/// <summary>
		/// Starts listening for incoming connection requests.
		/// </summary>
		void Start();

		/// <summary>
		/// Starts listening for incoming connection requests with a maximum number of pending connection.
		/// </summary>
		/// <param name="backlog">The maximum length of the pending connections queue.</param>
		void Start(int backlog);

		/// <summary>
		/// Closes the listener.
		/// </summary>
		void Stop();
	}
}
