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
	public class StreamAdapter : IStream
	{
		/// <summary>A Stream with no backing store.</summary>
		/// <filterpriority>1</filterpriority>
		public static readonly IStream Null = new StreamAdapter(Stream.Null);

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Stream InternalInstance { get; }

		/// <inheritdoc />
		public bool CanRead => InternalInstance.CanRead;

		/// <inheritdoc />
		public bool CanSeek => InternalInstance.CanSeek;

		/// <inheritdoc />
		public bool CanTimeout => InternalInstance.CanTimeout;

		/// <inheritdoc />
		public bool CanWrite => InternalInstance.CanWrite;

		/// <inheritdoc />
		public long Length => InternalInstance.Length;

		/// <inheritdoc />
		public long Position
		{
			get { return InternalInstance.Position; }
			set { InternalInstance.Position = value; }
		}

		/// <inheritdoc />
		public int ReadTimeout
		{
			get { return InternalInstance.ReadTimeout; }
			set { InternalInstance.ReadTimeout = value; }
		}

		/// <inheritdoc />
		public int WriteTimeout
		{
			get { return InternalInstance.WriteTimeout; }
			set { InternalInstance.WriteTimeout = value; }
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="StreamAdapter" /> class.
		/// </summary>
		/// <param name="stream">Stream to be used by the adapter.</param>
		public StreamAdapter(Stream stream)
		{
			if (stream == null)
				throw new ArgumentNullException(nameof(stream));

			InternalInstance = stream;
		}

		/// <inheritdoc />
		public void CopyTo(IStream destination)
		{
			InternalInstance.CopyTo(destination.ToImplementation());
		}

		/// <inheritdoc />
		public void CopyTo(Stream destination)
		{
			InternalInstance.CopyTo(destination);
		}

		/// <inheritdoc />
		public void CopyTo(IStream destination, int bufferSize)
		{
			InternalInstance.CopyTo(destination.ToImplementation(), bufferSize);
		}

		/// <inheritdoc />
		public void CopyTo(Stream destination, int bufferSize)
		{
			InternalInstance.CopyTo(destination, bufferSize);
		}

		/// <inheritdoc />
		public Task CopyToAsync(IStream destination)
		{
			return InternalInstance.CopyToAsync(destination.ToImplementation());
		}

		/// <inheritdoc />
		public Task CopyToAsync(Stream destination)
		{
			return InternalInstance.CopyToAsync(destination);
		}

		/// <inheritdoc />
		public Task CopyToAsync(IStream destination, int bufferSize)
		{
			return InternalInstance.CopyToAsync(destination.ToImplementation(), bufferSize);
		}

		/// <inheritdoc />
		public Task CopyToAsync(Stream destination, int bufferSize)
		{
			return InternalInstance.CopyToAsync(destination, bufferSize);
		}

		/// <inheritdoc />
		public Task CopyToAsync(IStream destination, int bufferSize, CancellationToken cancellationToken)
		{
			return InternalInstance.CopyToAsync(destination.ToImplementation(), bufferSize, cancellationToken);
		}

		/// <inheritdoc />
		public Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			return InternalInstance.CopyToAsync(destination, bufferSize, cancellationToken);
		}

		/// <inheritdoc />
		public void Flush()
		{
			InternalInstance.Flush();
		}

		/// <inheritdoc />
		public Task FlushAsync()
		{
			return InternalInstance.FlushAsync();
		}

		/// <inheritdoc />
		public Task FlushAsync(CancellationToken cancellationToken)
		{
			return InternalInstance.FlushAsync(cancellationToken);
		}

		/// <inheritdoc />
		public int Read(byte[] buffer, int offset, int count)
		{
			return InternalInstance.Read(buffer, offset, count);
		}

		/// <inheritdoc />
		public Task<int> ReadAsync(byte[] buffer, int offset, int count)
		{
			return InternalInstance.ReadAsync(buffer, offset, count);
		}

		/// <inheritdoc />
		public Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return InternalInstance.ReadAsync(buffer, offset, count, cancellationToken);
		}

		/// <inheritdoc />
		public int ReadByte()
		{
			return InternalInstance.ReadByte();
		}

		/// <inheritdoc />
		public long Seek(long offset, SeekOrigin origin)
		{
			return InternalInstance.Seek(offset, origin);
		}

		/// <inheritdoc />
		public void SetLength(long value)
		{
			InternalInstance.SetLength(value);
		}

		/// <inheritdoc />
		public void Write(byte[] buffer, int offset, int count)
		{
			InternalInstance.Write(buffer, offset, count);
		}

		/// <inheritdoc />
		public Task WriteAsync(byte[] buffer, int offset, int count)
		{
			return InternalInstance.WriteAsync(buffer, offset, count);
		}

		/// <inheritdoc />
		public Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return InternalInstance.WriteAsync(buffer, offset, count, cancellationToken);
		}

		/// <inheritdoc />
		public void WriteByte(byte value)
		{
			InternalInstance.WriteByte(value);
		}

		/// <inheritdoc />
		public void Dispose()
		{
			InternalInstance.Dispose();
		}

		/// <inheritdoc />
		public override string ToString()
		{
			return InternalInstance.ToString();
		}

		/// <inheritdoc />
		public override bool Equals(object obj)
		{
			return InternalInstance.Equals(obj);
		}

		/// <inheritdoc />
		public override int GetHashCode()
		{
			return InternalInstance.GetHashCode();
		}
	}
}