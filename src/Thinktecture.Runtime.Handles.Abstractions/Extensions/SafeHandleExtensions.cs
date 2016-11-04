using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Thinktecture.Runtime
{
	public static class SafeHandleExtensions
	{
		/// <summary>
		/// Converts safe handle to <see cref="ISafeHandle"/>.
		/// </summary>
		/// <param name="handle"></param>
		/// <returns>Converted safe handle.</returns>
		public static ISafeHandle ToInterface(this SafeHandle handle)
		{
			return new SafeHandleAdapter(handle);
		}
	}
}