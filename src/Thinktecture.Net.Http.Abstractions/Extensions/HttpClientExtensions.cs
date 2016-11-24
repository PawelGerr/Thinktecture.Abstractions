using System.Net.Http;
using Thinktecture.Net.Http;
using Thinktecture.Net.Http.Adapters;

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
		public static IHttpClient ToInterface(this HttpClient client)
		{
			return (client == null) ? null : new HttpClientAdapter(client);
		}

		/// <summary>
		/// Converts provided client to <see cref="HttpClient"/>.
		/// </summary>
		/// <param name="client">Client to convert.</param>
		/// <returns>Converted client.</returns>
		public static HttpClient ToImplementation(this IHttpClient client)
		{
			return client?.UnsafeConvert();
		}
	}
}