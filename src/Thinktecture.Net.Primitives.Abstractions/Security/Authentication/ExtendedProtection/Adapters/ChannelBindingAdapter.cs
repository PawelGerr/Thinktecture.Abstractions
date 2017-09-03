#if NETSTANDARD1_3 || NET45

using System.Security.Authentication.ExtendedProtection;
using JetBrains.Annotations;

#if NETSTANDARD1_3
using System;
using System.ComponentModel;
using Thinktecture.Runtime.InteropServices.Adapters;
#endif

namespace Thinktecture.Security.Authentication.ExtendedProtection.Adapters
{
	/// <summary>The <see cref="ChannelBindingAdapter" /> class encapsulates a pointer to the opaque data used to bind an authenticated transaction to a secure channel.</summary>
	public class ChannelBindingAdapter :
#if NETSTANDARD1_3
		SafeHandleAdapter,
#else
		AbstractionAdapter<ChannelBinding>,
#endif
		IChannelBinding
	{
#if NETSTANDARD1_3
		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		[NotNull]
		protected new ChannelBinding Implementation { get; }

		/// <inheritdoc />
		[NotNull]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new ChannelBinding UnsafeConvert()
		{
			return Implementation;
		}
#endif

		/// <inheritdoc />
		public int Size => Implementation.Size;

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Authentication.ExtendedProtection.ChannelBinding" /> class.</summary>
		/// <param name="binding">The implementation to use by the adapter.</param>
		public ChannelBindingAdapter([NotNull] ChannelBinding binding)
			: base(binding)
		{
#if NETSTANDARD1_3
			Implementation = binding ?? throw new ArgumentNullException(nameof(binding));
#endif
		}
	}
}

#endif
