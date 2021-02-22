using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extensions for <see cref="UnicastIPAddressInformationCollection"/>.
   /// </summary>
   // ReSharper disable once InconsistentNaming
   public static class UnicastIPAddressInformationCollectionExtensions
   {
      /// <summary>
      /// Converts provided collection to <see cref="IUnicastIPAddressInformationCollection"/>.
      /// </summary>
      /// <param name="collection">Collection to convert.</param>
      /// <returns>Converted collection.</returns>
      [return: NotNullIfNotNull("collection")]
      public static IUnicastIPAddressInformationCollection? ToInterface(this UnicastIPAddressInformationCollection? collection)
      {
         return (collection == null) ? null : new UnicastIpAddressInformationCollectionAdapter(collection);
      }
   }
}
