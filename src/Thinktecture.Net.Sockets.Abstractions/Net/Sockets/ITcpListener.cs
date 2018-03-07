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

#if NET46 || NETSTANDARD2_0
		/// <summary>Enables or disables Network Address Translation (NAT) traversal on a <see cref="T:System.Net.Sockets.TcpListener" /> instance.</summary>
		/// <param name="allowed">A Boolean value that specifies whether to enable or disable NAT traversal.</param>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="M:System.Net.Sockets.TcpListener.AllowNatTraversal(System.Boolean)" /> method was called after calling the <see cref="M:System.Net.Sockets.TcpListener.Start" /> method</exception>
		void AllowNatTraversal(bool allowed);

		/// <summary>Accepts a pending connection request.</summary>
		/// <returns>A <see cref="T:System.Net.Sockets.Socket" /> used to send and receive data.</returns>
		/// <exception cref="T:System.InvalidOperationException">The listener has not been started with a call to <see cref="M:System.Net.Sockets.TcpListener.Start" />. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		ISocket AcceptSocket();

		/// <summary>Accepts a pending connection request.</summary>
		/// <returns>A <see cref="T:System.Net.Sockets.TcpClient" /> used to send and receive data.</returns>
		/// <exception cref="T:System.InvalidOperationException">The listener has not been started with a call to <see cref="M:System.Net.Sockets.TcpListener.Start" />. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Use the <see cref="P:System.Net.Sockets.SocketException.ErrorCode" /> property to obtain the specific error code. When you have obtained this code, you can refer to the Windows Sockets version 2 API error code documentation in MSDN for a detailed description of the error. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		ITcpClient AcceptTcpClient();
#endif
	}
}
