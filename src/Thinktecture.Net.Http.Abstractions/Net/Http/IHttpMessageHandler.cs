using System;
using System.ComponentModel;
using System.Net.Http;

namespace Thinktecture.Net.Http
{
	/// <summary>A base type for HTTP message handlers.</summary>
	public interface IHttpMessageHandler : IDisposable
	{
		/// <summary>
		/// Gets inner instance of <see cref="HttpMessageHandler"/>.
		/// It is not intended to be used directly. Use <see cref="HttpMessageHandlerExtensions.ToImplementation"/> instead.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		HttpMessageHandler UnsafeConvert();
	}
}