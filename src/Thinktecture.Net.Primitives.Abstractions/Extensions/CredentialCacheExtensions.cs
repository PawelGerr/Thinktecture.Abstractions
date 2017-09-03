#if NETSTANDARD1_1 || NETSTANDARD1_3 || NET45

using System.Net;
using JetBrains.Annotations;
using Thinktecture.Net;
using Thinktecture.Net.Adapters;

// ReSharper disable once CheckNamespace
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
		[CanBeNull]
		public static ICredentialCache ToInterface([CanBeNull] this CredentialCache cache)
		{
			return (cache == null) ? null : new CredentialCacheAdapter(cache);
		}
	}
}

#endif
