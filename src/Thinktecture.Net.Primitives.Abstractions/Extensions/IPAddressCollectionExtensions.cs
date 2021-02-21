using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="IPAddressCollection"/>.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public static class IPAddressCollectionExtensions
	{
		/// <summary>
		/// Converts provided collection to <see cref="IIPAddressCollection"/>.
		/// </summary>
		/// <param name="collection">Collection to convert.</param>
		/// <returns>Converted collection.</returns>
      [return: NotNullIfNotNull("collection")]
		public static IIPAddressCollection? ToInterface(this IPAddressCollection? collection)
		{
			return (collection == null) ? null : new IPAddressCollectionAdapter(collection);
		}
	}
}
