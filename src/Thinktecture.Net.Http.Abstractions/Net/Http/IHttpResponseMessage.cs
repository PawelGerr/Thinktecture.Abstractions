using System;
using System.Net;
using System.Net.Http;
using JetBrains.Annotations;
using Thinktecture.Net.Http.Headers;

namespace Thinktecture.Net.Http
{
	/// <summary>Represents a HTTP response message including the status code and data.</summary>
	public interface IHttpResponseMessage : IAbstraction<HttpResponseMessage>, IDisposable
	{
		/// <summary>Gets or sets the HTTP message version. </summary>
		/// <returns>Returns <see cref="T:System.Version" />.The HTTP message version. The default is 1.1. </returns>
		[NotNull]
		Version Version { get; set; }

		/// <summary>Gets or sets the content of a HTTP response message. </summary>
		/// <returns>Returns <see cref="T:System.Net.Http.HttpContent" />.The content of the HTTP response message.</returns>
		[CanBeNull]
		IHttpContent Content { get; set; }

		/// <summary>Gets or sets the status code of the HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Net.HttpStatusCode" />.The status code of the HTTP response.</returns>
		HttpStatusCode StatusCode { get; set; }

		/// <summary>Gets or sets the reason phrase which typically is sent by servers together with the status code. </summary>
		/// <returns>Returns <see cref="T:System.String" />.The reason phrase sent by the server.</returns>
		[NotNull]
		string ReasonPhrase { get; set; }

		/// <summary>Gets the collection of HTTP response headers. </summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpResponseHeaders" />.The collection of HTTP response headers.</returns>
		[NotNull]
		IHttpResponseHeaders Headers { get; }

		/// <summary>Gets or sets the request message which led to this response message.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.HttpRequestMessage" />.The request message which led to this response message.</returns>
		[CanBeNull]
		IHttpRequestMessage RequestMessage { get; set; }

		/// <summary>Gets a value that indicates if the HTTP response was successful.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.A value that indicates if the HTTP response was successful. true if <see cref="P:System.Net.Http.HttpResponseMessage.StatusCode" /> was in the range 200-299; otherwise false.</returns>
		bool IsSuccessStatusCode { get; }

		/// <summary>Throws an exception if the <see cref="P:System.Net.Http.HttpResponseMessage.IsSuccessStatusCode" /> property for the HTTP response is false.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.HttpResponseMessage" />.The HTTP response message if the call is successful.</returns>
		[NotNull]
		IHttpResponseMessage EnsureSuccessStatusCode();
	}
}
