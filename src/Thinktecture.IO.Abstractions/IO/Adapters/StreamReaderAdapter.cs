using System;
using System.IO;
using System.Text;

namespace Thinktecture.IO.Adapters
{
	public class StreamReaderAdapter : TextReaderAdapter, IStreamReader
	{
		/// <summary>A <see cref="T:System.IO.StreamReader" /> object around an empty stream.</summary>
		/// <filterpriority>1</filterpriority>
		public new static readonly IStreamReader Null = new StreamReaderAdapter(StreamReader.Null);

		private readonly StreamReader _reader;

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified stream.</summary>
		/// <param name="stream">The stream to be read. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="stream" /> does not support reading. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> is null. </exception>
		public StreamReaderAdapter(IStream stream)
			: this(new StreamReader(stream?.ToImplementation()))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified stream, with the specified byte order mark detection option.</summary>
		/// <param name="stream">The stream to be read. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="stream" /> does not support reading. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> is null. </exception>
		public StreamReaderAdapter(IStream stream, bool detectEncodingFromByteOrderMarks)
			: this(new StreamReader(stream?.ToImplementation(), detectEncodingFromByteOrderMarks))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified stream, with the specified character encoding and byte order mark detection option.</summary>
		/// <param name="stream">The stream to be read. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="stream" /> does not support reading. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> or <paramref name="encoding" /> is null. </exception>
		public StreamReaderAdapter(IStream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks)
			: this(new StreamReader(stream?.ToImplementation(), encoding, detectEncodingFromByteOrderMarks))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified stream, with the specified character encoding, byte order mark detection option, and buffer size.</summary>
		/// <param name="stream">The stream to be read. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param>
		/// <param name="bufferSize">The minimum buffer size. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> or <paramref name="encoding" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="bufferSize" /> is less than or equal to zero. </exception>
		public StreamReaderAdapter(IStream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
			: this(new StreamReader(stream?.ToImplementation(), encoding, detectEncodingFromByteOrderMarks, bufferSize))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.StreamReader" /> class for the specified stream based on the specified character encoding, byte order mark detection option, and buffer size, and optionally leaves the stream open.</summary>
		/// <param name="stream">The stream to read.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="detectEncodingFromByteOrderMarks">true to look for byte order marks at the beginning of the file; otherwise, false.</param>
		/// <param name="bufferSize">The minimum buffer size.</param>
		/// <param name="leaveOpen">true to leave the stream open after the <see cref="T:System.IO.StreamReader" /> object is disposed; otherwise, false.</param>
		public StreamReaderAdapter(IStream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
			: this(new StreamReader(stream?.ToImplementation(), encoding, detectEncodingFromByteOrderMarks, bufferSize, leaveOpen))
		{
		}

		public StreamReaderAdapter(StreamReader reader)
			: base(reader)
		{
			if (reader == null)
				throw new ArgumentNullException(nameof(reader));

			_reader = reader;
		}

		/// <inheritdoc />
		StreamReader IStreamReader.ToImplementation()
		{
			return _reader;
		}

		/// <inheritdoc />
		public IStream BaseStream => _reader.BaseStream.ToInterface();

		/// <inheritdoc />
		public Encoding CurrentEncoding => _reader.CurrentEncoding;

		/// <inheritdoc />
		public bool EndOfStream => _reader.EndOfStream;

		/// <inheritdoc />
		public void DiscardBufferedData()
		{
			_reader.DiscardBufferedData();
		}
	}
}