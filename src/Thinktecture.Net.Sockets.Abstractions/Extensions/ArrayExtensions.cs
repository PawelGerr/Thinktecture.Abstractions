using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;
using Thinktecture.Net.Sockets;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extensions for arrays.
   /// </summary>
   public static class ArrayExtensions
   {
      /// <summary>
      /// Converts an array of <see cref="SendPacketsElement"/> to an array of <see cref="ISendPacketsElement"/>.
      /// </summary>
      /// <param name="elements">Array to convert.</param>
      /// <returns>An array of <see cref="ISendPacketsElement"/>.</returns>
      [return: NotNullIfNotNull("elements")]
      public static ISendPacketsElement[]? ToInterface(this SendPacketsElement[]? elements)
      {
         if (elements == null)
            return null;

         var abstractions = new ISendPacketsElement[elements.Length];

         for (var i = 0; i < elements.Length; i++)
         {
            abstractions[i] = elements[i].ToInterface();
         }

         return abstractions;
      }
   }
}
