#if NETSTANDARD1_3 || NET45 || NET46

using System;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>Provides configuration and statistical information for a network interface.</summary>
	public class NetworkInterfaceAdapter : AbstractionAdapter, INetworkInterface
	{
		private readonly NetworkInterface _nic;

		/// <inheritdoc />
		public string Id => _nic.Id;

		/// <inheritdoc />
		public string Name => _nic.Name;

		/// <inheritdoc />
		public string Description => _nic.Description;

		/// <inheritdoc />
		public OperationalStatus OperationalStatus => _nic.OperationalStatus;

		/// <inheritdoc />
		public long Speed => _nic.Speed;

		/// <inheritdoc />
		public bool IsReceiveOnly => _nic.IsReceiveOnly;

		/// <inheritdoc />
		public bool SupportsMulticast => _nic.SupportsMulticast;

		/// <inheritdoc />
		public NetworkInterfaceType NetworkInterfaceType => _nic.NetworkInterfaceType;

		/// <summary>Initializes a new instance of the <see cref="NetworkInterfaceAdapter" /> class.</summary>
		/// <param name="nic">Network interface to be used by the adapter.</param>
		public NetworkInterfaceAdapter(NetworkInterface nic)
			: base(nic)
		{
			if (nic == null)
				throw new ArgumentNullException(nameof(nic));

			_nic = nic;
		}

		/// <inheritdoc />
		public IIPInterfaceProperties GetIPProperties()
		{
			return _nic.GetIPProperties().ToInterface();
		}

		/// <inheritdoc />
		public IIPInterfaceStatistics GetIPStatistics()
		{
			return _nic.GetIPStatistics().ToInterface();
		}

		/// <inheritdoc />
		public IPhysicalAddress GetPhysicalAddress()
		{
			return _nic.GetPhysicalAddress().ToInterface();
		}

		/// <inheritdoc />
		public bool Supports(NetworkInterfaceComponent networkInterfaceComponent)
		{
			return _nic.Supports(networkInterfaceComponent);
		}

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new NetworkInterface UnsafeConvert()
		{
			return _nic;
		}
	}
}

#endif