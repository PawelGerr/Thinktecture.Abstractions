using System.Net.Http;
using Thinktecture.Net.Http;
using Thinktecture.Net.Http.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="HttpClientHandler"/>.
	/// </summary>
	public static class HttpClientHandlerExtensions
	{
		/// <summary>
		/// Converts provided handler to <see cref="IHttpClientHandler"/>.
		/// </summary>
		/// <param name="handler">Handler to convert.</param>
		/// <returns>Converted handler.</returns>
		public static IHttpClientHandler ToInterface(this HttpClientHandler handler)
		{
			return (handler == null) ? null : new HttpClientHandlerAdapter(handler);
		}

		/// <summary>
		/// Converts provided <see cref="IHttpClientHandler"/> info to <see cref="HttpClientHandler"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="IHttpClientHandler"/> to convert.</param>
		/// <returns>An instance of <see cref="HttpClientHandler"/>.</returns>
		public static HttpClientHandler ToImplementation(this IHttpClientHandler abstraction)
		{
			return ((IAbstraction<HttpClientHandler>)abstraction)?.UnsafeConvert();
		}
	}
}