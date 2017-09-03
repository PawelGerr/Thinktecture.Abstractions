#if NETSTANDARD1_3 || NET45

using System.Net;
using JetBrains.Annotations;
using Thinktecture.Net;
using Thinktecture.Net.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="IPAddress"/>.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public static class IPAddressExtensions
	{
		/// <summary>
		/// Converts provided address to <see cref="IIPAddress"/>.
		/// </summary>
		/// <param name="address">Address to convert.</param>
		/// <returns>Converted address.</returns>
		[CanBeNull]
		public static IIPAddress ToInterface([CanBeNull] this IPAddress address)
		{
			if (address == null)
				return null;

			if (ReferenceEquals(address, IPAddress.Any))
				return IPAddressAdapter.Any;

			if (ReferenceEquals(address, IPAddress.Broadcast))
				return IPAddressAdapter.Broadcast;

			if (ReferenceEquals(address, IPAddress.IPv6Any))
				return IPAddressAdapter.IPv6Any;

			if (ReferenceEquals(address, IPAddress.IPv6Loopback))
				return IPAddressAdapter.IPv6Loopback;

			if (ReferenceEquals(address, IPAddress.IPv6None))
				return IPAddressAdapter.IPv6None;

			if (ReferenceEquals(address, IPAddress.Loopback))
				return IPAddressAdapter.Loopback;

			if (ReferenceEquals(address, IPAddress.None))
				return IPAddressAdapter.None;

			return new IPAddressAdapter(address);
		}
	}
}

#endif
