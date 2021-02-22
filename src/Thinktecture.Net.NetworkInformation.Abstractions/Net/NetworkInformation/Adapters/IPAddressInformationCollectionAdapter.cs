using System.Net.NetworkInformation;
using Thinktecture.Collections.Generic;

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>
	/// Stores a set of IPAddressInformation types.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public class IPAddressInformationCollectionAdapter : NotNullCollectionAbstractionAdapter<IIPAddressInformation, IPAddressInformation, IPAddressInformationCollection>, IIPAddressInformationCollection
	{
		/// <inheritdoc />
		public IIPAddressInformation this[int index] => Implementation[index].ToInterface();

		/// <summary>
		/// Initializes new instance of <see cref="IPAddressInformationCollectionAdapter"/>
		/// </summary>
		/// <param name="collection">Collection to be used by the adapter.</param>
		public IPAddressInformationCollectionAdapter(IPAddressInformationCollection collection)
			: base(collection, information => information.ToInterface())
		{
		}
	}
}
