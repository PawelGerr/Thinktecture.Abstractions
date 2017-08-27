using System.Net.Http.Headers;
using Thinktecture.Net.Http.Headers;
using Thinktecture.Net.Http.Headers.Adapters;

// ReSharper disable once CheckNamespace
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
		/// Converts provided <see cref="IHttpContentHeaders"/> info to <see cref="HttpContentHeaders"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="IHttpContentHeaders"/> to convert.</param>
		/// <returns>An instance of <see cref="HttpContentHeaders"/>.</returns>
		public static HttpContentHeaders ToImplementation(this IHttpContentHeaders abstraction)
		{
			return ((IAbstraction<HttpContentHeaders>)abstraction)?.UnsafeConvert();
		}
	}
}
