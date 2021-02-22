using System.Net.NetworkInformation;
using Thinktecture.Collections.Generic;

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>
	/// Stores a set of MulticastIPAddressInformation types.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public class MulticastIPAddressInformationCollectionAdapter : NotNullCollectionAbstractionAdapter<IMulticastIPAddressInformation, MulticastIPAddressInformation, MulticastIPAddressInformationCollection>, IMulticastIPAddressInformationCollection
	{
		/// <inheritdoc />
		public IMulticastIPAddressInformation this[int index] => Implementation[index].ToInterface();

		/// <summary>
		/// Initializes new instance <see cref="MulticastIPAddressInformationCollectionAdapter"/>.
		/// </summary>
		/// <param name="collection">Collection to be used by the adapter.</param>
		public MulticastIPAddressInformationCollectionAdapter(MulticastIPAddressInformationCollection collection)
			: base(collection, information => information.ToInterface())
		{
		}
	}
}
