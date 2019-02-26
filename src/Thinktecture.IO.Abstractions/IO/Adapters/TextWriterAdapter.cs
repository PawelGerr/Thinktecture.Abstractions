using System;
using System.IO;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Thinktecture.Text;

#if NETCOREAPP2_2
using System.Threading;
#endif

// ReSharper disable AssignNullToNotNullAttribute
namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="TextWriter"/>.
	/// </summary>
	public class TextWriterAdapter : AbstractionAdapter<TextWriter>, ITextWriter
	{
		/// <summary>Provides a TextWriter with no backing store that can be written to, but not read from.</summary>
		public static readonly ITextWriter Null = new TextWriterAdapter(TextWriter.Null);

		/// <summary>
		/// Creates an instance of <see cref="TextWriterAdapter"/>.
		/// </summary>
		/// <param name="writer">write to be used by the adapter.</param>
		public TextWriterAdapter([NotNull] TextWriter writer)
			: base(writer)
		{
		}

		/// <inheritdoc />
		public void Dispose()
		{
			Implementation.Dispose();
		}

		/// <inheritdoc />
		public IEncoding Encoding => Implementation.Encoding.ToInterface();

		/// <inheritdoc />
		public IFormatProvider FormatProvider => Implementation.FormatProvider;

		/// <inheritdoc />
		public string NewLine
		{
			get => Implementation.NewLine;
			set => Implementation.NewLine = value;
		}

#if NET45 || NET462 || NETSTANDARD2_0
		/// <inheritdoc />
		public void Close()
		{
			Implementation.Close();
		}
#endif

		/// <inheritdoc />
		public void Flush()
		{
			Implementation.Flush();
		}

		/// <inheritdoc />
		public Task FlushAsync()
		{
			return Implementation.FlushAsync();
		}

#if NETCOREAPP2_2
		/// <inheritdoc />
		public void Write(ReadOnlySpan<char> value)
		{
			Implementation.Write(value);
		}

		/// <inheritdoc />
		public void WriteLine(ReadOnlySpan<char> value)
		{
			Implementation.WriteLine(value);
		}

		/// <inheritdoc />
		public Task WriteAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = default)
		{
			return Implementation.WriteAsync(buffer, cancellationToken);
		}

		/// <inheritdoc />
		public Task WriteLineAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = default)
		{
			return Implementation.WriteLineAsync(buffer, cancellationToken);
		}
#endif

		/// <inheritdoc />
		public void Write(bool value)
		{
			Implementation.Write(value);
		}

		/// <inheritdoc />
		public void Write(char value)
		{
			Implementation.Write(value);
		}

		/// <inheritdoc />
		public void Write(char[] buffer)
		{
			Implementation.Write(buffer);
		}

		/// <inheritdoc />
		public void Write(char[] buffer, int index, int count)
		{
			Implementation.Write(buffer, index, count);
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
		public void Write(object value)
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
		public void Write(string format, object arg0)
		{
			Implementation.Write(format, arg0);
		}

		/// <inheritdoc />
		public void Write(string format, object arg0, object arg1)
		{
			Implementation.Write(format, arg0, arg1);
		}

		/// <inheritdoc />
		public void Write(string format, object arg0, object arg1, object arg2)
		{
			Implementation.Write(format, arg0, arg1, arg2);
		}

		/// <inheritdoc />
		public void Write(string format, params object[] arg)
		{
			Implementation.Write(format, arg);
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
		public Task WriteAsync(char value)
		{
			return Implementation.WriteAsync(value);
		}

		/// <inheritdoc />
		public Task WriteAsync(char[] buffer)
		{
			return Implementation.WriteAsync(buffer);
		}

		/// <inheritdoc />
		public Task WriteAsync(char[] buffer, int index, int count)
		{
			return Implementation.WriteAsync(buffer, index, count);
		}

		/// <inheritdoc />
		public Task WriteAsync(string value)
		{
			return Implementation.WriteAsync(value);
		}

		/// <inheritdoc />
		public void WriteLine()
		{
			Implementation.WriteLine();
		}

		/// <inheritdoc />
		public void WriteLine(bool value)
		{
			Implementation.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(char value)
		{
			Implementation.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(char[] buffer)
		{
			Implementation.WriteLine(buffer);
		}

		/// <inheritdoc />
		public void WriteLine(char[] buffer, int index, int count)
		{
			Implementation.WriteLine(buffer, index, count);
		}

		/// <inheritdoc />
		public void WriteLine(decimal value)
		{
			Implementation.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(double value)
		{
			Implementation.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(int value)
		{
			Implementation.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(long value)
		{
			Implementation.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(object value)
		{
			Implementation.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(float value)
		{
			Implementation.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(string value)
		{
			Implementation.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(string format, object arg0)
		{
			Implementation.WriteLine(format, arg0);
		}

		/// <inheritdoc />
		public void WriteLine(string format, object arg0, object arg1)
		{
			Implementation.WriteLine(format, arg0, arg1);
		}

		/// <inheritdoc />
		public void WriteLine(string format, object arg0, object arg1, object arg2)
		{
			Implementation.WriteLine(format, arg0, arg1, arg2);
		}

		/// <inheritdoc />
		public void WriteLine(string format, params object[] arg)
		{
			Implementation.WriteLine(format, arg);
		}

		/// <inheritdoc />
		public void WriteLine(uint value)
		{
			Implementation.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(ulong value)
		{
			Implementation.WriteLine(value);
		}

		/// <inheritdoc />
		public Task WriteLineAsync()
		{
			return Implementation.WriteLineAsync();
		}

		/// <inheritdoc />
		public Task WriteLineAsync(char value)
		{
			return Implementation.WriteLineAsync(value);
		}

		/// <inheritdoc />
		public Task WriteLineAsync(char[] buffer)
		{
			return Implementation.WriteLineAsync(buffer);
		}

		/// <inheritdoc />
		public Task WriteLineAsync(char[] buffer, int index, int count)
		{
			return Implementation.WriteLineAsync(buffer, index, count);
		}

		/// <inheritdoc />
		public Task WriteLineAsync(string value)
		{
			return Implementation.WriteLineAsync(value);
		}
	}
}
