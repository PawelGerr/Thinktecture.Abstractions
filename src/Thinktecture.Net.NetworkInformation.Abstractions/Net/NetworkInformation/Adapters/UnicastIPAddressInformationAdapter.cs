#if NETSTANDARD1_3 || NET45 || NET46

using System;
using System.ComponentModel;
using System.Net.NetworkInformation;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>
	/// Provides information about a network interface's unicast address.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public class UnicastIPAddressInformationAdapter : IPAddressInformationAdapter, IUnicastIPAddressInformation
	{
		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		[NotNull]
		protected new UnicastIPAddressInformation Implementation { get; }

		/// <inheritdoc />
		public long AddressPreferredLifetime => Implementation.AddressPreferredLifetime;

		/// <inheritdoc />
		public long AddressValidLifetime => Implementation.AddressValidLifetime;

		/// <inheritdoc />
		public long DhcpLeaseLifetime => Implementation.DhcpLeaseLifetime;

		/// <inheritdoc />
		public DuplicateAddressDetectionState DuplicateAddressDetectionState => Implementation.DuplicateAddressDetectionState;

		/// <inheritdoc />
		public IIPAddress IPv4Mask => Implementation.IPv4Mask.ToInterface();

		/// <inheritdoc />
		public int PrefixLength => Implementation.PrefixLength;

		/// <inheritdoc />
		public PrefixOrigin PrefixOrigin => Implementation.PrefixOrigin;

		/// <inheritdoc />
		public SuffixOrigin SuffixOrigin => Implementation.SuffixOrigin;

		/// <summary>
		/// Initializes new instance of <see cref="UnicastIPAddressInformationAdapter"/>.
		/// </summary>
		/// <param name="info">Information to be used by the adapter.</param>
		public UnicastIPAddressInformationAdapter([NotNull] UnicastIPAddressInformation info)
			: base(info)
		{
			Implementation = info ?? throw new ArgumentNullException(nameof(info));
		}

		/// <inheritdoc />
		[NotNull, EditorBrowsable(EditorBrowsableState.Never)]
		public new UnicastIPAddressInformation UnsafeConvert()
		{
			return Implementation;
		}
	}
}

#endif
