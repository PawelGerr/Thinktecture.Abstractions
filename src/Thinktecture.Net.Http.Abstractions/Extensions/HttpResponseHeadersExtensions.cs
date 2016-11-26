using System.Net.Http.Headers;
using Thinktecture.Net.Http.Headers;
using Thinktecture.Net.Http.Headers.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="HttpResponseHeaders"/>.
	/// </summary>
	public static class HttpResponseHeadersExtensions
	{
		/// <summary>
		/// Converts provided headers to <see cref="IHttpResponseHeaders"/>.
		/// </summary>
		/// <param name="headers">Headers to convert.</param>
		/// <returns>Converted headers.</returns>
		public static IHttpResponseHeaders ToInterface(this HttpResponseHeaders headers)
		{
			return (headers == null) ? null : new HttpResponseHeadersAdapter(headers);
		}

		/// <summary>
		/// Converts provided headers to <see cref="HttpResponseHeaders"/>.
		/// </summary>
		/// <param name="headers">Headers to convert.</param>
		/// <returns>Converted headers.</returns>
		public static HttpResponseHeaders ToImplementation(this IHttpResponseHeaders headers)
		{
			return headers?.UnsafeConvert();
		}
	}
}