using System.Security.Authentication.ExtendedProtection;
using System;
using System.ComponentModel;
using Thinktecture.Runtime.InteropServices.Adapters;

namespace Thinktecture.Security.Authentication.ExtendedProtection.Adapters
{
   /// <summary>The <see cref="ChannelBindingAdapter" /> class encapsulates a pointer to the opaque data used to bind an authenticated transaction to a secure channel.</summary>
   public class ChannelBindingAdapter : SafeHandleAdapter, IChannelBinding
   {
      /// <summary>
      /// Implementation used by the adapter.
      /// </summary>
      protected new ChannelBinding Implementation { get; }

      /// <inheritdoc />
      [EditorBrowsable(EditorBrowsableState.Never)]
      public new ChannelBinding UnsafeConvert()
      {
         return Implementation;
      }

      /// <inheritdoc />
      public int Size => Implementation.Size;

      /// <summary>Initializes a new instance of the <see cref="T:System.Security.Authentication.ExtendedProtection.ChannelBinding" /> class.</summary>
      /// <param name="binding">The implementation to use by the adapter.</param>
      public ChannelBindingAdapter(ChannelBinding binding)
         : base(binding)
      {
         Implementation = binding ?? throw new ArgumentNullException(nameof(binding));
      }
   }
}
