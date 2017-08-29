using System.Net.Http.Headers;
using JetBrains.Annotations;
using Thinktecture.Net.Http.Headers;
using Thinktecture.Net.Http.Headers.Adapters;

// ReSharper disable once CheckNamespace
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
		[CanBeNull]
		public static IHttpRequestHeaders ToInterface([CanBeNull] this HttpRequestHeaders headers)
		{
			return (headers == null) ? null : new HttpRequestHeadersAdapter(headers);
		}

		/// <summary>
		/// Converts provided <see cref="IHttpRequestHeaders"/> info to <see cref="HttpRequestHeaders"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="IHttpRequestHeaders"/> to convert.</param>
		/// <returns>An instance of <see cref="HttpRequestHeaders"/>.</returns>
		[CanBeNull]
		public static HttpRequestHeaders ToImplementation([CanBeNull] this IHttpRequestHeaders abstraction)
		{
			return ((IAbstraction<HttpRequestHeaders>)abstraction)?.UnsafeConvert();
		}
	}
}
