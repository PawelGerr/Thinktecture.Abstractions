using System.Net;
using JetBrains.Annotations;
using Thinktecture.Net;
using Thinktecture.Net.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="NetworkCredential"/>.
	/// </summary>
	public static class NetworkCredentialExtensions
	{
		/// <summary>
		/// Converts provided credential to <see cref="INetworkCredential"/>.
		/// </summary>
		/// <param name="credential">Credential to convert.</param>
		/// <returns>Converted credential.</returns>
		[CanBeNull]
		public static INetworkCredential ToInterface([CanBeNull] this NetworkCredential credential)
		{
			if (credential == null)
				return null;

#if NETSTANDARD1_1 || NETSTANDARD1_3 || NET45
			if (ReferenceEquals(credential, CredentialCache.DefaultNetworkCredentials))
				return CredentialCacheAdapter.DefaultNetworkCredentials;
#endif

			return new NetworkCredentialAdapter(credential);
		}
	}
}
