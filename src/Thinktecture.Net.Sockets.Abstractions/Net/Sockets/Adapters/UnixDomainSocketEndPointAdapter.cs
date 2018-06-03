#if NETCOREAPP2_1

using System.Net.Sockets;
using JetBrains.Annotations;
using Thinktecture.Net.Adapters;

namespace Thinktecture.Net.Sockets.Adapters
{
	/// <summary>
	/// Unix domain socket endpoint.
	/// </summary>
	public class UnixDomainSocketEndPointAdapter : EndPointAdapter, IUnixDomainSocketEndPoint
	{
		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		[NotNull]
		protected new UnixDomainSocketEndPoint Implementation { get; }

		/// <inheritdoc />
		[NotNull]
		UnixDomainSocketEndPoint IAbstraction<UnixDomainSocketEndPoint>.UnsafeConvert()
		{
			return Implementation;
		}

		/// <inheritdoc />
		public UnixDomainSocketEndPointAdapter([NotNull] UnixDomainSocketEndPoint implementation)
			: base(implementation)
		{
			Implementation = implementation;
		}
	}
}

#endif
