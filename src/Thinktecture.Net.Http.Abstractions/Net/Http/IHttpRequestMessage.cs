using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using Thinktecture.Net.Http.Headers;

namespace Thinktecture.Net.Http
{
	/// <summary>Represents a HTTP request message.</summary>
	public interface IHttpRequestMessage : IDisposable
	{
		/// <summary>
		/// Gets inner instance of <see cref="HttpRequestMessage"/>.
		/// It is not intended to be used directly. Use <see cref="HttpRequestMessageExtensions.ToImplementation"/> instead.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		HttpRequestMessage UnsafeConvert();

		/// <summary>Gets or sets the HTTP message version.</summary>
		/// <returns>Returns <see cref="T:System.Version" />.The HTTP message version. The default is 1.1.</returns>
		Version Version { get; set; }

		/// <summary>Gets or sets the contents of the HTTP message. </summary>
		/// <returns>Returns <see cref="T:System.Net.Http.HttpContent" />.The content of a message</returns>
		IHttpContent Content { get; set; }

		/// <summary>Gets or sets the HTTP method used by the HTTP request message.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.HttpMethod" />.The HTTP method used by the request message. The default is the GET method.</returns>
		HttpMethod Method { get; set; }

		/// <summary>Gets or sets the <see cref="T:System.Uri" /> used for the HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Uri" />.The <see cref="T:System.Uri" /> used for the HTTP request.</returns>
		Uri RequestUri { get; set; }

		/// <summary>Gets the collection of HTTP request headers.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpRequestHeaders" />.The collection of HTTP request headers.</returns>
		IHttpRequestHeaders Headers { get; }

		/// <summary>Gets a set of properties for the HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Collections.Generic.IDictionary`2" />.</returns>
		IDictionary<string, object> Properties { get; }

		/// <summary>Returns a string that represents the current object.</summary>
		/// <returns>Returns <see cref="T:System.String" />.A string representation of the current object.</returns>
		string ToString();
	}
}