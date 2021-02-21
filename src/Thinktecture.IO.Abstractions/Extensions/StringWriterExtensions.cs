using System.Diagnostics.CodeAnalysis;
using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extensions for <see cref="StringWriter"/>.
   /// </summary>
   public static class StringWriterExtensions
   {
      /// <summary>
      /// Converts provided writer to <see cref="IStringWriter"/>.
      /// </summary>
      /// <param name="writer">Writer to convert.</param>
      /// <returns>Converted writer.</returns>
      [return: NotNullIfNotNull("writer")]
      public static IStringWriter? ToInterface(this StringWriter? writer)
      {
         return (writer == null) ? null : new StringWriterAdapter(writer);
      }

      /// <summary>
      /// Converts provided <see cref="IStringWriter"/> info to <see cref="StringWriter"/>.
      /// </summary>
      /// <param name="abstraction">Instance of <see cref="IStringWriter"/> to convert.</param>
      /// <returns>An instance of <see cref="StringWriter"/>.</returns>
      [return: NotNullIfNotNull("abstraction")]
      public static StringWriter? ToImplementation(this IStringWriter? abstraction)
      {
         return ((IAbstraction<StringWriter>?)abstraction)?.UnsafeConvert();
      }
   }
}
