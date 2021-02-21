using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using Thinktecture.Text;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="StreamWriter"/>.
	/// </summary>
	public class StreamWriterAdapter : TextWriterAdapter, IStreamWriter
	{
		/// <summary>Provides a StreamWriter with no backing store that can be written to, but not read from.</summary>
		public new static readonly IStreamWriter Null = new StreamWriterAdapter(StreamWriter.Null);

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new StreamWriter UnsafeConvert()
		{
			return Implementation;
		}

		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		protected new StreamWriter Implementation { get; }

		/// <summary>Initializes a new instance of the <see cref="StreamWriterAdapter" /> class for the specified stream by using UTF-8 encoding and the default buffer size.</summary>
		/// <param name="stream">The stream to write to. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="stream" /> is not writable. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> is null. </exception>
		public StreamWriterAdapter(IStream stream)
			: this(stream.ToImplementation())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamWriterAdapter" /> class for the specified stream by using UTF-8 encoding and the default buffer size.</summary>
		/// <param name="stream">The stream to write to. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="stream" /> is not writable. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> is null. </exception>
		public StreamWriterAdapter(Stream stream)
			: this(new StreamWriter(stream))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamWriterAdapter" /> class for the specified stream by using the specified encoding and the default buffer size.</summary>
		/// <param name="stream">The stream to write to. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> or <paramref name="encoding" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="stream" /> is not writable. </exception>
		public StreamWriterAdapter(IStream stream, IEncoding encoding)
			: this(stream.ToImplementation(), encoding.ToImplementation())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamWriterAdapter" /> class for the specified stream by using the specified encoding and the default buffer size.</summary>
		/// <param name="stream">The stream to write to. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> or <paramref name="encoding" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="stream" /> is not writable. </exception>
		public StreamWriterAdapter(Stream stream, IEncoding encoding)
			: this(stream, encoding.ToImplementation())
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
			: this(stream.ToImplementation(), encoding)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamWriterAdapter" /> class for the specified stream by using the specified encoding and the default buffer size.</summary>
		/// <param name="stream">The stream to write to. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> or <paramref name="encoding" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="stream" /> is not writable. </exception>
		public StreamWriterAdapter(Stream stream, Encoding encoding)
			: this(new StreamWriter(stream, encoding))
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
		public StreamWriterAdapter(IStream stream, IEncoding encoding, int bufferSize)
			: this(stream.ToImplementation(), encoding.ToImplementation(), bufferSize)
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
		public StreamWriterAdapter(Stream stream, IEncoding encoding, int bufferSize)
			: this(stream, encoding.ToImplementation(), bufferSize)
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
			: this(stream.ToImplementation(), encoding, bufferSize)
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
		public StreamWriterAdapter(Stream stream, Encoding encoding, int bufferSize)
			: this(new StreamWriter(stream, encoding, bufferSize))
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
		public StreamWriterAdapter(IStream stream, IEncoding encoding, int bufferSize, bool leaveOpen)
			: this(stream.ToImplementation(), encoding.ToImplementation(), bufferSize, leaveOpen)
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
		public StreamWriterAdapter(Stream stream, IEncoding encoding, int bufferSize, bool leaveOpen)
			: this(stream, encoding.ToImplementation(), bufferSize, leaveOpen)
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
			: this(stream.ToImplementation(), encoding, bufferSize, leaveOpen)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamWriterAdapter" /> class for the specified stream by using the specified encoding and buffer size, and optionally leaves the stream open.</summary>
		/// <param name="path">The file path to write to.</param>
		/// <exception cref="T:System.ArgumentNullException"> <paramref name="path" /> is null. </exception>
		public StreamWriterAdapter(string path)
			: this(new StreamWriter(path))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamWriterAdapter" /> class for the specified stream by using the specified encoding and buffer size, and optionally leaves the stream open.</summary>
		/// <param name="path">The file path to write to.</param>
		/// <param name="append">Indication whether the content should be appended to file.</param>
		/// <exception cref="T:System.ArgumentNullException"> <paramref name="path" /> is null. </exception>
		public StreamWriterAdapter(string path, bool append)
			: this(new StreamWriter(path, append))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamWriterAdapter" /> class for the specified stream by using the specified encoding and buffer size, and optionally leaves the stream open.</summary>
		/// <param name="path">The file path to write to.</param>
		/// <param name="append">Indication whether the content should be appended to file.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <exception cref="T:System.ArgumentNullException"> <paramref name="path" /> is null. </exception>
		public StreamWriterAdapter(string path, bool append, Encoding encoding)
			: this(new StreamWriter(path, append, encoding))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamWriterAdapter" /> class for the specified stream by using the specified encoding and buffer size, and optionally leaves the stream open.</summary>
		/// <param name="path">The file path to write to.</param>
		/// <param name="append">Indication whether the content should be appended to file.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <exception cref="T:System.ArgumentNullException"> <paramref name="path" /> is null. </exception>
		public StreamWriterAdapter(string path, bool append, IEncoding encoding)
			: this(new StreamWriter(path, append, encoding.ToImplementation()))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamWriterAdapter" /> class for the specified stream by using the specified encoding and buffer size, and optionally leaves the stream open.</summary>
		/// <param name="path">The file path to write to.</param>
		/// <param name="append">Indication whether the content should be appended to file.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="bufferSize">The buffer size, in bytes.</param>
		/// <exception cref="T:System.ArgumentNullException"> <paramref name="path" /> is null. </exception>
		public StreamWriterAdapter(string path, bool append, Encoding encoding, int bufferSize)
			: this(new StreamWriter(path, append, encoding, bufferSize))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StreamWriterAdapter" /> class for the specified stream by using the specified encoding and buffer size, and optionally leaves the stream open.</summary>
		/// <param name="path">The file path to write to.</param>
		/// <param name="append">Indication whether the content should be appended to file.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="bufferSize">The buffer size, in bytes.</param>
		/// <exception cref="T:System.ArgumentNullException"> <paramref name="path" /> is null. </exception>
		public StreamWriterAdapter(string path, bool append, IEncoding encoding, int bufferSize)
			: this(new StreamWriter(path, append, encoding.ToImplementation(), bufferSize))
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
		public StreamWriterAdapter(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen)
			: this(new StreamWriter(stream, encoding, bufferSize, leaveOpen))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="StreamWriterAdapter" /> class.
		/// </summary>
		/// <param name="writer">Writer to be used by the adapter.</param>
		public StreamWriterAdapter(StreamWriter writer)
			: base(writer)
		{
			Implementation = writer ?? throw new ArgumentNullException(nameof(writer));
		}

		/// <inheritdoc />
		public bool AutoFlush
		{
			get => Implementation.AutoFlush;
			set => Implementation.AutoFlush = value;
		}

		/// <inheritdoc />
		public IStream BaseStream => Implementation.BaseStream.ToInterface();
	}
}
