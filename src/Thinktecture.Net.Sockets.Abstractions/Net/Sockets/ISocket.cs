using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Versioning;

// ReSharper disable InconsistentNaming
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
      [DisallowNull]
      ILingerOption? LingerState { get; set; }

      /// <summary>Gets the local endpoint.</summary>
      /// <returns>The <see cref="T:System.Net.EndPoint" /> that the <see cref="T:System.Net.Sockets.Socket" /> is using for communications.</returns>
      /// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
      /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
      /// </PermissionSet>
      IEndPoint? LocalEndPoint { get; }

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
      IEndPoint? RemoteEndPoint { get; }

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
      bool AcceptAsync(SocketAsyncEventArgs e);

      /// <summary>Begins an asynchronous operation to accept an incoming connection attempt.</summary>
      /// <returns>Returns true if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation.Returns false if the I/O operation completed synchronously. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.</returns>
      /// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
      /// <exception cref="T:System.ArgumentException">An argument is not valid. This exception occurs if the buffer provided is not large enough. The buffer must be at least 2 * (sizeof(SOCKADDR_STORAGE + 16) bytes. This exception also occurs if multiple buffers are specified, the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> property is not null.</exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">An argument is out of range. The exception occurs if the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Count" /> is less than 0.</exception>
      /// <exception cref="T:System.InvalidOperationException">An invalid operation was requested. This exception occurs if the accepting <see cref="T:System.Net.Sockets.Socket" /> is not listening for connections or the accepted socket is bound. You must call the <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" /> and <see cref="M:System.Net.Sockets.Socket.Listen(System.Int32)" /> method before calling the <see cref="M:System.Net.Sockets.Socket.AcceptAsync(System.Net.Sockets.SocketAsyncEventArgs)" /> method.This exception also occurs if the socket is already connected or a socket operation was already in progress using the specified <paramref name="e" /> parameter. </exception>
      /// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
      /// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method.</exception>
      /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
      bool AcceptAsync(ISocketAsyncEventArgs e);

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
      void Bind(EndPoint localEP);

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
      void Bind(IEndPoint localEP);

      /// <summary>
      /// Establishes a connection to a remote host.
      /// </summary>
      /// <param name="remoteEP">An EndPoint that represents the remote device.</param>
      // ReSharper disable once InconsistentNaming
      void Connect(EndPoint remoteEP);

      /// <summary>
      /// Establishes a connection to a remote host.
      /// </summary>
      /// <param name="remoteEP">An EndPoint that represents the remote device.</param>
      // ReSharper disable once InconsistentNaming
      void Connect(IEndPoint remoteEP);

      /// <summary>
      /// Establishes a connection to a remote host. The host is specified by an IP address and a port number.
      /// </summary>
      /// <param name="address">The IP address of the remote host.</param>
      /// <param name="port">The port number of the remote host.</param>
      void Connect(IPAddress address, int port);

      /// <summary>
      /// Establishes a connection to a remote host. The host is specified by an IP address and a port number.
      /// </summary>
      /// <param name="address">The IP address of the remote host.</param>
      /// <param name="port">The port number of the remote host.</param>
      void Connect(IIPAddress address, int port);

      /// <summary>
      /// Establishes a connection to a remote host. The host is specified by an array of IP addresses and a port number.
      /// </summary>
      /// <param name="addresses">The IP addresses of the remote host.</param>
      /// <param name="port">The port number of the remote host.</param>
      void Connect(IPAddress[] addresses, int port);

      /// <summary>
      /// Establishes a connection to a remote host. The host is specified by an array of IP addresses and a port number.
      /// </summary>
      /// <param name="addresses">The IP addresses of the remote host.</param>
      /// <param name="port">The port number of the remote host.</param>
      void Connect(IIPAddress[] addresses, int port);

      /// <summary>
      /// Establishes a connection to a remote host. The host is specified by a host name and a port number.
      /// </summary>
      /// <param name="host">The name of the remote host.</param>
      /// <param name="port">The port number of the remote host.</param>
      void Connect(string host, int port);

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
      bool ConnectAsync(SocketAsyncEventArgs e);

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
      bool ConnectAsync(ISocketAsyncEventArgs e);

      /// <summary>
      /// Returns the value of a specified Socket option, represented as an object.
      /// </summary>
      /// <param name="optionLevel">One of the SocketOptionLevel values.</param>
      /// <param name="optionName">One of the SocketOptionName values.</param>
      /// <returns>An object that represents the value of the option. When the optionName parameter is set to Linger the return value is an instance of the LingerOption class. When optionName is set to AddMembership or DropMembership, the return value is an instance of the MulticastOption class. When optionName is any other value, the return value is an integer.</returns>
      object? GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName);

      /// <summary>
      /// Returns the specified Socket option setting, represented as a byte array.
      /// </summary>
      /// <param name="optionLevel">One of the SocketOptionLevel values.</param>
      /// <param name="optionName">One of the SocketOptionName values.</param>
      /// <param name="optionValue">An array of type Byte that is to receive the option setting.</param>
      void GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue);

      /// <summary>
      /// Returns the value of the specified Socket option in an array.
      /// </summary>
      /// <param name="optionLevel">One of the SocketOptionLevel values.</param>
      /// <param name="optionName">One of the SocketOptionName values.</param>
      /// <param name="optionLength">The length, in bytes, of the expected return value.</param>
      /// <returns></returns>
      byte[] GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionLength);

      /// <summary>
      /// Sets low-level operating modes for the Socket using numerical control codes.
      /// </summary>
      /// <param name="ioControlCode">An Int32 value that specifies the control code of the operation to perform.</param>
      /// <param name="optionInValue">A Byte array that contains the input data required by the operation.</param>
      /// <param name="optionOutValue">A Byte array that contains the output data returned by the operation.</param>
      /// <returns>The number of bytes in the optionOutValue parameter.</returns>
      // ReSharper disable once InconsistentNaming
      int IOControl(int ioControlCode, byte[]? optionInValue, byte[]? optionOutValue);

      /// <summary>
      /// Sets low-level operating modes for the Socket using the IOControlCode enumeration to specify control codes.
      /// </summary>
      /// <param name="ioControlCode">A IOControlCode value that specifies the control code of the operation to perform.</param>
      /// <param name="optionInValue">An array of type Byte that contains the input data required by the operation.</param>
      /// <param name="optionOutValue">An array of type Byte that contains the output data returned by the operation.</param>
      /// <returns>The number of bytes in the optionOutValue parameter.</returns>
      // ReSharper disable once InconsistentNaming
      int IOControl(IOControlCode ioControlCode, byte[]? optionInValue, byte[]? optionOutValue);

