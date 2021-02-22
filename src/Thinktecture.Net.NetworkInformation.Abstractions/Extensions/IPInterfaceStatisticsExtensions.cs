using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extensions for <see cref="IPInterfaceStatistics"/>.
   /// </summary>
   // ReSharper disable once InconsistentNaming
   public static class IPInterfaceStatisticsExtensions
   {
      /// <summary>
      /// Converts provided statistics to <see cref="IIPInterfaceStatistics"/>.
      /// </summary>
      /// <param name="statistics">Statistics to convert.</param>
      /// <returns>Converted statistics.</returns>
      [return: NotNullIfNotNull("statistics")]
      public static IIPInterfaceStatistics? ToInterface(this IPInterfaceStatistics? statistics)
      {
         return (statistics == null) ? null : new IPInterfaceStatisticsAdapter(statistics);
      }
   }
}
