using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.Sockets.Adapters
{
	/// <summary>Implements the Berkeley sockets interface.</summary>
	public class SocketAdapter : AbstractionAdapter<Socket>, ISocket
	{
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
		public static bool ConnectAsync(SocketType socketType, ProtocolType protocolType, [NotNull] SocketAsyncEventArgs e)
		{
			return Socket.ConnectAsync(socketType, protocolType, e);
		}

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
		public static bool ConnectAsync(SocketType socketType, ProtocolType protocolType, [NotNull] ISocketAsyncEventArgs e)
		{
			return Socket.ConnectAsync(socketType, protocolType, e.ToImplementation());
		}

		/// <summary>
		/// Cancels an asynchronous request for a remote host connection.
		/// </summary>
		/// <param name="e">The System.Net.Sockets.SocketAsyncEventArgs object used to request the connection to the remote host by calling one of the ConnectAsync methods.</param>
		public static void CancelConnectAsync([NotNull] SocketAsyncEventArgs e)
		{
			Socket.CancelConnectAsync(e);
		}

		/// <summary>
		/// Cancels an asynchronous request for a remote host connection.
		/// </summary>
		/// <param name="e">The System.Net.Sockets.SocketAsyncEventArgs object used to request the connection to the remote host by calling one of the ConnectAsync methods.</param>
		public static void CancelConnectAsync([NotNull] ISocketAsyncEventArgs e)
		{
			Socket.CancelConnectAsync(e.ToImplementation());
		}

		/// <summary>
		/// Determines the status of one or more sockets.
		/// </summary>
		/// <param name="checkRead">An IList of Socket instances to check for readability.</param>
		/// <param name="checkWrite">An IList of Socket instances to check for writability.</param>
		/// <param name="checkError">An IList of Socket instances to check for errors.</param>
		/// <param name="microSeconds">The time-out value, in microseconds. A -1 value indicates an infinite time-out.</param>
		public static void Select([NotNull] IList checkRead, [NotNull] IList checkWrite, [NotNull] IList checkError, int microSeconds)
		{
			Socket.Select(checkRead, checkWrite, checkError, microSeconds);
		}

		/// <inheritdoc />
		public AddressFamily AddressFamily => Implementation.AddressFamily;

		/// <inheritdoc />
		public int Available => Implementation.Available;

		/// <inheritdoc />
		public bool Blocking
		{
			get => Implementation.Blocking;
			set => Implementation.Blocking = value;
		}

		/// <inheritdoc />
		public bool Connected => Implementation.Connected;

		/// <inheritdoc />
		public bool DontFragment
		{
			get => Implementation.DontFragment;
			set => Implementation.DontFragment = value;
		}

		/// <inheritdoc />
		public bool DualMode
		{
			get => Implementation.DualMode;
			set => Implementation.DualMode = value;
		}

		/// <inheritdoc />
		public bool EnableBroadcast
		{
			get => Implementation.EnableBroadcast;
			set => Implementation.EnableBroadcast = value;
		}

		/// <inheritdoc />
		public bool ExclusiveAddressUse
		{
			get => Implementation.ExclusiveAddressUse;
			set => Implementation.ExclusiveAddressUse = value;
		}

		/// <inheritdoc />
		public bool IsBound => Implementation.IsBound;

		/// <inheritdoc />
		public ILingerOption LingerState
		{
			get => Implementation.LingerState.ToInterface();
			set => Implementation.LingerState = value.ToImplementation();
		}

		/// <inheritdoc />
		public IEndPoint LocalEndPoint => Implementation.LocalEndPoint.ToInterface();

		/// <inheritdoc />
		public bool MulticastLoopback
		{
			get => Implementation.MulticastLoopback;
			set => Implementation.MulticastLoopback = value;
		}

		/// <inheritdoc />
		public bool NoDelay
		{
			get => Implementation.NoDelay;
			set => Implementation.NoDelay = value;
		}

		/// <inheritdoc />
		public ProtocolType ProtocolType => Implementation.ProtocolType;

		/// <inheritdoc />
		public int ReceiveBufferSize
		{
			get => Implementation.ReceiveBufferSize;
			set => Implementation.ReceiveBufferSize = value;
		}

		/// <inheritdoc />
		public int ReceiveTimeout
		{
			get => Implementation.ReceiveTimeout;
			set => Implementation.ReceiveTimeout = value;
		}

		/// <inheritdoc />
		public IEndPoint RemoteEndPoint => Implementation.RemoteEndPoint.ToInterface();

		/// <inheritdoc />
		public int SendBufferSize
		{
			get => Implementation.SendBufferSize;
			set => Implementation.SendBufferSize = value;
		}

		/// <inheritdoc />
		public int SendTimeout
		{
			get => Implementation.SendTimeout;
			set => Implementation.SendTimeout = value;
		}

		/// <inheritdoc />
		public SocketType SocketType => Implementation.SocketType;

		/// <inheritdoc />
		public short Ttl
		{
			get => Implementation.Ttl;
			set => Implementation.Ttl = value;
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
		public SocketAdapter([NotNull] Socket socket)
			: base(socket)
		{
		}

		/// <inheritdoc />
		public ISocket Accept()
		{
			return Implementation.Accept().ToInterface();
		}

		/// <inheritdoc />
		public bool AcceptAsync(SocketAsyncEventArgs e)
		{
			return Implementation.AcceptAsync(e);
		}

		/// <inheritdoc />
		public bool AcceptAsync(ISocketAsyncEventArgs e)
		{
			return Implementation.AcceptAsync(e.ToImplementation<SocketAsyncEventArgs>());
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public void Bind(EndPoint localEP)
		{
			Implementation.Bind(localEP);
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public void Bind(IEndPoint localEP)
		{
			Implementation.Bind(localEP.ToImplementation());
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public void Connect(EndPoint remoteEP)
		{
			Implementation.Connect(remoteEP);
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public void Connect(IEndPoint remoteEP)
		{
			Implementation.Connect(remoteEP.ToImplementation());
		}

		/// <inheritdoc />
		public void Connect(IPAddress address, int port)
		{
			Implementation.Connect(address, port);
		}

		/// <inheritdoc />
		public void Connect(IIPAddress address, int port)
		{
			Implementation.Connect(address.ToImplementation(), port);
		}

		/// <inheritdoc />
		public void Connect(IPAddress[] addresses, int port)
		{
			Implementation.Connect(addresses, port);
		}

		/// <inheritdoc />
		public void Connect(IIPAddress[] addresses, int port)
		{
			Implementation.Connect(addresses.ToImplementation<IIPAddress, IPAddress>(), port);
		}

		/// <inheritdoc />
		public void Connect(string host, int port)
		{
			Implementation.Connect(host, port);
		}

		/// <inheritdoc />
		public bool ConnectAsync(SocketAsyncEventArgs e)
		{
			return Implementation.ConnectAsync(e);
		}

		/// <inheritdoc />
		public bool ConnectAsync(ISocketAsyncEventArgs e)
		{
			return Implementation.ConnectAsync(e.ToImplementation<SocketAsyncEventArgs>());
		}

		/// <inheritdoc />
		public void Dispose()
		{
			Implementation.Dispose();
		}

		/// <inheritdoc />
		public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName)
		{
			return Implementation.GetSocketOption(optionLevel, optionName);
		}

		/// <inheritdoc />
		public void GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)
		{
			Implementation.GetSocketOption(optionLevel, optionName, optionValue);
		}

		/// <inheritdoc />
		public byte[] GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionLength)
		{
			return Implementation.GetSocketOption(optionLevel, optionName, optionLength);
		}

		/// <inheritdoc />
		public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue)
		{
			return Implementation.IOControl(ioControlCode, optionInValue, optionOutValue);
		}

		/// <inheritdoc />
		public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue)
		{
			return Implementation.IOControl(ioControlCode, optionInValue, optionOutValue);
		}

		/// <inheritdoc />
		public void Listen(int backlog)
		{
			Implementation.Listen(backlog);
		}

		/// <inheritdoc />
		public bool Poll(int microSeconds, SelectMode mode)
		{
			return Implementation.Poll(microSeconds, mode);
		}

		/// <inheritdoc />
		public int Receive(byte[] buffer)
		{
			return Implementation.Receive(buffer);
		}

		/// <inheritdoc />
		public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags)
		{
			return Implementation.Receive(buffer, offset, size, socketFlags);
		}

		/// <inheritdoc />
		public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			return Implementation.Receive(buffer, offset, size, socketFlags, out errorCode);
		}

		/// <inheritdoc />
		public int Receive(byte[] buffer, int size, SocketFlags socketFlags)
		{
			return Implementation.Receive(buffer, size, socketFlags);
		}

		/// <inheritdoc />
		public int Receive(byte[] buffer, SocketFlags socketFlags)
		{
			return Implementation.Receive(buffer, socketFlags);
		}

		/// <inheritdoc />
		public int Receive(IList<ArraySegment<byte>> buffers)
		{
			return Implementation.Receive(buffers);
		}

		/// <inheritdoc />
		public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			return Implementation.Receive(buffers, socketFlags);
		}

		/// <inheritdoc />
		public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
		{
			return Implementation.Receive(buffers, socketFlags, out errorCode);
		}

		/// <inheritdoc />
		public bool ReceiveAsync(SocketAsyncEventArgs e)
		{
			return Implementation.ReceiveAsync(e);
		}

		/// <inheritdoc />
		public bool ReceiveAsync(ISocketAsyncEventArgs e)
		{
			return Implementation.ReceiveAsync(e.ToImplementation<SocketAsyncEventArgs>());
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP)
		{
			return Implementation.ReceiveFrom(buffer, offset, size, socketFlags, ref remoteEP);
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref IEndPoint remoteEP)
		{
			var tempRemoteEp = remoteEP.ToImplementation();
			var result = Implementation.ReceiveFrom(buffer, offset, size, socketFlags, ref tempRemoteEp);

			if (!ReferenceEquals(tempRemoteEp, remoteEP.ToImplementation()))
				remoteEP = tempRemoteEp.ToInterface();

			return result;
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int ReceiveFrom(byte[] buffer, int size, SocketFlags socketFlags, ref EndPoint remoteEP)
		{
			return Implementation.ReceiveFrom(buffer, size, socketFlags, ref remoteEP);
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int ReceiveFrom(byte[] buffer, int size, SocketFlags socketFlags, ref IEndPoint remoteEP)
		{
			var tempRemoteEp = remoteEP.ToImplementation();
			var result = Implementation.ReceiveFrom(buffer, size, socketFlags, ref tempRemoteEp);

			if (!ReferenceEquals(tempRemoteEp, remoteEP.ToImplementation()))
				remoteEP = tempRemoteEp.ToInterface();

			return result;
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int ReceiveFrom(byte[] buffer, ref EndPoint remoteEP)
		{
			return Implementation.ReceiveFrom(buffer, ref remoteEP);
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int ReceiveFrom(byte[] buffer, ref IEndPoint remoteEP)
		{
			var tempRemoteEp = remoteEP.ToImplementation();
			var result = Implementation.ReceiveFrom(buffer, ref tempRemoteEp);

			if (!ReferenceEquals(tempRemoteEp, remoteEP.ToImplementation()))
				remoteEP = tempRemoteEp.ToInterface();

			return result;
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int ReceiveFrom(byte[] buffer, SocketFlags socketFlags, ref EndPoint remoteEP)
		{
			return Implementation.ReceiveFrom(buffer, socketFlags, ref remoteEP);
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int ReceiveFrom(byte[] buffer, SocketFlags socketFlags, ref IEndPoint remoteEP)
		{
			var tempRemoteEp = remoteEP.ToImplementation();
			var result = Implementation.ReceiveFrom(buffer, socketFlags, ref tempRemoteEp);

			if (!ReferenceEquals(tempRemoteEp, remoteEP.ToImplementation()))
				remoteEP = tempRemoteEp.ToInterface();

			return result;
		}

		/// <inheritdoc />
		public bool ReceiveFromAsync(SocketAsyncEventArgs e)
		{
			return Implementation.ReceiveFromAsync(e);
		}

		/// <inheritdoc />
		public bool ReceiveFromAsync(ISocketAsyncEventArgs e)
		{
			return Implementation.ReceiveFromAsync(e.ToImplementation<SocketAsyncEventArgs>());
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int ReceiveMessageFrom(byte[] buffer, int offset, int size, ref SocketFlags socketFlags, ref EndPoint remoteEP, out IPPacketInformation ipPacketInformation)
		{
			return Implementation.ReceiveMessageFrom(buffer, offset, size, ref socketFlags, ref remoteEP, out ipPacketInformation);
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int ReceiveMessageFrom(byte[] buffer, int offset, int size, ref SocketFlags socketFlags, ref IEndPoint remoteEP, out IPPacketInformation ipPacketInformation)
		{
			var tempRemoteEp = remoteEP.ToImplementation();
			var result = Implementation.ReceiveMessageFrom(buffer, offset, size, ref socketFlags, ref tempRemoteEp, out ipPacketInformation);

			if (!ReferenceEquals(tempRemoteEp, remoteEP.ToImplementation()))
				remoteEP = tempRemoteEp.ToInterface();

			return result;
		}

		/// <inheritdoc />
		public bool ReceiveMessageFromAsync(SocketAsyncEventArgs e)
		{
			return Implementation.ReceiveMessageFromAsync(e);
		}

		/// <inheritdoc />
		public bool ReceiveMessageFromAsync(ISocketAsyncEventArgs e)
		{
			return Implementation.ReceiveMessageFromAsync(e.ToImplementation<SocketAsyncEventArgs>());
		}

		/// <inheritdoc />
		public int Send(byte[] buffer)
		{
			return Implementation.Send(buffer);
		}

		/// <inheritdoc />
		public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags)
		{
			return Implementation.Send(buffer, offset, size, socketFlags);
		}

		/// <inheritdoc />
		public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			return Implementation.Send(buffer, offset, size, socketFlags, out errorCode);
		}

		/// <inheritdoc />
		public int Send(byte[] buffer, int size, SocketFlags socketFlags)
		{
			return Implementation.Send(buffer, size, socketFlags);
		}

		/// <inheritdoc />
		public int Send(byte[] buffer, SocketFlags socketFlags)
		{
			return Implementation.Send(buffer, socketFlags);
		}

		/// <inheritdoc />
		public int Send(IList<ArraySegment<byte>> buffers)
		{
			return Implementation.Send(buffers);
		}

		/// <inheritdoc />
		public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			return Implementation.Send(buffers, socketFlags);
		}

		/// <inheritdoc />
		public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
		{
			return Implementation.Send(buffers, socketFlags, out errorCode);
		}

		/// <inheritdoc />
		public bool SendAsync(SocketAsyncEventArgs e)
		{
			return Implementation.SendAsync(e);
		}

		/// <inheritdoc />
		public bool SendAsync(ISocketAsyncEventArgs e)
		{
			return Implementation.SendAsync(e.ToImplementation<SocketAsyncEventArgs>());
		}

		/// <inheritdoc />
		public bool SendPacketsAsync(SocketAsyncEventArgs e)
		{
			return Implementation.SendPacketsAsync(e);
		}

		/// <inheritdoc />
		public bool SendPacketsAsync(ISocketAsyncEventArgs e)
		{
			return Implementation.SendPacketsAsync(e.ToImplementation<SocketAsyncEventArgs>());
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP)
		{
			return Implementation.SendTo(buffer, offset, size, socketFlags, remoteEP);
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, IEndPoint remoteEP)
		{
			return Implementation.SendTo(buffer, offset, size, socketFlags, remoteEP.ToImplementation());
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int SendTo(byte[] buffer, int size, SocketFlags socketFlags, EndPoint remoteEP)
		{
			return Implementation.SendTo(buffer, size, socketFlags, remoteEP);
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int SendTo(byte[] buffer, int size, SocketFlags socketFlags, IEndPoint remoteEP)
		{
			return Implementation.SendTo(buffer, size, socketFlags, remoteEP.ToImplementation());
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int SendTo(byte[] buffer, EndPoint remoteEP)
		{
			return Implementation.SendTo(buffer, remoteEP);
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int SendTo(byte[] buffer, IEndPoint remoteEP)
		{
			return Implementation.SendTo(buffer, remoteEP.ToImplementation());
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int SendTo(byte[] buffer, SocketFlags socketFlags, EndPoint remoteEP)
		{
			return Implementation.SendTo(buffer, socketFlags, remoteEP);
		}

		/// <inheritdoc />
		// ReSharper disable once InconsistentNaming
		public int SendTo(byte[] buffer, SocketFlags socketFlags, IEndPoint remoteEP)
		{
			return Implementation.SendTo(buffer, socketFlags, remoteEP.ToImplementation());
		}

		/// <inheritdoc />
		public bool SendToAsync(SocketAsyncEventArgs e)
		{
			return Implementation.SendToAsync(e);
		}

		/// <inheritdoc />
		public bool SendToAsync(ISocketAsyncEventArgs e)
		{
			return Implementation.SendToAsync(e.ToImplementation<SocketAsyncEventArgs>());
		}

		/// <inheritdoc />
		public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, bool optionValue)
		{
			Implementation.SetSocketOption(optionLevel, optionName, optionValue);
		}

		/// <inheritdoc />
		public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)
		{
			Implementation.SetSocketOption(optionLevel, optionName, optionValue);
		}

		/// <inheritdoc />
		public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue)
		{
			Implementation.SetSocketOption(optionLevel, optionName, optionValue);
		}

		/// <inheritdoc />
		public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, object optionValue)
		{
			Implementation.SetSocketOption(optionLevel, optionName, optionValue);
		}

		/// <inheritdoc />
		public void Shutdown(SocketShutdown how)
		{
			Implementation.Shutdown(how);
		}
	}
}
