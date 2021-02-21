using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

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
      [DisallowNull]
      ILingerOption? LingerState { get; set; }

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
      Task ConnectAsync(IPAddress address, int port);

      /// <summary>
      /// Connects the client to a remote TCP host using the specified IP address and port number as an asynchronous operation.
      /// </summary>
      /// <param name="address">The IPAddress of the host to which you intend to connect.</param>
      /// <param name="port">The port number to which you intend to connect.</param>
      /// <returns></returns>
      Task ConnectAsync(IIPAddress address, int port);

#if NET5_0
      /// <summary>
      /// Connects the client to a remote TCP host using the specified IP address and port number as an asynchronous operation.
      /// </summary>
      /// <param name="address">The IPAddress of the host to which you intend to connect.</param>
      /// <param name="port">The port number to which you intend to connect.</param>
      /// <param name="cancellationToken">Cancellation token.</param>
      /// <returns></returns>
      ValueTask ConnectAsync(IIPAddress address, int port, CancellationToken cancellationToken);

      /// <summary>
      /// Connects the client to a remote TCP host using the specified IP address and port number as an asynchronous operation.
      /// </summary>
      /// <param name="address">The IPAddress of the host to which you intend to connect.</param>
      /// <param name="port">The port number to which you intend to connect.</param>
      /// <param name="cancellationToken">Cancellation token.</param>
      /// <returns></returns>
      ValueTask ConnectAsync(IPAddress address, int port, CancellationToken cancellationToken);
#endif

      /// <summary>
      /// Connects the client to a remote TCP host using the specified IP addresses and port number as an asynchronous operation.
      /// </summary>
      /// <param name="addresses">The IPAddress array of the host to which you intend to connect.</param>
      /// <param name="port">The port number to which you intend to connect.</param>
      /// <returns></returns>
      Task ConnectAsync(IPAddress[] addresses, int port);

      /// <summary>
      /// Connects the client to a remote TCP host using the specified IP addresses and port number as an asynchronous operation.
      /// </summary>
      /// <param name="addresses">The IPAddress array of the host to which you intend to connect.</param>
      /// <param name="port">The port number to which you intend to connect.</param>
      /// <returns></returns>
      Task ConnectAsync(IIPAddress[] addresses, int port);

#if NET5_0
      /// <summary>
      /// Connects the client to a remote TCP host using the specified IP addresses and port number as an asynchronous operation.
      /// </summary>
      /// <param name="addresses">The IPAddress array of the host to which you intend to connect.</param>
      /// <param name="port">The port number to which you intend to connect.</param>
      /// <param name="cancellationToken">Cancellation token.</param>
      /// <returns></returns>
      ValueTask ConnectAsync(IPAddress[] addresses, int port, CancellationToken cancellationToken);

      /// <summary>
      /// Connects the client to a remote TCP host using the specified IP addresses and port number as an asynchronous operation.
      /// </summary>
      /// <param name="addresses">The IPAddress array of the host to which you intend to connect.</param>
      /// <param name="port">The port number to which you intend to connect.</param>
      /// <param name="cancellationToken">Cancellation token.</param>
      /// <returns></returns>
      ValueTask ConnectAsync(IIPAddress[] addresses, int port, CancellationToken cancellationToken);
#endif

      /// <summary>
      /// Connects the client to the specified TCP port on the specified host as an asynchronous operation.
      /// </summary>
      /// <param name="host">The DNS name of the remote host to which you intend to connect.</param>
      /// <param name="port">The port number of the remote host to which you intend to connect.</param>
      /// <returns></returns>
      Task ConnectAsync(string host, int port);

#if NET5_0
      /// <summary>
      /// Connects the client to the specified TCP port on the specified host as an asynchronous operation.
      /// </summary>
      /// <param name="host">The DNS name of the remote host to which you intend to connect.</param>
      /// <param name="port">The port number of the remote host to which you intend to connect.</param>
      /// <param name="cancellationToken">Cancellation token.</param>
      /// <returns></returns>
      ValueTask ConnectAsync(string host, int port, CancellationToken cancellationToken);
