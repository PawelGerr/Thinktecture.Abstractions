#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;

namespace Thinktecture.Net.NetworkInformation
{
	/// <summary>
	/// Provides Internet Protocol (IP) statistical data for an network interface on the local computer.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public interface IIPInterfaceStatistics : IAbstraction<IPInterfaceStatistics>
	{
		/// <summary>
		/// Gets the number of bytes that were received on the interface.
		/// </summary>
		long BytesReceived { get; }

		/// <summary>
		/// Gets the number of bytes that were sent on the interface.
		/// </summary>
		long BytesSent { get; }

		/// <summary>
		/// Gets the number of incoming packets that were discarded.
		/// </summary>
		long IncomingPacketsDiscarded { get; }

		/// <summary>
		/// Gets the number of incoming packets with errors.
		/// </summary>
		long IncomingPacketsWithErrors { get; }

		/// <summary>
		/// Gets the number of incoming packets with an unknown protocol that were received on the interface.
		/// </summary>
		long IncomingUnknownProtocolPackets { get; }

		/// <summary>
		/// Gets the number of non-unicast packets that were received on the interface.
		/// </summary>
		long NonUnicastPacketsReceived { get; }

		/// <summary>
		/// Gets the number of non-unicast packets that were sent on the interface.
		/// </summary>
		long NonUnicastPacketsSent { get; }

		/// <summary>
		/// Gets the number of outgoing packets that were discarded.
		/// </summary>
		long OutgoingPacketsDiscarded { get; }

		/// <summary>
		/// Gets the number of outgoing packets with errors.
		/// </summary>
		long OutgoingPacketsWithErrors { get; }

		/// <summary>
		/// Gets the length of the output queue.
		/// </summary>
		long OutputQueueLength { get; }

		/// <summary>
		/// Gets the number of unicast packets that were received on the interface.
		/// </summary>
		long UnicastPacketsReceived { get; }

		/// <summary>
		/// Gets the number of unicast packets that were sent on the interface.
		/// </summary>
		long UnicastPacketsSent { get; }
	}
}

#endif
