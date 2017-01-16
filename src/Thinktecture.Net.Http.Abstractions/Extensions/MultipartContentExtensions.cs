using System.Net.Http;
using Thinktecture.Net.Http;
using Thinktecture.Net.Http.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="MultipartContent"/>.
	/// </summary>
	public static class MultipartContentExtensions
	{
		/// <summary>
		/// Converts provided content to <see cref="IMultipartContent"/>.
		/// </summary>
		/// <param name="content">Content to convert.</param>
		/// <returns>Converted content.</returns>
		public static IMultipartContent ToInterface(this MultipartContent content)
		{
			return (content == null) ? null : new MultipartContentAdapter(content);
		}

		/// <summary>
		/// Converts provided <see cref="IMultipartContent"/> info to <see cref="MultipartContent"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="IMultipartContent"/> to convert.</param>
		/// <returns>An instance of <see cref="MultipartContent"/>.</returns>
		public static MultipartContent ToImplementation(this IMultipartContent abstraction)
		{
			return ((IAbstraction<MultipartContent>)abstraction)?.UnsafeConvert();
		}
	}
}