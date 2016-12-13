using System.Net.Http;
using Thinktecture.Net.Http;
using Thinktecture.Net.Http.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="MultipartFormDataContent"/>.
	/// </summary>
	public static class MultipartFormDataContentExtensions
	{
		/// <summary>
		/// Converts provided content to <see cref="IMultipartFormDataContent"/>.
		/// </summary>
		/// <param name="headers">Content to convert.</param>
		/// <returns>Converted content.</returns>
		public static IMultipartFormDataContent ToInterface(this MultipartFormDataContent headers)
		{
			return (headers == null) ? null : new MultipartFormDataContentAdapter(headers);
		}
	}
}