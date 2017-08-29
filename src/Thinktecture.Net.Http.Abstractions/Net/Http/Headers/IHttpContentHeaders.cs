using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using JetBrains.Annotations;

namespace Thinktecture.Net.Http.Headers
{
	/// <summary>Represents the collection of Content Headers as defined in RFC 2616.</summary>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface IHttpContentHeaders : IHttpHeaders, IAbstraction<HttpContentHeaders>
	{
		/// <summary>Gets the value of the Allow content header on an HTTP response. </summary>
		/// <returns>Returns <see cref="T:System.Collections.Generic.ICollection`1" />.The value of the Allow header on an HTTP response.</returns>
		[NotNull]
		ICollection<string> Allow { get; }

		/// <summary>Gets the value of the Content-Disposition content header on an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.ContentDispositionHeaderValue" />.The value of the Content-Disposition content header on an HTTP response.</returns>
		[CanBeNull]
		ContentDispositionHeaderValue ContentDisposition { get; set; }

		/// <summary>Gets the value of the Content-Encoding content header on an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Collections.Generic.ICollection`1" />.The value of the Content-Encoding content header on an HTTP response.</returns>
		[NotNull]
		ICollection<string> ContentEncoding { get; }

		/// <summary>Gets the value of the Content-Language content header on an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Collections.Generic.ICollection`1" />.The value of the Content-Language content header on an HTTP response.</returns>
		[NotNull]
		ICollection<string> ContentLanguage { get; }

		/// <summary>Gets or sets the value of the Content-Length content header on an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Int64" />.The value of the Content-Length content header on an HTTP response.</returns>
		long? ContentLength { get; set; }

		/// <summary>Gets or sets the value of the Content-Location content header on an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Uri" />.The value of the Content-Location content header on an HTTP response.</returns>
		[CanBeNull]
		Uri ContentLocation { get; set; }

		/// <summary>Gets or sets the value of the Content-MD5 content header on an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Byte" />.The value of the Content-MD5 content header on an HTTP response.</returns>
		[CanBeNull]
		// ReSharper disable once InconsistentNaming
		byte[] ContentMD5 { get; set; }

		/// <summary>Gets or sets the value of the Content-Range content header on an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.ContentRangeHeaderValue" />.The value of the Content-Range content header on an HTTP response.</returns>
		[CanBeNull]
		ContentRangeHeaderValue ContentRange { get; set; }

		/// <summary>Gets or sets the value of the Content-Type content header on an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.MediaTypeHeaderValue" />.The value of the Content-Type content header on an HTTP response.</returns>
		[CanBeNull]
		MediaTypeHeaderValue ContentType { get; set; }

		/// <summary>Gets or sets the value of the Expires content header on an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.DateTimeOffset" />.The value of the Expires content header on an HTTP response.</returns>
		DateTimeOffset? Expires { get; set; }

		/// <summary>Gets or sets the value of the Last-Modified content header on an HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.DateTimeOffset" />.The value of the Last-Modified content header on an HTTP response.</returns>
		DateTimeOffset? LastModified { get; set; }
	}
}
