using System;
using System.IO;

namespace Thinktecture.IO.Adapters
{
	public class StringReaderAdapter : TextReaderAdapter, IStringReader
	{
		private readonly StringReader _reader;

		public StringReaderAdapter(StringReader reader)
			: base(reader)
		{
			if (reader == null)
				throw new ArgumentNullException(nameof(reader));

			_reader = reader;
		}

		/// <inheritdoc />
		StringReader IStringReader.ToImplementation()
		{
			return _reader;
		}
	}
}