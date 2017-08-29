#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;
using JetBrains.Annotations;

namespace Thinktecture.Net.NetworkInformation
{
	/// <summary>
	/// Provides the Media Access Control (MAC) address for a network interface (adapter).
	/// </summary>
	public interface IPhysicalAddress : IAbstraction<PhysicalAddress>
	{
		/// <summary>
		/// Returns the address of the current instance.
		/// </summary>
		/// <returns>A Byte array containing the address.</returns>
		[NotNull]
		byte[] GetAddressBytes();
	}
}

#endif
