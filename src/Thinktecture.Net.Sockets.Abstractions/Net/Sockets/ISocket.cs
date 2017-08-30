using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using JetBrains.Annotations;

namespace Thinktecture.Net.Sockets
{
	/// <summary>Implements the Berkeley sockets interface.</summary>
	public interface ISocket : IAbstraction<Socket>, IDisposable
	{
		/// <summary>Gets the address family of the <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <returns>One of the <see cref="T:System.Net.Sockets.AddressFamily" /> values.</returns>
		AddressFamily AddressFamily { get; }

		/// <summary>
		/// Gets the amount of data that has been received from the network and is available to be read.
		/// </summary>
		int Available { get; }

		/// <summary>
		/// Gets or sets a value that indicates whether the Socket is in blocking mode.
		/// </summary>
		bool Blocking { get; set; }

		/// <summary>Gets a value that indicates whether a <see cref="T:System.Net.Sockets.Socket" /> is connected to a remote host as of the last <see cref="Send(byte[])" /> or <see cref="Receive(byte[])" /> operation.</summary>
		/// <returns>true if the <see cref="T:System.Net.Sockets.Socket" /> was connected to a remote resource as of the most recent operation; otherwise, false.</returns>
		bool Connected { get; }

		/// <summary>
		/// Gets or sets a Boolean value that specifies whether the Socket allows Internet Protocol (IP) datagrams to be fragmented.
		/// </summary>
		bool DontFragment { get; set; }

		/// <summary>
		/// Gets or sets a Boolean value that specifies whether the Socket is a dual-mode socket used for both IPv4 and IPv6.
		/// </summary>
		bool DualMode { get; set; }

		/// <summary>
		/// Gets or sets a Boolean value that specifies whether the Socket can send or receive broadcast packets.
		/// </summary>
		bool EnableBroadcast { get; set; }

		/// <summary>
		/// Gets or sets a Boolean value that specifies whether the Socket allows only one process to bind to a port.
		/// </summary>
		bool ExclusiveAddressUse { get; set; }

		/// <summary>
		/// Gets a value that indicates whether the Socket is bound to a specific local port.
		/// </summary>
		bool IsBound { get; }

		/// <summary>
		/// Gets or sets a value that specifies whether the Socket will delay closing a socket in an attempt to send all pending data.
		/// </summary>
		[CanBeNull]
		ILingerOption LingerState { get; set; }

		/// <summary>Gets the local endpoint.</summary>
		/// <returns>The <see cref="T:System.Net.EndPoint" /> that the <see cref="T:System.Net.Sockets.Socket" /> is using for communications.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		[CanBeNull]
		IEndPoint LocalEndPoint { get; }

		/// <summary>
		/// Gets or sets a value that specifies whether outgoing multicast packets are delivered to the sending application.
		/// </summary>
		bool MulticastLoopback { get; set; }

		/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that specifies whether the stream <see cref="T:System.Net.Sockets.Socket" /> is using the Nagle algorithm.</summary>
		/// <returns>false if the <see cref="T:System.Net.Sockets.Socket" /> uses the Nagle algorithm; otherwise, true. The default is false.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the <see cref="T:System.Net.Sockets.Socket" />. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		bool NoDelay { get; set; }

		/// <summary>Gets the protocol type of the <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <returns>One of the <see cref="T:System.Net.Sockets.ProtocolType" /> values.</returns>
		ProtocolType ProtocolType { get; }

		/// <summary>Gets or sets a value that specifies the size of the receive buffer of the <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <returns>An <see cref="T:System.Int32" /> that contains the size, in bytes, of the receive buffer. The default is 8192.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for a set operation is less than 0.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		int ReceiveBufferSize { get; set; }

		/// <summary>
		/// Gets or sets a value that specifies the amount of time after which a synchronous Receive call will time out.
		/// </summary>
		int ReceiveTimeout { get; set; }

		/// <summary>Gets the remote endpoint.</summary>
		/// <returns>The <see cref="T:System.Net.EndPoint" /> with which the <see cref="T:System.Net.Sockets.Socket" /> is communicating.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		[CanBeNull]
		IEndPoint RemoteEndPoint { get; }

		/// <summary>Gets or sets a value that specifies the size of the send buffer of the <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <returns>An <see cref="T:System.Int32" /> that contains the size, in bytes, of the send buffer. The default is 8192.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for a set operation is less than 0.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		int SendBufferSize { get; set; }

		/// <summary>
		/// Gets or sets a value that specifies the amount of time after which a synchronous Send call will time out.
		/// </summary>
		int SendTimeout { get; set; }

		/// <summary>
		/// Gets the type of the Socket.
		/// </summary>
		SocketType SocketType { get; }

		/// <summary>Gets or sets a value that specifies the Time To Live (TTL) value of Internet Protocol (IP) packets sent by the <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <returns>The TTL value.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The TTL value can't be set to a negative number.</exception>
		/// <exception cref="T:System.NotSupportedException">This property can be set only for sockets in the <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> or <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> families.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. This error is also returned when an attempt was made to set TTL to a value higher than 255.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		short Ttl { get; set; }

		/// <summary>
		/// Creates a new Socket for a newly created connection.
		/// </summary>
		/// <returns></returns>
		[NotNull]
		ISocket Accept();

