using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Thinktecture.Text;

namespace Thinktecture.IO
{
	/// <summary>Implements a <see cref="T:System.IO.TextWriter" /> for writing information to a string. The information is stored in an underlying <see cref="T:System.Text.StringBuilder" />.</summary>
	/// <filterpriority>2</filterpriority>
	public interface IStringWriter : ITextWriter
	{
		/// <summary>
		/// Gets inner instance of <see cref="StringWriter"/>.
		/// It is not intended to be used directly. Use <see cref="StringWriterExtensions.ToImplementation"/> instead.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		new StringWriter UnsafeConvert();
		
		/// <summary>Returns the underlying <see cref="T:System.Text.StringBuilder" />.</summary>
		/// <returns>The underlying StringBuilder.</returns>
		/// <filterpriority>2</filterpriority>
		IStringBuilder GetStringBuilder();

		/// <summary>Returns a string containing the characters written to the current StringWriter so far.</summary>
		/// <returns>The string containing the characters written to the current StringWriter.</returns>
		/// <filterpriority>2</filterpriority>
		string ToString();
	}
}