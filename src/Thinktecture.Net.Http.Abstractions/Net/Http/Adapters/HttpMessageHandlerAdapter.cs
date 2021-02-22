using System.Net.Http;
namespace Thinktecture.Net.Http.Adapters
{
	/// <summary>A base type for HTTP message handlers.</summary>
	public class HttpMessageHandlerAdapter : AbstractionAdapter<HttpMessageHandler>, IHttpMessageHandler
	{
		/// <summary>Initializes a new instance of the <see cref="HttpMessageHandlerAdapter" /> class.</summary>
		/// <param name="handler">Handler to be used by the adapter.</param>
		public HttpMessageHandlerAdapter(HttpMessageHandler handler)
			: base(handler)
		{
		}

		/// <inheritdoc />
		public void Dispose()
		{
			Implementation.Dispose();
		}
	}
}
