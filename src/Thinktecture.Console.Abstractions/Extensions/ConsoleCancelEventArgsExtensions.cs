using System;
using System.Diagnostics.CodeAnalysis;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extensions for <see cref="ConsoleCancelEventArgs"/>.
   /// </summary>
   public static class BufferedStreamExtensions
   {
      /// <summary>
      /// Converts provided eventArgs to <see cref="IConsoleCancelEventArgs"/>;
      /// </summary>
      /// <param name="eventArgs">Event args to convert.</param>
      /// <returns>Converted event args.</returns>
      [return: NotNullIfNotNull("eventArgs")]
      public static IConsoleCancelEventArgs? ToInterface(this ConsoleCancelEventArgs? eventArgs)
      {
         return (eventArgs == null) ? null : new ConsoleCancelEventArgsAdapter(eventArgs);
      }

      /// <summary>
      /// Converts provided <see cref="IConsoleCancelEventArgs"/> info to <see cref="ConsoleCancelEventArgs"/>.
      /// </summary>
      /// <param name="abstraction">Instance of <see cref="IConsoleCancelEventArgs"/> to convert.</param>
      /// <returns>An instance of <see cref="ConsoleCancelEventArgs"/>.</returns>
      [return: NotNullIfNotNull("eventArgs")]
      public static ConsoleCancelEventArgs? ToImplementation(this IConsoleCancelEventArgs? abstraction)
      {
         return ((IAbstraction<ConsoleCancelEventArgs>?)abstraction)?.UnsafeConvert();
      }
   }
}
