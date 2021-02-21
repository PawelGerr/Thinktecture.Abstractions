using System.Diagnostics.CodeAnalysis;
using System.Net;
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
      [return: NotNullIfNotNull("cache")]
		public static ICredentialCache? ToInterface(this CredentialCache? cache)
		{
			return (cache == null) ? null : new CredentialCacheAdapter(cache);
		}
	}
}
