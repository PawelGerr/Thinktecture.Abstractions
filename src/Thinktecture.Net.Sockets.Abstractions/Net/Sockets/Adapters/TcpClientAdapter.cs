using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.Sockets.Adapters
{
	/// <summary>
	/// Provides client connections for TCP network services.
	/// </summary>
	public class TcpClientAdapter : AbstractionAdapter<TcpClient>, ITcpClient
	{
		/// <inheritdoc />
		public int Available => Implementation.Available;

		/// <inheritdoc />
		public ISocket Client
		{
			get => Implementation.Client.ToInterface();
			set => Implementation.Client = value.ToImplementation();
		}

		/// <inheritdoc />
		public bool Connected => Implementation.Connected;

		/// <inheritdoc />
		public bool ExclusiveAddressUse
		{
			get => Implementation.ExclusiveAddressUse;
			set => Implementation.ExclusiveAddressUse = value;
		}

		/// <inheritdoc />
		public ILingerOption LingerState
		{
			get => Implementation.LingerState.ToInterface();
			set => Implementation.LingerState = value.ToImplementation();
		}

		/// <inheritdoc />
		public bool NoDelay
		{
			get => Implementation.NoDelay;
			set => Implementation.NoDelay = value;
		}

		/// <inheritdoc />
		public int ReceiveBufferSize
		{
			get => Implementation.ReceiveBufferSize;
			set => Implementation.ReceiveBufferSize = value;
		}

		/// <inheritdoc />
		public int ReceiveTimeout
		{
			get => Implementation.ReceiveTimeout;
			set => Implementation.ReceiveTimeout = value;
		}

		/// <inheritdoc />
		public int SendBufferSize
		{
			get => Implementation.SendBufferSize;
			set => Implementation.SendBufferSize = value;
		}

		/// <inheritdoc />
		public int SendTimeout
		{
			get => Implementation.SendTimeout;
			set => Implementation.SendTimeout = value;
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
		public TcpClientAdapter([NotNull] TcpClient client)
			: base(client)
		{
		}

		/// <inheritdoc />
		public Task ConnectAsync(IPAddress address, int port)
		{
			return Implementation.ConnectAsync(address, port);
		}

		/// <inheritdoc />
		public Task ConnectAsync(IIPAddress address, int port)
		{
			return Implementation.ConnectAsync(address.ToImplementation(), port);
		}

		/// <inheritdoc />
		public Task ConnectAsync(IPAddress[] addresses, int port)
		{
			return Implementation.ConnectAsync(addresses, port);
		}

		/// <inheritdoc />
		public Task ConnectAsync(IIPAddress[] addresses, int port)
		{
			return Implementation.ConnectAsync(addresses.ToImplementation<IIPAddress, IPAddress>(), port);
		}

		/// <inheritdoc />
		public Task ConnectAsync(string host, int port)
		{
			return Implementation.ConnectAsync(host, port);
		}

		/// <inheritdoc />
		public INetworkStream GetStream()
		{
			return Implementation.GetStream().ToInterface();
		}

		/// <inheritdoc />
		public void Dispose()
		{
			((IDisposable)Implementation).Dispose();
		}
	}
}
