using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Thinktecture.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extension methods for <see cref="ICollection{T}"/>
   /// </summary>
   public static class CollectionExtensions
   {
      /// <summary>
      /// Converts a collection of type <typeparamref name="TAbstractionItem"/> to <typeparamref name="TImplementation"/>.
      /// </summary>
      /// <param name="collection">Collection to convert</param>
      /// <typeparam name="TAbstractionItem">Type of the abstraction.</typeparam>
      /// <typeparam name="TImplementationItem">Type of the item of the implementation.</typeparam>
      /// <typeparam name="TImplementation">Type of the implementation.</typeparam>
      /// <returns>Converted collection.</returns>
      [return: NotNullIfNotNull("collection")]
      public static TImplementation? ToImplementation<TAbstractionItem, TImplementationItem, TImplementation>(this ICollectionAbstraction<TAbstractionItem, TImplementationItem, TImplementation>? collection)
         where TAbstractionItem : IAbstraction<TImplementationItem>
         where TImplementationItem : notnull
         where TImplementation : ICollection<TImplementationItem?>

      {
         return ReferenceEquals(collection, null) ? default : collection.UnsafeConvert();
      }
   }
}