#if NET5_0
      /// <summary>
      /// Places a <see cref="Socket"/> in a listening state.
      /// </summary>
      /// <remarks>
      /// The maximum length of the pending connections queue will be determined automatically.
      /// </remarks>
      void Listen();
#endif

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
      int Receive(byte[] buffer);

      /// <summary>
      /// Receives the specified number of bytes from a bound Socket into the specified offset position of the receive buffer, using the specified SocketFlags.
      /// </summary>
      /// <param name="buffer">An array of type Byte that is the storage location for received data.</param>
      /// <param name="offset">The location in buffer to store the received data.</param>
      /// <param name="size">The number of bytes to receive.</param>
      /// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
      /// <returns>The number of bytes received.</returns>
      int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags);

      /// <summary>
      /// Receives data from a bound Socket into a receive buffer, using the specified SocketFlags.
      /// </summary>
      /// <param name="buffer">An array of type Byte that is the storage location for the received data.</param>
      /// <param name="offset">The position in the buffer parameter to store the received data.</param>
      /// <param name="size">The number of bytes to receive.</param>
      /// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
      /// <param name="errorCode">A SocketError object that stores the socket error.</param>
      /// <returns>The number of bytes received.</returns>
      int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode);

      /// <summary>
      /// Receives the specified number of bytes of data from a bound Socket into a receive buffer, using the specified SocketFlags.
      /// </summary>
      /// <param name="buffer">An array of type Byte that is the storage location for the received data.</param>
      /// <param name="size">The number of bytes to receive.</param>
      /// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
      /// <returns>The number of bytes received.</returns>
      int Receive(byte[] buffer, int size, SocketFlags socketFlags);

      /// <summary>
      /// Receives data from a bound Socket into a receive buffer, using the specified SocketFlags.
      /// </summary>
      /// <param name="buffer">An array of type Byte that is the storage location for the received data.</param>
      /// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
      /// <returns>The number of bytes received.</returns>
      int Receive(byte[] buffer, SocketFlags socketFlags);

      /// <summary>
      /// Receives data from a bound Socket into the list of receive buffers.
      /// </summary>
      /// <param name="buffers">A list of ArraySegments of type Byte that contains the received data.</param>
      /// <returns>The number of bytes received.</returns>
      int Receive(IList<ArraySegment<byte>> buffers);

      /// <summary>
      /// Receives data from a bound Socket into the list of receive buffers, using the specified SocketFlags.
      /// </summary>
      /// <param name="buffers">A list of ArraySegments of type Byte that contains the received data.</param>
      /// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
      /// <returns>The number of bytes received.</returns>
      int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags);

      /// <summary>
      /// Receives data from a bound Socket into the list of receive buffers, using the specified SocketFlags.
      /// </summary>
      /// <param name="buffers">A list of ArraySegments of type Byte that contains the received data.</param>
      /// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
      /// <param name="errorCode">A SocketError object that stores the socket error.</param>
      /// <returns>The number of bytes received.</returns>
      int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode);

      /// <summary>Begins an asynchronous request to receive data from a connected <see cref="T:System.Net.Sockets.Socket" /> object.</summary>
      /// <returns>Returns true if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation. Returns false if the I/O operation completed synchronously. In this case, The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.</returns>
      /// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
      /// <exception cref="T:System.ArgumentException">An argument was invalid. The <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> or <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> properties on the <paramref name="e" /> parameter must reference valid buffers. One or the other of these properties may be set, but not both at the same time.</exception>
      /// <exception cref="T:System.InvalidOperationException">A socket operation was already in progress using the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object specified in the <paramref name="e" /> parameter.</exception>
      /// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method.</exception>
      /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
      /// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
      bool ReceiveAsync(SocketAsyncEventArgs e);

      /// <summary>Begins an asynchronous request to receive data from a connected <see cref="T:System.Net.Sockets.Socket" /> object.</summary>
      /// <returns>Returns true if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation. Returns false if the I/O operation completed synchronously. In this case, The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.</returns>
      /// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
      /// <exception cref="T:System.ArgumentException">An argument was invalid. The <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> or <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> properties on the <paramref name="e" /> parameter must reference valid buffers. One or the other of these properties may be set, but not both at the same time.</exception>
      /// <exception cref="T:System.InvalidOperationException">A socket operation was already in progress using the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object specified in the <paramref name="e" /> parameter.</exception>
      /// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method.</exception>
      /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
      /// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
      bool ReceiveAsync(ISocketAsyncEventArgs e);

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
      int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP);

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
      int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref IEndPoint remoteEP);

      /// <summary>
      /// Receives the specified number of bytes into the data buffer, using the specified SocketFlags, and stores the endpoint.
      /// </summary>
      /// <param name="buffer">An array of type Byte that is the storage location for received data.</param>
      /// <param name="size">The number of bytes to receive.</param>
      /// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
      /// <param name="remoteEP">An EndPoint, passed by reference, that represents the remote server.</param>
      /// <returns>The number of bytes received.</returns>
      // ReSharper disable once InconsistentNaming
      int ReceiveFrom(byte[] buffer, int size, SocketFlags socketFlags, ref EndPoint remoteEP);

      /// <summary>
      /// Receives the specified number of bytes into the data buffer, using the specified SocketFlags, and stores the endpoint.
      /// </summary>
      /// <param name="buffer">An array of type Byte that is the storage location for received data.</param>
      /// <param name="size">The number of bytes to receive.</param>
      /// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
      /// <param name="remoteEP">An EndPoint, passed by reference, that represents the remote server.</param>
      /// <returns>The number of bytes received.</returns>
      // ReSharper disable once InconsistentNaming
      int ReceiveFrom(byte[] buffer, int size, SocketFlags socketFlags, ref IEndPoint remoteEP);

      /// <summary>
      /// Receives a datagram into the data buffer and stores the endpoint.
      /// </summary>
      /// <param name="buffer">An array of type Byte that is the storage location for received data.</param>
      /// <param name="remoteEP">An EndPoint, passed by reference, that represents the remote server.</param>
      /// <returns>The number of bytes received.</returns>
      // ReSharper disable once InconsistentNaming
      int ReceiveFrom(byte[] buffer, ref EndPoint remoteEP);

      /// <summary>
      /// Receives a datagram into the data buffer and stores the endpoint.
      /// </summary>
      /// <param name="buffer">An array of type Byte that is the storage location for received data.</param>
      /// <param name="remoteEP">An EndPoint, passed by reference, that represents the remote server.</param>
      /// <returns>The number of bytes received.</returns>
      // ReSharper disable once InconsistentNaming
      int ReceiveFrom(byte[] buffer, ref IEndPoint remoteEP);

      /// <summary>
      /// Receives a datagram into the data buffer, using the specified SocketFlags, and stores the endpoint.
      /// </summary>
      /// <param name="buffer">An array of type Byte that is the storage location for the received data.</param>
      /// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
      /// <param name="remoteEP">An EndPoint, passed by reference, that represents the remote server.</param>
      /// <returns>The number of bytes received.</returns>
      // ReSharper disable once InconsistentNaming
      int ReceiveFrom(byte[] buffer, SocketFlags socketFlags, ref EndPoint remoteEP);

      /// <summary>
      /// Receives a datagram into the data buffer, using the specified SocketFlags, and stores the endpoint.
      /// </summary>
      /// <param name="buffer">An array of type Byte that is the storage location for the received data.</param>
      /// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
      /// <param name="remoteEP">An EndPoint, passed by reference, that represents the remote server.</param>
      /// <returns>The number of bytes received.</returns>
      // ReSharper disable once InconsistentNaming
      int ReceiveFrom(byte[] buffer, SocketFlags socketFlags, ref IEndPoint remoteEP);

      /// <summary>Begins to asynchronously receive data from a specified network device.</summary>
      /// <returns>Returns true if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation. Returns false if the I/O operation completed synchronously. In this case, The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.</returns>
      /// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
      /// <exception cref="T:System.ArgumentNullException">The <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> cannot be null.</exception>
      /// <exception cref="T:System.InvalidOperationException">A socket operation was already in progress using the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object specified in the <paramref name="e" /> parameter.</exception>
      /// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method.</exception>
      /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
      /// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. </exception>
      bool ReceiveFromAsync(SocketAsyncEventArgs e);

      /// <summary>Begins to asynchronously receive data from a specified network device.</summary>
      /// <returns>Returns true if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation. Returns false if the I/O operation completed synchronously. In this case, The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.</returns>
      /// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
      /// <exception cref="T:System.ArgumentNullException">The <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> cannot be null.</exception>
      /// <exception cref="T:System.InvalidOperationException">A socket operation was already in progress using the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object specified in the <paramref name="e" /> parameter.</exception>
      /// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method.</exception>
      /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
      /// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. </exception>
      bool ReceiveFromAsync(ISocketAsyncEventArgs e);

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
      int ReceiveMessageFrom(byte[] buffer, int offset, int size, ref SocketFlags socketFlags, ref EndPoint remoteEP, out IPPacketInformation ipPacketInformation);

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
      int ReceiveMessageFrom(byte[] buffer, int offset, int size, ref SocketFlags socketFlags, ref IEndPoint remoteEP, out IPPacketInformation ipPacketInformation);

      /// <summary>
      /// Begins to asynchronously receive the specified number of bytes of data into the specified location in the data buffer, using the specified SocketAsyncEventArgs.SocketFlags, and stores the endpoint and packet information.
      /// </summary>
      /// <param name="e">The System.Net.Sockets.SocketAsyncEventArgs object to use for this asynchronous socket operation.</param>
      /// <returns>
      /// Returns true if the I/O operation is pending. The SocketAsyncEventArgs.Completed event on the e parameter will be raised upon completion of the operation.
      /// Returns false if the I/O operation completed synchronously.In this case, The SocketAsyncEventArgs.Completed event on the e parameter will not be raised and the e object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.
      /// </returns>
      bool ReceiveMessageFromAsync(SocketAsyncEventArgs e);

      /// <summary>
      /// Begins to asynchronously receive the specified number of bytes of data into the specified location in the data buffer, using the specified SocketAsyncEventArgs.SocketFlags, and stores the endpoint and packet information.
      /// </summary>
      /// <param name="e">The System.Net.Sockets.SocketAsyncEventArgs object to use for this asynchronous socket operation.</param>
      /// <returns>
      /// Returns true if the I/O operation is pending. The SocketAsyncEventArgs.Completed event on the e parameter will be raised upon completion of the operation.
      /// Returns false if the I/O operation completed synchronously.In this case, The SocketAsyncEventArgs.Completed event on the e parameter will not be raised and the e object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.
      /// </returns>
      bool ReceiveMessageFromAsync(ISocketAsyncEventArgs e);

      /// <summary>
      /// Sends data to a connected Socket.
      /// </summary>
      /// <param name="buffer">A span of type Byte that contains the data to be sent.</param>
      /// <returns>The number of bytes sent to the Socket.</returns>
      int Send(ReadOnlySpan<byte> buffer);

      /// <summary>
      /// Sends data to a connected Socket using the specified SocketFlags.
      /// </summary>
      /// <param name="buffer">A span of bytes that contains the data to be sent.</param>
      /// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
      /// <returns>The number of bytes sent to the Socket.</returns>
      int Send(ReadOnlySpan<byte> buffer, SocketFlags socketFlags);

      /// <summary>
      /// Sends the specified number of bytes of data to a connected Socket, starting at the specified offset, and using the specified SocketFlags.
      /// </summary>
      /// <param name="buffer">A span of bytes that contains the data to be sent.</param>
      /// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
      /// <param name="errorCode">A SocketError object that stores the socket error.</param>
      /// <returns>The number of bytes sent to the Socket.</returns>
      int Send(ReadOnlySpan<byte> buffer, SocketFlags socketFlags, out SocketError errorCode);

      /// <summary>
      /// Receives data from a bound Socket into a receive buffer, using the specified SocketFlags.
      /// </summary>
      /// <param name="buffer">A span of bytes that is the storage location for the received data.</param>
      /// <returns>The number of bytes received.</returns>
      int Receive(Span<byte> buffer);

      /// <summary>
      /// Receives data from a bound Socket into a receive buffer, using the specified SocketFlags.
      /// </summary>
      /// <param name="buffer">A span of bytes that is the storage location for the received data.</param>
      /// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
      /// <returns>The number of bytes received.</returns>
      int Receive(Span<byte> buffer, SocketFlags socketFlags);

      /// <summary>
      /// Receives data from a bound Socket into a receive buffer, using the specified SocketFlags.
      /// </summary>
      /// <param name="buffer">A span of bytes that is the storage location for the received data.</param>
      /// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
      /// <param name="errorCode">A SocketError object that stores the socket error.</param>
      /// <returns>The number of bytes received.</returns>
      int Receive(Span<byte> buffer, SocketFlags socketFlags, out SocketError errorCode);

      /// <summary>
      /// Sends data to a connected Socket.
      /// </summary>
      /// <param name="buffer">An array of type Byte that contains the data to be sent.</param>
      /// <returns>The number of bytes sent to the Socket.</returns>
      int Send(byte[] buffer);

      /// <summary>
      /// Sends the specified number of bytes of data to a connected Socket, starting at the specified offset, and using the specified SocketFlags.
      /// </summary>
      /// <param name="buffer">An array of type Byte that contains the data to be sent.</param>
      /// <param name="offset">The position in the data buffer at which to begin sending data.</param>
      /// <param name="size">The number of bytes to send.</param>
      /// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
      /// <returns>The number of bytes sent to the Socket.</returns>
      int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags);

      /// <summary>
      /// Sends the specified number of bytes of data to a connected Socket, starting at the specified offset, and using the specified SocketFlags.
      /// </summary>
      /// <param name="buffer">An array of type Byte that contains the data to be sent.</param>
      /// <param name="offset">The position in the data buffer at which to begin sending data.</param>
      /// <param name="size">The number of bytes to send.</param>
      /// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
      /// <param name="errorCode">A SocketError object that stores the socket error.</param>
      /// <returns>The number of bytes sent to the Socket.</returns>
      int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode);

      /// <summary>
      /// Sends the specified number of bytes of data to a connected Socket, using the specified SocketFlags.
      /// </summary>
      /// <param name="buffer">An array of type Byte that contains the data to be sent.</param>
      /// <param name="size">The number of bytes to send.</param>
      /// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
      /// <returns>The number of bytes sent to the Socket.</returns>
      int Send(byte[] buffer, int size, SocketFlags socketFlags);

      /// <summary>
      /// Sends data to a connected Socket using the specified SocketFlags.
      /// </summary>
      /// <param name="buffer">An array of type Byte that contains the data to be sent.</param>
      /// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
      /// <returns>The number of bytes sent to the Socket.</returns>
      int Send(byte[] buffer, SocketFlags socketFlags);

      /// <summary>
      /// Sends data to a connected Socket using the specified SocketFlags.
      /// </summary>
      /// <param name="buffers">A list of ArraySegments of type Byte that contains the data to be sent.</param>
      /// <returns>The number of bytes sent to the Socket.</returns>
      int Send(IList<ArraySegment<byte>> buffers);

      /// <summary>
      /// Sends the set of buffers in the list to a connected Socket, using the specified SocketFlags.
      /// </summary>
      /// <param name="buffers">A list of ArraySegments of type Byte that contains the data to be sent.</param>
      /// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
      /// <returns>The number of bytes sent to the Socket.</returns>
      int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags);

      /// <summary>
      /// Sends the set of buffers in the list to a connected Socket, using the specified SocketFlags.
      /// </summary>
      /// <param name="buffers">A list of ArraySegments of type Byte that contains the data to be sent.</param>
      /// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
      /// <param name="errorCode">A SocketError object that stores the socket error.</param>
      /// <returns>The number of bytes sent to the Socket.</returns>
      int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode);

      /// <summary>Sends data asynchronously to a connected <see cref="T:System.Net.Sockets.Socket" /> object.</summary>
      /// <returns>Returns true if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation. Returns false if the I/O operation completed synchronously. In this case, The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.</returns>
      /// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
      /// <exception cref="T:System.ArgumentException">The <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> or <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> properties on the <paramref name="e" /> parameter must reference valid buffers. One or the other of these properties may be set, but not both at the same time.</exception>
      /// <exception cref="T:System.InvalidOperationException">A socket operation was already in progress using the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object specified in the <paramref name="e" /> parameter.</exception>
      /// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method.</exception>
      /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
      /// <exception cref="T:System.Net.Sockets.SocketException">The <see cref="T:System.Net.Sockets.Socket" /> is not yet connected or was not obtained via an <see cref="M:System.Net.Sockets.Socket.Accept" />, <see cref="M:System.Net.Sockets.Socket.AcceptAsync(System.Net.Sockets.SocketAsyncEventArgs)" /> method.</exception>
      bool SendAsync(SocketAsyncEventArgs e);

      /// <summary>Sends data asynchronously to a connected <see cref="T:System.Net.Sockets.Socket" /> object.</summary>
      /// <returns>Returns true if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation. Returns false if the I/O operation completed synchronously. In this case, The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.</returns>
      /// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
      /// <exception cref="T:System.ArgumentException">The <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> or <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> properties on the <paramref name="e" /> parameter must reference valid buffers. One or the other of these properties may be set, but not both at the same time.</exception>
      /// <exception cref="T:System.InvalidOperationException">A socket operation was already in progress using the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object specified in the <paramref name="e" /> parameter.</exception>
      /// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method.</exception>
      /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
      /// <exception cref="T:System.Net.Sockets.SocketException">The <see cref="T:System.Net.Sockets.Socket" /> is not yet connected or was not obtained via an <see cref="M:System.Net.Sockets.Socket.Accept" />, <see cref="M:System.Net.Sockets.Socket.AcceptAsync(System.Net.Sockets.SocketAsyncEventArgs)" /> method.</exception>
      bool SendAsync(ISocketAsyncEventArgs e);

      /// <summary>
      /// Sends a collection of files or in memory data buffers asynchronously to a connected Socket object.
      /// </summary>
      /// <param name="e">The System.Net.Sockets.SocketAsyncEventArgs object to use for this asynchronous socket operation.</param>
      /// <returns>
      /// Returns true if the I/O operation is pending. The SocketAsyncEventArgs.Completed event on the e parameter will be raised upon completion of the operation.
      /// Returns false if the I/O operation completed synchronously.In this case, The SocketAsyncEventArgs.Completed event on the e parameter will not be raised and the e object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.
      /// </returns>
      bool SendPacketsAsync(SocketAsyncEventArgs e);

      /// <summary>
      /// Sends a collection of files or in memory data buffers asynchronously to a connected Socket object.
      /// </summary>
      /// <param name="e">The System.Net.Sockets.SocketAsyncEventArgs object to use for this asynchronous socket operation.</param>
      /// <returns>
      /// Returns true if the I/O operation is pending. The SocketAsyncEventArgs.Completed event on the e parameter will be raised upon completion of the operation.
      /// Returns false if the I/O operation completed synchronously.In this case, The SocketAsyncEventArgs.Completed event on the e parameter will not be raised and the e object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.
      /// </returns>
      bool SendPacketsAsync(ISocketAsyncEventArgs e);

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
      int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP);

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
      int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, IEndPoint remoteEP);

      /// <summary>
      /// Sends the specified number of bytes of data to the specified endpoint using the specified SocketFlags.
      /// </summary>
      /// <param name="buffer">An array of type Byte that contains the data to be sent.</param>
      /// <param name="size">The number of bytes to send.</param>
      /// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
      /// <param name="remoteEP">The EndPoint that represents the destination location for the data.</param>
      /// <returns>The number of bytes sent.</returns>
      // ReSharper disable once InconsistentNaming
      int SendTo(byte[] buffer, int size, SocketFlags socketFlags, EndPoint remoteEP);

      /// <summary>
      /// Sends the specified number of bytes of data to the specified endpoint using the specified SocketFlags.
      /// </summary>
      /// <param name="buffer">An array of type Byte that contains the data to be sent.</param>
      /// <param name="size">The number of bytes to send.</param>
      /// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
      /// <param name="remoteEP">The EndPoint that represents the destination location for the data.</param>
      /// <returns>The number of bytes sent.</returns>
      // ReSharper disable once InconsistentNaming
      int SendTo(byte[] buffer, int size, SocketFlags socketFlags, IEndPoint remoteEP);

      /// <summary>
      /// Sends data to the specified endpoint.
      /// </summary>
      /// <param name="buffer">An array of type Byte that contains the data to be sent.</param>
      /// <param name="remoteEP">The EndPoint that represents the destination for the data.</param>
      /// <returns>The number of bytes sent.</returns>
      // ReSharper disable once InconsistentNaming
      int SendTo(byte[] buffer, EndPoint remoteEP);

      /// <summary>
      /// Sends data to the specified endpoint.
      /// </summary>
      /// <param name="buffer">An array of type Byte that contains the data to be sent.</param>
      /// <param name="remoteEP">The EndPoint that represents the destination for the data.</param>
      /// <returns>The number of bytes sent.</returns>
      // ReSharper disable once InconsistentNaming
      int SendTo(byte[] buffer, IEndPoint remoteEP);

      /// <summary>
      /// Sends data to a specific endpoint using the specified SocketFlags.
      /// </summary>
      /// <param name="buffer">An array of type Byte that contains the data to be sent.</param>
      /// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
      /// <param name="remoteEP">The EndPoint that represents the destination location for the data.</param>
      /// <returns>The number of bytes sent.</returns>
      // ReSharper disable once InconsistentNaming
      int SendTo(byte[] buffer, SocketFlags socketFlags, EndPoint remoteEP);

      /// <summary>
      /// Sends data to a specific endpoint using the specified SocketFlags.
      /// </summary>
      /// <param name="buffer">An array of type Byte that contains the data to be sent.</param>
      /// <param name="socketFlags">A bitwise combination of the SocketFlags values.</param>
      /// <param name="remoteEP">The EndPoint that represents the destination location for the data.</param>
      /// <returns>The number of bytes sent.</returns>
      // ReSharper disable once InconsistentNaming
      int SendTo(byte[] buffer, SocketFlags socketFlags, IEndPoint remoteEP);

      /// <summary>Sends data asynchronously to a specific remote host.</summary>
      /// <returns>Returns true if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation. Returns false if the I/O operation completed synchronously. In this case, The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.</returns>
      /// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
      /// <exception cref="T:System.ArgumentNullException">The <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> cannot be null.</exception>
      /// <exception cref="T:System.InvalidOperationException">A socket operation was already in progress using the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object specified in the <paramref name="e" /> parameter.</exception>
      /// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method.</exception>
      /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
      /// <exception cref="T:System.Net.Sockets.SocketException">The protocol specified is connection-oriented, but the <see cref="T:System.Net.Sockets.Socket" /> is not yet connected.</exception>
      bool SendToAsync(SocketAsyncEventArgs e);

      /// <summary>Sends data asynchronously to a specific remote host.</summary>
      /// <returns>Returns true if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation. Returns false if the I/O operation completed synchronously. In this case, The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.</returns>
      /// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
      /// <exception cref="T:System.ArgumentNullException">The <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> cannot be null.</exception>
      /// <exception cref="T:System.InvalidOperationException">A socket operation was already in progress using the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object specified in the <paramref name="e" /> parameter.</exception>
      /// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method.</exception>
      /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
      /// <exception cref="T:System.Net.Sockets.SocketException">The protocol specified is connection-oriented, but the <see cref="T:System.Net.Sockets.Socket" /> is not yet connected.</exception>
      bool SendToAsync(ISocketAsyncEventArgs e);

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
      void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue);

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
      void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, object optionValue);

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

      /// <summary>Begins an asynchronous request to disconnect from a remote endpoint.</summary>
      /// <returns>Returns true if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation. Returns false if the I/O operation completed synchronously. In this case, The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.</returns>
      /// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
      /// <exception cref="T:System.ArgumentNullException">The <paramref name="e" /> parameter cannot be null.</exception>
      /// <exception cref="T:System.InvalidOperationException">A socket operation was already in progress using the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object specified in the <paramref name="e" /> parameter.</exception>
      /// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method.</exception>
      /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
      /// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. </exception>
      bool DisconnectAsync(SocketAsyncEventArgs e);

      /// <summary>Begins an asynchronous request to disconnect from a remote endpoint.</summary>
      /// <returns>Returns true if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation. Returns false if the I/O operation completed synchronously. In this case, The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation.</returns>
      /// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
      /// <exception cref="T:System.ArgumentNullException">The <paramref name="e" /> parameter cannot be null.</exception>
      /// <exception cref="T:System.InvalidOperationException">A socket operation was already in progress using the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object specified in the <paramref name="e" /> parameter.</exception>
      /// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method.</exception>
      /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
      /// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. </exception>
      bool DisconnectAsync(ISocketAsyncEventArgs e);

      /// <summary>Closes the <see cref="T:System.Net.Sockets.Socket" /> connection and releases all associated resources.</summary>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
      /// </PermissionSet>
      void Close();

      /// <summary>Closes the <see cref="T:System.Net.Sockets.Socket" /> connection and releases all associated resources with a specified timeout to allow queued data to be sent. </summary>
      /// <param name="timeout">Wait up to <paramref name="timeout" /> seconds to send any remaining data, then close the socket.</param>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
      /// </PermissionSet>
      void Close(int timeout);

      /// <summary>Sends the file <paramref name="fileName" /> to a connected <see cref="T:System.Net.Sockets.Socket" /> object with the <see cref="F:System.Net.Sockets.TransmitFileOptions.UseDefaultWorkerThread" /> transmit flag.</summary>
      /// <param name="fileName">A <see cref="T:System.String" /> that contains the path and name of the file to be sent. This parameter can be null. </param>
      /// <exception cref="T:System.NotSupportedException">The socket is not connected to a remote host. </exception>
      /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> object has been closed. </exception>
      /// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Net.Sockets.Socket" /> object is not in blocking mode and cannot accept this synchronous call. </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The file <paramref name="fileName" /> was not found. </exception>
      /// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void SendFile(string fileName);

      /// <summary>Sends the file <paramref name="fileName" /> and buffers of data to a connected <see cref="T:System.Net.Sockets.Socket" /> object using the specified <see cref="T:System.Net.Sockets.TransmitFileOptions" /> value.</summary>
      /// <param name="fileName">A <see cref="T:System.String" /> that contains the path and name of the file to be sent. This parameter can be null. </param>
      /// <param name="preBuffer">A <see cref="T:System.Byte" /> array that contains data to be sent before the file is sent. This parameter can be null. </param>
      /// <param name="postBuffer">A <see cref="T:System.Byte" /> array that contains data to be sent after the file is sent. This parameter can be null. </param>
      /// <param name="flags">One or more of <see cref="T:System.Net.Sockets.TransmitFileOptions" /> values. </param>
      /// <exception cref="T:System.NotSupportedException">The operating system is not Windows NT or later.- or - The socket is not connected to a remote host. </exception>
      /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> object has been closed. </exception>
      /// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Net.Sockets.Socket" /> object is not in blocking mode and cannot accept this synchronous call. </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The file <paramref name="fileName" /> was not found. </exception>
      /// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
      void SendFile(string fileName, byte[] preBuffer, byte[] postBuffer, TransmitFileOptions flags);

      /// <summary>Set the IP protection level on a socket.</summary>
      /// <param name="level">The IP protection level to set on this socket. </param>
      /// <exception cref="T:System.ArgumentException">The <paramref name="level" /> parameter cannot be <see cref="F:System.Net.Sockets.IPProtectionLevel.Unspecified" />. The IP protection level cannot be set to unspecified.</exception>
      /// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Net.Sockets.AddressFamily" /> of the socket must be either <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> or <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" />.</exception>
      // ReSharper disable once InconsistentNaming
