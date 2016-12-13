#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>Provides configuration and statistical information for network interfaces.</summary>
	public class NetworkInterfaceInformation : INetworkInterfaceInformation
	{
		/// <inheritdoc />
		public int LoopbackInterfaceIndex => NetworkInterface.LoopbackInterfaceIndex;

		/// <inheritdoc />
		public int IPv6LoopbackInterfaceIndex => NetworkInterface.IPv6LoopbackInterfaceIndex;

		/// <inheritdoc />
		public INetworkInterface[] GetAllNetworkInterfaces()
		{
			return NetworkInterface.GetAllNetworkInterfaces().ToInterface();
		}
		
		/// <inheritdoc />
		public bool GetIsNetworkAvailable()
		{
			return NetworkInterface.GetIsNetworkAvailable();
		}
	}
}

#endif