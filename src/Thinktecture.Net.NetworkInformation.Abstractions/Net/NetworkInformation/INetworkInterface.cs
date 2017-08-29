#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;
using JetBrains.Annotations;

namespace Thinktecture.Net.NetworkInformation
{
	/// <summary>Provides configuration and statistical information for a network interface.</summary>
	public interface INetworkInterface : IAbstraction<NetworkInterface>
	{
		/// <summary>Gets the identifier of the network adapter.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the identifier.</returns>
		[NotNull]
		string Id { get; }

		/// <summary>Gets the name of the network adapter.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the adapter name.</returns>
		[NotNull]
		string Name { get; }

		/// <summary>Gets the description of the interface.</summary>
		/// <returns>A <see cref="T:System.String" /> that describes this interface.</returns>
		[NotNull]
		string Description { get; }

		/// <summary>Gets the current operational state of the network connection.</summary>
		/// <returns>One of the <see cref="T:System.Net.NetworkInformation.OperationalStatus" /> values.</returns>
		OperationalStatus OperationalStatus { get; }

		/// <summary>Gets the speed of the network interface.</summary>
		/// <returns>A <see cref="T:System.Int64" /> value that specifies the speed in bits per second.</returns>
		long Speed { get; }

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether the network interface is set to only receive data packets.</summary>
		/// <returns>true if the interface only receives network traffic; otherwise, false.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">This property is not valid on computers running operating systems earlier than Windows XP. </exception>
		bool IsReceiveOnly { get; }

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether the network interface is enabled to receive multicast packets.</summary>
		/// <returns>true if the interface receives multicast packets; otherwise, false.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">This property is not valid on computers running operating systems earlier than Windows XP. </exception>
		bool SupportsMulticast { get; }

		/// <summary>Gets the interface type.</summary>
		/// <returns>An <see cref="T:System.Net.NetworkInformation.NetworkInterfaceType" /> value that specifies the network interface type.</returns>
		NetworkInterfaceType NetworkInterfaceType { get; }

		/// <summary>Returns an object that describes the configuration of this network interface.</summary>
		/// <returns>An <see cref="T:System.Net.NetworkInformation.IPInterfaceProperties" /> object that describes this network interface.</returns>
		[NotNull]
		// ReSharper disable once InconsistentNaming
		IIPInterfaceProperties GetIPProperties();

		/// <summary>Gets the IP statistics for this <see cref="T:System.Net.NetworkInformation.NetworkInterface" /> instance.</summary>
		/// <returns>Returns <see cref="T:System.Net.NetworkInformation.IPInterfaceStatistics" />.The IP statistics.</returns>
		[NotNull]
		// ReSharper disable once InconsistentNaming
		IIPInterfaceStatistics GetIPStatistics();

		/// <summary>Returns the Media Access Control (MAC) or physical address for this adapter.</summary>
		/// <returns>A <see cref="T:System.Net.NetworkInformation.PhysicalAddress" /> object that contains the physical address.</returns>
		[NotNull]
		IPhysicalAddress GetPhysicalAddress();

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether the interface supports the specified protocol.</summary>
		/// <returns>true if the specified protocol is supported; otherwise, false.</returns>
		/// <param name="networkInterfaceComponent">A <see cref="T:System.Net.NetworkInformation.NetworkInterfaceComponent" /> value.</param>
		bool Supports(NetworkInterfaceComponent networkInterfaceComponent);
	}
}

#endif
