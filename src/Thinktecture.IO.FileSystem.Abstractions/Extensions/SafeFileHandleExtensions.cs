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

		/// <summary>
		/// Converts provided <see cref="ISafeFileHandle"/> info to <see cref="SafeFileHandle"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="ISafeFileHandle"/> to convert.</param>
		/// <returns>An instance of <see cref="SafeFileHandle"/>.</returns>
		public static SafeFileHandle ToImplementation(this ISafeFileHandle abstraction)
		{
			return ((IAbstraction<SafeFileHandle>) abstraction)?.UnsafeConvert();
		}
	}
}