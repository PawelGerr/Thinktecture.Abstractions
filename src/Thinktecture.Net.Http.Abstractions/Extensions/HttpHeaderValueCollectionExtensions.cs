using System.Net.Http.Headers;
using JetBrains.Annotations;
using Thinktecture.Net.Http.Headers;
using Thinktecture.Net.Http.Headers.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for HttpHeaderValueCollection/>.
	/// </summary>
	public static class HttpHeaderValueCollectionExtensions
	{
		/// <summary>
		/// Converts provided http header value collection to <see cref="IHttpHeaderValueCollection{T}" />/>.
		/// </summary>
		/// <typeparam name="T">The header collection type.</typeparam>
		/// <param name="valueCollection">Http header value collection to convert.</param>
		/// <returns>Converted http header value collection.</returns>
		[CanBeNull]
		public static IHttpHeaderValueCollection<T> ToInterface<T>([CanBeNull] this HttpHeaderValueCollection<T> valueCollection)
			where T : class
		{
			return valueCollection == null ? null : new HttpHeaderValueCollectionAdapter<T>(valueCollection);
		}
	}
}
