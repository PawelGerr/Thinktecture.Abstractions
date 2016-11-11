using System.ComponentModel;
using Microsoft.Win32.SafeHandles;
using Thinktecture.Runtime.InteropServices;

namespace Thinktecture.Win32.SafeHandles
{
	/// <summary>Represents a wrapper class for a file handle.</summary>
	public interface ISafeFileHandle : ISafeHandle
	{
		/// <summary>
		/// Gets inner instance of <see cref="SafeFileHandle"/>.
		/// It is not intended to be used directly. Use <see cref="SafeFileHandleExtensions.ToImplementation"/> instead.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		new SafeFileHandle UnsafeConvert();
	}
}