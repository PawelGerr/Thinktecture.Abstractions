using System.Diagnostics.CodeAnalysis;
using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extensions for <see cref="TextWriter"/>.
   /// </summary>
   public static class TextWriterExtensions
   {
      /// <summary>
      /// Converts writer to <see cref="ITextWriter"/>.
      /// </summary>
      /// <param name="writer">Writer to convert.</param>
      /// <returns>Converted writer.</returns>
      [return: NotNullIfNotNull("writer")]
      public static ITextWriter? ToInterface(this TextWriter? writer)
      {
         if (writer == null)
            return null;

         if (ReferenceEquals(writer, TextWriter.Null))
            return TextWriterAdapter.Null;

         return new TextWriterAdapter(writer);
      }
   }
}
