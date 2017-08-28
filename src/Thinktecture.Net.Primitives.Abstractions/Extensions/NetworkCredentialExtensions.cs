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
			return (credential == null) ? null : new NetworkCredentialAdapter(credential);
		}
	}
}
