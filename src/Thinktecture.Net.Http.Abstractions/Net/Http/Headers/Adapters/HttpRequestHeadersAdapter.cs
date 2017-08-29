using System;
using System.ComponentModel;
using System.Net.Http.Headers;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.Http.Headers.Adapters
{
	/// <summary>Represents the collection of Request Headers as defined in RFC 2616.</summary>
	public class HttpRequestHeadersAdapter : HttpHeadersAdapter, IHttpRequestHeaders
	{
		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		[NotNull]
		protected new HttpRequestHeaders Implementation { get; }

		/// <inheritdoc />
		[NotNull, EditorBrowsable(EditorBrowsableState.Never)]
		public new HttpRequestHeaders UnsafeConvert()
		{
			return Implementation;
		}

		/// <inheritdoc />
		public IHttpHeaderValueCollection<MediaTypeWithQualityHeaderValue> Accept => Implementation.Accept.ToInterface();

		/// <inheritdoc />
		public IHttpHeaderValueCollection<StringWithQualityHeaderValue> AcceptCharset => Implementation.AcceptCharset.ToInterface();

		/// <inheritdoc />
		public IHttpHeaderValueCollection<StringWithQualityHeaderValue> AcceptEncoding => Implementation.AcceptEncoding.ToInterface();

		/// <inheritdoc />
		public IHttpHeaderValueCollection<StringWithQualityHeaderValue> AcceptLanguage => Implementation.AcceptLanguage.ToInterface();

		/// <inheritdoc />
		public AuthenticationHeaderValue Authorization
		{
			get => Implementation.Authorization;
			set => Implementation.Authorization = value;
		}

		/// <inheritdoc />
		public IHttpHeaderValueCollection<NameValueWithParametersHeaderValue> Expect => Implementation.Expect.ToInterface();

		/// <inheritdoc />
		public bool? ExpectContinue
		{
			get => Implementation.ExpectContinue;
			set => Implementation.ExpectContinue = value;
		}

		/// <inheritdoc />
		public string From
		{
			get => Implementation.From;
			set => Implementation.From = value;
		}

		/// <inheritdoc />
		public string Host
		{
			get => Implementation.Host;
			set => Implementation.Host = value;
		}

		/// <inheritdoc />
		public IHttpHeaderValueCollection<EntityTagHeaderValue> IfMatch => Implementation.IfMatch.ToInterface();

		/// <inheritdoc />
		public DateTimeOffset? IfModifiedSince
		{
			get => Implementation.IfModifiedSince;
			set => Implementation.IfModifiedSince = value;
		}

		/// <inheritdoc />
		public IHttpHeaderValueCollection<EntityTagHeaderValue> IfNoneMatch => Implementation.IfNoneMatch.ToInterface();

		/// <inheritdoc />
		public RangeConditionHeaderValue IfRange
		{
			get => Implementation.IfRange;
			set => Implementation.IfRange = value;
		}

		/// <inheritdoc />
		public DateTimeOffset? IfUnmodifiedSince
		{
			get => Implementation.IfUnmodifiedSince;
			set => Implementation.IfUnmodifiedSince = value;
		}

		/// <inheritdoc />
		public int? MaxForwards
		{
			get => Implementation.MaxForwards;
			set => Implementation.MaxForwards = value;
		}

		/// <inheritdoc />
		public AuthenticationHeaderValue ProxyAuthorization
		{
			get => Implementation.ProxyAuthorization;
			set => Implementation.ProxyAuthorization = value;
		}

		/// <inheritdoc />
		public RangeHeaderValue Range
		{
			get => Implementation.Range;
			set => Implementation.Range = value;
		}

		/// <inheritdoc />
		public Uri Referrer
		{
			get => Implementation.Referrer;
			set => Implementation.Referrer = value;
		}

		/// <inheritdoc />
		public IHttpHeaderValueCollection<TransferCodingWithQualityHeaderValue> TE => Implementation.TE.ToInterface();

		/// <inheritdoc />
		public IHttpHeaderValueCollection<ProductInfoHeaderValue> UserAgent => Implementation.UserAgent.ToInterface();

		/// <inheritdoc />
		public CacheControlHeaderValue CacheControl
		{
			get => Implementation.CacheControl;
			set => Implementation.CacheControl = value;
		}

		/// <inheritdoc />
		public IHttpHeaderValueCollection<string> Connection => Implementation.Connection.ToInterface();

		/// <inheritdoc />
		public bool? ConnectionClose
		{
			get => Implementation.ConnectionClose;
			set => Implementation.ConnectionClose = value;
		}

		/// <inheritdoc />
		public DateTimeOffset? Date
		{
			get => Implementation.Date;
			set => Implementation.Date = value;
		}

		/// <inheritdoc />
		public IHttpHeaderValueCollection<NameValueHeaderValue> Pragma => Implementation.Pragma.ToInterface();

		/// <inheritdoc />
		public IHttpHeaderValueCollection<string> Trailer => Implementation.Trailer.ToInterface();

		/// <inheritdoc />
		public IHttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding => Implementation.TransferEncoding.ToInterface();

		/// <inheritdoc />
		public bool? TransferEncodingChunked
		{
			get => Implementation.TransferEncodingChunked;
			set => Implementation.TransferEncodingChunked = value;
		}

		/// <inheritdoc />
		public IHttpHeaderValueCollection<ProductHeaderValue> Upgrade => Implementation.Upgrade.ToInterface();

		/// <inheritdoc />
		public IHttpHeaderValueCollection<ViaHeaderValue> Via => Implementation.Via.ToInterface();

		/// <inheritdoc />
		public IHttpHeaderValueCollection<WarningHeaderValue> Warning => Implementation.Warning.ToInterface();

		/// <summary>Initializes a new instance of the <see cref="HttpHeadersAdapter" /> class.</summary>
		/// <param name="headers">Http headers to be use by the adapter.</param>
		public HttpRequestHeadersAdapter([NotNull] HttpRequestHeaders headers)
			: base(headers)
		{
			Implementation = headers ?? throw new ArgumentNullException(nameof(headers));
		}
	}
}
