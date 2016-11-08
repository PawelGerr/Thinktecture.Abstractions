using System;
using Microsoft.Win32.SafeHandles;
using Thinktecture.Win32.SafeHandles;
using Thinktecture.Win32.SafeHandles.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="SafeWaitHandle"/>.
	/// </summary>
	public static class SafeWaitHandlerExtensions
	{
		/// <summary>
		/// Converts <see cref="SafeWaitHandle"/> to <see cref="ISafeWaitHandle"/>.
		/// </summary>
		/// <param name="handle"><see cref="SafeWaitHandle"/> to convert.</param>
		/// <returns>Instance of <see cref="ISafeWaitHandle"/>.</returns>
		public static ISafeWaitHandle ToInterface(this SafeWaitHandle handle)
		{
			return (handle == null) ? null : new SafeWaitHandleAdapter(handle);
		}

		/// <summary>
		/// Converts <see cref="ISafeWaitHandle"/> to <see cref="SafeWaitHandle"/>.
		/// </summary>
		/// <param name="handle"><see cref="ISafeWaitHandle"/> to convert.</param>
		/// <returns>Instance of <see cref="SafeWaitHandle"/>.</returns>
		public static SafeWaitHandle ToImplementation(this ISafeWaitHandle handle)
		{
			return handle?.InternalInstance;
		}
	}
}