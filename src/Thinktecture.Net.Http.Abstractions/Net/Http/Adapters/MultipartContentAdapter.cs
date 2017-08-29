using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.Http.Adapters
{
	/// <summary>Provides a collection of <see cref="T:System.Net.Http.HttpContent" /> objects that get serialized using the multipart/* content type specification.</summary>
	public class MultipartContentAdapter : HttpContentAdapter, IMultipartContent
	{
		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		[NotNull]
		protected new MultipartContent Implementation { get; }

		/// <summary>Creates a new instance of the <see cref="MultipartContentAdapter" /> class.</summary>
		public MultipartContentAdapter()
			: this(new MultipartContent())
		{
		}

		/// <summary>Creates a new instance of the <see cref="MultipartContentAdapter" /> class.</summary>
		/// <param name="subtype">The subtype of the multipart content.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="subtype" /> was null or contains only white space characters.</exception>
		public MultipartContentAdapter([NotNull] string subtype)
			: this(new MultipartContent(subtype))

		{
		}

		/// <summary>Creates a new instance of the <see cref="MultipartContentAdapter" /> class.</summary>
		/// <param name="subtype">The subtype of the multipart content.</param>
		/// <param name="boundary">The boundary string for the multipart content.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="subtype" /> was null or an empty string.The <paramref name="boundary" /> was null or contains only white space characters.-or-The <paramref name="boundary" /> ends with a space character.</exception>
		/// <exception cref="T:System.OutOfRangeException">The length of the <paramref name="boundary" /> was greater than 70.</exception>
		public MultipartContentAdapter([NotNull] string subtype, [NotNull] string boundary)
			: this(new MultipartContent(subtype, boundary))
		{
		}

		/// <summary>Creates a new instance of the <see cref="MultipartContentAdapter" /> class.</summary>
		/// <param name="content">The implementation to use by the adapter.</param>
		public MultipartContentAdapter([NotNull] MultipartContent content)
			: base(content)
		{
			Implementation = content;
		}

		/// <inheritdoc />
		[NotNull, EditorBrowsable(EditorBrowsableState.Never)]
		public new MultipartContent UnsafeConvert()
		{
			return Implementation;
		}

		/// <inheritdoc />
		public void Add(HttpContent content)
		{
			Implementation.Add(content);
		}

		/// <inheritdoc />
		public void Add(IHttpContent content)
		{
			Implementation.Add(content.ToImplementation());
		}

		/// <inheritdoc />
		public IEnumerator<IHttpContent> GetEnumerator()
		{
			foreach (var content in Implementation)
			{
				yield return content.ToInterface();
			}
		}

		/// <inheritdoc />
		[NotNull]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
