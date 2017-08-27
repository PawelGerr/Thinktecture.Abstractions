using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;

namespace Thinktecture.Net.Sockets.Adapters
{
	/// <summary>Implements the Berkeley sockets interface.</summary>
	public class SocketAdapter : AbstractionAdapter, ISocket
	{
		private readonly Socket _socket;

		/// <summary>Indicates whether the underlying operating system and network adaptors support Internet Protocol version 4 (IPv4).</summary>
		/// <returns>true if the operating system and network adaptors support the IPv4 protocol; otherwise, false.</returns>
		// ReSharper disable once InconsistentNaming
		public static bool OSSupportsIPv4 => Socket.OSSupportsIPv4;

		/// <summary>Indicates whether the underlying operating system and network adaptors support Internet Protocol version 6 (IPv6).</summary>
		/// <returns>true if the operating system and network adaptors support the IPv6 protocol; otherwise, false.</returns>
		// ReSharper disable once InconsistentNaming
		public static bool OSSupportsIPv6 => Socket.OSSupportsIPv6;

		/// <summary>Begins an asynchronous request for a connection to a remote host.</summary>
		/// <returns>Returns true if the I/O operation is pending. The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will be raised upon completion of the operation. Returns false if the I/O operation completed synchronously. In this case, The <see cref="E:System.Net.Sockets.SocketAsyncEventArgs.Completed" /> event on the <paramref name="e" /> parameter will not be raised and the <paramref name="e" /> object passed as a parameter may be examined immediately after the method call returns to retrieve the result of the operation. </returns>
		/// <param name="socketType">One of the <see cref="T:System.Net.Sockets.SocketType" /> values.</param>
		/// <param name="protocolType">One of the <see cref="T:System.Net.Sockets.ProtocolType" /> values.</param>
		/// <param name="e">The <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object to use for this asynchronous socket operation.</param>
		/// <exception cref="T:System.ArgumentException">An argument is not valid. This exception occurs if multiple buffers are specified, the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> property is not null. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="e" /> parameter cannot be null and the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> cannot be null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Net.Sockets.Socket" /> is listening or a socket operation was already in progress using the <see cref="T:System.Net.Sockets.SocketAsyncEventArgs" /> object specified in the <paramref name="e" /> parameter.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information.</exception>
		/// <exception cref="T:System.NotSupportedException">Windows XP or later is required for this method. This exception also occurs if the local endpoint and the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> are not the same address family.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.Security.SecurityException">A caller higher in the call stack does not have permission for the requested operation.</exception>
		public static bool ConnectAsync(SocketType socketType, ProtocolType protocolType, SocketAsyncEventArgs e)
		{
			return Socket.ConnectAsync(socketType, protocolType, e);
		}

		/// <summary>
		/// Cancels an asynchronous request for a remote host connection.
		/// </summary>
		/// <param name="e">The System.Net.Sockets.SocketAsyncEventArgs object used to request the connection to the remote host by calling one of the ConnectAsync methods.</param>
		public static void CancelConnectAsync(SocketAsyncEventArgs e)
		{
			Socket.CancelConnectAsync(e);
		}

		/// <summary>
		/// Determines the status of one or more sockets.
		/// </summary>
		/// <param name="checkRead">An IList of Socket instances to check for readability.</param>
		/// <param name="checkWrite">An IList of Socket instances to check for writability.</param>
		/// <param name="checkError">An IList of Socket instances to check for errors.</param>
		/// <param name="microSeconds">The time-out value, in microseconds. A -1 value indicates an infinite time-out.</param>
		public static void Select(IList checkRead, IList checkWrite, IList checkError, int microSeconds)
		{
			Socket.Select(checkRead, checkWrite, checkError, microSeconds);
		}

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new Socket UnsafeConvert()
		{
			return _socket;
		}

		/// <inheritdoc />
		public AddressFamily AddressFamily => _socket.AddressFamily;

		/// <inheritdoc />
		public int Available => _socket.Available;

		/// <inheritdoc />
		public bool Blocking
		{
			get => _socket.Blocking;
			set => _socket.Blocking = value;
		}

		/// <inheritdoc />
		public bool Connected => _socket.Connected;

