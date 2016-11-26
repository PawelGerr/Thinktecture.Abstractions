using System.Net.Http.Headers;
using Thinktecture.Net.Http.Headers;
using Thinktecture.Net.Http.Headers.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="HttpRequestHeaders"/>.
	/// </summary>
	public static class HttpRequestHeadersExtensions
	{
		/// <summary>
		/// Converts provided headers to <see cref="IHttpRequestHeaders"/>.
		/// </summary>
		/// <param name="headers">Headers to convert.</param>
		/// <returns>Converted headers.</returns>
		public static IHttpRequestHeaders ToInterface(this HttpRequestHeaders headers)
		{
			return (headers == null) ? null : new HttpRequestHeadersAdapter(headers);
		}

		/// <summary>
		/// Converts provided headers to <see cref="HttpRequestHeaders"/>.
		/// </summary>
		/// <param name="headers">Headers to convert.</param>
		/// <returns>Converted headers.</returns>
		public static HttpRequestHeaders ToImplementation(this IHttpRequestHeaders headers)
		{
			return headers?.UnsafeConvert();
		}
	}
}