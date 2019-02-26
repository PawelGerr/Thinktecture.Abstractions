#if NETCOREAPP2_2

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

		/// <summary>
		/// Initializes new instance of <see cref="UnixDomainSocketEndPointAdapter"/>.
		/// </summary>
		/// <param name="path">Path.</param>
		public UnixDomainSocketEndPointAdapter(string path)
			:this(new UnixDomainSocketEndPoint(path))
		{

		}

		/// <summary>
		/// Initializes new instance of <see cref="UnixDomainSocketEndPointAdapter"/>.
		/// </summary>
		public UnixDomainSocketEndPointAdapter([NotNull] UnixDomainSocketEndPoint implementation)
			: base(implementation)
		{
			Implementation = implementation;
		}
	}
}

#endif
