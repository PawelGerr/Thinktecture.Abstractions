using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.IO
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