using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.IO.Extensions
{
	public static class TextWriterExtensions
	{
		/// <summary>
		/// Converts writer to <see cref="ITextWriter"/>.
		/// </summary>
		/// <param name="writer">Writer to convert.</param>
		/// <returns>Converted writer.</returns>
		public static ITextWriter ToInterface(this TextWriter writer)
		{
			return new TextWriterAdapter(writer);
		}
	}
}