#if NET5_0
      [SupportedOSPlatform("windows")]
#endif
      void SetIPProtectionLevel(IPProtectionLevel level);

      /// <summary>Duplicates the socket reference for the target process, and closes the socket for this process.</summary>
      /// <returns>The socket reference to be passed to the target process.</returns>
      /// <param name="targetProcessId">The ID of the target process where a duplicate of the socket reference is created.</param>
      /// <exception cref="T:System.Net.Sockets.SocketException">
      /// <paramref name="targetProcessId" /> is not a valid process id.-or- Duplication of the socket reference failed. </exception>
#if NET5_0
      [SupportedOSPlatform("windows")]
#endif
      SocketInformation DuplicateAndClose(int targetProcessId);

      /// <summary>Closes the socket connection and allows reuse of the socket.</summary>
      /// <param name="reuseSocket">true if this socket can be reused after the current connection is closed; otherwise, false. </param>
      /// <exception cref="T:System.PlatformNotSupportedException">This method requires Windows 2000 or earlier, or the exception will be thrown.</exception>
      /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> object has been closed. </exception>
      /// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void Disconnect(bool reuseSocket);

      /// <summary>Gets the operating system handle for the <see cref="T:System.Net.Sockets.Socket" />.</summary>
      /// <returns>An <see cref="T:System.IntPtr" /> that represents the operating system handle for the <see cref="T:System.Net.Sockets.Socket" />.</returns>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      IntPtr Handle { get; }

      /// <summary>Specifies whether the socket should only use Overlapped I/O mode.</summary>
      /// <returns>true if the <see cref="T:System.Net.Sockets.Socket" /> uses only overlapped I/O; otherwise, false. The default is false.</returns>
      /// <exception cref="T:System.InvalidOperationException">The socket has been bound to a completion port.</exception>
      // ReSharper disable once InconsistentNaming
      bool UseOnlyOverlappedIO { get; set; }

