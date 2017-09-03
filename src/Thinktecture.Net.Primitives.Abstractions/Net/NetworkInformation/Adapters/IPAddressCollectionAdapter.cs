#if NETSTANDARD1_3 || NET45

using System.Net;
using System.Net.NetworkInformation;
using JetBrains.Annotations;
using Thinktecture.Collections.Generic;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>Stores a set of <see cref="T:System.Net.IPAddress" /> types.</summary>
	// ReSharper disable once InconsistentNaming
	public class IPAddressCollectionAdapter : CollectionAbstractionAdapter<IIPAddress, IPAddress, IPAddressCollection>, IIPAddressCollection
	{
		/// <inheritdoc />
		public IIPAddress this[int index] => Implementation[index].ToInterface();

		/// <summary>Initializes a new instance of the <see cref="IPAddressCollectionAdapter" /> class.</summary>
		/// <param name="collection">The implementation to use by the adapter.</param>
		public IPAddressCollectionAdapter([NotNull] IPAddressCollection collection)
			: base(collection, address => address.ToInterface())
		{
		}
	}
}

#endif
