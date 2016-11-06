using System;
using System.IO;
using System.Text;

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="BinaryReader"/>.
	/// </summary>
	public class BinaryReaderAdapter : IBinaryReader
	{
		private readonly BinaryReader _reader;

		/// <inheritdoc />
		public Stream BaseStream => _reader.BaseStream;

		/// <summary>Initializes a new instance of the <see cref="BinaryReaderAdapter" /> class based on the specified stream and using UTF-8 encoding.</summary>
		/// <param name="input">The input stream. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading, is null, or is already closed. </exception>
		public BinaryReaderAdapter(IStream input)
			: this(new BinaryReader(input?.ToImplementation()))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="BinaryReaderAdapter" /> class based on the specified stream and character encoding.</summary>
		/// <param name="input">The input stream. </param>
		/// <param name="encoding">The character encoding to use. </param>
		/// <exception cref="T:System.ArgumentException">The stream does not support reading, is null, or is already closed. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="encoding" /> is null. </exception>
		public BinaryReaderAdapter(IStream input, Encoding encoding)
			: this(new BinaryReader(input?.ToImplementation(), encoding))
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
			: this(new BinaryReader(input?.ToImplementation(), encoding, leaveOpen))
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

			_reader = reader;
		}

		/// <inheritdoc />
		public BinaryReader ToImplementation()
		{
			return _reader;
		}

		/// <inheritdoc />
		public int PeekChar()
		{
			return _reader.PeekChar();
		}

		/// <inheritdoc />
		public int Read()
		{
			return _reader.Read();
		}

		/// <inheritdoc />
		public int Read(byte[] buffer, int index, int count)
		{
			return _reader.Read(buffer, index, count);
		}

		/// <inheritdoc />
		public int Read(char[] buffer, int index, int count)
		{
			return _reader.Read(buffer, index, count);
		}

		/// <inheritdoc />
		public bool ReadBoolean()
		{
			return _reader.ReadBoolean();
		}

		/// <inheritdoc />
		public byte ReadByte()
		{
			return _reader.ReadByte();
		}

		/// <inheritdoc />
		public byte[] ReadBytes(int count)
		{
			return _reader.ReadBytes(count);
		}

		/// <inheritdoc />
		public char ReadChar()
		{
			return _reader.ReadChar();
		}

		/// <inheritdoc />
		public char[] ReadChars(int count)
		{
			return _reader.ReadChars(count);
		}

		/// <inheritdoc />
		public decimal ReadDecimal()
		{
			return _reader.ReadDecimal();
		}

		/// <inheritdoc />
		public double ReadDouble()
		{
			return _reader.ReadDouble();
		}

		/// <inheritdoc />
		public short ReadInt16()
		{
			return _reader.ReadInt16();
		}

		/// <inheritdoc />
		public int ReadInt32()
		{
			return _reader.ReadInt32();
		}

		/// <inheritdoc />
		public long ReadInt64()
		{
			return _reader.ReadInt64();
		}

		/// <inheritdoc />
		public sbyte ReadSByte()
		{
			return _reader.ReadSByte();
		}

		/// <inheritdoc />
		public float ReadSingle()
		{
			return _reader.ReadSingle();
		}

		/// <inheritdoc />
		public string ReadString()
		{
			return _reader.ReadString();
		}

		/// <inheritdoc />
		public ushort ReadUInt16()
		{
			return _reader.ReadUInt16();
		}

		/// <inheritdoc />
		public uint ReadUInt32()
		{
			return _reader.ReadUInt32();
		}

		/// <inheritdoc />
		public ulong ReadUInt64()
		{
			return _reader.ReadUInt64();
		}

		/// <inheritdoc />
		public void Dispose()
		{
			_reader.Dispose();
		}
	}
}