using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http.Headers;

namespace Thinktecture.Net.Http.Headers.Adapters
{
	/// <summary>Represents the collection of Content Headers as defined in RFC 2616.</summary>
	public class HttpContentHeadersAdapter : HttpHeadersAdapter, IHttpContentHeaders
	{
		private readonly HttpContentHeaders _headers;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new HttpContentHeaders UnsafeConvert()
		{
			return _headers;
		}

		/// <inheritdoc />
		public ICollection<string> Allow => _headers.Allow;

		/// <inheritdoc />
		public ContentDispositionHeaderValue ContentDisposition
		{
			get => _headers.ContentDisposition;
			set => _headers.ContentDisposition = value;
		}

		/// <inheritdoc />
		public ICollection<string> ContentEncoding => _headers.ContentEncoding;

		/// <inheritdoc />
		public ICollection<string> ContentLanguage => _headers.ContentLanguage;

		/// <inheritdoc />
		public long? ContentLength
		{
			get => _headers.ContentLength;
			set => _headers.ContentLength = value;
		}

		/// <inheritdoc />
		public Uri ContentLocation
		{
			get => _headers.ContentLocation;
			set => _headers.ContentLocation = value;
		}

		/// <inheritdoc />
		public byte[] ContentMD5
		{
			get => _headers.ContentMD5;
			set => _headers.ContentMD5 = value;
		}

		/// <inheritdoc />
		public ContentRangeHeaderValue ContentRange
		{
			get => _headers.ContentRange;
			set => _headers.ContentRange = value;
		}

		/// <inheritdoc />
		public MediaTypeHeaderValue ContentType
		{
			get => _headers.ContentType;
			set => _headers.ContentType = value;
		}

		/// <inheritdoc />
		public DateTimeOffset? Expires
		{
			get => _headers.Expires;
			set => _headers.Expires = value;
		}

		/// <inheritdoc />
		public DateTimeOffset? LastModified
		{
			get => _headers.LastModified;
			set => _headers.LastModified = value;
		}

		/// <summary>
		/// Initializes new instance of type <see cref="HttpContentHeadersAdapter"/>.
		/// </summary>
		/// <param name="headers">Headers to be used by the adapter.</param>
		public HttpContentHeadersAdapter(HttpContentHeaders headers)
			: base(headers)
		{
			_headers = headers ?? throw new ArgumentNullException(nameof(headers));
		}
	}
}
