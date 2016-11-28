using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Sockets;
using Thinktecture.Adapters;
using Thinktecture.Extensions;

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
			get { return _args.AcceptSocket.ToInterface(); }
			set { _args.AcceptSocket = value.ToImplementation(); }
		}

		/// <inheritdoc />
		public byte[] Buffer => _args.Buffer;

		/// <inheritdoc />
		public IList<ArraySegment<byte>> BufferList
		{
			get { return _args.BufferList; }
			set { _args.BufferList = value; }
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
			get { return _args.RemoteEndPoint.ToInterface(); }
			set { _args.RemoteEndPoint = value.ToImplementation(); }
		}

		/// <inheritdoc />
		public ISendPacketsElement[] SendPacketsElements
		{
			get { return _args.SendPacketsElements.ToInterface(); }
			set { _args.SendPacketsElements = value.ToImplementation<ISendPacketsElement, SendPacketsElement>(); }
		}

		/// <inheritdoc />
		public int SendPacketsSendSize
		{
			get { return _args.SendPacketsSendSize; }
			set { _args.SendPacketsSendSize = value; }
		}

		/// <inheritdoc />
		public SocketError SocketError
		{
			get { return _args.SocketError; }
			set { _args.SocketError = value; }
		}

		/// <inheritdoc />
		public SocketFlags SocketFlags
		{
			get { return _args.SocketFlags; }
			set { _args.SocketFlags = value; }
		}

		/// <inheritdoc />
		public object UserToken
		{
			get { return _args.UserToken; }
			set { _args.UserToken = value; }
		}

		/// <inheritdoc />
		public event EventHandler<ISocketAsyncEventArgs> Completed
		{
			add { _args.Completed += _completedLookup.MapForAttachment(value, args => args.ToInterface()); }
			remove { _args.Completed -= _completedLookup.TryMapForDetachment(value); }
		}

		/// <summary>
		/// Initializes new instance of <see cref="SocketAsyncEventArgsAdapter"/>.
		/// </summary>
		/// <param name="args">Event args to be used by the adapter.</param>
		public SocketAsyncEventArgsAdapter(SocketAsyncEventArgs args)
			: base(args)
		{
			if (args == null)
				throw new ArgumentNullException(nameof(args));

			_args = args;
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