using System.Net.Http;
using JetBrains.Annotations;
using Thinktecture.Net.Http;
using Thinktecture.Net.Http.Adapters;

// ReSharper disable once CheckNamespace
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
		[CanBeNull]
		public static IMessageProcessingHandler ToInterface([CanBeNull] this MessageProcessingHandler handler)
		{
			return (handler == null) ? null : new MessageProcessingHandlerAdapter(handler);
		}

		/// <summary>
		/// Converts provided <see cref="IMessageProcessingHandler"/> info to <see cref="MessageProcessingHandler"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="IMessageProcessingHandler"/> to convert.</param>
		/// <returns>An instance of <see cref="MessageProcessingHandler"/>.</returns>
		[CanBeNull]
		public static MessageProcessingHandler ToImplementation([CanBeNull] this IMessageProcessingHandler abstraction)
		{
			return ((IAbstraction<MessageProcessingHandler>)abstraction)?.UnsafeConvert();
		}
	}
}
