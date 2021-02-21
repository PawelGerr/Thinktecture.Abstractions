using System.Diagnostics.CodeAnalysis;
using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extensions for <see cref="BinaryReader"/>.
   /// </summary>
   public static class BinaryReaderExtensions
   {
      /// <summary>
      /// Converts provided reader to <see cref="IBinaryReader"/>.
      /// </summary>
      /// <param name="reader">Reader to convert.</param>
      /// <returns>Converted reader.</returns>
      [return: NotNullIfNotNull("reader")]
      public static IBinaryReader? ToInterface(this BinaryReader? reader)
      {
         return reader == null ? null : new BinaryReaderAdapter(reader);
      }
   }
}
