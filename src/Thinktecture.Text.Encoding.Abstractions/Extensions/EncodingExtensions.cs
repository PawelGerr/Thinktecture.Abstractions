using System.Diagnostics.CodeAnalysis;
using System.Text;
using Thinktecture.Text;
using Thinktecture.Text.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extensions for <see cref="Encoding"/>.
   /// </summary>
   public static class EncodingExtensions
   {
      /// <summary>
      /// Converts provided encoding to <see cref="IEncoding"/>.
      /// </summary>
      /// <param name="encoding">Encoding to convert.</param>
      /// <returns>Converted encoding.</returns>
      [return: NotNullIfNotNull("encoding")]
      public static IEncoding? ToInterface(this Encoding? encoding)
      {
         if (encoding == null)
            return null;

         if (ReferenceEquals(encoding, Encoding.BigEndianUnicode))
            return EncodingAdapter.BigEndianUnicode;

         if (ReferenceEquals(encoding, Encoding.Unicode))
            return EncodingAdapter.Unicode;

         if (ReferenceEquals(encoding, Encoding.UTF8))
            return EncodingAdapter.UTF8;

         return new EncodingAdapter(encoding);
      }
   }
}
