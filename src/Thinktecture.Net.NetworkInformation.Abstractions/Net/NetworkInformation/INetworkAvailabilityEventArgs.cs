using System.Net.NetworkInformation;

namespace Thinktecture.Net.NetworkInformation
{
	/// <summary>Provides data for the <see cref="INetworkChange.NetworkAvailabilityChanged" /> event.</summary>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface INetworkAvailabilityEventArgs : IAbstraction<NetworkAvailabilityEventArgs>, IEventArgs
	{
		/// <summary>Gets the current status of the network connection.</summary>
		/// <returns>
		/// <see langword="true" /> if the network is available; otherwise, <see langword="false" />.</returns>
		bool IsAvailable { get; }
	}
}
