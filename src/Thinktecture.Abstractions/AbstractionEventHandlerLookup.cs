using System;
using System.Collections.Generic;
using System.Reflection;
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
      where TImplementation : notnull
   {
      private static readonly Type _abstractionType = typeof(TAbstraction);

      private readonly Dictionary<EventHandler<TAbstraction>, AbstractionEventHandlerContext<EventHandler<TImplementation>>> _lookup;

      /// <summary>
      /// Initializes new instance of <see cref="AbstractionEventHandlerLookup{TAbstraction,TImplementation}"/>.
      /// </summary>
      public AbstractionEventHandlerLookup()
      {
         var comparer = new GenericEqualityComparer<EventHandler<TAbstraction>>(Equal, GetHashCode);
         _lookup = new Dictionary<EventHandler<TAbstraction>, AbstractionEventHandlerContext<EventHandler<TImplementation>>>(comparer);
      }

      private static int GetHashCode(EventHandler<TAbstraction>? key)
      {
         return key is null
                   ? _abstractionType.GetHashCode()
                   : HashCode.Combine(key.Target, key.GetMethodInfo());
      }

      private static bool Equal(EventHandler<TAbstraction>? key, EventHandler<TAbstraction>? otherKey)
      {
         return ReferenceEquals(key?.Target, otherKey?.Target)
                && ReferenceEquals(key?.GetMethodInfo(), otherKey?.GetMethodInfo());
      }

      /// <summary>
      /// Maps handler for attaching to an event.
      /// </summary>
      /// <param name="handler">Handler to map.</param>
      /// <param name="toInterface">Function to convert an implementation to an abstraction.</param>
      /// <returns>Mapped handler</returns>
      public EventHandler<TImplementation>? MapForAttachment(EventHandler<TAbstraction>? handler, Func<TImplementation, TAbstraction> toInterface)
      {
         if (toInterface == null)
            throw new ArgumentNullException(nameof(toInterface));
         if (handler == null)
            return null;

         if (!_lookup.TryGetValue(handler, out var ctx))
         {
            ctx = new AbstractionEventHandlerContext<EventHandler<TImplementation>>((sender, args) => handler(sender, toInterface(args)));
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
      public EventHandler<TImplementation>? TryMapForDetachment(EventHandler<TAbstraction>? handler)
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
