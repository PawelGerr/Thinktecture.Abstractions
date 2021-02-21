using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Net.Sockets;
using Thinktecture.Net.Sockets;
using Thinktecture.Net.Sockets.Adapters;

// ReSharper disable once CheckNamespace
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
      [return: NotNullIfNotNull("stream")]
		public static INetworkStream? ToInterface(this NetworkStream? stream)
		{
			return (stream == null) ? null : new NetworkStreamAdapter(stream);
		}

		/// <summary>
		/// Converts provided <see cref="INetworkStream"/> info to <see cref="NetworkStream"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="INetworkStream"/> to convert.</param>
		/// <returns>An instance of <see cref="NetworkStream"/>.</returns>
      [return: NotNullIfNotNull("abstraction")]
		public static NetworkStream? ToImplementation(this INetworkStream? abstraction)
		{
			return ((IAbstraction<NetworkStream>?)abstraction)?.UnsafeConvert();
		}
	}
}
