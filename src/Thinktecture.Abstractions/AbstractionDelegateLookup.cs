using System;
using System.Collections.Generic;
using System.Reflection;
using Thinktecture.Collections.Generic;

namespace Thinktecture
{
	/// <summary>
	/// Allow mapping of event handlers.
	/// </summary>
	/// <typeparam name="TImplementationDelegate">Type of delegate.</typeparam>
	public class AbstractionDelegateLookup<TImplementationDelegate>
		where TImplementationDelegate : class
   {
      private static readonly Type _implementationDelegateType = typeof(TImplementationDelegate);

		private readonly Dictionary<EventHandler, AbstractionEventHandlerContext<TImplementationDelegate>> _lookup;

		/// <summary>
		/// Initializes new instance of <see cref="AbstractionDelegateLookup{TAbstraction,TImplementationDelegate}"/>.
		/// </summary>
		public AbstractionDelegateLookup()
		{
			var comparer = new GenericEqualityComparer<EventHandler>(Equal, GetHashCode);
			_lookup = new Dictionary<EventHandler, AbstractionEventHandlerContext<TImplementationDelegate>>(comparer);
		}

		private static int GetHashCode(EventHandler? key)
		{
			return key is null
                   ? _implementationDelegateType.GetHashCode()
                   : HashCode.Combine(key.Target, key.GetMethodInfo());
		}

		private static bool Equal(EventHandler? key, Delegate? otherKey)
		{
			return ReferenceEquals(key?.Target, otherKey?.Target)
					&& ReferenceEquals(key?.GetMethodInfo(), otherKey?.GetMethodInfo());
		}

		/// <summary>
		/// Maps handler for attaching to an event.
		/// </summary>
		/// <param name="handler">Handler to map.</param>
		/// <param name="convertDelegate">Function to convert an implementation to an abstraction.</param>
		/// <returns>Mapped handler</returns>
		public TImplementationDelegate? MapForAttachment(EventHandler? handler, Func<EventHandler, TImplementationDelegate> convertDelegate)
		{
			if (handler == null)
				return null;
			if (convertDelegate == null)
				throw new ArgumentNullException(nameof(convertDelegate));

			if (!_lookup.TryGetValue(handler, out var ctx))
			{
				ctx = new AbstractionEventHandlerContext<TImplementationDelegate>(convertDelegate(handler));
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
		public TImplementationDelegate? TryMapForDetachment(EventHandler? handler)
		{
			if (handler == null || !_lookup.TryGetValue(handler, out var ctx))
				return default;

			ctx.Count--;

			if (ctx.Count <= 0)
				_lookup.Remove(handler);

			return ctx.Handler;
		}
	}

	/// <summary>
	/// Allow mapping of event handlers.
	/// </summary>
	/// <typeparam name="TAbstraction">Type of the abstraction.</typeparam>
	/// <typeparam name="TImplementationDelegate">Type of delegate.</typeparam>
	public class AbstractionDelegateLookup<TAbstraction, TImplementationDelegate>
		where TImplementationDelegate : class
	{
		private readonly Dictionary<EventHandler<TAbstraction>, AbstractionEventHandlerContext<TImplementationDelegate>> _lookup;

		/// <summary>
		/// Initializes new instance of <see cref="AbstractionDelegateLookup{TAbstraction,TImplementationDelegate}"/>.
		/// </summary>
		public AbstractionDelegateLookup()
		{
			var comparer = new GenericEqualityComparer<EventHandler<TAbstraction>>(Equal, GetHashCode);
			_lookup = new Dictionary<EventHandler<TAbstraction>, AbstractionEventHandlerContext<TImplementationDelegate>>(comparer);
		}

		private static int GetHashCode(EventHandler<TAbstraction>? key)
		{
			return ((key?.Target?.GetHashCode() ?? 0) * 397)
					^ (key?.GetMethodInfo()?.GetHashCode() ?? 0);
		}

		private static bool Equal(EventHandler<TAbstraction>? key, Delegate? otherKey)
		{
			return ReferenceEquals(key?.Target, otherKey?.Target)
					&& ReferenceEquals(key?.GetMethodInfo(), otherKey?.GetMethodInfo());
		}

		/// <summary>
		/// Maps handler for attaching to an event.
		/// </summary>
		/// <param name="handler">Handler to map.</param>
		/// <param name="convertDelegate">Function to convert an implementation to an abstraction.</param>
		/// <returns>Mapped handler</returns>
		public TImplementationDelegate? MapForAttachment(EventHandler<TAbstraction>? handler, Func<EventHandler<TAbstraction>, TImplementationDelegate> convertDelegate)
		{
			if (handler == null)
				return null;
			if (convertDelegate == null)
				throw new ArgumentNullException(nameof(convertDelegate));

			if (!_lookup.TryGetValue(handler, out var ctx))
			{
				ctx = new AbstractionEventHandlerContext<TImplementationDelegate>(convertDelegate(handler));
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
		public TImplementationDelegate? TryMapForDetachment(EventHandler<TAbstraction>? handler)
		{
			if (handler == null || !_lookup.TryGetValue(handler, out var ctx))
				return default;

			ctx.Count--;

			if (ctx.Count <= 0)
				_lookup.Remove(handler);

			return ctx.Handler;
		}
	}
}
