using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.IO.Adapters
{
	public class TextWriterAdapter : ITextWriter
	{
		private readonly TextWriter _writer;

		public TextWriterAdapter(TextWriter writer)
		{
			if (writer == null)
				throw new ArgumentNullException(nameof(writer));

			_writer = writer;
		}

		/// <inheritdoc />
		public void Dispose()
		{
			_writer.Dispose();
		}

		/// <inheritdoc />
		public TextWriter ToImplementation()
		{
			return _writer;
		}

		/// <inheritdoc />
		public Encoding Encoding => _writer.Encoding;

		/// <inheritdoc />
		public IFormatProvider FormatProvider => _writer.FormatProvider;

		/// <inheritdoc />
		public string NewLine
		{
			get { return _writer.NewLine; }
			set { _writer.NewLine = value; }
		}

		/// <inheritdoc />
		public void Flush()
		{
			_writer.Flush();
		}

		/// <inheritdoc />
		public Task FlushAsync()
		{
			return _writer.FlushAsync();
		}

		/// <inheritdoc />
		public void Write(bool value)
		{
			_writer.Write(value);
		}

		/// <inheritdoc />
		public void Write(char value)
		{
			_writer.Write(value);
		}

		/// <inheritdoc />
		public void Write(char[] buffer)
		{
			_writer.Write(buffer);
		}

		/// <inheritdoc />
		public void Write(char[] buffer, int index, int count)
		{
			_writer.Write(buffer, index, count);
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
		public void Write(object value)
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
		public void Write(string format, params object[] arg)
		{
			_writer.Write(format, arg);
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
		public Task WriteAsync(char value)
		{
			return _writer.WriteAsync(value);
		}

		/// <inheritdoc />
		public Task WriteAsync(char[] buffer)
		{
			return _writer.WriteAsync(buffer);
		}

		/// <inheritdoc />
		public Task WriteAsync(char[] buffer, int index, int count)
		{
			return _writer.WriteAsync(buffer, index, count);
		}

		/// <inheritdoc />
		public Task WriteAsync(string value)
		{
			return _writer.WriteAsync(value);
		}

		/// <inheritdoc />
		public void WriteLine()
		{
			_writer.WriteLine();
		}

		/// <inheritdoc />
		public void WriteLine(bool value)
		{
			_writer.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(char value)
		{
			_writer.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(char[] buffer)
		{
			_writer.WriteLine(buffer);
		}

		/// <inheritdoc />
		public void WriteLine(char[] buffer, int index, int count)
		{
			_writer.WriteLine(buffer, index, count);
		}

		/// <inheritdoc />
		public void WriteLine(decimal value)
		{
			_writer.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(double value)
		{
			_writer.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(int value)
		{
			_writer.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(long value)
		{
			_writer.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(object value)
		{
			_writer.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(float value)
		{
			_writer.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(string value)
		{
			_writer.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(string format, params object[] arg)
		{
			_writer.WriteLine(format, arg);
		}

		/// <inheritdoc />
		public void WriteLine(uint value)
		{
			_writer.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(ulong value)
		{
			_writer.WriteLine(value);
		}

		/// <inheritdoc />
		public Task WriteLineAsync()
		{
			return _writer.WriteLineAsync();
		}

		/// <inheritdoc />
		public Task WriteLineAsync(char value)
		{
			return _writer.WriteLineAsync(value);
		}

		/// <inheritdoc />
		public Task WriteLineAsync(char[] buffer)
		{
			return _writer.WriteLineAsync(buffer);
		}

		/// <inheritdoc />
		public Task WriteLineAsync(char[] buffer, int index, int count)
		{
			return _writer.WriteLineAsync(buffer, index, count);
		}

		/// <inheritdoc />
		public Task WriteLineAsync(string value)
		{
			return _writer.WriteLineAsync(value);
		}
	}
}