using System;
using System.Runtime.InteropServices;
using Thinktecture.Runtime.InteropServices;
using Thinktecture.Runtime.InteropServices.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="CriticalHandle"/>.
	/// </summary>
	public static class CriticalHandleExtensions
	{
		/// <summary>
		/// Converts <see cref="CriticalHandle"/> to <see cref="ICriticalHandle"/>.
		/// </summary>
		/// <param name="handle"><see cref="CriticalHandle"/> to convert.</param>
		/// <returns>Instance of <see cref="ICriticalHandle"/>.</returns>
		public static ICriticalHandle ToInterface(this CriticalHandle handle)
		{
			return (handle == null) ? null : new CriticalHandleAdapter(handle);
		}
		
		/// <summary>
		/// Converts <see cref="ICriticalHandle"/> to <see cref="CriticalHandle"/>.
		/// </summary>
		/// <param name="handle"><see cref="ICriticalHandle"/> to convert.</param>
		/// <returns>Instance of <see cref="CriticalHandle"/>.</returns>
		public static CriticalHandle ToImplementation(this ICriticalHandle handle)
		{
			return handle?.InternalInstance;
		}
	}
}