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
		public TextWriter InternalInstance { get; }

		/// <summary>
		/// Creates an instance of <see cref="TextWriterAdapter"/>.
		/// </summary>
		/// <param name="writer">write to be used by the adapter.</param>
		public TextWriterAdapter(TextWriter writer)
		{
			if (writer == null)
				throw new ArgumentNullException(nameof(writer));

			InternalInstance = writer;
		}

		/// <inheritdoc />
		public void Dispose()
		{
			InternalInstance.Dispose();
		}
		
		/// <inheritdoc />
		public Encoding Encoding => InternalInstance.Encoding;

		/// <inheritdoc />
		public IFormatProvider FormatProvider => InternalInstance.FormatProvider;

		/// <inheritdoc />
		public string NewLine
		{
			get { return InternalInstance.NewLine; }
			set { InternalInstance.NewLine = value; }
		}

		/// <inheritdoc />
		public void Flush()
		{
			InternalInstance.Flush();
		}

		/// <inheritdoc />
		public Task FlushAsync()
		{
			return InternalInstance.FlushAsync();
		}

		/// <inheritdoc />
		public void Write(bool value)
		{
			InternalInstance.Write(value);
		}

		/// <inheritdoc />
		public void Write(char value)
		{
			InternalInstance.Write(value);
		}

		/// <inheritdoc />
		public void Write(char[] buffer)
		{
			InternalInstance.Write(buffer);
		}

		/// <inheritdoc />
		public void Write(char[] buffer, int index, int count)
		{
			InternalInstance.Write(buffer, index, count);
		}

		/// <inheritdoc />
		public void Write(decimal value)
		{
			InternalInstance.Write(value);
		}

		/// <inheritdoc />
		public void Write(double value)
		{
			InternalInstance.Write(value);
		}

		/// <inheritdoc />
		public void Write(int value)
		{
			InternalInstance.Write(value);
		}

		/// <inheritdoc />
		public void Write(long value)
		{
			InternalInstance.Write(value);
		}

		/// <inheritdoc />
		public void Write(object value)
		{
			InternalInstance.Write(value);
		}

		/// <inheritdoc />
		public void Write(float value)
		{
			InternalInstance.Write(value);
		}

		/// <inheritdoc />
		public void Write(string value)
		{
			InternalInstance.Write(value);
		}

		/// <inheritdoc />
		public void Write(string format, params object[] arg)
		{
			InternalInstance.Write(format, arg);
		}

		/// <inheritdoc />
		public void Write(uint value)
		{
			InternalInstance.Write(value);
		}

		/// <inheritdoc />
		public void Write(ulong value)
		{
			InternalInstance.Write(value);
		}

		/// <inheritdoc />
		public Task WriteAsync(char value)
		{
			return InternalInstance.WriteAsync(value);
		}

		/// <inheritdoc />
		public Task WriteAsync(char[] buffer)
		{
			return InternalInstance.WriteAsync(buffer);
		}

		/// <inheritdoc />
		public Task WriteAsync(char[] buffer, int index, int count)
		{
			return InternalInstance.WriteAsync(buffer, index, count);
		}

		/// <inheritdoc />
		public Task WriteAsync(string value)
		{
			return InternalInstance.WriteAsync(value);
		}

		/// <inheritdoc />
		public void WriteLine()
		{
			InternalInstance.WriteLine();
		}

		/// <inheritdoc />
		public void WriteLine(bool value)
		{
			InternalInstance.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(char value)
		{
			InternalInstance.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(char[] buffer)
		{
			InternalInstance.WriteLine(buffer);
		}

		/// <inheritdoc />
		public void WriteLine(char[] buffer, int index, int count)
		{
			InternalInstance.WriteLine(buffer, index, count);
		}

		/// <inheritdoc />
		public void WriteLine(decimal value)
		{
			InternalInstance.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(double value)
		{
			InternalInstance.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(int value)
		{
			InternalInstance.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(long value)
		{
			InternalInstance.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(object value)
		{
			InternalInstance.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(float value)
		{
			InternalInstance.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(string value)
		{
			InternalInstance.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(string format, params object[] arg)
		{
			InternalInstance.WriteLine(format, arg);
		}

		/// <inheritdoc />
		public void WriteLine(uint value)
		{
			InternalInstance.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(ulong value)
		{
			InternalInstance.WriteLine(value);
		}

		/// <inheritdoc />
		public Task WriteLineAsync()
		{
			return InternalInstance.WriteLineAsync();
		}

		/// <inheritdoc />
		public Task WriteLineAsync(char value)
		{
			return InternalInstance.WriteLineAsync(value);
		}

		/// <inheritdoc />
		public Task WriteLineAsync(char[] buffer)
		{
			return InternalInstance.WriteLineAsync(buffer);
		}

		/// <inheritdoc />
		public Task WriteLineAsync(char[] buffer, int index, int count)
		{
			return InternalInstance.WriteLineAsync(buffer, index, count);
		}

		/// <inheritdoc />
		public Task WriteLineAsync(string value)
		{
			return InternalInstance.WriteLineAsync(value);
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