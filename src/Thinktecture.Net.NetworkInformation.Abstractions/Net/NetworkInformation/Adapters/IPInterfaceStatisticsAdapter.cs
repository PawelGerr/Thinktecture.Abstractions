#if NETSTANDARD1_3 || NET45 || NET46

using System;
using System.Net.NetworkInformation;
using JetBrains.Annotations;

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>
	/// Provides Internet Protocol (IP) statistical data for an network interface on the local computer.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public class IPInterfaceStatisticsAdapter : AbstractionAdapter<IPInterfaceStatistics>, IIPInterfaceStatistics
	{
		/// <inheritdoc />
		public long BytesReceived => Implementation.BytesReceived;

		/// <inheritdoc />
		public long BytesSent => Implementation.BytesSent;

		/// <inheritdoc />
		public long IncomingPacketsDiscarded => Implementation.IncomingPacketsDiscarded;

		/// <inheritdoc />
		public long IncomingPacketsWithErrors => Implementation.IncomingPacketsWithErrors;

		/// <inheritdoc />
		public long IncomingUnknownProtocolPackets => Implementation.IncomingUnknownProtocolPackets;

		/// <inheritdoc />
		public long NonUnicastPacketsReceived => Implementation.NonUnicastPacketsReceived;

		/// <inheritdoc />
		public long NonUnicastPacketsSent => Implementation.NonUnicastPacketsSent;

		/// <inheritdoc />
		public long OutgoingPacketsDiscarded => Implementation.OutgoingPacketsDiscarded;

		/// <inheritdoc />
		public long OutgoingPacketsWithErrors => Implementation.OutgoingPacketsWithErrors;

		/// <inheritdoc />
		public long OutputQueueLength => Implementation.OutputQueueLength;

		/// <inheritdoc />
		public long UnicastPacketsReceived => Implementation.UnicastPacketsReceived;

		/// <inheritdoc />
		public long UnicastPacketsSent => Implementation.UnicastPacketsSent;

		/// <summary>
		/// Initializes new instance of <see cref="IPInterfaceStatisticsAdapter"/>.
		/// </summary>
		/// <param name="stats">Statistics to be used by the adapter.</param>
		public IPInterfaceStatisticsAdapter([NotNull] IPInterfaceStatistics stats)
			: base(stats)
		{
		}
	}
}

#endif
