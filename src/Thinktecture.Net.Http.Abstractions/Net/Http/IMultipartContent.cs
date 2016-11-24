using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;

namespace Thinktecture.Net.Http
{
	/// <summary>Provides a collection of <see cref="T:System.Net.Http.HttpContent" /> objects that get serialized using the multipart/* content type specification.</summary>
	public interface IMultipartContent : IHttpContent, IEnumerable<IHttpContent>
	{
		/// <summary>
		/// Gets inner instance of <see cref="MultipartContent"/>.
		/// It is not intended to be used directly. Use <see cref="MultipartContentExtensions.ToImplementation"/> instead.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		new MultipartContent UnsafeConvert();

		/// <summary>Add multipart HTTP content to a collection of <see cref="T:System.Net.Http.HttpContent" /> objects that get serialized using the multipart/* content type specification.</summary>
		/// <param name="content">The HTTP content to add to the collection.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="content" /> was null.</exception>
		void Add(HttpContent content);

		/// <summary>Add multipart HTTP content to a collection of <see cref="T:System.Net.Http.HttpContent" /> objects that get serialized using the multipart/* content type specification.</summary>
		/// <param name="content">The HTTP content to add to the collection.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="content" /> was null.</exception>
		void Add(IHttpContent content);
	}
}