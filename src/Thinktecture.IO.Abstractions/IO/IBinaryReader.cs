using System;
using System.IO;
using JetBrains.Annotations;

namespace Thinktecture.IO
{
	/// <summary>Reads primitive data types as binary values in a specific encoding.</summary>
	public interface IBinaryReader : IAbstraction<BinaryReader>, IDisposable
	{
		/// <summary>Exposes access to the underlying stream of the <see cref="T:System.IO.BinaryReader" />.</summary>
		/// <returns>The underlying stream associated with the BinaryReader.</returns>

		[NotNull]
		IStream BaseStream { get; }

		/// <summary>Returns the next available character and does not advance the byte or character position.</summary>
		/// <returns>The next available character, or -1 if no more characters are available or the stream does not support seeking.</returns>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ArgumentException">The current character cannot be decoded into the internal character buffer by using the <see cref="T:System.Text.Encoding" /> selected for the stream.</exception>
		int PeekChar();

		/// <summary>Reads characters from the underlying stream and advances the current position of the stream in accordance with the Encoding used and the specific character being read from the stream.</summary>
		/// <returns>The next character from the input stream, or -1 if no characters are currently available.</returns>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		int Read();

		/// <summary>Reads the specified number of bytes from the stream, starting from a specified point in the byte array. </summary>
		/// <returns>The number of bytes read into <paramref name="buffer" />. This might be less than the number of bytes requested if that many bytes are not available, or it might be zero if the end of the stream is reached.</returns>
		/// <param name="buffer">The buffer to read data into. </param>
		/// <param name="index">The starting point in the buffer at which to begin reading into the buffer. </param>
		/// <param name="count">The number of bytes to read. </param>
		/// <exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. -or-The number of decoded characters to read is greater than <paramref name="count" />. This can happen if a Unicode decoder returns fallback characters or a surrogate pair.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="buffer" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="index" /> or <paramref name="count" /> is negative. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		int Read([NotNull] byte[] buffer, int index, int count);

		/// <summary>Reads the specified number of characters from the stream, starting from a specified point in the character array.</summary>
		/// <returns>The total number of characters read into the buffer. This might be less than the number of characters requested if that many characters are not currently available, or it might be zero if the end of the stream is reached.</returns>
		/// <param name="buffer">The buffer to read data into. </param>
		/// <param name="index">The starting point in the buffer at which to begin reading into the buffer. </param>
		/// <param name="count">The number of characters to read. </param>
		/// <exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. -or-The number of decoded characters to read is greater than <paramref name="count" />. This can happen if a Unicode decoder returns fallback characters or a surrogate pair.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="buffer" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="index" /> or <paramref name="count" /> is negative. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		int Read([NotNull] char[] buffer, int index, int count);

		/// <summary>Reads a Boolean value from the current stream and advances the current position of the stream by one byte.</summary>
		/// <returns>true if the byte is nonzero; otherwise, false.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		bool ReadBoolean();

		/// <summary>Reads the next byte from the current stream and advances the current position of the stream by one byte.</summary>
		/// <returns>The next byte read from the current stream.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		byte ReadByte();

		/// <summary>Reads the specified number of bytes from the current stream into a byte array and advances the current position by that number of bytes.</summary>
		/// <returns>A byte array containing data read from the underlying stream. This might be less than the number of bytes requested if the end of the stream is reached.</returns>
		/// <param name="count">The number of bytes to read. This value must be 0 or a non-negative number or an exception will occur.</param>
		/// <exception cref="T:System.ArgumentException">The number of decoded characters to read is greater than <paramref name="count" />. This can happen if a Unicode decoder returns fallback characters or a surrogate pair.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="count" /> is negative. </exception>
		[NotNull]
		byte[] ReadBytes(int count);

		/// <summary>Reads the next character from the current stream and advances the current position of the stream in accordance with the Encoding used and the specific character being read from the stream.</summary>
		/// <returns>A character read from the current stream.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ArgumentException">A surrogate character was read. </exception>
		char ReadChar();

		/// <summary>Reads the specified number of characters from the current stream, returns the data in a character array, and advances the current position in accordance with the Encoding used and the specific character being read from the stream.</summary>
		/// <returns>A character array containing data read from the underlying stream. This might be less than the number of characters requested if the end of the stream is reached.</returns>
		/// <param name="count">The number of characters to read. </param>
		/// <exception cref="T:System.ArgumentException">The number of decoded characters to read is greater than <paramref name="count" />. This can happen if a Unicode decoder returns fallback characters or a surrogate pair.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="count" /> is negative. </exception>
		[NotNull]
		char[] ReadChars(int count);

		/// <summary>Reads a decimal value from the current stream and advances the current position of the stream by sixteen bytes.</summary>
		/// <returns>A decimal value read from the current stream.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		decimal ReadDecimal();

		/// <summary>Reads an 8-byte floating point value from the current stream and advances the current position of the stream by eight bytes.</summary>
		/// <returns>An 8-byte floating point value read from the current stream.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		double ReadDouble();

		/// <summary>Reads a 2-byte signed integer from the current stream and advances the current position of the stream by two bytes.</summary>
		/// <returns>A 2-byte signed integer read from the current stream.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		short ReadInt16();

		/// <summary>Reads a 4-byte signed integer from the current stream and advances the current position of the stream by four bytes.</summary>
		/// <returns>A 4-byte signed integer read from the current stream.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		int ReadInt32();

		/// <summary>Reads an 8-byte signed integer from the current stream and advances the current position of the stream by eight bytes.</summary>
		/// <returns>An 8-byte signed integer read from the current stream.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		long ReadInt64();

		/// <summary>Reads a signed byte from this stream and advances the current position of the stream by one byte.</summary>
		/// <returns>A signed byte read from the current stream.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		sbyte ReadSByte();

		/// <summary>Reads a 4-byte floating point value from the current stream and advances the current position of the stream by four bytes.</summary>
		/// <returns>A 4-byte floating point value read from the current stream.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		float ReadSingle();

		/// <summary>Reads a string from the current stream. The string is prefixed with the length, encoded as an integer seven bits at a time.</summary>
		/// <returns>The string being read.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		[NotNull]
		string ReadString();

		/// <summary>Reads a 2-byte unsigned integer from the current stream using little-endian encoding and advances the position of the stream by two bytes.</summary>
		/// <returns>A 2-byte unsigned integer read from this stream.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		ushort ReadUInt16();

		/// <summary>Reads a 4-byte unsigned integer from the current stream and advances the position of the stream by four bytes.</summary>
		/// <returns>A 4-byte unsigned integer read from this stream.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		uint ReadUInt32();

		/// <summary>Reads an 8-byte unsigned integer from the current stream and advances the position of the stream by eight bytes.</summary>
		/// <returns>An 8-byte unsigned integer read from this stream.</returns>
		/// <exception cref="T:System.IO.EndOfStreamException">The end of the stream is reached. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
		ulong ReadUInt64();
	}
}
