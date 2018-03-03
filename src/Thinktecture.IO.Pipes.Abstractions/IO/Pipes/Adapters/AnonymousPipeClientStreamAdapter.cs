using System;
using System.ComponentModel;
using System.IO;
using System.IO.Pipes;
using JetBrains.Annotations;
using Microsoft.Win32.SafeHandles;

namespace Thinktecture.IO.Pipes.Adapters
{
	/// <summary>
	/// Exposes the client side of an anonymous pipe stream, which supports both synchronous and asynchronous read and write operations.
	/// </summary>
	public class AnonymousPipeClientStreamAdapter : PipeStreamAdapter, IAnonymousPipeClientStream
	{
		/// <inheritdoc />
		[NotNull]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new AnonymousPipeClientStream UnsafeConvert()
		{
			return Implementation;
		}

		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		[NotNull]
		protected new AnonymousPipeClientStream Implementation { get; }

		/// <summary>Initializes a new instance of the <see cref="AnonymousPipeClientStreamAdapter" /> class with the specified string representation of the pipe handle.</summary>
		/// <param name="pipeHandleAsString">A string that represents the pipe handle.</param>
		/// <exception cref="IOException">
		/// <paramref name="pipeHandleAsString" /> is not a valid pipe handle.</exception>
		public AnonymousPipeClientStreamAdapter([NotNull] string pipeHandleAsString)
			: this(new AnonymousPipeClientStream(pipeHandleAsString))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="AnonymousPipeClientStreamAdapter" /> class with the specified pipe direction and a string representation of the pipe handle.</summary>
		/// <param name="direction">One of the enumeration values that determines the direction of the pipe.Anonymous pipes can only be in one direction, so <paramref name="direction" /> cannot be set to <see cref="F:System.IO.Pipes.PipeDirection.InOut" />.</param>
		/// <param name="pipeHandleAsString">A string that represents the pipe handle.</param>
		/// <exception cref="ArgumentException">
		/// <paramref name="pipeHandleAsString" /> is an invalid handle.</exception>
		/// <exception cref="ArgumentNullException">
		/// <paramref name="pipeHandleAsString" /> is <see langword="null" />.</exception>
		/// <exception cref="NotSupportedException">
		/// <paramref name="direction" /> is set to <see cref="PipeDirection.InOut" />.</exception>
		public AnonymousPipeClientStreamAdapter(PipeDirection direction, [NotNull] string pipeHandleAsString)
			: this(new AnonymousPipeClientStream(direction, pipeHandleAsString))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="AnonymousPipeClientStreamAdapter" /> class from the specified handle.</summary>
		/// <param name="direction">One of the enumeration values that determines the direction of the pipe.Anonymous pipes can only be in one direction, so <paramref name="direction" /> cannot be set to <see cref="F:System.IO.Pipes.PipeDirection.InOut" />.</param>
		/// <param name="safePipeHandle">A safe handle for the pipe that this <see cref="AnonymousPipeClientStreamAdapter" /> object will encapsulate.</param>
		/// <exception cref="ArgumentException">
		/// <paramref name="safePipeHandle " />is not a valid handle.</exception>
		/// <exception cref="ArgumentNullException">
		/// <paramref name="safePipeHandle" /> is <see langword="null" />.</exception>
		/// <exception cref="NotSupportedException">
		/// <paramref name="direction" /> is set to <see cref="PipeDirection.InOut" />.</exception>
		/// <exception cref="IOException">An I/O error, such as a disk error, has occurred.-or-The stream has been closed.</exception>
		public AnonymousPipeClientStreamAdapter(PipeDirection direction, [NotNull] SafePipeHandle safePipeHandle)
			: this(new AnonymousPipeClientStream(direction, safePipeHandle))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="AnonymousPipeClientStream" />.</summary>
		/// <param name="stream">Stream to use by the adapter.</param>
		public AnonymousPipeClientStreamAdapter([NotNull] AnonymousPipeClientStream stream)
			: base(stream)
		{
			Implementation = stream ?? throw new ArgumentNullException(nameof(stream));
		}
	}
}
