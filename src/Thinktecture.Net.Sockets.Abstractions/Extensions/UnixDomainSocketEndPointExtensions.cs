using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;
using Thinktecture.Net.Sockets;
using Thinktecture.Net.Sockets.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extensions for <see cref="UnixDomainSocketEndPoint"/>.
   /// </summary>
   public static class UnixDomainSocketEndPointExtensions
   {
      /// <summary>
      /// Converts provided endpoint to <see cref="IUnixDomainSocketEndPoint"/>.
      /// </summary>
      /// <param name="endpoint">Endpoint to convert.</param>
      /// <returns>Converted endpoint.</returns>
      [return: NotNullIfNotNull("abstraction")]
      public static IUnixDomainSocketEndPoint? ToInterface(this UnixDomainSocketEndPoint? endpoint)
      {
         return (endpoint == null) ? null : new UnixDomainSocketEndPointAdapter(endpoint);
      }
   }
}
