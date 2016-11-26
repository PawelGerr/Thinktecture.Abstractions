using System;
using System.ComponentModel;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Thinktecture.IO;
using Thinktecture.Net.Http.Headers;

namespace Thinktecture.Net.Http.Adapters
{
	/// <summary>Provides a base class for sending HTTP requests and receiving HTTP responses from a resource identified by a URI. </summary>
	public class HttpClientAdapter : HttpMessageInvokerAdapter, IHttpClient
	{
		private readonly HttpClient _client;

		/// <summary>
		/// Gets inner instance of <see cref="HttpClient"/>.
		/// It is not intended to be used directly. Use <see cref="HttpClientExtensions.ToImplementation"/> instead.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new HttpClient UnsafeConvert()
		{
			return _client;
		}

		/// <inheritdoc />
		public IHttpRequestHeaders DefaultRequestHeaders => _client.DefaultRequestHeaders.ToInterface();

		/// <inheritdoc />
		public Uri BaseAddress
		{
			get { return _client.BaseAddress; }
			set { _client.BaseAddress = value; }
		}

		/// <inheritdoc />
		public TimeSpan Timeout
		{
			get { return _client.Timeout; }
			set { _client.Timeout = value; }
		}

		/// <inheritdoc />
		public long MaxResponseContentBufferSize
		{
			get { return _client.MaxResponseContentBufferSize; }
			set { _client.MaxResponseContentBufferSize = value; }
		}

		/// <summary>Initializes a new instance of the <see cref="HttpClientAdapter" /> class.</summary>
		public HttpClientAdapter()
			: this(new HttpClient())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="HttpClientAdapter" /> class with a specific handler.</summary>
		/// <param name="handler">The HTTP handler stack to use for sending requests. </param>
		public HttpClientAdapter(HttpMessageHandler handler)
			: this(new HttpClient(handler))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="HttpClientAdapter" /> class with a specific handler.</summary>
		/// <param name="handler">The HTTP handler stack to use for sending requests. </param>
		public HttpClientAdapter(IHttpMessageHandler handler)
			: this(new HttpClient(handler.ToImplementation()))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="HttpClientAdapter" /> class with a specific handler.</summary>
		/// <param name="handler">The <see cref="T:System.Net.Http.HttpMessageHandler" /> responsible for processing the HTTP response messages.</param>
		/// <param name="disposeHandler">true if the inner handler should be disposed of by Dispose(),false if you intend to reuse the inner handler.</param>
		public HttpClientAdapter(HttpMessageHandler handler, bool disposeHandler)
			: base(new HttpClient(handler, disposeHandler))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="HttpClientAdapter" /> class with a specific handler.</summary>
		/// <param name="handler">The <see cref="T:System.Net.Http.HttpMessageHandler" /> responsible for processing the HTTP response messages.</param>
		/// <param name="disposeHandler">true if the inner handler should be disposed of by Dispose(),false if you intend to reuse the inner handler.</param>
		public HttpClientAdapter(IHttpMessageHandler handler, bool disposeHandler)
			: this(new HttpClient(handler.ToImplementation(), disposeHandler))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="HttpClientAdapter" /> class.
		/// </summary>
		/// <param name="client">Client to be used by the adapter.</param>
		public HttpClientAdapter(HttpClient client)
			: base(client)
		{
			if (client == null)
				throw new ArgumentNullException(nameof(client));

			_client = client;
		}

		/// <inheritdoc />
		public Task<string> GetStringAsync(string requestUri)
		{
			return _client.GetStringAsync(requestUri);
		}

		/// <inheritdoc />
		public Task<string> GetStringAsync(Uri requestUri)
		{
			return _client.GetStringAsync(requestUri);
		}

		/// <inheritdoc />
		public Task<byte[]> GetByteArrayAsync(string requestUri)
		{
			return _client.GetByteArrayAsync(requestUri);
		}

		/// <inheritdoc />
		public Task<byte[]> GetByteArrayAsync(Uri requestUri)
		{
			return _client.GetByteArrayAsync(requestUri);
		}

