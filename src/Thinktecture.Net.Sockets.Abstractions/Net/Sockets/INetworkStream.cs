using System.Net.Sockets;
using Thinktecture.IO;

namespace Thinktecture.Net.Sockets
{
   /// <summary>
   /// Provides the underlying stream of data for network access.
   /// </summary>
   // ReSharper disable once PossibleInterfaceMemberAmbiguity
   public interface INetworkStream : IStream, IAbstraction<NetworkStream>
   {
#if NET5_0
      /// <summary>
      /// The underlying socket.
      /// </summary>
      Socket Socket { get; }
#endif

      /// <summary>
      /// Gets a value that indicates whether data is available on the NetworkStream to be read.
      /// </summary>
      bool DataAvailable { get; }

      /// <summary>Closes the <see cref="T:System.Net.Sockets.NetworkStream" /> after waiting the specified time to allow data to be sent.</summary>
      /// <param name="timeout">A 32-bit signed integer that specifies the number of milliseconds to wait to send any remaining data before closing.</param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="timeout" /> parameter is less than -1.</exception>
      void Close(int timeout);
   }
}
