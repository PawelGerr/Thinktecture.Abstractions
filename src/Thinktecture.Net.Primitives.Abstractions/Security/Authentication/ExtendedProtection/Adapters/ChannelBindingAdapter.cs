#if NETSTANDARD1_3 || NET45 || NET46

using System;
using System.ComponentModel;
using System.Security.Authentication.ExtendedProtection;
using Thinktecture.Runtime.InteropServices.Adapters;

namespace Thinktecture.Security.Authentication.ExtendedProtection.Adapters
{
	/// <summary>The <see cref="ChannelBindingAdapter" /> class encapsulates a pointer to the opaque data used to bind an authenticated transaction to a secure channel.</summary>
	public class ChannelBindingAdapter : SafeHandleAdapter, IChannelBinding
	{
		private readonly ChannelBinding _binding;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new ChannelBinding UnsafeConvert()
		{
			return _binding;
		}

		/// <inheritdoc />
		public int Size => _binding.Size;

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Authentication.ExtendedProtection.ChannelBinding" /> class.</summary>
		/// <param name="binding">The implementation to use by the adapter.</param>
		public ChannelBindingAdapter(ChannelBinding binding)
			: base(binding)
		{
			_binding = binding ?? throw new ArgumentNullException(nameof(binding));
		}
	}
}

#endif
