using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Thinktecture.Net.Sockets.Adapters
{
	/// <summary>
	/// Listens for connections from TCP network clients.
	/// </summary>
	public class TcpListenerAdapter : AbstractionAdapter, ITcpListener
	{
		private readonly TcpListener _listener;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new TcpListener UnsafeConvert()
		{
			return _listener;
		}

		/// <inheritdoc />
		public bool ExclusiveAddressUse
		{
			get { return _listener.ExclusiveAddressUse; }
			set { _listener.ExclusiveAddressUse = value; }
		}

		/// <inheritdoc />
		public IEndPoint LocalEndpoint => _listener.LocalEndpoint.ToInterface();

		/// <inheritdoc />
		public ISocket Server => _listener.Server.ToInterface();

		/// <summary>
		/// Initializes a new instance of the TcpListener class that listens for incoming connection attempts on the specified local IP address and port number.
		/// </summary>
		/// <param name="localaddr">An IPAddress that represents the local IP address.</param>
		/// <param name="port">The port on which to listen for incoming connection attempts.</param>
		public TcpListenerAdapter(IPAddress localaddr, int port)
			: this(new TcpListener(localaddr, port))
		{
		}

		/// <summary>
		/// Initializes a new instance of the TcpListener class that listens for incoming connection attempts on the specified local IP address and port number.
		/// </summary>
		/// <param name="localaddr">An IPAddress that represents the local IP address.</param>
		/// <param name="port">The port on which to listen for incoming connection attempts.</param>
		public TcpListenerAdapter(IIPAddress localaddr, int port)
			: this(new TcpListener(localaddr.ToImplementation(), port))
		{
		}

		/// <summary>
		/// Initializes a new instance of the TcpListener class with the specified local endpoint.
		/// </summary>
		/// <param name="localEP">An IPEndPoint that represents the local endpoint to which to bind the listener Socket.</param>
		// ReSharper disable once InconsistentNaming
		public TcpListenerAdapter(IPEndPoint localEP)
			: this(new TcpListener(localEP))
		{
		}

		/// <summary>
		/// Initializes a new instance of the TcpListener class with the specified local endpoint.
		/// </summary>
		/// <param name="localEP">An IPEndPoint that represents the local endpoint to which to bind the listener Socket.</param>
		// ReSharper disable once InconsistentNaming
		public TcpListenerAdapter(IIPEndPoint localEP)
			: this(new TcpListener(localEP.ToImplementation()))
		{
		}

		/// <summary>
		/// Initializes new instance of <see cref="TcpListenerAdapter"/>.
		/// </summary>
		/// <param name="listener">Listener to be used by the adapter.</param>
		public TcpListenerAdapter(TcpListener listener)
			: base(listener)
		{
			if (listener == null)
				throw new ArgumentNullException(nameof(listener));

			_listener = listener;
		}

		/// <inheritdoc />
		public async Task<ISocket> AcceptSocketAsync()
		{
			return (await _listener.AcceptSocketAsync()).ToInterface();
		}

		/// <inheritdoc />
		public async Task<ITcpClient> AcceptTcpClientAsync()
		{
			return (await _listener.AcceptTcpClientAsync()).ToInterface();
		}

		/// <inheritdoc />
		public bool Pending()
		{
			return _listener.Pending();
		}

		/// <inheritdoc />
		public void Start()
		{
			_listener.Start();
		}

		/// <inheritdoc />
		public void Start(int backlog)
		{
			_listener.Start(backlog);
		}

		/// <inheritdoc />
		public void Stop()
		{
			_listener.Stop();
		}
	}
}