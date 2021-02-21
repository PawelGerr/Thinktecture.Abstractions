using System.IO;
using System.Net.Sockets;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.Sockets.Adapters
{
   /// <summary>
   /// Represents an element in a SendPacketsElement array.
   /// </summary>
   public class SendPacketsElementAdapter : AbstractionAdapter<SendPacketsElement>, ISendPacketsElement
   {
#if NETCOREAPP || NET5_0
      /// <inheritdoc />
      public FileStream? FileStream => Implementation.FileStream;

      /// <inheritdoc />
      public long OffsetLong => Implementation.OffsetLong;
#endif

      /// <inheritdoc />
      public byte[]? Buffer => Implementation.Buffer;

      /// <inheritdoc />
      public int Count => Implementation.Count;

      /// <inheritdoc />
      public bool EndOfPacket => Implementation.EndOfPacket;

      /// <inheritdoc />
      public string? FilePath => Implementation.FilePath;

      /// <inheritdoc />
      public int Offset => Implementation.Offset;

      /// <summary>
      /// Initializes a new instance of the SendPacketsElement class using the specified buffer.
      /// </summary>
      /// <param name="buffer">A byte array of data to send using the Socket.SendPacketsAsync method.</param>
      public SendPacketsElementAdapter(byte[] buffer)
         : this(new SendPacketsElement(buffer))
      {
      }

      /// <summary>
      /// Initializes a new instance of the SendPacketsElement class using the specified buffer, buffer offset, and count.
      /// </summary>
      /// <param name="buffer">A byte array of data to send using the Socket.SendPacketsAsync method.</param>
      /// <param name="offset">The offset, in bytes, from the beginning of the buffer to the location in the buffer to start sending the data specified in the buffer parameter.</param>
      /// <param name="count">The number of bytes to send starting from the offset parameter. If count is zero, no bytes are sent.</param>
      public SendPacketsElementAdapter(byte[] buffer, int offset, int count)
         : this(new SendPacketsElement(buffer, offset, count))
      {
      }

      /// <summary>
      /// Initializes a new instance of the SendPacketsElement class using the specified buffer, buffer offset, and count with an option to combine this element with the next element in a single send request from the sockets layer to the transport.
      /// </summary>
      /// <param name="buffer">A byte array of data to send using the Socket.SendPacketsAsync method.</param>
      /// <param name="offset">The offset, in bytes, from the beginning of the buffer to the location in the buffer to start sending the data specified in the buffer parameter.</param>
      /// <param name="count">The number bytes to send starting from the offset parameter. If count is zero, no bytes are sent.</param>
      /// <param name="endOfPacket">A Boolean value that specifies that this element should not be combined with the next element in a single send request from the sockets layer to the transport. This flag is used for granular control of the content of each message on a datagram or message-oriented socket.</param>
      public SendPacketsElementAdapter(byte[] buffer, int offset, int count, bool endOfPacket)
         : this(new SendPacketsElement(buffer, offset, count, endOfPacket))
      {
      }

      /// <summary>
      /// Initializes a new instance of the SendPacketsElement class using the specified file.
      /// </summary>
      /// <param name="filepath">The filename of the file to be transmitted using the Socket.SendPacketsAsync method.</param>
      public SendPacketsElementAdapter(string filepath)
         : this(new SendPacketsElement(filepath))
      {
      }

      /// <summary>
      /// Initializes a new instance of the SendPacketsElement class using the specified filename path, offset, and count.
      /// </summary>
      /// <param name="filepath">The filename of the file to be transmitted using the Socket.SendPacketsAsync method.</param>
      /// <param name="offset">The offset, in bytes, from the beginning of the file to the location in the file to start sending the file specified in the filepath parameter.</param>
      /// <param name="count">The number of bytes to send starting from the offset parameter. If count is zero, the entire file is sent.</param>
      public SendPacketsElementAdapter(string filepath, int offset, int count)
         : this(new SendPacketsElement(filepath, offset, count))
      {
      }

      /// <summary>
      /// Initializes a new instance of the SendPacketsElement class using the specified filename path, buffer offset, and count with an option to combine this element with the next element in a single send request from the sockets layer to the transport.
      /// </summary>
      /// <param name="filepath">The filename of the file to be transmitted using the Socket.SendPacketsAsync method.</param>
      /// <param name="offset">The offset, in bytes, from the beginning of the file to the location in the file to start sending the file specified in the filepath parameter.</param>
      /// <param name="count">The number of bytes to send starting from the offset parameter. If count is zero, the entire file is sent.</param>
      /// <param name="endOfPacket">A Boolean value that specifies that this element should not be combined with the next element in a single send request from the sockets layer to the transport. This flag is used for granular control of the content of each message on a datagram or message-oriented socket.</param>
      public SendPacketsElementAdapter(string filepath, int offset, int count, bool endOfPacket)
         : this(new SendPacketsElement(filepath, offset, count, endOfPacket))
      {
      }

#if NETCOREAPP || NET5_0
      /// <summary>
      /// Initializes a new instance of the SendPacketsElement class using the specified filename path, buffer offset, and count with an option to combine this element with the next element in a single send request from the sockets layer to the transport.
      /// </summary>
      /// <param name="filepath">The filename of the file to be transmitted using the Socket.SendPacketsAsync method.</param>
      /// <param name="offset">The offset, in bytes, from the beginning of the file to the location in the file to start sending the file specified in the filepath parameter.</param>
      /// <param name="count">The number of bytes to send starting from the offset parameter. If count is zero, the entire file is sent.</param>
      public SendPacketsElementAdapter(string filepath, long offset, int count)
         : this(new SendPacketsElement(filepath, offset, count))
      {
      }

      /// <summary>
      /// Initializes a new instance of the SendPacketsElement class using the specified filename path, buffer offset, and count with an option to combine this element with the next element in a single send request from the sockets layer to the transport.
      /// </summary>
      /// <param name="filepath">The filename of the file to be transmitted using the Socket.SendPacketsAsync method.</param>
      /// <param name="offset">The offset, in bytes, from the beginning of the file to the location in the file to start sending the file specified in the filepath parameter.</param>
      /// <param name="count">The number of bytes to send starting from the offset parameter. If count is zero, the entire file is sent.</param>
      /// <param name="endOfPacket">A Boolean value that specifies that this element should not be combined with the next element in a single send request from the sockets layer to the transport. This flag is used for granular control of the content of each message on a datagram or message-oriented socket.</param>
      public SendPacketsElementAdapter(string filepath, long offset, int count, bool endOfPacket)
         : this(new SendPacketsElement(filepath, offset, count, endOfPacket))
      {
      }

      /// <summary>
      /// Initializes a new instance of the SendPacketsElement class using the specified file stream.
      /// </summary>
      /// <param name="fileStream">The file to be transmitted using the Socket.SendPacketsAsync method.</param>
      public SendPacketsElementAdapter(FileStream fileStream)
         : this(new SendPacketsElement(fileStream))
      {
      }

      /// <summary>
      /// Initializes a new instance of the SendPacketsElement class using the specified file stream.
      /// </summary>
      /// <param name="fileStream">The file to be transmitted using the Socket.SendPacketsAsync method.</param>
      /// <param name="offset">The offset, in bytes, from the beginning of the file to the location in the file to start sending the file specified in the filepath parameter.</param>
      /// <param name="count">The number of bytes to send starting from the offset parameter. If count is zero, the entire file is sent.</param>
      public SendPacketsElementAdapter(FileStream fileStream, long offset, int count)
         : this(new SendPacketsElement(fileStream, offset, count))
      {
      }

      /// <summary>
      /// Initializes a new instance of the SendPacketsElement class using the specified file stream.
      /// </summary>
      /// <param name="fileStream">The file to be transmitted using the Socket.SendPacketsAsync method.</param>
      /// <param name="offset">The offset, in bytes, from the beginning of the file to the location in the file to start sending the file specified in the filepath parameter.</param>
      /// <param name="count">The number of bytes to send starting from the offset parameter. If count is zero, the entire file is sent.</param>
      /// <param name="endOfPacket">A Boolean value that specifies that this element should not be combined with the next element in a single send request from the sockets layer to the transport. This flag is used for granular control of the content of each message on a datagram or message-oriented socket.</param>
      public SendPacketsElementAdapter(FileStream fileStream, long offset, int count, bool endOfPacket)
         : this(new SendPacketsElement(fileStream, offset, count, endOfPacket))
      {
      }
#endif

      /// <summary>
      /// Initializes new instance of <see cref="SendPacketsElementAdapter"/>.
      /// </summary>
      /// <param name="element">Element to be used by the adapter.</param>
      public SendPacketsElementAdapter(SendPacketsElement element)
         : base(element)
      {
      }
   }
}
