using System;
using System.ComponentModel;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Thinktecture.IO;
using Thinktecture.Net.Http.Headers;

// ReSharper disable PossibleNullReferenceException

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.Http.Adapters
{
	/// <summary>Provides a base class for sending HTTP requests and receiving HTTP responses from a resource identified by a URI. </summary>
	public class HttpClientAdapter : HttpMessageInvokerAdapter, IHttpClient
	{
		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		[NotNull]
		protected new HttpClient Implementation;

		/// <inheritdoc />
		[NotNull]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new HttpClient UnsafeConvert()
		{
			return Implementation;
		}

		/// <inheritdoc />
		public IHttpRequestHeaders DefaultRequestHeaders => Implementation.DefaultRequestHeaders.ToInterface();

		/// <inheritdoc />
		public Uri BaseAddress
		{
			get => Implementation.BaseAddress;
			set => Implementation.BaseAddress = value;
		}

		/// <inheritdoc />
		public TimeSpan Timeout
		{
			get => Implementation.Timeout;
			set => Implementation.Timeout = value;
		}

		/// <inheritdoc />
		public long MaxResponseContentBufferSize
		{
			get => Implementation.MaxResponseContentBufferSize;
			set => Implementation.MaxResponseContentBufferSize = value;
		}

		/// <summary>Initializes a new instance of the <see cref="HttpClientAdapter" /> class.</summary>
		public HttpClientAdapter()
			: this(new HttpClient())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="HttpClientAdapter" /> class with a specific handler.</summary>
		/// <param name="handler">The HTTP handler stack to use for sending requests. </param>
		public HttpClientAdapter([NotNull] HttpMessageHandler handler)
			: this(new HttpClient(handler))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="HttpClientAdapter" /> class with a specific handler.</summary>
		/// <param name="handler">The HTTP handler stack to use for sending requests. </param>
		public HttpClientAdapter([NotNull] IHttpMessageHandler handler)
			: this(handler.ToImplementation())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="HttpClientAdapter" /> class with a specific handler.</summary>
		/// <param name="handler">The <see cref="T:System.Net.Http.HttpMessageHandler" /> responsible for processing the HTTP response messages.</param>
		/// <param name="disposeHandler">true if the inner handler should be disposed of by Dispose(),false if you intend to reuse the inner handler.</param>
		public HttpClientAdapter([NotNull] HttpMessageHandler handler, bool disposeHandler)
			: this(new HttpClient(handler, disposeHandler))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="HttpClientAdapter" /> class with a specific handler.</summary>
		/// <param name="handler">The <see cref="T:System.Net.Http.HttpMessageHandler" /> responsible for processing the HTTP response messages.</param>
		/// <param name="disposeHandler">true if the inner handler should be disposed of by Dispose(),false if you intend to reuse the inner handler.</param>
		public HttpClientAdapter([NotNull] IHttpMessageHandler handler, bool disposeHandler)
			: this(handler.ToImplementation(), disposeHandler)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="HttpClientAdapter" /> class.
		/// </summary>
		/// <param name="client">Client to be used by the adapter.</param>
		public HttpClientAdapter([NotNull] HttpClient client)
			: base(client)
		{
			Implementation = client ?? throw new ArgumentNullException(nameof(client));
		}

		/// <inheritdoc />
		public Task<string> GetStringAsync(string requestUri)
		{
			return Implementation.GetStringAsync(requestUri);
		}

		/// <inheritdoc />
		public Task<string> GetStringAsync(Uri requestUri)
		{
			return Implementation.GetStringAsync(requestUri);
		}

		/// <inheritdoc />
		public Task<byte[]> GetByteArrayAsync(string requestUri)
		{
			return Implementation.GetByteArrayAsync(requestUri);
		}

		/// <inheritdoc />
		public Task<byte[]> GetByteArrayAsync(Uri requestUri)
		{
			return Implementation.GetByteArrayAsync(requestUri);
		}

		/// <inheritdoc />
		public async Task<IStream> GetStreamAsync(string requestUri)
		{
			var stream = await Implementation.GetStreamAsync(requestUri).ConfigureAwait(false);
			return stream.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IStream> GetStreamAsync(Uri requestUri)
		{
			var stream = await Implementation.GetStreamAsync(requestUri).ConfigureAwait(false);
			return stream.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> GetAsync(string requestUri)
		{
			var message = await Implementation.GetAsync(requestUri).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> GetAsync(Uri requestUri)
		{
			var message = await Implementation.GetAsync(requestUri).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption)
		{
			var message = await Implementation.GetAsync(requestUri, completionOption).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption)
		{
			var message = await Implementation.GetAsync(requestUri, completionOption).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> GetAsync(string requestUri, CancellationToken cancellationToken)
		{
			var message = await Implementation.GetAsync(requestUri, cancellationToken).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken)
		{
			var message = await Implementation.GetAsync(requestUri, cancellationToken).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			var message = await Implementation.GetAsync(requestUri, completionOption, cancellationToken).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			var message = await Implementation.GetAsync(requestUri, completionOption, cancellationToken).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PostAsync(string requestUri, HttpContent content)
		{
			var message = await Implementation.PostAsync(requestUri, content).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PostAsync(string requestUri, IHttpContent content)
		{
			var message = await Implementation.PostAsync(requestUri, content.ToImplementation()).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PostAsync(Uri requestUri, HttpContent content)
		{
			var message = await Implementation.PostAsync(requestUri, content).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PostAsync(Uri requestUri, IHttpContent content)
		{
			var message = await Implementation.PostAsync(requestUri, content.ToImplementation()).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			var message = await Implementation.PostAsync(requestUri, content, cancellationToken).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PostAsync(string requestUri, IHttpContent content, CancellationToken cancellationToken)
		{
			var message = await Implementation.PostAsync(requestUri, content.ToImplementation(), cancellationToken).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			var message = await Implementation.PostAsync(requestUri, content, cancellationToken).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PostAsync(Uri requestUri, IHttpContent content, CancellationToken cancellationToken)
		{
			var message = await Implementation.PostAsync(requestUri, content.ToImplementation(), cancellationToken).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PutAsync(string requestUri, HttpContent content)
		{
			var message = await Implementation.PutAsync(requestUri, content).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PutAsync(string requestUri, IHttpContent content)
		{
			var message = await Implementation.PutAsync(requestUri, content.ToImplementation()).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PutAsync(Uri requestUri, HttpContent content)
		{
			var message = await Implementation.PutAsync(requestUri, content).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PutAsync(Uri requestUri, IHttpContent content)
		{
			var message = await Implementation.PutAsync(requestUri, content.ToImplementation()).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PutAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			var message = await Implementation.PutAsync(requestUri, content, cancellationToken).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PutAsync(string requestUri, IHttpContent content, CancellationToken cancellationToken)
		{
			var message = await Implementation.PutAsync(requestUri, content.ToImplementation(), cancellationToken).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			var message = await Implementation.PutAsync(requestUri, content, cancellationToken).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> PutAsync(Uri requestUri, IHttpContent content, CancellationToken cancellationToken)
		{
			var message = await Implementation.PutAsync(requestUri, content.ToImplementation(), cancellationToken).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> DeleteAsync(string requestUri)
		{
			var message = await Implementation.DeleteAsync(requestUri).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> DeleteAsync(Uri requestUri)
		{
			var message = await Implementation.DeleteAsync(requestUri).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> DeleteAsync(string requestUri, CancellationToken cancellationToken)
		{
			var message = await Implementation.DeleteAsync(requestUri, cancellationToken).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken)
		{
			var message = await Implementation.DeleteAsync(requestUri, cancellationToken).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> SendAsync(HttpRequestMessage request)
		{
			var message = await Implementation.SendAsync(request).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> SendAsync(IHttpRequestMessage request)
		{
			var message = await Implementation.SendAsync(request.ToImplementation()).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption)
		{
			var message = await Implementation.SendAsync(request, completionOption).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> SendAsync(IHttpRequestMessage request, HttpCompletionOption completionOption)
		{
			var message = await Implementation.SendAsync(request.ToImplementation(), completionOption).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			var message = await Implementation.SendAsync(request, completionOption, cancellationToken).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> SendAsync(IHttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			var message = await Implementation.SendAsync(request.ToImplementation(), completionOption, cancellationToken).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public void CancelPendingRequests()
		{
			Implementation.CancelPendingRequests();
		}
	}
}
