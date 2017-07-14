using System;
using System.ComponentModel;
using System.Net;
using System.Net.Http;
using Thinktecture.Net.Http.Headers;

namespace Thinktecture.Net.Http.Adapters
{
	/// <summary>Represents a HTTP response message including the status code and data.</summary>
	public class HttpResponseMessageAdapter : AbstractionAdapter, IHttpResponseMessage
	{
		private readonly HttpResponseMessage _message;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new HttpResponseMessage UnsafeConvert()
		{
			return _message;
		}

		/// <inheritdoc />
		public Version Version
		{
			get => _message.Version;
			set => _message.Version = value;
		}

		/// <inheritdoc />
		public IHttpContent Content
		{
			get => _message.Content.ToInterface();
			set => _message.Content = value.ToImplementation();
		}

		/// <inheritdoc />
		public HttpStatusCode StatusCode
		{
			get => _message.StatusCode;
			set => _message.StatusCode = value;
		}

		/// <inheritdoc />
		public string ReasonPhrase
		{
			get => _message.ReasonPhrase;
			set => _message.ReasonPhrase = value;
		}

		/// <inheritdoc />
		public IHttpResponseHeaders Headers => _message.Headers.ToInterface();

		/// <inheritdoc />
		public IHttpRequestMessage RequestMessage
		{
			get => _message.RequestMessage.ToInterface();
			set => _message.RequestMessage = value.ToImplementation();
		}

		/// <inheritdoc />
		public bool IsSuccessStatusCode => _message.IsSuccessStatusCode;

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
		public HttpResponseMessageAdapter(HttpResponseMessage message)
			: base(message)
		{
			_message = message ?? throw new ArgumentNullException(nameof(message));
		}

		/// <inheritdoc />
		public IHttpResponseMessage EnsureSuccessStatusCode()
		{
			return _message.EnsureSuccessStatusCode().ToInterface();
		}

		/// <inheritdoc />
		public void Dispose()
		{
			_message.Dispose();
		}
	}
}