		/// <summary>Begins an asynchronous operation to accept an incoming connection attempt.</summary>
		/// <returns>Returns true if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation.Returns false if the I/O operation completed synchronously. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.</returns>
		/// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
		/// <exception cref="T:System.ArgumentException">An argument is not valid. This exception occurs if the buffer provided is not large enough. The buffer must be at least 2 * (sizeof(SOCKADDR_STORAGE + 16) bytes. This exception also occurs if multiple buffers are specified, the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> property is not null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">An argument is out of range. The exception occurs if the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Count" /> is less than 0.</exception>
		/// <exception cref="T:System.InvalidOperationException">An invalid operation was requested. This exception occurs if the accepting <see cref="T:System.Net.Sockets.Socket" /> is not listening for connections or the accepted socket is bound. You must call the <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" /> and <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" /> method before calling the <see cref="M:System.Net.Sockets.Socket.AcceptAsync(System.Net.Sockets.SocketAsyncEventArgs)" /> method.This exception also occurs if the socket is already connected or a socket operation was already in progress using the specified <paramref name="e" /> parameter. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		bool AcceptAsync([NotNull] SocketAsyncEventArgs e);

		/// <summary>Begins an asynchronous operation to accept an incoming connection attempt.</summary>
		/// <returns>Returns true if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation.Returns false if the I/O operation completed synchronously. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.</returns>
		/// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
		/// <exception cref="T:System.ArgumentException">An argument is not valid. This exception occurs if the buffer provided is not large enough. The buffer must be at least 2 * (sizeof(SOCKADDR_STORAGE + 16) bytes. This exception also occurs if multiple buffers are specified, the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> property is not null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">An argument is out of range. The exception occurs if the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Count" /> is less than 0.</exception>
		/// <exception cref="T:System.InvalidOperationException">An invalid operation was requested. This exception occurs if the accepting <see cref="T:System.Net.Sockets.Socket" /> is not listening for connections or the accepted socket is bound. You must call the <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" /> and <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" /> method before calling the <see cref="M:System.Net.Sockets.Socket.AcceptAsync(System.Net.Sockets.SocketAsyncEventArgs)" /> method.This exception also occurs if the socket is already connected or a socket operation was already in progress using the specified <paramref name="e" /> parameter. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		bool AcceptAsync([NotNull] ISocketAsyncEventArgs e);

		/// <summary>Associates a <see cref="T:System.Net.Sockets.Socket" /> with a local endpoint.</summary>
		/// <param name="localEP">The local <see cref="T:System.Net.EndPoint" /> to associate with the <see cref="T:System.Net.Sockets.Socket" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="localEP" /> is null. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.Security.SecurityException">A caller higher in the call stack does not have permission for the requested operation. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Net.SocketPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// ReSharper disable once InconsistentNaming
		void Bind([NotNull] EndPoint localEP);

		/// <summary>Associates a <see cref="T:System.Net.Sockets.Socket" /> with a local endpoint.</summary>
		/// <param name="localEP">The local <see cref="T:System.Net.EndPoint" /> to associate with the <see cref="T:System.Net.Sockets.Socket" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="localEP" /> is null. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.Security.SecurityException">A caller higher in the call stack does not have permission for the requested operation. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Net.SocketPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// ReSharper disable once InconsistentNaming
		void Bind([NotNull] IEndPoint localEP);

		/// <summary>
		/// Establishes a connection to a remote host.
		/// </summary>
		/// <param name="remoteEP">An EndPoint that represents the remote device.</param>
		// ReSharper disable once InconsistentNaming
		void Connect([NotNull] EndPoint remoteEP);

		/// <summary>
		/// Establishes a connection to a remote host.
		/// </summary>
		/// <param name="remoteEP">An EndPoint that represents the remote device.</param>
		// ReSharper disable once InconsistentNaming
		void Connect([NotNull] IEndPoint remoteEP);

		/// <summary>
		/// Establishes a connection to a remote host. The host is specified by an IP address and a port number.
		/// </summary>
		/// <param name="address">The IP address of the remote host.</param>
		/// <param name="port">The port number of the remote host.</param>
		void Connect([NotNull] IPAddress address, int port);

		/// <summary>
		/// Establishes a connection to a remote host. The host is specified by an IP address and a port number.
		/// </summary>
		/// <param name="address">The IP address of the remote host.</param>
		/// <param name="port">The port number of the remote host.</param>
		void Connect([NotNull] IIPAddress address, int port);

		/// <summary>
		/// Establishes a connection to a remote host. The host is specified by an array of IP addresses and a port number.
		/// </summary>
		/// <param name="addresses">The IP addresses of the remote host.</param>
		/// <param name="port">The port number of the remote host.</param>
		void Connect([NotNull] IPAddress[] addresses, int port);

		/// <summary>
		/// Establishes a connection to a remote host. The host is specified by an array of IP addresses and a port number.
		/// </summary>
		/// <param name="addresses">The IP addresses of the remote host.</param>
		/// <param name="port">The port number of the remote host.</param>
		void Connect([NotNull] IIPAddress[] addresses, int port);

		/// <summary>
		/// Establishes a connection to a remote host. The host is specified by a host name and a port number.
		/// </summary>
		/// <param name="host">The name of the remote host.</param>
		/// <param name="port">The port number of the remote host.</param>
		void Connect([NotNull] string host, int port);

