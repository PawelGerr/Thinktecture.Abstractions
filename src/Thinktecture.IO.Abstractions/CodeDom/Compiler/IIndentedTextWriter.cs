#if NET45 || NET462 || NETSTANDARD2_0

using System.CodeDom.Compiler;
using System.IO;
using Thinktecture.IO;

namespace Thinktecture.CodeDom.Compiler
{
	/// <summary>Provides a text writer that can indent new lines by a tab string token.</summary>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface IIndentedTextWriter: IAbstraction<IndentedTextWriter>, ITextWriter
	{
		/// <summary>Gets or sets the number of spaces to indent.</summary>
		/// <returns>The number of spaces to indent.</returns>
		int Indent { get; set; }

		/// <summary>Gets the <see cref="T:System.IO.TextWriter" /> to use.</summary>
		/// <returns>The <see cref="T:System.IO.TextWriter" /> to use.</returns>
		TextWriter InnerWriter { get; }

		/// <summary>Writes the specified string to a line without tabs.</summary>
		/// <param name="s">The string to write. </param>
		void WriteLineNoTabs(string s);
	}
}

#endif
