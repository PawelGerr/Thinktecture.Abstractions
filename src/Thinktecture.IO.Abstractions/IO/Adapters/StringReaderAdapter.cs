using System;
using System.ComponentModel;
using System.IO;

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="StringReader"/>:
	/// </summary>
	public class StringReaderAdapter : TextReaderAdapter, IStringReader
	{
		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new StringReader InternalInstance { get; }

		/// <summary>Initializes a new instance of the <see cref="StringReaderAdapter" /> class that reads from the specified string.</summary>
		/// <param name="s">The string to which the <see cref="T:System.IO.StringReader" /> should be initialized. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="s" /> parameter is null. </exception>
		public StringReaderAdapter(string s)
			: this(new StringReader(s))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="StringReaderAdapter" /> class.
		/// </summary>
		/// <param name="reader">Reader to be used by the adapter.</param>
		public StringReaderAdapter(StringReader reader)
			: base(reader)
		{
			if (reader == null)
				throw new ArgumentNullException(nameof(reader));

			InternalInstance = reader;
		}
	}
}