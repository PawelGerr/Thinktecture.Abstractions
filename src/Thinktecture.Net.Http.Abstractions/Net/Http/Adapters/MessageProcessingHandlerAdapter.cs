using System;
using System.ComponentModel;
using System.Net.Http;

namespace Thinktecture.Net.Http.Adapters
{
	/// <summary>A base type for handlers which only do some small processing of request and/or response messages.</summary>
	public class MessageProcessingHandlerAdapter : DelegatingHandlerAdapter, IMessageProcessingHandler
	{
		private readonly MessageProcessingHandler _handler;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new MessageProcessingHandler UnsafeConvert()
		{
			return _handler;
		}

		/// <summary>Creates an instance of a <see cref="MessageProcessingHandlerAdapter" /> class.</summary>
		/// <param name="handler">The implementation to use by the adapter.</param>
		public MessageProcessingHandlerAdapter(MessageProcessingHandler handler)
			: base(handler)
		{
			_handler = handler ?? throw new ArgumentNullException(nameof(handler));
		}
	}
}
