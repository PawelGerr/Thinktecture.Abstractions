using System;
using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="TextReader"/>.
	/// </summary>
	public static class TextReaderExtensions
	{
		/// <summary>
		/// Converts provided reader to <see cref="ITextReader"/>.
		/// </summary>
		/// <param name="reader">Reader to convert.</param>
		/// <returns>Converted reader.</returns>
		public static ITextReader ToInterface(this TextReader reader)
		{
			return (reader == null) ? null : new TextReaderAdapter(reader);
		}
	}
}
