using System.IO;
using JetBrains.Annotations;

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
