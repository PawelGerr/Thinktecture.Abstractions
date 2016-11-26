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
		private readonly Dictionary<EventHandler<ISocketAsyncEventArgs>, EventHandlerContext> _completedHandlerLookup;

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
			get
			{
				if (_args.SendPacketsElements == null)
					return null;

				var elements = new ISendPacketsElement[_args.SendPacketsElements.Length];

				for (var i = 0; i < _args.SendPacketsElements.Length; i++)
				{
					elements[i] = _args.SendPacketsElements[i].ToInterface();
				}

				return elements;
			}
			set
			{
				if (value == null)
				{
					_args.SendPacketsElements = null;
				}
				else
				{
					var elements = new SendPacketsElement[_args.SendPacketsElements.Length];

					for (var i = 0; i < value.Length; i++)
					{
						elements[i] = value[i].ToImplementation();
					}

					_args.SendPacketsElements = elements;
				}
			}
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
			add
			{
				if (value != null)
				{
					EventHandlerContext ctx;
					if (!_completedHandlerLookup.TryGetValue(value, out ctx))
					{
						ctx = new EventHandlerContext((sender, args) => value(sender, args.ToInterface()));
						_completedHandlerLookup.Add(value, ctx);
					}

					_args.Completed += ctx.Handler;
					ctx.Count++;
				}
			}
			remove
			{
				if (value != null)
				{
					EventHandlerContext ctx;
					if (_completedHandlerLookup.TryGetValue(value, out ctx))
					{
						_args.Completed -= ctx.Handler;
						ctx.Count--;

						if (ctx.Count <= 0)
							_completedHandlerLookup.Remove(value);
					}
				}
			}
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
			_completedHandlerLookup = new Dictionary<EventHandler<ISocketAsyncEventArgs>, EventHandlerContext>(new InstanceEqualityComparer());
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

		private class EventHandlerContext
		{
			public EventHandler<SocketAsyncEventArgs> Handler { get; }
			public int Count { get; set; }

			public EventHandlerContext(EventHandler<SocketAsyncEventArgs> handler)
			{
				Handler = handler;
			}
		}

		private class InstanceEqualityComparer : IEqualityComparer<EventHandler<ISocketAsyncEventArgs>>
		{
			public bool Equals(EventHandler<ISocketAsyncEventArgs> x, EventHandler<ISocketAsyncEventArgs> y)
			{
				return ReferenceEquals(x, y);
			}

			public int GetHashCode(EventHandler<ISocketAsyncEventArgs> obj)
			{
				return obj?.GetHashCode() ?? 0;
			}
		}
	}
}