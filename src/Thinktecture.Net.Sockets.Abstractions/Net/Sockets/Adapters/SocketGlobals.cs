using System.Collections;
using System.Net.Sockets;

namespace Thinktecture.Net.Sockets.Adapters
{
	/// <summary>
	/// Statics for <see cref="Socket"/>.
	/// </summary>
	public class SocketGlobals : ISocketGlobals
	{
		/// <summary>Indicates whether the underlying operating system and network adaptors support Internet Protocol version 4 (IPv4).</summary>
		/// <returns>true if the operating system and network adaptors support the IPv4 protocol; otherwise, false.</returns>
		// ReSharper disable once InconsistentNaming
		public bool OSSupportsIPv4 => SocketAdapter.OSSupportsIPv4;

		/// <summary>Indicates whether the underlying operating system and network adaptors support Internet Protocol version 6 (IPv6).</summary>
		/// <returns>true if the operating system and network adaptors support the IPv6 protocol; otherwise, false.</returns>
		// ReSharper disable once InconsistentNaming
		public bool OSSupportsIPv6 => SocketAdapter.OSSupportsIPv6;

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
		public bool ConnectAsync(SocketType socketType, ProtocolType protocolType, SocketAsyncEventArgs e)
		{
			return SocketAdapter.ConnectAsync(socketType, protocolType, e);
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
		public bool ConnectAsync(SocketType socketType, ProtocolType protocolType, ISocketAsyncEventArgs e)
		{
			return SocketAdapter.ConnectAsync(socketType, protocolType, e);
		}

		/// <summary>
		/// Cancels an asynchronous request for a remote host connection.
		/// </summary>
		/// <param name="e">The System.Net.Sockets.SocketAsyncEventArgs object used to request the connection to the remote host by calling one of the ConnectAsync methods.</param>
		public void CancelConnectAsync(SocketAsyncEventArgs e)
		{
			SocketAdapter.CancelConnectAsync(e);
		}

		/// <summary>
		/// Cancels an asynchronous request for a remote host connection.
		/// </summary>
		/// <param name="e">The System.Net.Sockets.SocketAsyncEventArgs object used to request the connection to the remote host by calling one of the ConnectAsync methods.</param>
		public void CancelConnectAsync(ISocketAsyncEventArgs e)
		{
			SocketAdapter.CancelConnectAsync(e);
		}

		/// <summary>
		/// Determines the status of one or more sockets.
		/// </summary>
		/// <param name="checkRead">An IList of Socket instances to check for readability.</param>
		/// <param name="checkWrite">An IList of Socket instances to check for writability.</param>
		/// <param name="checkError">An IList of Socket instances to check for errors.</param>
		/// <param name="microSeconds">The time-out value, in microseconds. A -1 value indicates an infinite time-out.</param>
		public void Select(IList checkRead, IList checkWrite, IList checkError, int microSeconds)
		{
			SocketAdapter.Select(checkRead, checkWrite, checkError, microSeconds);
		}
	}
}