		/// <inheritdoc />
		public bool DontFragment
		{
			get => _socket.DontFragment;
			set => _socket.DontFragment = value;
		}

		/// <inheritdoc />
		public bool DualMode
		{
			get => _socket.DualMode;
			set => _socket.DualMode = value;
		}

		/// <inheritdoc />
		public bool EnableBroadcast
		{
			get => _socket.EnableBroadcast;
			set => _socket.EnableBroadcast = value;
		}

		/// <inheritdoc />
		public bool ExclusiveAddressUse
		{
			get => _socket.ExclusiveAddressUse;
			set => _socket.ExclusiveAddressUse = value;
		}

		/// <inheritdoc />
		public bool IsBound => _socket.IsBound;

		/// <inheritdoc />
		public ILingerOption LingerState
		{
			get => _socket.LingerState.ToInterface();
			set => _socket.LingerState = value.ToImplementation();
		}

		/// <inheritdoc />
		public IEndPoint LocalEndPoint => _socket.LocalEndPoint.ToInterface();

		/// <inheritdoc />
		public bool MulticastLoopback
		{
			get => _socket.MulticastLoopback;
			set => _socket.MulticastLoopback = value;
		}

		/// <inheritdoc />
		public bool NoDelay
		{
			get => _socket.NoDelay;
			set => _socket.NoDelay = value;
		}

		/// <inheritdoc />
		public ProtocolType ProtocolType => _socket.ProtocolType;

		/// <inheritdoc />
		public int ReceiveBufferSize
		{
			get => _socket.ReceiveBufferSize;
			set => _socket.ReceiveBufferSize = value;
		}

		/// <inheritdoc />
		public int ReceiveTimeout
		{
			get => _socket.ReceiveTimeout;
			set => _socket.ReceiveTimeout = value;
		}

		/// <inheritdoc />
		public IEndPoint RemoteEndPoint => _socket.RemoteEndPoint.ToInterface();

		/// <inheritdoc />
		public int SendBufferSize
		{
			get => _socket.SendBufferSize;
			set => _socket.SendBufferSize = value;
		}

		/// <inheritdoc />
		public int SendTimeout
		{
			get => _socket.SendTimeout;
			set => _socket.SendTimeout = value;
		}

		/// <inheritdoc />
		public SocketType SocketType => _socket.SocketType;

		/// <inheritdoc />
		public short Ttl
		{
			get => _socket.Ttl;
			set => _socket.Ttl = value;
		}

