using System.Runtime.InteropServices;
using Thinktecture.Runtime.InteropServices;
using Thinktecture.Runtime.InteropServices.Adapters;

namespace Thinktecture
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