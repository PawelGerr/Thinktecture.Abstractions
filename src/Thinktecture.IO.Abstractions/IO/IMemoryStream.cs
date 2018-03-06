using System.IO;
using JetBrains.Annotations;

#if NET462 || NETSTANDARD1_3 || NETSTANDARD1_5 || NETSTANDARD2_0
using System;
#endif

namespace Thinktecture.IO
{
	/// <summary>Creates a stream whose backing store is memory.To browse the .NET Framework source code for this type, see the Reference Source.</summary>

	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface IMemoryStream : IStream, IAbstraction<MemoryStream>
	{
		/// <summary>Gets or sets the number of bytes allocated for this stream.</summary>
		/// <returns>The length of the usable portion of the buffer for the stream.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">A capacity is set that is negative or less than the current length of the stream. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The current stream is closed. </exception>
		/// <exception cref="T:System.NotSupportedException">set is invoked on a stream whose capacity cannot be modified. </exception>

		int Capacity { get; set; }

		/// <summary>Writes the stream contents to a byte array, regardless of the <see cref="P:System.IO.MemoryStream.Position" /> property.</summary>
		/// <returns>A new byte array.</returns>
		[NotNull]
		byte[] ToArray();

#if NET45 ||NET462 || NETSTANDARD2_0
		/// <summary>Returns the array of unsigned bytes from which this stream was created.</summary>
		/// <returns>The byte array from which this stream was created, or the underlying array if a byte array was not provided to the <see cref="T:System.IO.MemoryStream" /> constructor during construction of the current instance.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">The MemoryStream instance was not created with a publicly visible buffer. </exception>
		/// <filterpriority>2</filterpriority>
		byte[] GetBuffer();
#endif

#if NET462 || NETSTANDARD1_3 || NETSTANDARD1_5 || NETSTANDARD2_0
		/// <summary>Returns the array of unsigned bytes from which this stream was created. The return value indicates whether the conversion succeeded.</summary>
		/// <returns>true if the conversion was successful; otherwise, false.</returns>
		/// <param name="buffer">The byte array segment from which this stream was created.</param>
		bool TryGetBuffer(out ArraySegment<byte> buffer);
#endif

		/// <summary>Writes the entire contents of this memory stream to another stream.</summary>
		/// <param name="stream">The stream to write this memory stream to. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> is null. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The current or target stream is closed. </exception>
		void WriteTo([NotNull] IStream stream);

		/// <summary>Writes the entire contents of this memory stream to another stream.</summary>
		/// <param name="stream">The stream to write this memory stream to. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="stream" /> is null. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The current or target stream is closed. </exception>
		void WriteTo([NotNull] Stream stream);
	}
}
