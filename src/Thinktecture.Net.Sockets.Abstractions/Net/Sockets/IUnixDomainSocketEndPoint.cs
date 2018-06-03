#if NETCOREAPP2_1

using System.Net.Sockets;

namespace Thinktecture.Net.Sockets
{
	/// <summary>
	/// Unix domain socket endpoint.
	/// </summary>
	public interface IUnixDomainSocketEndPoint : IEndPoint, IAbstraction<UnixDomainSocketEndPoint>
	{

	}
}

#endif
