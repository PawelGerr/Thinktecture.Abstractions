#if NETSTANDARD1_3 || NET45

using System;
using System.Net;
using System.Net.Sockets;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.Adapters
{
	/// <summary>Identifies a network address. This is an abstract class.</summary>
	public class EndPointAdapter : AbstractionAdapter<EndPoint>, IEndPoint
	{
		/// <inheritdoc />
		public AddressFamily AddressFamily => Implementation.AddressFamily;

		/// <inheritdoc />
		public IEndPoint Create(SocketAddress socketAddress)
		{
			return Implementation.Create(socketAddress).ToInterface();
		}

		/// <inheritdoc />
		public IEndPoint Create(ISocketAddress socketAddress)
		{
			return Implementation.Create(socketAddress.ToImplementation()).ToInterface();
		}

		/// <inheritdoc />
		public ISocketAddress Serialize()
		{
			return Implementation.Serialize().ToInterface();
		}

		/// <summary>
		/// Initializes new instance of <see cref="EndPointAdapter"/>.
		/// </summary>
		/// <param name="endpoint">Endpoint to be used by the adapter.</param>
		public EndPointAdapter([NotNull] EndPoint endpoint)
			: base(endpoint)
		{
		}
	}
}

#endif
