using System.IO;

namespace Thinktecture.IO
{
	/// <summary>Adds a buffering layer to read and write operations on another stream. This class cannot be inherited.</summary>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface IBufferedStream : IStream, IAbstraction<BufferedStream>
	{
		/// <summary>
		/// Underlying stream.
		/// </summary>
		Stream UnderlyingStream { get; }

		/// <summary>
		/// Buffer size.
		/// </summary>
		long BufferSize { get; }
	}
}
