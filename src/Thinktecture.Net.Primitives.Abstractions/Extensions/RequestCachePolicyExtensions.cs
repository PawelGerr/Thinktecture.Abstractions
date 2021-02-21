using System.Diagnostics.CodeAnalysis;
using System.Net.Cache;
using Thinktecture.Net.Cache;
using Thinktecture.Net.Cache.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="RequestCachePolicy"/>.
	/// </summary>
	public static class RequestCachePolicyExtensions
	{
		/// <summary>
		/// Converts provided policy to <see cref="IRequestCachePolicy"/>.
		/// </summary>
		/// <param name="collection">Policy to convert.</param>
		/// <returns>Converted policy.</returns>
      [return: NotNullIfNotNull("collection")]
		public static IRequestCachePolicy? ToInterface(this RequestCachePolicy? collection)
		{
			return collection == null ? null : new RequestCachePolicyAdapter(collection);
		}
	}
}
