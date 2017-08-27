using System;
using System.ComponentModel;
using System.Net.Http;

namespace Thinktecture.Net.Http.Adapters
{
	/// <summary>A type for HTTP handlers that delegate the processing of HTTP response messages to another handler, called the inner handler.</summary>
	public class DelegatingHandlerAdapter : HttpMessageHandlerAdapter, IDelegatingHandler
	{
		private readonly DelegatingHandler _handler;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new DelegatingHandler UnsafeConvert()
		{
			return _handler;
		}

		/// <summary>Gets or sets the inner handler which processes the HTTP response messages.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.HttpMessageHandler" />.The inner handler for HTTP response messages.</returns>
		public IHttpMessageHandler InnerHandler
		{
			get => _handler.InnerHandler.ToInterface();
			set => _handler.InnerHandler = value.ToImplementation();
		}

		/// <summary>Creates a new instance of the <see cref="T:System.Net.Http.DelegatingHandler" /> class.</summary>
		/// <param name="handler">The implementation to use by the adapter.</param>
		public DelegatingHandlerAdapter(DelegatingHandler handler)
			: base(handler)
		{
			_handler = handler ?? throw new ArgumentNullException(nameof(handler));
		}
	}
}
