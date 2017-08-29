using System.Net.Http;
using JetBrains.Annotations;
using Thinktecture.Net.Http;
using Thinktecture.Net.Http.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="HttpClient"/>.
	/// </summary>
	public static class HttpClientExtensions
	{
		/// <summary>
		/// Converts provided client to <see cref="IHttpClient"/>.
		/// </summary>
		/// <param name="client">Client to convert.</param>
		/// <returns>Converted client.</returns>
		[CanBeNull]
		public static IHttpClient ToInterface([CanBeNull] this HttpClient client)
		{
			return (client == null) ? null : new HttpClientAdapter(client);
		}

		/// <summary>
		/// Converts provided <see cref="IHttpClient"/> info to <see cref="HttpClient"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="IHttpClient"/> to convert.</param>
		/// <returns>An instance of <see cref="HttpClient"/>.</returns>
		[CanBeNull]
		public static HttpClient ToImplementation([CanBeNull] this IHttpClient abstraction)
		{
			return ((IAbstraction<HttpClient>)abstraction)?.UnsafeConvert();
		}
	}
}
