using System.IO.Pipes;
using System.Runtime.Versioning;
using System.Threading;
using System.Threading.Tasks;
using Thinktecture.IO.Pipes.Adapters;

namespace Thinktecture.IO.Pipes
{
   /// <summary>
   /// Exposes a <see cref="T:System.IO.Stream"></see> around a named pipe, which supports both synchronous and asynchronous read and write operations.
   /// </summary>
   // ReSharper disable once PossibleInterfaceMemberAmbiguity
   public interface INamedPipeClientStream : IPipeStream, IAbstraction<NamedPipeClientStream>
   {
      /// <summary>Gets the number of server instances that share the same pipe name.</summary>
      /// <returns>The number of server instances that share the same pipe name.</returns>
      /// <exception cref="T:System.InvalidOperationException">The pipe handle has not been set.   -or-   The current <see cref="NamedPipeClientStreamAdapter"></see> object has not yet connected to a <see cref="T:System.IO.Pipes.NamedPipeServerStream"></see> object.</exception>
      /// <exception cref="T:System.IO.IOException">The pipe is broken or an I/O error occurred.</exception>
      /// <exception cref="T:System.ObjectDisposedException">The underlying pipe handle is closed.</exception>
#if NET5_0
      [SupportedOSPlatform("windows")]
#endif
      int NumberOfServerInstances { get; }

      /// <summary>Connects to a waiting server with an infinite time-out value.</summary>
      /// <exception cref="T:System.InvalidOperationException">The client is already connected.</exception>
      void Connect();

      /// <summary>Connects to a waiting server within the specified time-out period.</summary>
      /// <param name="timeout">The number of milliseconds to wait for the server to respond before the connection times out.</param>
      /// <exception cref="T:System.TimeoutException">Could not connect to the server within the specified <paramref name="timeout">timeout</paramref> period.</exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeout">timeout</paramref> is less than 0 and not set to <see cref="F:System.Threading.Timeout.Infinite"></see>.</exception>
      /// <exception cref="T:System.InvalidOperationException">The client is already connected.</exception>
      /// <exception cref="T:System.IO.IOException">The server is connected to another client and the time-out period has expired.</exception>
      void Connect(int timeout);

      /// <summary>Asynchronously connects to a waiting server with an infinite timeout period.</summary>
      /// <returns>A task that represents the asynchronous connect operation.</returns>
      Task ConnectAsync();

      /// <summary>Asynchronously connects to a waiting server within the specified timeout period.</summary>
      /// <param name="timeout">The number of milliseconds to wait for the server to respond before the connection times out.</param>
      /// <returns>A task that represents the asynchronous connect operation.</returns>
      Task ConnectAsync(int timeout);

      /// <summary>Asynchronously connects to a waiting server within the specified timeout period and monitors cancellation requests.</summary>
      /// <param name="timeout">The number of milliseconds to wait for the server to respond before the connection times out.</param>
      /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None"></see>.</param>
      /// <returns>A task that represents the asynchronous connect operation.</returns>
      Task ConnectAsync(int timeout, CancellationToken cancellationToken);

      /// <summary>Asynchronously connects to a waiting server and monitors cancellation requests.</summary>
      /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None"></see>.</param>
      /// <returns>A task that represents the asynchronous connect operation.</returns>
      Task ConnectAsync(CancellationToken cancellationToken);
   }
}
