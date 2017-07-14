using System;
using System.ComponentModel;
using System.Net.Sockets;

namespace Thinktecture.Net.Sockets.Adapters
{
	/// <summary>
	/// Represents an element in a SendPacketsElement array.
	/// </summary>
	public class SendPacketsElementAdapter : AbstractionAdapter, ISendPacketsElement
	{
		private readonly SendPacketsElement _element;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new SendPacketsElement UnsafeConvert()
		{
			return _element;
		}

		/// <inheritdoc />
		public byte[] Buffer => _element.Buffer;

		/// <inheritdoc />
		public int Count => _element.Count;

		/// <inheritdoc />
		public bool EndOfPacket => _element.EndOfPacket;

		/// <inheritdoc />
		public string FilePath => _element.FilePath;

		/// <inheritdoc />
		public int Offset => _element.Offset;

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

		/// <summary>
		/// Initializes new instance of <see cref="SendPacketsElementAdapter"/>.
		/// </summary>
		/// <param name="element">Element to be used by the adapter.</param>
		public SendPacketsElementAdapter(SendPacketsElement element)
			: base(element)
		{
			_element = element ?? throw new ArgumentNullException(nameof(element));
		}
	}
}