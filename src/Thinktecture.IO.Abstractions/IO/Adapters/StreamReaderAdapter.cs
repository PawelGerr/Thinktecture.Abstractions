using System;
using System.IO;
using System.Text;

namespace Thinktecture.IO.Adapters
{
	public class StreamReaderAdapter : TextReaderAdapter, IStreamReader
	{
		private readonly StreamReader _reader;

		public StreamReaderAdapter(StreamReader reader)
			: base(reader)
		{
			if (reader == null)
				throw new ArgumentNullException(nameof(reader));

			_reader = reader;
		}

		/// <inheritdoc />
		StreamReader IStreamReader.ToImplementation()
		{
			return _reader;
		}

		/// <inheritdoc />
		public IStream BaseStream => _reader.BaseStream.ToInterface();

		/// <inheritdoc />
		public Encoding CurrentEncoding => _reader.CurrentEncoding;

		/// <inheritdoc />
		public bool EndOfStream => _reader.EndOfStream;

		/// <inheritdoc />
		public void DiscardBufferedData()
		{
			_reader.DiscardBufferedData();
		}
	}
}