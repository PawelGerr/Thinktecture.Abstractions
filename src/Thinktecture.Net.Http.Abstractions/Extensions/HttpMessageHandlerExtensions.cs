using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using Thinktecture.Net.Http;
using Thinktecture.Net.Http.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extensions for <see cref="HttpMessageHandler"/>.
   /// </summary>
   public static class HttpMessageHandlerExtensions
   {
      /// <summary>
      /// Converts provided handler to <see cref="IHttpMessageHandler"/>.
      /// </summary>
      /// <param name="handler">Handler to convert.</param>
      /// <returns>Converted handler.</returns>
      [return: NotNullIfNotNull("handler")]
      public static IHttpMessageHandler? ToInterface(this HttpMessageHandler? handler)
      {
         return (handler == null) ? null : new HttpMessageHandlerAdapter(handler);
      }
   }
}
