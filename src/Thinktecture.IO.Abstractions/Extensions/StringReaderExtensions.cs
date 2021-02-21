using System.Diagnostics.CodeAnalysis;
using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="StringReader"/>.
	/// </summary>
	public static class StringReaderExtensions
	{
		/// <summary>
		/// Converts provided reader to <see cref="IStringReader"/>.
		/// </summary>
		/// <param name="reader">Reader to convert.</param>
		/// <returns>Converted reader.</returns>
      [return: NotNullIfNotNull("reader")]
      public static IStringReader? ToInterface(this StringReader? reader)
		{
			return reader == null ? null : new StringReaderAdapter(reader);
		}

		/// <summary>
		/// Converts provided <see cref="IStringReader"/> info to <see cref="StringReader"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="IStringReader"/> to convert.</param>
		/// <returns>An instance of <see cref="StringReader"/>.</returns>
      [return: NotNullIfNotNull("abstraction")]
      public static StringReader? ToImplementation(this IStringReader? abstraction)
		{
			return ((IAbstraction<StringReader>?)abstraction)?.UnsafeConvert();
		}
	}
}
