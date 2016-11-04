using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

namespace Thinktecture
{
	public static class StreamWriterExtensions
	{
		/// <summary>
		/// Converts provided writer to <see cref="IStreamWriter"/>.
		/// </summary>
		/// <param name="writer">Writer to convert.</param>
		/// <returns>Converted writer.</returns>
		public static IStreamWriter ToInterface(this StreamWriter writer)
		{
			return new StreamWriterAdapter(writer);
		}
	}
}