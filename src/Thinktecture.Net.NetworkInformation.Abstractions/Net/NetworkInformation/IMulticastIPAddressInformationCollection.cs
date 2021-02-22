using System.Net.NetworkInformation;
using Thinktecture.Collections.Generic;

namespace Thinktecture.Net.NetworkInformation
{
	/// <summary>
	/// Stores a set of MulticastIPAddressInformation types.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public interface IMulticastIPAddressInformationCollection : INotNullCollectionAbstraction<IMulticastIPAddressInformation, MulticastIPAddressInformation, MulticastIPAddressInformationCollection>
	{
		/// <summary>
		/// Gets the MulticastIPAddressInformation at the specific index of the collection.
		/// </summary>
		/// <param name="index">The index of interest.</param>
		/// <returns>The MulticastIPAddressInformation at the specific index in the collection.</returns>
		IMulticastIPAddressInformation? this[int index] { get; }
	}
}
