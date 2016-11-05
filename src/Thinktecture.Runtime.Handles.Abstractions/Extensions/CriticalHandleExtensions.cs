using System.Runtime.InteropServices;
using Thinktecture.Runtime.InteropServices;
using Thinktecture.Runtime.InteropServices.Adapters;

namespace Thinktecture
{
	public static class CriticalHandleExtensions
	{
		/// <summary>
		/// Converts <see cref="CriticalHandle"/> to <see cref="ICriticalHandle"/>.
		/// </summary>
		/// <param name="handle"><see cref="CriticalHandle"/> to convert.</param>
		/// <returns>Instance of <see cref="ICriticalHandle"/>.</returns>
		public static ICriticalHandle ToInterface(this CriticalHandle handle)
		{
			return new CriticalHandleAdapter(handle);
		}
	}
}