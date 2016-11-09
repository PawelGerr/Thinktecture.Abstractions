using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using Thinktecture.Text;

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="BinaryWriter"/>.
	/// </summary>
	public class BinaryWriterAdapter : IBinaryWriter
	{
		/// <summary>Specifies a <see cref="T:System.IO.BinaryWriter" /> with no backing store.</summary>
		/// <filterpriority>1</filterpriority>
		public static readonly IBinaryWriter Null = new BinaryWriterAdapter(BinaryWriter.Null);

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public BinaryWriter InternalInstance { get; }

		/// <inheritdoc />
		public IStream BaseStream => InternalInstance.BaseStream.ToInterface();

		/// <summary>Initializes a new instance of the <see cref="BinaryWriterAdapter" /> class based on the specified stream and using UTF-8 encoding.</summary>
		/// <param name="output">The output stream. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="output" /> is null. </exception>
		public BinaryWriterAdapter(IStream output)
			: this(new BinaryWriter(output.ToImplementation()))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryWriterAdapter" /> class based on the specified stream and using UTF-8 encoding.</summary>
		/// <param name="output">The output stream. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="output" /> is null. </exception>
		public BinaryWriterAdapter(Stream output)
			: this(new BinaryWriter(output))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryWriterAdapter" /> class based on the specified stream and character encoding.</summary>
		/// <param name="output">The output stream. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="output" /> or <paramref name="encoding" /> is null. </exception>
		public BinaryWriterAdapter(IStream output, IEncoding encoding)
			: this(new BinaryWriter(output.ToImplementation(), encoding.ToImplementation()))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryWriterAdapter" /> class based on the specified stream and character encoding.</summary>
		/// <param name="output">The output stream. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="output" /> or <paramref name="encoding" /> is null. </exception>
		public BinaryWriterAdapter(Stream output, IEncoding encoding)
			: this(new BinaryWriter(output, encoding.ToImplementation()))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryWriterAdapter" /> class based on the specified stream and character encoding.</summary>
		/// <param name="output">The output stream. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="output" /> or <paramref name="encoding" /> is null. </exception>
		public BinaryWriterAdapter(IStream output, Encoding encoding)
			: this(new BinaryWriter(output.ToImplementation(), encoding))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryWriterAdapter" /> class based on the specified stream and character encoding.</summary>
		/// <param name="output">The output stream. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="output" /> or <paramref name="encoding" /> is null. </exception>
		public BinaryWriterAdapter(Stream output, Encoding encoding)
			: this(new BinaryWriter(output, encoding))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryWriterAdapter" /> class based on the specified stream and character encoding, and optionally leaves the stream open.</summary>
		/// <param name="output">The output stream.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="leaveOpen">true to leave the stream open after the <see cref="T:System.IO.BinaryWriter" /> object is disposed; otherwise, false.</param>
		/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="output" /> or <paramref name="encoding" /> is null. </exception>
		public BinaryWriterAdapter(IStream output, IEncoding encoding, bool leaveOpen)
			: this(new BinaryWriter(output.ToImplementation(), encoding.ToImplementation(), leaveOpen))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryWriterAdapter" /> class based on the specified stream and character encoding, and optionally leaves the stream open.</summary>
		/// <param name="output">The output stream.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="leaveOpen">true to leave the stream open after the <see cref="T:System.IO.BinaryWriter" /> object is disposed; otherwise, false.</param>
		/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="output" /> or <paramref name="encoding" /> is null. </exception>
		public BinaryWriterAdapter(Stream output, IEncoding encoding, bool leaveOpen)
			: this(new BinaryWriter(output, encoding.ToImplementation(), leaveOpen))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryWriterAdapter" /> class based on the specified stream and character encoding, and optionally leaves the stream open.</summary>
		/// <param name="output">The output stream.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="leaveOpen">true to leave the stream open after the <see cref="T:System.IO.BinaryWriter" /> object is disposed; otherwise, false.</param>
		/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="output" /> or <paramref name="encoding" /> is null. </exception>
		public BinaryWriterAdapter(IStream output, Encoding encoding, bool leaveOpen)
			: this(new BinaryWriter(output.ToImplementation(), encoding, leaveOpen))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryWriterAdapter" /> class based on the specified stream and character encoding, and optionally leaves the stream open.</summary>
		/// <param name="output">The output stream.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="leaveOpen">true to leave the stream open after the <see cref="T:System.IO.BinaryWriter" /> object is disposed; otherwise, false.</param>
		/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="output" /> or <paramref name="encoding" /> is null. </exception>
		public BinaryWriterAdapter(Stream output, Encoding encoding, bool leaveOpen)
			: this(new BinaryWriter(output, encoding, leaveOpen))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BinaryWriterAdapter" /> class
		/// </summary>
		/// <param name="writer">Writer to be used by the adapter.</param>
		public BinaryWriterAdapter(BinaryWriter writer)
		{
			if (writer == null)
				throw new ArgumentNullException(nameof(writer));

			InternalInstance = writer;
		}

		/// <inheritdoc />
		public void Flush()
		{
			InternalInstance.Flush();
		}

		/// <inheritdoc />
		public long Seek(int offset, SeekOrigin origin)
		{
			return InternalInstance.Seek(offset, origin);
		}

		/// <inheritdoc />
		public void Write(bool value)
		{
			InternalInstance.Write(value);
		}

		/// <inheritdoc />
		public void Write(byte value)
		{
			InternalInstance.Write(value);
		}

		/// <inheritdoc />
		public void Write(byte[] buffer)
		{
			InternalInstance.Write(buffer);
		}

		/// <inheritdoc />
		public void Write(byte[] buffer, int index, int count)
		{
			InternalInstance.Write(buffer, index, count);
		}

		/// <inheritdoc />
		public void Write(char ch)
		{
			InternalInstance.Write(ch);
		}

		/// <inheritdoc />
		public void Write(char[] chars)
		{
			InternalInstance.Write(chars);
		}

		/// <inheritdoc />
		public void Write(char[] chars, int index, int count)
		{
			InternalInstance.Write(chars, index, count);
		}

		/// <inheritdoc />
		public void Write(decimal value)
		{
			InternalInstance.Write(value);
		}

		/// <inheritdoc />
		public void Write(double value)
		{
			InternalInstance.Write(value);
		}

		/// <inheritdoc />
		public void Write(short value)
		{
			InternalInstance.Write(value);
		}

		/// <inheritdoc />
		public void Write(int value)
		{
			InternalInstance.Write(value);
		}

		/// <inheritdoc />
		public void Write(long value)
		{
			InternalInstance.Write(value);
		}

		/// <inheritdoc />
		public void Write(sbyte value)
		{
			InternalInstance.Write(value);
		}

		/// <inheritdoc />
		public void Write(float value)
		{
			InternalInstance.Write(value);
		}

		/// <inheritdoc />
		public void Write(string value)
		{
			InternalInstance.Write(value);
		}

		/// <inheritdoc />
		public void Write(ushort value)
		{
			InternalInstance.Write(value);
		}

		/// <inheritdoc />
		public void Write(uint value)
		{
			InternalInstance.Write(value);
		}

		/// <inheritdoc />
		public void Write(ulong value)
		{
			InternalInstance.Write(value);
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