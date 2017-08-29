#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;
using JetBrains.Annotations;
using Thinktecture.Collections.Generic;

namespace Thinktecture.Net.NetworkInformation
{
	/// <summary>
	/// Stores a set of UnicastIPAddressInformation types.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public interface IUnicastIPAddressInformationCollection : ICollectionAbstraction<IUnicastIPAddressInformation, UnicastIPAddressInformation, UnicastIPAddressInformationCollection>
	{
		/// <summary>
		/// Gets the UnicastIPAddressInformation instance at the specified index in the collection.
		/// </summary>
		/// <param name="index">The zero-based index of the element.</param>
		/// <returns>The UnicastIPAddressInformation at the specified location.</returns>
		[CanBeNull]
		IUnicastIPAddressInformation this[int index] { get; }
	}
}

#endif
