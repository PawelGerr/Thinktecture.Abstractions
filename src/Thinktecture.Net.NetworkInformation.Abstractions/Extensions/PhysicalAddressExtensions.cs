#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;
using JetBrains.Annotations;
using Thinktecture.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation.Adapters;

// ReSharper disable once CheckNamespace
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
		[CanBeNull]
		public static IPhysicalAddress ToInterface([CanBeNull] this PhysicalAddress address)
		{
			if (address == null)
				return null;

			if (ReferenceEquals(address, PhysicalAddress.None))
				return PhysicalAddressAdapter.None;

			return new PhysicalAddressAdapter(address);
		}
	}
}

#endif
