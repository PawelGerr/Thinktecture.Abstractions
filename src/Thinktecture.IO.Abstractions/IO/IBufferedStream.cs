#if NETSTANDARD1_5
using System.IO;

namespace Thinktecture.IO
{
	/// <summary>Adds a buffering layer to read and write operations on another stream. This class cannot be inherited.</summary>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface IBufferedStream : IStream, IAbstraction<BufferedStream>
	{
	}
}
#endif
