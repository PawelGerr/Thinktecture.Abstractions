using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Thinktecture.IO.Pipes
{
	/// <summary>
	/// Exposes a <see cref="Stream" /> around a named pipe, supporting both synchronous and asynchronous read and write operations.
	/// </summary>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface INamedPipeServerStream : IPipeStream, IAbstraction<NamedPipeServerStream>
	{
		/// <summary>Waits for a client to connect to this <see cref="NamedPipeServerStream" /> object.</summary>
		/// <exception cref="InvalidOperationException">A pipe connection has already been established.-or-The pipe handle has not been set.</exception>
		/// <exception cref="ObjectDisposedException">The pipe is closed.</exception>
		/// <exception cref="IOException">The pipe connection has been broken.</exception>
		void WaitForConnection();

		/// <summary>Asynchronously waits for a client to connect to this <see cref="NamedPipeServerStream" /> object and monitors cancellation requests.</summary>
		/// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
		/// <returns>A task that represents the asynchronous wait operation.</returns>
		Task WaitForConnectionAsync(CancellationToken cancellationToken);

		/// <summary>Asynchronously waits for a client to connect to this <see cref="NamedPipeServerStream" /> object.</summary>
		/// <returns>A task that represents the asynchronous wait operation.</returns>
		Task WaitForConnectionAsync();

		/// <summary>Disconnects the current connection.</summary>
		/// <exception cref="InvalidOperationException">No pipe connections have been made yet.-or-The connected pipe has already disconnected.-or-The pipe handle has not been set.</exception>
		/// <exception cref="ObjectDisposedException">The pipe is closed.</exception>
		void Disconnect();

#if NET46
		/// <summary>Calls a delegate while impersonating the client.</summary>
		/// <param name="impersonationWorker">The delegate that specifies a method to call.</param>
		/// <exception cref="InvalidOperationException">No pipe connections have been made yet.-or-The connected pipe has already disconnected.-or-The pipe handle has not been set.</exception>
		/// <exception cref="ObjectDisposedException">The pipe is closed.</exception>
		/// <exception cref="IOException">The pipe connection has been broken.-or-An I/O error occurred.</exception>
		void RunAsClient(PipeStreamImpersonationWorker impersonationWorker);
#endif

		/// <summary>Gets the user name of the client on the other end of the pipe.</summary>
		/// <returns>The user name of the client on the other end of the pipe.</returns>
		/// <exception cref="InvalidOperationException">No pipe connections have been made yet.-or-The connected pipe has already disconnected.-or-The pipe handle has not been set.</exception>
		/// <exception cref="ObjectDisposedException">The pipe is closed.</exception>
		/// <exception cref="IOException">The pipe connection has been broken.-or-The user name of the client is longer than 19 characters.</exception>
		[NotNull]
		string GetImpersonationUserName();
	}
}
