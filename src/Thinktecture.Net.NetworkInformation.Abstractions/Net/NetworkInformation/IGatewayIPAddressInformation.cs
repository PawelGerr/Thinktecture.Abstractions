#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;
using JetBrains.Annotations;

namespace Thinktecture.Net.NetworkInformation
{
	/// <summary>
	/// Represents the IP address of the network gateway.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public interface IGatewayIPAddressInformation : IAbstraction<GatewayIPAddressInformation>
	{
		/// <summary>
		/// Get the IP address of the gateway.
		/// </summary>
		[NotNull]
		IIPAddress Address { get; }
	}
}

#endif
