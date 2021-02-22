using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;

namespace Thinktecture.Net.NetworkInformation
{
   /// <summary>
   /// Statics of <see cref="PhysicalAddress"/>
   /// </summary>
   public interface IPhysicalAddressGlobals
   {
      /// <summary>
      /// Returns a new <see cref="IPhysicalAddress"/> instance with a zero length address. This field is read-only.
      /// </summary>
      IPhysicalAddress None { get; }

      /// <summary>
      /// Parses the specified <see cref="String"/> and stores its contents as the address bytes of the <see cref="IPhysicalAddress"/> returned by this method.
      /// </summary>
      /// <param name="address">A String containing the address that will be used to initialize the PhysicalAddress instance returned by this method.</param>
      /// <returns>A <see cref="IPhysicalAddress"/> instance with the specified address.</returns>
      IPhysicalAddress Parse(string? address);

#if NET5_0
      /// <summary>
      /// Parses the specified <see cref="ReadOnlySpan{T}"/> and stores its contents as the address bytes of the <see cref="IPhysicalAddress"/> returned by this method.
      /// </summary>
      /// <param name="address">A String containing the address that will be used to initialize the PhysicalAddress instance returned by this method.</param>
      /// <returns>A <see cref="IPhysicalAddress"/> instance with the specified address.</returns>
      IPhysicalAddress Parse(ReadOnlySpan<char> address);

      /// <summary>
      /// Tries to convert the string representation of a hardware address to a PhysicalAddress instance. A return value indicates whether the conversion succeeded.
      /// </summary>
      /// <param name="address">A string containing the address that will be used to initialize the PhysicalAddress instance returned by this method.</param>
      /// <param name="value">When this method returns, contains the PhysicalAddress instance equivalent of the address contained in address, if the conversion succeeded, or null if the conversion failed. If the address is null it contains None. This parameter is passed uninitialized; any value originally supplied in result will be overwritten.</param>
      /// <returns>true if address was converted successfully; otherwise, false.</returns>
      bool TryParse(string? address, [NotNullWhen(true)] out PhysicalAddress? value);

      /// <summary>
      /// Tries to convert the span representation of a hardware address to a PhysicalAddress instance. A return value indicates whether the conversion succeeded.
      /// </summary>
      /// <param name="address">A span containing the address that will be used to initialize the PhysicalAddress instance returned by this method.</param>
      /// <param name="value">When this method returns, contains the PhysicalAddress instance equivalent of the address contained in address, if the conversion succeeded, or null if the conversion failed. This parameter is passed uninitialized; any value originally supplied in result will be overwritten.</param>
      /// <returns>true if address was converted successfully; otherwise, false.</returns>
      bool TryParse(ReadOnlySpan<char> address, [NotNullWhen(true)] out PhysicalAddress? value);
#endif
   }
}