		/// <summary>Begins an asynchronous request for a connection to a remote host.</summary>
		/// <returns>Returns true if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation. Returns false if the I/O operation completed synchronously. In this case, The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation. </returns>
		/// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
		/// <exception cref="T:System.ArgumentException">An argument is not valid. This exception occurs if multiple buffers are specified, the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> property is not null. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="e" /> parameter cannot be null and the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> cannot be null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Net.Sockets.Socket" /> is listening or a socket operation was already in progress using the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object specified in the <paramref name="e" /> parameter.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information.</exception>
		/// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method. This exception also occurs if the local endpoint and the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> are not the same address family.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.Security.SecurityException">A caller higher in the call stack does not have permission for the requested operation.</exception>
		bool ConnectAsync([NotNull] SocketAsyncEventArgs e);

		/// <summary>Begins an asynchronous request for a connection to a remote host.</summary>
		/// <returns>Returns true if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation. Returns false if the I/O operation completed synchronously. In this case, The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation. </returns>
		/// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
		/// <exception cref="T:System.ArgumentException">An argument is not valid. This exception occurs if multiple buffers are specified, the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> property is not null. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="e" /> parameter cannot be null and the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> cannot be null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Net.Sockets.Socket" /> is listening or a socket operation was already in progress using the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object specified in the <paramref name="e" /> parameter.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information.</exception>
		/// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method. This exception also occurs if the local endpoint and the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> are not the same address family.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.Security.SecurityException">A caller higher in the call stack does not have permission for the requested operation.</exception>
		bool ConnectAsync([NotNull] ISocketAsyncEventArgs e);

		/// <summary>
		/// Returns the value of a specified Socket option, represented as an object.
		/// </summary>
		/// <param name="optionLevel">One of the SocketOptionLevel values.</param>
		/// <param name="optionName">One of the SocketOptionName values.</param>
		/// <returns>An object that represents the value of the option. When the optionName parameter is set to Linger the return value is an instance of the LingerOption class. When optionName is set to AddMembership or DropMembership, the return value is an instance of the MulticastOption class. When optionName is any other value, the return value is an integer.</returns>
		[CanBeNull]
		object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName);