		/// <summary>Initializes a new instance of the <see cref="SocketAdapter" /> class using the specified address family, socket type and protocol.</summary>
		/// <param name="addressFamily">One of the <see cref="T:System.Net.Sockets.AddressFamily" /> values. </param>
		/// <param name="socketType">One of the <see cref="T:System.Net.Sockets.SocketType" /> values. </param>
		/// <param name="protocolType">One of the <see cref="T:System.Net.Sockets.ProtocolType" /> values. </param>
		/// <exception cref="T:System.Net.Sockets.SocketException">The combination of <paramref name="addressFamily" />, <paramref name="socketType" />, and <paramref name="protocolType" /> results in an invalid socket. </exception>
		public SocketAdapter(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
			: this(new Socket(addressFamily, socketType, protocolType))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="SocketAdapter" /> class using the specified socket type and protocol.</summary>
		/// <param name="socketType">One of the <see cref="T:System.Net.Sockets.SocketType" /> values.</param>
		/// <param name="protocolType">One of the <see cref="T:System.Net.Sockets.ProtocolType" /> values.</param>
		/// <exception cref="T:System.Net.Sockets.SocketException">The combination of  <paramref name="socketType" /> and <paramref name="protocolType" /> results in an invalid socket. </exception>
		public SocketAdapter(SocketType socketType, ProtocolType protocolType)
			: this(new Socket(socketType, protocolType))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="SocketAdapter" /> class using the specified socket type and protocol.</summary>
		/// <param name="socket"></param>
		public SocketAdapter(Socket socket)
			: base(socket)
		{
			_socket = socket ?? throw new ArgumentNullException(nameof(socket));
		}

		/// <inheritdoc />
		public ISocket Accept()
		{
			return _socket.Accept().ToInterface();
		}

		/// <inheritdoc />
		public bool AcceptAsync(SocketAsyncEventArgs e)
		{
			return _socket.AcceptAsync(e);
		}

		/// <inheritdoc />
		public bool AcceptAsync(ISocketAsyncEventArgs e)
		{
			return _socket.AcceptAsync(e.ToImplementation<SocketAsyncEventArgs>());
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public void Bind(EndPoint localEP)
		{
			_socket.Bind(localEP);
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public void Bind(IEndPoint localEP)
		{
			_socket.Bind(localEP.ToImplementation());
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public void Connect(EndPoint remoteEP)
		{
			_socket.Connect(remoteEP);
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public void Connect(IEndPoint remoteEP)
		{
			_socket.Connect(remoteEP.ToImplementation());
		}

		/// <inheritdoc />
		public void Connect(IPAddress address, int port)
		{
			_socket.Connect(address, port);
		}

		/// <inheritdoc />
		public void Connect(IIPAddress address, int port)
		{
			_socket.Connect(address.ToImplementation(), port);
		}

		/// <inheritdoc />
		public void Connect(IPAddress[] addresses, int port)
		{
			_socket.Connect(addresses, port);
		}

		/// <inheritdoc />
		public void Connect(IIPAddress[] addresses, int port)
		{
			_socket.Connect(addresses.ToImplementation<IIPAddress, IPAddress>(), port);
		}

		/// <inheritdoc />
		public void Connect(string host, int port)
		{
			_socket.Connect(host, port);
		}

		/// <inheritdoc />
		public bool ConnectAsync(SocketAsyncEventArgs e)
		{
			return _socket.ConnectAsync(e);
		}

		/// <inheritdoc />
		public bool ConnectAsync(ISocketAsyncEventArgs e)
		{
			return _socket.ConnectAsync(e.ToImplementation<SocketAsyncEventArgs>());
		}

		/// <inheritdoc />
		public void Dispose()
		{
			_socket.Dispose();
		}

		/// <inheritdoc />
		public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName)
		{
			return _socket.GetSocketOption(optionLevel, optionName);
		}

		/// <inheritdoc />
		public void GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)
		{
			_socket.GetSocketOption(optionLevel, optionName, optionValue);
		}

		/// <inheritdoc />
		public byte[] GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionLength)
		{
			return _socket.GetSocketOption(optionLevel, optionName, optionLength);
		}

		/// <inheritdoc />
		public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue)
		{
			return _socket.IOControl(ioControlCode, optionInValue, optionOutValue);
		}

		/// <inheritdoc />
		public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue)
		{
			return _socket.IOControl(ioControlCode, optionInValue, optionOutValue);
		}

		/// <inheritdoc />
		public void Listen(int backlog)
		{
			_socket.Listen(backlog);
		}

		/// <inheritdoc />
		public bool Poll(int microSeconds, SelectMode mode)
		{
			return _socket.Poll(microSeconds, mode);
		}

		/// <inheritdoc />
		public int Receive(byte[] buffer)
		{
			return _socket.Receive(buffer);
		}

		/// <inheritdoc />
		public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags)
		{
			return _socket.Receive(buffer, offset, size, socketFlags);
		}

