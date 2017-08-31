using System;
using JetBrains.Annotations;

namespace Thinktecture
{
	/// <summary>
	/// Event handler context of an abstraction.
	/// </summary>
	/// <typeparam name="T">The type of the event arguments</typeparam>
	public class AbstractionEventHandlerContext<T>
	{
		/// <summary>
		/// Event handler.
		/// </summary>
		[NotNull]
		public EventHandler<T> Handler { get; }

		/// <summary>
		/// Indication how many times the handler has been attached.
		/// </summary>
		public int Count { get; set; }

		/// <summary>
		/// Initializes new istance of <see cref="AbstractionEventHandlerContext{T}"/>.
		/// </summary>
		/// <param name="handler">Event handler</param>
		public AbstractionEventHandlerContext([NotNull] EventHandler<T> handler)
		{
			Handler = handler ?? throw new ArgumentNullException(nameof(handler));
		}
	}
}
