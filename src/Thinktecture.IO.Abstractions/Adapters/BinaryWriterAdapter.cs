using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.IO
{
	public class BinaryWriterAdapter : IBinaryWriter
	{
		private readonly BinaryWriter _writer;

		/// <inheritdoc />
		public Stream BaseStream => _writer.BaseStream;

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