using System.Net.Sockets;
using JetBrains.Annotations;
using Thinktecture.Net.Sockets;
using Thinktecture.Net.Sockets.Adapters;

// ReSharper disable once CheckNamespace
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
		[CanBeNull]
		public static ISocket ToInterface([CanBeNull] this Socket socket)
		{
			return (socket == null) ? null : new SocketAdapter(socket);
		}
	}
}
