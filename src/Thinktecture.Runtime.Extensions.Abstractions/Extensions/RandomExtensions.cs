using System;
using System.Diagnostics.CodeAnalysis;
using Thinktecture.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extensions for <see cref="Random"/>.
   /// </summary>
   public static class RandomExtensions
   {
      /// <summary>
      /// Converts provided instance of <see cref="Random"/> to <see cref="IRandom"/>.
      /// </summary>
      /// <param name="random">Instance of <see cref="Random"/> to <see cref="IRandom"/>.</param>
      /// <returns>Instance of <see cref="IRandom"/>.</returns>
      [return: NotNullIfNotNull("random")]
      public static IRandom? ToInterface(this Random? random)
      {
         return (random == null) ? null : new RandomAdapter(random);
      }
   }
}
