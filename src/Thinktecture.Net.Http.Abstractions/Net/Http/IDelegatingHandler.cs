using System.ComponentModel;
using System.Net.Http;

namespace Thinktecture.Net.Http
{
	/// <summary>A type for HTTP handlers that delegate the processing of HTTP response messages to another handler, called the inner handler.</summary>
	public interface IDelegatingHandler : IHttpMessageHandler
	{
		/// <summary>
		/// Gets inner instance of <see cref="DelegatingHandler"/>.
		/// It is not intended to be used directly. Use <see cref="DelegatingHandlerExtensions.ToImplementation"/> instead.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		new DelegatingHandler UnsafeConvert();

		/// <summary>Gets or sets the inner handler which processes the HTTP response messages.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.HttpMessageHandler" />.The inner handler for HTTP response messages.</returns>
		IHttpMessageHandler InnerHandler { get; set; }
	}
}