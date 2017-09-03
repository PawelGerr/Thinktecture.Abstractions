#if NETSTANDARD1_3 || NET45

using System.Net;
using System.Net.NetworkInformation;
using JetBrains.Annotations;
using Thinktecture.Collections.Generic;

namespace Thinktecture.Net.NetworkInformation
{
	/// <summary>Stores a set of <see cref="T:System.Net.IPAddress" /> types.</summary>
	// ReSharper disable once InconsistentNaming
	public interface IIPAddressCollection : ICollectionAbstraction<IIPAddress, IPAddress, IPAddressCollection>
	{
		/// <summary>Gets the <see cref="IIPAddress" /> at the specific index of the collection.</summary>
		/// <returns>The <see cref="IIPAddress" /> at the specific index in the collection.</returns>
		/// <param name="index">The index of interest.</param>
		[NotNull]
		IIPAddress this[int index] { get; }
	}
}

#endif
