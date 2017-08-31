#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;
using JetBrains.Annotations;
using Thinktecture.Collections.Generic;

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>
	/// Stores a set of MulticastIPAddressInformation types.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public class MulticastIPAddressInformationCollectionAdapter : CollectionAbstractionAdapter<IMulticastIPAddressInformation, MulticastIPAddressInformation, MulticastIPAddressInformationCollection>, IMulticastIPAddressInformationCollection
	{
		/// <inheritdoc />
		public IMulticastIPAddressInformation this[int index] => Implementation[index].ToInterface();

		/// <summary>
		/// Initializes new instance <see cref="MulticastIPAddressInformationCollectionAdapter"/>.
		/// </summary>
		/// <param name="collection">Collection to be used by the adapter.</param>
		public MulticastIPAddressInformationCollectionAdapter([NotNull] MulticastIPAddressInformationCollection collection)
			: base(collection, information => information.ToInterface())
		{
		}
	}
}

#endif
