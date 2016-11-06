using System;
using System.IO;
using System.Threading.Tasks;

namespace Thinktecture.IO.Adapters
{
	public class TextReaderAdapter : ITextReader
	{
		/// <summary>Provides a TextReader with no data to read from.</summary>
		/// <filterpriority>1</filterpriority>
		public static readonly ITextReader Null = new TextReaderAdapter(TextReader.Null);

		private readonly TextReader _reader;

		public TextReaderAdapter(TextReader reader)
		{
			if (reader == null)
				throw new ArgumentNullException(nameof(reader));
			
			_reader = reader;
		}

		/// <inheritdoc />
		public void Dispose()
		{
			_reader.Dispose();
		}

		/// <inheritdoc />
		public TextReader ToImplementation()
		{
			return _reader;
		}

		/// <inheritdoc />
		public int Peek()
		{
			return _reader.Peek();
		}

		/// <inheritdoc />
		public int Read()
		{
			return _reader.Read();
		}

		/// <inheritdoc />
		public int Read(char[] buffer, int index, int count)
		{
			return _reader.Read(buffer, index, count);
		}

		/// <inheritdoc />
		public Task<int> ReadAsync(char[] buffer, int index, int count)
		{
			return _reader.ReadAsync(buffer, index, count);
		}

		/// <inheritdoc />
		public int ReadBlock(char[] buffer, int index, int count)
		{
			return _reader.ReadBlock(buffer, index, count);
		}

		/// <inheritdoc />
		public Task<int> ReadBlockAsync(char[] buffer, int index, int count)
		{
			return _reader.ReadBlockAsync(buffer, index, count);
		}

		/// <inheritdoc />
		public string ReadLine()
		{
			return _reader.ReadLine();
		}

		/// <inheritdoc />
		public Task<string> ReadLineAsync()
		{
			return _reader.ReadLineAsync();
		}

		/// <inheritdoc />
		public string ReadToEnd()
		{
			return _reader.ReadToEnd();
		}

		/// <inheritdoc />
		public Task<string> ReadToEndAsync()
		{
			return _reader.ReadToEndAsync();
		}
	}
}