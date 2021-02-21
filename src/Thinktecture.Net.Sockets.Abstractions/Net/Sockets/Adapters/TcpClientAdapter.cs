using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

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
      [DisallowNull]
      public ILingerOption? LingerState
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

      /// <summary>Initializes a new instance of the <see cref="TcpClientAdapter"></see> class and binds it to the specified local endpoint.</summary>
      /// <param name="localEp">The <see cref="T:System.Net.IPEndPoint"></see> to which you bind the TCP <see cref="T:System.Net.Sockets.Socket"></see>.</param>
      /// <exception cref="T:System.ArgumentNullException">The  <paramref name="localEp">localEP</paramref> parameter is null.</exception>
      public TcpClientAdapter(IPEndPoint localEp)
         : this(new TcpClient(localEp))
      {
      }

      /// <summary>Initializes a new instance of the <see cref="TcpClientAdapter"></see> class and connects to the specified port on the specified host.</summary>
      /// <param name="hostname">The DNS name of the remote host to which you intend to connect.</param>
      /// <param name="port">The port number of the remote host to which you intend to connect.</param>
      /// <exception cref="T:System.ArgumentNullException">The <paramref name="hostname">hostname</paramref> parameter is null.</exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="port">port</paramref> parameter is not between <see cref="System.Net.IPEndPoint.MinPort"></see> and <see cref="System.Net.IPEndPoint.MaxPort"></see>.</exception>
      /// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket.</exception>
      public TcpClientAdapter(string hostname, int port)
         : this(new TcpClient(hostname, port))
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

#if NET5_0
      /// <inheritdoc />
      public ValueTask ConnectAsync(IPAddress address, int port, CancellationToken cancellationToken)
      {
         return Implementation.ConnectAsync(address, port, cancellationToken);
      }

      /// <inheritdoc />
      public ValueTask ConnectAsync(IIPAddress address, int port, CancellationToken cancellationToken)
      {
         return Implementation.ConnectAsync(address.ToImplementation(), port, cancellationToken);
      }
#endif

      /// <inheritdoc />
      public Task ConnectAsync(IPAddress[] addresses, int port)
      {
         return Implementation.ConnectAsync(addresses, port);
      }

      /// <inheritdoc />
      public Task ConnectAsync(IIPAddress[] addresses, int port)
      {
         return Implementation.ConnectAsync(addresses.ToNotNullImplementation<IIPAddress, IPAddress>(), port);
      }

#if NET5_0
      /// <inheritdoc />
      public ValueTask ConnectAsync(IPAddress[] addresses, int port, CancellationToken cancellationToken)
      {
         return Implementation.ConnectAsync(addresses, port, cancellationToken);
      }

      /// <inheritdoc />
      public ValueTask ConnectAsync(IIPAddress[] addresses, int port, CancellationToken cancellationToken)
      {
         return Implementation.ConnectAsync(addresses.ToNotNullImplementation<IIPAddress, IPAddress>(), port, cancellationToken);
      }
#endif

      /// <inheritdoc />
      public Task ConnectAsync(string host, int port)
      {
         return Implementation.ConnectAsync(host, port);
      }

#if NET5_0
      /// <inheritdoc />
      public ValueTask ConnectAsync(string host, int port, CancellationToken cancellationToken)
      {
         return Implementation.ConnectAsync(host, port, cancellationToken);
      }
#endif

      /// <inheritdoc />
      public INetworkStream GetStream()
      {
         return Implementation.GetStream().ToInterface();
      }

      /// <inheritdoc />
      public void Connect(string hostname, int port)
      {
         Implementation.Connect(hostname, port);
      }

      /// <inheritdoc />
      public void Connect(IPAddress address, int port)
      {
         Implementation.Connect(address, port);
      }

      /// <inheritdoc />
      public void Connect(IIPAddress address, int port)
      {
         Implementation.Connect(address.ToImplementation(), port);
      }

      /// <inheritdoc />
      public void Connect(IPEndPoint remoteEp)
      {
         Implementation.Connect(remoteEp);
      }

      /// <inheritdoc />
      public void Connect(IIPEndPoint remoteEp)
      {
         Implementation.Connect(remoteEp.ToImplementation());
      }

      /// <inheritdoc />
      public void Connect(IPAddress[] ipAddresses, int port)
      {
         Implementation.Connect(ipAddresses, port);
      }

      /// <inheritdoc />
      public void Connect(IIPAddress[] ipAddresses, int port)
      {
         Implementation.Connect(ipAddresses.ToNotNullImplementation<IIPAddress, IPAddress>(), port);
      }

      /// <inheritdoc />
      public void Close()
      {
         Implementation.Close();
      }

      /// <inheritdoc />
      public void Dispose()
      {
         ((IDisposable)Implementation).Dispose();
      }
   }
}
