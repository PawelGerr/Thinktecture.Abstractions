using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using Thinktecture.Net.Http.Headers;

namespace Thinktecture.Net.Http.Adapters
{
	/// <summary>Represents a HTTP request message.</summary>
	public class HttpRequestMessageAdapter : IHttpRequestMessage
	{
		private readonly HttpRequestMessage _message;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public HttpRequestMessage UnsafeConvert()
		{
			return _message;
		}

		/// <inheritdoc />
		public Version Version
		{
			get { return _message.Version; }
			set { _message.Version = value; }
		}

		/// <inheritdoc />
		public IHttpContent Content
		{
			get { return _message.Content.ToInterface(); }
			set { _message.Content = value.ToImplementation(); }
		}

		/// <inheritdoc />
		public HttpMethod Method
		{
			get { return _message.Method; }
			set { _message.Method = value; }
		}

		/// <inheritdoc />
		public Uri RequestUri
		{
			get { return _message.RequestUri; }
			set { _message.RequestUri = value; }
		}

		/// <inheritdoc />
		public IHttpRequestHeaders Headers => _message.Headers.ToInterface();

		/// <inheritdoc />
		public IDictionary<string, object> Properties => _message.Properties;

		/// <summary>Initializes a new instance of the <see cref="HttpRequestMessageAdapter" /> class.</summary>
		public HttpRequestMessageAdapter()
			: this(new HttpRequestMessage())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="HttpRequestMessageAdapter" /> class with an HTTP method and a request <see cref="T:System.Uri" />.</summary>
		/// <param name="method">The HTTP method.</param>
		/// <param name="requestUri">The <see cref="T:System.Uri" /> to request.</param>
		public HttpRequestMessageAdapter(HttpMethod method, Uri requestUri)
			: this(new HttpRequestMessage(method, requestUri))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="HttpRequestMessageAdapter" /> class with an HTTP method and a request <see cref="T:System.Uri" />.</summary>
		/// <param name="method">The HTTP method.</param>
		/// <param name="requestUri">A string that represents the request  <see cref="T:System.Uri" />.</param>
		public HttpRequestMessageAdapter(HttpMethod method, string requestUri)
			: this(new HttpRequestMessage(method, requestUri))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="HttpRequestMessageAdapter" /> class.</summary>
		/// <param name="message">Message to be used by the adapter.</param>
		public HttpRequestMessageAdapter(HttpRequestMessage message)
		{
			if (message == null)
				throw new ArgumentNullException(nameof(message));

			_message = message;
		}

		/// <inheritdoc />
		public void Dispose()
		{
			_message.Dispose();
		}

		/// <inheritdoc />
		public override string ToString()
		{
			return _message.ToString();
		}

		/// <inheritdoc />
		public override bool Equals(object obj)
		{
			return _message.Equals(obj);
		}

		/// <inheritdoc />
		public override int GetHashCode()
		{
			return _message.GetHashCode();
		}
	}
}