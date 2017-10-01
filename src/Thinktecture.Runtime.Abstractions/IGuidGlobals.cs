using System;

namespace Thinktecture
{
	/// <summary>
	/// Statics of <see cref="Guid"/>
	/// </summary>
	public interface IGuidGlobals
	{
		/// <summary>A read-only instance of the <see cref="T:System.Guid" /> structure whose value is all zeros.</summary>
		/// <filterpriority>1</filterpriority>
		Guid Empty { get; }

		/// <summary>Initializes a new instance of the <see cref="T:System.Guid" /> structure.</summary>
		/// <returns>A new GUID object.</returns>
		/// <filterpriority>1</filterpriority>
		Guid NewGuid();

		/// <summary>Converts the string representation of a GUID to the equivalent <see cref="T:System.Guid" /> structure.</summary>
		/// <returns>A structure that contains the value that was parsed.</returns>
		/// <param name="input">The string to convert.</param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="input" /> is null.</exception>
		/// <exception cref="T:System.FormatException">
		/// <paramref name="input" /> is not in a recognized format.</exception>
		Guid Parse(string input);

		/// <summary>Converts the string representation of a GUID to the equivalent <see cref="T:System.Guid" /> structure, provided that the string is in the specified format.</summary>
		/// <returns>A structure that contains the value that was parsed.</returns>
		/// <param name="input">The GUID to convert.</param>
		/// <param name="format">One of the following specifiers that indicates the exact format to use when interpreting <paramref name="input" />: "N", "D", "B", "P", or "X".</param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="input" /> or <paramref name="format" /> is null.</exception>
		/// <exception cref="T:System.FormatException">
		/// <paramref name="input" /> is not in the format specified by <paramref name="format" />.</exception>
		Guid ParseExact(string input, string format);

		/// <summary>Converts the string representation of a GUID to the equivalent <see cref="T:System.Guid" /> structure. </summary>
		/// <returns>true if the parse operation was successful; otherwise, false.</returns>
		/// <param name="input">The GUID to convert.</param>
		/// <param name="result">The structure that will contain the parsed value. If the method returns true, <paramref name="result" /> contains a valid <see cref="T:System.Guid" />. If the method returns false, <paramref name="result" /> equals <see cref="F:System.Guid.Empty" />. </param>
		bool TryParse(string input, out Guid result);

		/// <summary>Converts the string representation of a GUID to the equivalent <see cref="T:System.Guid" /> structure, provided that the string is in the specified format.</summary>
		/// <returns>true if the parse operation was successful; otherwise, false.</returns>
		/// <param name="input">The GUID to convert.</param>
		/// <param name="format">One of the following specifiers that indicates the exact format to use when interpreting <paramref name="input" />: "N", "D", "B", "P", or "X".</param>
		/// <param name="result">The structure that will contain the parsed value. If the method returns true, <paramref name="result" /> contains a valid <see cref="T:System.Guid" />. If the method returns false, <paramref name="result" /> equals <see cref="F:System.Guid.Empty" />.</param>
		bool TryParseExact(string input, string format, out Guid result);
	}
}
