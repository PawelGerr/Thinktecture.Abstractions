using System.Net.Sockets;
using Thinktecture.IO;

namespace Thinktecture.Net.Sockets
{
	/// <summary>
	/// Provides the underlying stream of data for network access.
	/// </summary>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface INetworkStream : IStream, IAbstraction<NetworkStream>
	{
		/// <summary>
		/// Gets a value that indicates whether data is available on the NetworkStream to be read.
		/// </summary>
		bool DataAvailable { get; }
	}
}
