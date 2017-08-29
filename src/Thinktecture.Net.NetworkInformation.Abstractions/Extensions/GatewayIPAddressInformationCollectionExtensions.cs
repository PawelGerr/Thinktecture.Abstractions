#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;
using JetBrains.Annotations;
using Thinktecture.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="GatewayIPAddressInformationCollection"/>.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public static class GatewayIPAddressInformationCollectionExtensions
	{
		/// <summary>
		/// Converts provided collection to <see cref="IGatewayIPAddressInformationCollection"/>.
		/// </summary>
		/// <param name="collection">Collection to convert.</param>
		/// <returns>Converted collection.</returns>
		[CanBeNull]
		public static IGatewayIPAddressInformationCollection ToInterface([CanBeNull] this GatewayIPAddressInformationCollection collection)
		{
			return (collection == null) ? null : new GatewayIPAddressInformationCollectionAdapter(collection);
		}
	}
}

#endif
