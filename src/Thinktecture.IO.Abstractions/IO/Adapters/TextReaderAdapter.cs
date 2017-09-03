using System;
using System.IO;
using System.Threading.Tasks;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="TextReader"/>.
	/// </summary>
	public class TextReaderAdapter : AbstractionAdapter<TextReader>, ITextReader
	{
		/// <summary>Provides a TextReader with no data to read from.</summary>
		public static readonly ITextReader Null = new TextReaderAdapter(TextReader.Null);

		/// <summary>
		/// Initializes a new instance of the <see cref="TextReaderAdapter" /> class.
		/// </summary>
		/// <param name="reader">Reader to be used by the adapter.</param>
		public TextReaderAdapter([NotNull] TextReader reader)
			: base(reader)
		{
		}

		/// <inheritdoc />
		public void Dispose()
		{
			Implementation.Dispose();
		}

		/// <inheritdoc />
		public int Peek()
		{
			return Implementation.Peek();
		}

		/// <inheritdoc />
		public int Read()
		{
			return Implementation.Read();
		}

		/// <inheritdoc />
		public int Read(char[] buffer, int index, int count)
		{
			return Implementation.Read(buffer, index, count);
		}

		/// <inheritdoc />
		public Task<int> ReadAsync(char[] buffer, int index, int count)
		{
			return Implementation.ReadAsync(buffer, index, count);
		}

		/// <inheritdoc />
		public int ReadBlock(char[] buffer, int index, int count)
		{
			return Implementation.ReadBlock(buffer, index, count);
		}

		/// <inheritdoc />
		public Task<int> ReadBlockAsync(char[] buffer, int index, int count)
		{
			return Implementation.ReadBlockAsync(buffer, index, count);
		}

		/// <inheritdoc />
		public string ReadLine()
		{
			return Implementation.ReadLine();
		}

		/// <inheritdoc />
		public Task<string> ReadLineAsync()
		{
			return Implementation.ReadLineAsync();
		}

		/// <inheritdoc />
		public string ReadToEnd()
		{
			return Implementation.ReadToEnd();
		}

		/// <inheritdoc />
		public Task<string> ReadToEndAsync()
		{
			return Implementation.ReadToEndAsync();
		}
	}
}
