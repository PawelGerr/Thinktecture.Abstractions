#if NETSTANDARD1_3 || NET45 || NET46

using System.Net;
using System.Net.NetworkInformation;
using Thinktecture.Collections.Generic;

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>Stores a set of <see cref="T:System.Net.IPAddress" /> types.</summary>
	public class IPAddressCollectionAdapter : CollectionAbstractionAdapter<IIPAddress, IPAddress, IPAddressCollection>, IIPAddressCollection
	{
		/// <inheritdoc />
		public IIPAddress this[int index] => Collection[index].ToInterface();

		/// <summary>Initializes a new instance of the <see cref="IPAddressCollectionAdapter" /> class.</summary>
		public IPAddressCollectionAdapter(IPAddressCollection collection)
			: base(collection, address => address.ToInterface())
		{
		}
	}
}

#endif
