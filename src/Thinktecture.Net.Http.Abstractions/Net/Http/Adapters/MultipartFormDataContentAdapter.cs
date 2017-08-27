using System.ComponentModel;
using System.Net.Http;

namespace Thinktecture.Net.Http.Adapters
{
	/// <summary>Provides a container for content encoded using multipart/form-data MIME type.</summary>
	public class MultipartFormDataContentAdapter : MultipartContentAdapter, IMultipartFormDataContent
	{
		private readonly MultipartFormDataContent _content;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new MultipartFormDataContent UnsafeConvert()
		{
			return _content;
		}

		/// <summary>Creates a new instance of the <see cref="T:System.Net.Http.MultipartFormDataContent" /> class.</summary>
		public MultipartFormDataContentAdapter()
			: this(new MultipartFormDataContent())
		{
		}

		/// <summary>Creates a new instance of the <see cref="T:System.Net.Http.MultipartFormDataContent" /> class.</summary>
		/// <param name="boundary">The boundary string for the multipart form data content.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="boundary" /> was null or contains only white space characters.-or-The <paramref name="boundary" /> ends with a space character.</exception>
		/// <exception cref="T:System.OutOfRangeException">The length of the <paramref name="boundary" /> was greater than 70.</exception>
		public MultipartFormDataContentAdapter(string boundary)
			: this(new MultipartFormDataContent(boundary))
		{
		}

		/// <summary>Creates a new instance of the <see cref="MultipartFormDataContentAdapter" /> class.</summary>
		/// <param name="content">The implementation to use by the adapter.</param>
		public MultipartFormDataContentAdapter(MultipartFormDataContent content)
			: base(content)
		{
			_content = content;
		}

		/// <summary>Add HTTP content to a collection of <see cref="T:System.Net.Http.HttpContent" /> objects that get serialized to multipart/form-data MIME type.</summary>
		/// <param name="content">The HTTP content to add to the collection.</param>
		/// <param name="name">The name for the HTTP content to add.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="name" /> was null or contains only white space characters.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="content" /> was null.</exception>
		public void Add(HttpContent content, string name)
		{
			_content.Add(content, name);
		}

		/// <summary>Add HTTP content to a collection of <see cref="T:System.Net.Http.HttpContent" /> objects that get serialized to multipart/form-data MIME type.</summary>
		/// <param name="content">The HTTP content to add to the collection.</param>
		/// <param name="name">The name for the HTTP content to add.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="name" /> was null or contains only white space characters.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="content" /> was null.</exception>
		public void Add(IHttpContent content, string name)
		{
			_content.Add(content.ToImplementation(), name);
		}

		/// <summary>Add HTTP content to a collection of <see cref="T:System.Net.Http.HttpContent" /> objects that get serialized to multipart/form-data MIME type.</summary>
		/// <param name="content">The HTTP content to add to the collection.</param>
		/// <param name="name">The name for the HTTP content to add.</param>
		/// <param name="fileName">The file name for the HTTP content to add to the collection.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="name" /> was null or contains only white space characters.-or-The <paramref name="fileName" /> was null or contains only white space characters.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="content" /> was null.</exception>
		public void Add(HttpContent content, string name, string fileName)
		{
			_content.Add(content, name, fileName);
		}

		/// <summary>Add HTTP content to a collection of <see cref="T:System.Net.Http.HttpContent" /> objects that get serialized to multipart/form-data MIME type.</summary>
		/// <param name="content">The HTTP content to add to the collection.</param>
		/// <param name="name">The name for the HTTP content to add.</param>
		/// <param name="fileName">The file name for the HTTP content to add to the collection.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="name" /> was null or contains only white space characters.-or-The <paramref name="fileName" /> was null or contains only white space characters.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="content" /> was null.</exception>
		public void Add(IHttpContent content, string name, string fileName)
		{
			_content.Add(content.ToImplementation(), name, fileName);
		}
	}
}
