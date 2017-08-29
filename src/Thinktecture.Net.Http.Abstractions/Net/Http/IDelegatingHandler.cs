using System.Net.Http;
using JetBrains.Annotations;

namespace Thinktecture.Net.Http
{
	/// <summary>A type for HTTP handlers that delegate the processing of HTTP response messages to another handler, called the inner handler.</summary>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface IDelegatingHandler : IHttpMessageHandler, IAbstraction<DelegatingHandler>
	{
		/// <summary>Gets or sets the inner handler which processes the HTTP response messages.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.HttpMessageHandler" />.The inner handler for HTTP response messages.</returns>
		[NotNull]
		IHttpMessageHandler InnerHandler { get; set; }
	}
}
