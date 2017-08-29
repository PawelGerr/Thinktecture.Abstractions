using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Sockets;
using JetBrains.Annotations;
using Thinktecture.Adapters;

namespace Thinktecture.Net.Sockets.Adapters
{
	/// <summary>Represents an asynchronous socket operation.</summary>
	public class SocketAsyncEventArgsAdapter : EventArgsAdapter, ISocketAsyncEventArgs
	{
		[NotNull]
		private readonly AbstractionEventHandlerLookup<ISocketAsyncEventArgs, SocketAsyncEventArgs> _completedLookup;

		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		[NotNull]
		protected new SocketAsyncEventArgs Implementation { get; }

		/// <inheritdoc />
		[NotNull, EditorBrowsable(EditorBrowsableState.Never)]
		public new SocketAsyncEventArgs UnsafeConvert()
		{
			return Implementation;
		}

		/// <inheritdoc />
		public ISocket AcceptSocket
		{
			get => Implementation.AcceptSocket.ToInterface();
			set => Implementation.AcceptSocket = value.ToImplementation();
		}

		/// <inheritdoc />
		public byte[] Buffer => Implementation.Buffer;

		/// <inheritdoc />
		public IList<ArraySegment<byte>> BufferList
		{
			get => Implementation.BufferList;
			set => Implementation.BufferList = value;
		}

		/// <inheritdoc />
		public int BytesTransferred => Implementation.BytesTransferred;

		/// <inheritdoc />
		public Exception ConnectByNameError => Implementation.ConnectByNameError;

		/// <inheritdoc />
		public ISocket ConnectSocket => Implementation.ConnectSocket.ToInterface();

		/// <inheritdoc />
		public int Count => Implementation.Count;

		/// <inheritdoc />
		public SocketAsyncOperation LastOperation => Implementation.LastOperation;

		/// <inheritdoc />
		public int Offset => Implementation.Offset;

		/// <inheritdoc />
		public IPPacketInformation ReceiveMessageFromPacketInfo => Implementation.ReceiveMessageFromPacketInfo;

		/// <inheritdoc />
		public IEndPoint RemoteEndPoint
		{
			get => Implementation.RemoteEndPoint.ToInterface();
			set => Implementation.RemoteEndPoint = value.ToImplementation();
		}

		/// <inheritdoc />
		public ISendPacketsElement[] SendPacketsElements
		{
			get => Implementation.SendPacketsElements.ToInterface();
			set => Implementation.SendPacketsElements = value.ToImplementation<ISendPacketsElement, SendPacketsElement>();
		}

		/// <inheritdoc />
		public int SendPacketsSendSize
		{
			get => Implementation.SendPacketsSendSize;
			set => Implementation.SendPacketsSendSize = value;
		}

		/// <inheritdoc />
		public SocketError SocketError
		{
			get => Implementation.SocketError;
			set => Implementation.SocketError = value;
		}

		/// <inheritdoc />
		public SocketFlags SocketFlags
		{
			get => Implementation.SocketFlags;
			set => Implementation.SocketFlags = value;
		}

		/// <inheritdoc />
		public object UserToken
		{
			get => Implementation.UserToken;
			set => Implementation.UserToken = value;
		}

		/// <inheritdoc />
		public event EventHandler<ISocketAsyncEventArgs> Completed
		{
			add => Implementation.Completed += _completedLookup.MapForAttachment(value, args => args.ToInterface());
			remove => Implementation.Completed -= _completedLookup.TryMapForDetachment(value);
		}

		/// <summary>
		/// Initializes new instance of <see cref="SocketAsyncEventArgsAdapter"/>.
		/// </summary>
		public SocketAsyncEventArgsAdapter()
			: this(new SocketAsyncEventArgs())
		{
		}

		/// <summary>
		/// Initializes new instance of <see cref="SocketAsyncEventArgsAdapter"/>.
		/// </summary>
		/// <param name="args">Event args to be used by the adapter.</param>
		public SocketAsyncEventArgsAdapter([NotNull] SocketAsyncEventArgs args)
			: base(args)
		{
			Implementation = args ?? throw new ArgumentNullException(nameof(args));
			_completedLookup = new AbstractionEventHandlerLookup<ISocketAsyncEventArgs, SocketAsyncEventArgs>();
		}

		/// <inheritdoc />
		public void SetBuffer(byte[] buffer, int offset, int count)
		{
			Implementation.SetBuffer(buffer, offset, count);
		}

		/// <inheritdoc />
		public void SetBuffer(int offset, int count)
		{
			Implementation.SetBuffer(offset, count);
		}

		/// <inheritdoc />
		public void Dispose()
		{
			Implementation.Dispose();
		}
	}
}
