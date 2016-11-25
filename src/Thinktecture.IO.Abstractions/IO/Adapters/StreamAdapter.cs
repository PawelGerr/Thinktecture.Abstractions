using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="Stream"/>.
	/// </summary>
	public class StreamAdapter : AbstractionAdapter, IStream
	{
		/// <summary>A Stream with no backing store.</summary>
		/// <filterpriority>1</filterpriority>
		public static readonly IStream Null = new StreamAdapter(Stream.Null);

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new Stream UnsafeConvert()
		{
			return _instance;
		}

		private readonly Stream _instance;

		/// <inheritdoc />
		public bool CanRead => _instance.CanRead;

		/// <inheritdoc />
		public bool CanSeek => _instance.CanSeek;

		/// <inheritdoc />
		public bool CanTimeout => _instance.CanTimeout;

		/// <inheritdoc />
		public bool CanWrite => _instance.CanWrite;

		/// <inheritdoc />
		public long Length => _instance.Length;

		/// <inheritdoc />
		public long Position
		{
			get { return _instance.Position; }
			set { _instance.Position = value; }
		}

		/// <inheritdoc />
		public int ReadTimeout
		{
			get { return _instance.ReadTimeout; }
			set { _instance.ReadTimeout = value; }
		}

		/// <inheritdoc />
		public int WriteTimeout
		{
			get { return _instance.WriteTimeout; }
			set { _instance.WriteTimeout = value; }
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="StreamAdapter" /> class.
		/// </summary>
		/// <param name="stream">Stream to be used by the adapter.</param>
		public StreamAdapter(Stream stream)
			: base(stream)
		{
			if (stream == null)
				throw new ArgumentNullException(nameof(stream));

			_instance = stream;
		}

		/// <inheritdoc />
		public void CopyTo(IStream destination)
		{
			_instance.CopyTo(destination.ToImplementation());
		}

		/// <inheritdoc />
		public void CopyTo(Stream destination)
		{
			_instance.CopyTo(destination);
		}

		/// <inheritdoc />
		public void CopyTo(IStream destination, int bufferSize)
		{
			_instance.CopyTo(destination.ToImplementation(), bufferSize);
		}

		/// <inheritdoc />
		public void CopyTo(Stream destination, int bufferSize)
		{
			_instance.CopyTo(destination, bufferSize);
		}

		/// <inheritdoc />
		public Task CopyToAsync(IStream destination)
		{
			return _instance.CopyToAsync(destination.ToImplementation());
		}

		/// <inheritdoc />
		public Task CopyToAsync(Stream destination)
		{
			return _instance.CopyToAsync(destination);
		}

		/// <inheritdoc />
		public Task CopyToAsync(IStream destination, int bufferSize)
		{
			return _instance.CopyToAsync(destination.ToImplementation(), bufferSize);
		}

		/// <inheritdoc />
		public Task CopyToAsync(Stream destination, int bufferSize)
		{
			return _instance.CopyToAsync(destination, bufferSize);
		}

		/// <inheritdoc />
		public Task CopyToAsync(IStream destination, int bufferSize, CancellationToken cancellationToken)
		{
			return _instance.CopyToAsync(destination.ToImplementation(), bufferSize, cancellationToken);
		}

		/// <inheritdoc />
		public Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			return _instance.CopyToAsync(destination, bufferSize, cancellationToken);
		}

		/// <inheritdoc />
		public void Flush()
		{
			_instance.Flush();
		}

		/// <inheritdoc />
		public Task FlushAsync()
		{
			return _instance.FlushAsync();
		}

		/// <inheritdoc />
		public Task FlushAsync(CancellationToken cancellationToken)
		{
			return _instance.FlushAsync(cancellationToken);
		}

		/// <inheritdoc />
		public int Read(byte[] buffer, int offset, int count)
		{
			return _instance.Read(buffer, offset, count);
		}

		/// <inheritdoc />
		public Task<int> ReadAsync(byte[] buffer, int offset, int count)
		{
			return _instance.ReadAsync(buffer, offset, count);
		}

		/// <inheritdoc />
		public Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return _instance.ReadAsync(buffer, offset, count, cancellationToken);
		}

		/// <inheritdoc />
		public int ReadByte()
		{
			return _instance.ReadByte();
		}

		/// <inheritdoc />
		public long Seek(long offset, SeekOrigin origin)
		{
			return _instance.Seek(offset, origin);
		}

		/// <inheritdoc />
		public void SetLength(long value)
		{
			_instance.SetLength(value);
		}

		/// <inheritdoc />
		public void Write(byte[] buffer, int offset, int count)
		{
			_instance.Write(buffer, offset, count);
		}

		/// <inheritdoc />
		public Task WriteAsync(byte[] buffer, int offset, int count)
		{
			return _instance.WriteAsync(buffer, offset, count);
		}

		/// <inheritdoc />
		public Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return _instance.WriteAsync(buffer, offset, count, cancellationToken);
		}

		/// <inheritdoc />
		public void WriteByte(byte value)
		{
			_instance.WriteByte(value);
		}

		/// <inheritdoc />
		public void Dispose()
		{
			_instance.Dispose();
		}
	}
}