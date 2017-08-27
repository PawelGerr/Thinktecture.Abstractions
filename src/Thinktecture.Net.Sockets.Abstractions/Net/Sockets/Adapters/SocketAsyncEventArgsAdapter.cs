using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Sockets;
using Thinktecture.Adapters;

namespace Thinktecture.Net.Sockets.Adapters
{
	/// <summary>Represents an asynchronous socket operation.</summary>
	public class SocketAsyncEventArgsAdapter : EventArgsAdapter, ISocketAsyncEventArgs
	{
		private readonly SocketAsyncEventArgs _args;
		private readonly AbstractionEventHandlerLookup<ISocketAsyncEventArgs, SocketAsyncEventArgs> _completedLookup;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new SocketAsyncEventArgs UnsafeConvert()
		{
			return _args;
		}

		/// <inheritdoc />
		public ISocket AcceptSocket
		{
			get => _args.AcceptSocket.ToInterface();
			set => _args.AcceptSocket = value.ToImplementation();
		}

		/// <inheritdoc />
		public byte[] Buffer => _args.Buffer;

		/// <inheritdoc />
		public IList<ArraySegment<byte>> BufferList
		{
			get => _args.BufferList;
			set => _args.BufferList = value;
		}

		/// <inheritdoc />
		public int BytesTransferred => _args.BytesTransferred;

		/// <inheritdoc />
		public Exception ConnectByNameError => _args.ConnectByNameError;

		/// <inheritdoc />
		public ISocket ConnectSocket => _args.ConnectSocket.ToInterface();

		/// <inheritdoc />
		public int Count => _args.Count;

		/// <inheritdoc />
		public SocketAsyncOperation LastOperation => _args.LastOperation;

		/// <inheritdoc />
		public int Offset => _args.Offset;

		/// <inheritdoc />
		public IPPacketInformation ReceiveMessageFromPacketInfo => _args.ReceiveMessageFromPacketInfo;

		/// <inheritdoc />
		public IEndPoint RemoteEndPoint
		{
			get => _args.RemoteEndPoint.ToInterface();
			set => _args.RemoteEndPoint = value.ToImplementation();
		}

		/// <inheritdoc />
		public ISendPacketsElement[] SendPacketsElements
		{
			get => _args.SendPacketsElements.ToInterface();
			set => _args.SendPacketsElements = value.ToImplementation<ISendPacketsElement, SendPacketsElement>();
		}

		/// <inheritdoc />
		public int SendPacketsSendSize
		{
			get => _args.SendPacketsSendSize;
			set => _args.SendPacketsSendSize = value;
		}

		/// <inheritdoc />
		public SocketError SocketError
		{
			get => _args.SocketError;
			set => _args.SocketError = value;
		}

		/// <inheritdoc />
		public SocketFlags SocketFlags
		{
			get => _args.SocketFlags;
			set => _args.SocketFlags = value;
		}

		/// <inheritdoc />
		public object UserToken
		{
			get => _args.UserToken;
			set => _args.UserToken = value;
		}

		/// <inheritdoc />
		public event EventHandler<ISocketAsyncEventArgs> Completed
		{
			add => _args.Completed += _completedLookup.MapForAttachment(value, args => args.ToInterface());
			remove => _args.Completed -= _completedLookup.TryMapForDetachment(value);
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
		public SocketAsyncEventArgsAdapter(SocketAsyncEventArgs args)
			: base(args)
		{
			_args = args ?? throw new ArgumentNullException(nameof(args));
			_completedLookup = new AbstractionEventHandlerLookup<ISocketAsyncEventArgs, SocketAsyncEventArgs>();
		}

		/// <inheritdoc />
		public void SetBuffer(byte[] buffer, int offset, int count)
		{
			_args.SetBuffer(buffer, offset, count);
		}

		/// <inheritdoc />
		public void SetBuffer(int offset, int count)
		{
			_args.SetBuffer(offset, count);
		}

		/// <inheritdoc />
		public void Dispose()
		{
			_args.Dispose();
		}
	}
}
