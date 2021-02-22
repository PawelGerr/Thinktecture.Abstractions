using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.NetworkInformation.Adapters
{
   /// <summary>
   /// Provides the Media Access Control (MAC) address for a network interface (adapter).
   /// </summary>
   public class PhysicalAddressAdapter : AbstractionAdapter<PhysicalAddress>, IPhysicalAddress
   {
      /// <summary>
      /// Returns a new <see cref="IPhysicalAddress"/> instance with a zero length address. This field is read-only.
      /// </summary>
      public static readonly IPhysicalAddress None = new PhysicalAddressAdapter(PhysicalAddress.None);

      /// <summary>
      /// Parses the specified <see cref="String"/> and stores its contents as the address bytes of the <see cref="IPhysicalAddress"/> returned by this method.
      /// </summary>
      /// <param name="address">A String containing the address that will be used to initialize the PhysicalAddress instance returned by this method.</param>
      /// <returns>A <see cref="IPhysicalAddress"/> instance with the specified address.</returns>
      public static IPhysicalAddress Parse(string? address)
      {
         return PhysicalAddress.Parse(address).ToInterface();
      }

#if NET5_0
      /// <summary>
      /// Parses the specified <see cref="ReadOnlySpan{T}"/> and stores its contents as the address bytes of the <see cref="IPhysicalAddress"/> returned by this method.
      /// </summary>
      /// <param name="address">A String containing the address that will be used to initialize the PhysicalAddress instance returned by this method.</param>
      /// <returns>A <see cref="IPhysicalAddress"/> instance with the specified address.</returns>
      public static IPhysicalAddress Parse(ReadOnlySpan<char> address)
      {
         return PhysicalAddress.Parse(address).ToInterface();
      }

      /// <summary>
      /// Tries to convert the string representation of a hardware address to a PhysicalAddress instance. A return value indicates whether the conversion succeeded.
      /// </summary>
      /// <param name="address">A string containing the address that will be used to initialize the PhysicalAddress instance returned by this method.</param>
      /// <param name="value">When this method returns, contains the PhysicalAddress instance equivalent of the address contained in address, if the conversion succeeded, or null if the conversion failed. If the address is null it contains None. This parameter is passed uninitialized; any value originally supplied in result will be overwritten.</param>
      /// <returns>true if address was converted successfully; otherwise, false.</returns>
      public static bool TryParse(string? address, [NotNullWhen(true)] out PhysicalAddress? value)
      {
         return PhysicalAddress.TryParse(address, out value);
      }

      /// <summary>
      /// Tries to convert the span representation of a hardware address to a PhysicalAddress instance. A return value indicates whether the conversion succeeded.
      /// </summary>
      /// <param name="address">A span containing the address that will be used to initialize the PhysicalAddress instance returned by this method.</param>
      /// <param name="value">When this method returns, contains the PhysicalAddress instance equivalent of the address contained in address, if the conversion succeeded, or null if the conversion failed. This parameter is passed uninitialized; any value originally supplied in result will be overwritten.</param>
      /// <returns>true if address was converted successfully; otherwise, false.</returns>
      public static bool TryParse(ReadOnlySpan<char> address, [NotNullWhen(true)] out PhysicalAddress? value)
      {
         return PhysicalAddress.TryParse(address, out value);
      }
#endif

      /// <summary>
      /// Initializes a new instance of the <see cref="PhysicalAddressAdapter"/> class.
      /// </summary>
      /// <param name="address">A Byte array containing the address.</param>
      public PhysicalAddressAdapter(byte[] address)
         : this(new PhysicalAddress(address))
      {
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="PhysicalAddressAdapter"/> class.
      /// </summary>
      /// <param name="address">Address to be used by the adapter.</param>
      public PhysicalAddressAdapter(PhysicalAddress address)
         : base(address)
      {
      }

      /// <inheritdoc />
      public byte[] GetAddressBytes()
      {
         return Implementation.GetAddressBytes();
      }
   }
}
