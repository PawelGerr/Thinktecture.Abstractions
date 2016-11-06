using System;
using System.IO;

namespace Thinktecture.IO.Adapters
{
	public class StringReaderAdapter : TextReaderAdapter, IStringReader
	{
		private readonly StringReader _reader;

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.StringReader" /> class that reads from the specified string.</summary>
		/// <param name="s">The string to which the <see cref="T:System.IO.StringReader" /> should be initialized. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="s" /> parameter is null. </exception>
		public StringReaderAdapter(string s)
			:this(new StringReader(s))
		{
		}

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