using System;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="TextReader"/>.
	/// </summary>
	public class TextReaderAdapter : AbstractionAdapter, ITextReader
	{
		/// <summary>Provides a TextReader with no data to read from.</summary>
		/// <filterpriority>1</filterpriority>
		public static readonly ITextReader Null = new TextReaderAdapter(TextReader.Null);

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new TextReader UnsafeConvert()
		{
			return _instance;
		}

		private readonly TextReader _instance;

		/// <summary>
		/// Initializes a new instance of the <see cref="TextReaderAdapter" /> class.
		/// </summary>
		/// <param name="reader">Reader to be used by the adapter.</param>
		public TextReaderAdapter(TextReader reader)
			: base(reader)
		{
			_instance = reader ?? throw new ArgumentNullException(nameof(reader));
		}

		/// <inheritdoc />
		public void Dispose()
		{
			_instance.Dispose();
		}

		/// <inheritdoc />
		public int Peek()
		{
			return _instance.Peek();
		}

		/// <inheritdoc />
		public int Read()
		{
			return _instance.Read();
		}

		/// <inheritdoc />
		public int Read(char[] buffer, int index, int count)
		{
			return _instance.Read(buffer, index, count);
		}

		/// <inheritdoc />
		public Task<int> ReadAsync(char[] buffer, int index, int count)
		{
			return _instance.ReadAsync(buffer, index, count);
		}

		/// <inheritdoc />
		public int ReadBlock(char[] buffer, int index, int count)
		{
			return _instance.ReadBlock(buffer, index, count);
		}

		/// <inheritdoc />
		public Task<int> ReadBlockAsync(char[] buffer, int index, int count)
		{
			return _instance.ReadBlockAsync(buffer, index, count);
		}

		/// <inheritdoc />
		public string ReadLine()
		{
			return _instance.ReadLine();
		}

		/// <inheritdoc />
		public Task<string> ReadLineAsync()
		{
			return _instance.ReadLineAsync();
		}

		/// <inheritdoc />
		public string ReadToEnd()
		{
			return _instance.ReadToEnd();
		}

		/// <inheritdoc />
		public Task<string> ReadToEndAsync()
		{
			return _instance.ReadToEndAsync();
		}
	}
}
