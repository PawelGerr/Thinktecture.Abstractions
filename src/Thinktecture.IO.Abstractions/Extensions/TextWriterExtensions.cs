using System;
using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="TextWriter"/>.
	/// </summary>
	public static class TextWriterExtensions
	{
		/// <summary>
		/// Converts writer to <see cref="ITextWriter"/>.
		/// </summary>
		/// <param name="writer">Writer to convert.</param>
		/// <returns>Converted writer.</returns>
		public static ITextWriter ToInterface(this TextWriter writer)
		{
			return (writer == null) ? null : new TextWriterAdapter(writer);
		}

		/// <summary>
		/// Converts writer to <see cref="TextWriter"/>.
		/// </summary>
		/// <param name="writer">Writer to convert.</param>
		/// <returns>Converted writer.</returns>
		public static TextWriter ToImplementation(this ITextWriter writer)
		{
			return writer?.UnsafeConvert();
		}
	}
}