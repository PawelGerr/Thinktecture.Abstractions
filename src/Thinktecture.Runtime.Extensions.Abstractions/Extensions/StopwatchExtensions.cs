using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Thinktecture.Diagnostics;
using Thinktecture.Diagnostics.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extensions for <see cref="Stopwatch"/>.
   /// </summary>
   public static class StopwatchExtensions
   {
      /// <summary>
      /// Converts provided instance of <see cref="Stopwatch"/> to <see cref="IStopwatch"/>.
      /// </summary>
      /// <param name="stopwatch">Instance of <see cref="Stopwatch"/> to convert.</param>
      /// <returns>An instance of <see cref="IStopwatch"/>.</returns>
      [return: NotNullIfNotNull("stopwatch")]
      public static IStopwatch? ToInterface(this Stopwatch? stopwatch)
      {
         return (stopwatch == null) ? null : new StopwatchAdapter(stopwatch);
      }
   }
}
