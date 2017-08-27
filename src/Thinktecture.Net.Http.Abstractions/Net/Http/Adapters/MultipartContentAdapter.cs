using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;

namespace Thinktecture.Net.Http.Adapters
{
	/// <summary>Provides a collection of <see cref="T:System.Net.Http.HttpContent" /> objects that get serialized using the multipart/* content type specification.</summary>
	public class MultipartContentAdapter : HttpContentAdapter, IMultipartContent
	{
		private readonly MultipartContent _content;

		/// <summary>Creates a new instance of the <see cref="MultipartContentAdapter" /> class.</summary>
		public MultipartContentAdapter()
			: this(new MultipartContent())
		{
		}

		/// <summary>Creates a new instance of the <see cref="MultipartContentAdapter" /> class.</summary>
		/// <param name="subtype">The subtype of the multipart content.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="subtype" /> was null or contains only white space characters.</exception>
		public MultipartContentAdapter(string subtype)
			: this(new MultipartContent(subtype))

		{
		}

		/// <summary>Creates a new instance of the <see cref="MultipartContentAdapter" /> class.</summary>
		/// <param name="subtype">The subtype of the multipart content.</param>
		/// <param name="boundary">The boundary string for the multipart content.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="subtype" /> was null or an empty string.The <paramref name="boundary" /> was null or contains only white space characters.-or-The <paramref name="boundary" /> ends with a space character.</exception>
		/// <exception cref="T:System.OutOfRangeException">The length of the <paramref name="boundary" /> was greater than 70.</exception>
		public MultipartContentAdapter(string subtype, string boundary)
			: this(new MultipartContent(subtype, boundary))
		{
		}

		/// <summary>Creates a new instance of the <see cref="MultipartContentAdapter" /> class.</summary>
		public MultipartContentAdapter(MultipartContent content)
			: base(content)
		{
			_content = content;
		}

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new MultipartContent UnsafeConvert()
		{
			return _content;
		}

		/// <inheritdoc />
		public void Add(HttpContent content)
		{
			_content.Add(content);
		}

		/// <inheritdoc />
		public void Add(IHttpContent content)
		{
			_content.Add(content.ToImplementation());
		}

		/// <inheritdoc />
		public IEnumerator<IHttpContent> GetEnumerator()
		{
			foreach (var content in _content)
			{
				yield return content.ToInterface();
			}
		}

		/// <inheritdoc />
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
