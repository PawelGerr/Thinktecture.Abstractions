using System.IO;

namespace Thinktecture.IO
{
	/// <summary>Implements a <see cref="T:System.IO.TextReader" /> that reads from a string.</summary>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface IStringReader : ITextReader, IAbstraction<StringReader>
	{
	}
}
