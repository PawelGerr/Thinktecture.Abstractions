using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;
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
		/// <param name="client">Client to convert.</param>
		/// <returns>Converted client.</returns>
      [return: NotNullIfNotNull("client")]
		public static IUdpClient? ToInterface(this UdpClient? client)
		{
			return client == null ? null : new UdpClientAdapter(client);
		}
	}
}
