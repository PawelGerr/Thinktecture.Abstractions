using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Thinktecture.IO
{
	/// <summary>
	/// Provides a <see cref="T:System.IO.Stream" /> for a file, supporting both synchronous and asynchronous read and write operations.To browse the .NET Framework source code for this type, see the Reference Source.
	/// </summary>
	/// <filterpriority>1</filterpriority>
	public interface IFileStream : IStream
    {
		/// <summary>
		/// Gets inner file stream.
		/// </summary>
		/// <returns>A file stream</returns>
	    new FileStream ToImplementation();

		/// <summary>Gets a value indicating whether the current stream supports reading.</summary>
		/// <returns>true if the stream supports reading; false if the stream is closed or was opened with write-only access.</returns>
		/// <filterpriority>1</filterpriority>
		new bool CanRead { get; }

		/// <summary>Gets a value indicating whether the current stream supports seeking.</summary>
		/// <returns>true if the stream supports seeking; false if the stream is closed or if the FileStream was constructed from an operating-system handle such as a pipe or output to the console.</returns>
		/// <filterpriority>2</filterpriority>
		new bool CanSeek { get; }

		/// <summary>Gets a value indicating whether the current stream supports writing.</summary>
		/// <returns>true if the stream supports writing; false if the stream is closed or was opened with read-only access.</returns>
		/// <filterpriority>1</filterpriority>
		new bool CanWrite { get; }

		/// <summary>Gets a value indicating whether the FileStream was opened asynchronously or synchronously.</summary>
		/// <returns>true if the FileStream was opened asynchronously; otherwise, false.</returns>
		/// <filterpriority>2</filterpriority>
		bool IsAsync { get; }

		/// <summary>Gets the length in bytes of the stream.</summary>
		/// <returns>A long value representing the length of the stream in bytes.</returns>
		/// <exception cref="T:System.NotSupportedException">
		/// <see cref="P:System.IO.FileStream.CanSeek" /> for this stream is false. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error, such as the file being closed, occurred. </exception>
		/// <filterpriority>1</filterpriority>
		new long Length { get; }

		/// <summary>Gets the name of the FileStream that was passed to the constructor.</summary>
		/// <returns>A string that is the name of the FileStream.</returns>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		string Name { get; }

		/// <summary>Gets or sets the current position of this stream.</summary>
		/// <returns>The current position of this stream.</returns>
		/// <exception cref="T:System.NotSupportedException">The stream does not support seeking. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. - or -The position was set to a very large value beyond the end of the stream in Windows 98 or earlier.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Attempted to set the position to a negative value. </exception>
		/// <exception cref="T:System.IO.EndOfStreamException">Attempted seeking past the end of a stream that does not support this. </exception>
		/// <filterpriority>1</filterpriority>
		new long Position { get; set; }

		/// <summary>Gets a <see cref="T:Microsoft.Win32.SafeHandles.SafeFileHandle" /> object that represents the operating system file handle for the file that the current <see cref="T:System.IO.FileStream" /> object encapsulates.</summary>
		/// <returns>An object that represents the operating system file handle for the file that the current <see cref="T:System.IO.FileStream" /> object encapsulates.</returns>
		/// <filterpriority>1</filterpriority>
		ISafeFileHandle SafeFileHandle { get; }

	    /// <summary>Clears buffers for this stream and causes any buffered data to be written to the file.</summary>
	    /// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
	    /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
	    /// <filterpriority>1</filterpriority>
	    new void Flush();

	    /// <summary>Clears buffers for this stream and causes any buffered data to be written to the file, and also clears all intermediate file buffers.</summary>
	    /// <param name="flushToDisk">true to flush all intermediate file buffers; otherwise, false. </param>
	    void Flush(bool flushToDisk);

	    /// <summary>Asynchronously clears all buffers for this stream, causes any buffered data to be written to the underlying device, and monitors cancellation requests. </summary>
	    /// <returns>A task that represents the asynchronous flush operation. </returns>
	    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
	    /// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
	    new Task FlushAsync(CancellationToken cancellationToken);

	    /// <summary>Reads a block of bytes from the stream and writes the data in a given buffer.</summary>
	    /// <returns>The total number of bytes read into the buffer. This might be less than the number of bytes requested if that number of bytes are not currently available, or zero if the end of the stream is reached.</returns>
	    /// <param name="array">When this method returns, contains the specified byte array with the values between <paramref name="offset" /> and (<paramref name="offset" /> + <paramref name="count" /> - 1<paramref name=")" /> replaced by the bytes read from the current source. </param>
	    /// <param name="offset">The byte offset in <paramref name="array" /> at which the read bytes will be placed. </param>
	    /// <param name="count">The maximum number of bytes to read. </param>
	    /// <exception cref="T:System.ArgumentNullException">
	    /// <paramref name="array" /> is null. </exception>
	    /// <exception cref="T:System.ArgumentOutOfRangeException">
	    /// <paramref name="offset" /> or <paramref name="count" /> is negative. </exception>
	    /// <exception cref="T:System.NotSupportedException">The stream does not support reading. </exception>
	    /// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
	    /// <exception cref="T:System.ArgumentException">
	    /// <paramref name="offset" /> and <paramref name="count" /> describe an invalid range in <paramref name="array" />. </exception>
	    /// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception>
	    /// <filterpriority>1</filterpriority>
	    new int Read(byte[] array, int offset, int count);

	    /// <summary>Asynchronously reads a sequence of bytes from the current stream, advances the position within the stream by the number of bytes read, and monitors cancellation requests.</summary>
	    /// <returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result value can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the stream has been reached. </returns>
	    /// <param name="buffer">The buffer to write the data into.</param>
	    /// <param name="offset">The byte offset in <paramref name="buffer" /> at which to begin writing data from the stream.</param>
	    /// <param name="count">The maximum number of bytes to read.</param>
	    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
	    /// <exception cref="T:System.ArgumentNullException">
	    /// <paramref name="buffer" /> is null.</exception>
	    /// <exception cref="T:System.ArgumentOutOfRangeException">
	    /// <paramref name="offset" /> or <paramref name="count" /> is negative.</exception>
	    /// <exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception>
	    /// <exception cref="T:System.NotSupportedException">The stream does not support reading.</exception>
	    /// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
	    /// <exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous read operation. </exception>
	    new Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);

	    /// <summary>Reads a byte from the file and advances the read position one byte.</summary>
	    /// <returns>The byte, cast to an <see cref="T:System.Int32" />, or -1 if the end of the stream has been reached.</returns>
	    /// <exception cref="T:System.NotSupportedException">The current stream does not support reading. </exception>
	    /// <exception cref="T:System.ObjectDisposedException">The current stream is closed. </exception>
	    /// <filterpriority>1</filterpriority>
	    new int ReadByte();

	    /// <summary>Sets the current position of this stream to the given value.</summary>
	    /// <returns>The new position in the stream.</returns>
	    /// <param name="offset">The point relative to <paramref name="origin" /> from which to begin seeking. </param>
	    /// <param name="origin">Specifies the beginning, the end, or the current position as a reference point for <paramref name="offset" />, using a value of type <see cref="T:System.IO.SeekOrigin" />. </param>
	    /// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
	    /// <exception cref="T:System.NotSupportedException">The stream does not support seeking, such as if the FileStream is constructed from a pipe or console output. </exception>
	    /// <exception cref="T:System.ArgumentException">Seeking is attempted before the beginning of the stream. </exception>
	    /// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception>
	    /// <filterpriority>1</filterpriority>
	    new long Seek(long offset, SeekOrigin origin);

	    /// <summary>Sets the length of this stream to the given value.</summary>
	    /// <param name="value">The new length of the stream. </param>
	    /// <exception cref="T:System.IO.IOException">An I/O error has occurred. </exception>
	    /// <exception cref="T:System.NotSupportedException">The stream does not support both writing and seeking. </exception>
	    /// <exception cref="T:System.ArgumentOutOfRangeException">Attempted to set the <paramref name="value" /> parameter to less than 0. </exception>
	    /// <filterpriority>2</filterpriority>
	    new void SetLength(long value);

	    /// <summary>Writes a block of bytes to the file stream.</summary>
	    /// <param name="array">The buffer containing data to write to the stream.</param>
	    /// <param name="offset">The zero-based byte offset in <paramref name="array" /> from which to begin copying bytes to the stream. </param>
	    /// <param name="count">The maximum number of bytes to write. </param>
	    /// <exception cref="T:System.ArgumentNullException">
	    /// <paramref name="array" /> is null. </exception>
	    /// <exception cref="T:System.ArgumentException">
	    /// <paramref name="offset" /> and <paramref name="count" /> describe an invalid range in <paramref name="array" />. </exception>
	    /// <exception cref="T:System.ArgumentOutOfRangeException">
	    /// <paramref name="offset" /> or <paramref name="count" /> is negative. </exception>
	    /// <exception cref="T:System.IO.IOException">An I/O error occurred. - or -Another thread may have caused an unexpected change in the position of the operating system's file handle. </exception>
	    /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
	    /// <exception cref="T:System.NotSupportedException">The current stream instance does not support writing. </exception>
	    /// <filterpriority>1</filterpriority>
	    new void Write(byte[] array, int offset, int count);

	    /// <summary>Asynchronously writes a sequence of bytes to the current stream, advances the current position within this stream by the number of bytes written, and monitors cancellation requests. </summary>
	    /// <returns>A task that represents the asynchronous write operation.</returns>
	    /// <param name="buffer">The buffer to write data from. </param>
	    /// <param name="offset">The zero-based byte offset in <paramref name="buffer" /> from which to begin copying bytes to the stream.</param>
	    /// <param name="count">The maximum number of bytes to write.</param>
	    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
	    /// <exception cref="T:System.ArgumentNullException">
	    /// <paramref name="buffer" /> is null.</exception>
	    /// <exception cref="T:System.ArgumentOutOfRangeException">
	    /// <paramref name="offset" /> or <paramref name="count" /> is negative.</exception>
	    /// <exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception>
	    /// <exception cref="T:System.NotSupportedException">The stream does not support writing.</exception>
	    /// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
	    /// <exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous write operation. </exception>
	    new Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);

	    /// <summary>Writes a byte to the current position in the file stream.</summary>
	    /// <param name="value">A byte to write to the stream. </param>
	    /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
	    /// <exception cref="T:System.NotSupportedException">The stream does not support writing. </exception>
	    /// <filterpriority>1</filterpriority>
	    new void WriteByte(byte value);
    }
}
