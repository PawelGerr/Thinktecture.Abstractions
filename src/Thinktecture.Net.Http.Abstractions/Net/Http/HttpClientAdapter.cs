using System;
using System.ComponentModel;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Thinktecture.IO;

namespace Thinktecture.Net.Http
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
		public HttpClient UnsafeConvert()
		{
			return _client;
		}

		/// <summary>Gets the headers which should be sent with each request.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpRequestHeaders" />.The headers which should be sent with each request.</returns>
		public IHttpRequestHeaders DefaultRequestHeaders => _client.DefaultRequestHeaders.ToInterface();

		/// <summary>Gets or sets the base address of Uniform Resource Identifier (URI) of the Internet resource used when sending requests.</summary>
		/// <returns>Returns <see cref="T:System.Uri" />.The base address of Uniform Resource Identifier (URI) of the Internet resource used when sending requests.</returns>
		public Uri BaseAddress
		{
			get { return _client.BaseAddress; }
			set { _client.BaseAddress = value; }
		}

		/// <summary>Gets or sets the timespan to wait before the request times out.</summary>
		/// <returns>Returns <see cref="T:System.TimeSpan" />.The timespan to wait before the request times out.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The timeout specified is less than or equal to zero and is not <see cref="F:System.Threading.Timeout.InfiniteTimeSpan" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">An operation has already been started on the current instance. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The current instance has been disposed.</exception>
		public TimeSpan Timeout
		{
			get { return _client.Timeout; }
			set { _client.Timeout = value; }
		}

		/// <summary>Gets or sets the maximum number of bytes to buffer when reading the response content.</summary>
		/// <returns>Returns <see cref="T:System.Int32" />.The maximum number of bytes to buffer when reading the response content. The default value for this property is 2 gigabytes.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The size specified is less than or equal to zero.</exception>
		/// <exception cref="T:System.InvalidOperationException">An operation has already been started on the current instance. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The current instance has been disposed. </exception>
		public long MaxResponseContentBufferSize
		{
			get { return _client.MaxResponseContentBufferSize; }
			set { _client.MaxResponseContentBufferSize = value; }
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.HttpClient" /> class.</summary>
		public HttpClientAdapter()
			: this(new HttpClient())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.HttpClient" /> class with a specific handler.</summary>
		/// <param name="handler">The HTTP handler stack to use for sending requests. </param>
		public HttpClientAdapter(HttpMessageHandler handler)
			: this(new HttpClient(handler, true))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.HttpClient" /> class with a specific handler.</summary>
		/// <param name="handler">The HTTP handler stack to use for sending requests. </param>
		public HttpClientAdapter(IHttpMessageHandler handler)
			: this(new HttpClient(handler.ToImplementation(), true))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.HttpClient" /> class with a specific handler.</summary>
		/// <param name="handler">The <see cref="T:System.Net.Http.HttpMessageHandler" /> responsible for processing the HTTP response messages.</param>
		/// <param name="disposeHandler">true if the inner handler should be disposed of by Dispose(),false if you intend to reuse the inner handler.</param>
		public HttpClientAdapter(HttpMessageHandler handler, bool disposeHandler)
			: base(new HttpClient(handler, disposeHandler))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.HttpClient" /> class with a specific handler.</summary>
		/// <param name="handler">The <see cref="T:System.Net.Http.HttpMessageHandler" /> responsible for processing the HTTP response messages.</param>
		/// <param name="disposeHandler">true if the inner handler should be disposed of by Dispose(),false if you intend to reuse the inner handler.</param>
		public HttpClientAdapter(IHttpMessageHandler handler, bool disposeHandler)
			: this(new HttpClient(handler.ToImplementation(), disposeHandler))
		{
		}

		/// <summary>
		/// >Initializes a new instance of the <see cref="HttpClientAdapter" /> class
		/// </summary>
		/// <param name="client">Client to be used by the adapter.</param>
		public HttpClientAdapter(HttpClient client)
			: base(client)
		{
			if (client == null)
				throw new ArgumentNullException(nameof(client));

			_client = client;
		}

		/// <summary>Send a GET request to the specified Uri and return the response body as a string in an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<string> GetStringAsync(string requestUri)
		{
			return _client.GetStringAsync(requestUri);
		}

		/// <summary>Send a GET request to the specified Uri and return the response body as a string in an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<string> GetStringAsync(Uri requestUri)
		{
			return _client.GetStringAsync(requestUri);
		}

		/// <summary>Send a GET request to the specified Uri and return the response body as a byte array in an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<byte[]> GetByteArrayAsync(string requestUri)
		{
			return _client.GetByteArrayAsync(requestUri);
		}

		/// <summary>Send a GET request to the specified Uri and return the response body as a byte array in an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<byte[]> GetByteArrayAsync(Uri requestUri)
		{
		}

		/// <summary>Send a GET request to the specified Uri and return the response body as a stream in an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IStream> GetStreamAsync(string requestUri)
		{
		}

		/// <summary>Send a GET request to the specified Uri and return the response body as a stream in an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IStream> GetStreamAsync(Uri requestUri)
		{
		}

		/// <summary>Send a GET request to the specified Uri as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IHttpResponseMessage> GetAsync(string requestUri)
		{
		}

		/// <summary>Send a GET request to the specified Uri as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IHttpResponseMessage> GetAsync(Uri requestUri)
		{
		}

		/// <summary>Send a GET request to the specified Uri with an HTTP completion option as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <param name="completionOption">An HTTP completion option value that indicates when the operation should be considered completed.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IHttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption)
		{
		}

		/// <summary>Send a GET request to the specified Uri with an HTTP completion option as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <param name="completionOption">An HTTP  completion option value that indicates when the operation should be considered completed.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IHttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption)
		{
		}

		/// <summary>Send a GET request to the specified Uri with a cancellation token as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IHttpResponseMessage> GetAsync(string requestUri, CancellationToken cancellationToken)
		{
		}

		/// <summary>Send a GET request to the specified Uri with a cancellation token as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IHttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken)
		{
		}

		/// <summary>Send a GET request to the specified Uri with an HTTP completion option and a cancellation token as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <param name="completionOption">An HTTP  completion option value that indicates when the operation should be considered completed.</param>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IHttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
		}

		/// <summary>Send a GET request to the specified Uri with an HTTP completion option and a cancellation token as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <param name="completionOption">An HTTP  completion option value that indicates when the operation should be considered completed.</param>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IHttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
		}

		/// <summary>Send a POST request to the specified Uri as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <param name="content">The HTTP request content sent to the server.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IHttpResponseMessage> PostAsync(string requestUri, HttpContent content)
		{
		}

		/// <summary>Send a POST request to the specified Uri as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <param name="content">The HTTP request content sent to the server.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IHttpResponseMessage> PostAsync(string requestUri, IHttpContent content)
		{
		}

		/// <summary>Send a POST request to the specified Uri as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <param name="content">The HTTP request content sent to the server.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IHttpResponseMessage> PostAsync(Uri requestUri, HttpContent content)
		{
		}

		/// <summary>Send a POST request to the specified Uri as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <param name="content">The HTTP request content sent to the server.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IHttpResponseMessage> PostAsync(Uri requestUri, IHttpContent content)
		{
		}

		/// <summary>Send a POST request with a cancellation token as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <param name="content">The HTTP request content sent to the server.</param>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IHttpResponseMessage> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
		{
		}

		/// <summary>Send a POST request with a cancellation token as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <param name="content">The HTTP request content sent to the server.</param>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IHttpResponseMessage> PostAsync(string requestUri, IHttpContent content, CancellationToken cancellationToken)
		{
		}

		/// <summary>Send a POST request with a cancellation token as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <param name="content">The HTTP request content sent to the server.</param>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IHttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{
		}

		/// <summary>Send a POST request with a cancellation token as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <param name="content">The HTTP request content sent to the server.</param>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IHttpResponseMessage> PostAsync(Uri requestUri, IHttpContent content, CancellationToken cancellationToken)
		{
		}

		/// <summary>Send a PUT request to the specified Uri as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <param name="content">The HTTP request content sent to the server.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IHttpResponseMessage> PutAsync(string requestUri, HttpContent content)
		{
		}

		/// <summary>Send a PUT request to the specified Uri as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <param name="content">The HTTP request content sent to the server.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IHttpResponseMessage> PutAsync(string requestUri, IHttpContent content)
		{
		}

		/// <summary>Send a PUT request to the specified Uri as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <param name="content">The HTTP request content sent to the server.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IHttpResponseMessage> PutAsync(Uri requestUri, HttpContent content)
		{
		}

		/// <summary>Send a PUT request to the specified Uri as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <param name="content">The HTTP request content sent to the server.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IHttpResponseMessage> PutAsync(Uri requestUri, IHttpContent content)
		{
		}

		/// <summary>Send a PUT request with a cancellation token as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <param name="content">The HTTP request content sent to the server.</param>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IHttpResponseMessage> PutAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
		{
		}

		/// <summary>Send a PUT request with a cancellation token as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <param name="content">The HTTP request content sent to the server.</param>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IHttpResponseMessage> PutAsync(string requestUri, IHttpContent content, CancellationToken cancellationToken)
		{
		}

		/// <summary>Send a PUT request with a cancellation token as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <param name="content">The HTTP request content sent to the server.</param>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IHttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{
		}

		/// <summary>Send a PUT request with a cancellation token as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <param name="content">The HTTP request content sent to the server.</param>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		public Task<IHttpResponseMessage> PutAsync(Uri requestUri, IHttpContent content, CancellationToken cancellationToken)
		{
		}

		Task<IHttpResponseMessage> IHttpClient.DeleteAsync(string requestUri)
		{
			throw new NotImplementedException();
		}

		/// <summary>Send a DELETE request to the specified Uri as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient" /> instance.</exception>
		public Task<HttpResponseMessage> DeleteAsync(string requestUri)
		{
		}

		/// <summary>Send a DELETE request to the specified Uri as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient" /> instance.</exception>
		public Task<HttpResponseMessage> DeleteAsync(string requestUri)
		{
		}

		/// <summary>Send a DELETE request to the specified Uri as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient" /> instance.</exception>
		public Task<IHttpResponseMessage> DeleteAsync(Uri requestUri)
		{
		}

		/// <summary>Send a DELETE request to the specified Uri with a cancellation token as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient" /> instance.</exception>
		public Task<IHttpResponseMessage> DeleteAsync(string requestUri, CancellationToken cancellationToken)
		{
		}

		/// <summary>Send a DELETE request to the specified Uri with a cancellation token as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="requestUri">The Uri the request is sent to.</param>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient" /> instance.</exception>
		public Task<IHttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken)
		{
		}

		/// <summary>Send an HTTP request as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="request">The HTTP request message to send.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="request" /> was null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient" /> instance.</exception>
		public Task<IHttpResponseMessage> SendAsync(HttpRequestMessage request)
		{
		}

		/// <summary>Send an HTTP request as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="request">The HTTP request message to send.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="request" /> was null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient" /> instance.</exception>
		public Task<IHttpResponseMessage> SendAsync(IHttpRequestMessage request)
		{
		}

		/// <summary>Send an HTTP request as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="request">The HTTP request message to send.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="request" /> was null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient" /> instance.</exception>
		public override Task<IHttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
		}

		/// <summary>Send an HTTP request as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="request">The HTTP request message to send.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="request" /> was null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient" /> instance.</exception>
		public override Task<IHttpResponseMessage> SendAsync(IHttpRequestMessage request, CancellationToken cancellationToken)
		{
		}

		/// <summary>Send an HTTP request as an asynchronous operation. </summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="request">The HTTP request message to send.</param>
		/// <param name="completionOption">When the operation should complete (as soon as a response is available or after reading the whole response content).</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="request" /> was null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient" /> instance.</exception>
		public Task<IHttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption)
		{
		}

		/// <summary>Send an HTTP request as an asynchronous operation. </summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="request">The HTTP request message to send.</param>
		/// <param name="completionOption">When the operation should complete (as soon as a response is available or after reading the whole response content).</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="request" /> was null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient" /> instance.</exception>
		public Task<IHttpResponseMessage> SendAsync(IHttpRequestMessage request, HttpCompletionOption completionOption)
		{
		}

		/// <summary>Send an HTTP request as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="request">The HTTP request message to send.</param>
		/// <param name="completionOption">When the operation should complete (as soon as a response is available or after reading the whole response content).</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="request" /> was null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient" /> instance.</exception>
		public Task<IHttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
		}

		/// <summary>Send an HTTP request as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="request">The HTTP request message to send.</param>
		/// <param name="completionOption">When the operation should complete (as soon as a response is available or after reading the whole response content).</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="request" /> was null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient" /> instance.</exception>
		public Task<IHttpResponseMessage> SendAsync(IHttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
		}

		/// <summary>Cancel all pending requests on this instance.</summary>
		public void CancelPendingRequests()
		{
		}
	}
}