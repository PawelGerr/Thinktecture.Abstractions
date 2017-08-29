using System;
using System.Net;
using System.Net.Http;
using JetBrains.Annotations;
using Thinktecture.Net.Http.Headers;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.Http.Adapters
{
	/// <summary>Represents a HTTP response message including the status code and data.</summary>
	public class HttpResponseMessageAdapter : AbstractionAdapter<HttpResponseMessage>, IHttpResponseMessage
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
		public HttpStatusCode StatusCode
		{
			get => Implementation.StatusCode;
			set => Implementation.StatusCode = value;
		}

		/// <inheritdoc />
		public string ReasonPhrase
		{
			get => Implementation.ReasonPhrase;
			set => Implementation.ReasonPhrase = value;
		}

		/// <inheritdoc />
		public IHttpResponseHeaders Headers => Implementation.Headers.ToInterface();

		/// <inheritdoc />
		public IHttpRequestMessage RequestMessage
		{
			get => Implementation.RequestMessage.ToInterface();
			set => Implementation.RequestMessage = value.ToImplementation();
		}

		/// <inheritdoc />
		public bool IsSuccessStatusCode => Implementation.IsSuccessStatusCode;

		/// <summary>Initializes a new instance of the <see cref="HttpResponseMessageAdapter" /> class.</summary>
		public HttpResponseMessageAdapter()
			: this(new HttpResponseMessage())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="HttpResponseMessageAdapter" /> class with a specific <see cref="P:System.Net.Http.HttpResponseMessage.StatusCode" />.</summary>
		/// <param name="statusCode">The status code of the HTTP response.</param>
		public HttpResponseMessageAdapter(HttpStatusCode statusCode)
			: this(new HttpResponseMessage(statusCode))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="HttpResponseMessageAdapter" /> class.
		/// </summary>
		/// <param name="message">Message to be used by the adapter.</param>
		public HttpResponseMessageAdapter([NotNull] HttpResponseMessage message)
			: base(message)
		{
		}

		/// <inheritdoc />
		public IHttpResponseMessage EnsureSuccessStatusCode()
		{
			return Implementation.EnsureSuccessStatusCode().ToInterface();
		}

		/// <inheritdoc />
		public void Dispose()
		{
			Implementation.Dispose();
		}
	}
}
