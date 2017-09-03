#if NETSTANDARD1_3 || NET45 || NET46

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>Provides configuration and statistical information for network interfaces.</summary>
	public class NetworkInterfaceGlobals : INetworkInterfaceGlobals
	{
		/// <inheritdoc />
		public int LoopbackInterfaceIndex => NetworkInterfaceAdapter.LoopbackInterfaceIndex;

		/// <inheritdoc />
		public int IPv6LoopbackInterfaceIndex => NetworkInterfaceAdapter.IPv6LoopbackInterfaceIndex;

		/// <inheritdoc />
		public INetworkInterface[] GetAllNetworkInterfaces()
		{
			return NetworkInterfaceAdapter.GetAllNetworkInterfaces();
		}

		/// <inheritdoc />
		public bool GetIsNetworkAvailable()
		{
			return NetworkInterfaceAdapter.GetIsNetworkAvailable();
		}
	}
}

#endif
