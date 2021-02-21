using System.Diagnostics.CodeAnalysis;
using System.Security.Authentication.ExtendedProtection;
using Thinktecture.Security.Authentication.ExtendedProtection;
using Thinktecture.Security.Authentication.ExtendedProtection.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extensions for <see cref="ChannelBinding"/>.
   /// </summary>
   public static class ChannelBindingExtensions
   {
      /// <summary>
      /// Converts provided binding to <see cref="IChannelBinding"/>.
      /// </summary>
      /// <param name="binding">Binding to convert.</param>
      /// <returns>Converted binding.</returns>
      [return: NotNullIfNotNull("binding")]
      public static IChannelBinding? ToInterface(this ChannelBinding? binding)
      {
         return (binding == null) ? null : new ChannelBindingAdapter(binding);
      }

      /// <summary>
      /// Converts provided <see cref="IChannelBinding"/> info to <see cref="ChannelBinding"/>.
      /// </summary>
      /// <param name="abstraction">Instance of <see cref="IChannelBinding"/> to convert.</param>
      /// <returns>An instance of <see cref="ChannelBinding"/>.</returns>
      [return: NotNullIfNotNull("abstraction")]
      public static ChannelBinding? ToImplementation(this IChannelBinding? abstraction)
      {
         // ReSharper disable once RedundantCast
         return ((IAbstraction<ChannelBinding>?)abstraction)?.UnsafeConvert();
      }
   }
}
