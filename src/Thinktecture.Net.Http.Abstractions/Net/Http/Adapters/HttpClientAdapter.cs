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

		/// <inheritdoc />
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
			get => _client.BaseAddress;
			set => _client.BaseAddress = value;
		}

		/// <inheritdoc />
		public TimeSpan Timeout
		{
			get => _client.Timeout;
			set => _client.Timeout = value;
		}

		/// <inheritdoc />
		public long MaxResponseContentBufferSize
		{
			get => _client.MaxResponseContentBufferSize;
			set => _client.MaxResponseContentBufferSize = value;
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
			_client = client ?? throw new ArgumentNullException(nameof(client));
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
		public Task<IStream> GetStreamAsync(string requestUri)
		{
			return _client.GetStreamAsync(requestUri)
						.ContinueWith(t => t.Result.ToInterface());
		}

		/// <inheritdoc />
		public Task<IStream> GetStreamAsync(Uri requestUri)
		{
			return _client.GetStreamAsync(requestUri)
						.ContinueWith(t => t.Result.ToInterface());
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> GetAsync(string requestUri)
		{
			return _client.GetAsync(requestUri)
						.ContinueWith(task => task.Result.ToInterface());
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> GetAsync(Uri requestUri)
		{
			return _client.GetAsync(requestUri)
						.ContinueWith(t => t.Result.ToInterface());
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption)
		{
			return _client.GetAsync(requestUri, completionOption)
						.ContinueWith(t => t.Result.ToInterface());
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption)
		{
			return _client.GetAsync(requestUri, completionOption)
						.ContinueWith(t => t.Result.ToInterface());
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> GetAsync(string requestUri, CancellationToken cancellationToken)
		{
			return _client.GetAsync(requestUri, cancellationToken)
						.ContinueWith(t => t.Result.ToInterface(), cancellationToken);
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken)
		{
			return _client.GetAsync(requestUri, cancellationToken)
						.ContinueWith(t => t.Result.ToInterface(), cancellationToken);
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			return _client.GetAsync(requestUri, completionOption, cancellationToken)
						.ContinueWith(t => t.Result.ToInterface(), cancellationToken);
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			return _client.GetAsync(requestUri, completionOption, cancellationToken)
						.ContinueWith(t => t.Result.ToInterface(), cancellationToken);
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> PostAsync(string requestUri, HttpContent content)
		{
			return _client.PostAsync(requestUri, content)
						.ContinueWith(t => t.Result.ToInterface());
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> PostAsync(string requestUri, IHttpContent content)
		{
			return _client.PostAsync(requestUri, content.ToImplementation())
						.ContinueWith(t => t.Result.ToInterface());
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> PostAsync(Uri requestUri, HttpContent content)
		{
			return _client.PostAsync(requestUri, content)
						.ContinueWith(t => t.Result.ToInterface());
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> PostAsync(Uri requestUri, IHttpContent content)
		{
			return _client.PostAsync(requestUri, content.ToImplementation())
						.ContinueWith(t => t.Result.ToInterface());
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			return _client.PostAsync(requestUri, content, cancellationToken)
						.ContinueWith(t => t.Result.ToInterface(), cancellationToken);
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> PostAsync(string requestUri, IHttpContent content, CancellationToken cancellationToken)
		{
			return _client.PostAsync(requestUri, content.ToImplementation(), cancellationToken)
						.ContinueWith(t => t.Result.ToInterface(), cancellationToken);
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			return _client.PostAsync(requestUri, content, cancellationToken)
						.ContinueWith(t => t.Result.ToInterface(), cancellationToken);
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> PostAsync(Uri requestUri, IHttpContent content, CancellationToken cancellationToken)
		{
			return _client.PostAsync(requestUri, content.ToImplementation(), cancellationToken)
						.ContinueWith(t => t.Result.ToInterface(), cancellationToken);
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> PutAsync(string requestUri, HttpContent content)
		{
			return _client.PutAsync(requestUri, content)
						.ContinueWith(t => t.Result.ToInterface());
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> PutAsync(string requestUri, IHttpContent content)
		{
			return _client.PutAsync(requestUri, content.ToImplementation())
						.ContinueWith(t => t.Result.ToInterface());
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> PutAsync(Uri requestUri, HttpContent content)
		{
			return _client.PutAsync(requestUri, content)
						.ContinueWith(t => t.Result.ToInterface());
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> PutAsync(Uri requestUri, IHttpContent content)
		{
			return _client.PutAsync(requestUri, content.ToImplementation())
						.ContinueWith(t => t.Result.ToInterface());
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> PutAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			return _client.PutAsync(requestUri, content, cancellationToken)
						.ContinueWith(t => t.Result.ToInterface(), cancellationToken);
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> PutAsync(string requestUri, IHttpContent content, CancellationToken cancellationToken)
		{
			return _client.PutAsync(requestUri, content.ToImplementation(), cancellationToken)
						.ContinueWith(t => t.Result.ToInterface(), cancellationToken);
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			return _client.PutAsync(requestUri, content, cancellationToken)
						.ContinueWith(t => t.Result.ToInterface(), cancellationToken);
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> PutAsync(Uri requestUri, IHttpContent content, CancellationToken cancellationToken)
		{
			return _client.PutAsync(requestUri, content.ToImplementation(), cancellationToken)
						.ContinueWith(t => t.Result.ToInterface(), cancellationToken);
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> DeleteAsync(string requestUri)
		{
			return _client.DeleteAsync(requestUri)
						.ContinueWith(t => t.Result.ToInterface());
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> DeleteAsync(Uri requestUri)
		{
			return _client.DeleteAsync(requestUri)
						.ContinueWith(t => t.Result.ToInterface());
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> DeleteAsync(string requestUri, CancellationToken cancellationToken)
		{
			return _client.DeleteAsync(requestUri, cancellationToken)
						.ContinueWith(t => t.Result.ToInterface(), cancellationToken);
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken)
		{
			return _client.DeleteAsync(requestUri, cancellationToken)
						.ContinueWith(t => t.Result.ToInterface(), cancellationToken);
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> SendAsync(HttpRequestMessage request)
		{
			return _client.SendAsync(request)
						.ContinueWith(t => t.Result.ToInterface());
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> SendAsync(IHttpRequestMessage request)
		{
			return _client.SendAsync(request.ToImplementation())
						.ContinueWith(t => t.Result.ToInterface());
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption)
		{
			return _client.SendAsync(request, completionOption)
						.ContinueWith(t => t.Result.ToInterface());
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> SendAsync(IHttpRequestMessage request, HttpCompletionOption completionOption)
		{
			return _client.SendAsync(request.ToImplementation(), completionOption)
						.ContinueWith(t => t.Result.ToInterface());
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			return _client.SendAsync(request, completionOption, cancellationToken)
						.ContinueWith(t => t.Result.ToInterface(), cancellationToken);
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> SendAsync(IHttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			return _client.SendAsync(request.ToImplementation(), completionOption, cancellationToken)
						.ContinueWith(t => t.Result.ToInterface(), cancellationToken);
		}

		/// <inheritdoc />
		public void CancelPendingRequests()
		{
			_client.CancelPendingRequests();
		}
	}
}
