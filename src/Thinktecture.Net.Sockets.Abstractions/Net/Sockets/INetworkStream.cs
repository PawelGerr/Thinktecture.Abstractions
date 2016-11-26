using System.ComponentModel;
using System.Net.Sockets;
using Thinktecture.IO;

namespace Thinktecture.Net.Sockets
{
	/// <summary>
	/// Provides the underlying stream of data for network access.
	/// </summary>
	public interface INetworkStream : IStream
	{
		/// <summary>
		/// Gets inner instance of <see cref="NetworkStream"/>.
		/// It is not intended to be used directly. Use <see cref="NetworkStreamExtensions.ToImplementation"/> instead.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		new NetworkStream UnsafeConvert();

		/// <summary>
		/// Gets a value that indicates whether data is available on the NetworkStream to be read.
		/// </summary>
		bool DataAvailable { get; }
	}
}