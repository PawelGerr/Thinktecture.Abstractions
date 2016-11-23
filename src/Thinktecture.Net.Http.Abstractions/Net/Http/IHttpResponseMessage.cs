using System;
using System.ComponentModel;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Thinktecture.Net.Http
{
	public interface IHttpResponseMessage : IDisposable
	{
		/// <summary>
		/// Gets inner instance of <see cref="HttpResponseMessage"/>.
		/// It is not intended to be used directly. Use <see cref="HttpResponseMessageExtensions.ToImplementation"/> instead.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		HttpResponseMessage UnsafeConvert();

		/// <summary>Gets or sets the HTTP message version. </summary>
		/// <returns>Returns <see cref="T:System.Version" />.The HTTP message version. The default is 1.1. </returns>
		Version Version { get; set; }

		/// <summary>Gets or sets the content of a HTTP response message. </summary>
		/// <returns>Returns <see cref="T:System.Net.Http.HttpContent" />.The content of the HTTP response message.</returns>
		IHttpContent Content { get; set; }

		/// <summary>Gets or sets the status code of the HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Net.HttpStatusCode" />.The status code of the HTTP response.</returns>
		HttpStatusCode StatusCode { get; set; }

		/// <summary>Gets or sets the reason phrase which typically is sent by servers together with the status code. </summary>
		/// <returns>Returns <see cref="T:System.String" />.The reason phrase sent by the server.</returns>
		string ReasonPhrase { get; set; }

		/// <summary>Gets the collection of HTTP response headers. </summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpResponseHeaders" />.The collection of HTTP response headers.</returns>
		HttpResponseHeaders Headers { get; }

		/// <summary>Gets or sets the request message which led to this response message.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.HttpRequestMessage" />.The request message which led to this response message.</returns>
		HttpRequestMessage RequestMessage { get; set; }

		/// <summary>Gets a value that indicates if the HTTP response was successful.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.A value that indicates if the HTTP response was successful. true if <see cref="P:System.Net.Http.HttpResponseMessage.StatusCode" /> was in the range 200-299; otherwise false.</returns>
		bool IsSuccessStatusCode { get; }

		/// <summary>Throws an exception if the <see cref="P:System.Net.Http.HttpResponseMessage.IsSuccessStatusCode" /> property for the HTTP response is false.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.HttpResponseMessage" />.The HTTP response message if the call is successful.</returns>
		IHttpResponseMessage EnsureSuccessStatusCode();

		/// <summary>Returns a string that represents the current object.</summary>
		/// <returns>Returns <see cref="T:System.String" />.A string representation of the current object.</returns>
		string ToString();
	}

	/// <summary>Represents a HTTP response message including the status code and data.</summary>
	public class HttpResponseMessage : IHttpResponseMessage
	{
		/// <summary>Gets or sets the HTTP message version. </summary>
		/// <returns>Returns <see cref="T:System.Version" />.The HTTP message version. The default is 1.1. </returns>
		public Version Version { get; set; }

		/// <summary>Gets or sets the content of a HTTP response message. </summary>
		/// <returns>Returns <see cref="T:System.Net.Http.HttpContent" />.The content of the HTTP response message.</returns>
		public HttpContent Content { get; set; }

		/// <summary>Gets or sets the status code of the HTTP response.</summary>
		/// <returns>Returns <see cref="T:System.Net.HttpStatusCode" />.The status code of the HTTP response.</returns>
		public HttpStatusCode StatusCode { get; set; }

		/// <summary>Gets or sets the reason phrase which typically is sent by servers together with the status code. </summary>
		/// <returns>Returns <see cref="T:System.String" />.The reason phrase sent by the server.</returns>
		public string ReasonPhrase { get; set; }

		/// <summary>Gets the collection of HTTP response headers. </summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpResponseHeaders" />.The collection of HTTP response headers.</returns>
		public HttpResponseHeaders Headers { get; }

		/// <summary>Gets or sets the request message which led to this response message.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.HttpRequestMessage" />.The request message which led to this response message.</returns>
		public HttpRequestMessage RequestMessage { get; set; }

		/// <summary>Gets a value that indicates if the HTTP response was successful.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.A value that indicates if the HTTP response was successful. true if <see cref="P:System.Net.Http.HttpResponseMessage.StatusCode" /> was in the range 200-299; otherwise false.</returns>
		public bool IsSuccessStatusCode { get; }

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.HttpResponseMessage" /> class.</summary>
		public HttpResponseMessage()
			: this(HttpStatusCode.OK)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.HttpResponseMessage" /> class with a specific <see cref="P:System.Net.Http.HttpResponseMessage.StatusCode" />.</summary>
		/// <param name="statusCode">The status code of the HTTP response.</param>
		public HttpResponseMessage(HttpStatusCode statusCode)
		{
		}

		/// <summary>Throws an exception if the <see cref="P:System.Net.Http.HttpResponseMessage.IsSuccessStatusCode" /> property for the HTTP response is false.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.HttpResponseMessage" />.The HTTP response message if the call is successful.</returns>
		public HttpResponseMessage EnsureSuccessStatusCode()
		{
		}

		/// <summary>Returns a string that represents the current object.</summary>
		/// <returns>Returns <see cref="T:System.String" />.A string representation of the current object.</returns>
		public override string ToString()
		{
		}

		public void Dispose()
		{
		}
	}
}