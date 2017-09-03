#if NETSTANDARD1_3 || NET45

using System.Net;
using JetBrains.Annotations;
using Thinktecture.Net;
using Thinktecture.Net.Adapters;

// ReSharper disable once CheckNamespace
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
		[CanBeNull]
		public static ISocketAddress ToInterface([CanBeNull] this SocketAddress address)
		{
			return (address == null) ? null : new SocketAddressAdapter(address);
		}
	}
}

#endif
