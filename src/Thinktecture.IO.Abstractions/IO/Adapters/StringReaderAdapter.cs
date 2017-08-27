using System;
using System.ComponentModel;
using System.IO;
using JetBrains.Annotations;

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="StringReader"/>:
	/// </summary>
	public class StringReaderAdapter : TextReaderAdapter, IStringReader
	{
		/// <inheritdoc />
		[NotNull]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new StringReader UnsafeConvert()
		{
			return Implementation;
		}

		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		[NotNull]
		protected new StringReader Implementation { get; }

		/// <summary>Initializes a new instance of the <see cref="StringReaderAdapter" /> class that reads from the specified string.</summary>
		/// <param name="s">The string to which the <see cref="T:System.IO.StringReader" /> should be initialized. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="s" /> parameter is null. </exception>
		public StringReaderAdapter([NotNull] string s)
			: this(new StringReader(s))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="StringReaderAdapter" /> class.
		/// </summary>
		/// <param name="reader">Reader to be used by the adapter.</param>
		public StringReaderAdapter([NotNull] StringReader reader)
			: base(reader)
		{
			Implementation = reader ?? throw new ArgumentNullException(nameof(reader));
		}
	}
}
