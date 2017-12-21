using System;
using System.ComponentModel;
using System.IO;
using System.IO.Pipes;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.Win32.SafeHandles;

namespace Thinktecture.IO.Pipes.Adapters
{
	/// <summary>
	/// Exposes a <see cref="Stream" /> around a named pipe, supporting both synchronous and asynchronous read and write operations.
	/// </summary>
	public class NamedPipeServerStreamAdapter : PipeStreamAdapter, INamedPipeServerStream
	{
		/// <summary>Represents the maximum number of server instances that the system resources allow.</summary>
		public const int MaxAllowedServerInstances = -1;

		/// <inheritdoc />
		[NotNull]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new NamedPipeServerStream UnsafeConvert()
		{
			return Implementation;
		}

		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		[NotNull]
		protected new NamedPipeServerStream Implementation { get; }

		/// <summary>Initializes a new instance of the <see cref="NamedPipeServerStreamAdapter" /> class with the specified pipe name.</summary>
		/// <param name="pipeName">The name of the pipe.</param>
		/// <exception cref="ArgumentNullException">
		/// <paramref name="pipeName" /> is <see langword="null" />.</exception>
		/// <exception cref="ArgumentException">
		/// <paramref name="pipeName" /> is a zero-length string.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <paramref name="pipeName" /> is set to "anonymous".</exception>
		/// <exception cref="NotSupportedException">
		/// <paramref name="pipeName" /> contains a colon (":").</exception>
		/// <exception cref="PlatformNotSupportedException">The operating system is Windows Millennium Edition, Windows 98, or Windows 95, which are not supported. </exception>
		/// <exception cref="IOException">The maximum number of server instances has been exceeded.</exception>
		public NamedPipeServerStreamAdapter(string pipeName)
			: this(new NamedPipeServerStream(pipeName))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="NamedPipeServerStreamAdapter" /> class with the specified pipe name and pipe direction.</summary>
		/// <param name="pipeName">The name of the pipe.</param>
		/// <param name="direction">One of the enumeration values that determines the direction of the pipe.</param>
		/// <exception cref="ArgumentNullException">
		/// <paramref name="pipeName" /> is <see langword="null" />.</exception>
		/// <exception cref="ArgumentException">
		/// <paramref name="pipeName" /> is a zero-length string.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <paramref name="pipeName" /> is set to "anonymous".-or-
		/// <paramref name="direction" /> is not a valid <see cref="PipeDirection" /> value.</exception>
		/// <exception cref="NotSupportedException">
		/// <paramref name="pipeName" /> contains a colon (":").</exception>
		/// <exception cref="PlatformNotSupportedException">The operating system is Windows Millennium Edition, Windows 98, or Windows 95, which are not supported.</exception>
		/// <exception cref="IOException">The maximum number of server instances has been exceeded.</exception>
		public NamedPipeServerStreamAdapter(string pipeName, PipeDirection direction)
			: this(new NamedPipeServerStream(pipeName, direction))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="NamedPipeServerStreamAdapter" /> class with the specified pipe name, pipe direction, and maximum number of server instances.</summary>
		/// <param name="pipeName">The name of the pipe.</param>
		/// <param name="direction">One of the enumeration values that determines the direction of the pipe.</param>
		/// <param name="maxNumberOfServerInstances">The maximum number of server instances that share the same name. You can pass <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" /> for this value.</param>
		/// <exception cref="ArgumentNullException">
		/// <paramref name="pipeName" /> is <see langword="null" />.</exception>
		/// <exception cref="ArgumentException">
		/// <paramref name="pipeName" /> is a zero-length string.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <paramref name="pipeName" /> is set to "anonymous".-or-
		/// <paramref name="direction" /> is not a valid <see cref="PipeDirection" /> value.-or-A non-negative number is required.-or-
		/// <paramref name="maxNumberOfServerInstances" /> is less than -1 or greater than 254 (-1 indicates <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" />)-or-
		/// 
		/// <see cref="F:System.IO.HandleInheritability.None" /> or <see cref="F:System.IO.HandleInheritability.Inheritable" /> is required.-or-Access rights is limited to the <see cref="F:System.IO.Pipes.PipeAccessRights.ChangePermissions" /> , <see cref="F:System.IO.Pipes.PipeAccessRights.TakeOwnership" /> , and <see cref="F:System.IO.Pipes.PipeAccessRights.AccessSystemSecurity" /> flags.</exception>
		/// <exception cref="NotSupportedException">
		/// <paramref name="pipeName" /> contains a colon (":").</exception>
		/// <exception cref="PlatformNotSupportedException">The operating system is Windows Millennium Edition, Windows 98, or Windows 95, which are not supported.</exception>
		/// <exception cref="IOException">The maximum number of server instances has been exceeded.</exception>
		public NamedPipeServerStreamAdapter(string pipeName, PipeDirection direction, int maxNumberOfServerInstances)
			: this(new NamedPipeServerStream(pipeName, direction, maxNumberOfServerInstances))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="NamedPipeServerStreamAdapter" /> class with the specified pipe name, pipe direction, maximum number of server instances, and transmission mode.</summary>
		/// <param name="pipeName">The name of the pipe.</param>
		/// <param name="direction">One of the enumeration values that determines the direction of the pipe.</param>
		/// <param name="maxNumberOfServerInstances">The maximum number of server instances that share the same name. You can pass <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" /> for this value.</param>
		/// <param name="transmissionMode">One of the enumeration values that determines the transmission mode of the pipe.</param>
		/// <exception cref="ArgumentNullException">
		/// <paramref name="pipeName" /> is <see langword="null" />.</exception>
		/// <exception cref="ArgumentException">
		/// <paramref name="pipeName" /> is a zero-length string.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <paramref name="pipeName" /> is set to "anonymous".-or-
		/// <paramref name="direction" /> is not a valid <see cref="PipeDirection" /> value.-or-
		/// <paramref name="maxNumberofServerInstances" /> is less than -1 or greater than 254 (-1 indicates <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" />)</exception>
		/// <exception cref="NotSupportedException">
		/// <paramref name="pipeName" /> contains a colon (":").</exception>
		/// <exception cref="PlatformNotSupportedException">The operating system is Windows Millennium Edition, Windows 98, or Windows 95, which are not supported.</exception>
		/// <exception cref="IOException">The maximum number of server instances has been exceeded.</exception>
		public NamedPipeServerStreamAdapter(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode)
			: this(new NamedPipeServerStream(pipeName, direction, maxNumberOfServerInstances, transmissionMode))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="NamedPipeServerStreamAdapter" /> class with the specified pipe name, pipe direction, maximum number of server instances, transmission mode, and pipe options.</summary>
		/// <param name="pipeName">The name of the pipe.</param>
		/// <param name="direction">One of the enumeration values that determines the direction of the pipe.</param>
		/// <param name="maxNumberOfServerInstances">The maximum number of server instances that share the same name. You can pass <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" /> for this value.</param>
		/// <param name="transmissionMode">One of the enumeration values that determines the transmission mode of the pipe.</param>
		/// <param name="options">One of the enumeration values that determines how to open or create the pipe.</param>
		/// <exception cref="ArgumentNullException">
		/// <paramref name="pipeName" /> is <see langword="null" />.</exception>
		/// <exception cref="ArgumentException">
		/// <paramref name="pipeName" /> is a zero-length string.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <paramref name="pipeName" /> is set to "anonymous".-or-
		/// <paramref name="direction" /> is not a valid <see cref="PipeDirection" /> value.-or-
		/// <paramref name="maxNumberofServerInstances" /> is less than -1 or greater than 254 (-1 indicates <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" />)-or-
		/// <paramref name="options" /> is not a valid <see cref="PipeOptions" /> value.</exception>
		/// <exception cref="NotSupportedException">
		/// <paramref name="pipeName" /> contains a colon (":").</exception>
		/// <exception cref="PlatformNotSupportedException">The operating system is Windows Millennium Edition, Windows 98, or Windows 95, which are not supported.</exception>
		/// <exception cref="IOException">The maximum number of server instances has been exceeded.</exception>
		public NamedPipeServerStreamAdapter(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options)
			: this(new NamedPipeServerStream(pipeName, direction, maxNumberOfServerInstances, transmissionMode, options))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="NamedPipeServerStreamAdapter" /> class with the specified pipe name, pipe direction, maximum number of server instances, transmission mode, pipe options, and recommended in and out buffer sizes.</summary>
		/// <param name="pipeName">The name of the pipe.</param>
		/// <param name="direction">One of the enumeration values that determines the direction of the pipe.</param>
		/// <param name="maxNumberOfServerInstances">The maximum number of server instances that share the same name. You can pass <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" /> for this value.</param>
		/// <param name="transmissionMode">One of the enumeration values that determines the transmission mode of the pipe.</param>
		/// <param name="options">One of the enumeration values that determines how to open or create the pipe.</param>
		/// <param name="inBufferSize">A positive value greater than 0 that indicates the input buffer size.</param>
		/// <param name="outBufferSize">A positive value greater than 0 that indicates the output buffer size.</param>
		/// <exception cref="ArgumentNullException">
		/// <paramref name="pipeName" /> is <see langword="null" />.</exception>
		/// <exception cref="ArgumentException">
		/// <paramref name="pipeName" /> is a zero-length string.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <paramref name="pipeName" /> is set to "anonymous".-or-
		/// <paramref name="direction" /> is not a valid <see cref="PipeDirection" /> value.-or-
		/// <paramref name="maxNumberofServerInstances" /> is less than -1 or greater than 254 (-1 indicates <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" />)-or-
		/// <paramref name="options" /> is not a valid <see cref="PipeOptions" /> value.-or-
		/// <paramref name="inBufferSize" /> is negative.</exception>
		/// <exception cref="NotSupportedException">
		/// <paramref name="pipeName" /> contains a colon (":").</exception>
		/// <exception cref="PlatformNotSupportedException">The operating system is Windows Millennium Edition, Windows 98, or Windows 95, which are not supported.</exception>
		/// <exception cref="IOException">The maximum number of server instances has been exceeded.</exception>
		public NamedPipeServerStreamAdapter(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize)
			: this(new NamedPipeServerStream(pipeName, direction, maxNumberOfServerInstances, transmissionMode, options, inBufferSize, outBufferSize))
		{
		}

#if NET46
		/// <summary>Initializes a new instance of the <see cref="NamedPipeServerStreamAdapter" /> class with the specified pipe name, pipe direction, maximum number of server instances, transmission mode, pipe options, recommended in and out buffer sizes, and pipe security.</summary>
		/// <param name="pipeName">The name of the pipe.</param>
		/// <param name="direction">One of the enumeration values that determines the direction of the pipe.</param>
		/// <param name="maxNumberOfServerInstances">The maximum number of server instances that share the same name. You can pass <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" /> for this value.</param>
		/// <param name="transmissionMode">One of the enumeration values that determines the transmission mode of the pipe.</param>
		/// <param name="options">One of the enumeration values that determines how to open or create the pipe.</param>
		/// <param name="inBufferSize">A positive value greater than 0 that indicates the input buffer size.</param>
		/// <param name="outBufferSize">A positive value greater than 0 that indicates the output buffer size.</param>
		/// <param name="pipeSecurity">An object that determines the access control and audit security for the pipe.</param>
		/// <exception cref="ArgumentNullException">
		/// <paramref name="pipeName" /> is <see langword="null" />.</exception>
		/// <exception cref="ArgumentException">
		/// <paramref name="pipeName" /> is a zero-length string.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <paramref name="pipeName" /> is set to "anonymous".-or-
		/// <paramref name="direction" /> is not a valid <see cref="PipeDirection" /> value.-or-
		/// <paramref name="maxNumberOfServerInstances" />  is less than -1 or greater than 254 (-1 indicates <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" />)-or-
		/// <paramref name="options" /> is not a valid <see cref="PipeOptions" /> value.-or-
		/// <paramref name="inBufferSize" /> is negative.</exception>
		/// <exception cref="NotSupportedException">
		/// <paramref name="pipeName" /> contains a colon (":").</exception>
		/// <exception cref="PlatformNotSupportedException">The operating system is Windows Millennium Edition, Windows 98, or Windows 95, which are not supported.</exception>
		/// <exception cref="IOException">The maximum number of server instances has been exceeded.</exception>
		public NamedPipeServerStreamAdapter(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize, PipeSecurity pipeSecurity)
			: this(new NamedPipeServerStream(pipeName, direction, maxNumberOfServerInstances, transmissionMode, options, inBufferSize, outBufferSize, pipeSecurity))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="NamedPipeServerStreamAdapter" /> class with the specified pipe name, pipe direction, maximum number of server instances, transmission mode, pipe options, recommended in and out buffer sizes, pipe security, and inheritability mode.</summary>
		/// <param name="pipeName">The name of the pipe.</param>
		/// <param name="direction">One of the enumeration values that determines the direction of the pipe.</param>
		/// <param name="maxNumberOfServerInstances">The maximum number of server instances that share the same name. You can pass <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" /> for this value.</param>
		/// <param name="transmissionMode">One of the enumeration values that determines the transmission mode of the pipe.</param>
		/// <param name="options">One of the enumeration values that determines how to open or create the pipe.</param>
		/// <param name="inBufferSize">A positive value greater than 0 that indicates the input buffer size.</param>
		/// <param name="outBufferSize">A positive value greater than 0 that indicates the output buffer size.</param>
		/// <param name="pipeSecurity">An object that determines the access control and audit security for the pipe.</param>
		/// <param name="inheritability">One of the enumeration values that determines whether the underlying handle can be inherited by child processes.</param>
		/// <exception cref="ArgumentNullException">
		/// <paramref name="pipeName" /> is <see langword="null" />.</exception>
		/// <exception cref="ArgumentException">
		/// <paramref name="pipeName" /> is a zero-length string.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <paramref name="pipeName" /> is set to "anonymous".-or-
		/// <paramref name="direction" /> is not a valid <see cref="PipeDirection" /> value.-or-
		/// <paramref name="maxNumberofServerInstances" /> is less than -1 or greater than 254 (-1 indicates <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" />)-or-
		/// <paramref name="options" /> is not a valid <see cref="PipeOptions" /> value.-or-
		/// <paramref name="inBufferSize" /> is negative.-or-
		/// <paramref name="inheritability" /> is not a valid <see cref="HandleInheritability" /> value.</exception>
		/// <exception cref="NotSupportedException">
		/// <paramref name="pipeName" /> contains a colon (":").</exception>
		/// <exception cref="PlatformNotSupportedException">The operating system is Windows Millennium Edition, Windows 98, or Windows 95, which are not supported.</exception>
		/// <exception cref="IOException">The maximum number of server instances has been exceeded.</exception>
		public NamedPipeServerStreamAdapter(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize, PipeSecurity pipeSecurity, HandleInheritability inheritability)
			: this(new NamedPipeServerStream(pipeName, direction, maxNumberOfServerInstances, transmissionMode, options, inBufferSize, outBufferSize, pipeSecurity, inheritability))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="NamedPipeServerStreamAdapter" /> class with the specified pipe name, pipe direction, maximum number of server instances, transmission mode, pipe options, recommended in and out buffer sizes, pipe security, inheritability mode, and pipe access rights.</summary>
		/// <param name="pipeName">The name of the pipe.</param>
		/// <param name="direction">One of the enumeration values that determines the direction of the pipe.</param>
		/// <param name="maxNumberOfServerInstances">The maximum number of server instances that share the same name. You can pass <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" /> for this value.</param>
		/// <param name="transmissionMode">One of the enumeration values that determines the transmission mode of the pipe.</param>
		/// <param name="options">One of the enumeration values that determines how to open or create the pipe.</param>
		/// <param name="inBufferSize">The input buffer size.</param>
		/// <param name="outBufferSize">The output buffer size.</param>
		/// <param name="pipeSecurity">An object that determines the access control and audit security for the pipe.</param>
		/// <param name="inheritability">One of the enumeration values that determines whether the underlying handle can be inherited by child processes.</param>
		/// <param name="additionalAccessRights">One of the enumeration values that specifies the access rights of the pipe.</param>
		/// <exception cref="ArgumentNullException">
		/// <paramref name="pipeName" /> is <see langword="null" />.</exception>
		/// <exception cref="ArgumentException">
		/// <paramref name="pipeName" /> is a zero-length string.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <paramref name="pipeName" /> is set to "anonymous".-or-
		/// <paramref name="direction" /> is not a valid <see cref="PipeDirection" /> value.-or-
		/// <paramref name="maxNumberOfServerInstances" /> is less than -1 or greater than 254 (-1 indicates <see cref="F:System.IO.Pipes.NamedPipeServerStream.MaxAllowedServerInstances" />)-or-
		/// <paramref name="options" /> is not a valid <see cref="PipeOptions" /> value.-or-
		/// <paramref name="inBufferSize" /> is negative.-or-
		/// <paramref name="inheritability" /> is not a valid <see cref="HandleInheritability" /> value.-or-
		/// <paramref name="additionalAccessRights" /> is not a valid <see cref="PipeAccessRights" /> value.</exception>
		/// <exception cref="NotSupportedException">
		/// <paramref name="pipeName" /> contains a colon (":").</exception>
		/// <exception cref="PlatformNotSupportedException">The operating system is Windows Millennium Edition, Windows 98, or Windows 95, which are not supported.</exception>
		/// <exception cref="IOException">The maximum number of server instances has been exceeded.</exception>
		public NamedPipeServerStreamAdapter(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize, PipeSecurity pipeSecurity, HandleInheritability inheritability, PipeAccessRights additionalAccessRights)
			: this(new NamedPipeServerStream(pipeName, direction, maxNumberOfServerInstances, transmissionMode, options, inBufferSize, outBufferSize, pipeSecurity, inheritability, additionalAccessRights))
		{
		}
#endif

