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
		/// Converts provided content to <see cref="MultipartContent"/>.
		/// </summary>
		/// <param name="content">Content to convert.</param>
		/// <returns>Converted content.</returns>
		public static MultipartContent ToImplementation(this IMultipartContent content)
		{
			return content?.UnsafeConvert();
		}
	}
}