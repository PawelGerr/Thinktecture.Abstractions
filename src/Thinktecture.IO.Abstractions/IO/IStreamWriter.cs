using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.IO
{
	/// <summary>
	/// Implements a <see cref="T:System.IO.TextWriter" /> for writing characters to a stream in a particular encoding.To browse the .NET Framework source code for this type, see the Reference Source.
	/// </summary>
	/// <filterpriority>1</filterpriority>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface IStreamWriter : ITextWriter, IAbstraction<StreamWriter>
	{
		/// <summary>Gets or sets a value indicating whether the <see cref="T:System.IO.StreamWriter" /> will flush its buffer to the underlying stream after every call to <see cref="M:System.IO.StreamWriter.Write(System.Char)" />.</summary>
		/// <returns>true to force <see cref="T:System.IO.StreamWriter" /> to flush its buffer; otherwise, false.</returns>
		/// <filterpriority>1</filterpriority>
		bool AutoFlush { get; set; }

		/// <summary>Gets the underlying stream that interfaces with a backing store.</summary>
		/// <returns>The stream this StreamWriter is writing to.</returns>
		/// <filterpriority>2</filterpriority>
		IStream BaseStream { get; }
	}
}