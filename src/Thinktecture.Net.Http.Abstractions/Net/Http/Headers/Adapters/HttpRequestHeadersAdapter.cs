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
		/// <returns>Returns <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" />.The value of the Accept header for an HTTP request.</returns>
		public IHttpHeaderValueCollection<MediaTypeWithQualityHeaderValue> Accept => _headers.Accept.ToInterface();

		/// <summary>Gets the value of the Accept-Charset header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" />.The value of the Accept-Charset header for an HTTP request.</returns>
		public IHttpHeaderValueCollection<StringWithQualityHeaderValue> AcceptCharset => _headers.AcceptCharset.ToInterface();

		/// <summary>Gets the value of the Accept-Encoding header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" />.The value of the Accept-Encoding header for an HTTP request.</returns>
		public IHttpHeaderValueCollection<StringWithQualityHeaderValue> AcceptEncoding => _headers.AcceptEncoding.ToInterface();

		/// <summary>Gets the value of the Accept-Language header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" />.The value of the Accept-Language header for an HTTP request.</returns>
		public IHttpHeaderValueCollection<StringWithQualityHeaderValue> AcceptLanguage => _headers.AcceptLanguage.ToInterface();

		/// <summary>Gets or sets the value of the Authorization header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" />.The value of the Authorization header for an HTTP request.</returns>
		public AuthenticationHeaderValue Authorization
		{
			get => _headers.Authorization;
			set => _headers.Authorization = value;
		}

		/// <summary>Gets the value of the Expect header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" />.The value of the Expect header for an HTTP request.</returns>
		public IHttpHeaderValueCollection<NameValueWithParametersHeaderValue> Expect => _headers.Expect.ToInterface();

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
		/// <returns>Returns <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" />.The value of the If-Match header for an HTTP request.</returns>
		public IHttpHeaderValueCollection<EntityTagHeaderValue> IfMatch => _headers.IfMatch.ToInterface();

		/// <summary>Gets or sets the value of the If-Modified-Since header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.DateTimeOffset" />.The value of the If-Modified-Since header for an HTTP request.</returns>
		public DateTimeOffset? IfModifiedSince
		{
			get => _headers.IfModifiedSince;
			set => _headers.IfModifiedSince = value;
		}

		/// <summary>Gets the value of the If-None-Match header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" />.Gets the value of the If-None-Match header for an HTTP request.</returns>
		public IHttpHeaderValueCollection<EntityTagHeaderValue> IfNoneMatch => _headers.IfNoneMatch.ToInterface();

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
		/// <returns>Returns <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" />.The value of the TE header for an HTTP request.</returns>
		public IHttpHeaderValueCollection<TransferCodingWithQualityHeaderValue> TE => _headers.TE.ToInterface();

		/// <summary>Gets the value of the User-Agent header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" />.The value of the User-Agent header for an HTTP request.</returns>
		public IHttpHeaderValueCollection<ProductInfoHeaderValue> UserAgent => _headers.UserAgent.ToInterface();

		/// <summary>Gets or sets the value of the Cache-Control header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.CacheControlHeaderValue" />.The value of the Cache-Control header for an HTTP request.</returns>
		public CacheControlHeaderValue CacheControl
		{
			get => _headers.CacheControl;
			set => _headers.CacheControl = value;
		}

		/// <summary>Gets the value of the Connection header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" />.The value of the Connection header for an HTTP request.</returns>
		public IHttpHeaderValueCollection<string> Connection => _headers.Connection.ToInterface();

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
		/// <returns>Returns <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" />.The value of the Pragma header for an HTTP request.</returns>
		public IHttpHeaderValueCollection<NameValueHeaderValue> Pragma => _headers.Pragma.ToInterface();

		/// <summary>Gets the value of the Trailer header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" />.The value of the Trailer header for an HTTP request.</returns>
		public IHttpHeaderValueCollection<string> Trailer => _headers.Trailer.ToInterface();

		/// <summary>Gets the value of the Transfer-Encoding header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" />.The value of the Transfer-Encoding header for an HTTP request.</returns>
		public IHttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding => _headers.TransferEncoding.ToInterface();

		/// <summary>Gets or sets a value that indicates if the Transfer-Encoding header for an HTTP request contains chunked.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the Transfer-Encoding header contains chunked, otherwise false.</returns>
		public bool? TransferEncodingChunked
		{
			get => _headers.TransferEncodingChunked;
			set => _headers.TransferEncodingChunked = value;
		}

		/// <summary>Gets the value of the Upgrade header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" />.The value of the Upgrade header for an HTTP request.</returns>
		public IHttpHeaderValueCollection<ProductHeaderValue> Upgrade => _headers.Upgrade.ToInterface();

		/// <summary>Gets the value of the Via header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" />.The value of the Via header for an HTTP request.</returns>
		public IHttpHeaderValueCollection<ViaHeaderValue> Via => _headers.Via.ToInterface();

		/// <summary>Gets the value of the Warning header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" />.The value of the Warning header for an HTTP request.</returns>
		public IHttpHeaderValueCollection<WarningHeaderValue> Warning => _headers.Warning.ToInterface();

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.Headers.HttpHeadersAdapter" /> class.</summary>
		/// <param name="headers">Http headers to be use by the adapter.</param>
		public HttpRequestHeadersAdapter(HttpRequestHeaders headers)
			: base(headers)
		{
			_headers = headers ?? throw new ArgumentNullException(nameof(headers));
		}
	}
}