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
			return new SafeHandleAdapter(handle);
		}
	}
}