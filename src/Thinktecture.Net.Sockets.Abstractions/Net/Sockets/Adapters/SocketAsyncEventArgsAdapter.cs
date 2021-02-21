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
      private readonly AbstractionEventHandlerLookup<ISocketAsyncEventArgs, SocketAsyncEventArgs> _completedLookup;

      /// <summary>
      /// Implementation used by the adapter.
      /// </summary>
      protected new SocketAsyncEventArgs Implementation { get; }

      /// <inheritdoc />
      [EditorBrowsable(EditorBrowsableState.Never)]
      public new SocketAsyncEventArgs UnsafeConvert()
      {
         return Implementation;
      }

      /// <inheritdoc />
      public ISocket? AcceptSocket
      {
         get => Implementation.AcceptSocket.ToInterface();
         set => Implementation.AcceptSocket = value.ToImplementation();
      }

      /// <inheritdoc />
      public byte[]? Buffer => Implementation.Buffer;

      /// <inheritdoc />
      public Memory<byte> MemoryBuffer => Implementation.MemoryBuffer;

      /// <inheritdoc />
      public IList<ArraySegment<byte>>? BufferList
      {
         get => Implementation.BufferList;
         set => Implementation.BufferList = value;
      }

      /// <inheritdoc />
      public int BytesTransferred => Implementation.BytesTransferred;

      /// <inheritdoc />
      public Exception? ConnectByNameError => Implementation.ConnectByNameError;

      /// <inheritdoc />
      public ISocket? ConnectSocket => Implementation.ConnectSocket.ToInterface();

      /// <inheritdoc />
      public int Count => Implementation.Count;

      /// <inheritdoc />
      public SocketAsyncOperation LastOperation => Implementation.LastOperation;

      /// <inheritdoc />
      public int Offset => Implementation.Offset;

      /// <inheritdoc />
      public IPPacketInformation ReceiveMessageFromPacketInfo => Implementation.ReceiveMessageFromPacketInfo;

      /// <inheritdoc />
      public IEndPoint? RemoteEndPoint
      {
         get => Implementation.RemoteEndPoint.ToInterface();
         set => Implementation.RemoteEndPoint = value.ToImplementation();
      }

      /// <inheritdoc />
      public ISendPacketsElement[]? SendPacketsElements
      {
         get => Implementation.SendPacketsElements.ToInterface();
         set => Implementation.SendPacketsElements = value.ToNotNullImplementation<ISendPacketsElement, SendPacketsElement>();
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
      public object? UserToken
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

#if NET5_0
      /// <summary>Initialize the SocketAsyncEventArgs</summary>
      /// <param name="unsafeSuppressExecutionContextFlow">
      /// Whether to disable the capturing and flow of ExecutionContext. ExecutionContext flow should only
      /// be disabled if it's going to be handled by higher layers.
      /// </param>
      public SocketAsyncEventArgsAdapter(bool unsafeSuppressExecutionContextFlow)
         : this(new SocketAsyncEventArgs(unsafeSuppressExecutionContextFlow))
      {
      }
#endif

      /// <summary>
      /// Initializes new instance of <see cref="SocketAsyncEventArgsAdapter"/>.
      /// </summary>
      /// <param name="args">Event args to be used by the adapter.</param>
      public SocketAsyncEventArgsAdapter(SocketAsyncEventArgs args)
         : base(args)
      {
         Implementation = args ?? throw new ArgumentNullException(nameof(args));
         _completedLookup = new AbstractionEventHandlerLookup<ISocketAsyncEventArgs, SocketAsyncEventArgs>();
      }

      /// <inheritdoc />
      public void SetBuffer(Memory<byte> buffer)
      {
         Implementation.SetBuffer(buffer);
      }

      /// <inheritdoc />
      public void SetBuffer(byte[]? buffer, int offset, int count)
      {
         Implementation.SetBuffer(buffer, offset, count);
      }

      /// <inheritdoc />
      public void SetBuffer(int offset, int count)
      {
         Implementation.SetBuffer(offset, count);
      }

      /// <inheritdoc />
      public TransmitFileOptions SendPacketsFlags
      {
         get => Implementation.SendPacketsFlags;
         set => Implementation.SendPacketsFlags = value;
      }

      /// <inheritdoc />
      public bool DisconnectReuseSocket
      {
         get => Implementation.DisconnectReuseSocket;
         set => Implementation.DisconnectReuseSocket = value;
      }

      /// <inheritdoc />
      public void Dispose()
      {
         Implementation.Dispose();
      }
   }
}
