using System.IO;
using System.Net.Sockets;
using Thinktecture.Net.Sockets;
using Thinktecture.Net.Sockets.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="Stream"/>.
	/// </summary>
	public static class NetworkStreamExtensions
	{
		/// <summary>
		/// Converts provided stream to <see cref="INetworkStream"/>.
		/// </summary>
		/// <param name="stream">Stream to convert.</param>
		/// <returns>Converted stream.</returns>
		public static INetworkStream ToInterface(this NetworkStream stream)
		{
			return (stream == null) ? null : new NetworkStreamAdapter(stream);
		}
	}
}