using System.Net;
using System.Net.Http;
using JetBrains.Annotations;

namespace Thinktecture.Net.Http
{
	/// <summary>The default message handler used by <see cref="T:System.Net.Http.HttpClient" />.  </summary>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface IHttpClientHandler : IHttpMessageHandler, IAbstraction<HttpClientHandler>
	{
		/// <summary>Gets a value that indicates whether the handler supports automatic response content decompression.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the if the handler supports automatic response content decompression; otherwise false. The default value is true.</returns>
		bool SupportsAutomaticDecompression { get; }

		/// <summary>Gets a value that indicates whether the handler supports proxy settings.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the if the handler supports proxy settings; otherwise false. The default value is true.</returns>
		bool SupportsProxy { get; }

		/// <summary>Gets a value that indicates whether the handler supports configuration settings for the <see cref="P:System.Net.Http.HttpClientHandler.AllowAutoRedirect" /> and <see cref="P:System.Net.Http.HttpClientHandler.MaxAutomaticRedirections" /> properties.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the if the handler supports configuration settings for the <see cref="P:System.Net.Http.HttpClientHandler.AllowAutoRedirect" /> and <see cref="P:System.Net.Http.HttpClientHandler.MaxAutomaticRedirections" /> properties; otherwise false. The default value is true.</returns>
		bool SupportsRedirectConfiguration { get; }

		/// <summary>Gets or sets a value that indicates whether the handler uses the  <see cref="P:System.Net.Http.HttpClientHandler.CookieContainer" /> property  to store server cookies and uses these cookies when sending requests.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the if the handler supports uses the  <see cref="P:System.Net.Http.HttpClientHandler.CookieContainer" /> property  to store server cookies and uses these cookies when sending requests; otherwise false. The default value is true.</returns>
		bool UseCookies { get; set; }

		/// <summary>Gets or sets the cookie container used to store server cookies by the handler.</summary>
		/// <returns>Returns <see cref="T:System.Net.CookieContainer" />.The cookie container used to store server cookies by the handler.</returns>
		[NotNull]
		ICookieContainer CookieContainer { get; set; }

		/// <summary>Gets or sets a value that indicates if the certificate is automatically picked from the certificate store or if the caller is allowed to pass in a specific client certificate.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.ClientCertificateOption" />.The collection of security certificates associated with this handler.</returns>
		ClientCertificateOption ClientCertificateOptions { get; set; }

		/// <summary>Gets or sets the type of decompression method used by the handler for automatic decompression of the HTTP content response.</summary>
		/// <returns>Returns <see cref="T:System.Net.DecompressionMethods" />.The automatic decompression method used by the handler. The default value is <see cref="F:System.Net.DecompressionMethods.None" />.</returns>
		DecompressionMethods AutomaticDecompression { get; set; }

		/// <summary>Gets or sets a value that indicates whether the handler uses a proxy for requests. </summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the handler should use a proxy for requests; otherwise false. The default value is true.</returns>
		bool UseProxy { get; set; }

		/// <summary>Gets or sets proxy information used by the handler.</summary>
		/// <returns>Returns <see cref="T:System.Net.IWebProxy" />.The proxy information used by the handler. The default value is null.</returns>
		[CanBeNull]
		IWebProxy Proxy { get; set; }

		/// <summary>Gets or sets a value that indicates whether the handler sends an Authorization header with the request.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true for the handler to send an HTTP Authorization header with requests after authentication has taken place; otherwise, false. The default is false.</returns>
		bool PreAuthenticate { get; set; }

		/// <summary>Gets or sets a value that controls whether default credentials are sent with requests by the handler.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the default credentials are used; otherwise false. The default value is false.</returns>
		bool UseDefaultCredentials { get; set; }

		/// <summary>Gets or sets authentication information used by this handler.</summary>
		/// <returns>Returns <see cref="T:System.Net.ICredentials" />.The authentication credentials associated with the handler. The default is null.</returns>
		[CanBeNull]
		ICredentials Credentials { get; set; }

		/// <summary>Gets or sets a value that indicates whether the handler should follow redirection responses.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the if the handler should follow redirection responses; otherwise false. The default value is true.</returns>
		bool AllowAutoRedirect { get; set; }

		/// <summary>Gets or sets the maximum number of redirects that the handler follows.</summary>
		/// <returns>Returns <see cref="T:System.Int32" />.The maximum number of redirection responses that the handler follows. The default value is 50.</returns>
		int MaxAutomaticRedirections { get; set; }

		/// <summary>Gets or sets the maximum request content buffer size used by the handler.</summary>
		/// <returns>Returns <see cref="T:System.Int32" />.The maximum request content buffer size in bytes. The default value is 2 gigabytes.</returns>
		long MaxRequestContentBufferSize { get; set; }
	}
}
