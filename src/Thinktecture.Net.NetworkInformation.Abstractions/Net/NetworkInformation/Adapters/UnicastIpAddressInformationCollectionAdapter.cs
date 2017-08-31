#if NETSTANDARD1_3 || NET45 || NET46

using System;
using System.Net.NetworkInformation;
using JetBrains.Annotations;
using Thinktecture.Collections.Generic;

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>
	/// Stores a set of UnicastIPAddressInformation types.
	/// </summary>
	public class UnicastIpAddressInformationCollectionAdapter : CollectionAbstractionAdapter<IUnicastIPAddressInformation, UnicastIPAddressInformation, UnicastIPAddressInformationCollection>, IUnicastIPAddressInformationCollection
	{
		/// <inheritdoc />
		public IUnicastIPAddressInformation this[int index] => Implementation[index].ToInterface();

		/// <summary>
		/// Initializes new instance of <see cref="UnicastIpAddressInformationCollectionAdapter"/>.
		/// </summary>
		/// <param name="collection">Collection to be used by the adapter.</param>
		public UnicastIpAddressInformationCollectionAdapter([NotNull] UnicastIPAddressInformationCollection collection)
			: base(collection, information => information.ToInterface())
		{
		}
	}
}

#endif
