using System;
using System.Net.NetworkInformation;

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
      byte[] GetAddressBytes();
   }
}
