using System.ComponentModel;
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
		/// Gets inner instance of <see cref="SafeWaitHandle"/>.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		new SafeWaitHandle InternalInstance { get; }
	}
}