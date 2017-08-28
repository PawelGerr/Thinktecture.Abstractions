using System.Net;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.Adapters
{
	/// <summary>
	/// Adapter for <see cref="WebUtility"/>.
	/// </summary>
	public class WebUtilityAdapter : IWebUtility
	{
		/// <inheritdoc />
		public string HtmlEncode(string value)
		{
			return WebUtility.HtmlEncode(value);
		}

		/// <inheritdoc />
		public string HtmlDecode(string value)
		{
			return WebUtility.HtmlDecode(value);
		}

		/// <inheritdoc />
		public string UrlEncode(string value)
		{
			return WebUtility.UrlEncode(value);
		}

		/// <inheritdoc />
		public byte[] UrlEncodeToBytes(byte[] value, int offset, int count)
		{
			return WebUtility.UrlEncodeToBytes(value, offset, count);
		}

		/// <inheritdoc />
		public string UrlDecode(string encodedValue)
		{
			return WebUtility.UrlDecode(encodedValue);
		}

		/// <inheritdoc />
		public byte[] UrlDecodeToBytes(byte[] encodedValue, int offset, int count)
		{
			return WebUtility.UrlDecodeToBytes(encodedValue, offset, count);
		}
	}
}
