using System;
using System.ComponentModel;
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
	}
}
