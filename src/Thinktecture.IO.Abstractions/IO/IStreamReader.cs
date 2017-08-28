using System.IO;
using JetBrains.Annotations;
using Thinktecture.Text;

namespace Thinktecture.IO
{
	/// <summary>
	/// Implements a <see cref="T:System.IO.TextReader" /> that reads characters from a byte stream in a particular encoding.To browse the .NET Framework source code for this type, see the Reference Source.
	/// </summary>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface IStreamReader : ITextReader, IAbstraction<StreamReader>
	{
		/// <summary>Returns the underlying stream.</summary>
		/// <returns>The underlying stream.</returns>
		[NotNull]
		IStream BaseStream { get; }

		/// <summary>Gets the current character encoding that the current <see cref="T:System.IO.StreamReader" /> object is using.</summary>
		/// <returns>The current character encoding used by the current reader. The value can be different after the first call to any <see cref="ITextReader.Read()" /> method of <see cref="T:System.IO.StreamReader" />, since encoding autodetection is not done until the first call to a <see cref="ITextReader.Read()" /> method.</returns>
		[NotNull]
		IEncoding CurrentEncoding { get; }

		/// <summary>Gets a value that indicates whether the current stream position is at the end of the stream.</summary>
		/// <returns>true if the current stream position is at the end of the stream; otherwise false.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The underlying stream has been disposed.</exception>
		bool EndOfStream { get; }

		/// <summary>Clears the internal buffer.</summary>
		void DiscardBufferedData();
	}
}
