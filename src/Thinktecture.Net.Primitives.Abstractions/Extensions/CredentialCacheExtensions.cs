#if NETSTANDARD1_1 || NETSTANDARD1_3 || NET45 || NET46

using System;
using System.Net;
using Thinktecture.Net;
using Thinktecture.Net.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="CredentialCache"/>.
	/// </summary>
	public static class CredentialCacheExtensions
	{
		/// <summary>
		/// Converts provided cache to <see cref="ICredentialCache"/>.
		/// </summary>
		/// <param name="cache">Cache to convert.</param>
		/// <returns>Converted cache.</returns>
		public static ICredentialCache ToInterface(this CredentialCache cache)
		{
			return (cache == null) ? null : new CredentialCacheAdapter(cache);
		}
	}
}

#endif