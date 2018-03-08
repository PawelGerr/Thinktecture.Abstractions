using JetBrains.Annotations;
#if NET45 || NET462 || NETSTANDARD2_0
using System.IO;

#endif

namespace Thinktecture.Net
{
	/// <summary>
	/// Provides methods for encoding and decoding URLs when processing Web requests.
	/// </summary>
	public interface IWebUtility
	{
		/// <summary>
		/// Converts a string to an HTML-encoded string.
		/// </summary>
		/// <param name="value">The string to encode.</param>
		/// <returns>An encoded string.</returns>
		[CanBeNull]
		string HtmlEncode([CanBeNull] string value);

		/// <summary>
		/// Converts a string that has been HTML-encoded for HTTP transmission into a decoded string.
		/// </summary>
		/// <param name="value">The string to decode.</param>
		/// <returns>A decoded string.</returns>
		[CanBeNull]
		string HtmlDecode([CanBeNull] string value);

		/// <summary>
		/// Converts a text string into a URL-encoded string.
		/// </summary>
		/// <param name="value">The text to URL-encode.</param>
		/// <returns>A URL-encoded string.</returns>
		[CanBeNull]
		string UrlEncode([CanBeNull] string value);

		/// <summary>
		/// Converts a byte array into a URL-encoded byte array.
		/// </summary>
		/// <param name="value">The Byte array to URL-encode.</param>
		/// <param name="offset">The offset, in bytes, from the start of the Byte array to encode.</param>
		/// <param name="count">The count, in bytes, to encode from the Byte array.</param>
		/// <returns>An encoded Byte array.</returns>
		[NotNull]
		byte[] UrlEncodeToBytes([NotNull] byte[] value, int offset, int count);

		/// <summary>
		/// Converts a string that has been encoded for transmission in a URL into a decoded string.
		/// </summary>
		/// <param name="encodedValue">A URL-encoded string to decode.</param>
		/// <returns>A decoded string.</returns>
		[CanBeNull]
		string UrlDecode([CanBeNull] string encodedValue);

		/// <summary>
		/// Converts an encoded byte array that has been encoded for transmission in a URL into a decoded byte array.
		/// </summary>
		/// <param name="encodedValue">A URL-encoded Byte array to decode.</param>
		/// <param name="offset">The offset, in bytes, from the start of the Byte array to decode.</param>
		/// <param name="count">The count, in bytes, to decode from the Byte array.</param>
		/// <returns>A decoded Byte array.</returns>
		[NotNull]
		byte[] UrlDecodeToBytes([NotNull] byte[] encodedValue, int offset, int count);

#if NET45 || NET462 || NETSTANDARD2_0
		/// <summary>Converts a string into an HTML-encoded string, and returns the output as a <see cref="T:System.IO.TextWriter" /> stream of output.</summary>
		/// <param name="value">The string to encode.</param>
		/// <param name="output">A <see cref="T:System.IO.TextWriter" /> output stream.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="output" /> parameter cannot be null if the <paramref name="value" /> parameter is not null.  </exception>
		void HtmlEncode(string value, TextWriter output);

		/// <summary>Converts a string that has been HTML-encoded into a decoded string, and sends the decoded string to a <see cref="T:System.IO.TextWriter" /> output stream.</summary>
		/// <param name="value">The string to decode.</param>
		/// <param name="output">A <see cref="T:System.IO.TextWriter" /> stream of output.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="output" /> parameter cannot be null if the <paramref name="value" /> parameter is not null.  </exception>
		void HtmlDecode(string value, TextWriter output);
#endif
	}
}
