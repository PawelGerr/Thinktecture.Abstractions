#if NETSTANDARD1_3 || NET45 || NET46

using System;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>
	/// Provides information about a network interface address.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public class IPAddressInformationAdapter : AbstractionAdapter, IIPAddressInformation
	{
		private readonly IPAddressInformation _info;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new IPAddressInformation UnsafeConvert()
		{
			return _info;
		}

		/// <inheritdoc />
		public IIPAddress Address => _info.Address.ToInterface();

		/// <inheritdoc />
		public bool IsDnsEligible => _info.IsDnsEligible;

		/// <inheritdoc />
		public bool IsTransient => _info.IsTransient;

		/// <summary>
		/// Initializes new instance of <see cref="IPAddressInformationAdapter"/>.
		/// </summary>
		/// <param name="info">Information to be used by the adapter.</param>
		public IPAddressInformationAdapter(IPAddressInformation info)
			: base(info)
		{
			if (info == null)
				throw new ArgumentNullException(nameof(info));

			_info = info;
		}
	}
}

#endif