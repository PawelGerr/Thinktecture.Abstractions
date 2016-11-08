using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Thinktecture.IO
{
	/// <summary>Creates a stream whose backing store is memory.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	/// <filterpriority>2</filterpriority>
	public interface IMemoryStream : IStream
	{
		/// <summary>
		/// Gets inner instance of <see cref="MemoryStream"/>.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		new MemoryStream InternalInstance { get; }

		/// <summary>Gets a value indicating whether the current stream supports reading.</summary>
		/// <returns>true if the stream is open.</returns>
		/// <filterpriority>2</filterpriority>
		new bool CanRead { get; }

		/// <summary>Gets a value indicating whether the current stream supports seeking.</summary>
		/// <returns>true if the stream is open.</returns>
		/// <filterpriority>2</filterpriority>
		new bool CanSeek { get; }

		/// <summary>Gets a value indicating whether the current stream supports writing.</summary>
		/// <returns>true if the stream supports writing; otherwise, false.</returns>
		/// <filterpriority>2</filterpriority>
		new bool CanWrite { get; }

		/// <summary>Gets or sets the number of bytes allocated for this stream.</summary>
		/// <returns>The length of the usable portion of the buffer for the stream.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">A capacity is set that is negative or less than the current length of the stream. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The current stream is closed. </exception>
		/// <exception cref="T:System.NotSupportedException">set is invoked on a stream whose capacity cannot be modified. </exception>
		/// <filterpriority>2</filterpriority>
		int Capacity { get; set; }

		/// <summary>Gets the length of the stream in bytes.</summary>
		/// <returns>The length of the stream in bytes.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <filterpriority>2</filterpriority>
		new long Length { get; }

		/// <summary>Gets or sets the current position within the stream.</summary>
		/// <returns>The current position within the stream.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The position is set to a negative value or a value greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <filterpriority>2</filterpriority>
		new long Position { get; set; }

		/// <summary>Overrides the <see cref="M:System.IO.Stream.Flush" /> method so that no action is performed.</summary>
		/// <filterpriority>2</filterpriority>
		new void Flush();

		/// <summary>Asynchronously clears all buffers for this stream, and monitors cancellation requests.</summary>
		/// <returns>A task that represents the asynchronous flush operation.</returns>
		/// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
		/// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
		new Task FlushAsync(CancellationToken cancellationToken);

		/// <summary>Reads a block of bytes from the current stream and writes the data to a buffer.</summary>
		/// <returns>The total number of bytes written into the buffer. This can be less than the number of bytes requested if that number of bytes are not currently available, or zero if the end of the stream is reached before any bytes are read.</returns>
		/// <param name="buffer">When this method returns, contains the specified byte array with the values between <paramref name="offset" /> and (<paramref name="offset" /> + <paramref name="count" /> - 1) replaced by the characters read from the current stream. </param>
		/// <param name="offset">The zero-based byte offset in <paramref name="buffer" /> at which to begin storing data from the current stream.</param>
		/// <param name="count">The maximum number of bytes to read. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="buffer" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="offset" /> or <paramref name="count" /> is negative. </exception>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="offset" /> subtracted from the buffer length is less than <paramref name="count" />. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The current stream instance is closed. </exception>
		/// <filterpriority>2</filterpriority>
		new int Read(byte[] buffer, int offset, int count);

#pragma warning disable 1584
		/// <summary>Asynchronously reads a sequence of bytes from the current stream, advances the position within the stream by the number of bytes read, and monitors cancellation requests.</summary>
		/// <returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result value can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the stream has been reached. </returns>
		/// <param name="buffer">The buffer to write the data into.</param>
		/// <param name="offset">The byte offset in <paramref name="buffer" /> at which to begin writing data from the stream.</param>
		/// <param name="count">The maximum number of bytes to read.</param>
		/// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="buffer" /> is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="offset" /> or <paramref name="count" /> is negative.</exception>
		/// <exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception>
		/// <exception cref="T:System.NotSupportedException">The stream does not support reading.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous read operation. </exception>
		new Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
#pragma warning restore 1584

		/// <summary>Reads a byte from the current stream.</summary>
		/// <returns>The byte cast to a <see cref="T:System.Int32" />, or -1 if the end of the stream has been reached.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The current stream instance is closed. </exception>
		/// <filterpriority>2</filterpriority>
		new int ReadByte();

		/// <summary>Sets the position within the current stream to the specified value.</summary>
		/// <returns>The new position within the stream, calculated by combining the initial reference point and the offset.</returns>
		/// <param name="offset">The new position within the stream. This is relative to the <paramref name="loc" /> parameter, and can be positive or negative. </param>
		/// <param name="loc">A value of type <see cref="T:System.IO.SeekOrigin" />, which acts as the seek reference point. </param>
		/// <exception cref="T:System.IO.IOException">Seeking is attempted before the beginning of the stream. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="offset" /> is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		/// <exception cref="T:System.ArgumentException">There is an invalid <see cref="T:System.IO.SeekOrigin" />. -or-<paramref name="offset" /> caused an arithmetic overflow.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The current stream instance is closed. </exception>
		/// <filterpriority>2</filterpriority>
		new long Seek(long offset, SeekOrigin loc);

		/// <summary>Sets the length of the current stream to the specified value.</summary>
		/// <param name="value">The value at which to set the length. </param>
		/// <exception cref="T:System.NotSupportedException">The current stream is not resizable and <paramref name="value" /> is larger than the current capacity.-or- The current stream does not support writing. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="value" /> is negative or is greater than the maximum length of the <see cref="T:System.IO.MemoryStream" />, where the maximum length is(<see cref="F:System.Int32.MaxValue" /> - origin), and origin is the index into the underlying buffer at which the stream starts. </exception>
		/// <filterpriority>2</filterpriority>
		new void SetLength(long value);

		/// <summary>Writes the stream contents to a byte array, regardless of the <see cref="P:System.IO.MemoryStream.Position" /> property.</summary>
		/// <returns>A new byte array.</returns>
		/// <filterpriority>2</filterpriority>
		byte[] ToArray();

		/// <summary>Writes a block of bytes to the current stream using data read from a buffer.</summary>
		/// <param name="buffer">The buffer to write data from. </param>
		/// <param name="offset">The zero-based byte offset in <paramref name="buffer" /> at which to begin copying bytes to the current stream.</param>
		/// <param name="count">The maximum number of bytes to write. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="buffer" /> is null. </exception>
		/// <exception cref="T:System.NotSupportedException">The stream does not support writing. For additional information see <see cref="P:System.IO.Stream.CanWrite" />.-or- The current position is closer than <paramref name="count" /> bytes to the end of the stream, and the capacity cannot be modified. </exception>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="offset" /> subtracted from the buffer length is less than <paramref name="count" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="offset" /> or <paramref name="count" /> are negative. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The current stream instance is closed. </exception>
		/// <filterpriority>2</filterpriority>
		new void Write(byte[] buffer, int offset, int count);

		/// <summary>Asynchronously writes a sequence of bytes to the current stream, advances the current position within this stream by the number of bytes written, and monitors cancellation requests.</summary>
		/// <returns>A task that represents the asynchronous write operation.</returns>
		/// <param name="buffer">The buffer to write data from.</param>
		/// <param name="offset">The zero-based byte offset in <paramref name="buffer" /> from which to begin copying bytes to the stream.</param>
		/// <param name="count">The maximum number of bytes to write.</param>
		/// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="buffer" /> is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="offset" /> or <paramref name="count" /> is negative.</exception>
		/// <exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception>
		/// <exception cref="T:System.NotSupportedException">The stream does not support writing.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous write operation. </exception>
		new Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);

		/// <summary>Writes a byte to the current stream at the current position.</summary>
		/// <param name="value">The byte to write. </param>
		/// <exception cref="T:System.NotSupportedException">The stream does not support writing. For additional information see <see cref="P:System.IO.Stream.CanWrite" />.-or- The current position is at the end of the stream, and the capacity cannot be modified. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The current stream is closed. </exception>
		/// <filterpriority>2</filterpriority>
		new void WriteByte(byte value);

		/// <summary>Writes the entire contents of this memory stream to another stream.</summary>
		/// <param name="stream">The stream to write this memory stream to. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> is null. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The current or target stream is closed. </exception>
		/// <filterpriority>2</filterpriority>
		void WriteTo(IStream stream);

		/// <summary>Writes the entire contents of this memory stream to another stream.</summary>
		/// <param name="stream">The stream to write this memory stream to. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> is null. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The current or target stream is closed. </exception>
		/// <filterpriority>2</filterpriority>
		void WriteTo(Stream stream);
	}
}