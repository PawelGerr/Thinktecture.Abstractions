#if NETSTANDARD1_3 || NET45 || NET46

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
			return (address == null) ? null : new IPAddressAdapter(address);
		}
	}
}

#endif
