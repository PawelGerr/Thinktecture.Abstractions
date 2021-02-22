using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="MulticastIPAddressInformationCollection"/>.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public static class MulticastIPAddressInformationCollectionExtensions
	{
		/// <summary>
		/// Converts provided collection to <see cref="IMulticastIPAddressInformationCollection"/>.
		/// </summary>
		/// <param name="collection">Collection to convert.</param>
		/// <returns>Converted collection.</returns>
      [return:NotNullIfNotNull("collection")]

		public static IMulticastIPAddressInformationCollection? ToInterface(this MulticastIPAddressInformationCollection? collection)
		{
			return (collection == null) ? null : new MulticastIPAddressInformationCollectionAdapter(collection);
		}
	}
}
