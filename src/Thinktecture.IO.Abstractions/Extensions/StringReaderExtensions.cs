using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

namespace Thinktecture
{
	public static class StringReaderExtensions
	{
		/// <summary>
		/// Converts provided reader to <see cref="IStringReader"/>.
		/// </summary>
		/// <param name="reader">Reader to convert.</param>
		/// <returns>Converted reader.</returns>
		public static IStringReader ToInterface(this StringReader reader)
		{
			return new StringReaderAdapter(reader);
		}
	}
}