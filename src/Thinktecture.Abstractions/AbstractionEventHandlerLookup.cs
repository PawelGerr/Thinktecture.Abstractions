using System;
using System.Collections.Generic;
using System.Reflection;
using Thinktecture.Collections.Generic;

namespace Thinktecture
{
	/// <summary>
	/// Allow mapping of event handlers.
	/// </summary>
	public class AbstractionEventHandlerLookup<TAbstraction, TImplementation>
		where TAbstraction : IAbstraction<TImplementation>
	{
		private readonly Dictionary<EventHandler<TAbstraction>, AbstractionEventHandlerContext<TImplementation>> _lookup;

		/// <summary>
		/// Initializes new instance of <see cref="AbstractionEventHandlerLookup{TAbstraction,TImplementation}"/>.
		/// </summary>
		public AbstractionEventHandlerLookup()
		{
			var comparer = new GenericEqualityComparer<EventHandler<TAbstraction>>(
				(key, otherKey) => ReferenceEquals(key.Target, otherKey.Target) && ReferenceEquals(key.GetMethodInfo(), otherKey.GetMethodInfo()),
				key => ((key.Target?.GetHashCode() ?? 0) * 397) ^ (key.GetMethodInfo()?.GetHashCode() ?? 0));

			_lookup = new Dictionary<EventHandler<TAbstraction>, AbstractionEventHandlerContext<TImplementation>>(comparer);
		}

		/// <summary>
		/// Maps handler for attaching to an event.
		/// </summary>
		/// <param name="handler">Handler to map.</param>
		/// <param name="toInterface">Function to convert an implementation to an abstraction.</param>
		/// <returns>Mapped handler</returns>
		public EventHandler<TImplementation> MapForAttachment(EventHandler<TAbstraction> handler, Func<TImplementation, TAbstraction> toInterface)
		{
			if (handler == null)
				return null;

			if (toInterface == null)
				throw new ArgumentNullException(nameof(toInterface));

			AbstractionEventHandlerContext<TImplementation> ctx;
			if (!_lookup.TryGetValue(handler, out ctx))
			{
				ctx = new AbstractionEventHandlerContext<TImplementation>((sender, args) => handler(sender, toInterface(args)));
				_lookup.Add(handler, ctx);
			}

			ctx.Count++;

			return ctx.Handler;
		}

		/// <summary>
		/// Maps handler for detachment.
		/// </summary>
		/// <param name="handler">Handler to map.</param>
		/// <returns>Mapped handler</returns>
		public EventHandler<TImplementation> TryMapForDetachment(EventHandler<TAbstraction> handler)
		{
			AbstractionEventHandlerContext<TImplementation> ctx;

			if (handler != null && _lookup.TryGetValue(handler, out ctx))
			{
				ctx.Count--;

				if (ctx.Count <= 0)
					_lookup.Remove(handler);

				return ctx.Handler;
			}

			return null;
		}
	}
}