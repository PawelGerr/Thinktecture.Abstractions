using System.Net.Sockets;
using Thinktecture.Net.Sockets;
using Thinktecture.Net.Sockets.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="Socket"/>.
	/// </summary>
	public static class SocketExtensions
	{
		/// <summary>
		/// Converts provided socket to <see cref="ISocket"/>.
		/// </summary>
		/// <param name="socket">Socket to convert.</param>
		/// <returns>Converted socket.</returns>
		public static ISocket ToInterface(this Socket socket)
		{
			return (socket == null) ? null : new SocketAdapter(socket);
		}

		/// <summary>
		/// Converts provided socket to <see cref="Socket"/>.
		/// </summary>
		/// <param name="socket">Socket to convert.</param>
		/// <returns>Converted socket.</returns>
		public static Socket ToImplementation(this ISocket socket)
		{
			return socket?.UnsafeConvert();
		}
	}
}