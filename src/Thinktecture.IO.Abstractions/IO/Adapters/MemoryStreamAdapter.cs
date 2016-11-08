using System;
using System.ComponentModel;
using System.IO;

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="MemoryStream"/>.
	/// </summary>
	public class MemoryStreamAdapter : StreamAdapter, IMemoryStream
	{
		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new MemoryStream InternalInstance { get; }

		/// <inheritdoc />
		public int Capacity
		{
			get { return InternalInstance.Capacity; }
			set { InternalInstance.Capacity = value; }
		}

		/// <summary>Initializes a new instance of the <see cref="MemoryStreamAdapter" /> class with an expandable capacity initialized to zero.</summary>
		public MemoryStreamAdapter()
			: this(new MemoryStream())
		{
		}

		/// <summary>Initializes a new non-resizable instance of the <see cref="MemoryStreamAdapter" /> class based on the specified byte array.</summary>
		/// <param name="buffer">The array of unsigned bytes from which to create the current stream. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="buffer" /> is null. </exception>
		public MemoryStreamAdapter(byte[] buffer)
			: this(new MemoryStream(buffer))
		{
		}

		/// <summary>Initializes a new non-resizable instance of the <see cref="MemoryStreamAdapter" /> class based on the specified byte array with the <see cref="P:System.IO.MemoryStream.CanWrite" /> property set as specified.</summary>
		/// <param name="buffer">The array of unsigned bytes from which to create this stream. </param>
		/// <param name="writable">The setting of the <see cref="P:System.IO.MemoryStream.CanWrite" /> property, which determines whether the stream supports writing. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="buffer" /> is null. </exception>
		public MemoryStreamAdapter(byte[] buffer, bool writable)
			: this(new MemoryStream(buffer, writable))
		{
		}

		/// <summary>Initializes a new non-resizable instance of the <see cref="MemoryStreamAdapter" /> class based on the specified region (index) of a byte array.</summary>
		/// <param name="buffer">The array of unsigned bytes from which to create this stream. </param>
		/// <param name="index">The index into <paramref name="buffer" /> at which the stream begins. </param>
		/// <param name="count">The length of the stream in bytes. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="buffer" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="index" /> or <paramref name="count" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.</exception>
		public MemoryStreamAdapter(byte[] buffer, int index, int count)
			: this(new MemoryStream(buffer, index, count))
		{
		}

		/// <summary>Initializes a new non-resizable instance of the <see cref="MemoryStreamAdapter" /> class based on the specified region of a byte array, with the <see cref="P:System.IO.MemoryStream.CanWrite" /> property set as specified.</summary>
		/// <param name="buffer">The array of unsigned bytes from which to create this stream. </param>
		/// <param name="index">The index in <paramref name="buffer" /> at which the stream begins. </param>
		/// <param name="count">The length of the stream in bytes. </param>
		/// <param name="writable">The setting of the <see cref="P:System.IO.MemoryStream.CanWrite" /> property, which determines whether the stream supports writing. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="buffer" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="index" /> or <paramref name="count" /> are negative. </exception>
		/// <exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.</exception>
		public MemoryStreamAdapter(byte[] buffer, int index, int count, bool writable)
			: this(new MemoryStream(buffer, index, count, writable))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="MemoryStreamAdapter" /> class with an expandable capacity initialized as specified.</summary>
		/// <param name="capacity">The initial size of the internal array in bytes. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="capacity" /> is negative. </exception>
		public MemoryStreamAdapter(int capacity)
			: this(new MemoryStream(capacity))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="MemoryStreamAdapter" /> class.
		/// </summary>
		/// <param name="stream">Stream to be used by the adapter.</param>
		public MemoryStreamAdapter(MemoryStream stream)
			: base(stream)
		{
			if (stream == null)
				throw new ArgumentNullException(nameof(stream));

			InternalInstance = stream;
		}
		
		/// <inheritdoc />
		public byte[] ToArray()
		{
			return InternalInstance.ToArray();
		}

		/// <inheritdoc />
		public void WriteTo(IStream stream)
		{
			InternalInstance.WriteTo(stream.ToImplementation());
		}

		/// <inheritdoc />
		public void WriteTo(Stream stream)
		{
			InternalInstance.WriteTo(stream);
		}
	}
}