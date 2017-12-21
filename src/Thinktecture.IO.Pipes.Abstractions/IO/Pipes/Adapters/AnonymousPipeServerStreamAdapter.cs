using System;
using System.ComponentModel;
using System.IO;
using System.IO.Pipes;
using JetBrains.Annotations;
using Microsoft.Win32.SafeHandles;

namespace Thinktecture.IO.Pipes.Adapters
{
	/// <summary>
	/// Exposes a stream around an anonymous pipe, which supports both synchronous and asynchronous read and write operations.
	/// </summary>
	public class AnonymousPipeServerStreamAdapter : PipeStreamAdapter, IAnonymousPipeServerStream
	{
		/// <inheritdoc />
		[NotNull]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new AnonymousPipeServerStream UnsafeConvert()
		{
			return Implementation;
		}

		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		[NotNull]
		protected new AnonymousPipeServerStream Implementation { get; }

		/// <inheritdoc />
		public SafePipeHandle ClientSafePipeHandle => Implementation.ClientSafePipeHandle;

		/// <summary>Initializes a new instance of the <see cref="AnonymousPipeServerStreamAdapter" /> class.</summary>
		public AnonymousPipeServerStreamAdapter()
			: this(new AnonymousPipeServerStream())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="AnonymousPipeServerStreamAdapter" /> class with the specified pipe direction.</summary>
		/// <param name="direction">One of the enumeration values that determines the direction of the pipe.Anonymous pipes can only be in one direction, so <paramref name="direction" /> cannot be set to <see cref="F:System.IO.Pipes.PipeDirection.InOut" />.</param>
		/// <exception cref="T:System.NotSupportedException">
		/// <paramref name="direction" /> is set to <see cref="F:System.IO.Pipes.PipeDirection.InOut" />.</exception>
		public AnonymousPipeServerStreamAdapter(PipeDirection direction)
			: this(new AnonymousPipeServerStream(direction))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="AnonymousPipeServerStreamAdapter" /> class with the specified pipe direction and inheritability mode.</summary>
		/// <param name="direction">One of the enumeration values that determines the direction of the pipe.Anonymous pipes can only be in one direction, so <paramref name="direction" /> cannot be set to <see cref="F:System.IO.Pipes.PipeDirection.InOut" />.</param>
		/// <param name="inheritability">One of the enumeration values that determines whether the underlying handle can be inherited by child processes. Must be set to either <see cref="F:System.IO.HandleInheritability.None" /> or <see cref="F:System.IO.HandleInheritability.Inheritable" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="inheritability" /> is not set to either <see cref="F:System.IO.HandleInheritability.None" /> or <see cref="F:System.IO.HandleInheritability.Inheritable" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		/// <paramref name="direction" /> is set to <see cref="F:System.IO.Pipes.PipeDirection.InOut" />.</exception>
		public AnonymousPipeServerStreamAdapter(PipeDirection direction, HandleInheritability inheritability)
			: this(new AnonymousPipeServerStream(direction, inheritability))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="AnonymousPipeServerStreamAdapter" /> class with the specified pipe direction, inheritability mode, and buffer size.</summary>
		/// <param name="direction">One of the enumeration values that determines the direction of the pipe.Anonymous pipes can only be in one direction, so <paramref name="direction" /> cannot be set to <see cref="F:System.IO.Pipes.PipeDirection.InOut" />.</param>
		/// <param name="inheritability">One of the enumeration values that determines whether the underlying handle can be inherited by child processes. Must be set to either <see cref="F:System.IO.HandleInheritability.None" /> or <see cref="F:System.IO.HandleInheritability.Inheritable" />.</param>
		/// <param name="bufferSize">The size of the buffer. This value must be greater than or equal to 0. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="inheritability" /> is not set to either <see cref="F:System.IO.HandleInheritability.None" /> or <see cref="F:System.IO.HandleInheritability.Inheritable" />.-or-
		/// <paramref name="bufferSize" /> is less than 0.</exception>
		/// <exception cref="T:System.NotSupportedException">
		/// <paramref name="direction" /> is set to <see cref="F:System.IO.Pipes.PipeDirection.InOut" />.</exception>
		public AnonymousPipeServerStreamAdapter(PipeDirection direction, HandleInheritability inheritability, int bufferSize)
			: this(new AnonymousPipeServerStream(direction, inheritability, bufferSize))
		{
		}

#if NET46
		/// <summary>Initializes a new instance of the <see cref="AnonymousPipeServerStreamAdapter" /> class with the specified pipe direction, inheritability mode, buffer size, and pipe security.</summary>
		/// <param name="direction">One of the enumeration values that determines the direction of the pipe.Anonymous pipes can only be in one direction, so <paramref name="direction" /> cannot be set to <see cref="F:System.IO.Pipes.PipeDirection.InOut" />.</param>
		/// <param name="inheritability">One of the enumeration values that determines whether the underlying handle can be inherited by child processes.</param>
		/// <param name="bufferSize">The size of the buffer. This value must be greater than or equal to 0. </param>
		/// <param name="pipeSecurity">An object that determines the access control and audit security for the pipe.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="inheritability" /> is not set to either <see cref="F:System.IO.HandleInheritability.None" /> or <see cref="F:System.IO.HandleInheritability.Inheritable" />.-or-
		/// <paramref name="bufferSize" /> is less than 0.</exception>
		/// <exception cref="T:System.NotSupportedException">
		/// <paramref name="direction" /> is set to <see cref="F:System.IO.Pipes.PipeDirection.InOut" />.</exception>
		public AnonymousPipeServerStreamAdapter(PipeDirection direction, HandleInheritability inheritability, int bufferSize, PipeSecurity pipeSecurity)
			: this(new AnonymousPipeServerStream(direction, inheritability, bufferSize, pipeSecurity))
		{
		}
#endif
		/// <summary>Initializes a new instance of the <see cref="AnonymousPipeServerStreamAdapter" /> class from the specified pipe handles.</summary>
		/// <param name="direction">One of the enumeration values that determines the direction of the pipe.Anonymous pipes can only be in one direction, so <paramref name="direction" /> cannot be set to <see cref="F:System.IO.Pipes.PipeDirection.InOut" />.</param>
		/// <param name="serverSafePipeHandle">A safe handle for the pipe that this <see cref="AnonymousPipeServerStreamAdapter" /> object will encapsulate.</param>
		/// <param name="clientSafePipeHandle">A safe handle for the <see cref="T:System.IO.Pipes.AnonymousPipeClientStream" /> object.</param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="serverSafePipeHandle" /> or <paramref name="clientSafePipeHandle" /> is an invalid handle.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="serverSafePipeHandle" /> or <paramref name="clientSafePipeHandle" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		/// <paramref name="direction" /> is set to <see cref="F:System.IO.Pipes.PipeDirection.InOut" />.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error, such as a disk error, has occurred.-or-The stream has been closed.</exception>
		public AnonymousPipeServerStreamAdapter(PipeDirection direction, SafePipeHandle serverSafePipeHandle, SafePipeHandle clientSafePipeHandle)
			: this(new AnonymousPipeServerStream(direction, serverSafePipeHandle, clientSafePipeHandle))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="AnonymousPipeServerStreamAdapter" /> class with the specified pipe direction.</summary>
		/// <param name="stream">Stream to use by the adapter.</param>
		public AnonymousPipeServerStreamAdapter([NotNull] AnonymousPipeServerStream stream)
			: base(stream)
		{
			Implementation = stream ?? throw new ArgumentNullException(nameof(stream));
		}

		/// <inheritdoc />
		public string GetClientHandleAsString()
		{
			return Implementation.GetClientHandleAsString();
		}

		/// <inheritdoc />
		public void DisposeLocalCopyOfClientHandle()
		{
			Implementation.DisposeLocalCopyOfClientHandle();
		}
	}
}
