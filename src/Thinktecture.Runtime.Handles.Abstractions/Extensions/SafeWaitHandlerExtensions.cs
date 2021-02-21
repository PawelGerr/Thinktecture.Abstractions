using System.Diagnostics.CodeAnalysis;
using Microsoft.Win32.SafeHandles;
using Thinktecture.Win32.SafeHandles;
using Thinktecture.Win32.SafeHandles.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extensions for <see cref="SafeWaitHandle"/>.
   /// </summary>
   public static class SafeWaitHandlerExtensions
   {
      /// <summary>
      /// Converts <see cref="SafeWaitHandle"/> to <see cref="ISafeWaitHandle"/>.
      /// </summary>
      /// <param name="handle"><see cref="SafeWaitHandle"/> to convert.</param>
      /// <returns>Instance of <see cref="ISafeWaitHandle"/>.</returns>
      [return: NotNullIfNotNull("handle")]
      public static ISafeWaitHandle? ToInterface(this SafeWaitHandle? handle)
      {
         return handle == null ? null : new SafeWaitHandleAdapter(handle);
      }

      /// <summary>
      /// Converts provided <see cref="ISafeWaitHandle"/> info to <see cref="SafeWaitHandle"/>.
      /// </summary>
      /// <param name="abstraction">Instance of <see cref="ISafeWaitHandle"/> to convert.</param>
      /// <returns>An instance of <see cref="SafeWaitHandle"/>.</returns>
      [return: NotNullIfNotNull("abstraction")]
      public static SafeWaitHandle? ToImplementation(this ISafeWaitHandle? abstraction)
      {
         return ((IAbstraction<SafeWaitHandle>?)abstraction)?.UnsafeConvert();
      }
   }
}
