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
		string HtmlEncode(string value);

		/// <summary>
		/// Converts a string that has been HTML-encoded for HTTP transmission into a decoded string.
		/// </summary>
		/// <param name="value">The string to decode.</param>
		/// <returns>A decoded string.</returns>
		string HtmlDecode(string value);

		/// <summary>
		/// Converts a text string into a URL-encoded string.
		/// </summary>
		/// <param name="value">The text to URL-encode.</param>
		/// <returns>A URL-encoded string.</returns>
		string UrlEncode(string value);

		/// <summary>
		/// Converts a byte array into a URL-encoded byte array.
		/// </summary>
		/// <param name="value">The Byte array to URL-encode.</param>
		/// <param name="offset">The offset, in bytes, from the start of the Byte array to encode.</param>
		/// <param name="count">The count, in bytes, to encode from the Byte array.</param>
		/// <returns>An encoded Byte array.</returns>
		byte[] UrlEncodeToBytes(byte[] value, int offset, int count);

		/// <summary>
		/// Converts a string that has been encoded for transmission in a URL into a decoded string.
		/// </summary>
		/// <param name="encodedValue">A URL-encoded string to decode.</param>
		/// <returns>A decoded string.</returns>
		string UrlDecode(string encodedValue);

		/// <summary>
		/// Converts an encoded byte array that has been encoded for transmission in a URL into a decoded byte array.
		/// </summary>
		/// <param name="encodedValue">A URL-encoded Byte array to decode.</param>
		/// <param name="offset">The offset, in bytes, from the start of the Byte array to decode.</param>
		/// <param name="count">The count, in bytes, to decode from the Byte array.</param>
		/// <returns>A decoded Byte array.</returns>
		byte[] UrlDecodeToBytes(byte[] encodedValue, int offset, int count);
	}
}
