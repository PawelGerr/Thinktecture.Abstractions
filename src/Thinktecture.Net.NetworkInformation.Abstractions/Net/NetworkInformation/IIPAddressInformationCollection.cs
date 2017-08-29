#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;
using JetBrains.Annotations;
using Thinktecture.Collections.Generic;

namespace Thinktecture.Net.NetworkInformation
{
	/// <summary>
	/// Stores a set of IPAddressInformation types.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public interface IIPAddressInformationCollection : ICollectionAbstraction<IIPAddressInformation, IPAddressInformation, IPAddressInformationCollection>
	{
		/// <summary>
		/// Gets the IPAddressInformation at the specified index in the collection.
		/// </summary>
		/// <param name="index">The zero-based index of the element.</param>
		/// <returns>The IPAddressInformation at the specified location.</returns>
		[CanBeNull]
		IIPAddressInformation this[int index] { get; }
	}
}

#endif