#endif

      /// <summary>
      /// Returns the NetworkStream used to send and receive data.
      /// </summary>
      /// <returns>The underlying NetworkStream.</returns>
      INetworkStream GetStream();

      /// <summary>Connects the client to the specified port on the specified host.</summary>
      /// <param name="hostname">The DNS name of the remote host to which you intend to connect. </param>
      /// <param name="port">The port number of the remote host to which you intend to connect. </param>
      /// <exception cref="T:System.ArgumentNullException">The <paramref name="hostname" /> parameter is null. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="port" /> parameter is not between <see cref="F:System.Net.IPEndPoint.MinPort" /> and <see cref="F:System.Net.IPEndPoint.MaxPort" />. </exception>
      /// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket. See the Remarks section for more information. </exception>
      /// <exception cref="T:System.ObjectDisposedException">
      /// <see cref="T:System.Net.Sockets.TcpClient" /> is closed. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Net.SocketPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void Connect(string hostname, int port);

      /// <summary>Connects the client to a remote TCP host using the specified IP address and port number.</summary>
      /// <param name="address">The <see cref="T:System.Net.IPAddress" /> of the host to which you intend to connect. </param>
      /// <param name="port">The port number to which you intend to connect. </param>
      /// <exception cref="T:System.ArgumentNullException">The <paramref name="address" /> parameter is null. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="port" /> is not between <see cref="F:System.Net.IPEndPoint.MinPort" /> and <see cref="F:System.Net.IPEndPoint.MaxPort" />. </exception>
      /// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket. See the Remarks section for more information. </exception>
      /// <exception cref="T:System.ObjectDisposedException">
      /// <see cref="T:System.Net.Sockets.TcpClient" /> is closed. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Net.SocketPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void Connect(IPAddress address, int port);

      /// <summary>Connects the client to a remote TCP host using the specified IP address and port number.</summary>
      /// <param name="address">The <see cref="T:System.Net.IPAddress" /> of the host to which you intend to connect. </param>
      /// <param name="port">The port number to which you intend to connect. </param>
      /// <exception cref="T:System.ArgumentNullException">The <paramref name="address" /> parameter is null. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="port" /> is not between <see cref="F:System.Net.IPEndPoint.MinPort" /> and <see cref="F:System.Net.IPEndPoint.MaxPort" />. </exception>
      /// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket. See the Remarks section for more information. </exception>
      /// <exception cref="T:System.ObjectDisposedException">
      /// <see cref="T:System.Net.Sockets.TcpClient" /> is closed. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Net.SocketPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void Connect(IIPAddress address, int port);

      /// <summary>Connects the client to a remote TCP host using the specified remote network endpoint.</summary>
      /// <param name="remoteEp">The <see cref="T:System.Net.IPEndPoint" /> to which you intend to connect. </param>
      /// <exception cref="T:System.ArgumentNullException">The <paramref name="remoteEp" /> parameter is null. </exception>
      /// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket. See the Remarks section for more information. </exception>
      /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.TcpClient" /> is closed. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Net.SocketPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void Connect(IPEndPoint remoteEp);

      /// <summary>Connects the client to a remote TCP host using the specified remote network endpoint.</summary>
      /// <param name="remoteEp">The <see cref="T:System.Net.IPEndPoint" /> to which you intend to connect. </param>
      /// <exception cref="T:System.ArgumentNullException">The <paramref name="remoteEp" /> parameter is null. </exception>
      /// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket. See the Remarks section for more information. </exception>
      /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.TcpClient" /> is closed. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Net.SocketPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void Connect(IIPEndPoint remoteEp);

      /// <summary>Connects the client to a remote TCP host using the specified IP addresses and port number.</summary>
      /// <param name="ipAddresses">The <see cref="T:System.Net.IPAddress" /> array of the host to which you intend to connect.</param>
      /// <param name="port">The port number to which you intend to connect.</param>
      /// <exception cref="T:System.ArgumentNullException">The <paramref name="ipAddresses" /> parameter is null. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">The port number is not valid.</exception>
      /// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
      /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
      /// <exception cref="T:System.Security.SecurityException">A caller higher in the call stack does not have permission for the requested operation. </exception>
      /// <exception cref="T:System.NotSupportedException">This method is valid for sockets that use the <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> flag or the <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> flag.</exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Net.SocketPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void Connect(IPAddress[] ipAddresses, int port);

      /// <summary>Connects the client to a remote TCP host using the specified IP addresses and port number.</summary>
      /// <param name="ipAddresses">The <see cref="T:System.Net.IPAddress" /> array of the host to which you intend to connect.</param>
      /// <param name="port">The port number to which you intend to connect.</param>
      /// <exception cref="T:System.ArgumentNullException">The <paramref name="ipAddresses" /> parameter is null. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">The port number is not valid.</exception>
      /// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
      /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
      /// <exception cref="T:System.Security.SecurityException">A caller higher in the call stack does not have permission for the requested operation. </exception>
      /// <exception cref="T:System.NotSupportedException">This method is valid for sockets that use the <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> flag or the <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> flag.</exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Net.SocketPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void Connect(IIPAddress[] ipAddresses, int port);

      /// <summary>Disposes this <see cref="T:System.Net.Sockets.TcpClient" /> instance and requests that the underlying TCP connection be closed.</summary>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
      /// </PermissionSet>
      void Close();
   }
}
