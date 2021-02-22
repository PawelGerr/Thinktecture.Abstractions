using System.Net.NetworkInformation;
// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>
	/// Provides information about a network interface address.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public class IPAddressInformationAdapter : AbstractionAdapter<IPAddressInformation>, IIPAddressInformation
	{
		/// <inheritdoc />
		public IIPAddress Address => Implementation.Address.ToInterface();

		/// <inheritdoc />
		public bool IsDnsEligible => Implementation.IsDnsEligible;

		/// <inheritdoc />
		public bool IsTransient => Implementation.IsTransient;

		/// <summary>
		/// Initializes new instance of <see cref="IPAddressInformationAdapter"/>.
		/// </summary>
		/// <param name="info">Information to be used by the adapter.</param>
		public IPAddressInformationAdapter(IPAddressInformation info)
			: base(info)
		{
		}
	}
}
