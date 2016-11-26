#if NETSTANDARD1_3 || NET45 || NET46

using System.Net;
using Thinktecture.Net;
using Thinktecture.Net.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="SocketAddress"/>.
	/// </summary>
	public static class SocketAddressExtensions
	{
		/// <summary>
		/// Converts provided address to <see cref="ISocketAddress"/>.
		/// </summary>
		/// <param name="address">Address to convert.</param>
		/// <returns>Converted address.</returns>
		public static ISocketAddress ToInterface(this SocketAddress address)
		{
			return (address == null) ? null : new SocketAddressAdapter(address);
		}

		/// <summary>
		/// Converts provided address to <see cref="SocketAddress"/>.
		/// </summary>
		/// <param name="address">Address to convert.</param>
		/// <returns>Converted address.</returns>
		public static SocketAddress ToImplementation(this ISocketAddress address)
		{
			return address?.UnsafeConvert();
		}
	}
}

#endif