using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="Stream"/>.
	/// </summary>
	public class StreamAdapter : AbstractionAdapter<Stream>, IStream
	{
		/// <summary>A Stream with no backing store.</summary>
		[NotNull]
		public static readonly IStream Null = new StreamAdapter(Stream.Null);

		/// <inheritdoc />
		public bool CanRead => Implementation.CanRead;

		/// <inheritdoc />
		public bool CanSeek => Implementation.CanSeek;

		/// <inheritdoc />
		public bool CanTimeout => Implementation.CanTimeout;

		/// <inheritdoc />
		public bool CanWrite => Implementation.CanWrite;

		/// <inheritdoc />
		public long Length => Implementation.Length;

		/// <inheritdoc />
		public long Position
		{
			get => Implementation.Position;
			set => Implementation.Position = value;
		}

		/// <inheritdoc />
		public int ReadTimeout
		{
			get => Implementation.ReadTimeout;
			set => Implementation.ReadTimeout = value;
		}

		/// <inheritdoc />
		public int WriteTimeout
		{
			get => Implementation.WriteTimeout;
			set => Implementation.WriteTimeout = value;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="StreamAdapter" /> class.
		/// </summary>
		/// <param name="stream">Stream to be used by the adapter.</param>
		public StreamAdapter([NotNull] Stream stream)
			: base(stream)
		{
		}

		/// <inheritdoc />
		public void CopyTo(IStream destination)
		{
			Implementation.CopyTo(destination.ToImplementation());
		}

		/// <inheritdoc />
		public void CopyTo(Stream destination)
		{
			Implementation.CopyTo(destination);
		}

		/// <inheritdoc />
		public void CopyTo(IStream destination, int bufferSize)
		{
			Implementation.CopyTo(destination.ToImplementation(), bufferSize);
		}

		/// <inheritdoc />
		public void CopyTo(Stream destination, int bufferSize)
		{
			Implementation.CopyTo(destination, bufferSize);
		}

		/// <inheritdoc />
		public Task CopyToAsync(IStream destination)
		{
			return Implementation.CopyToAsync(destination.ToImplementation());
		}

		/// <inheritdoc />
		public Task CopyToAsync(Stream destination)
		{
			return Implementation.CopyToAsync(destination);
		}

		/// <inheritdoc />
		public Task CopyToAsync(IStream destination, int bufferSize)
		{
			return Implementation.CopyToAsync(destination.ToImplementation(), bufferSize);
		}

		/// <inheritdoc />
		public Task CopyToAsync(Stream destination, int bufferSize)
		{
			return Implementation.CopyToAsync(destination, bufferSize);
		}

		/// <inheritdoc />
		public Task CopyToAsync(IStream destination, int bufferSize, CancellationToken cancellationToken)
		{
			return Implementation.CopyToAsync(destination.ToImplementation(), bufferSize, cancellationToken);
		}

		/// <inheritdoc />
		public Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			return Implementation.CopyToAsync(destination, bufferSize, cancellationToken);
		}

		/// <inheritdoc />
		public void Flush()
		{
			Implementation.Flush();
		}

		/// <inheritdoc />
		public Task FlushAsync()
		{
			return Implementation.FlushAsync();
		}

		/// <inheritdoc />
		public Task FlushAsync(CancellationToken cancellationToken)
		{
			return Implementation.FlushAsync(cancellationToken);
		}

		/// <inheritdoc />
		public int Read(byte[] buffer, int offset, int count)
		{
			return Implementation.Read(buffer, offset, count);
		}

		/// <inheritdoc />
		public Task<int> ReadAsync(byte[] buffer, int offset, int count)
		{
			return Implementation.ReadAsync(buffer, offset, count);
		}

		/// <inheritdoc />
		public Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return Implementation.ReadAsync(buffer, offset, count, cancellationToken);
		}

		/// <inheritdoc />
		public int ReadByte()
		{
			return Implementation.ReadByte();
		}

		/// <inheritdoc />
		public long Seek(long offset, SeekOrigin origin)
		{
			return Implementation.Seek(offset, origin);
		}

		/// <inheritdoc />
		public void SetLength(long value)
		{
			Implementation.SetLength(value);
		}

		/// <inheritdoc />
		public void Write(byte[] buffer, int offset, int count)
		{
			Implementation.Write(buffer, offset, count);
		}

		/// <inheritdoc />
		public Task WriteAsync(byte[] buffer, int offset, int count)
		{
			return Implementation.WriteAsync(buffer, offset, count);
		}

		/// <inheritdoc />
		public Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return Implementation.WriteAsync(buffer, offset, count, cancellationToken);
		}

		/// <inheritdoc />
		public void WriteByte(byte value)
		{
			Implementation.WriteByte(value);
		}

		/// <inheritdoc />
		public void Dispose()
		{
			Implementation.Dispose();
		}
	}
}
