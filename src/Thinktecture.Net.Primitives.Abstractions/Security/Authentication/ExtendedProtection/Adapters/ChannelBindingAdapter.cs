#if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45

using System.Security.Authentication.ExtendedProtection;
using JetBrains.Annotations;

#if NETSTANDARD1_3 || NETSTANDARD2_0
using System;
using System.ComponentModel;
using Thinktecture.Runtime.InteropServices.Adapters;
#endif

namespace Thinktecture.Security.Authentication.ExtendedProtection.Adapters
{
	/// <summary>The <see cref="ChannelBindingAdapter" /> class encapsulates a pointer to the opaque data used to bind an authenticated transaction to a secure channel.</summary>
	public class ChannelBindingAdapter :
#if NETSTANDARD1_3 || NETSTANDARD2_0
		SafeHandleAdapter,
#else
		AbstractionAdapter<ChannelBinding>,
#endif
		IChannelBinding
	{
#if NETSTANDARD1_3 || NETSTANDARD2_0
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

#if NET45
		/// <inheritdoc />
		public bool IsInvalid => Implementation.IsInvalid;
#endif

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Authentication.ExtendedProtection.ChannelBinding" /> class.</summary>
		/// <param name="binding">The implementation to use by the adapter.</param>
		public ChannelBindingAdapter([NotNull] ChannelBinding binding)
			: base(binding)
		{
#if NETSTANDARD1_3 || NETSTANDARD2_0
			Implementation = binding ?? throw new ArgumentNullException(nameof(binding));
#endif
		}

#if NET45
		/// <inheritdoc />
		public void Dispose()
		{
			Implementation.Dispose();
		}
#endif
	}
}

#endif

