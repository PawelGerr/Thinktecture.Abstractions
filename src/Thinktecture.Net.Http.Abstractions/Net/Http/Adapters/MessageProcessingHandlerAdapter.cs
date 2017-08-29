using System;
using System.ComponentModel;
using System.Net.Http;
using JetBrains.Annotations;

namespace Thinktecture.Net.Http.Adapters
{
	/// <summary>A base type for handlers which only do some small processing of request and/or response messages.</summary>
	public class MessageProcessingHandlerAdapter : DelegatingHandlerAdapter, IMessageProcessingHandler
	{
		/// <inheritdoc />
		[NotNull, EditorBrowsable(EditorBrowsableState.Never)]
		public new MessageProcessingHandler UnsafeConvert()
		{
			return (MessageProcessingHandler)Implementation;
		}

		/// <summary>Creates an instance of a <see cref="MessageProcessingHandlerAdapter" /> class.</summary>
		/// <param name="handler">The implementation to use by the adapter.</param>
		// ReSharper disable once SuggestBaseTypeForParameter
		public MessageProcessingHandlerAdapter([NotNull] MessageProcessingHandler handler)
			: base(handler)
		{
		}
	}
}
