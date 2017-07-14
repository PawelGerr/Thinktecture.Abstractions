using System;
using System.ComponentModel;
using System.Net.Http.Headers;

namespace Thinktecture.Net.Http.Headers.Adapters
{
	/// <summary>Represents the collection of Request Headers as defined in RFC 2616.</summary>
	public class HttpRequestHeadersAdapter : HttpHeadersAdapter, IHttpRequestHeaders
	{
		private readonly HttpRequestHeaders _headers;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new HttpRequestHeaders UnsafeConvert()
		{
			return _headers;
		}

		/// <summary>Gets the value of the Accept header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.The value of the Accept header for an HTTP request.</returns>
		public HttpHeaderValueCollection<MediaTypeWithQualityHeaderValue> Accept => _headers.Accept;

		/// <summary>Gets the value of the Accept-Charset header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.The value of the Accept-Charset header for an HTTP request.</returns>
		public HttpHeaderValueCollection<StringWithQualityHeaderValue> AcceptCharset => _headers.AcceptCharset;

		/// <summary>Gets the value of the Accept-Encoding header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.The value of the Accept-Encoding header for an HTTP request.</returns>
		public HttpHeaderValueCollection<StringWithQualityHeaderValue> AcceptEncoding => _headers.AcceptEncoding;

		/// <summary>Gets the value of the Accept-Language header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.The value of the Accept-Language header for an HTTP request.</returns>
		public HttpHeaderValueCollection<StringWithQualityHeaderValue> AcceptLanguage => _headers.AcceptLanguage;

		/// <summary>Gets or sets the value of the Authorization header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" />.The value of the Authorization header for an HTTP request.</returns>
		public AuthenticationHeaderValue Authorization
		{
			get => _headers.Authorization;
			set => _headers.Authorization = value;
		}

		/// <summary>Gets the value of the Expect header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.The value of the Expect header for an HTTP request.</returns>
		public HttpHeaderValueCollection<NameValueWithParametersHeaderValue> Expect => _headers.Expect;

		/// <summary>Gets or sets a value that indicates if the Expect header for an HTTP request contains Continue.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the Expect header contains Continue, otherwise false.</returns>
		public bool? ExpectContinue
		{
			get => _headers.ExpectContinue;
			set => _headers.ExpectContinue = value;
		}

		/// <summary>Gets or sets the value of the From header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.String" />.The value of the From header for an HTTP request.</returns>
		public string From
		{
			get => _headers.From;
			set => _headers.From = value;
		}

		/// <summary>Gets or sets the value of the Host header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.String" />.The value of the Host header for an HTTP request.</returns>
		public string Host
		{
			get => _headers.Host;
			set => _headers.Host = value;
		}

		/// <summary>Gets the value of the If-Match header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.The value of the If-Match header for an HTTP request.</returns>
		public HttpHeaderValueCollection<EntityTagHeaderValue> IfMatch => _headers.IfMatch;

		/// <summary>Gets or sets the value of the If-Modified-Since header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.DateTimeOffset" />.The value of the If-Modified-Since header for an HTTP request.</returns>
		public DateTimeOffset? IfModifiedSince
		{
			get => _headers.IfModifiedSince;
			set => _headers.IfModifiedSince = value;
		}

		/// <summary>Gets the value of the If-None-Match header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.Gets the value of the If-None-Match header for an HTTP request.</returns>
		public HttpHeaderValueCollection<EntityTagHeaderValue> IfNoneMatch => _headers.IfNoneMatch;

		/// <summary>Gets or sets the value of the If-Range header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.RangeConditionHeaderValue" />.The value of the If-Range header for an HTTP request.</returns>
		public RangeConditionHeaderValue IfRange
		{
			get => _headers.IfRange;
			set => _headers.IfRange = value;
		}

		/// <summary>Gets or sets the value of the If-Unmodified-Since header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.DateTimeOffset" />.The value of the If-Unmodified-Since header for an HTTP request.</returns>
		public DateTimeOffset? IfUnmodifiedSince
		{
			get => _headers.IfUnmodifiedSince;
			set => _headers.IfUnmodifiedSince = value;
		}

