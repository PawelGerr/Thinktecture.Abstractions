#if NETSTANDARD1_3 || NET45 || NET46

using System;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>
	/// Represents the IP address of the network gateway.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public class GatewayIPAddressInformationAdapter : AbstractionAdapter, IGatewayIPAddressInformation
	{
		private readonly GatewayIPAddressInformation _info;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new GatewayIPAddressInformation UnsafeConvert()
		{
			return _info;
		}

		/// <inheritdoc />
		public IIPAddress Address => _info.Address.ToInterface();

		/// <summary>
		/// Initialies new instance of type <see cref="GatewayIPAddressInformation"/>
		/// </summary>
		/// <param name="info"></param>
		public GatewayIPAddressInformationAdapter(GatewayIPAddressInformation info)
			: base(info)
		{
			if (info == null)
				throw new ArgumentNullException(nameof(info));

			_info = info;
		}
	}
}

#endif