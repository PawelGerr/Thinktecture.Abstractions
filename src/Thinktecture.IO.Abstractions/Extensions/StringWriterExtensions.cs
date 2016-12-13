using System;
using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="StringWriter"/>.
	/// </summary>
	public static class StringWriterExtensions
	{
		/// <summary>
		/// Converts provided writer to <see cref="IStringWriter"/>.
		/// </summary>
		/// <param name="writer">Writer to convert.</param>
		/// <returns>Converted writer.</returns>
		public static IStringWriter ToInterface(this StringWriter writer)
		{
			return (writer == null) ? null : new StringWriterAdapter(writer);
		}
	}
}