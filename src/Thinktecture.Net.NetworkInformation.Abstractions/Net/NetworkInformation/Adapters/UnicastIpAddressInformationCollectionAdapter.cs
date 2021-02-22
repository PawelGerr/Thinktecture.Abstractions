using System.Net.NetworkInformation;
using Thinktecture.Collections.Generic;

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>
	/// Stores a set of UnicastIPAddressInformation types.
	/// </summary>
	public class UnicastIpAddressInformationCollectionAdapter : NotNullCollectionAbstractionAdapter<IUnicastIPAddressInformation, UnicastIPAddressInformation, UnicastIPAddressInformationCollection>, IUnicastIPAddressInformationCollection
	{
		/// <inheritdoc />
		public IUnicastIPAddressInformation this[int index] => Implementation[index].ToInterface();

		/// <summary>
		/// Initializes new instance of <see cref="UnicastIpAddressInformationCollectionAdapter"/>.
		/// </summary>
		/// <param name="collection">Collection to be used by the adapter.</param>
		public UnicastIpAddressInformationCollectionAdapter(UnicastIPAddressInformationCollection collection)
			: base(collection, information => information.ToInterface())
		{
		}
	}
}
