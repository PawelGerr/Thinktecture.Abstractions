using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.IO
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