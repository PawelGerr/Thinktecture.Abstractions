using System;
using System.Collections.Generic;
using System.Net.Sockets;
using JetBrains.Annotations;

namespace Thinktecture.Net.Sockets
{
	/// <summary>Represents an asynchronous socket operation.</summary>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface ISocketAsyncEventArgs : IEventArgs, IDisposable, IAbstraction<SocketAsyncEventArgs>
	{
		/// <summary>Gets or sets the socket to use or the socket created for accepting a connection with an asynchronous socket method.</summary>
		/// <returns>The <see cref="T:System.Net.Sockets.Socket" /> to use or the socket created for accepting a connection with an asynchronous socket method.</returns>
		[CanBeNull]
		ISocket AcceptSocket { get; set; }

		/// <summary>Gets the data buffer to use with an asynchronous socket method.</summary>
		/// <returns>A <see cref="T:System.Byte" /> array that represents the data buffer to use with an asynchronous socket method.</returns>
		[CanBeNull]
		byte[] Buffer { get; }

		/// <summary>Gets or sets an array of data buffers to use with an asynchronous socket method.</summary>
		/// <returns>An <see cref="T:System.Collections.IList" /> that represents an array of data buffers to use with an asynchronous socket method.</returns>
		/// <exception cref="T:System.ArgumentException">There are ambiguous buffers specified on a set operation. This exception occurs if the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> property has been set to a non-null value and an attempt was made to set the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> property to a non-null value.</exception>
		[CanBeNull]
		IList<ArraySegment<byte>> BufferList { get; set; }

		/// <summary>Gets the number of bytes transferred in the socket operation.</summary>
		/// <returns>An <see cref="T:System.Int32" /> that contains the number of bytes transferred in the socket operation.</returns>
		int BytesTransferred { get; }

		/// <summary>Gets the exception in the case of a connection failure when a <see cref="T:System.Net.DnsEndPoint" /> was used.</summary>
		/// <returns>An <see cref="T:System.Exception" /> that indicates the cause of the connection error when a <see cref="T:System.Net.DnsEndPoint" /> was specified for the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.RemoteEndPoint" /> property.</returns>
		[CanBeNull]
		Exception ConnectByNameError { get; }

		/// <summary>The created and connected <see cref="T:System.Net.Sockets.Socket" /> object after successful completion of the <see cref="ISocket.ConnectAsync(ISocketAsyncEventArgs)" /> method.</summary>
		/// <returns>The connected <see cref="T:System.Net.Sockets.Socket" /> object.</returns>
		[CanBeNull]
		ISocket ConnectSocket { get; }

		/// <summary>Gets the maximum amount of data, in bytes, to send or receive in an asynchronous operation.</summary>
		/// <returns>An <see cref="T:System.Int32" /> that contains the maximum amount of data, in bytes, to send or receive.</returns>
		int Count { get; }

		/// <summary>Gets the type of socket operation most recently performed with this context object.</summary>
		/// <returns>A <see cref="T:System.Net.Sockets.SocketAsyncOperation" /> instance that indicates the type of socket operation most recently performed with this context object.</returns>
		SocketAsyncOperation LastOperation { get; }

		/// <summary>Gets the offset, in bytes, into the data buffer referenced by the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> property.</summary>
		/// <returns>An <see cref="T:System.Int32" /> that contains the offset, in bytes, into the data buffer referenced by the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> property.</returns>
		int Offset { get; }

		/// <summary>
		/// Gets the IP address and interface of a received packet.
		/// </summary>
		IPPacketInformation ReceiveMessageFromPacketInfo { get; }

		/// <summary>Gets or sets the remote IP endpoint for an asynchronous operation.</summary>
		/// <returns>An <see cref="T:System.Net.EndPoint" /> that represents the remote IP endpoint for an asynchronous operation.</returns>
		[CanBeNull]
		IEndPoint RemoteEndPoint { get; set; }

		/// <summary>
		/// Gets or sets an array of buffers to be sent for an asynchronous operation used by the Socket.SendPacketsAsync method.
		/// </summary>
		[CanBeNull]
		ISendPacketsElement[] SendPacketsElements { get; set; }

		/// <summary>
		/// Gets or sets the size, in bytes, of the data block used in the send operation.
		/// </summary>
		int SendPacketsSendSize { get; set; }

		/// <summary>Gets or sets the result of the asynchronous socket operation.</summary>
		/// <returns>A <see cref="T:System.Net.Sockets.SocketError" /> that represents the result of the asynchronous socket operation.</returns>
		SocketError SocketError { get; set; }

		/// <summary>
		/// Gets the results of an asynchronous socket operation or sets the behavior of an asynchronous operation.
		/// </summary>
		SocketFlags SocketFlags { get; set; }

		/// <summary>Gets or sets a user or application object associated with this asynchronous socket operation.</summary>
		/// <returns>An object that represents the user or application object associated with this asynchronous socket operation.</returns>
		[CanBeNull]
		object UserToken { get; set; }

		/// <summary>The event used to complete an asynchronous operation.</summary>
		event EventHandler<ISocketAsyncEventArgs> Completed;

		/// <summary>Sets the data buffer to use with an asynchronous socket method.</summary>
		/// <param name="buffer">The data buffer to use with an asynchronous socket method.</param>
		/// <param name="offset">The offset, in bytes, in the data buffer where the operation starts.</param>
		/// <param name="count">The maximum amount of data, in bytes, to send or receive in the buffer.</param>
		/// <exception cref="T:System.ArgumentException">There are ambiguous buffers specified. This exception occurs if the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> property is also not null and the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.BufferList" /> property is also not null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">An argument was out of range. This exception occurs if the <paramref name="offset" /> parameter is less than zero or greater than the length of the array in the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> property. This exception also occurs if the <paramref name="count" /> parameter is less than zero or greater than the length of the array in the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> property minus the <paramref name="offset" /> parameter.</exception>
		void SetBuffer([CanBeNull] byte[] buffer, int offset, int count);

		/// <summary>Sets the data buffer to use with an asynchronous socket method.</summary>
		/// <param name="offset">The offset, in bytes, in the data buffer where the operation starts.</param>
		/// <param name="count">The maximum amount of data, in bytes, to send or receive in the buffer.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">An argument was out of range. This exception occurs if the <paramref name="offset" /> parameter is less than zero or greater than the length of the array in the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> property. This exception also occurs if the <paramref name="count" /> parameter is less than zero or greater than the length of the array in the <see cref="P:System.Net.Sockets.SocketAsyncEventArgs.Buffer" /> property minus the <paramref name="offset" /> parameter.</exception>
		void SetBuffer(int offset, int count);
	}
}
