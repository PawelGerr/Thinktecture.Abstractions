using System.Net.Http;
using JetBrains.Annotations;
using Thinktecture.Net.Http;
using Thinktecture.Net.Http.Adapters;

// ReSharper disable once CheckNamespace
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
		[CanBeNull]
		public static IMultipartFormDataContent ToInterface([CanBeNull] this MultipartFormDataContent headers)
		{
			return (headers == null) ? null : new MultipartFormDataContentAdapter(headers);
		}

		/// <summary>
		/// Converts provided <see cref="IMultipartFormDataContent"/> info to <see cref="MultipartFormDataContent"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="IMultipartFormDataContent"/> to convert.</param>
		/// <returns>An instance of <see cref="MultipartFormDataContent"/>.</returns>
		[CanBeNull]
		public static MultipartFormDataContent ToImplementation([CanBeNull] this IMultipartFormDataContent abstraction)
		{
			return ((IAbstraction<MultipartFormDataContent>)abstraction)?.UnsafeConvert();
		}
	}
}
