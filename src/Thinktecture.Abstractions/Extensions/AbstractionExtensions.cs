using System.Diagnostics.CodeAnalysis;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extensions for <see cref="IAbstraction"/>.
   /// </summary>
   public static class AbstractionExtensions
   {
      /// <summary>
      /// Converts provided abstraction to implementation.
      /// </summary>
      /// <typeparam name="TImplementation">Type of the implementation.</typeparam>
      /// <param name="abstraction">Abstraction to convert.</param>
      /// <returns>Converted abstraction.</returns>
      [return: NotNullIfNotNull("abstraction")]
      public static TImplementation? ToImplementation<TImplementation>(this IAbstraction<TImplementation>? abstraction)
         where TImplementation : notnull
      {
         return ReferenceEquals(abstraction, null) ? default : abstraction.UnsafeConvert();
      }
   }
}
