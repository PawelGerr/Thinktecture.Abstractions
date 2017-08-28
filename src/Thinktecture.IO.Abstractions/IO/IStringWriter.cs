using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Thinktecture.Text;

namespace Thinktecture.IO
{
	/// <summary>Implements a <see cref="T:System.IO.TextWriter" /> for writing information to a string. The information is stored in an underlying <see cref="T:System.Text.StringBuilder" />.</summary>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface IStringWriter : ITextWriter, IAbstraction<StringWriter>
	{
		/// <summary>Returns the underlying <see cref="T:System.Text.StringBuilder" />.</summary>
		/// <returns>The underlying StringBuilder.</returns>
		[NotNull]
		IStringBuilder GetStringBuilder();
	}
}
