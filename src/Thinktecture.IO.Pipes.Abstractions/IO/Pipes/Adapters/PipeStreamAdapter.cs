using System;
using System.ComponentModel;
using System.IO.Pipes;
using System.Runtime.Versioning;
using Microsoft.Win32.SafeHandles;
using Thinktecture.IO.Adapters;

namespace Thinktecture.IO.Pipes.Adapters
{
   /// <summary>
   /// Exposes a <see cref="IStream" /> object around a pipe, which supports both anonymous and named pipes.
   /// </summary>
   public class PipeStreamAdapter : StreamAdapter, IPipeStream
   {
      /// <inheritdoc />
      [EditorBrowsable(EditorBrowsableState.Never)]
      public new PipeStream UnsafeConvert()
      {
         return Implementation;
      }

      /// <summary>
      /// Implementation used by the adapter.
      /// </summary>
      protected new PipeStream Implementation { get; }

      /// <inheritdoc />
      public int InBufferSize => Implementation.InBufferSize;

      /// <inheritdoc />
      public bool IsAsync => Implementation.IsAsync;

      /// <inheritdoc />
      public bool IsConnected => Implementation.IsConnected;

      /// <inheritdoc />
      public bool IsMessageComplete => Implementation.IsMessageComplete;

      /// <inheritdoc />
      public int OutBufferSize => Implementation.OutBufferSize;

      /// <inheritdoc />
      public PipeTransmissionMode ReadMode
      {
         get => Implementation.ReadMode;
         set => Implementation.ReadMode = value;
      }

      /// <inheritdoc />
      public SafePipeHandle SafePipeHandle => Implementation.SafePipeHandle;

      /// <inheritdoc />
      public PipeTransmissionMode TransmissionMode => Implementation.TransmissionMode;

      /// <summary>Initializes a new instance of the <see cref="PipeStreamAdapter" />.</summary>
      /// <param name="stream"> to be used by the adapter.</param>
      public PipeStreamAdapter(PipeStream stream)
         : base(stream)
      {
         Implementation = stream ?? throw new ArgumentNullException(nameof(stream));
      }

      /// <inheritdoc />
#if NET5_0
      [SupportedOSPlatform("windows")]
#endif
      public void WaitForPipeDrain()
      {
         Implementation.WaitForPipeDrain();
      }
   }
}
