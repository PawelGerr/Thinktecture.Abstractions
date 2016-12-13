#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="PhysicalAddress"/>.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public static class PhysicalAddressExtensions
	{
		/// <summary>
		/// Converts provided address to <see cref="IPhysicalAddress"/>.
		/// </summary>
		/// <param name="address">Address to convert.</param>
		/// <returns>Converted address.</returns>
		public static IPhysicalAddress ToInterface(this PhysicalAddress address)
		{
			return (address == null) ? null : new PhysicalAddressAdapter(address);
		}
	}
}

#endif