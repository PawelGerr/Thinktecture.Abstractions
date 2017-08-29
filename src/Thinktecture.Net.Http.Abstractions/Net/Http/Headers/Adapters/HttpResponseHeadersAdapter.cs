using System;
using System.ComponentModel;
using System.Net.Http.Headers;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.Http.Headers.Adapters
{
	/// <summary>Represents the collectionof Response Headers as defined in RFC 2616.</summary>
	public class HttpResponseHeadersAdapter : HttpHeadersAdapter, IHttpResponseHeaders
	{
		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		[NotNull]
		protected new HttpResponseHeaders Implementation { get; }

		/// <inheritdoc />
		[NotNull, EditorBrowsable(EditorBrowsableState.Never)]
		public new HttpResponseHeaders UnsafeConvert()
		{
			return Implementation;
		}

		/// <inheritdoc />
		public IHttpHeaderValueCollection<string> AcceptRanges => Implementation.AcceptRanges.ToInterface();

		/// <inheritdoc />
		public TimeSpan? Age
		{
			get => Implementation.Age;
			set => Implementation.Age = value;
		}

		/// <inheritdoc />
		public EntityTagHeaderValue ETag
		{
			get => Implementation.ETag;
			set => Implementation.ETag = value;
		}

		/// <inheritdoc />
		public Uri Location
		{
			get => Implementation.Location;
			set => Implementation.Location = value;
		}

		/// <inheritdoc />
		public IHttpHeaderValueCollection<AuthenticationHeaderValue> ProxyAuthenticate => Implementation.ProxyAuthenticate.ToInterface();

		/// <inheritdoc />
		public RetryConditionHeaderValue RetryAfter
		{
			get => Implementation.RetryAfter;
			set => Implementation.RetryAfter = value;
		}

		/// <inheritdoc />
		public IHttpHeaderValueCollection<ProductInfoHeaderValue> Server => Implementation.Server.ToInterface();

		/// <inheritdoc />
		public IHttpHeaderValueCollection<string> Vary => Implementation.Vary.ToInterface();

		/// <inheritdoc />
		public IHttpHeaderValueCollection<AuthenticationHeaderValue> WwwAuthenticate => Implementation.WwwAuthenticate.ToInterface();

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

		/// <summary>Initializes a new instance of the <see cref="HttpResponseHeaders" /> class.</summary>
		/// <param name="headers">Http headers to be use by the adapter.</param>
		public HttpResponseHeadersAdapter([NotNull] HttpResponseHeaders headers)
			: base(headers)
		{
			Implementation = headers ?? throw new ArgumentNullException(nameof(headers));
		}
	}
}
