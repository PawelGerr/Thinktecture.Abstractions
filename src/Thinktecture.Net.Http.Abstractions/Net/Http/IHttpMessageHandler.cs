using System;
using System.Net.Http;

namespace Thinktecture.Net.Http
{
	/// <summary>A base type for HTTP message handlers.</summary>
	public interface IHttpMessageHandler : IAbstraction<HttpMessageHandler>, IDisposable
	{
	}
}
