using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="TextWriter"/>.
	/// </summary>
	public class TextWriterAdapter : ITextWriter
	{
		/// <summary>Provides a TextWriter with no backing store that can be written to, but not read from.</summary>
		/// <filterpriority>1</filterpriority>
		public static readonly ITextWriter Null = new TextWriterAdapter(TextWriter.Null);

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public TextWriter UnsafeConvert()
		{
			return _instance;
		}

		private readonly TextWriter _instance;

		/// <summary>
		/// Creates an instance of <see cref="TextWriterAdapter"/>.
		/// </summary>
		/// <param name="writer">write to be used by the adapter.</param>
		public TextWriterAdapter(TextWriter writer)
		{
			if (writer == null)
				throw new ArgumentNullException(nameof(writer));

			_instance = writer;
		}

		/// <inheritdoc />
		public void Dispose()
		{
			_instance.Dispose();
		}
		
		/// <inheritdoc />
		public Encoding Encoding => _instance.Encoding;

		/// <inheritdoc />
		public IFormatProvider FormatProvider => _instance.FormatProvider;

		/// <inheritdoc />
		public string NewLine
		{
			get { return _instance.NewLine; }
			set { _instance.NewLine = value; }
		}

		/// <inheritdoc />
		public void Flush()
		{
			_instance.Flush();
		}

		/// <inheritdoc />
		public Task FlushAsync()
		{
			return _instance.FlushAsync();
		}

		/// <inheritdoc />
		public void Write(bool value)
		{
			_instance.Write(value);
		}

		/// <inheritdoc />
		public void Write(char value)
		{
			_instance.Write(value);
		}

		/// <inheritdoc />
		public void Write(char[] buffer)
		{
			_instance.Write(buffer);
		}

		/// <inheritdoc />
		public void Write(char[] buffer, int index, int count)
		{
			_instance.Write(buffer, index, count);
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
		public void Write(object value)
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
		public void Write(string format, params object[] arg)
		{
			_instance.Write(format, arg);
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
		public Task WriteAsync(char value)
		{
			return _instance.WriteAsync(value);
		}

		/// <inheritdoc />
		public Task WriteAsync(char[] buffer)
		{
			return _instance.WriteAsync(buffer);
		}

		/// <inheritdoc />
		public Task WriteAsync(char[] buffer, int index, int count)
		{
			return _instance.WriteAsync(buffer, index, count);
		}

		/// <inheritdoc />
		public Task WriteAsync(string value)
		{
			return _instance.WriteAsync(value);
		}

		/// <inheritdoc />
		public void WriteLine()
		{
			_instance.WriteLine();
		}

		/// <inheritdoc />
		public void WriteLine(bool value)
		{
			_instance.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(char value)
		{
			_instance.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(char[] buffer)
		{
			_instance.WriteLine(buffer);
		}

		/// <inheritdoc />
		public void WriteLine(char[] buffer, int index, int count)
		{
			_instance.WriteLine(buffer, index, count);
		}

		/// <inheritdoc />
		public void WriteLine(decimal value)
		{
			_instance.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(double value)
		{
			_instance.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(int value)
		{
			_instance.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(long value)
		{
			_instance.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(object value)
		{
			_instance.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(float value)
		{
			_instance.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(string value)
		{
			_instance.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(string format, params object[] arg)
		{
			_instance.WriteLine(format, arg);
		}

		/// <inheritdoc />
		public void WriteLine(uint value)
		{
			_instance.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(ulong value)
		{
			_instance.WriteLine(value);
		}

		/// <inheritdoc />
		public Task WriteLineAsync()
		{
			return _instance.WriteLineAsync();
		}

		/// <inheritdoc />
		public Task WriteLineAsync(char value)
		{
			return _instance.WriteLineAsync(value);
		}

		/// <inheritdoc />
		public Task WriteLineAsync(char[] buffer)
		{
			return _instance.WriteLineAsync(buffer);
		}

		/// <inheritdoc />
		public Task WriteLineAsync(char[] buffer, int index, int count)
		{
			return _instance.WriteLineAsync(buffer, index, count);
		}

		/// <inheritdoc />
		public Task WriteLineAsync(string value)
		{
			return _instance.WriteLineAsync(value);
		}
		
		/// <inheritdoc />
		public override string ToString()
		{
			return _instance.ToString();
		}

		/// <inheritdoc />
		public override bool Equals(object obj)
		{
			return _instance.Equals(obj);
		}

		/// <inheritdoc />
		public override int GetHashCode()
		{
			return _instance.GetHashCode();
		}
	}
}