		/// <inheritdoc />
		public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			return _socket.Receive(buffer, offset, size, socketFlags, out errorCode);
		}

		/// <inheritdoc />
		public int Receive(byte[] buffer, int size, SocketFlags socketFlags)
		{
			return _socket.Receive(buffer, size, socketFlags);
		}

		/// <inheritdoc />
		public int Receive(byte[] buffer, SocketFlags socketFlags)
		{
			return _socket.Receive(buffer, socketFlags);
		}

		/// <inheritdoc />
		public int Receive(IList<ArraySegment<byte>> buffers)
		{
			return _socket.Receive(buffers);
		}

		/// <inheritdoc />
		public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			return _socket.Receive(buffers, socketFlags);
		}

		/// <inheritdoc />
		public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
		{
			return _socket.Receive(buffers, socketFlags, out errorCode);
		}

		/// <inheritdoc />
		public bool ReceiveAsync(SocketAsyncEventArgs e)
		{
			return _socket.ReceiveAsync(e);
		}

		/// <inheritdoc />
		public bool ReceiveAsync(ISocketAsyncEventArgs e)
		{
			return _socket.ReceiveAsync(e.ToImplementation<SocketAsyncEventArgs>());
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP)
		{
			return _socket.ReceiveFrom(buffer, offset, size, socketFlags, ref remoteEP);
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref IEndPoint remoteEP)
		{
			var tempRemoteEp = remoteEP.ToImplementation();
			var result = _socket.ReceiveFrom(buffer, offset, size, socketFlags, ref tempRemoteEp);

			if (!ReferenceEquals(tempRemoteEp, remoteEP.ToImplementation()))
				remoteEP = tempRemoteEp.ToInterface();

			return result;
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int ReceiveFrom(byte[] buffer, int size, SocketFlags socketFlags, ref EndPoint remoteEP)
		{
			return _socket.ReceiveFrom(buffer, size, socketFlags, ref remoteEP);
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int ReceiveFrom(byte[] buffer, int size, SocketFlags socketFlags, ref IEndPoint remoteEP)
		{
			var tempRemoteEp = remoteEP.ToImplementation();
			var result = _socket.ReceiveFrom(buffer, size, socketFlags, ref tempRemoteEp);

			if (!ReferenceEquals(tempRemoteEp, remoteEP.ToImplementation()))
				remoteEP = tempRemoteEp.ToInterface();

			return result;
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int ReceiveFrom(byte[] buffer, ref EndPoint remoteEP)
		{
			return _socket.ReceiveFrom(buffer, ref remoteEP);
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int ReceiveFrom(byte[] buffer, ref IEndPoint remoteEP)
		{
			var tempRemoteEp = remoteEP.ToImplementation();
			var result = _socket.ReceiveFrom(buffer, ref tempRemoteEp);

			if (!ReferenceEquals(tempRemoteEp, remoteEP.ToImplementation()))
				remoteEP = tempRemoteEp.ToInterface();

			return result;
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int ReceiveFrom(byte[] buffer, SocketFlags socketFlags, ref EndPoint remoteEP)
		{
			return _socket.ReceiveFrom(buffer, socketFlags, ref remoteEP);
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int ReceiveFrom(byte[] buffer, SocketFlags socketFlags, ref IEndPoint remoteEP)
		{
			var tempRemoteEp = remoteEP.ToImplementation();
			var result = _socket.ReceiveFrom(buffer, socketFlags, ref tempRemoteEp);

			if (!ReferenceEquals(tempRemoteEp, remoteEP.ToImplementation()))
				remoteEP = tempRemoteEp.ToInterface();

			return result;
		}

		/// <inheritdoc />
		public bool ReceiveFromAsync(SocketAsyncEventArgs e)
		{
			return _socket.ReceiveFromAsync(e);
		}

		/// <inheritdoc />
		public bool ReceiveFromAsync(ISocketAsyncEventArgs e)
		{
			return _socket.ReceiveFromAsync(e.ToImplementation<SocketAsyncEventArgs>());
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int ReceiveMessageFrom(byte[] buffer, int offset, int size, ref SocketFlags socketFlags, ref EndPoint remoteEP, out IPPacketInformation ipPacketInformation)
		{
			return _socket.ReceiveMessageFrom(buffer, offset, size, ref socketFlags, ref remoteEP, out ipPacketInformation);
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int ReceiveMessageFrom(byte[] buffer, int offset, int size, ref SocketFlags socketFlags, ref IEndPoint remoteEP, out IPPacketInformation ipPacketInformation)
		{
			var tempRemoteEp = remoteEP.ToImplementation();
			var result = _socket.ReceiveMessageFrom(buffer, offset, size, ref socketFlags, ref tempRemoteEp, out ipPacketInformation);

			if (!ReferenceEquals(tempRemoteEp, remoteEP.ToImplementation()))
				remoteEP = tempRemoteEp.ToInterface();

			return result;
		}

		/// <inheritdoc />
		public bool ReceiveMessageFromAsync(SocketAsyncEventArgs e)
		{
			return _socket.ReceiveMessageFromAsync(e);
		}

		/// <inheritdoc />
		public bool ReceiveMessageFromAsync(ISocketAsyncEventArgs e)
		{
			return _socket.ReceiveMessageFromAsync(e.ToImplementation<SocketAsyncEventArgs>());
		}

		/// <inheritdoc />
		public int Send(byte[] buffer)
		{
			return _socket.Send(buffer);
		}

		/// <inheritdoc />
		public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags)
		{
			return _socket.Send(buffer, offset, size, socketFlags);
		}

		/// <inheritdoc />
		public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			return _socket.Send(buffer, offset, size, socketFlags, out errorCode);
		}

		/// <inheritdoc />
		public int Send(byte[] buffer, int size, SocketFlags socketFlags)
		{
			return _socket.Send(buffer, size, socketFlags);
		}

		/// <inheritdoc />
		public int Send(byte[] buffer, SocketFlags socketFlags)
		{
			return _socket.Send(buffer, socketFlags);
		}

		/// <inheritdoc />
		public int Send(IList<ArraySegment<byte>> buffers)
		{
			return _socket.Send(buffers);
		}

		/// <inheritdoc />
		public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			return _socket.Send(buffers, socketFlags);
		}

		/// <inheritdoc />
		public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
		{
			return _socket.Send(buffers, socketFlags, out errorCode);
		}

		/// <inheritdoc />
		public bool SendAsync(SocketAsyncEventArgs e)
		{
			return _socket.SendAsync(e);
		}

		/// <inheritdoc />
		public bool SendAsync(ISocketAsyncEventArgs e)
		{
			return _socket.SendAsync(e.ToImplementation<SocketAsyncEventArgs>());
		}

		/// <inheritdoc />
		public bool SendPacketsAsync(SocketAsyncEventArgs e)
		{
			return _socket.SendPacketsAsync(e);
		}

		/// <inheritdoc />
		public bool SendPacketsAsync(ISocketAsyncEventArgs e)
		{
			return _socket.SendPacketsAsync(e.ToImplementation<SocketAsyncEventArgs>());
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP)
		{
			return _socket.SendTo(buffer, offset, size, socketFlags, remoteEP);
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, IEndPoint remoteEP)
		{
			return _socket.SendTo(buffer, offset, size, socketFlags, remoteEP.ToImplementation());
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int SendTo(byte[] buffer, int size, SocketFlags socketFlags, EndPoint remoteEP)
		{
			return _socket.SendTo(buffer, size, socketFlags, remoteEP);
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int SendTo(byte[] buffer, int size, SocketFlags socketFlags, IEndPoint remoteEP)
		{
			return _socket.SendTo(buffer, size, socketFlags, remoteEP.ToImplementation());
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int SendTo(byte[] buffer, EndPoint remoteEP)
		{
			return _socket.SendTo(buffer, remoteEP);
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int SendTo(byte[] buffer, IEndPoint remoteEP)
		{
			return _socket.SendTo(buffer, remoteEP.ToImplementation());
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int SendTo(byte[] buffer, SocketFlags socketFlags, EndPoint remoteEP)
		{
			return _socket.SendTo(buffer, socketFlags, remoteEP);
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int SendTo(byte[] buffer, SocketFlags socketFlags, IEndPoint remoteEP)
		{
			return _socket.SendTo(buffer, socketFlags, remoteEP.ToImplementation());
		}

		/// <inheritdoc />
		public bool SendToAsync(SocketAsyncEventArgs e)
		{
			return _socket.SendToAsync(e);
		}

		/// <inheritdoc />
		public bool SendToAsync(ISocketAsyncEventArgs e)
		{
			return _socket.SendToAsync(e.ToImplementation<SocketAsyncEventArgs>());
		}

		/// <inheritdoc />
		public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, bool optionValue)
		{
			_socket.SetSocketOption(optionLevel, optionName, optionValue);
		}

		/// <inheritdoc />
		public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)
		{
			_socket.SetSocketOption(optionLevel, optionName, optionValue);
		}

		/// <inheritdoc />
		public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue)
		{
			_socket.SetSocketOption(optionLevel, optionName, optionValue);
		}

		/// <inheritdoc />
		public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, object optionValue)
		{
			_socket.SetSocketOption(optionLevel, optionName, optionValue);
		}

		/// <inheritdoc />
		public void Shutdown(SocketShutdown how)
		{
			_socket.Shutdown(how);
		}
	}
}
