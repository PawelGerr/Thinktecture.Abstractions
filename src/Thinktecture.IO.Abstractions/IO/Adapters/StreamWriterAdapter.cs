using System;
using System.IO;
using System.Text;

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="StreamWriter"/>.
	/// </summary>
	public class StreamWriterAdapter : TextWriterAdapter, IStreamWriter
	{
		/// <summary>Provides a StreamWriter with no backing store that can be written to, but not read from.</summary>
		/// <filterpriority>1</filterpriority>
		public new static readonly IStreamWriter Null = new StreamWriterAdapter(StreamWriter.Null);

		private readonly StreamWriter _writer;

		/// <summary>Initializes a new instance of the <see cref="StreamWriterAdapter" /> class for the specified stream by using UTF-8 encoding and the default buffer size.</summary>
		/// <param name="stream">The stream to write to. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="stream" /> is not writable. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> is null. </exception>
		public StreamWriterAdapter(IStream stream)
			: this(new StreamWriter(stream?.ToImplementation()))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamWriterAdapter" /> class for the specified stream by using the specified encoding and the default buffer size.</summary>
		/// <param name="stream">The stream to write to. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> or <paramref name="encoding" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="stream" /> is not writable. </exception>
		public StreamWriterAdapter(IStream stream, Encoding encoding)
			: this(new StreamWriter(stream?.ToImplementation(), encoding))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamWriterAdapter" /> class for the specified stream by using the specified encoding and buffer size.</summary>
		/// <param name="stream">The stream to write to. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <param name="bufferSize">The buffer size, in bytes. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> or <paramref name="encoding" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="bufferSize" /> is negative. </exception>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="stream" /> is not writable. </exception>
		public StreamWriterAdapter(IStream stream, Encoding encoding, int bufferSize)
			: this(new StreamWriter(stream?.ToImplementation(), encoding, bufferSize))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamWriterAdapter" /> class for the specified stream by using the specified encoding and buffer size, and optionally leaves the stream open.</summary>
		/// <param name="stream">The stream to write to.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="bufferSize">The buffer size, in bytes.</param>
		/// <param name="leaveOpen">true to leave the stream open after the <see cref="T:System.IO.StreamWriter" /> object is disposed; otherwise, false.</param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> or <paramref name="encoding" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="bufferSize" /> is negative. </exception>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="stream" /> is not writable. </exception>
		public StreamWriterAdapter(IStream stream, Encoding encoding, int bufferSize, bool leaveOpen)
			: this(new StreamWriter(stream?.ToImplementation(), encoding, bufferSize, leaveOpen))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="StreamWriterAdapter" /> class.
		/// </summary>
		/// <param name="writer">Writer to be used by the adapter.</param>
		public StreamWriterAdapter(StreamWriter writer)
			: base(writer)
		{
			if (writer == null)
				throw new ArgumentNullException(nameof(writer));

			_writer = writer;
		}

		/// <inheritdoc />
		StreamWriter IStreamWriter.ToImplementation()
		{
			return _writer;
		}

		/// <inheritdoc />
		public bool AutoFlush
		{
			get { return _writer.AutoFlush; }
			set { _writer.AutoFlush = value; }
		}

		/// <inheritdoc />
		public IStream BaseStream => _writer.BaseStream.ToInterface();
	}
}