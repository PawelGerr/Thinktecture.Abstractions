#if NETSTANDARD1_3 || NET45 || NET46

using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;

namespace Thinktecture.Net.Adapters
{
	/// <summary>Identifies a network address. This is an abstract class.</summary>
	public class EndPointAdapter : AbstractionAdapter, IEndPoint
	{
		private readonly EndPoint _endpoint;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new EndPoint UnsafeConvert()
		{
			return _endpoint;
		}

		/// <inheritdoc />
		public AddressFamily AddressFamily => _endpoint.AddressFamily;

		/// <inheritdoc />
		public IEndPoint Create(SocketAddress socketAddress)
		{
			return _endpoint.Create(socketAddress).ToInterface();
		}

		/// <inheritdoc />
		public IEndPoint Create(ISocketAddress socketAddress)
		{
			return _endpoint.Create(socketAddress.ToImplementation()).ToInterface();
		}

		/// <inheritdoc />
		public ISocketAddress Serialize()
		{
			return _endpoint.Serialize().ToInterface();
		}

		/// <summary>
		/// Initializes new instance of <see cref="EndPointAdapter"/>.
		/// </summary>
		/// <param name="endpoint">Endpoint to be used by the adapter.</param>
		public EndPointAdapter(EndPoint endpoint)
			: base(endpoint)
		{
			if (endpoint == null)
				throw new ArgumentNullException(nameof(endpoint));

			_endpoint = endpoint;
		}
	}
}

#endif