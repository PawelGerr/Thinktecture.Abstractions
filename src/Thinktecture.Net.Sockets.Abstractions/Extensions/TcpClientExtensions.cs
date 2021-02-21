using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;
using Thinktecture.Net.Sockets;
using Thinktecture.Net.Sockets.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="TcpClient"/>.
	/// </summary>
	public static class TcpClientExtensions
	{
		/// <summary>
		/// Converts provided client to <see cref="ITcpClient"/>.
		/// </summary>
		/// <param name="socket">Client to convert.</param>
		/// <returns>Converted client.</returns>
      [return: NotNullIfNotNull("socket")]
		public static ITcpClient? ToInterface(this TcpClient? socket)
		{
			return socket == null ? null : new TcpClientAdapter(socket);
		}
	}
}
