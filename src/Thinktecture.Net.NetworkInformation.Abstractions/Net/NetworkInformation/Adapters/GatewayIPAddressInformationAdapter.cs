#if NETSTANDARD1_3 || NET45 || NET46

using System;
using System.Net.NetworkInformation;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>
	/// Represents the IP address of the network gateway.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public class GatewayIPAddressInformationAdapter : AbstractionAdapter<GatewayIPAddressInformation>, IGatewayIPAddressInformation
	{
		/// <inheritdoc />
		public IIPAddress Address => Implementation.Address.ToInterface();

		/// <summary>
		/// Initialies new instance of type <see cref="GatewayIPAddressInformation"/>
		/// </summary>
		/// <param name="info"></param>
		public GatewayIPAddressInformationAdapter([NotNull] GatewayIPAddressInformation info)
			: base(info)
		{
		}
	}
}

#endif
