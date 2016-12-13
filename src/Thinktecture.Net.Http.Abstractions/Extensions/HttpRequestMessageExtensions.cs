using System.Net.Http;
using Thinktecture.Net.Http;
using Thinktecture.Net.Http.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="HttpRequestMessage"/>.
	/// </summary>
	public static class HttpRequestMessageExtensions
	{
		/// <summary>
		/// Converts provided message to <see cref="IHttpRequestMessage"/>.
		/// </summary>
		/// <param name="message">Message to convert.</param>
		/// <returns>Converted message.</returns>
		public static IHttpRequestMessage ToInterface(this HttpRequestMessage message)
		{
			return (message == null) ? null : new HttpRequestMessageAdapter(message);
		}
	}
}