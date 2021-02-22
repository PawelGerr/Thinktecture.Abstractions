using System.Net.NetworkInformation;
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
		/// Initializes new instance of type <see cref="GatewayIPAddressInformation"/>
		/// </summary>
		/// <param name="info"></param>
		public GatewayIPAddressInformationAdapter(GatewayIPAddressInformation info)
			: base(info)
		{
		}
	}
}
