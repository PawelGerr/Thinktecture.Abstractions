using System.ComponentModel;
using System.IO;

namespace Thinktecture.IO
{
	/// <summary>Creates a stream whose backing store is memory.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	/// <filterpriority>2</filterpriority>
	public interface IMemoryStream : IStream
	{
		/// <summary>
		/// Gets inner instance of <see cref="MemoryStream"/>.
		/// It is not intended to be used directly. Use <see cref="MemoryStreamExtensions.ToImplementation"/> instead.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		new MemoryStream UnsafeConvert();
		
		/// <summary>Gets or sets the number of bytes allocated for this stream.</summary>
		/// <returns>The length of the usable portion of the buffer for the stream.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">A capacity is set that is negative or less than the current length of the stream. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The current stream is closed. </exception>
		/// <exception cref="T:System.NotSupportedException">set is invoked on a stream whose capacity cannot be modified. </exception>
		/// <filterpriority>2</filterpriority>
		int Capacity { get; set; }
		
		/// <summary>Writes the stream contents to a byte array, regardless of the <see cref="P:System.IO.MemoryStream.Position" /> property.</summary>
		/// <returns>A new byte array.</returns>
		/// <filterpriority>2</filterpriority>
		byte[] ToArray();
		
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