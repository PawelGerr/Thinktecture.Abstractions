using System;
using System.Collections.Generic;
using System.Net.Http;
using JetBrains.Annotations;
using Thinktecture.Net.Http.Headers;

namespace Thinktecture.Net.Http
{
	/// <summary>Represents a HTTP request message.</summary>
	public interface IHttpRequestMessage : IAbstraction<HttpRequestMessage>, IDisposable
	{
		/// <summary>Gets or sets the HTTP message version.</summary>
		/// <returns>Returns <see cref="T:System.Version" />.The HTTP message version. The default is 1.1.</returns>
		[NotNull]
		Version Version { get; set; }

		/// <summary>Gets or sets the contents of the HTTP message. </summary>
		/// <returns>Returns <see cref="T:System.Net.Http.HttpContent" />.The content of a message</returns>
		[CanBeNull]
		IHttpContent Content { get; set; }

		/// <summary>Gets or sets the HTTP method used by the HTTP request message.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.HttpMethod" />.The HTTP method used by the request message. The default is the GET method.</returns>
		[NotNull]
		HttpMethod Method { get; set; }

		/// <summary>Gets or sets the <see cref="T:System.Uri" /> used for the HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Uri" />.The <see cref="T:System.Uri" /> used for the HTTP request.</returns>
		[CanBeNull]
		Uri RequestUri { get; set; }

		/// <summary>Gets the collection of HTTP request headers.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpRequestHeaders" />.The collection of HTTP request headers.</returns>
		[NotNull]
		IHttpRequestHeaders Headers { get; }

		/// <summary>Gets a set of properties for the HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Collections.Generic.IDictionary`2" />.</returns>
		[NotNull]
		IDictionary<string, object> Properties { get; }
	}
}
