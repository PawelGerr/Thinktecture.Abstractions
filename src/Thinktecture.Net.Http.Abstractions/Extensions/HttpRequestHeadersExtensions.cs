using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using Thinktecture.Net.Http.Headers;
using Thinktecture.Net.Http.Headers.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extensions for <see cref="HttpRequestHeaders"/>.
   /// </summary>
   public static class HttpRequestHeadersExtensions
   {
      /// <summary>
      /// Converts provided headers to <see cref="IHttpRequestHeaders"/>.
      /// </summary>
      /// <param name="headers">Headers to convert.</param>
      /// <returns>Converted headers.</returns>
      [return: NotNullIfNotNull("headers")]
      public static IHttpRequestHeaders? ToInterface(this HttpRequestHeaders? headers)
      {
         return (headers == null) ? null : new HttpRequestHeadersAdapter(headers);
      }

      /// <summary>
      /// Converts provided <see cref="IHttpRequestHeaders"/> info to <see cref="HttpRequestHeaders"/>.
      /// </summary>
      /// <param name="abstraction">Instance of <see cref="IHttpRequestHeaders"/> to convert.</param>
      /// <returns>An instance of <see cref="HttpRequestHeaders"/>.</returns>
      [return: NotNullIfNotNull("abstraction")]
      public static HttpRequestHeaders? ToImplementation(this IHttpRequestHeaders? abstraction)
      {
         return ((IAbstraction<HttpRequestHeaders>?)abstraction)?.UnsafeConvert();
      }
   }
}
