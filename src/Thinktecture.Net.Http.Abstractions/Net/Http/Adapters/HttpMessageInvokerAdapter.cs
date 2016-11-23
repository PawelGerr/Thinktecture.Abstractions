using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thinktecture.Net.Http
{
	/// <summary>A specialty class that allows applications to call the <see cref="M:System.Net.Http.HttpMessageInvoker.SendAsync(System.Net.Http.HttpRequestMessage,System.Threading.CancellationToken)" /> method on an Http handler chain. </summary>
	public class HttpMessageInvokerAdapter : IHttpMessageInvoker
	{
		private readonly HttpMessageInvoker _messageInvoker;

		/// <summary>Initializes an instance of a <see cref="T:System.Net.Http.HttpMessageInvoker" /> class with a specific <see cref="T:System.Net.Http.HttpMessageHandler" />.</summary>
		/// <param name="handler">The <see cref="T:System.Net.Http.HttpMessageHandler" /> responsible for processing the HTTP response messages.</param>
		public HttpMessageInvokerAdapter(HttpMessageHandler handler)
			: this(handler, true)
		{
		}

		/// <summary>Initializes an instance of a <see cref="T:System.Net.Http.HttpMessageInvoker" /> class with a specific <see cref="T:System.Net.Http.HttpMessageHandler" />.</summary>
		/// <param name="handler">The <see cref="T:System.Net.Http.HttpMessageHandler" /> responsible for processing the HTTP response messages.</param>
		/// <param name="disposeHandler">true if the inner handler should be disposed of by Dispose(),false if you intend to reuse the inner handler.</param>
		public HttpMessageInvokerAdapter(HttpMessageHandler handler, bool disposeHandler)
		{
		}

		/// <summary>Initializes an instance of a <see cref="T:System.Net.Http.HttpMessageInvoker" /> class with a specific <see cref="T:System.Net.Http.HttpMessageHandler" />.</summary>
		/// <param name="handler">The <see cref="T:System.Net.Http.HttpMessageHandler" /> responsible for processing the HTTP response messages.</param>
		/// <param name="disposeHandler">true if the inner handler should be disposed of by Dispose(),false if you intend to reuse the inner handler.</param>
		public HttpMessageInvokerAdapter(IHttpRequestMessage handler, bool disposeHandler)
		{
		}

		/// <summary>
		/// Initializes an instance of a <see cref="HttpMessageInvokerAdapter" /> class
		/// </summary>
		/// <param name="messageInvoker"></param>
		public HttpMessageInvokerAdapter(HttpMessageInvoker messageInvoker)
		{
			if (messageInvoker == null)
				throw new ArgumentNullException(nameof(messageInvoker));

			_messageInvoker = messageInvoker;
		}

		/// <summary>Send an HTTP request as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="request">The HTTP request message to send.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="request" /> was null.</exception>
		public Task<IHttpResponseMessage> SendAsync(IHttpRequestMessage request, CancellationToken cancellationToken)
		{
		}

		/// <summary>Send an HTTP request as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="request">The HTTP request message to send.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="request" /> was null.</exception>
		public Task<IHttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
		}

		/// <summary>Releases the unmanaged resources and disposes of the managed resources used by the <see cref="T:System.Net.Http.HttpMessageInvoker" />.</summary>
		public void Dispose()
		{
		}
		
	}
}