using System;
using System.Net.Http.Headers;
using JetBrains.Annotations;

namespace Thinktecture.Net.Http.Headers
{
	/// <summary>Represents the collection of Request Headers as defined in RFC 2616.</summary>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface IHttpRequestHeaders : IHttpHeaders, IAbstraction<HttpRequestHeaders>
	{
		/// <summary>Gets the value of the Accept header for an HTTP request.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the Accept header for an HTTP request.</returns>
		[NotNull]
		IHttpHeaderValueCollection<MediaTypeWithQualityHeaderValue> Accept { get; }

		/// <summary>Gets the value of the Accept-Charset header for an HTTP request.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the Accept-Charset header for an HTTP request.</returns>
		[NotNull]
		IHttpHeaderValueCollection<StringWithQualityHeaderValue> AcceptCharset { get; }

		/// <summary>Gets the value of the Accept-Encoding header for an HTTP request.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the Accept-Encoding header for an HTTP request.</returns>
		[NotNull]
		IHttpHeaderValueCollection<StringWithQualityHeaderValue> AcceptEncoding { get; }

		/// <summary>Gets the value of the Accept-Language header for an HTTP request.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the Accept-Language header for an HTTP request.</returns>
		[NotNull]
		IHttpHeaderValueCollection<StringWithQualityHeaderValue> AcceptLanguage { get; }

		/// <summary>Gets or sets the value of the Authorization header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" />.The value of the Authorization header for an HTTP request.</returns>
		[CanBeNull]
		AuthenticationHeaderValue Authorization { get; set; }

		/// <summary>Gets the value of the Expect header for an HTTP request.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the Expect header for an HTTP request.</returns>
		[NotNull]
		IHttpHeaderValueCollection<NameValueWithParametersHeaderValue> Expect { get; }

		/// <summary>Gets or sets a value that indicates if the Expect header for an HTTP request contains Continue.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the Expect header contains Continue, otherwise false.</returns>
		bool? ExpectContinue { get; set; }

		/// <summary>Gets or sets the value of the From header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.String" />.The value of the From header for an HTTP request.</returns>
		[CanBeNull]
		string From { get; set; }

		/// <summary>Gets or sets the value of the Host header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.String" />.The value of the Host header for an HTTP request.</returns>
		[CanBeNull]
		string Host { get; set; }

		/// <summary>Gets the value of the If-Match header for an HTTP request.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the If-Match header for an HTTP request.</returns>
		[NotNull]
		IHttpHeaderValueCollection<EntityTagHeaderValue> IfMatch { get; }

		/// <summary>Gets or sets the value of the If-Modified-Since header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.DateTimeOffset" />.The value of the If-Modified-Since header for an HTTP request.</returns>
		DateTimeOffset? IfModifiedSince { get; set; }

		/// <summary>Gets the value of the If-None-Match header for an HTTP request.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.Gets the value of the If-None-Match header for an HTTP request.</returns>
		[NotNull]
		IHttpHeaderValueCollection<EntityTagHeaderValue> IfNoneMatch { get; }

		/// <summary>Gets or sets the value of the If-Range header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.RangeConditionHeaderValue" />.The value of the If-Range header for an HTTP request.</returns>
		[CanBeNull]
		RangeConditionHeaderValue IfRange { get; set; }

		/// <summary>Gets or sets the value of the If-Unmodified-Since header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.DateTimeOffset" />.The value of the If-Unmodified-Since header for an HTTP request.</returns>
		DateTimeOffset? IfUnmodifiedSince { get; set; }

		/// <summary>Gets or sets the value of the Max-Forwards header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Int32" />.The value of the Max-Forwards header for an HTTP request.</returns>
		int? MaxForwards { get; set; }

		/// <summary>Gets or sets the value of the Proxy-Authorization header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" />.The value of the Proxy-Authorization header for an HTTP request.</returns>
		[CanBeNull]
		AuthenticationHeaderValue ProxyAuthorization { get; set; }

		/// <summary>Gets or sets the value of the Range header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.RangeHeaderValue" />.The value of the Range header for an HTTP request.</returns>
		[NotNull]
		RangeHeaderValue Range { get; set; }

		/// <summary>Gets or sets the value of the Referer header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Uri" />.The value of the Referer header for an HTTP request.</returns>
		[CanBeNull]
		Uri Referrer { get; set; }

		/// <summary>Gets the value of the TE header for an HTTP request.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the TE header for an HTTP request.</returns>
		[NotNull]
		// ReSharper disable once InconsistentNaming
		IHttpHeaderValueCollection<TransferCodingWithQualityHeaderValue> TE { get; }

		/// <summary>Gets the value of the User-Agent header for an HTTP request.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the User-Agent header for an HTTP request.</returns>
		[NotNull]
		IHttpHeaderValueCollection<ProductInfoHeaderValue> UserAgent { get; }

		/// <summary>Gets or sets the value of the Cache-Control header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.CacheControlHeaderValue" />.The value of the Cache-Control header for an HTTP request.</returns>
		[CanBeNull]
		CacheControlHeaderValue CacheControl { get; set; }

		/// <summary>Gets the value of the Connection header for an HTTP request.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the Connection header for an HTTP request.</returns>
		[NotNull]
		IHttpHeaderValueCollection<string> Connection { get; }

		/// <summary>Gets or sets a value that indicates if the Connection header for an HTTP request contains Close.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the Connection header contains Close, otherwise false.</returns>
		bool? ConnectionClose { get; set; }

		/// <summary>Gets or sets the value of the Date header for an HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.DateTimeOffset" />.The value of the Date header for an HTTP request.</returns>
		DateTimeOffset? Date { get; set; }

		/// <summary>Gets the value of the Pragma header for an HTTP request.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the Pragma header for an HTTP request.</returns>
		[NotNull]
		IHttpHeaderValueCollection<NameValueHeaderValue> Pragma { get; }

		/// <summary>Gets the value of the Trailer header for an HTTP request.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the Trailer header for an HTTP request.</returns>
		[NotNull]
		IHttpHeaderValueCollection<string> Trailer { get; }

		/// <summary>Gets the value of the Transfer-Encoding header for an HTTP request.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the Transfer-Encoding header for an HTTP request.</returns>
		[NotNull]
		IHttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding { get; }

		/// <summary>Gets or sets a value that indicates if the Transfer-Encoding header for an HTTP request contains chunked.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the Transfer-Encoding header contains chunked, otherwise false.</returns>
		bool? TransferEncodingChunked { get; set; }

		/// <summary>Gets the value of the Upgrade header for an HTTP request.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the Upgrade header for an HTTP request.</returns>
		[NotNull]
		IHttpHeaderValueCollection<ProductHeaderValue> Upgrade { get; }

		/// <summary>Gets the value of the Via header for an HTTP request.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the Via header for an HTTP request.</returns>
		[NotNull]
		IHttpHeaderValueCollection<ViaHeaderValue> Via { get; }

		/// <summary>Gets the value of the Warning header for an HTTP request.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the Warning header for an HTTP request.</returns>
		[NotNull]
		IHttpHeaderValueCollection<WarningHeaderValue> Warning { get; }
	}
}
