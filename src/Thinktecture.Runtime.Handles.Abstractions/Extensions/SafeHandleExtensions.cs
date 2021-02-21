using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using Thinktecture.Runtime.InteropServices;
using Thinktecture.Runtime.InteropServices.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extensions for <see cref="SafeHandle"/>.
   /// </summary>
   public static class SafeHandleExtensions
   {
      /// <summary>
      /// Converts safe handle to <see cref="ISafeHandle"/>.
      /// </summary>
      /// <param name="handle"><see cref="SafeHandle"/> to convert</param>
      /// <returns>Instance of <see cref="ISafeHandle"/>.</returns>
      [return: NotNullIfNotNull("handle")]
      public static ISafeHandle? ToInterface(this SafeHandle? handle)
      {
         return handle == null ? null : new SafeHandleAdapter(handle);
      }
   }
}
