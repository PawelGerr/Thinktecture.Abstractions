#if NETSTANDARD1_3 || NET45 || NET46

using System;
using System.Net.NetworkInformation;
using Thinktecture.Collections.Generic;

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>
	/// Stores a set of IPAddressInformation types.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public class IPAddressInformationCollectionAdapter : CollectionAbstractionAdapter<IIPAddressInformation, IPAddressInformation, IPAddressInformationCollection>, IIPAddressInformationCollection
	{
		private readonly IPAddressInformationCollection _collection;

		/// <inheritdoc />
		public IIPAddressInformation this[int index] => _collection[index].ToInterface();

		/// <summary>
		/// Initializes new instance of <see cref="IPAddressInformationCollectionAdapter"/>
		/// </summary>
		/// <param name="collection">Collection to be used by the adapter.</param>
		public IPAddressInformationCollectionAdapter(IPAddressInformationCollection collection)
			: base(collection, information => information.ToInterface())
		{
			_collection = collection ?? throw new ArgumentNullException(nameof(collection));
		}
	}
}

#endif
