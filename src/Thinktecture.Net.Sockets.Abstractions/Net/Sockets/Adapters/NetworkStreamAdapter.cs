using System;
using System.ComponentModel;
using System.Net.Sockets;
using Thinktecture.IO.Adapters;

namespace Thinktecture.Net.Sockets.Adapters
{
	/// <summary>
	/// Provides the underlying stream of data for network access.
	/// </summary>
	public class NetworkStreamAdapter : StreamAdapter, INetworkStream
	{
		private readonly NetworkStream _stream;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new NetworkStream UnsafeConvert()
		{
			return _stream;
		}

		/// <inheritdoc />
		public bool DataAvailable => _stream.DataAvailable;

		/// <summary>
		/// Creates a new instance of the NetworkStream class for the specified Socket.
		/// </summary>
		/// <param name="socket">The Socket that the NetworkStream will use to send and receive data.</param>
		public NetworkStreamAdapter(Socket socket)
			: this(new NetworkStream(socket))
		{
		}

		/// <summary>
		/// Initializes a new instance of the NetworkStream class for the specified Socket with the specified Socket ownership.
		/// </summary>
		/// <param name="socket">The Socket that the NetworkStream will use to send and receive data.</param>
		/// <param name="ownsSocket">Set to true to indicate that the NetworkStream will take ownership of the Socket; otherwise, false.</param>
		public NetworkStreamAdapter(Socket socket, bool ownsSocket)
			: this(new NetworkStream(socket, ownsSocket))
		{
		}

		/// <summary>
		/// Initializes new instance of <see cref="NetworkStreamAdapter"/>.
		/// </summary>
		/// <param name="stream">Stream to be used by the adapter.</param>
		public NetworkStreamAdapter(NetworkStream stream)
			: base(stream)
		{
			_stream = stream ?? throw new ArgumentNullException(nameof(stream));
		}
	}
}
