using System.Net;
using Thinktecture.Net;
using Thinktecture.Net.Adapters;

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
		public static INetworkCredential ToInterface(this NetworkCredential credential)
		{
			return (credential == null) ? null : new NetworkCredentialAdapter(credential);
		}
	}
}