using System.Net.Http.Headers;
using JetBrains.Annotations;
using Thinktecture.Net.Http.Headers;
using Thinktecture.Net.Http.Headers.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="HttpHeaders"/>.
	/// </summary>
	public static class HttpHeadersExtensions
	{
		/// <summary>
		/// Converts provided headers to <see cref="IHttpHeaders"/>.
		/// </summary>
		/// <param name="headers">Headers to convert.</param>
		/// <returns>Converted headers.</returns>
		[CanBeNull]
		public static IHttpHeaders ToInterface([CanBeNull] this HttpHeaders headers)
		{
			return (headers == null) ? null : new HttpHeadersAdapter(headers);
		}
	}
}
