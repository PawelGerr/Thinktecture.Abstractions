using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.Net.Http
{
	/// <summary>Represents a HTTP request message.</summary>
	public class HttpRequestMessageAdapter : IHttpRequestMessage
	{
		public HttpRequestMessage UnsafeConvert()
		{
			throw new NotImplementedException();
		}

		/// <summary>Gets or sets the HTTP message version.</summary>
		/// <returns>Returns <see cref="T:System.Version" />.The HTTP message version. The default is 1.1.</returns>
		public Version Version { get; set; }

		/// <summary>Gets or sets the contents of the HTTP message. </summary>
		/// <returns>Returns <see cref="T:System.Net.Http.HttpContent" />.The content of a message</returns>
		public HttpContent Content { get; set; }

		/// <summary>Gets or sets the HTTP method used by the HTTP request message.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.HttpMethod" />.The HTTP method used by the request message. The default is the GET method.</returns>
		public HttpMethod Method { get; set; }

		/// <summary>Gets or sets the <see cref="T:System.Uri" /> used for the HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Uri" />.The <see cref="T:System.Uri" /> used for the HTTP request.</returns>
		public Uri RequestUri { get; set; }

		/// <summary>Gets the collection of HTTP request headers.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpRequestHeaders" />.The collection of HTTP request headers.</returns>
		public HttpRequestHeaders Headers { get; }

		/// <summary>Gets a set of properties for the HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Collections.Generic.IDictionary`2" />.</returns>
		public IDictionary<string, object> Properties { get; }

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.HttpRequestMessage" /> class.</summary>
		public HttpRequestMessage()
			: this(HttpMethod.Get, (Uri) null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.HttpRequestMessage" /> class with an HTTP method and a request <see cref="T:System.Uri" />.</summary>
		/// <param name="method">The HTTP method.</param>
		/// <param name="requestUri">The <see cref="T:System.Uri" /> to request.</param>
		public HttpRequestMessage(HttpMethod method, Uri requestUri)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.HttpRequestMessage" /> class with an HTTP method and a request <see cref="T:System.Uri" />.</summary>
		/// <param name="method">The HTTP method.</param>
		/// <param name="requestUri">A string that represents the request  <see cref="T:System.Uri" />.</param>
		public HttpRequestMessage(HttpMethod method, string requestUri)
		{
		}

		/// <summary>Returns a string that represents the current object.</summary>
		/// <returns>Returns <see cref="T:System.String" />.A string representation of the current object.</returns>
		public override string ToString()
		{
		}

		/// <summary>Releases the unmanaged resources and disposes of the managed resources used by the <see cref="T:System.Net.Http.HttpRequestMessage" />.</summary>
		public void Dispose()
		{
		}
	}
}