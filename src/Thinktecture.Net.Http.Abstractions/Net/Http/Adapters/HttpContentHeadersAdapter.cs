using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.Net.Http.Adapters
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

		/// <summary>Gets the value of the Allow content header on an HTTP response. </summary>
		/// <returns>Returns <see cref="T:System.Collections.Generic.ICollection`1" />.The value of the Allow header on an HTTP response.</returns>
		public ICollection<string> Allow => _headers.Allow;

		/// <summary>Gets the value of the Content-Disposition content header on an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.ContentDispositionHeaderValue" />.The value of the Content-Disposition content header on an HTTP response.</returns>
		public ContentDispositionHeaderValue ContentDisposition
		{
			get { return _headers.ContentDisposition; }
			set { _headers.ContentDisposition = value; }
		}

		/// <summary>Gets the value of the Content-Encoding content header on an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Collections.Generic.ICollection`1" />.The value of the Content-Encoding content header on an HTTP response.</returns>
		public ICollection<string> ContentEncoding => _headers.ContentEncoding;

		/// <summary>Gets the value of the Content-Language content header on an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Collections.Generic.ICollection`1" />.The value of the Content-Language content header on an HTTP response.</returns>
		public ICollection<string> ContentLanguage => _headers.ContentLanguage;

		/// <summary>Gets or sets the value of the Content-Length content header on an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Int64" />.The value of the Content-Length content header on an HTTP response.</returns>
		public long? ContentLength
		{
			get { return _headers.ContentLength; }
			set { _headers.ContentLength = value; }
		}

		/// <summary>Gets or sets the value of the Content-Location content header on an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Uri" />.The value of the Content-Location content header on an HTTP response.</returns>
		public Uri ContentLocation
		{
			get { return _headers.ContentLocation; }
			set { _headers.ContentLocation = value; }
		}

		/// <summary>Gets or sets the value of the Content-MD5 content header on an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Byte" />.The value of the Content-MD5 content header on an HTTP response.</returns>
		public byte[] ContentMD5
		{
			get { return _headers.ContentMD5; }
			set { _headers.ContentMD5 = value; }
		}

		/// <summary>Gets or sets the value of the Content-Range content header on an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.ContentRangeHeaderValue" />.The value of the Content-Range content header on an HTTP response.</returns>
		public ContentRangeHeaderValue ContentRange
		{
			get { return _headers.ContentRange; }
			set { _headers.ContentRange = value; }
		}

		/// <summary>Gets or sets the value of the Content-Type content header on an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.MediaTypeHeaderValue" />.The value of the Content-Type content header on an HTTP response.</returns>
		public MediaTypeHeaderValue ContentType
		{
			get { return _headers.ContentType; }
			set { _headers.ContentType = value; }
		}

		/// <summary>Gets or sets the value of the Expires content header on an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.DateTimeOffset" />.The value of the Expires content header on an HTTP response.</returns>
		public DateTimeOffset? Expires
		{
			get { return _headers.Expires; }
			set { _headers.Expires = value; }
		}

		/// <summary>Gets or sets the value of the Last-Modified content header on an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.DateTimeOffset" />.The value of the Last-Modified content header on an HTTP response.</returns>
		public DateTimeOffset? LastModified
		{
			get { return _headers.LastModified; }
			set { _headers.LastModified = value; }
		}

		/// <summary>
		/// Initializes new instance of type <see cref="HttpContentHeadersAdapter"/>.
		/// </summary>
		/// <param name="headers">Headers to be used by the adapter.</param>
		public HttpContentHeadersAdapter(HttpContentHeaders headers)
			: base(headers)
		{
			if (headers == null)
				throw new ArgumentNullException(nameof(headers));

			_headers = headers;
		}
	}
}