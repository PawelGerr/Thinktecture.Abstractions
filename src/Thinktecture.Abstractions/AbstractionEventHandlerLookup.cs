using System;
using System.Collections.Generic;
using System.Reflection;
using JetBrains.Annotations;
using Thinktecture.Collections.Generic;

namespace Thinktecture
{
	/// <summary>
	/// Allow mapping of event handlers.
	/// </summary>
	/// <typeparam name="TAbstraction">Type of the abstraction.</typeparam>
	/// <typeparam name="TImplementation">Type of the implementation.</typeparam>
	public class AbstractionEventHandlerLookup<TAbstraction, TImplementation>
		where TAbstraction : IAbstraction<TImplementation>
	{
		[NotNull]
		private readonly Dictionary<EventHandler<TAbstraction>, AbstractionEventHandlerContext<TImplementation>> _lookup;

		/// <summary>
		/// Initializes new instance of <see cref="AbstractionEventHandlerLookup{TAbstraction,TImplementation}"/>.
		/// </summary>
		public AbstractionEventHandlerLookup()
		{
			var comparer = new GenericEqualityComparer<EventHandler<TAbstraction>>(Equal, GetHashCode);
			_lookup = new Dictionary<EventHandler<TAbstraction>, AbstractionEventHandlerContext<TImplementation>>(comparer);
		}

		private static int GetHashCode([CanBeNull] EventHandler<TAbstraction> key)
		{
			return ((key?.Target?.GetHashCode() ?? 0) * 397)
					^ (key.GetMethodInfo()?.GetHashCode() ?? 0);
		}

		private static bool Equal([CanBeNull] EventHandler<TAbstraction> key, [CanBeNull] EventHandler<TAbstraction> otherKey)
		{
			return ReferenceEquals(key?.Target, otherKey?.Target)
					&& ReferenceEquals(key.GetMethodInfo(), otherKey.GetMethodInfo());
		}

		/// <summary>
		/// Maps handler for attaching to an event.
		/// </summary>
		/// <param name="handler">Handler to map.</param>
		/// <param name="toInterface">Function to convert an implementation to an abstraction.</param>
		/// <returns>Mapped handler</returns>
		[CanBeNull]
		public EventHandler<TImplementation> MapForAttachment([CanBeNull] EventHandler<TAbstraction> handler, [NotNull] Func<TImplementation, TAbstraction> toInterface)
		{
			if (toInterface == null)
				throw new ArgumentNullException(nameof(toInterface));
			if (handler == null)
				return null;

			if (!_lookup.TryGetValue(handler, out var ctx))
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
		[CanBeNull]
		public EventHandler<TImplementation> TryMapForDetachment([CanBeNull] EventHandler<TAbstraction> handler)
		{
			if (handler == null || !_lookup.TryGetValue(handler, out var ctx))
				return null;

			ctx.Count--;

			if (ctx.Count <= 0)
				_lookup.Remove(handler);

			return ctx.Handler;
		}
	}
}
