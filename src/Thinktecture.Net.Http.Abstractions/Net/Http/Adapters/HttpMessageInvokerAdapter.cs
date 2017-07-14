using System;
using System.ComponentModel;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Thinktecture.Net.Http.Adapters
{
	/// <summary>A specialty class that allows applications to call the <see cref="SendAsync(IHttpRequestMessage, CancellationToken)" /> method on an Http handler chain. </summary>
	public class HttpMessageInvokerAdapter : AbstractionAdapter, IHttpMessageInvoker
	{
		private readonly HttpMessageInvoker _invoker;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new HttpMessageInvoker UnsafeConvert()
		{
			return _invoker;
		}

		/// <summary>Initializes an instance of a <see cref="HttpMessageInvokerAdapter" /> class with a specific <see cref="T:System.Net.Http.HttpMessageHandler" />.</summary>
		/// <param name="handler">The <see cref="T:System.Net.Http.HttpMessageHandler" /> responsible for processing the HTTP response messages.</param>
		public HttpMessageInvokerAdapter(HttpMessageHandler handler)
			: this(new HttpMessageInvoker(handler))
		{
		}

		/// <summary>Initializes an instance of a <see cref="HttpMessageInvokerAdapter" /> class with a specific <see cref="T:System.Net.Http.HttpMessageHandler" />.</summary>
		/// <param name="handler">The <see cref="T:System.Net.Http.HttpMessageHandler" /> responsible for processing the HTTP response messages.</param>
		/// <param name="disposeHandler">true if the inner handler should be disposed of by Dispose(),false if you intend to reuse the inner handler.</param>
		public HttpMessageInvokerAdapter(HttpMessageHandler handler, bool disposeHandler)
			: this(new HttpMessageInvoker(handler, disposeHandler))
		{
		}

		/// <summary>Initializes an instance of a <see cref="HttpMessageInvokerAdapter" /> class with a specific <see cref="T:System.Net.Http.HttpMessageHandler" />.</summary>
		/// <param name="handler">The <see cref="T:System.Net.Http.HttpMessageHandler" /> responsible for processing the HTTP response messages.</param>
		/// <param name="disposeHandler">true if the inner handler should be disposed of by Dispose(),false if you intend to reuse the inner handler.</param>
		public HttpMessageInvokerAdapter(IHttpMessageHandler handler, bool disposeHandler)
			: this(new HttpMessageInvoker(handler.ToImplementation(), disposeHandler))
		{
		}

		/// <summary>
		/// Initializes an instance of a <see cref="HttpMessageInvokerAdapter" /> class
		/// </summary>
		/// <param name="invoker"></param>
		public HttpMessageInvokerAdapter(HttpMessageInvoker invoker)
			: base(invoker)
		{
			_invoker = invoker ?? throw new ArgumentNullException(nameof(invoker));
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> SendAsync(IHttpRequestMessage request, CancellationToken cancellationToken)
		{
			return _invoker.SendAsync(request.ToImplementation(), cancellationToken)
				.ContinueWith(t => t.Result.ToInterface(), cancellationToken);
		}

		/// <inheritdoc />
		public Task<IHttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			return _invoker.SendAsync(request, cancellationToken)
				.ContinueWith(t => t.Result.ToInterface(), cancellationToken);
		}

		/// <inheritdoc />
		public void Dispose()
		{
			_invoker.Dispose();
		}
	}
}