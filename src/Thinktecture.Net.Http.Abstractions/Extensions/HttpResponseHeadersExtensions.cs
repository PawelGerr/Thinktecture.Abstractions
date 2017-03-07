using System.Net.Http.Headers;
using Thinktecture.Net.Http.Headers;
using Thinktecture.Net.Http.Headers.Adapters;

// ReSharper disable once CheckNamespace
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
		/// Converts provided <see cref="IHttpResponseHeaders"/> info to <see cref="HttpResponseHeaders"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="IHttpResponseHeaders"/> to convert.</param>
		/// <returns>An instance of <see cref="HttpResponseHeaders"/>.</returns>
		public static HttpResponseHeaders ToImplementation(this IHttpResponseHeaders abstraction)
		{
			return ((IAbstraction<HttpResponseHeaders>)abstraction)?.UnsafeConvert();
		}
	}
}