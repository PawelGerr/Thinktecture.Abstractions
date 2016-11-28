using System;
using System.Threading;
using Thinktecture.Threading;
using Thinktecture.Threading.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="WaitHandle"/>.
	/// </summary>
	public static class WaitHandleExtensions
	{
		/// <summary>
		/// Converts provided <see cref="WaitHandle"/> to <see cref="IWaitHandle"/>.
		/// </summary>
		/// <param name="handle"><see cref="WaitHandle"/> to convert.</param>
		/// <returns>An instance of <see cref="IWaitHandle"/>.</returns>
		public static IWaitHandle ToInterface(this WaitHandle handle)
		{
			return (handle == null) ? null : new WaitHandleAdapter(handle);
		}

		/// <summary>
		/// Converts provided <see cref="IWaitHandle"/> to <see cref="WaitHandle"/>.
		/// </summary>
		/// <param name="handle"><see cref="IWaitHandle"/> to convert.</param>
		/// <returns>An instance of <see cref="EventArgs"/>.</returns>
		public static WaitHandle ToImplementation(this IWaitHandle handle)
		{
			return handle?.UnsafeConvert();
		}
	}
}