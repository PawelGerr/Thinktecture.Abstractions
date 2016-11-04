using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace Thinktecture.IO
{
	public static class SafeFileHandleExtensions
	{
		/// <summary>
		/// Converts safe file handle to <see cref="ISafeFileHandle"/>.
		/// </summary>
		/// <param name="handle">Safe file handle to convert.</param>
		/// <returns>Converted safe file handle.</returns>
		public static ISafeFileHandle ToInterface(this SafeFileHandle handle)
		{
			return new SafeFileHandleAdapter(handle);
		}
	}
}