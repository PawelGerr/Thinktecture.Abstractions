using System;
using System.IO;
using System.Text;

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

		private readonly BinaryWriter _writer;

		/// <inheritdoc />
		public IStream BaseStream => _writer.BaseStream.ToInterface();

		/// <summary>Initializes a new instance of the <see cref="BinaryWriterAdapter" /> class based on the specified stream and using UTF-8 encoding.</summary>
		/// <param name="output">The output stream. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="output" /> is null. </exception>
		public BinaryWriterAdapter(IStream output)
			: this(new BinaryWriter(output?.ToImplementation()))
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
		public BinaryWriterAdapter(IStream output, Encoding encoding)
			: this(new BinaryWriter(output?.ToImplementation(), encoding))
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
		public BinaryWriterAdapter(IStream output, Encoding encoding, bool leaveOpen)
			: this(new BinaryWriter(output?.ToImplementation(), encoding, leaveOpen))
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

			_writer = writer;
		}

		/// <inheritdoc />
		public BinaryWriter ToImplementation()
		{
			return _writer;
		}

		/// <inheritdoc />
		public void Flush()
		{
			_writer.Flush();
		}

		/// <inheritdoc />
		public long Seek(int offset, SeekOrigin origin)
		{
			return _writer.Seek(offset, origin);
		}

		/// <inheritdoc />
		public void Write(bool value)
		{
			_writer.Write(value);
		}

		/// <inheritdoc />
		public void Write(byte value)
		{
			_writer.Write(value);
		}

		/// <inheritdoc />
		public void Write(byte[] buffer)
		{
			_writer.Write(buffer);
		}

		/// <inheritdoc />
		public void Write(byte[] buffer, int index, int count)
		{
			_writer.Write(buffer, index, count);
		}

		/// <inheritdoc />
		public void Write(char ch)
		{
			_writer.Write(ch);
		}

		/// <inheritdoc />
		public void Write(char[] chars)
		{
			_writer.Write(chars);
		}

		/// <inheritdoc />
		public void Write(char[] chars, int index, int count)
		{
			_writer.Write(chars, index, count);
		}

		/// <inheritdoc />
		public void Write(decimal value)
		{
			_writer.Write(value);
		}

		/// <inheritdoc />
		public void Write(double value)
		{
			_writer.Write(value);
		}

		/// <inheritdoc />
		public void Write(short value)
		{
			_writer.Write(value);
		}

		/// <inheritdoc />
		public void Write(int value)
		{
			_writer.Write(value);
		}

		/// <inheritdoc />
		public void Write(long value)
		{
			_writer.Write(value);
		}

		/// <inheritdoc />
		public void Write(sbyte value)
		{
			_writer.Write(value);
		}

		/// <inheritdoc />
		public void Write(float value)
		{
			_writer.Write(value);
		}

		/// <inheritdoc />
		public void Write(string value)
		{
			_writer.Write(value);
		}

		/// <inheritdoc />
		public void Write(ushort value)
		{
			_writer.Write(value);
		}

		/// <inheritdoc />
		public void Write(uint value)
		{
			_writer.Write(value);
		}

		/// <inheritdoc />
		public void Write(ulong value)
		{
			_writer.Write(value);
		}

		/// <inheritdoc />
		public void Dispose()
		{
			_writer.Dispose();
		}
	}
}