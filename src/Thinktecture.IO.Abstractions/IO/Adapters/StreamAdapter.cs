using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="Stream"/>.
	/// </summary>
	public class StreamAdapter : IStream
	{
		/// <summary>A Stream with no backing store.</summary>
		/// <filterpriority>1</filterpriority>
		public static readonly IStream Null = new StreamAdapter(Stream.Null);

		private readonly Stream _stream;

		/// <inheritdoc />
		public bool CanRead => _stream.CanRead;

		/// <inheritdoc />
		public bool CanSeek => _stream.CanSeek;

		/// <inheritdoc />
		public bool CanTimeout => _stream.CanTimeout;

		/// <inheritdoc />
		public bool CanWrite => _stream.CanWrite;

		/// <inheritdoc />
		public long Length => _stream.Length;

		/// <inheritdoc />
		public long Position
		{
			get { return _stream.Position; }
			set { _stream.Position = value; }
		}

		/// <inheritdoc />
		public int ReadTimeout
		{
			get { return _stream.ReadTimeout; }
			set { _stream.ReadTimeout = value; }
		}

		/// <inheritdoc />
		public int WriteTimeout
		{
			get { return _stream.WriteTimeout; }
			set { _stream.WriteTimeout = value; }
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="StreamAdapter" /> class.
		/// </summary>
		/// <param name="stream">Stream to be used by the adapter.</param>
		public StreamAdapter(Stream stream)
		{
			if (stream == null)
				throw new ArgumentNullException(nameof(stream));

			_stream = stream;
		}

		/// <inheritdoc />
		public Stream ToImplementation()
		{
			return _stream;
		}

		/// <inheritdoc />
		public void CopyTo(IStream destination)
		{
			_stream.CopyTo(destination.ToImplementation());
		}

		/// <inheritdoc />
		public void CopyTo(Stream destination)
		{
			_stream.CopyTo(destination);
		}

		/// <inheritdoc />
		public void CopyTo(IStream destination, int bufferSize)
		{
			_stream.CopyTo(destination.ToImplementation(), bufferSize);
		}

		/// <inheritdoc />
		public void CopyTo(Stream destination, int bufferSize)
		{
			_stream.CopyTo(destination, bufferSize);
		}

		/// <inheritdoc />
		public Task CopyToAsync(IStream destination)
		{
			return _stream.CopyToAsync(destination.ToImplementation());
		}

		/// <inheritdoc />
		public Task CopyToAsync(Stream destination)
		{
			return _stream.CopyToAsync(destination);
		}

		/// <inheritdoc />
		public Task CopyToAsync(IStream destination, int bufferSize)
		{
			return _stream.CopyToAsync(destination.ToImplementation(), bufferSize);
		}

		/// <inheritdoc />
		public Task CopyToAsync(Stream destination, int bufferSize)
		{
			return _stream.CopyToAsync(destination, bufferSize);
		}

		/// <inheritdoc />
		public Task CopyToAsync(IStream destination, int bufferSize, CancellationToken cancellationToken)
		{
			return _stream.CopyToAsync(destination.ToImplementation(), bufferSize, cancellationToken);
		}

		/// <inheritdoc />
		public Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			return _stream.CopyToAsync(destination, bufferSize, cancellationToken);
		}

		/// <inheritdoc />
		public void Flush()
		{
			_stream.Flush();
		}

		/// <inheritdoc />
		public Task FlushAsync()
		{
			return _stream.FlushAsync();
		}

		/// <inheritdoc />
		public Task FlushAsync(CancellationToken cancellationToken)
		{
			return _stream.FlushAsync(cancellationToken);
		}

		/// <inheritdoc />
		public int Read(byte[] buffer, int offset, int count)
		{
			return _stream.Read(buffer, offset, count);
		}

		/// <inheritdoc />
		public Task<int> ReadAsync(byte[] buffer, int offset, int count)
		{
			return _stream.ReadAsync(buffer, offset, count);
		}

		/// <inheritdoc />
		public Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return _stream.ReadAsync(buffer, offset, count, cancellationToken);
		}

		/// <inheritdoc />
		public int ReadByte()
		{
			return _stream.ReadByte();
		}

		/// <inheritdoc />
		public long Seek(long offset, SeekOrigin origin)
		{
			return _stream.Seek(offset, origin);
		}

		/// <inheritdoc />
		public void SetLength(long value)
		{
			_stream.SetLength(value);
		}

		/// <inheritdoc />
		public void Write(byte[] buffer, int offset, int count)
		{
			_stream.Write(buffer, offset, count);
		}

		/// <inheritdoc />
		public Task WriteAsync(byte[] buffer, int offset, int count)
		{
			return _stream.WriteAsync(buffer, offset, count);
		}

		/// <inheritdoc />
		public Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return _stream.WriteAsync(buffer, offset, count, cancellationToken);
		}

		/// <inheritdoc />
		public void WriteByte(byte value)
		{
			_stream.WriteByte(value);
		}

		/// <inheritdoc />
		public void Dispose()
		{
			_stream.Dispose();
		}
	}
}