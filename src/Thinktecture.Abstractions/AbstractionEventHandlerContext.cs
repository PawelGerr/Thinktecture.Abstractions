using System;
using JetBrains.Annotations;

namespace Thinktecture
{
	/// <summary>
	/// Event handler context of an abstraction.
	/// </summary>
	/// <typeparam name="TImplementationDelegate">Type of the delegate.</typeparam>
	public class AbstractionEventHandlerContext<TImplementationDelegate>
		where TImplementationDelegate : class
	{
		/// <summary>
		/// Event handler.
		/// </summary>
		[NotNull]
		public TImplementationDelegate Handler { get; }

		/// <summary>
		/// Indication how many times the handler has been attached.
		/// </summary>
		public int Count { get; set; }

		/// <summary>
		/// Initializes new istance of <see cref="AbstractionEventHandlerContext{TImplementationDelegate}"/>.
		/// </summary>
		/// <param name="handler">Event handler</param>
		public AbstractionEventHandlerContext([NotNull] TImplementationDelegate handler)
		{
			Handler = handler ?? throw new ArgumentNullException(nameof(handler));
		}
	}
}
