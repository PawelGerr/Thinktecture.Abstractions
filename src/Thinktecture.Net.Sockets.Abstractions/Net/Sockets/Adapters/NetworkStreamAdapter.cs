using System;
using System.ComponentModel;
using System.IO;
using System.Net.Sockets;
using JetBrains.Annotations;
using Thinktecture.IO.Adapters;

namespace Thinktecture.Net.Sockets.Adapters
{
	/// <summary>
	/// Provides the underlying stream of data for network access.
	/// </summary>
	public class NetworkStreamAdapter : StreamAdapter, INetworkStream
	{
		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		[NotNull]
		protected new NetworkStream Implementation { get; }

		/// <inheritdoc />
		[NotNull, EditorBrowsable(EditorBrowsableState.Never)]
		public new NetworkStream UnsafeConvert()
		{
			return Implementation;
		}

		/// <inheritdoc />
		public bool DataAvailable => Implementation.DataAvailable;

		/// <summary>
		/// Creates a new instance of the NetworkStream class for the specified Socket.
		/// </summary>
		/// <param name="socket">The Socket that the NetworkStream will use to send and receive data.</param>
		public NetworkStreamAdapter([NotNull] Socket socket)
			: this(new NetworkStream(socket))
		{
		}

#if NET46 ||NETSTANDARD2_0
		/// <summary>Creates a new instance of the <see cref="T:System.Net.Sockets.NetworkStream"></see> class for the specified <see cref="T:System.Net.Sockets.Socket"></see> with the specified access rights.</summary>
		/// <param name="socket">The <see cref="T:System.Net.Sockets.Socket"></see> that the <see cref="T:System.Net.Sockets.NetworkStream"></see> will use to send and receive data.</param>
		/// <param name="access">A bitwise combination of the <see cref="T:System.IO.FileAccess"></see> values that specify the type of access given to the <see cref="T:System.Net.Sockets.NetworkStream"></see> over the provided <see cref="T:System.Net.Sockets.Socket"></see>.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="socket">socket</paramref> parameter is null.</exception>
		/// <exception cref="T:System.IO.IOException">The <paramref name="socket">socket</paramref> parameter is not connected.
		/// -or-
		/// the <see cref="System.Net.Sockets.Socket.SocketType"></see> property of the <paramref name="socket">socket</paramref> parameter is not <see cref="System.Net.Sockets.SocketType.Stream"></see>.
		/// -or-
		/// the <paramref name="socket">socket</paramref> parameter is in a nonblocking state.</exception>
		public NetworkStreamAdapter([NotNull] Socket socket, FileAccess access)
			: this(new NetworkStream(socket, access))
		{
		}

		/// <summary>Creates a new instance of the <see cref="T:System.Net.Sockets.NetworkStream"></see> class for the specified <see cref="T:System.Net.Sockets.Socket"></see> with the specified access rights.</summary>
		/// <param name="socket">The <see cref="T:System.Net.Sockets.Socket"></see> that the <see cref="T:System.Net.Sockets.NetworkStream"></see> will use to send and receive data.</param>
		/// <param name="access">A bitwise combination of the <see cref="T:System.IO.FileAccess"></see> values that specify the type of access given to the <see cref="T:System.Net.Sockets.NetworkStream"></see> over the provided <see cref="T:System.Net.Sockets.Socket"></see>.</param>
		/// <param name="ownsSocket">Set to true to indicate that the NetworkStream will take ownership of the Socket; otherwise, false.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="socket">socket</paramref> parameter is null.</exception>
		/// <exception cref="T:System.IO.IOException">The <paramref name="socket">socket</paramref> parameter is not connected.
		/// -or-
		/// the <see cref="System.Net.Sockets.Socket.SocketType"></see> property of the <paramref name="socket">socket</paramref> parameter is not <see cref="System.Net.Sockets.SocketType.Stream"></see>.
		/// -or-
		/// the <paramref name="socket">socket</paramref> parameter is in a nonblocking state.</exception>
		public NetworkStreamAdapter([NotNull] Socket socket, FileAccess access, bool ownsSocket)
			: this(new NetworkStream(socket, access, ownsSocket))
		{
		}
#endif

		/// <summary>
		/// Initializes a new instance of the NetworkStream class for the specified Socket with the specified Socket ownership.
		/// </summary>
		/// <param name="socket">The Socket that the NetworkStream will use to send and receive data.</param>
		/// <param name="ownsSocket">Set to true to indicate that the NetworkStream will take ownership of the Socket; otherwise, false.</param>
		public NetworkStreamAdapter([NotNull] Socket socket, bool ownsSocket)
			: this(new NetworkStream(socket, ownsSocket))
		{
		}

		/// <summary>
		/// Initializes new instance of <see cref="NetworkStreamAdapter"/>.
		/// </summary>
		/// <param name="stream">Stream to be used by the adapter.</param>
		public NetworkStreamAdapter([NotNull] NetworkStream stream)
			: base(stream)
		{
			Implementation = stream ?? throw new ArgumentNullException(nameof(stream));
		}

#if NET46 || NETSTANDARD2_0
		/// <inheritdoc />
		public void Close(int timeout)
		{
			Implementation.Close(timeout);
		}
#endif
	}
}
