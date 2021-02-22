using System;
using System.Net.NetworkInformation;

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>Allows applications to receive notification when the Internet Protocol (IP) address of a network interface, also called a network card or adapter, changes.</summary>
	public class NetworkChangeAdapter : INetworkChange
	{
		private readonly AbstractionDelegateLookup<INetworkAvailabilityEventArgs, NetworkAvailabilityChangedEventHandler> _networkAvailabilityChanged;

		private readonly AbstractionDelegateLookup<NetworkAddressChangedEventHandler> _networkAddressChanged;

		/// <summary>
		/// Initializes new instance of <see cref="NetworkChangeAdapter"/>.
		/// </summary>
		public NetworkChangeAdapter()
		{
			_networkAvailabilityChanged = new AbstractionDelegateLookup<INetworkAvailabilityEventArgs, NetworkAvailabilityChangedEventHandler>();
			_networkAddressChanged = new AbstractionDelegateLookup<NetworkAddressChangedEventHandler>();
		}

		/// <inheritdoc />
		public event EventHandler<INetworkAvailabilityEventArgs> NetworkAvailabilityChanged
		{
			add => NetworkChange.NetworkAvailabilityChanged += _networkAvailabilityChanged.MapForAttachment(value, abstraction => ((sender, args) => abstraction(sender, args.ToInterface())));
			remove => NetworkChange.NetworkAvailabilityChanged -= _networkAvailabilityChanged.TryMapForDetachment(value);
		}

		/// <inheritdoc />
		public event EventHandler NetworkAddressChanged
		{
			add => NetworkChange.NetworkAddressChanged += _networkAddressChanged.MapForAttachment(value, abstraction => ((sender, args) => abstraction(sender, EventArgs.Empty)));
			remove => NetworkChange.NetworkAddressChanged -= _networkAddressChanged.TryMapForDetachment(value);
		}
	}
}
