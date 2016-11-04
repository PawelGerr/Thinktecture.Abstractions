using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.IO
{
	public static class StringWriterExtensions
	{
		/// <summary>
		/// Converts provided writer to <see cref="IStringWriter"/>.
		/// </summary>
		/// <param name="writer">Writer to convert.</param>
		/// <returns>Converted writer.</returns>
		public static IStringWriter ToInterface(this StringWriter writer)
		{
			return new StringWriterAdapter(writer);
		}
	}
}