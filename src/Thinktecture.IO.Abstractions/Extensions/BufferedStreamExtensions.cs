using System.Diagnostics.CodeAnalysis;
using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extensions for <see cref="BufferedStream"/>.
   /// </summary>
   public static class BufferedStreamExtensions
   {
      /// <summary>
      /// Converts provided stream to <see cref="IBufferedStream"/>;
      /// </summary>
      /// <param name="stream">Stream to convert.</param>
      /// <returns>Converted stream.</returns>
      [return: NotNullIfNotNull("stream")]
      public static IBufferedStream? ToInterface(this BufferedStream? stream)
      {
         return stream == null ? null : new BufferedStreamAdapter(stream);
      }

      /// <summary>
      /// Converts provided <see cref="IBufferedStream"/> info to <see cref="BufferedStream"/>.
      /// </summary>
      /// <param name="abstraction">Instance of <see cref="IBufferedStream"/> to convert.</param>
      /// <returns>An instance of <see cref="BufferedStream"/>.</returns>
      [return: NotNullIfNotNull("abstraction")]
      public static BufferedStream? ToImplementation(this IBufferedStream? abstraction)
      {
         return ((IAbstraction<BufferedStream>?)abstraction)?.UnsafeConvert();
      }
   }
}
