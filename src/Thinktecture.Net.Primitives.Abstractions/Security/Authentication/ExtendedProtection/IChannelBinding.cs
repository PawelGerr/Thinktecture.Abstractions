#if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
using System.Security.Authentication.ExtendedProtection;

#if NETSTANDARD1_3 || NETSTANDARD2_0
using Thinktecture.Runtime.InteropServices;
#else
using System;
#endif

namespace Thinktecture.Security.Authentication.ExtendedProtection
{
	/// <summary>The <see cref="ChannelBinding" /> class encapsulates a pointer to the opaque data used to bind an authenticated transaction to a secure channel.</summary>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface IChannelBinding :
#if NETSTANDARD1_3 || NETSTANDARD2_0
		ISafeHandle,
#else
		IDisposable,
#endif
		IAbstraction<ChannelBinding>
	{
		/// <summary>The <see cref="Size" /> property gets the size, in bytes, of the channel binding token associated with the <see cref="T:System.Security.Authentication.ExtendedProtection.ChannelBinding" /> instance.</summary>
		/// <returns>The size, in bytes, of the channel binding token in the <see cref="T:System.Security.Authentication.ExtendedProtection.ChannelBinding" /> instance.</returns>
		int Size { get; }

#if NET45
		/// <summary>Gets a value that indicates whether the handle is invalid.</summary>
		/// <returns>true if the handle is not valid; otherwise, false.</returns>
		bool IsInvalid { get; }
#endif
	}
}

#endif
