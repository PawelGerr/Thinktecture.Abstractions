#if NETSTANDARD1_3 || NET45 || NET46

using System;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>
	/// Provides information about a network interface's unicast address.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public class UnicastIPAddressInformationAdapter : IPAddressInformationAdapter, IUnicastIPAddressInformation
	{
		private readonly UnicastIPAddressInformation _info;

		/// <inheritdoc />
		public long AddressPreferredLifetime => _info.AddressPreferredLifetime;

		/// <inheritdoc />
		public long AddressValidLifetime => _info.AddressValidLifetime;

		/// <inheritdoc />
		public long DhcpLeaseLifetime => _info.DhcpLeaseLifetime;

		/// <inheritdoc />
		public DuplicateAddressDetectionState DuplicateAddressDetectionState => _info.DuplicateAddressDetectionState;

		/// <inheritdoc />
		public IIPAddress IPv4Mask => _info.IPv4Mask.ToInterface();

		/// <inheritdoc />
		public int PrefixLength => _info.PrefixLength;

		/// <inheritdoc />
		public PrefixOrigin PrefixOrigin => _info.PrefixOrigin;

		/// <inheritdoc />
		public SuffixOrigin SuffixOrigin => _info.SuffixOrigin;

		/// <summary>
		/// Initializes new instance of <see cref="UnicastIPAddressInformationAdapter"/>.
		/// </summary>
		/// <param name="info">Information to be used by the adapter.</param>
		public UnicastIPAddressInformationAdapter(UnicastIPAddressInformation info)
			: base(info)
		{
			_info = info ?? throw new ArgumentNullException(nameof(info));
		}

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new UnicastIPAddressInformation UnsafeConvert()
		{
			return _info;
		}
	}
}

#endif
