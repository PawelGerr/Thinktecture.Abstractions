#if NETSTANDARD1_3 || NET45 || NET46

using System.ComponentModel;
using System.Security.Authentication.ExtendedProtection;
using Thinktecture.Runtime.InteropServices;

namespace Thinktecture.Security.Authentication.ExtendedProtection
{
	/// <summary>The <see cref="ChannelBinding" /> class encapsulates a pointer to the opaque data used to bind an authenticated transaction to a secure channel.</summary>
	public interface IChannelBinding : ISafeHandle
	{
		/// <summary>
		/// Gets inner instance of <see cref="ChannelBinding"/>.
		/// It is not intended to be used directly. Use <see cref="ChannelBindingExtensions.ToImplementation"/> instead.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		new ChannelBinding UnsafeConvert();

		/// <summary>The <see cref="Size" /> property gets the size, in bytes, of the channel binding token associated with the <see cref="T:System.Security.Authentication.ExtendedProtection.ChannelBinding" /> instance.</summary>
		/// <returns>The size, in bytes, of the channel binding token in the <see cref="T:System.Security.Authentication.ExtendedProtection.ChannelBinding" /> instance.</returns>
		int Size { get; }
	}
}

#endif