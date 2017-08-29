using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute
// ReSharper disable PossibleNullReferenceException

namespace Thinktecture.Net.Http.Adapters
{
	/// <summary>A specialty class that allows applications to call the <see cref="SendAsync(IHttpRequestMessage, CancellationToken)" /> method on an Http handler chain. </summary>
	public class HttpMessageInvokerAdapter : AbstractionAdapter<HttpMessageInvoker>, IHttpMessageInvoker
	{
		/// <summary>Initializes an instance of a <see cref="HttpMessageInvokerAdapter" /> class with a specific <see cref="T:System.Net.Http.HttpMessageHandler" />.</summary>
		/// <param name="handler">The <see cref="T:System.Net.Http.HttpMessageHandler" /> responsible for processing the HTTP response messages.</param>
		public HttpMessageInvokerAdapter([NotNull] HttpMessageHandler handler)
			: this(new HttpMessageInvoker(handler))
		{
		}

		/// <summary>Initializes an instance of a <see cref="HttpMessageInvokerAdapter" /> class with a specific <see cref="T:System.Net.Http.HttpMessageHandler" />.</summary>
		/// <param name="handler">The <see cref="T:System.Net.Http.HttpMessageHandler" /> responsible for processing the HTTP response messages.</param>
		/// <param name="disposeHandler">true if the inner handler should be disposed of by Dispose(),false if you intend to reuse the inner handler.</param>
		public HttpMessageInvokerAdapter([NotNull] HttpMessageHandler handler, bool disposeHandler)
			: this(new HttpMessageInvoker(handler, disposeHandler))
		{
		}

		/// <summary>Initializes an instance of a <see cref="HttpMessageInvokerAdapter" /> class with a specific <see cref="T:System.Net.Http.HttpMessageHandler" />.</summary>
		/// <param name="handler">The <see cref="T:System.Net.Http.HttpMessageHandler" /> responsible for processing the HTTP response messages.</param>
		/// <param name="disposeHandler">true if the inner handler should be disposed of by Dispose(),false if you intend to reuse the inner handler.</param>
		public HttpMessageInvokerAdapter([NotNull] IHttpMessageHandler handler, bool disposeHandler)
			: this(handler.ToImplementation(), disposeHandler)
		{
		}

		/// <summary>
		/// Initializes an instance of a <see cref="HttpMessageInvokerAdapter" /> class
		/// </summary>
		/// <param name="invoker"></param>
		public HttpMessageInvokerAdapter([NotNull] HttpMessageInvoker invoker)
			: base(invoker)
		{
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> SendAsync(IHttpRequestMessage request, CancellationToken cancellationToken)
		{
			var message = await Implementation.SendAsync(request.ToImplementation(), cancellationToken).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public async Task<IHttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			var message = await Implementation.SendAsync(request, cancellationToken).ConfigureAwait(false);
			return message.ToInterface();
		}

		/// <inheritdoc />
		public void Dispose()
		{
			Implementation.Dispose();
		}
	}
}
