using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extensions for <see cref="NetworkInterface"/>.
   /// </summary>
   // ReSharper disable once InconsistentNaming
   public static class NetworkInterfaceExtensions
   {
      /// <summary>
      /// Converts provided network interface to <see cref="INetworkInterface"/>.
      /// </summary>
      /// <param name="networkInterface">Network interface to convert.</param>
      /// <returns>Converted network interface.</returns>
      [return: NotNullIfNotNull("networkInterface")]
      public static INetworkInterface? ToInterface(this NetworkInterface? networkInterface)
      {
         return (networkInterface == null) ? null : new NetworkInterfaceAdapter(networkInterface);
      }
   }
}
