using System.Diagnostics.CodeAnalysis;
using System.Text;
using Thinktecture.Text;
using Thinktecture.Text.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extensions for <see cref="Encoder"/>.
   /// </summary>
   public static class EncoderExtensions
   {
      /// <summary>
      /// Converts provided encoder to <see cref="IEncoder"/>.
      /// </summary>
      /// <param name="encoder">Encoder to convert.</param>
      /// <returns>Converted encoder.</returns>
      [return: NotNullIfNotNull("encoder")]
      public static IEncoder? ToInterface(this Encoder? encoder)
      {
         return encoder is null ? null : new EncoderAdapter(encoder);
      }
   }
}
