using System.IO.Pipes;
using Microsoft.Win32.SafeHandles;
using Thinktecture.IO.Pipes.Adapters;

namespace Thinktecture.IO.Pipes
{
	/// <summary>
	/// Exposes a stream around an anonymous pipe, which supports both synchronous and asynchronous read and write operations.
	/// </summary>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface IAnonymousPipeServerStream : IPipeStream, IAbstraction<AnonymousPipeServerStream>
	{
		/// <summary>Gets the connected <see cref="T:System.IO.Pipes.AnonymousPipeClientStream" /> object's handle as a string.</summary>
		/// <returns>A string that represents the connected <see cref="T:System.IO.Pipes.AnonymousPipeClientStream" /> object's handle.</returns>
		string GetClientHandleAsString();

		/// <summary>Gets the safe handle for the <see cref="T:System.IO.Pipes.AnonymousPipeClientStream" /> object that is currently connected to the <see cref="AnonymousPipeServerStreamAdapter" /> object.</summary>
		/// <returns>A handle for the <see cref="T:System.IO.Pipes.AnonymousPipeClientStream" /> object that is currently connected to the <see cref="AnonymousPipeServerStreamAdapter" /> object.</returns>
		SafePipeHandle ClientSafePipeHandle { get; }

		/// <summary>Closes the local copy of the <see cref="T:System.IO.Pipes.AnonymousPipeClientStream" /> object's handle.</summary>
		void DisposeLocalCopyOfClientHandle();
	}
}