		/// <inheritdoc />
		public async Task<IStream> GetStreamAsync(string requestUri)
		{
			return (await _client.GetStreamAsync(requestUri)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IStream> GetStreamAsync(Uri requestUri)
		{
			return (await _client.GetStreamAsync(requestUri)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> GetAsync(string requestUri)
		{
			return (await _client.GetAsync(requestUri)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> GetAsync(Uri requestUri)
		{
			return (await _client.GetAsync(requestUri)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption)
		{
			return (await _client.GetAsync(requestUri, completionOption)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption)
		{
			return (await _client.GetAsync(requestUri, completionOption)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> GetAsync(string requestUri, CancellationToken cancellationToken)
		{
			return (await _client.GetAsync(requestUri, cancellationToken)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken)
		{
			return (await _client.GetAsync(requestUri, cancellationToken)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			return (await _client.GetAsync(requestUri, completionOption, cancellationToken)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			return (await _client.GetAsync(requestUri, completionOption, cancellationToken)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PostAsync(string requestUri, HttpContent content)
		{
			return (await _client.PostAsync(requestUri, content)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PostAsync(string requestUri, IHttpContent content)
		{
			return (await _client.PostAsync(requestUri, content.ToImplementation())).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PostAsync(Uri requestUri, HttpContent content)
		{
			return (await _client.PostAsync(requestUri, content)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PostAsync(Uri requestUri, IHttpContent content)
		{
			return (await _client.PostAsync(requestUri, content.ToImplementation())).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			return (await _client.PostAsync(requestUri, content, cancellationToken)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PostAsync(string requestUri, IHttpContent content, CancellationToken cancellationToken)
		{
			return (await _client.PostAsync(requestUri, content.ToImplementation(), cancellationToken)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			return (await _client.PostAsync(requestUri, content, cancellationToken)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PostAsync(Uri requestUri, IHttpContent content, CancellationToken cancellationToken)
		{
			return (await _client.PostAsync(requestUri, content.ToImplementation(), cancellationToken)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PutAsync(string requestUri, HttpContent content)
		{
			return (await _client.PutAsync(requestUri, content)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PutAsync(string requestUri, IHttpContent content)
		{
			return (await _client.PutAsync(requestUri, content.ToImplementation())).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PutAsync(Uri requestUri, HttpContent content)
		{
			return (await _client.PutAsync(requestUri, content)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PutAsync(Uri requestUri, IHttpContent content)
		{
			return (await _client.PutAsync(requestUri, content.ToImplementation())).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PutAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			return (await _client.PutAsync(requestUri, content, cancellationToken)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PutAsync(string requestUri, IHttpContent content, CancellationToken cancellationToken)
		{
			return (await _client.PutAsync(requestUri, content.ToImplementation(), cancellationToken)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			return (await _client.PutAsync(requestUri, content, cancellationToken)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PutAsync(Uri requestUri, IHttpContent content, CancellationToken cancellationToken)
		{
			return (await _client.PutAsync(requestUri, content.ToImplementation(), cancellationToken)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> DeleteAsync(string requestUri)
		{
			return (await _client.DeleteAsync(requestUri)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> DeleteAsync(Uri requestUri)
		{
			return (await _client.DeleteAsync(requestUri)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> DeleteAsync(string requestUri, CancellationToken cancellationToken)
		{
			return (await _client.DeleteAsync(requestUri, cancellationToken)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken)
		{
			return (await _client.DeleteAsync(requestUri, cancellationToken)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> SendAsync(HttpRequestMessage request)
		{
			return (await _client.SendAsync(request)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> SendAsync(IHttpRequestMessage request)
		{
			return (await _client.SendAsync(request.ToImplementation())).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption)
		{
			return (await _client.SendAsync(request, completionOption)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> SendAsync(IHttpRequestMessage request, HttpCompletionOption completionOption)
		{
			return (await _client.SendAsync(request.ToImplementation(), completionOption)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			return (await _client.SendAsync(request, completionOption, cancellationToken)).ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> SendAsync(IHttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			return (await _client.SendAsync(request.ToImplementation(), completionOption, cancellationToken)).ToInterface();
		}

		/// <inheritdoc />
		public void CancelPendingRequests()
		{
			_client.CancelPendingRequests();
		}
	}
}