using System;
using System.IO;
using JetBrains.Annotations;
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
		[CanBeNull]
		public static ITextReader ToInterface([CanBeNull] this TextReader reader)
		{
			if (reader == null)
				return null;

			if (ReferenceEquals(reader, TextReader.Null))
				return TextReaderAdapter.Null;

			return new TextReaderAdapter(reader);
		}
	}
}
