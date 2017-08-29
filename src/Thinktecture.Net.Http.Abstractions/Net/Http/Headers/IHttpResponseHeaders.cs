using System;
using System.Net.Http.Headers;
using JetBrains.Annotations;

namespace Thinktecture.Net.Http.Headers
{
	/// <summary>Represents the collectionof Response Headers as defined in RFC 2616.</summary>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface IHttpResponseHeaders : IHttpHeaders, IAbstraction<HttpResponseHeaders>
	{
		/// <summary>Gets the value of the Accept-Ranges header for an HTTP response.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the Accept-Ranges header for an HTTP response.</returns>
		[NotNull]
		IHttpHeaderValueCollection<string> AcceptRanges { get; }

		/// <summary>Gets or sets the value of the Age header for an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.TimeSpan" />.The value of the Age header for an HTTP response.</returns>
		TimeSpan? Age { get; set; }

		/// <summary>Gets or sets the value of the ETag header for an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.EntityTagHeaderValue" />.The value of the ETag header for an HTTP response.</returns>
		[CanBeNull]
		EntityTagHeaderValue ETag { get; set; }

		/// <summary>Gets or sets the value of the Location header for an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Uri" />.The value of the Location header for an HTTP response.</returns>
		[CanBeNull]
		Uri Location { get; set; }

		/// <summary>Gets the value of the Proxy-Authenticate header for an HTTP response.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the Proxy-Authenticate header for an HTTP response.</returns>
		[NotNull]
		IHttpHeaderValueCollection<AuthenticationHeaderValue> ProxyAuthenticate { get; }

		/// <summary>Gets or sets the value of the Retry-After header for an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.RetryConditionHeaderValue" />.The value of the Retry-After header for an HTTP response.</returns>
		[CanBeNull]
		RetryConditionHeaderValue RetryAfter { get; set; }

		/// <summary>Gets the value of the Server header for an HTTP response.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the Server header for an HTTP response.</returns>
		[NotNull]
		IHttpHeaderValueCollection<ProductInfoHeaderValue> Server { get; }

		/// <summary>Gets the value of the Vary header for an HTTP response.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the Vary header for an HTTP response.</returns>
		[NotNull]
		IHttpHeaderValueCollection<string> Vary { get; }

		/// <summary>Gets the value of the WWW-Authenticate header for an HTTP response.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the WWW-Authenticate header for an HTTP response.</returns>
		[NotNull]
		IHttpHeaderValueCollection<AuthenticationHeaderValue> WwwAuthenticate { get; }

		/// <summary>Gets or sets the value of the Cache-Control header for an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.CacheControlHeaderValue" />.The value of the Cache-Control header for an HTTP response.</returns>
		[CanBeNull]
		CacheControlHeaderValue CacheControl { get; set; }

		/// <summary>Gets the value of the Connection header for an HTTP response.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the Connection header for an HTTP response.</returns>
		[NotNull]
		IHttpHeaderValueCollection<string> Connection { get; }

		/// <summary>Gets or sets a value that indicates if the Connection header for an HTTP response contains Close.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the Connection header contains Close, otherwise false.</returns>
		bool? ConnectionClose { get; set; }

		/// <summary>Gets or sets the value of the Date header for an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.DateTimeOffset" />.The value of the Date header for an HTTP response.</returns>
		DateTimeOffset? Date { get; set; }

		/// <summary>Gets the value of the Pragma header for an HTTP response.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the Pragma header for an HTTP response.</returns>
		[NotNull]
		IHttpHeaderValueCollection<NameValueHeaderValue> Pragma { get; }

		/// <summary>Gets the value of the Trailer header for an HTTP response.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the Trailer header for an HTTP response.</returns>
		[NotNull]
		IHttpHeaderValueCollection<string> Trailer { get; }

		/// <summary>Gets the value of the Transfer-Encoding header for an HTTP response.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the Transfer-Encoding header for an HTTP response.</returns>
		[NotNull]
		IHttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding { get; }

		/// <summary>Gets or sets a value that indicates if the Transfer-Encoding header for an HTTP response contains chunked.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the Transfer-Encoding header contains chunked, otherwise false.</returns>
		bool? TransferEncodingChunked { get; set; }

		/// <summary>Gets the value of the Upgrade header for an HTTP response.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the Upgrade header for an HTTP response.</returns>
		[NotNull]
		IHttpHeaderValueCollection<ProductHeaderValue> Upgrade { get; }

		/// <summary>Gets the value of the Via header for an HTTP response.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the Via header for an HTTP response.</returns>
		[NotNull]
		IHttpHeaderValueCollection<ViaHeaderValue> Via { get; }

		/// <summary>Gets the value of the Warning header for an HTTP response.</summary>
		/// <returns>Returns <see cref="IHttpHeaderValueCollection{T}" />.The value of the Warning header for an HTTP response.</returns>
		[NotNull]
		IHttpHeaderValueCollection<WarningHeaderValue> Warning { get; }
	}
}
