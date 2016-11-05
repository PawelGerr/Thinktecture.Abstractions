using Microsoft.Win32.SafeHandles;
using Thinktecture.Runtime.InteropServices;

namespace Thinktecture.Win32.SafeHandles
{
	/// <summary>
	/// Represents a wrapper class for a wait handle.
	/// </summary>
	public interface ISafeWaitHandle : ISafeHandle
	{
		/// <summary>
		/// Get inner instance of <see cref="SafeWaitHandle"/>.
		/// </summary>
		/// <returns>An instance of <see cref="SafeWaitHandle"/>.</returns>
		new SafeWaitHandle ToImplementation();

	}
}