using System.Net.Http;

namespace Thinktecture.Net.Http
{
	/// <summary>A base type for handlers which only do some small processing of request and/or response messages.</summary>
	public interface IMessageProcessingHandler : IDelegatingHandler
	{
		/// <summary>
		/// Gets inner instance of <see cref="MessageProcessingHandler"/>.
		/// It is not intended to be used directly. Use <see cref="MessageProcessingHandlerExtensions.ToImplementation"/> instead.
		/// </summary>
		new MessageProcessingHandler UnsafeConvert();
	}
}