using System.Diagnostics.CodeAnalysis;
using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extensions for <see cref="StreamWriter"/>.
   /// </summary>
   public static class StreamWriterExtensions
   {
      /// <summary>
      /// Converts provided writer to <see cref="IStreamWriter"/>.
      /// </summary>
      /// <param name="writer">Writer to convert.</param>
      /// <returns>Converted writer.</returns>
      [return: NotNullIfNotNull("writer")]
      public static IStreamWriter? ToInterface(this StreamWriter? writer)
      {
         if (writer == null)
            return null;

         if (ReferenceEquals(writer, StreamWriter.Null))
            return StreamWriterAdapter.Null;

         return new StreamWriterAdapter(writer);
      }

      /// <summary>
      /// Converts provided <see cref="IStreamWriter"/> info to <see cref="StreamWriter"/>.
      /// </summary>
      /// <param name="abstraction">Instance of <see cref="IStreamWriter"/> to convert.</param>
      /// <returns>An instance of <see cref="StreamWriter"/>.</returns>
      [return: NotNullIfNotNull("abstraction")]
      public static StreamWriter? ToImplementation(this IStreamWriter? abstraction)
      {
         return ((IAbstraction<StreamWriter>?)abstraction)?.UnsafeConvert();
      }
   }
}
