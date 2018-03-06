#if NET45 || NET462 || NETSTANDARD1_5 || NETSTANDARD2_0
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
