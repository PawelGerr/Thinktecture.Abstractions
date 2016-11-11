using System;
using System.Runtime.InteropServices;
using Thinktecture.Runtime.InteropServices;
using Thinktecture.Runtime.InteropServices.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="SafeHandle"/>.
	/// </summary>
	public static class SafeHandleExtensions
	{
		/// <summary>
		/// Converts safe handle to <see cref="ISafeHandle"/>.
		/// </summary>
		/// <param name="handle"><see cref="SafeHandle"/> to convert</param>
		/// <returns>Instance of <see cref="ISafeHandle"/>.</returns>
		public static ISafeHandle ToInterface(this SafeHandle handle)
		{
			return (handle == null) ? null : new SafeHandleAdapter(handle);
		}
		
		/// <summary>
		/// Converts safe handle to <see cref="SafeHandle"/>.
		/// </summary>
		/// <param name="handle"><see cref="ISafeHandle"/> to convert</param>
		/// <returns>Instance of <see cref="SafeHandle"/>.</returns>
		public static SafeHandle ToImplementation(this ISafeHandle handle)
		{
			return handle?.UnsafeConvert();
		}
	}
}