		/// <summary>Initializes a new instance of the <see cref="NamedPipeServerStream" /> class from the specified pipe handle.</summary>
		/// <param name="direction">One of the enumeration values that determines the direction of the pipe.</param>
		/// <param name="isAsync">
		/// <see langword="true" /> to indicate that the handle was opened asynchronously; otherwise, <see langword="false" />.</param>
		/// <param name="isConnected">
		/// <see langword="true" /> to indicate that the pipe is connected; otherwise, <see langword="false" />.</param>
		/// <param name="safePipeHandle">A safe handle for the pipe that this <see cref="NamedPipeServerStream" /> object will encapsulate.</param>
		/// <exception cref="ArgumentOutOfRangeException">
		/// <paramref name="direction" /> is not a valid <see cref="PipeDirection" /> value.</exception>
		/// <exception cref="ArgumentNullException">
		/// <paramref name="safePipeHandle" /> is <see langword="null" />.</exception>
		/// <exception cref="ArgumentException">
		/// <paramref name="safePipeHandle" /> is an invalid handle.</exception>
		/// <exception cref="IOException">
		/// <paramref name="safePipeHandle" /> is not a valid pipe handle.-or-The maximum number of server instances has been exceeded.</exception>
		public NamedPipeServerStreamAdapter(PipeDirection direction, bool isAsync, bool isConnected, SafePipeHandle safePipeHandle)
			: this(new NamedPipeServerStream(direction, isAsync, isConnected, safePipeHandle))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="NamedPipeServerStreamAdapter" /> class from the specified pipe handle.</summary>
		/// <param name="stream">Stream to use by the adapter.</param>
		public NamedPipeServerStreamAdapter([NotNull] NamedPipeServerStream stream)
			: base(stream)
		{
			Implementation = stream ?? throw new ArgumentNullException(nameof(stream));
		}

		/// <inheritdoc />
		public void WaitForConnection()
		{
			Implementation.WaitForConnection();
		}

		/// <inheritdoc />
		public Task WaitForConnectionAsync(CancellationToken cancellationToken)
		{
			return Implementation.WaitForConnectionAsync(cancellationToken);
		}

		/// <inheritdoc />
		public Task WaitForConnectionAsync()
		{
			return Implementation.WaitForConnectionAsync();
		}

		/// <inheritdoc />
		public void Disconnect()
		{
			Implementation.Disconnect();
		}

#if NET46
		/// <inheritdoc />
		public void RunAsClient(PipeStreamImpersonationWorker impersonationWorker)
		{
			Implementation.RunAsClient(impersonationWorker);
		}
#endif

		/// <inheritdoc />
		public string GetImpersonationUserName()
		{
			return Implementation.GetImpersonationUserName();
		}
	}
}
