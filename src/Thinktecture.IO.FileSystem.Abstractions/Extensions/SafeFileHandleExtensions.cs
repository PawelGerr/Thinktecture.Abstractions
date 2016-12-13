using Microsoft.Win32.SafeHandles;
using Thinktecture.Win32.SafeHandles;
using Thinktecture.Win32.SafeHandles.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="SafeFileHandle"/>.
	/// </summary>
	public static class SafeFileHandleExtensions
	{
		/// <summary>
		/// Converts safe file handle to <see cref="ISafeFileHandle"/>.
		/// </summary>
		/// <param name="handle">Safe file handle to convert.</param>
		/// <returns>Converted safe file handle.</returns>
		public static ISafeFileHandle ToInterface(this SafeFileHandle handle)
		{
			return (handle == null) ? null : new SafeFileHandleAdapter(handle);
		}
	}
}