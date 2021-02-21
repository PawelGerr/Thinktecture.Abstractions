using System.Diagnostics.CodeAnalysis;
using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extensions for <see cref="BinaryWriter"/>.
   /// </summary>
   public static class BinaryWriterExtensions
   {
      /// <summary>
      /// Converts provided writer to <see cref="IBinaryWriter"/>.
      /// </summary>
      /// <param name="writer">Writer to convert.</param>
      /// <returns>Converted writer.</returns>
      [return: NotNullIfNotNull("writer")]
      public static IBinaryWriter? ToInterface(this BinaryWriter? writer)
      {
         if (writer == null)
            return null;

         if (ReferenceEquals(writer, BinaryWriter.Null))
            return BinaryWriterAdapter.Null;

         return new BinaryWriterAdapter(writer);
      }
   }
}
