using System.Diagnostics.CodeAnalysis;
using System.Net.Http;

namespace Thinktecture.Net.Http
{
   /// <summary>A type for HTTP handlers that delegate the processing of HTTP response messages to another handler, called the inner handler.</summary>
   // ReSharper disable once PossibleInterfaceMemberAmbiguity
   public interface IDelegatingHandler : IHttpMessageHandler, IAbstraction<DelegatingHandler>
   {
      /// <summary>Gets or sets the inner handler which processes the HTTP response messages.</summary>
      /// <returns>Returns <see cref="T:System.Net.Http.HttpMessageHandler" />.The inner handler for HTTP response messages.</returns>
      [DisallowNull]
      IHttpMessageHandler? InnerHandler { get; set; }
   }
}
