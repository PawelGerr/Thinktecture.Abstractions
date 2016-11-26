using System;
using System.ComponentModel;
using System.Net.Http;

namespace Thinktecture.Net.Http.Adapters
{
	/// <summary>A base type for HTTP message handlers.</summary>
	public class HttpMessageHandlerAdapter : AbstractionAdapter, IHttpMessageHandler
	{
		private readonly HttpMessageHandler _handler;

		/// <summary>Initializes a new instance of the <see cref="HttpMessageHandlerAdapter" /> class.</summary>
		/// <param name="handler">Handler to be used by the adapter.</param>
		public HttpMessageHandlerAdapter(HttpMessageHandler handler)
			: base(handler)
		{
			if (handler == null)
				throw new ArgumentNullException(nameof(handler));

			_handler = handler;
		}

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new HttpMessageHandler UnsafeConvert()
		{
			return _handler;
		}

		/// <inheritdoc />
		public void Dispose()
		{
			_handler.Dispose();
		}
	}
}