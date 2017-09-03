using System;
using System.IO;
using System.Text;
using JetBrains.Annotations;
using Thinktecture.Text;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="BinaryWriter"/>.
	/// </summary>
	public class BinaryWriterAdapter : AbstractionAdapter<BinaryWriter>, IBinaryWriter
	{
		/// <summary>Specifies a <see cref="T:System.IO.BinaryWriter" /> with no backing store.</summary>
		public static readonly IBinaryWriter Null = new BinaryWriterAdapter(BinaryWriter.Null);

		/// <inheritdoc />
		public IStream BaseStream => Implementation.BaseStream.ToInterface();

		/// <summary>Initializes a new instance of the <see cref="BinaryWriterAdapter" /> class based on the specified stream and using UTF-8 encoding.</summary>
		/// <param name="output">The output stream. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="output" /> is null. </exception>
		public BinaryWriterAdapter([NotNull] IStream output)
			: this(output.ToImplementation())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryWriterAdapter" /> class based on the specified stream and using UTF-8 encoding.</summary>
		/// <param name="output">The output stream. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="output" /> is null. </exception>
		public BinaryWriterAdapter([NotNull] Stream output)
			: this(new BinaryWriter(output))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryWriterAdapter" /> class based on the specified stream and character encoding.</summary>
		/// <param name="output">The output stream. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="output" /> or <paramref name="encoding" /> is null. </exception>
		public BinaryWriterAdapter([NotNull] IStream output, [NotNull] IEncoding encoding)
			: this(output.ToImplementation(), encoding.ToImplementation())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryWriterAdapter" /> class based on the specified stream and character encoding.</summary>
		/// <param name="output">The output stream. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="output" /> or <paramref name="encoding" /> is null. </exception>
		public BinaryWriterAdapter([NotNull] Stream output, [NotNull] IEncoding encoding)
			: this(output, encoding.ToImplementation())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryWriterAdapter" /> class based on the specified stream and character encoding.</summary>
		/// <param name="output">The output stream. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="output" /> or <paramref name="encoding" /> is null. </exception>
		public BinaryWriterAdapter([NotNull] IStream output, [NotNull] Encoding encoding)
			: this(output.ToImplementation(), encoding)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryWriterAdapter" /> class based on the specified stream and character encoding.</summary>
		/// <param name="output">The output stream. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="output" /> or <paramref name="encoding" /> is null. </exception>
		public BinaryWriterAdapter([NotNull] Stream output, [NotNull] Encoding encoding)
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
		public BinaryWriterAdapter([NotNull] IStream output, [NotNull] IEncoding encoding, bool leaveOpen)
			: this(output.ToImplementation(), encoding.ToImplementation(), leaveOpen)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryWriterAdapter" /> class based on the specified stream and character encoding, and optionally leaves the stream open.</summary>
		/// <param name="output">The output stream.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="leaveOpen">true to leave the stream open after the <see cref="T:System.IO.BinaryWriter" /> object is disposed; otherwise, false.</param>
		/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="output" /> or <paramref name="encoding" /> is null. </exception>
		public BinaryWriterAdapter([NotNull] Stream output, [NotNull] IEncoding encoding, bool leaveOpen)
			: this(output, encoding.ToImplementation(), leaveOpen)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryWriterAdapter" /> class based on the specified stream and character encoding, and optionally leaves the stream open.</summary>
		/// <param name="output">The output stream.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="leaveOpen">true to leave the stream open after the <see cref="T:System.IO.BinaryWriter" /> object is disposed; otherwise, false.</param>
		/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="output" /> or <paramref name="encoding" /> is null. </exception>
		public BinaryWriterAdapter([NotNull] IStream output, [NotNull] Encoding encoding, bool leaveOpen)
			: this(output.ToImplementation(), encoding, leaveOpen)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryWriterAdapter" /> class based on the specified stream and character encoding, and optionally leaves the stream open.</summary>
		/// <param name="output">The output stream.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="leaveOpen">true to leave the stream open after the <see cref="T:System.IO.BinaryWriter" /> object is disposed; otherwise, false.</param>
		/// <exception cref="T:System.ArgumentException">The stream does not support writing or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="output" /> or <paramref name="encoding" /> is null. </exception>
		public BinaryWriterAdapter([NotNull] Stream output, [NotNull] Encoding encoding, bool leaveOpen)
			: this(new BinaryWriter(output, encoding, leaveOpen))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BinaryWriterAdapter" /> class
		/// </summary>
		/// <param name="writer">Writer to be used by the adapter.</param>
		public BinaryWriterAdapter([NotNull] BinaryWriter writer)
			: base(writer)
		{
		}

		/// <inheritdoc />
		public void Flush()
		{
			Implementation.Flush();
		}

		/// <inheritdoc />
		public long Seek(int offset, SeekOrigin origin)
		{
			return Implementation.Seek(offset, origin);
		}

		/// <inheritdoc />
		public void Write(bool value)
		{
			Implementation.Write(value);
		}

		/// <inheritdoc />
		public void Write(byte value)
		{
			Implementation.Write(value);
		}

		/// <inheritdoc />
		public void Write(byte[] buffer)
		{
			Implementation.Write(buffer);
		}

		/// <inheritdoc />
		public void Write(byte[] buffer, int index, int count)
		{
			Implementation.Write(buffer, index, count);
		}

		/// <inheritdoc />
		public void Write(char ch)
		{
			Implementation.Write(ch);
		}

		/// <inheritdoc />
		public void Write(char[] chars)
		{
			Implementation.Write(chars);
		}

		/// <inheritdoc />
		public void Write(char[] chars, int index, int count)
		{
			Implementation.Write(chars, index, count);
		}

		/// <inheritdoc />
		public void Write(decimal value)
		{
			Implementation.Write(value);
		}

		/// <inheritdoc />
		public void Write(double value)
		{
			Implementation.Write(value);
		}

		/// <inheritdoc />
		public void Write(short value)
		{
			Implementation.Write(value);
		}

		/// <inheritdoc />
		public void Write(int value)
		{
			Implementation.Write(value);
		}

		/// <inheritdoc />
		public void Write(long value)
		{
			Implementation.Write(value);
		}

		/// <inheritdoc />
		public void Write(sbyte value)
		{
			Implementation.Write(value);
		}

		/// <inheritdoc />
		public void Write(float value)
		{
			Implementation.Write(value);
		}

		/// <inheritdoc />
		public void Write(string value)
		{
			Implementation.Write(value);
		}

		/// <inheritdoc />
		public void Write(ushort value)
		{
			Implementation.Write(value);
		}

		/// <inheritdoc />
		public void Write(uint value)
		{
			Implementation.Write(value);
		}

		/// <inheritdoc />
		public void Write(ulong value)
		{
			Implementation.Write(value);
		}

		/// <inheritdoc />
		public void Dispose()
		{
			Implementation.Dispose();
		}
	}
}
