using System.Diagnostics.CodeAnalysis;
using System.Net;
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
      [return: NotNullIfNotNull("credential")]
		public static INetworkCredential? ToInterface(this NetworkCredential? credential)
		{
			if (credential == null)
				return null;

			if (ReferenceEquals(credential, CredentialCache.DefaultNetworkCredentials))
				return CredentialCacheAdapter.DefaultNetworkCredentials;

			return new NetworkCredentialAdapter(credential);
		}
	}
}
