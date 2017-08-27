using System;
using System.IO;
using System.Text;
using JetBrains.Annotations;
using Thinktecture.Text;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="BinaryReader"/>.
	/// </summary>
	public class BinaryReaderAdapter : AbstractionAdapter<BinaryReader>, IBinaryReader
	{
		/// <inheritdoc />
		public IStream BaseStream => Implementation.BaseStream.ToInterface();

		/// <summary>Initializes a new instance of the <see cref="BinaryReaderAdapter" /> class based on the specified stream and using UTF-8 encoding.</summary>
		/// <param name="input">The input stream. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading, is null, or is already closed. </exception>
		public BinaryReaderAdapter([NotNull] IStream input)
			: this(input.ToImplementation())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryReaderAdapter" /> class based on the specified stream and using UTF-8 encoding.</summary>
		/// <param name="input">The input stream. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading, is null, or is already closed. </exception>
		public BinaryReaderAdapter([NotNull] Stream input)
			: this(new BinaryReader(input))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryReaderAdapter" /> class based on the specified stream and character encoding.</summary>
		/// <param name="input">The input stream. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading, is null, or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="encoding" /> is null. </exception>
		public BinaryReaderAdapter([NotNull] IStream input, [NotNull] IEncoding encoding)
			: this(input.ToImplementation(), encoding.ToImplementation())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryReaderAdapter" /> class based on the specified stream and character encoding.</summary>
		/// <param name="input">The input stream. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading, is null, or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="encoding" /> is null. </exception>
		public BinaryReaderAdapter([NotNull] IStream input, [NotNull] Encoding encoding)
			: this(input.ToImplementation(), encoding)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryReaderAdapter" /> class based on the specified stream and character encoding.</summary>
		/// <param name="input">The input stream. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading, is null, or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="encoding" /> is null. </exception>
		public BinaryReaderAdapter([NotNull] Stream input, [NotNull] IEncoding encoding)
			: this(input, encoding.ToImplementation())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryReaderAdapter" /> class based on the specified stream and character encoding.</summary>
		/// <param name="input">The input stream. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading, is null, or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="encoding" /> is null. </exception>
		public BinaryReaderAdapter([NotNull] Stream input, [NotNull] Encoding encoding)
			: this(new BinaryReader(input, encoding))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryReaderAdapter" /> class based on the specified stream and character encoding, and optionally leaves the stream open.</summary>
		/// <param name="input">The input stream.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="leaveOpen">true to leave the stream open after the <see cref="T:System.IO.BinaryReader" /> object is disposed; otherwise, false.</param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading, is null, or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="encoding" /> or <paramref name="input" /> is null. </exception>
		public BinaryReaderAdapter([NotNull] IStream input, [NotNull] IEncoding encoding, bool leaveOpen)
			: this(input.ToImplementation(), encoding.ToImplementation(), leaveOpen)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryReaderAdapter" /> class based on the specified stream and character encoding, and optionally leaves the stream open.</summary>
		/// <param name="input">The input stream.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="leaveOpen">true to leave the stream open after the <see cref="T:System.IO.BinaryReader" /> object is disposed; otherwise, false.</param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading, is null, or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="encoding" /> or <paramref name="input" /> is null. </exception>
		public BinaryReaderAdapter([NotNull] Stream input, [NotNull] IEncoding encoding, bool leaveOpen)
			: this(input, encoding.ToImplementation(), leaveOpen)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryReaderAdapter" /> class based on the specified stream and character encoding, and optionally leaves the stream open.</summary>
		/// <param name="input">The input stream.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="leaveOpen">true to leave the stream open after the <see cref="T:System.IO.BinaryReader" /> object is disposed; otherwise, false.</param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading, is null, or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="encoding" /> or <paramref name="input" /> is null. </exception>
		public BinaryReaderAdapter([NotNull] IStream input, [NotNull] Encoding encoding, bool leaveOpen)
			: this(input.ToImplementation(), encoding, leaveOpen)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryReaderAdapter" /> class based on the specified stream and character encoding, and optionally leaves the stream open.</summary>
		/// <param name="input">The input stream.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="leaveOpen">true to leave the stream open after the <see cref="T:System.IO.BinaryReader" /> object is disposed; otherwise, false.</param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading, is null, or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="encoding" /> or <paramref name="input" /> is null. </exception>
		public BinaryReaderAdapter([NotNull] Stream input, [NotNull] Encoding encoding, bool leaveOpen)
			: this(new BinaryReader(input, encoding, leaveOpen))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BinaryReaderAdapter" /> class.
		/// </summary>
		/// <param name="reader">Reader to use by the adapter.</param>
		public BinaryReaderAdapter([NotNull] BinaryReader reader)
			: base(reader)
		{
		}

		/// <inheritdoc />
		public int PeekChar()
		{
			return Implementation.PeekChar();
		}

		/// <inheritdoc />
		public int Read()
		{
			return Implementation.Read();
		}

		/// <inheritdoc />
		public int Read(byte[] buffer, int index, int count)
		{
			return Implementation.Read(buffer, index, count);
		}

		/// <inheritdoc />
		public int Read(char[] buffer, int index, int count)
		{
			return Implementation.Read(buffer, index, count);
		}

		/// <inheritdoc />
		public bool ReadBoolean()
		{
			return Implementation.ReadBoolean();
		}

		/// <inheritdoc />
		public byte ReadByte()
		{
			return Implementation.ReadByte();
		}

		/// <inheritdoc />
		public byte[] ReadBytes(int count)
		{
			return Implementation.ReadBytes(count);
		}

		/// <inheritdoc />
		public char ReadChar()
		{
			return Implementation.ReadChar();
		}

		/// <inheritdoc />
		public char[] ReadChars(int count)
		{
			return Implementation.ReadChars(count);
		}

		/// <inheritdoc />
		public decimal ReadDecimal()
		{
			return Implementation.ReadDecimal();
		}

		/// <inheritdoc />
		public double ReadDouble()
		{
			return Implementation.ReadDouble();
		}

		/// <inheritdoc />
		public short ReadInt16()
		{
			return Implementation.ReadInt16();
		}

		/// <inheritdoc />
		public int ReadInt32()
		{
			return Implementation.ReadInt32();
		}

		/// <inheritdoc />
		public long ReadInt64()
		{
			return Implementation.ReadInt64();
		}

		/// <inheritdoc />
		public sbyte ReadSByte()
		{
			return Implementation.ReadSByte();
		}

		/// <inheritdoc />
		public float ReadSingle()
		{
			return Implementation.ReadSingle();
		}

		/// <inheritdoc />
		public string ReadString()
		{
			return Implementation.ReadString();
		}

		/// <inheritdoc />
		public ushort ReadUInt16()
		{
			return Implementation.ReadUInt16();
		}

		/// <inheritdoc />
		public uint ReadUInt32()
		{
			return Implementation.ReadUInt32();
		}

		/// <inheritdoc />
		public ulong ReadUInt64()
		{
			return Implementation.ReadUInt64();
		}

		/// <inheritdoc />
		public void Dispose()
		{
			Implementation.Dispose();
		}
	}
}
