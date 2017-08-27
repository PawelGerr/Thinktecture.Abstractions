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
		public IHttpHeaderValueCollection<string> AcceptRanges => _headers.AcceptRanges.ToInterface();

		/// <inheritdoc />
		public TimeSpan? Age
		{
			get => _headers.Age;
			set => _headers.Age = value;
		}

		/// <inheritdoc />
		public EntityTagHeaderValue ETag
		{
			get => _headers.ETag;
			set => _headers.ETag = value;
		}

		/// <inheritdoc />
		public Uri Location
		{
			get => _headers.Location;
			set => _headers.Location = value;
		}

		/// <inheritdoc />
		public IHttpHeaderValueCollection<AuthenticationHeaderValue> ProxyAuthenticate => _headers.ProxyAuthenticate.ToInterface();

		/// <inheritdoc />
		public RetryConditionHeaderValue RetryAfter
		{
			get => _headers.RetryAfter;
			set => _headers.RetryAfter = value;
		}

		/// <inheritdoc />
		public IHttpHeaderValueCollection<ProductInfoHeaderValue> Server => _headers.Server.ToInterface();

		/// <inheritdoc />
		public IHttpHeaderValueCollection<string> Vary => _headers.Vary.ToInterface();

		/// <inheritdoc />
		public IHttpHeaderValueCollection<AuthenticationHeaderValue> WwwAuthenticate => _headers.WwwAuthenticate.ToInterface();

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

		/// <summary>Initializes a new instance of the <see cref="HttpResponseHeaders" /> class.</summary>
		/// <param name="headers">Http headers to be use by the adapter.</param>
		public HttpResponseHeadersAdapter(HttpResponseHeaders headers)
			: base(headers)
		{
			_headers = headers ?? throw new ArgumentNullException(nameof(headers));
		}
	}
}
