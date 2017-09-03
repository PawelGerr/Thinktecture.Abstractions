#if NETSTANDARD1_3 || NET45

using System.Net.NetworkInformation;
using JetBrains.Annotations;
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
		[CanBeNull]
		public static IIPAddressCollection ToInterface([CanBeNull] this IPAddressCollection collection)
		{
			return (collection == null) ? null : new IPAddressCollectionAdapter(collection);
		}
	}
}

#endif