		/// <summary>
		/// Returns the specified Socket option setting, represented as a byte array.
		/// </summary>
		/// <param name="optionLevel">One of the SocketOptionLevel values.</param>
		/// <param name="optionName">One of the SocketOptionName values.</param>
		/// <param name="optionValue">An array of type Byte that is to receive the option setting.</param>
		void GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, [CanBeNull] byte[] optionValue);

		/// <summary>
		/// Returns the value of the specified Socket option in an array.
		/// </summary>
		/// <param name="optionLevel">One of the SocketOptionLevel values.</param>
		/// <param name="optionName">One of the SocketOptionName values.</param>
		/// <param name="optionLength">The length, in bytes, of the expected return value.</param>
		/// <returns></returns>
		[NotNull]
		byte[] GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionLength);

		/// <summary>
		/// Sets low-level operating modes for the Socket using numerical control codes.
		/// </summary>
		/// <param name="ioControlCode">An Int32 value that specifies the control code of the operation to perform.</param>
		/// <param name="optionInValue">A Byte array that contains the input data required by the operation.</param>
		/// <param name="optionOutValue">A Byte array that contains the output data returned by the operation.</param>
		/// <returns>The number of bytes in the optionOutValue parameter.</returns>
		// ReSharper disable once InconsistentNaming
		int IOControl(int ioControlCode, [CanBeNull] byte[] optionInValue, [CanBeNull] byte[] optionOutValue);

		/// <summary>
		/// Sets low-level operating modes for the Socket using the IOControlCode enumeration to specify control codes.
		/// </summary>
		/// <param name="ioControlCode">A IOControlCode value that specifies the control code of the operation to perform.</param>
		/// <param name="optionInValue">An array of type Byte that contains the input data required by the operation.</param>
		/// <param name="optionOutValue">An array of type Byte that contains the output data returned by the operation.</param>
		/// <returns>The number of bytes in the optionOutValue parameter.</returns>
		// ReSharper disable once InconsistentNaming
		int IOControl(IOControlCode ioControlCode, [CanBeNull] byte[] optionInValue, [CanBeNull] byte[] optionOutValue);

		/// <summary>Places a <see cref="T:System.Net.Sockets.Socket" /> in a listening state.</summary>
		/// <param name="backlog">The maximum length of the pending connections queue. </param>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		void Listen(int backlog);

		/// <summary>
		/// Determines the status of the Socket.
		/// </summary>
		/// <param name="microSeconds">The time to wait for a response, in microseconds.</param>
		/// <param name="mode">One of the SelectMode values.</param>
		/// <returns>The status of the Socket based on the polling mode value passed in the mode parameter.</returns>
		bool Poll(int microSeconds, SelectMode mode);

		/// <summary>
		/// Receives data from a bound Socket into a receive buffer.
		/// </summary>
		/// <param name="buffer">An array of type Byte that is the storage location for the received data.</param>
		/// <returns>The number of bytes received.</returns>
		int Receive([NotNull] byte[] buffer);

		/// <summary>
		/// Receives the specified number of bytes from a bound Socket into the specified offset position of the receive buffer, using the specified SocketFlags.
		/// </summary>
		/// <param name="buffer">An array of type Byte that is the storage location for received data.</param>
		/// <param name="offset">The location in buffer to store the received data.</param>
		/// <param name="size">The number of bytes to receive.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <returns>The number of bytes received.</returns>
		int Receive([NotNull] byte[] buffer, int offset, int size, SocketFlags socketFlags);

		/// <summary>
		/// Receives data from a bound Socket into a receive buffer, using the specified SocketFlags.
		/// </summary>
		/// <param name="buffer">An array of type Byte that is the storage location for the received data.</param>
		/// <param name="offset">The position in the buffer parameter to store the received data.</param>
		/// <param name="size">The number of bytes to receive.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <param name="errorCode">A SocketError object that stores the socket error.</param>
		/// <returns>The number of bytes received.</returns>
		int Receive([NotNull] byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode);

		/// <summary>
		/// Receives the specified number of bytes of data from a bound Socket into a receive buffer, using the specified SocketFlags.
		/// </summary>
		/// <param name="buffer">An array of type Byte that is the storage location for the received data.</param>
		/// <param name="size">The number of bytes to receive.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <returns>The number of bytes received.</returns>
		int Receive([NotNull] byte[] buffer, int size, SocketFlags socketFlags);

		/// <summary>
		/// Receives data from a bound Socket into a receive buffer, using the specified SocketFlags.
		/// </summary>
		/// <param name="buffer">An array of type Byte that is the storage location for the received data.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <returns>The number of bytes received.</returns>
		int Receive([NotNull] byte[] buffer, SocketFlags socketFlags);

		/// <summary>
		/// Receives data from a bound Socket into the list of receive buffers.
		/// </summary>
		/// <param name="buffers">A list of ArraySegments of type Byte that contains the received data.</param>
		/// <returns>The number of bytes received.</returns>
		int Receive([NotNull] IList<ArraySegment<byte>> buffers);

		/// <summary>
		/// Receives data from a bound Socket into the list of receive buffers, using the specified SocketFlags.
		/// </summary>
		/// <param name="buffers">A list of ArraySegments of type Byte that contains the received data.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <returns>The number of bytes received.</returns>
		int Receive([NotNull] IList<ArraySegment<byte>> buffers, SocketFlags socketFlags);

		/// <summary>
		/// Receives data from a bound Socket into the list of receive buffers, using the specified SocketFlags.
		/// </summary>
		/// <param name="buffers">A list of ArraySegments of type Byte that contains the received data.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <param name="errorCode">A SocketError object that stores the socket error.</param>
		/// <returns>The number of bytes received.</returns>
		int Receive([NotNull] IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode);

		/// <summary>Begins an asynchronous request to receive data from a connected <see cref="T:System.Net.Sockets.Socket" /> object.</summary>
		/// <returns>Returns true if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation. Returns false if the I/O operation completed synchronously. In this case, The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.</returns>
		/// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
		/// <exception cref="T:System.ArgumentException">An argument was invalid. The <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> or <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> properties on the <paramref name="e" /> parameter must reference valid buffers. One or the other of these properties may be set, but not both at the same time.</exception>
		/// <exception cref="T:System.InvalidOperationException">A socket operation was already in progress using the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object specified in the <paramref name="e" /> parameter.</exception>
		/// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		bool ReceiveAsync([NotNull] SocketAsyncEventArgs e);

		/// <summary>Begins an asynchronous request to receive data from a connected <see cref="T:System.Net.Sockets.Socket" /> object.</summary>
		/// <returns>Returns true if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation. Returns false if the I/O operation completed synchronously. In this case, The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.</returns>
		/// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
		/// <exception cref="T:System.ArgumentException">An argument was invalid. The <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> or <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> properties on the <paramref name="e" /> parameter must reference valid buffers. One or the other of these properties may be set, but not both at the same time.</exception>
		/// <exception cref="T:System.InvalidOperationException">A socket operation was already in progress using the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object specified in the <paramref name="e" /> parameter.</exception>
		/// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		bool ReceiveAsync([NotNull] ISocketAsyncEventArgs e);

		/// <summary>
		/// Receives the specified number of bytes of data into the specified location of the data buffer, using the specified SocketFlags, and stores the endpoint.
		/// </summary>
		/// <param name="buffer">An array of type Byte that is the storage location for received data.</param>
		/// <param name="offset">The position in the buffer parameter to store the received data.</param>
		/// <param name="size">The number of bytes to receive.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <param name="remoteEP">An EndPoint, passed by reference, that represents the remote server.</param>
		/// <returns>The number of bytes received.</returns>
		// ReSharper disable once InconsistentNaming
		int ReceiveFrom([NotNull] byte[] buffer, int offset, int size, SocketFlags socketFlags, [CanBeNull] ref EndPoint remoteEP);

		/// <summary>
		/// Receives the specified number of bytes of data into the specified location of the data buffer, using the specified SocketFlags, and stores the endpoint.
		/// </summary>
		/// <param name="buffer">An array of type Byte that is the storage location for received data.</param>
		/// <param name="offset">The position in the buffer parameter to store the received data.</param>
		/// <param name="size">The number of bytes to receive.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <param name="remoteEP">An EndPoint, passed by reference, that represents the remote server.</param>
		/// <returns>The number of bytes received.</returns>
		// ReSharper disable once InconsistentNaming
		int ReceiveFrom([NotNull] byte[] buffer, int offset, int size, SocketFlags socketFlags, [CanBeNull] ref IEndPoint remoteEP);

		/// <summary>
		/// Receives the specified number of bytes into the data buffer, using the specified SocketFlags, and stores the endpoint.
		/// </summary>
		/// <param name="buffer">An array of type Byte that is the storage location for received data.</param>
		/// <param name="size">The number of bytes to receive.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <param name="remoteEP">An EndPoint, passed by reference, that represents the remote server.</param>
		/// <returns>The number of bytes received.</returns>
		// ReSharper disable once InconsistentNaming
		int ReceiveFrom([NotNull] byte[] buffer, int size, SocketFlags socketFlags, [CanBeNull] ref EndPoint remoteEP);

		/// <summary>
		/// Receives the specified number of bytes into the data buffer, using the specified SocketFlags, and stores the endpoint.
		/// </summary>
		/// <param name="buffer">An array of type Byte that is the storage location for received data.</param>
		/// <param name="size">The number of bytes to receive.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <param name="remoteEP">An EndPoint, passed by reference, that represents the remote server.</param>
		/// <returns>The number of bytes received.</returns>
		// ReSharper disable once InconsistentNaming
		int ReceiveFrom([NotNull] byte[] buffer, int size, SocketFlags socketFlags, [CanBeNull] ref IEndPoint remoteEP);

		/// <summary>
		/// Receives a datagram into the data buffer and stores the endpoint.
		/// </summary>
		/// <param name="buffer">An array of type Byte that is the storage location for received data.</param>
		/// <param name="remoteEP">An EndPoint, passed by reference, that represents the remote server.</param>
		/// <returns>The number of bytes received.</returns>
		// ReSharper disable once InconsistentNaming
		int ReceiveFrom([NotNull] byte[] buffer, [CanBeNull] ref EndPoint remoteEP);

		/// <summary>
		/// Receives a datagram into the data buffer and stores the endpoint.
		/// </summary>
		/// <param name="buffer">An array of type Byte that is the storage location for received data.</param>
		/// <param name="remoteEP">An EndPoint, passed by reference, that represents the remote server.</param>
		/// <returns>The number of bytes received.</returns>
		// ReSharper disable once InconsistentNaming
		int ReceiveFrom([NotNull] byte[] buffer, [CanBeNull] ref IEndPoint remoteEP);

		/// <summary>
		/// Receives a datagram into the data buffer, using the specified SocketFlags, and stores the endpoint.
		/// </summary>
		/// <param name="buffer">An array of type Byte that is the storage location for the received data.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <param name="remoteEP">An EndPoint, passed by reference, that represents the remote server.</param>
		/// <returns>The number of bytes received.</returns>
		// ReSharper disable once InconsistentNaming
		int ReceiveFrom([NotNull] byte[] buffer, SocketFlags socketFlags, [CanBeNull] ref EndPoint remoteEP);

		/// <summary>
		/// Receives a datagram into the data buffer, using the specified SocketFlags, and stores the endpoint.
		/// </summary>
		/// <param name="buffer">An array of type Byte that is the storage location for the received data.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <param name="remoteEP">An EndPoint, passed by reference, that represents the remote server.</param>
		/// <returns>The number of bytes received.</returns>
		// ReSharper disable once InconsistentNaming
		int ReceiveFrom([NotNull] byte[] buffer, SocketFlags socketFlags, [CanBeNull] ref IEndPoint remoteEP);

		/// <summary>Begins to asynchronously receive data from a specified network device.</summary>
		/// <returns>Returns true if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation. Returns false if the I/O operation completed synchronously. In this case, The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.</returns>
		/// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> cannot be null.</exception>
		/// <exception cref="T:System.InvalidOperationException">A socket operation was already in progress using the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object specified in the <paramref name="e" /> parameter.</exception>
		/// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. </exception>
		bool ReceiveFromAsync([NotNull] SocketAsyncEventArgs e);

		/// <summary>Begins to asynchronously receive data from a specified network device.</summary>
		/// <returns>Returns true if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation. Returns false if the I/O operation completed synchronously. In this case, The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.</returns>
		/// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> cannot be null.</exception>
		/// <exception cref="T:System.InvalidOperationException">A socket operation was already in progress using the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object specified in the <paramref name="e" /> parameter.</exception>
		/// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. </exception>
		bool ReceiveFromAsync([NotNull] ISocketAsyncEventArgs e);

		/// <summary>
		/// Receives the specified number of bytes of data into the specified location of the data buffer, using the specified SocketFlags, and stores the endpoint and packet information.
		/// </summary>
		/// <param name="buffer">An array of type Byte that is the storage location for received data.</param>
		/// <param name="offset">The position in the buffer parameter to store the received data.</param>
		/// <param name="size">The number of bytes to receive.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <param name="remoteEP">An EndPoint, passed by reference, that represents the remote server.</param>
		/// <param name="ipPacketInformation">An IPPacketInformation holding address and interface information.</param>
		/// <returns>The number of bytes received.</returns>
		// ReSharper disable once InconsistentNaming
		int ReceiveMessageFrom([NotNull] byte[] buffer, int offset, int size, ref SocketFlags socketFlags, [CanBeNull] ref EndPoint remoteEP, out IPPacketInformation ipPacketInformation);

		/// <summary>
		/// Receives the specified number of bytes of data into the specified location of the data buffer, using the specified SocketFlags, and stores the endpoint and packet information.
		/// </summary>
		/// <param name="buffer">An array of type Byte that is the storage location for received data.</param>
		/// <param name="offset">The position in the buffer parameter to store the received data.</param>
		/// <param name="size">The number of bytes to receive.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <param name="remoteEP">An EndPoint, passed by reference, that represents the remote server.</param>
		/// <param name="ipPacketInformation">An IPPacketInformation holding address and interface information.</param>
		/// <returns>The number of bytes received.</returns>
		// ReSharper disable once InconsistentNaming
		int ReceiveMessageFrom([NotNull] byte[] buffer, int offset, int size, ref SocketFlags socketFlags, [CanBeNull] ref IEndPoint remoteEP, out IPPacketInformation ipPacketInformation);

		/// <summary>
		/// Begins to asynchronously receive the specified number of bytes of data into the specified location in the data buffer, using the specified SocketAsyncEventArgs.SocketFlags, and stores the endpoint and packet information.
		/// </summary>
		/// <param name="e">The System.Net.Sockets.SocketAsyncEventArgs object to use for this asynchronous socket operation.</param>
		/// <returns>
		/// Returns true if the I/O operation is pending. The SocketAsyncEventArgs.Completed event on the e parameter will be raised upon completion of the operation.
		/// Returns false if the I/O operation completed synchronously.In this case, The SocketAsyncEventArgs.Completed event on the e parameter will not be raised and the e object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.
		/// </returns>
		bool ReceiveMessageFromAsync([NotNull] SocketAsyncEventArgs e);

		/// <summary>
		/// Begins to asynchronously receive the specified number of bytes of data into the specified location in the data buffer, using the specified SocketAsyncEventArgs.SocketFlags, and stores the endpoint and packet information.
		/// </summary>
		/// <param name="e">The System.Net.Sockets.SocketAsyncEventArgs object to use for this asynchronous socket operation.</param>
		/// <returns>
		/// Returns true if the I/O operation is pending. The SocketAsyncEventArgs.Completed event on the e parameter will be raised upon completion of the operation.
		/// Returns false if the I/O operation completed synchronously.In this case, The SocketAsyncEventArgs.Completed event on the e parameter will not be raised and the e object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.
		/// </returns>
		bool ReceiveMessageFromAsync([NotNull] ISocketAsyncEventArgs e);

		/// <summary>
		/// Sends data to a connected Socket.
		/// </summary>
		/// <param name="buffer">An array of type Byte that contains the data to be sent.</param>
		/// <returns>The number of bytes sent to the Socket.</returns>
		int Send([NotNull] byte[] buffer);

		/// <summary>
		/// Sends the specified number of bytes of data to a connected Socket, starting at the specified offset, and using the specified SocketFlags.
		/// </summary>
		/// <param name="buffer">An array of type Byte that contains the data to be sent.</param>
		/// <param name="offset">The position in the data buffer at which to begin sending data.</param>
		/// <param name="size">The number of bytes to send.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <returns>The number of bytes sent to the Socket.</returns>
		int Send([NotNull] byte[] buffer, int offset, int size, SocketFlags socketFlags);

		/// <summary>
		/// Sends the specified number of bytes of data to a connected Socket, starting at the specified offset, and using the specified SocketFlags.
		/// </summary>
		/// <param name="buffer">An array of type Byte that contains the data to be sent.</param>
		/// <param name="offset">The position in the data buffer at which to begin sending data.</param>
		/// <param name="size">The number of bytes to send.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <param name="errorCode">A SocketError object that stores the socket error.</param>
		/// <returns>The number of bytes sent to the Socket.</returns>
		int Send([NotNull] byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode);

		/// <summary>
		/// Sends the specified number of bytes of data to a connected Socket, using the specified SocketFlags.
		/// </summary>
		/// <param name="buffer">An array of type Byte that contains the data to be sent.</param>
		/// <param name="size">The number of bytes to send.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <returns>The number of bytes sent to the Socket.</returns>
		int Send([NotNull] byte[] buffer, int size, SocketFlags socketFlags);

		/// <summary>
		/// Sends data to a connected Socket using the specified SocketFlags.
		/// </summary>
		/// <param name="buffer">An array of type Byte that contains the data to be sent.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <returns>The number of bytes sent to the Socket.</returns>
		int Send([NotNull] byte[] buffer, SocketFlags socketFlags);

		/// <summary>
		/// Sends data to a connected Socket using the specified SocketFlags.
		/// </summary>
		/// <param name="buffers">A list of ArraySegments of type Byte that contains the data to be sent.</param>
		/// <returns>The number of bytes sent to the Socket.</returns>
		int Send([NotNull] IList<ArraySegment<byte>> buffers);

		/// <summary>
		/// Sends the set of buffers in the list to a connected Socket, using the specified SocketFlags.
		/// </summary>
		/// <param name="buffers">A list of ArraySegments of type Byte that contains the data to be sent.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <returns>The number of bytes sent to the Socket.</returns>
		int Send([NotNull] IList<ArraySegment<byte>> buffers, SocketFlags socketFlags);

		/// <summary>
		/// Sends the set of buffers in the list to a connected Socket, using the specified SocketFlags.
		/// </summary>
		/// <param name="buffers">A list of ArraySegments of type Byte that contains the data to be sent.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <param name="errorCode">A SocketError object that stores the socket error.</param>
		/// <returns>The number of bytes sent to the Socket.</returns>
		int Send([NotNull] IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode);

		/// <summary>Sends data asynchronously to a connected <see cref="T:System.Net.Sockets.Socket" /> object.</summary>
		/// <returns>Returns true if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation. Returns false if the I/O operation completed synchronously. In this case, The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.</returns>
		/// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
		/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> or <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> properties on the <paramref name="e" /> parameter must reference valid buffers. One or the other of these properties may be set, but not both at the same time.</exception>
		/// <exception cref="T:System.InvalidOperationException">A socket operation was already in progress using the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object specified in the <paramref name="e" /> parameter.</exception>
		/// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">The <see cref="T:System.Net.Sockets.Socket" /> is not yet connected or was not obtained via an <see cref="M:System.Net.Sockets.Socket.Accept" />, <see cref="M:System.Net.Sockets.Socket.AcceptAsync(System.Net.Sockets.SocketAsyncEventArgs)" /> method.</exception>
		bool SendAsync([NotNull] SocketAsyncEventArgs e);

		/// <summary>Sends data asynchronously to a connected <see cref="T:System.Net.Sockets.Socket" /> object.</summary>
		/// <returns>Returns true if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation. Returns false if the I/O operation completed synchronously. In this case, The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.</returns>
		/// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
		/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> or <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> properties on the <paramref name="e" /> parameter must reference valid buffers. One or the other of these properties may be set, but not both at the same time.</exception>
		/// <exception cref="T:System.InvalidOperationException">A socket operation was already in progress using the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object specified in the <paramref name="e" /> parameter.</exception>
		/// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">The <see cref="T:System.Net.Sockets.Socket" /> is not yet connected or was not obtained via an <see cref="M:System.Net.Sockets.Socket.Accept" />, <see cref="M:System.Net.Sockets.Socket.AcceptAsync(System.Net.Sockets.SocketAsyncEventArgs)" /> method.</exception>
		bool SendAsync([NotNull] ISocketAsyncEventArgs e);

		/// <summary>
		/// Sends a collection of files or in memory data buffers asynchronously to a connected Socket object.
		/// </summary>
		/// <param name="e">The System.Net.Sockets.SocketAsyncEventArgs object to use for this asynchronous socket operation.</param>
		/// <returns>
		/// Returns true if the I/O operation is pending. The SocketAsyncEventArgs.Completed event on the e parameter will be raised upon completion of the operation.
		/// Returns false if the I/O operation completed synchronously.In this case, The SocketAsyncEventArgs.Completed event on the e parameter will not be raised and the e object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.
		/// </returns>
		bool SendPacketsAsync([NotNull] SocketAsyncEventArgs e);

		/// <summary>
		/// Sends a collection of files or in memory data buffers asynchronously to a connected Socket object.
		/// </summary>
		/// <param name="e">The System.Net.Sockets.SocketAsyncEventArgs object to use for this asynchronous socket operation.</param>
		/// <returns>
		/// Returns true if the I/O operation is pending. The SocketAsyncEventArgs.Completed event on the e parameter will be raised upon completion of the operation.
		/// Returns false if the I/O operation completed synchronously.In this case, The SocketAsyncEventArgs.Completed event on the e parameter will not be raised and the e object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.
		/// </returns>
		bool SendPacketsAsync([NotNull] ISocketAsyncEventArgs e);

		/// <summary>
		/// Sends the specified number of bytes of data to the specified endpoint, starting at the specified location in the buffer, and using the specified SocketFlags.
		/// </summary>
		/// <param name="buffer">An array of type Byte that contains the data to be sent.</param>
		/// <param name="offset">The position in the data buffer at which to begin sending data.</param>
		/// <param name="size">The number of bytes to send.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <param name="remoteEP">The EndPoint that represents the destination location for the data.</param>
		/// <returns>The number of bytes sent.</returns>
		// ReSharper disable once InconsistentNaming
		int SendTo([NotNull] byte[] buffer, int offset, int size, SocketFlags socketFlags, [NotNull] EndPoint remoteEP);

		/// <summary>
		/// Sends the specified number of bytes of data to the specified endpoint, starting at the specified location in the buffer, and using the specified SocketFlags.
		/// </summary>
		/// <param name="buffer">An array of type Byte that contains the data to be sent.</param>
		/// <param name="offset">The position in the data buffer at which to begin sending data.</param>
		/// <param name="size">The number of bytes to send.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <param name="remoteEP">The EndPoint that represents the destination location for the data.</param>
		/// <returns>The number of bytes sent.</returns>
		// ReSharper disable once InconsistentNaming
		int SendTo([NotNull] byte[] buffer, int offset, int size, SocketFlags socketFlags, [NotNull] IEndPoint remoteEP);

		/// <summary>
		/// Sends the specified number of bytes of data to the specified endpoint using the specified SocketFlags.
		/// </summary>
		/// <param name="buffer">An array of type Byte that contains the data to be sent.</param>
		/// <param name="size">The number of bytes to send.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <param name="remoteEP">The EndPoint that represents the destination location for the data.</param>
		/// <returns>The number of bytes sent.</returns>
		// ReSharper disable once InconsistentNaming
		int SendTo([NotNull] byte[] buffer, int size, SocketFlags socketFlags, [NotNull] EndPoint remoteEP);

		/// <summary>
		/// Sends the specified number of bytes of data to the specified endpoint using the specified SocketFlags.
		/// </summary>
		/// <param name="buffer">An array of type Byte that contains the data to be sent.</param>
		/// <param name="size">The number of bytes to send.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <param name="remoteEP">The EndPoint that represents the destination location for the data.</param>
		/// <returns>The number of bytes sent.</returns>
		// ReSharper disable once InconsistentNaming
		int SendTo([NotNull] byte[] buffer, int size, SocketFlags socketFlags, [NotNull] IEndPoint remoteEP);

		/// <summary>
		/// Sends data to the specified endpoint.
		/// </summary>
		/// <param name="buffer">An array of type Byte that contains the data to be sent.</param>
		/// <param name="remoteEP">The EndPoint that represents the destination for the data.</param>
		/// <returns>The number of bytes sent.</returns>
		// ReSharper disable once InconsistentNaming
		int SendTo([NotNull] byte[] buffer, [NotNull] EndPoint remoteEP);

		/// <summary>
		/// Sends data to the specified endpoint.
		/// </summary>
		/// <param name="buffer">An array of type Byte that contains the data to be sent.</param>
		/// <param name="remoteEP">The EndPoint that represents the destination for the data.</param>
		/// <returns>The number of bytes sent.</returns>
		// ReSharper disable once InconsistentNaming
		int SendTo([NotNull] byte[] buffer, [NotNull] IEndPoint remoteEP);

		/// <summary>
		/// Sends data to a specific endpoint using the specified SocketFlags.
		/// </summary>
		/// <param name="buffer">An array of type Byte that contains the data to be sent.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <param name="remoteEP">The EndPoint that represents the destination location for the data.</param>
		/// <returns>The number of bytes sent.</returns>
		// ReSharper disable once InconsistentNaming
		int SendTo([NotNull] byte[] buffer, SocketFlags socketFlags, [NotNull] EndPoint remoteEP);

		/// <summary>
		/// Sends data to a specific endpoint using the specified SocketFlags.
		/// </summary>
		/// <param name="buffer">An array of type Byte that contains the data to be sent.</param>
		/// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
		/// <param name="remoteEP">The EndPoint that represents the destination location for the data.</param>
		/// <returns>The number of bytes sent.</returns>
		// ReSharper disable once InconsistentNaming
		int SendTo([NotNull] byte[] buffer, SocketFlags socketFlags, [NotNull] IEndPoint remoteEP);

		/// <summary>Sends data asynchronously to a specific remote host.</summary>
		/// <returns>Returns true if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation. Returns false if the I/O operation completed synchronously. In this case, The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.</returns>
		/// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> cannot be null.</exception>
		/// <exception cref="T:System.InvalidOperationException">A socket operation was already in progress using the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object specified in the <paramref name="e" /> parameter.</exception>
		/// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">The protocol specified is connection-oriented, but the <see cref="T:System.Net.Sockets.Socket" /> is not yet connected.</exception>
		bool SendToAsync([NotNull] SocketAsyncEventArgs e);

		/// <summary>Sends data asynchronously to a specific remote host.</summary>
		/// <returns>Returns true if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation. Returns false if the I/O operation completed synchronously. In this case, The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.</returns>
		/// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> cannot be null.</exception>
		/// <exception cref="T:System.InvalidOperationException">A socket operation was already in progress using the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object specified in the <paramref name="e" /> parameter.</exception>
		/// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">The protocol specified is connection-oriented, but the <see cref="T:System.Net.Sockets.Socket" /> is not yet connected.</exception>
		bool SendToAsync([NotNull] ISocketAsyncEventArgs e);

		/// <summary>
		/// Sets the specified Socket option to the specified Boolean value.
		/// </summary>
		/// <param name="optionLevel">One of the SocketOptionLevel values.</param>
		/// <param name="optionName">One of the SocketOptionName values.</param>
		/// <param name="optionValue">The value of the option, represented as a Boolean.</param>
		void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, bool optionValue);

		/// <summary>
		/// Sets the specified Socket option to the specified value, represented as a byte array.
		/// </summary>
		/// <param name="optionLevel">One of the SocketOptionLevel values.</param>
		/// <param name="optionName">One of the SocketOptionName values.</param>
		/// <param name="optionValue">An array of type Byte that represents the value of the option.</param>
		void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, [CanBeNull] byte[] optionValue);

		/// <summary>
		/// Sets the specified Socket option to the specified integer value.
		/// </summary>
		/// <param name="optionLevel">One of the SocketOptionLevel values.</param>
		/// <param name="optionName">One of the SocketOptionName values.</param>
		/// <param name="optionValue">A value of the option.</param>
		void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue);

		/// <summary>
		/// Sets the specified Socket option to the specified value, represented as an object.
		/// </summary>
		/// <param name="optionLevel">One of the SocketOptionLevel values.</param>
		/// <param name="optionName">One of the SocketOptionName values.</param>
		/// <param name="optionValue">A LingerOption or MulticastOption that contains the value of the option.</param>
		void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, [CanBeNull] object optionValue);

		/// <summary>Disables sends and receives on a <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <param name="how">One of the <see cref="T:System.Net.Sockets.SocketShutdown" /> values that specifies the operation that will no longer be allowed. </param>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		void Shutdown(SocketShutdown how);
	}
}
