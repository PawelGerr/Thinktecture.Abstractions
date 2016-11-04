using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.IO
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