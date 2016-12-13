#if NETSTANDARD1_3 || NET45 || NET46

using System;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>
	/// Provides Internet Protocol (IP) statistical data for an network interface on the local computer.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public class IPInterfaceStatisticsAdapter : AbstractionAdapter, IIPInterfaceStatistics
	{
		private readonly IPInterfaceStatistics _stats;

		/// <inheritdoc />
		public long BytesReceived => _stats.BytesReceived;

		/// <inheritdoc />
		public long BytesSent => _stats.BytesSent;

		/// <inheritdoc />
		public long IncomingPacketsDiscarded => _stats.IncomingPacketsDiscarded;

		/// <inheritdoc />
		public long IncomingPacketsWithErrors => _stats.IncomingPacketsWithErrors;

		/// <inheritdoc />
		public long IncomingUnknownProtocolPackets => _stats.IncomingUnknownProtocolPackets;

		/// <inheritdoc />
		public long NonUnicastPacketsReceived => _stats.NonUnicastPacketsReceived;

		/// <inheritdoc />
		public long NonUnicastPacketsSent => _stats.NonUnicastPacketsSent;

		/// <inheritdoc />
		public long OutgoingPacketsDiscarded => _stats.OutgoingPacketsDiscarded;

		/// <inheritdoc />
		public long OutgoingPacketsWithErrors => _stats.OutgoingPacketsWithErrors;

		/// <inheritdoc />
		public long OutputQueueLength => _stats.OutputQueueLength;

		/// <inheritdoc />
		public long UnicastPacketsReceived => _stats.UnicastPacketsReceived;

		/// <inheritdoc />
		public long UnicastPacketsSent => _stats.UnicastPacketsSent;

		/// <summary>
		/// Initializes new instance of <see cref="IPInterfaceStatisticsAdapter"/>.
		/// </summary>
		/// <param name="stats">Statistics to be used by the adapter.</param>
		public IPInterfaceStatisticsAdapter(IPInterfaceStatistics stats)
			: base(stats)
		{
			if (stats == null)
				throw new ArgumentNullException(nameof(stats));

			_stats = stats;
		}

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new IPInterfaceStatistics UnsafeConvert()
		{
			return _stats;
		}
	}
}

#endif