using System.Diagnostics.CodeAnalysis;
using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extensions for <see cref="MemoryStream"/>.
   /// </summary>
   public static class MemoryStreamExtensions
   {
      /// <summary>
      /// Converts provided stream to <see cref="IMemoryStream"/>;
      /// </summary>
      /// <param name="stream">Stream to convert.</param>
      /// <returns>Converted stream.</returns>
      [return: NotNullIfNotNull("stream")]
      public static IMemoryStream? ToInterface(this MemoryStream? stream)
      {
         return (stream == null) ? null : new MemoryStreamAdapter(stream);
      }

      /// <summary>
      /// Converts provided <see cref="IMemoryStream"/> info to <see cref="MemoryStream"/>.
      /// </summary>
      /// <param name="abstraction">Instance of <see cref="IMemoryStream"/> to convert.</param>
      /// <returns>An instance of <see cref="MemoryStream"/>.</returns>
      [return: NotNullIfNotNull("abstraction")]
      public static MemoryStream? ToImplementation(this IMemoryStream? abstraction)
      {
         return ((IAbstraction<MemoryStream>?)abstraction)?.UnsafeConvert();
      }
   }
}
