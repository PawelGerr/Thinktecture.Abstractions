using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;

namespace Thinktecture.IO
{
	/// <summary>Implements a <see cref="T:System.IO.TextReader" /> that reads from a string.</summary>
	/// <filterpriority>2</filterpriority>
	public interface IStringReader : ITextReader
	{
		/// <summary>
		/// Gets inner instance of <see cref="StringReader"/>.
		/// It is not intended to be used directly. Use <see cref="StringReaderExtensions.ToImplementation"/> instead.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		new StringReader UnsafeConvert();
	}
}