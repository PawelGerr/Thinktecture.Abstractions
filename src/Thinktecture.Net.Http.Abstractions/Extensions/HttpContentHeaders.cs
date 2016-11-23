using System.Net.Http.Headers;
using Thinktecture.Net.Http;
using Thinktecture.Net.Http.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="HttpContentHeaders"/>.
	/// </summary>
	public static class HttpContentHeadersExtensions
	{
		/// <summary>
		/// Converts provided headers to <see cref="IHttpContentHeaders"/>.
		/// </summary>
		/// <param name="headers">Headers to convert.</param>
		/// <returns>Converted headers.</returns>
		public static IHttpContentHeaders ToInterface(this HttpContentHeaders headers)
		{
			return (headers == null) ? null : new HttpContentHeadersAdapter(headers);
		}

		/// <summary>
		/// Converts provided headers to <see cref="HttpContentHeaders"/>.
		/// </summary>
		/// <param name="headers">Headers to convert.</param>
		/// <returns>Converted headers.</returns>
		public static HttpContentHeaders ToImplementation(this IHttpContentHeaders headers)
		{
			return headers?.UnsafeConvert();
		}
	}
}