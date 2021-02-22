using System;
using System.ComponentModel;
using System.IO;
using System.IO.Pipes;
using System.Runtime.Versioning;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace Thinktecture.IO.Pipes.Adapters
{
   /// <summary>
   /// Exposes a <see cref="T:System.IO.Stream"></see> around a named pipe, which supports both synchronous and asynchronous read and write operations.
   /// </summary>
   public class NamedPipeClientStreamAdapter : PipeStreamAdapter, INamedPipeClientStream
   {
      /// <inheritdoc />
      [EditorBrowsable(EditorBrowsableState.Never)]
      public new NamedPipeClientStream UnsafeConvert()
      {
         return Implementation;
      }

      /// <summary>
      /// Implementation used by the adapter.
      /// </summary>
      protected new NamedPipeClientStream Implementation { get; }

      /// <inheritdoc />
#if NET5_0
      [SupportedOSPlatform("windows")]
#endif
      public int NumberOfServerInstances => Implementation.NumberOfServerInstances;

      /// <summary>Initializes a new instance of the <see cref="NamedPipeClientStreamAdapter"></see> class for the specified pipe handle with the specified pipe direction.</summary>
      /// <param name="direction">One of the enumeration values that determines the direction of the pipe.</param>
      /// <param name="isAsync">true to indicate that the handle was opened asynchronously; otherwise, false.</param>
      /// <param name="isConnected">true to indicate that the pipe is connected; otherwise, false.</param>
      /// <param name="safePipeHandle">A safe handle for the pipe that this <see cref="NamedPipeClientStreamAdapter"></see> object will encapsulate.</param>
      /// <exception cref="T:System.IO.IOException">The stream has been closed.</exception>
      /// <exception cref="T:System.ArgumentException"><paramref name="safePipeHandle">safePipeHandle</paramref> is not a valid handle.</exception>
      /// <exception cref="T:System.ArgumentNullException"><paramref name="safePipeHandle">safePipeHandle</paramref> is null.</exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="direction">direction</paramref> is not a valid <see cref="T:System.IO.Pipes.PipeDirection"></see> value.</exception>
      public NamedPipeClientStreamAdapter(PipeDirection direction, bool isAsync, bool isConnected, SafePipeHandle safePipeHandle)
         : this(new NamedPipeClientStream(direction, isAsync, isConnected, safePipeHandle))
      {
      }

      /// <summary>Initializes a new instance of the <see cref="NamedPipeClientStreamAdapter"></see> class with the specified pipe name.</summary>
      /// <param name="pipeName">The name of the pipe.</param>
      /// <exception cref="T:System.ArgumentNullException"><paramref name="pipeName">pipeName</paramref> is null.</exception>
      /// <exception cref="T:System.ArgumentException"><paramref name="pipeName">pipeName</paramref> is a zero-length string.</exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="pipeName">pipeName</paramref> is set to "anonymous".</exception>
      public NamedPipeClientStreamAdapter(string pipeName)
         : this(new NamedPipeClientStream(pipeName))
      {
      }

      /// <summary>Initializes a new instance of the <see cref="NamedPipeClientStreamAdapter"></see> class with the specified pipe and server names.</summary>
      /// <param name="serverName">The name of the remote computer to connect to, or "." to specify the local computer.</param>
      /// <param name="pipeName">The name of the pipe.</param>
      /// <exception cref="T:System.ArgumentNullException"><paramref name="pipeName">pipeName</paramref> or <paramref name="serverName">serverName</paramref> is null.</exception>
      /// <exception cref="T:System.ArgumentException"><paramref name="pipeName">pipeName</paramref> or <paramref name="serverName">serverName</paramref> is a zero-length string.</exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="pipeName">pipeName</paramref> is set to "anonymous".</exception>
      public NamedPipeClientStreamAdapter(string serverName, string pipeName)
         : this(new NamedPipeClientStream(serverName, pipeName))
      {
      }

      /// <summary>Initializes a new instance of the <see cref="NamedPipeClientStreamAdapter"></see> class with the specified pipe and server names, and the specified pipe direction.</summary>
      /// <param name="serverName">The name of the remote computer to connect to, or "." to specify the local computer.</param>
      /// <param name="pipeName">The name of the pipe.</param>
      /// <param name="direction">One of the enumeration values that determines the direction of the pipe.</param>
      /// <exception cref="T:System.ArgumentNullException"><paramref name="pipeName">pipeName</paramref> or <paramref name="serverName">serverName</paramref> is null.</exception>
      /// <exception cref="T:System.ArgumentException"><paramref name="pipeName">pipeName</paramref> or <paramref name="serverName">serverName</paramref> is a zero-length string.</exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="pipeName">pipeName</paramref> is set to "anonymous".   -or-  <paramref name="direction">direction</paramref> is not a valid <see cref="T:System.IO.Pipes.PipeDirection"></see> value.</exception>
      public NamedPipeClientStreamAdapter(string serverName, string pipeName, PipeDirection direction)
         : this(new NamedPipeClientStream(serverName, pipeName, direction))
      {
      }

      /// <summary>Initializes a new instance of the <see cref="NamedPipeClientStreamAdapter"></see> class with the specified pipe and server names, and the specified pipe direction and pipe options.</summary>
      /// <param name="serverName">The name of the remote computer to connect to, or "." to specify the local computer.</param>
      /// <param name="pipeName">The name of the pipe.</param>
      /// <param name="direction">One of the enumeration values that determines the direction of the pipe.</param>
      /// <param name="options">One of the enumeration values that determines how to open or create the pipe.</param>
      /// <exception cref="T:System.ArgumentNullException"><paramref name="pipeName">pipeName</paramref> or <paramref name="serverName">serverName</paramref> is null.</exception>
      /// <exception cref="T:System.ArgumentException"><paramref name="pipeName">pipeName</paramref> or <paramref name="serverName">serverName</paramref> is a zero-length string.</exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="pipeName">pipeName</paramref> is set to "anonymous".   -or-  <paramref name="direction">direction</paramref> is not a valid <see cref="T:System.IO.Pipes.PipeDirection"></see> value.   -or-  <paramref name="options">options</paramref> is not a valid <see cref="T:System.IO.Pipes.PipeOptions"></see> value.</exception>
      public NamedPipeClientStreamAdapter(string serverName, string pipeName, PipeDirection direction, PipeOptions options)
         : this(new NamedPipeClientStream(serverName, pipeName, direction, options))
      {
      }

      /// <summary>Initializes a new instance of the <see cref="NamedPipeClientStreamAdapter"></see> class with the specified pipe and server names, and the specified pipe direction, pipe options, and security impersonation level.</summary>
      /// <param name="serverName">The name of the remote computer to connect to, or "." to specify the local computer.</param>
      /// <param name="pipeName">The name of the pipe.</param>
      /// <param name="direction">One of the enumeration values that determines the direction of the pipe.</param>
      /// <param name="options">One of the enumeration values that determines how to open or create the pipe.</param>
      /// <param name="impersonationLevel">One of the enumeration values that determines the security impersonation level.</param>
      /// <exception cref="T:System.ArgumentNullException"><paramref name="pipeName">pipeName</paramref> or <paramref name="serverName">serverName</paramref> is null.</exception>
      /// <exception cref="T:System.ArgumentException"><paramref name="pipeName">pipeName</paramref> or <paramref name="serverName">serverName</paramref> is a zero-length string.</exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="pipeName">pipeName</paramref> is set to "anonymous".   -or-  <paramref name="direction">direction</paramref> is not a valid <see cref="T:System.IO.Pipes.PipeDirection"></see> value.   -or-  <paramref name="options">options</paramref> is not a valid <see cref="T:System.IO.Pipes.PipeOptions"></see> value.   -or-  <paramref name="impersonationLevel">impersonationLevel</paramref> is not a valid <see cref="T:System.Security.Principal.TokenImpersonationLevel"></see> value.</exception>
      public NamedPipeClientStreamAdapter(string serverName, string pipeName, PipeDirection direction, PipeOptions options, TokenImpersonationLevel impersonationLevel)
         : this(new NamedPipeClientStream(serverName, pipeName, direction, options, impersonationLevel))
      {
      }

      /// <summary>Initializes a new instance of the <see cref="NamedPipeClientStreamAdapter"></see> class with the specified pipe and server names, and the specified pipe direction, pipe options, security impersonation level, and inheritability mode.</summary>
      /// <param name="serverName">The name of the remote computer to connect to, or "." to specify the local computer.</param>
      /// <param name="pipeName">The name of the pipe.</param>
      /// <param name="direction">One of the enumeration values that determines the direction of the pipe.</param>
      /// <param name="options">One of the enumeration values that determines how to open or create the pipe.</param>
      /// <param name="impersonationLevel">One of the enumeration values that determines the security impersonation level.</param>
      /// <param name="inheritability">One of the enumeration values that determines whether the underlying handle will be inheritable by child processes.</param>
      /// <exception cref="T:System.ArgumentNullException"><paramref name="pipeName">pipeName</paramref> or <paramref name="serverName">serverName</paramref> is null.</exception>
      /// <exception cref="T:System.ArgumentException"><paramref name="pipeName">pipeName</paramref> or <paramref name="serverName">serverName</paramref> is a zero-length string.</exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="pipeName">pipeName</paramref> is set to "anonymous".   -or-  <paramref name="direction">direction</paramref> is not a valid <see cref="T:System.IO.Pipes.PipeDirection"></see> value.   -or-  <paramref name="options">options</paramref> is not a valid <see cref="T:System.IO.Pipes.PipeOptions"></see> value.   -or-  <paramref name="impersonationLevel">impersonationLevel</paramref> is not a valid <see cref="T:System.Security.Principal.TokenImpersonationLevel"></see> value.   -or-  <paramref name="inheritability">inheritability</paramref> is not a valid <see cref="T:System.IO.HandleInheritability"></see> value.</exception>
      public NamedPipeClientStreamAdapter(string serverName, string pipeName, PipeDirection direction, PipeOptions options, TokenImpersonationLevel impersonationLevel, HandleInheritability inheritability)
         : this(new NamedPipeClientStream(serverName, pipeName, direction, options, impersonationLevel, inheritability))
      {
      }

      /// <summary>Initializes a new instance of the <see cref="NamedPipeClientStreamAdapter"></see> .</summary>
      /// <param name="stream">Stream to use by the adapter.</param>
      public NamedPipeClientStreamAdapter(NamedPipeClientStream stream)
         : base(stream)
      {
         Implementation = stream ?? throw new ArgumentNullException(nameof(stream));
      }

      /// <inheritdoc />
      public void Connect()
      {
         Implementation.Connect();
      }

      /// <inheritdoc />
      public void Connect(int timeout)
      {
         Implementation.Connect(timeout);
      }

      /// <inheritdoc />
      public Task ConnectAsync()
      {
         return Implementation.ConnectAsync();
      }

      /// <inheritdoc />
      public Task ConnectAsync(int timeout)
      {
         return Implementation.ConnectAsync(timeout);
      }

      /// <inheritdoc />
      public Task ConnectAsync(int timeout, CancellationToken cancellationToken)
      {
         return Implementation.ConnectAsync(timeout, cancellationToken);
      }

      /// <inheritdoc />
      public Task ConnectAsync(CancellationToken cancellationToken)
      {
         return Implementation.ConnectAsync(cancellationToken);
      }
   }
}
