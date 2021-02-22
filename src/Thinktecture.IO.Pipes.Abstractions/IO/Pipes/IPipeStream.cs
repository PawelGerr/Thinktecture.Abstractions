using System;
using System.IO;
using System.IO.Pipes;
using System.Runtime.Versioning;
using Microsoft.Win32.SafeHandles;

namespace Thinktecture.IO.Pipes
{
   /// <summary>
   /// Exposes a <see cref="IStream" /> object around a pipe, which supports both anonymous and named pipes.
   /// </summary>
   // ReSharper disable once PossibleInterfaceMemberAmbiguity
   public interface IPipeStream : IStream, IAbstraction<PipeStream>
   {
      /// <summary>Gets the size, in bytes, of the inbound buffer for a pipe.</summary>
      /// <returns>An integer value that represents the inbound buffer size, in bytes.</returns>
      /// <exception cref="NotSupportedException">The stream is unreadable.</exception>
      /// <exception cref="InvalidOperationException">The pipe is waiting to connect.</exception>
      /// <exception cref="IOException">The pipe is broken or another I/O error occurred.</exception>
      int InBufferSize { get; }

      /// <summary>Gets a value indicating whether a <see cref="IPipeStream" /> object was opened asynchronously or synchronously.</summary>
      /// <returns>true if the <see cref="IPipeStream" /> object was opened asynchronously; otherwise, false.</returns>
      bool IsAsync { get; }

      /// <summary>Gets or sets a value indicating whether a <see cref="IPipeStream" /> object is connected.</summary>
      /// <returns>true if the <see cref="IPipeStream" /> object is connected; otherwise, false.</returns>
      bool IsConnected { get; }

      /// <summary>Gets a value indicating whether there is more data in the message returned from the most recent read operation.</summary>
      /// <returns>true if there are no more characters to read in the message; otherwise, false.</returns>
      /// <exception cref="InvalidOperationException">The pipe is not connected.-or-The pipe handle has not been set.-or-The pipe's <see cref="IPipeStream.ReadMode" /> property value is not <see cref="PipeTransmissionMode.Message" />.</exception>
      /// <exception cref="ObjectDisposedException">The pipe is closed.</exception>
      bool IsMessageComplete { get; }

      /// <summary>Gets the size, in bytes, of the outbound buffer for a pipe.</summary>
      /// <returns>The outbound buffer size, in bytes.</returns>
      /// <exception cref="NotSupportedException">The stream is unwriteable.</exception>
      /// <exception cref="InvalidOperationException">The pipe is waiting to connect.</exception>
      /// <exception cref="IOException">The pipe is broken or another I/O error occurred.</exception>
      int OutBufferSize { get; }

      /// <summary>Gets or sets the reading mode for a <see cref="IPipeStream" /> object.</summary>
      /// <returns>One of the <see cref="PipeTransmissionMode" /> values that indicates how the <see cref="IPipeStream" /> object reads from the pipe.</returns>
      /// <exception cref="ArgumentOutOfRangeException">The supplied value is not a valid <see cref="PipeTransmissionMode" /> value.</exception>
      /// <exception cref="NotSupportedException">The supplied value is not a supported <see cref="PipeTransmissionMode" /> value for this pipe stream.</exception>
      /// <exception cref="InvalidOperationException">The handle has not been set.-or-The pipe is waiting to connect with a named client.</exception>
      /// <exception cref="IOException">The pipe is broken or an I/O error occurred with a named client.</exception>
      PipeTransmissionMode ReadMode { get; set; }

      /// <summary>Gets the safe handle for the local end of the pipe that the current <see cref="IPipeStream" /> object encapsulates.</summary>
      /// <returns>A <see cref="SafePipeHandle" /> object for the pipe that is encapsulated by the current <see cref="IPipeStream" /> object.</returns>
      /// <exception cref="InvalidOperationException">The pipe handle has not been set.</exception>
      /// <exception cref="ObjectDisposedException">The pipe is closed.</exception>
      SafePipeHandle SafePipeHandle { get; }

      /// <summary>Gets the pipe transmission mode supported by the current pipe.</summary>
      /// <returns>One of the <see cref="PipeTransmissionMode" /> values that indicates the transmission mode supported by the current pipe.</returns>
      /// <exception cref="ObjectDisposedException">The pipe is closed.</exception>
      /// <exception cref="InvalidOperationException">The handle has not been set.-or-The pipe is waiting to connect in an anonymous client/server operation or with a named client. </exception>
      /// <exception cref="IOException">The pipe is broken or another I/O error occurred.</exception>
      PipeTransmissionMode TransmissionMode { get; }

      /// <summary>Waits for the other end of the pipe to read all sent bytes.</summary>
      /// <exception cref="ObjectDisposedException">The pipe is closed.</exception>
      /// <exception cref="NotSupportedException">The pipe does not support write operations.</exception>
      /// <exception cref="IOException">The pipe is broken or another I/O error occurred.</exception>
#if NET5_0
      [SupportedOSPlatform("windows")]
#endif
      void WaitForPipeDrain();
   }
}
