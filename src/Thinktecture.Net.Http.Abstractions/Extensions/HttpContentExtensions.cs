using System.Net.Http;
using Thinktecture.Net.Http;
using Thinktecture.Net.Http.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="HttpContent"/>.
	/// </summary>
	public static class HttpContentExtensions
	{
		/// <summary>
		/// Converts provided content to <see cref="IHttpContent"/>.
		/// </summary>
		/// <param name="content">Content to convert.</param>
		/// <returns>Converted content.</returns>
		public static IHttpContent ToInterface(this HttpContent content)
		{
			return (content == null) ? null : new HttpContentAdapter(content);
		}
	}
}