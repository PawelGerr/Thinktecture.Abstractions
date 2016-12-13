#if NETSTANDARD1_3 || NET45 || NET46

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
		private readonly MulticastIPAddressInformation _info;

		/// <inheritdoc />
		public long AddressPreferredLifetime => _info.AddressPreferredLifetime;

		/// <inheritdoc />
		public long AddressValidLifetime => _info.AddressValidLifetime;

		/// <inheritdoc />
		public long DhcpLeaseLifetime => _info.DhcpLeaseLifetime;

		/// <inheritdoc />
		public DuplicateAddressDetectionState DuplicateAddressDetectionState => _info.DuplicateAddressDetectionState;

		/// <inheritdoc />
		public PrefixOrigin PrefixOrigin => _info.PrefixOrigin;

		/// <inheritdoc />
		public SuffixOrigin SuffixOrigin => _info.SuffixOrigin;

		/// <summary>
		/// Initializes new instance of <see cref="MulticastIPAddressInformationAdapter"/>.
		/// </summary>
		/// <param name="info">Information to be used by the adapter.</param>
		public MulticastIPAddressInformationAdapter(MulticastIPAddressInformation info) 
			: base(info)
		{
			if (info == null)
				throw new ArgumentNullException(nameof(info));

			_info = info;
		}

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new MulticastIPAddressInformation UnsafeConvert()
		{
			return _info;
		}
	}
}

#endif