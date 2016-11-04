using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

namespace Thinktecture
{
	public static class TextReaderExtensions
	{
		/// <summary>
		/// Converts provided reader to <see cref="ITextReader"/>.
		/// </summary>
		/// <param name="reader">Reader to convert.</param>
		/// <returns>Converted reader.</returns>
		public static ITextReader ToInterface(this TextReader reader)
		{
			return new TextReaderAdapter(reader);
		}
	}
}