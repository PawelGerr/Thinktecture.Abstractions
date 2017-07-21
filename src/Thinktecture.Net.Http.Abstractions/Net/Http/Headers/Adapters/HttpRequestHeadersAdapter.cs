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

		/// <inheritdoc />
		public IHttpHeaderValueCollection<MediaTypeWithQualityHeaderValue> Accept => _headers.Accept.ToInterface();

		/// <inheritdoc />
		public IHttpHeaderValueCollection<StringWithQualityHeaderValue> AcceptCharset => _headers.AcceptCharset.ToInterface();

		/// <inheritdoc />
		public IHttpHeaderValueCollection<StringWithQualityHeaderValue> AcceptEncoding => _headers.AcceptEncoding.ToInterface();

		/// <inheritdoc />
		public IHttpHeaderValueCollection<StringWithQualityHeaderValue> AcceptLanguage => _headers.AcceptLanguage.ToInterface();

		/// <inheritdoc />
		public AuthenticationHeaderValue Authorization
		{
			get => _headers.Authorization;
			set => _headers.Authorization = value;
		}

		/// <inheritdoc />
		public IHttpHeaderValueCollection<NameValueWithParametersHeaderValue> Expect => _headers.Expect.ToInterface();

		/// <inheritdoc />
		public bool? ExpectContinue
		{
			get => _headers.ExpectContinue;
			set => _headers.ExpectContinue = value;
		}

		/// <inheritdoc />
		public string From
		{
			get => _headers.From;
			set => _headers.From = value;
		}

		/// <inheritdoc />
		public string Host
		{
			get => _headers.Host;
			set => _headers.Host = value;
		}

		/// <inheritdoc />
		public IHttpHeaderValueCollection<EntityTagHeaderValue> IfMatch => _headers.IfMatch.ToInterface();

		/// <inheritdoc />
		public DateTimeOffset? IfModifiedSince
		{
			get => _headers.IfModifiedSince;
			set => _headers.IfModifiedSince = value;
		}

		/// <inheritdoc />
		public IHttpHeaderValueCollection<EntityTagHeaderValue> IfNoneMatch => _headers.IfNoneMatch.ToInterface();

		/// <inheritdoc />
		public RangeConditionHeaderValue IfRange
		{
			get => _headers.IfRange;
			set => _headers.IfRange = value;
		}

		/// <inheritdoc />
		public DateTimeOffset? IfUnmodifiedSince
		{
			get => _headers.IfUnmodifiedSince;
			set => _headers.IfUnmodifiedSince = value;
		}

		/// <inheritdoc />
		public int? MaxForwards
		{
			get => _headers.MaxForwards;
			set => _headers.MaxForwards = value;
		}

		/// <inheritdoc />
		public AuthenticationHeaderValue ProxyAuthorization
		{
			get => _headers.ProxyAuthorization;
			set => _headers.ProxyAuthorization = value;
		}

		/// <inheritdoc />
		public RangeHeaderValue Range
		{
			get => _headers.Range;
			set => _headers.Range = value;
		}

		/// <inheritdoc />
		public Uri Referrer
		{
			get => _headers.Referrer;
			set => _headers.Referrer = value;
		}

		/// <inheritdoc />
		public IHttpHeaderValueCollection<TransferCodingWithQualityHeaderValue> TE => _headers.TE.ToInterface();

		/// <inheritdoc />
		public IHttpHeaderValueCollection<ProductInfoHeaderValue> UserAgent => _headers.UserAgent.ToInterface();

		/// <inheritdoc />
		public CacheControlHeaderValue CacheControl
		{
			get => _headers.CacheControl;
			set => _headers.CacheControl = value;
		}

		/// <inheritdoc />
		public IHttpHeaderValueCollection<string> Connection => _headers.Connection.ToInterface();

		/// <inheritdoc />
		public bool? ConnectionClose
		{
			get => _headers.ConnectionClose;
			set => _headers.ConnectionClose = value;
		}

		/// <inheritdoc />
		public DateTimeOffset? Date
		{
			get => _headers.Date;
			set => _headers.Date = value;
		}

		/// <inheritdoc />
		public IHttpHeaderValueCollection<NameValueHeaderValue> Pragma => _headers.Pragma.ToInterface();

		/// <inheritdoc />
		public IHttpHeaderValueCollection<string> Trailer => _headers.Trailer.ToInterface();

		/// <inheritdoc />
		public IHttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding => _headers.TransferEncoding.ToInterface();

		/// <inheritdoc />
		public bool? TransferEncodingChunked
		{
			get => _headers.TransferEncodingChunked;
			set => _headers.TransferEncodingChunked = value;
		}

		/// <inheritdoc />
		public IHttpHeaderValueCollection<ProductHeaderValue> Upgrade => _headers.Upgrade.ToInterface();

		/// <inheritdoc />
		public IHttpHeaderValueCollection<ViaHeaderValue> Via => _headers.Via.ToInterface();

		/// <inheritdoc />
		public IHttpHeaderValueCollection<WarningHeaderValue> Warning => _headers.Warning.ToInterface();

		/// <summary>Initializes a new instance of the <see cref="HttpHeadersAdapter" /> class.</summary>
		/// <param name="headers">Http headers to be use by the adapter.</param>
		public HttpRequestHeadersAdapter(HttpRequestHeaders headers)
			: base(headers)
		{
			_headers = headers ?? throw new ArgumentNullException(nameof(headers));
		}
	}
}