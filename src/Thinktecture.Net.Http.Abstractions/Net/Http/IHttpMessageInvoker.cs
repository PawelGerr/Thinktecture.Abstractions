using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Thinktecture.Net.Http
{
	/// <summary>A specialty class that allows applications to call the <see cref="SendAsync(IHttpRequestMessage, CancellationToken)" /> method on an Http handler chain. </summary>
	public interface IHttpMessageInvoker : IAbstraction<HttpMessageInvoker>, IDisposable
	{
		/// <summary>Send an HTTP request as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="request">The HTTP request message to send.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="request" /> was null.</exception>
		[NotNull, ItemNotNull]
		Task<IHttpResponseMessage> SendAsync([NotNull] HttpRequestMessage request, CancellationToken cancellationToken);

		/// <summary>Send an HTTP request as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		/// <param name="request">The HTTP request message to send.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="request" /> was null.</exception>
		[NotNull, ItemNotNull]
		Task<IHttpResponseMessage> SendAsync([NotNull] IHttpRequestMessage request, CancellationToken cancellationToken);
	}
}
