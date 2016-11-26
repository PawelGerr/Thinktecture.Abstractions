using System;
using System.ComponentModel;
using System.Net.Http.Headers;

namespace Thinktecture.Net.Http.Headers.Adapters
{
	/// <summary>Represents the collectionof Response Headers as defined in RFC 2616.</summary>
	public class HttpResponseHeadersAdapter : HttpHeadersAdapter, IHttpResponseHeaders
	{
		private readonly HttpResponseHeaders _headers;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new HttpResponseHeaders UnsafeConvert()
		{
			return _headers;
		}

		/// <inheritdoc />
		public HttpHeaderValueCollection<string> AcceptRanges => _headers.AcceptRanges;

		/// <inheritdoc />
		public TimeSpan? Age
		{
			get { return _headers.Age; }
			set { _headers.Age = value; }
		}

		/// <inheritdoc />
		public EntityTagHeaderValue ETag
		{
			get { return _headers.ETag; }
			set { _headers.ETag = value; }
		}

		/// <inheritdoc />
		public Uri Location
		{
			get { return _headers.Location; }
			set { _headers.Location = value; }
		}

		/// <inheritdoc />
		public HttpHeaderValueCollection<AuthenticationHeaderValue> ProxyAuthenticate => _headers.ProxyAuthenticate;

		/// <inheritdoc />
		public RetryConditionHeaderValue RetryAfter
		{
			get { return _headers.RetryAfter; }
			set { _headers.RetryAfter = value; }
		}

		/// <inheritdoc />
		public HttpHeaderValueCollection<ProductInfoHeaderValue> Server => _headers.Server;

		/// <inheritdoc />
		public HttpHeaderValueCollection<string> Vary => _headers.Vary;

		/// <inheritdoc />
		public HttpHeaderValueCollection<AuthenticationHeaderValue> WwwAuthenticate => _headers.WwwAuthenticate;

		/// <inheritdoc />
		public CacheControlHeaderValue CacheControl
		{
			get { return _headers.CacheControl; }
			set { _headers.CacheControl = value; }
		}

		/// <inheritdoc />
		public HttpHeaderValueCollection<string> Connection => _headers.Connection;

		/// <inheritdoc />
		public bool? ConnectionClose
		{
			get { return _headers.ConnectionClose; }
			set { _headers.ConnectionClose = value; }
		}

		/// <inheritdoc />
		public DateTimeOffset? Date
		{
			get { return _headers.Date; }
			set { _headers.Date = value; }
		}

		/// <inheritdoc />
		public HttpHeaderValueCollection<NameValueHeaderValue> Pragma => _headers.Pragma;

		/// <inheritdoc />
		public HttpHeaderValueCollection<string> Trailer => _headers.Trailer;

		/// <inheritdoc />
		public HttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding => _headers.TransferEncoding;

		/// <inheritdoc />
		public bool? TransferEncodingChunked
		{
			get { return _headers.TransferEncodingChunked; }
			set { _headers.TransferEncodingChunked = value; }
		}

		/// <inheritdoc />
		public HttpHeaderValueCollection<ProductHeaderValue> Upgrade => _headers.Upgrade;

		/// <inheritdoc />
		public HttpHeaderValueCollection<ViaHeaderValue> Via => _headers.Via;

		/// <inheritdoc />
		public HttpHeaderValueCollection<WarningHeaderValue> Warning => _headers.Warning;

		/// <summary>Initializes a new instance of the <see cref="HttpResponseHeaders" /> class.</summary>
		/// <param name="headers">Http headers to be use by the adapter.</param>
		public HttpResponseHeadersAdapter(HttpResponseHeaders headers)
			: base(headers)
		{
			if (headers == null)
				throw new ArgumentNullException(nameof(headers));
			_headers = headers;
		}
	}
}