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
	public class BinaryReaderAdapter : AbstractionAdapter, IBinaryReader
	{
		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new BinaryReader UnsafeConvert()
		{
			return _instance;
		}

		private readonly BinaryReader _instance;

		/// <inheritdoc />
		public IStream BaseStream => _instance.BaseStream.ToInterface();

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
			: base(reader)
		{
			_instance = reader ?? throw new ArgumentNullException(nameof(reader));
		}

		/// <inheritdoc />
		public int PeekChar()
		{
			return _instance.PeekChar();
		}

		/// <inheritdoc />
		public int Read()
		{
			return _instance.Read();
		}

		/// <inheritdoc />
		public int Read(byte[] buffer, int index, int count)
		{
			return _instance.Read(buffer, index, count);
		}

		/// <inheritdoc />
		public int Read(char[] buffer, int index, int count)
		{
			return _instance.Read(buffer, index, count);
		}

		/// <inheritdoc />
		public bool ReadBoolean()
		{
			return _instance.ReadBoolean();
		}

		/// <inheritdoc />
		public byte ReadByte()
		{
			return _instance.ReadByte();
		}

		/// <inheritdoc />
		public byte[] ReadBytes(int count)
		{
			return _instance.ReadBytes(count);
		}

		/// <inheritdoc />
		public char ReadChar()
		{
			return _instance.ReadChar();
		}

		/// <inheritdoc />
		public char[] ReadChars(int count)
		{
			return _instance.ReadChars(count);
		}

		/// <inheritdoc />
		public decimal ReadDecimal()
		{
			return _instance.ReadDecimal();
		}

		/// <inheritdoc />
		public double ReadDouble()
		{
			return _instance.ReadDouble();
		}

		/// <inheritdoc />
		public short ReadInt16()
		{
			return _instance.ReadInt16();
		}

		/// <inheritdoc />
		public int ReadInt32()
		{
			return _instance.ReadInt32();
		}

		/// <inheritdoc />
		public long ReadInt64()
		{
			return _instance.ReadInt64();
		}

		/// <inheritdoc />
		public sbyte ReadSByte()
		{
			return _instance.ReadSByte();
		}

		/// <inheritdoc />
		public float ReadSingle()
		{
			return _instance.ReadSingle();
		}

		/// <inheritdoc />
		public string ReadString()
		{
			return _instance.ReadString();
		}

		/// <inheritdoc />
		public ushort ReadUInt16()
		{
			return _instance.ReadUInt16();
		}

		/// <inheritdoc />
		public uint ReadUInt32()
		{
			return _instance.ReadUInt32();
		}

		/// <inheritdoc />
		public ulong ReadUInt64()
		{
			return _instance.ReadUInt64();
		}

		/// <inheritdoc />
		public void Dispose()
		{
			_instance.Dispose();
		}
	}
}