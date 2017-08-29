using System.Net.Sockets;
using JetBrains.Annotations;
using Thinktecture.Net.Sockets;
using Thinktecture.Net.Sockets.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="UdpClient"/>.
	/// </summary>
	public static class UdpClientExtensions
	{
		/// <summary>
		/// Converts provided client to <see cref="IUdpClient"/>.
		/// </summary>
		/// <param name="socket">Client to convert.</param>
		/// <returns>Converted client.</returns>
		[CanBeNull]
		public static IUdpClient ToInterface([CanBeNull] this UdpClient socket)
		{
			return (socket == null) ? null : new UdpClientAdapter(socket);
		}
	}
}
