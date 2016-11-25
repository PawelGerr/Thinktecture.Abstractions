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
	public class BinaryWriterAdapter : AbstractionAdapter, IBinaryWriter
	{
		/// <summary>Specifies a <see cref="T:System.IO.BinaryWriter" /> with no backing store.</summary>
		/// <filterpriority>1</filterpriority>
		public static readonly IBinaryWriter Null = new BinaryWriterAdapter(BinaryWriter.Null);

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new BinaryWriter UnsafeConvert()
		{
			return _instance;
		}

		private readonly BinaryWriter _instance;

		/// <inheritdoc />
		public IStream BaseStream => _instance.BaseStream.ToInterface();

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
			: base(writer)
		{
			if (writer == null)
				throw new ArgumentNullException(nameof(writer));

			_instance = writer;
		}

		/// <inheritdoc />
		public void Flush()
		{
			_instance.Flush();
		}

		/// <inheritdoc />
		public long Seek(int offset, SeekOrigin origin)
		{
			return _instance.Seek(offset, origin);
		}

		/// <inheritdoc />
		public void Write(bool value)
		{
			_instance.Write(value);
		}

		/// <inheritdoc />
		public void Write(byte value)
		{
			_instance.Write(value);
		}

		/// <inheritdoc />
		public void Write(byte[] buffer)
		{
			_instance.Write(buffer);
		}

		/// <inheritdoc />
		public void Write(byte[] buffer, int index, int count)
		{
			_instance.Write(buffer, index, count);
		}

		/// <inheritdoc />
		public void Write(char ch)
		{
			_instance.Write(ch);
		}

		/// <inheritdoc />
		public void Write(char[] chars)
		{
			_instance.Write(chars);
		}

		/// <inheritdoc />
		public void Write(char[] chars, int index, int count)
		{
			_instance.Write(chars, index, count);
		}

		/// <inheritdoc />
		public void Write(decimal value)
		{
			_instance.Write(value);
		}

		/// <inheritdoc />
		public void Write(double value)
		{
			_instance.Write(value);
		}

		/// <inheritdoc />
		public void Write(short value)
		{
			_instance.Write(value);
		}

		/// <inheritdoc />
		public void Write(int value)
		{
			_instance.Write(value);
		}

		/// <inheritdoc />
		public void Write(long value)
		{
			_instance.Write(value);
		}

		/// <inheritdoc />
		public void Write(sbyte value)
		{
			_instance.Write(value);
		}

		/// <inheritdoc />
		public void Write(float value)
		{
			_instance.Write(value);
		}

		/// <inheritdoc />
		public void Write(string value)
		{
			_instance.Write(value);
		}

		/// <inheritdoc />
		public void Write(ushort value)
		{
			_instance.Write(value);
		}

		/// <inheritdoc />
		public void Write(uint value)
		{
			_instance.Write(value);
		}

		/// <inheritdoc />
		public void Write(ulong value)
		{
			_instance.Write(value);
		}

		/// <inheritdoc />
		public void Dispose()
		{
			_instance.Dispose();
		}
	}
}