using System;

namespace Thinktecture.Net.NetworkInformation
{
	/// <summary>Allows applications to receive notification when the Internet Protocol (IP) address of a network interface, also called a network card or adapter, changes.</summary>
	public interface INetworkChange
	{
#if NET45 || NET46 || NETSTANDARD2_0
		/// <summary>Occurs when the availability of the network changes.</summary>
		event EventHandler<INetworkAvailabilityEventArgs> NetworkAvailabilityChanged;
#endif

		/// <summary>Occurs when the IP address of a network interface changes.</summary>
		event EventHandler NetworkAddressChanged;
	}
}
