#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;
using JetBrains.Annotations;
using Thinktecture.Collections.Generic;

namespace Thinktecture.Net.NetworkInformation
{
	/// <summary>
	/// Stores a set of GatewayIPAddressInformation types.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public interface IGatewayIPAddressInformationCollection : ICollectionAbstraction<IGatewayIPAddressInformation, GatewayIPAddressInformation, GatewayIPAddressInformationCollection>
	{
		/// <summary>
		/// Gets the GatewayIPAddressInformation at the specific index of the collection.
		/// </summary>
		/// <param name="index">The index of interest.</param>
		/// <returns>The GatewayIPAddressInformation at the specific index in the collection.</returns>
		[CanBeNull]
		IGatewayIPAddressInformation this[int index] { get; }
	}
}

#endif
