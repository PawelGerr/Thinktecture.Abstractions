using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Thinktecture.Net.Sockets.Adapters
{
	/// <summary>
	/// Provides client connections for TCP network services.
	/// </summary>
	public class TcpClientAdapter : AbstractionAdapter, ITcpClient
	{
		private readonly TcpClient _client;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new TcpClient UnsafeConvert()
		{
			return _client;
		}

		/// <inheritdoc />
		public int Available => _client.Available;

		/// <inheritdoc />
		public ISocket Client
		{
			get => _client.Client.ToInterface();
			set => _client.Client = value.ToImplementation();
		}

		/// <inheritdoc />
		public bool Connected => _client.Connected;

		/// <inheritdoc />
		public bool ExclusiveAddressUse
		{
			get => _client.ExclusiveAddressUse;
			set => _client.ExclusiveAddressUse = value;
		}

		/// <inheritdoc />
		public ILingerOption LingerState
		{
			get => _client.LingerState.ToInterface();
			set => _client.LingerState = value.ToImplementation();
		}

		/// <inheritdoc />
		public bool NoDelay
		{
			get => _client.NoDelay;
			set => _client.NoDelay = value;
		}

		/// <inheritdoc />
		public int ReceiveBufferSize
		{
			get => _client.ReceiveBufferSize;
			set => _client.ReceiveBufferSize = value;
		}

		/// <inheritdoc />
		public int ReceiveTimeout
		{
			get => _client.ReceiveTimeout;
			set => _client.ReceiveTimeout = value;
		}

		/// <inheritdoc />
		public int SendBufferSize
		{
			get => _client.SendBufferSize;
			set => _client.SendBufferSize = value;
		}

		/// <inheritdoc />
		public int SendTimeout
		{
			get => _client.SendTimeout;
			set => _client.SendTimeout = value;
		}

		/// <summary>
		/// Initializes a new instance of the TcpClient class.
		/// </summary>
		public TcpClientAdapter()
			: this(new TcpClient())
		{
		}

		/// <summary>
		/// Initializes a new instance of the TcpClient class with the specified family.
		/// </summary>
		/// <param name="family">The AddressFamily of the IP protocol.</param>
		public TcpClientAdapter(AddressFamily family)
			: this(new TcpClient(family))
		{
		}

		/// <summary>
		/// Initializes new instance of <see cref="TcpClientAdapter"/>.
		/// </summary>
		/// <param name="client">Client to be used by the adapter.</param>
		public TcpClientAdapter(TcpClient client)
			: base(client)
		{
			_client = client ?? throw new ArgumentNullException(nameof(client));
		}

		/// <inheritdoc />
		public Task ConnectAsync(IPAddress address, int port)
		{
			return _client.ConnectAsync(address, port);
		}

		/// <inheritdoc />
		public Task ConnectAsync(IIPAddress address, int port)
		{
			return _client.ConnectAsync(address.ToImplementation(), port);
		}

		/// <inheritdoc />
		public Task ConnectAsync(IPAddress[] addresses, int port)
		{
			return _client.ConnectAsync(addresses, port);
		}

		/// <inheritdoc />
		public Task ConnectAsync(IIPAddress[] addresses, int port)
		{
			return _client.ConnectAsync(addresses.ToImplementation<IIPAddress, IPAddress>(), port);
		}

		/// <inheritdoc />
		public Task ConnectAsync(string host, int port)
		{
			return _client.ConnectAsync(host, port);
		}

		/// <inheritdoc />
		public INetworkStream GetStream()
		{
			return _client.GetStream().ToInterface();
		}

		/// <inheritdoc />
		public void Dispose()
		{
			((IDisposable) _client).Dispose();
		}
	}
}