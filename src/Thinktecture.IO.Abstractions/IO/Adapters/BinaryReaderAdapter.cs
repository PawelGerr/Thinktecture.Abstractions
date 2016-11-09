using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using Thinktecture.Text;

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="BinaryReader"/>.
	/// </summary>
	public class BinaryReaderAdapter : IBinaryReader
	{
		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public BinaryReader InternalInstance { get; }

		/// <inheritdoc />
		public IStream BaseStream => InternalInstance.BaseStream.ToInterface();

		/// <summary>Initializes a new instance of the <see cref="BinaryReaderAdapter" /> class based on the specified stream and using UTF-8 encoding.</summary>
		/// <param name="input">The input stream. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading, is null, or is already closed. </exception>
		public BinaryReaderAdapter(IStream input)
			: this(new BinaryReader(input.ToImplementation()))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryReaderAdapter" /> class based on the specified stream and using UTF-8 encoding.</summary>
		/// <param name="input">The input stream. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading, is null, or is already closed. </exception>
		public BinaryReaderAdapter(Stream input)
			: this(new BinaryReader(input))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryReaderAdapter" /> class based on the specified stream and character encoding.</summary>
		/// <param name="input">The input stream. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading, is null, or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="encoding" /> is null. </exception>
		public BinaryReaderAdapter(IStream input, IEncoding encoding)
			: this(new BinaryReader(input.ToImplementation(), encoding.ToImplementation()))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryReaderAdapter" /> class based on the specified stream and character encoding.</summary>
		/// <param name="input">The input stream. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading, is null, or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="encoding" /> is null. </exception>
		public BinaryReaderAdapter(IStream input, Encoding encoding)
			: this(new BinaryReader(input.ToImplementation(), encoding))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryReaderAdapter" /> class based on the specified stream and character encoding.</summary>
		/// <param name="input">The input stream. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading, is null, or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="encoding" /> is null. </exception>
		public BinaryReaderAdapter(Stream input, IEncoding encoding)
			: this(new BinaryReader(input, encoding.ToImplementation()))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryReaderAdapter" /> class based on the specified stream and character encoding.</summary>
		/// <param name="input">The input stream. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading, is null, or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="encoding" /> is null. </exception>
		public BinaryReaderAdapter(Stream input, Encoding encoding)
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
		public BinaryReaderAdapter(IStream input, IEncoding encoding, bool leaveOpen)
			: this(new BinaryReader(input.ToImplementation(), encoding.ToImplementation(), leaveOpen))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryReaderAdapter" /> class based on the specified stream and character encoding, and optionally leaves the stream open.</summary>
		/// <param name="input">The input stream.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="leaveOpen">true to leave the stream open after the <see cref="T:System.IO.BinaryReader" /> object is disposed; otherwise, false.</param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading, is null, or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="encoding" /> or <paramref name="input" /> is null. </exception>
		public BinaryReaderAdapter(Stream input, IEncoding encoding, bool leaveOpen)
			: this(new BinaryReader(input, encoding.ToImplementation(), leaveOpen))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryReaderAdapter" /> class based on the specified stream and character encoding, and optionally leaves the stream open.</summary>
		/// <param name="input">The input stream.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="leaveOpen">true to leave the stream open after the <see cref="T:System.IO.BinaryReader" /> object is disposed; otherwise, false.</param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading, is null, or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="encoding" /> or <paramref name="input" /> is null. </exception>
		public BinaryReaderAdapter(IStream input, Encoding encoding, bool leaveOpen)
			: this(new BinaryReader(input.ToImplementation(), encoding, leaveOpen))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryReaderAdapter" /> class based on the specified stream and character encoding, and optionally leaves the stream open.</summary>
		/// <param name="input">The input stream.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <param name="leaveOpen">true to leave the stream open after the <see cref="T:System.IO.BinaryReader" /> object is disposed; otherwise, false.</param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading, is null, or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="encoding" /> or <paramref name="input" /> is null. </exception>
		public BinaryReaderAdapter(Stream input, Encoding encoding, bool leaveOpen)
			: this(new BinaryReader(input, encoding, leaveOpen))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BinaryReaderAdapter" /> class.
		/// </summary>
		/// <param name="reader">Reader to use by the adapter.</param>
		public BinaryReaderAdapter(BinaryReader reader)
		{
			if (reader == null)
				throw new ArgumentNullException(nameof(reader));

			InternalInstance = reader;
		}

		/// <inheritdoc />
		public int PeekChar()
		{
			return InternalInstance.PeekChar();
		}

		/// <inheritdoc />
		public int Read()
		{
			return InternalInstance.Read();
		}

		/// <inheritdoc />
		public int Read(byte[] buffer, int index, int count)
		{
			return InternalInstance.Read(buffer, index, count);
		}

		/// <inheritdoc />
		public int Read(char[] buffer, int index, int count)
		{
			return InternalInstance.Read(buffer, index, count);
		}

		/// <inheritdoc />
		public bool ReadBoolean()
		{
			return InternalInstance.ReadBoolean();
		}

		/// <inheritdoc />
		public byte ReadByte()
		{
			return InternalInstance.ReadByte();
		}

		/// <inheritdoc />
		public byte[] ReadBytes(int count)
		{
			return InternalInstance.ReadBytes(count);
		}

		/// <inheritdoc />
		public char ReadChar()
		{
			return InternalInstance.ReadChar();
		}

		/// <inheritdoc />
		public char[] ReadChars(int count)
		{
			return InternalInstance.ReadChars(count);
		}

		/// <inheritdoc />
		public decimal ReadDecimal()
		{
			return InternalInstance.ReadDecimal();
		}

		/// <inheritdoc />
		public double ReadDouble()
		{
			return InternalInstance.ReadDouble();
		}

		/// <inheritdoc />
		public short ReadInt16()
		{
			return InternalInstance.ReadInt16();
		}

		/// <inheritdoc />
		public int ReadInt32()
		{
			return InternalInstance.ReadInt32();
		}

		/// <inheritdoc />
		public long ReadInt64()
		{
			return InternalInstance.ReadInt64();
		}

		/// <inheritdoc />
		public sbyte ReadSByte()
		{
			return InternalInstance.ReadSByte();
		}

		/// <inheritdoc />
		public float ReadSingle()
		{
			return InternalInstance.ReadSingle();
		}

		/// <inheritdoc />
		public string ReadString()
		{
			return InternalInstance.ReadString();
		}

		/// <inheritdoc />
		public ushort ReadUInt16()
		{
			return InternalInstance.ReadUInt16();
		}

		/// <inheritdoc />
		public uint ReadUInt32()
		{
			return InternalInstance.ReadUInt32();
		}

		/// <inheritdoc />
		public ulong ReadUInt64()
		{
			return InternalInstance.ReadUInt64();
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