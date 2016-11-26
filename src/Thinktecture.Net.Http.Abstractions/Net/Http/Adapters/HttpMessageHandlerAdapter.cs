using System;
using System.ComponentModel;
using System.Net.Http;

namespace Thinktecture.Net.Http.Adapters
{
	/// <summary>A base type for HTTP message handlers.</summary>
	public class HttpMessageHandlerAdapter : IHttpMessageHandler
	{
		private readonly HttpMessageHandler _handler;

		/// <summary>Initializes a new instance of the <see cref="HttpMessageHandlerAdapter" /> class.</summary>
		/// <param name="handler">Handler to be used by the adapter.</param>
		public HttpMessageHandlerAdapter(HttpMessageHandler handler)
		{
			if (handler == null)
				throw new ArgumentNullException(nameof(handler));

			_handler = handler;
		}

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public HttpMessageHandler UnsafeConvert()
		{
			return _handler;
		}

		/// <inheritdoc />
		public void Dispose()
		{
			_handler.Dispose();
		}

		/// <inheritdoc />
		public override string ToString()
		{
			return _handler.ToString();
		}

		/// <inheritdoc />
		public override bool Equals(object obj)
		{
			return _handler.Equals(obj);
		}

		/// <inheritdoc />
		public override int GetHashCode()
		{
			return _handler.GetHashCode();
		}
	}
}