#if NET5_0
      /// <summary>Sets a socket option value using platform-specific level and name identifiers.</summary>
      /// <param name="optionLevel">The platform-defined option level.</param>
      /// <param name="optionName">The platform-defined option name.</param>
      /// <param name="optionValue">The value to which the option should be set.</param>
      /// <exception cref="ObjectDisposedException">The <see cref="Socket"/> has been closed.</exception>
      /// <exception cref="SocketException">An error occurred when attempting to access the socket.</exception>
      /// <remarks>
      /// In general, the SetSocketOption method should be used whenever setting a <see cref="Socket"/> option.
      /// The <see cref="SetRawSocketOption"/> should be used only when <see cref="SocketOptionLevel"/> and <see cref="SocketOptionName"/>
      /// do not expose the required option.
      /// </remarks>
      void SetRawSocketOption(int optionLevel, int optionName, ReadOnlySpan<byte> optionValue);

      /// <summary>Gets a socket option value using platform-specific level and name identifiers.</summary>
      /// <param name="optionLevel">The platform-defined option level.</param>
      /// <param name="optionName">The platform-defined option name.</param>
      /// <param name="optionValue">The span into which the retrieved option value should be stored.</param>
      /// <returns>The number of bytes written into <paramref name="optionValue"/> for a successfully retrieved value.</returns>
      /// <exception cref="ObjectDisposedException">The <see cref="Socket"/> has been closed.</exception>
      /// <exception cref="SocketException">An error occurred when attempting to access the socket.</exception>
      /// <remarks>
      /// In general, the GetSocketOption method should be used whenever getting a <see cref="Socket"/> option.
      /// The <see cref="GetRawSocketOption"/> should be used only when <see cref="SocketOptionLevel"/> and <see cref="SocketOptionName"/>
      /// do not expose the required option.
      /// </remarks>
      int GetRawSocketOption(int optionLevel, int optionName, Span<byte> optionValue);
#endif

#if NETCOREAPP || NET5_0
      /// <summary>
      /// Gets a SafeSocketHandle that represents the socket handle that the current Socket object encapsulates.
      /// </summary>
      SafeSocketHandle SafeHandle { get; }
#endif
   }
}
