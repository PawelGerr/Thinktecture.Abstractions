#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;
using JetBrains.Annotations;
using Thinktecture.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="UnicastIPAddressInformationCollection"/>.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public static class UnicastIPAddressInformationCollectionExtensions
	{
		/// <summary>
		/// Converts provided collection to <see cref="IUnicastIPAddressInformationCollection"/>.
		/// </summary>
		/// <param name="collection">Collection to convert.</param>
		/// <returns>Converted collection.</returns>
		[CanBeNull]
		public static IUnicastIPAddressInformationCollection ToInterface([CanBeNull] this UnicastIPAddressInformationCollection collection)
		{
			return (collection == null) ? null : new UnicastIpAddressInformationCollectionAdapter(collection);
		}
	}
}

#endif
