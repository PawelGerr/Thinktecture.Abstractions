using System.Net.Http.Headers;
using Thinktecture.Net.Http;
using Thinktecture.Net.Http.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="HttpHeaders"/>.
	/// </summary>
	public static class HttpHeadersExtensions
	{
		/// <summary>
		/// Converts provided headers to <see cref="IHttpHeaders"/>.
		/// </summary>
		/// <param name="headers">Headers to convert.</param>
		/// <returns>Converted headers.</returns>
		public static IHttpHeaders ToInterface(this HttpHeaders headers)
		{
			return (headers == null) ? null : new HttpHeadersAdapter(headers);
		}

		/// <summary>
		/// Converts provided headers to <see cref="HttpHeaders"/>.
		/// </summary>
		/// <param name="headers">Headers to convert.</param>
		/// <returns>Converted headers.</returns>
		public static HttpHeaders ToImplementation(this IHttpHeaders headers)
		{
			return headers?.UnsafeConvert();
		}
	}
}