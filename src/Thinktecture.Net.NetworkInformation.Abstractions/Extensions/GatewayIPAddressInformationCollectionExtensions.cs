using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extensions for <see cref="GatewayIPAddressInformationCollection"/>.
   /// </summary>
   // ReSharper disable once InconsistentNaming
   public static class GatewayIPAddressInformationCollectionExtensions
   {
      /// <summary>
      /// Converts provided collection to <see cref="IGatewayIPAddressInformationCollection"/>.
      /// </summary>
      /// <param name="collection">Collection to convert.</param>
      /// <returns>Converted collection.</returns>
      [return: NotNullIfNotNull("collection")]
      public static IGatewayIPAddressInformationCollection? ToInterface(this GatewayIPAddressInformationCollection? collection)
      {
         return (collection == null) ? null : new GatewayIPAddressInformationCollectionAdapter(collection);
      }
   }
}
