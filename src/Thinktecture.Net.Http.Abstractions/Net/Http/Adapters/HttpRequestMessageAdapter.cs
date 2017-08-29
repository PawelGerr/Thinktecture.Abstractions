using System;
using System.Collections.Generic;
using System.Net.Http;
using JetBrains.Annotations;
using Thinktecture.Net.Http.Headers;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.Http.Adapters
{
	/// <summary>Represents a HTTP request message.</summary>
	public class HttpRequestMessageAdapter : AbstractionAdapter<HttpRequestMessage>, IHttpRequestMessage
	{
		/// <inheritdoc />
		public Version Version
		{
			get => Implementation.Version;
			set => Implementation.Version = value;
		}

		/// <inheritdoc />
		public IHttpContent Content
		{
			get => Implementation.Content.ToInterface();
			set => Implementation.Content = value.ToImplementation();
		}

		/// <inheritdoc />
		public HttpMethod Method
		{
			get => Implementation.Method;
			set => Implementation.Method = value;
		}

		/// <inheritdoc />
		public Uri RequestUri
		{
			get => Implementation.RequestUri;
			set => Implementation.RequestUri = value;
		}

		/// <inheritdoc />
		public IHttpRequestHeaders Headers => Implementation.Headers.ToInterface();

		/// <inheritdoc />
		public IDictionary<string, object> Properties => Implementation.Properties;

		/// <summary>Initializes a new instance of the <see cref="HttpRequestMessageAdapter" /> class.</summary>
		public HttpRequestMessageAdapter()
			: this(new HttpRequestMessage())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="HttpRequestMessageAdapter" /> class with an HTTP method and a request <see cref="T:System.Uri" />.</summary>
		/// <param name="method">The HTTP method.</param>
		/// <param name="requestUri">The <see cref="T:System.Uri" /> to request.</param>
		public HttpRequestMessageAdapter([NotNull] HttpMethod method, [CanBeNull] Uri requestUri)
			: this(new HttpRequestMessage(method, requestUri))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="HttpRequestMessageAdapter" /> class with an HTTP method and a request <see cref="T:System.Uri" />.</summary>
		/// <param name="method">The HTTP method.</param>
		/// <param name="requestUri">A string that represents the request  <see cref="T:System.Uri" />.</param>
		public HttpRequestMessageAdapter([NotNull] HttpMethod method, [CanBeNull] string requestUri)
			: this(new HttpRequestMessage(method, requestUri))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="HttpRequestMessageAdapter" /> class.</summary>
		/// <param name="message">Message to be used by the adapter.</param>
		public HttpRequestMessageAdapter([NotNull] HttpRequestMessage message)
			: base(message)
		{
		}

		/// <inheritdoc />
		public void Dispose()
		{
			Implementation.Dispose();
		}
	}
}
