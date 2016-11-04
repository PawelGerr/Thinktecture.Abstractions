using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

namespace Thinktecture
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