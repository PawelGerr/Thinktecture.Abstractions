using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.NetworkInformation.Adapters
{
   /// <summary>
   /// Statics of <see cref="PhysicalAddress"/>
   /// </summary>
   public class PhysicalAddressGlobals : IPhysicalAddressGlobals
   {
      /// <inheritdoc />
      public IPhysicalAddress None => PhysicalAddressAdapter.None;

      /// <inheritdoc />
      public IPhysicalAddress Parse(string? address)
      {
         return PhysicalAddressAdapter.Parse(address);
      }

#if NET5_0
      /// <inheritdoc />
      public IPhysicalAddress Parse(ReadOnlySpan<char> address)
      {
         return PhysicalAddressAdapter.Parse(address);
      }

      /// <inheritdoc />
      public bool TryParse(string? address, [NotNullWhen(true)] out PhysicalAddress? value)
      {
         return PhysicalAddress.TryParse(address, out value);
      }

      /// <inheritdoc />
      public bool TryParse(ReadOnlySpan<char> address, [NotNullWhen(true)] out PhysicalAddress? value)
      {
         return PhysicalAddress.TryParse(address, out value);
      }
#endif
   }
}