		/// <summary>Gets or sets the value of the Max-Forwards header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Int32" />.The value of the Max-Forwards header for an HTTP request.</returns>
		public int? MaxForwards
		{
			get => _headers.MaxForwards;
			set => _headers.MaxForwards = value;
		}

		/// <summary>Gets or sets the value of the Proxy-Authorization header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" />.The value of the Proxy-Authorization header for an HTTP request.</returns>
		public AuthenticationHeaderValue ProxyAuthorization
		{
			get => _headers.ProxyAuthorization;
			set => _headers.ProxyAuthorization = value;
		}

		/// <summary>Gets or sets the value of the Range header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.RangeHeaderValue" />.The value of the Range header for an HTTP request.</returns>
		public RangeHeaderValue Range
		{
			get => _headers.Range;
			set => _headers.Range = value;
		}

		/// <summary>Gets or sets the value of the Referer header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Uri" />.The value of the Referer header for an HTTP request.</returns>
		public Uri Referrer
		{
			get => _headers.Referrer;
			set => _headers.Referrer = value;
		}

		/// <summary>Gets the value of the TE header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.The value of the TE header for an HTTP request.</returns>
		public HttpHeaderValueCollection<TransferCodingWithQualityHeaderValue> TE => _headers.TE;

		/// <summary>Gets the value of the User-Agent header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.The value of the User-Agent header for an HTTP request.</returns>
		public HttpHeaderValueCollection<ProductInfoHeaderValue> UserAgent => _headers.UserAgent;

		/// <summary>Gets or sets the value of the Cache-Control header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.CacheControlHeaderValue" />.The value of the Cache-Control header for an HTTP request.</returns>
		public CacheControlHeaderValue CacheControl
		{
			get => _headers.CacheControl;
			set => _headers.CacheControl = value;
		}

		/// <summary>Gets the value of the Connection header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.The value of the Connection header for an HTTP request.</returns>
		public HttpHeaderValueCollection<string> Connection => _headers.Connection;

		/// <summary>Gets or sets a value that indicates if the Connection header for an HTTP request contains Close.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the Connection header contains Close, otherwise false.</returns>
		public bool? ConnectionClose
		{
			get => _headers.ConnectionClose;
			set => _headers.ConnectionClose = value;
		}

		/// <summary>Gets or sets the value of the Date header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.DateTimeOffset" />.The value of the Date header for an HTTP request.</returns>
		public DateTimeOffset? Date
		{
			get => _headers.Date;
			set => _headers.Date = value;
		}

		/// <summary>Gets the value of the Pragma header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.The value of the Pragma header for an HTTP request.</returns>
		public HttpHeaderValueCollection<NameValueHeaderValue> Pragma => _headers.Pragma;

		/// <summary>Gets the value of the Trailer header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.The value of the Trailer header for an HTTP request.</returns>
		public HttpHeaderValueCollection<string> Trailer => _headers.Trailer;

		/// <summary>Gets the value of the Transfer-Encoding header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.The value of the Transfer-Encoding header for an HTTP request.</returns>
		public HttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding => _headers.TransferEncoding;

		/// <summary>Gets or sets a value that indicates if the Transfer-Encoding header for an HTTP request contains chunked.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the Transfer-Encoding header contains chunked, otherwise false.</returns>
		public bool? TransferEncodingChunked
		{
			get => _headers.TransferEncodingChunked;
			set => _headers.TransferEncodingChunked = value;
		}

		/// <summary>Gets the value of the Upgrade header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.The value of the Upgrade header for an HTTP request.</returns>
		public HttpHeaderValueCollection<ProductHeaderValue> Upgrade => _headers.Upgrade;

		/// <summary>Gets the value of the Via header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.The value of the Via header for an HTTP request.</returns>
		public HttpHeaderValueCollection<ViaHeaderValue> Via => _headers.Via;

		/// <summary>Gets the value of the Warning header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.The value of the Warning header for an HTTP request.</returns>
		public HttpHeaderValueCollection<WarningHeaderValue> Warning => _headers.Warning;

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.Headers.HttpHeadersAdapter" /> class.</summary>
		/// <param name="headers">Http headers to be use by the adapter.</param>
		public HttpRequestHeadersAdapter(HttpRequestHeaders headers)
			: base(headers)
		{
			_headers = headers ?? throw new ArgumentNullException(nameof(headers));
		}
	}
}