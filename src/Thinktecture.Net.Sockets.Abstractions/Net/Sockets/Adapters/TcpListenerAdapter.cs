using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute
// ReSharper disable PossibleNullReferenceException

namespace Thinktecture.Net.Sockets.Adapters
{
	/// <summary>
	/// Listens for connections from TCP network clients.
	/// </summary>
	public class TcpListenerAdapter : AbstractionAdapter<TcpListener>, ITcpListener
	{
		/// <inheritdoc />
		public bool ExclusiveAddressUse
		{
			get => Implementation.ExclusiveAddressUse;
			set => Implementation.ExclusiveAddressUse = value;
		}

		/// <inheritdoc />
		public IEndPoint LocalEndpoint => Implementation.LocalEndpoint.ToInterface();

		/// <inheritdoc />
		public ISocket Server => Implementation.Server.ToInterface();

		/// <summary>
		/// Initializes a new instance of the TcpListener class that listens for incoming connection attempts on the specified local IP address and port number.
		/// </summary>
		/// <param name="localaddr">An IPAddress that represents the local IP address.</param>
		/// <param name="port">The port on which to listen for incoming connection attempts.</param>
		public TcpListenerAdapter([NotNull] IPAddress localaddr, int port)
			: this(new TcpListener(localaddr, port))
		{
		}

		/// <summary>
		/// Initializes a new instance of the TcpListener class that listens for incoming connection attempts on the specified local IP address and port number.
		/// </summary>
		/// <param name="localaddr">An IPAddress that represents the local IP address.</param>
		/// <param name="port">The port on which to listen for incoming connection attempts.</param>
		public TcpListenerAdapter([NotNull] IIPAddress localaddr, int port)
			: this(localaddr.ToImplementation(), port)
		{
		}

		/// <summary>
		/// Initializes a new instance of the TcpListener class with the specified local endpoint.
		/// </summary>
		/// <param name="localEP">An IPEndPoint that represents the local endpoint to which to bind the listener Socket.</param>
		// ReSharper disable once InconsistentNaming
		public TcpListenerAdapter([NotNull] IPEndPoint localEP)
			: this(new TcpListener(localEP))
		{
		}

		/// <summary>
		/// Initializes a new instance of the TcpListener class with the specified local endpoint.
		/// </summary>
		/// <param name="localEP">An IPEndPoint that represents the local endpoint to which to bind the listener Socket.</param>
		// ReSharper disable once InconsistentNaming
		public TcpListenerAdapter([NotNull] IIPEndPoint localEP)
			: this(localEP.ToImplementation())
		{
		}

		/// <summary>
		/// Initializes new instance of <see cref="TcpListenerAdapter"/>.
		/// </summary>
		/// <param name="listener">Listener to be used by the adapter.</param>
		public TcpListenerAdapter([NotNull] TcpListener listener)
			: base(listener)
		{
		}

		/// <inheritdoc />
		public async Task<ISocket> AcceptSocketAsync()
		{
			var socket = await Implementation.AcceptSocketAsync().ConfigureAwait(false);
			return socket.ToInterface();
		}

		/// <inheritdoc />
		public async Task<ITcpClient> AcceptTcpClientAsync()
		{
			var socket = await Implementation.AcceptTcpClientAsync().ConfigureAwait(false);
			return socket.ToInterface();
		}

		/// <inheritdoc />
		public bool Pending()
		{
			return Implementation.Pending();
		}

		/// <inheritdoc />
		public void Start()
		{
			Implementation.Start();
		}

		/// <inheritdoc />
		public void Start(int backlog)
		{
			Implementation.Start(backlog);
		}

		/// <inheritdoc />
		public void Stop()
		{
			Implementation.Stop();
		}
	}
}
