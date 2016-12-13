using System.Net.Http;
using Thinktecture.Net.Http;
using Thinktecture.Net.Http.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="MessageProcessingHandler"/>.
	/// </summary>
	public static class MessageProcessingHandlerExtensions
	{
		/// <summary>
		/// Converts provided handler to <see cref="IMessageProcessingHandler"/>.
		/// </summary>
		/// <param name="handler">Handler to convert.</param>
		/// <returns>Converted handler.</returns>
		public static IMessageProcessingHandler ToInterface(this MessageProcessingHandler handler)
		{
			return (handler == null) ? null : new MessageProcessingHandlerAdapter(handler);
		}
	}
}