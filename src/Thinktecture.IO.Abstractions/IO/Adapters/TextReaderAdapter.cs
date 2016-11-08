using System;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="TextReader"/>.
	/// </summary>
	public class TextReaderAdapter : ITextReader
	{
		/// <summary>Provides a TextReader with no data to read from.</summary>
		/// <filterpriority>1</filterpriority>
		public static readonly ITextReader Null = new TextReaderAdapter(TextReader.Null);

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public TextReader InternalInstance { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="TextReaderAdapter" /> class.
		/// </summary>
		/// <param name="reader">Reader to be used by the adapter.</param>
		public TextReaderAdapter(TextReader reader)
		{
			if (reader == null)
				throw new ArgumentNullException(nameof(reader));
			
			InternalInstance = reader;
		}

		/// <inheritdoc />
		public void Dispose()
		{
			InternalInstance.Dispose();
		}
		
		/// <inheritdoc />
		public int Peek()
		{
			return InternalInstance.Peek();
		}

		/// <inheritdoc />
		public int Read()
		{
			return InternalInstance.Read();
		}

		/// <inheritdoc />
		public int Read(char[] buffer, int index, int count)
		{
			return InternalInstance.Read(buffer, index, count);
		}

		/// <inheritdoc />
		public Task<int> ReadAsync(char[] buffer, int index, int count)
		{
			return InternalInstance.ReadAsync(buffer, index, count);
		}

		/// <inheritdoc />
		public int ReadBlock(char[] buffer, int index, int count)
		{
			return InternalInstance.ReadBlock(buffer, index, count);
		}

		/// <inheritdoc />
		public Task<int> ReadBlockAsync(char[] buffer, int index, int count)
		{
			return InternalInstance.ReadBlockAsync(buffer, index, count);
		}

		/// <inheritdoc />
		public string ReadLine()
		{
			return InternalInstance.ReadLine();
		}

		/// <inheritdoc />
		public Task<string> ReadLineAsync()
		{
			return InternalInstance.ReadLineAsync();
		}

		/// <inheritdoc />
		public string ReadToEnd()
		{
			return InternalInstance.ReadToEnd();
		}

		/// <inheritdoc />
		public Task<string> ReadToEndAsync()
		{
			return InternalInstance.ReadToEndAsync();
		}
	}
}