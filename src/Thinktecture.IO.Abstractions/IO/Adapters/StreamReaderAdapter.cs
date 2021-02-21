using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using Thinktecture.Text;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="StreamReader"/>.
	/// </summary>
	public class StreamReaderAdapter : TextReaderAdapter, IStreamReader
	{
		/// <summary>A <see cref="T:System.IO.StreamReader" /> object around an empty stream.</summary>
		public new static readonly IStreamReader Null = new StreamReaderAdapter(StreamReader.Null);

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new StreamReader UnsafeConvert()
		{
			return Implementation;
		}

		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		protected new StreamReader Implementation { get; }

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream.</summary>
		/// <param name="stream">The stream to be read. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="stream" /> does not support reading. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> is null. </exception>
		public StreamReaderAdapter(IStream stream)
			: this(stream.ToImplementation())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream.</summary>
		/// <param name="stream">The stream to be read. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="stream" /> does not support reading. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> is null. </exception>
		public StreamReaderAdapter(Stream stream)
			: this(new StreamReader(stream))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream, with the specified byte order mark detection option.</summary>
		/// <param name="stream">The stream to be read. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="stream" /> does not support reading. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> is null. </exception>
		public StreamReaderAdapter(IStream stream, bool detectEncodingFromByteOrderMarks)
			: this(stream.ToImplementation(), detectEncodingFromByteOrderMarks)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream, with the specified byte order mark detection option.</summary>
		/// <param name="stream">The stream to be read. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="stream" /> does not support reading. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> is null. </exception>
		public StreamReaderAdapter(Stream stream, bool detectEncodingFromByteOrderMarks)
			: this(new StreamReader(stream, detectEncodingFromByteOrderMarks))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream, with the specified character encoding and byte order mark detection option.</summary>
		/// <param name="stream">The stream to be read. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="stream" /> does not support reading. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> or <paramref name="encoding" /> is null. </exception>
		public StreamReaderAdapter(IStream stream, IEncoding encoding, bool detectEncodingFromByteOrderMarks)
			: this(stream.ToImplementation(), encoding.ToImplementation(), detectEncodingFromByteOrderMarks)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream, with the specified character encoding and byte order mark detection option.</summary>
		/// <param name="stream">The stream to be read. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="stream" /> does not support reading. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> or <paramref name="encoding" /> is null. </exception>
		public StreamReaderAdapter(Stream stream, IEncoding encoding, bool detectEncodingFromByteOrderMarks)
			: this(stream, encoding.ToImplementation(), detectEncodingFromByteOrderMarks)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream, with the specified character encoding and byte order mark detection option.</summary>
		/// <param name="stream">The stream to be read. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="stream" /> does not support reading. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> or <paramref name="encoding" /> is null. </exception>
		public StreamReaderAdapter(IStream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks)
			: this(stream.ToImplementation(), encoding, detectEncodingFromByteOrderMarks)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream, with the specified character encoding and byte order mark detection option.</summary>
		/// <param name="stream">The stream to be read. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="stream" /> does not support reading. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> or <paramref name="encoding" /> is null. </exception>
		public StreamReaderAdapter(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks)
			: this(new StreamReader(stream, encoding, detectEncodingFromByteOrderMarks))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream, with the specified character encoding, byte order mark detection option, and buffer size.</summary>
		/// <param name="stream">The stream to be read. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param>
		/// <param name="bufferSize">The minimum buffer size. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> or <paramref name="encoding" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="bufferSize" /> is less than or equal to zero. </exception>
		public StreamReaderAdapter(IStream stream, IEncoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
			: this(stream.ToImplementation(), encoding.ToImplementation(), detectEncodingFromByteOrderMarks, bufferSize)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream, with the specified character encoding, byte order mark detection option, and buffer size.</summary>
		/// <param name="stream">The stream to be read. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param>
		/// <param name="bufferSize">The minimum buffer size. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> or <paramref name="encoding" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="bufferSize" /> is less than or equal to zero. </exception>
		public StreamReaderAdapter(Stream stream, IEncoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
			: this(stream, encoding.ToImplementation(), detectEncodingFromByteOrderMarks, bufferSize)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream, with the specified character encoding, byte order mark detection option, and buffer size.</summary>
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
			: this(stream.ToImplementation(), encoding, detectEncodingFromByteOrderMarks, bufferSize)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream, with the specified character encoding, byte order mark detection option, and buffer size.</summary>
		/// <param name="stream">The stream to be read. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading. </exception>
		/// <exception cref="T:System.ArgumentNullException"> <paramref name="stream" /> or <paramref name="encoding" /> is null. </exception>
		public StreamReaderAdapter(Stream stream, Encoding encoding)
			: this(new StreamReader(stream, encoding))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream, with the specified character encoding, byte order mark detection option, and buffer size.</summary>
		/// <param name="stream">The stream to be read. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading. </exception>
		/// <exception cref="T:System.ArgumentNullException"> <paramref name="stream" /> or <paramref name="encoding" /> is null. </exception>
		public StreamReaderAdapter(Stream stream, IEncoding encoding)
			: this(new StreamReader(stream, encoding.ToImplementation()))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream, with the specified character encoding, byte order mark detection option, and buffer size.</summary>
		/// <param name="stream">The stream to be read. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> or <paramref name="encoding" /> is null. </exception>
		public StreamReaderAdapter(IStream stream, Encoding encoding)
			: this(new StreamReader(stream.ToImplementation(), encoding))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream, with the specified character encoding, byte order mark detection option, and buffer size.</summary>
		/// <param name="stream">The stream to be read. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> or <paramref name="encoding" /> is null. </exception>
		public StreamReaderAdapter(IStream stream, IEncoding encoding)
			: this(new StreamReader(stream.ToImplementation(), encoding.ToImplementation()))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream, with the specified character encoding, byte order mark detection option, and buffer size.</summary>
		/// <param name="path">The file path to be read. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading. </exception>
		public StreamReaderAdapter(string path)
			: this(new StreamReader(path))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream, with the specified character encoding, byte order mark detection option, and buffer size.</summary>
		/// <param name="path">The file path to be read. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading. </exception>
		public StreamReaderAdapter(string path, bool detectEncodingFromByteOrderMarks)
			: this(new StreamReader(path, detectEncodingFromByteOrderMarks))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream, with the specified character encoding, byte order mark detection option, and buffer size.</summary>
		/// <param name="path">The file path to be read. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading. </exception>
		public StreamReaderAdapter(string path, Encoding encoding)
			: this(new StreamReader(path, encoding))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream, with the specified character encoding, byte order mark detection option, and buffer size.</summary>
		/// <param name="path">The file path to be read. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading. </exception>
		public StreamReaderAdapter(string path, IEncoding encoding)
			: this(new StreamReader(path, encoding.ToImplementation()))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream, with the specified character encoding, byte order mark detection option, and buffer size.</summary>
		/// <param name="path">The file path to be read. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading. </exception>
		public StreamReaderAdapter(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks)
			: this(new StreamReader(path, encoding, detectEncodingFromByteOrderMarks))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream, with the specified character encoding, byte order mark detection option, and buffer size.</summary>
		/// <param name="path">The file path to be read. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading. </exception>
		public StreamReaderAdapter(string path, IEncoding encoding, bool detectEncodingFromByteOrderMarks)
			: this(new StreamReader(path, encoding.ToImplementation(), detectEncodingFromByteOrderMarks))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream, with the specified character encoding, byte order mark detection option, and buffer size.</summary>
		/// <param name="path">The file path to be read. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param>
		/// <param name="bufferSize">The minimum buffer size. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading. </exception>
		public StreamReaderAdapter(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
			: this(new StreamReader(path, encoding, detectEncodingFromByteOrderMarks, bufferSize))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream, with the specified character encoding, byte order mark detection option, and buffer size.</summary>
		/// <param name="path">The file path to be read. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param>
		/// <param name="bufferSize">The minimum buffer size. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading. </exception>
		public StreamReaderAdapter(string path, IEncoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
			: this(new StreamReader(path, encoding.ToImplementation(), detectEncodingFromByteOrderMarks, bufferSize))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream, with the specified character encoding, byte order mark detection option, and buffer size.</summary>
		/// <param name="stream">The stream to be read. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <param name="detectEncodingFromByteOrderMarks">Indicates whether to look for byte order marks at the beginning of the file. </param>
		/// <param name="bufferSize">The minimum buffer size. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> or <paramref name="encoding" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="bufferSize" /> is less than or equal to zero. </exception>
		public StreamReaderAdapter(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
			: this(new StreamReader(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream based on the specified character encoding, byte order mark detection option, and buffer size, and optionally leaves the stream open.</summary>
		/// <param name="stream">The stream to read.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="detectEncodingFromByteOrderMarks">true to look for byte order marks at the beginning of the file; otherwise, false.</param>
		/// <param name="bufferSize">The minimum buffer size.</param>
		/// <param name="leaveOpen">true to leave the stream open after the <see cref="T:System.IO.StreamReader" /> object is disposed; otherwise, false.</param>
		public StreamReaderAdapter(IStream stream, IEncoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
			: this(stream.ToImplementation(), encoding.ToImplementation(), detectEncodingFromByteOrderMarks, bufferSize, leaveOpen)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream based on the specified character encoding, byte order mark detection option, and buffer size, and optionally leaves the stream open.</summary>
		/// <param name="stream">The stream to read.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="detectEncodingFromByteOrderMarks">true to look for byte order marks at the beginning of the file; otherwise, false.</param>
		/// <param name="bufferSize">The minimum buffer size.</param>
		/// <param name="leaveOpen">true to leave the stream open after the <see cref="T:System.IO.StreamReader" /> object is disposed; otherwise, false.</param>
		public StreamReaderAdapter(Stream stream, IEncoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
			: this(stream, encoding.ToImplementation(), detectEncodingFromByteOrderMarks, bufferSize, leaveOpen)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream based on the specified character encoding, byte order mark detection option, and buffer size, and optionally leaves the stream open.</summary>
		/// <param name="stream">The stream to read.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="detectEncodingFromByteOrderMarks">true to look for byte order marks at the beginning of the file; otherwise, false.</param>
		/// <param name="bufferSize">The minimum buffer size.</param>
		/// <param name="leaveOpen">true to leave the stream open after the <see cref="T:System.IO.StreamReader" /> object is disposed; otherwise, false.</param>
		public StreamReaderAdapter(IStream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
			: this(stream.ToImplementation(), encoding, detectEncodingFromByteOrderMarks, bufferSize, leaveOpen)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamReaderAdapter" /> class for the specified stream based on the specified character encoding, byte order mark detection option, and buffer size, and optionally leaves the stream open.</summary>
		/// <param name="stream">The stream to read.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="detectEncodingFromByteOrderMarks">true to look for byte order marks at the beginning of the file; otherwise, false.</param>
		/// <param name="bufferSize">The minimum buffer size.</param>
		/// <param name="leaveOpen">true to leave the stream open after the <see cref="T:System.IO.StreamReader" /> object is disposed; otherwise, false.</param>
		public StreamReaderAdapter(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
			: this(new StreamReader(stream, encoding, detectEncodingFromByteOrderMarks, bufferSize, leaveOpen))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="StreamReaderAdapter" /> class.
		/// </summary>
		/// <param name="reader">Reader to be used by the adapter.</param>
		public StreamReaderAdapter(StreamReader reader)
			: base(reader)
		{
			Implementation = reader ?? throw new ArgumentNullException(nameof(reader));
		}

		/// <inheritdoc />
		public IStream BaseStream => Implementation.BaseStream.ToInterface();

		/// <inheritdoc />
		public IEncoding CurrentEncoding => Implementation.CurrentEncoding.ToInterface();

		/// <inheritdoc />
		public bool EndOfStream => Implementation.EndOfStream;

		/// <inheritdoc />
		public void DiscardBufferedData()
		{
			Implementation.DiscardBufferedData();
		}
	}
}
