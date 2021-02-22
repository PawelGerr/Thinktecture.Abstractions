using System;
using System.ComponentModel;
using System.Net.NetworkInformation;
namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>
	/// Provides information about a network interface's multicast address.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public class MulticastIPAddressInformationAdapter : IPAddressInformationAdapter, IMulticastIPAddressInformation
	{
		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		protected new MulticastIPAddressInformation Implementation { get; }

		/// <inheritdoc />
		public long AddressPreferredLifetime => Implementation.AddressPreferredLifetime;

		/// <inheritdoc />
		public long AddressValidLifetime => Implementation.AddressValidLifetime;

		/// <inheritdoc />
		public long DhcpLeaseLifetime => Implementation.DhcpLeaseLifetime;

		/// <inheritdoc />
		public DuplicateAddressDetectionState DuplicateAddressDetectionState => Implementation.DuplicateAddressDetectionState;

		/// <inheritdoc />
		public PrefixOrigin PrefixOrigin => Implementation.PrefixOrigin;

		/// <inheritdoc />
		public SuffixOrigin SuffixOrigin => Implementation.SuffixOrigin;

		/// <summary>
		/// Initializes new instance of <see cref="MulticastIPAddressInformationAdapter"/>.
		/// </summary>
		/// <param name="info">Information to be used by the adapter.</param>
		public MulticastIPAddressInformationAdapter(MulticastIPAddressInformation info)
			: base(info)
		{
			Implementation = info ?? throw new ArgumentNullException(nameof(info));
		}

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new MulticastIPAddressInformation UnsafeConvert()
		{
			return Implementation;
		}
	}
}
