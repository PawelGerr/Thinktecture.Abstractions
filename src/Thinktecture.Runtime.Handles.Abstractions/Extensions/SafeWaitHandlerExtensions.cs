using JetBrains.Annotations;
using Microsoft.Win32.SafeHandles;
using Thinktecture.Win32.SafeHandles;
using Thinktecture.Win32.SafeHandles.Adapters;

// ReSharper disable once CheckNamespace
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
		[CanBeNull]
		public static ISafeWaitHandle ToInterface([CanBeNull] this SafeWaitHandle handle)
		{
			return (handle == null) ? null : new SafeWaitHandleAdapter(handle);
		}

		/// <summary>
		/// Converts provided <see cref="ISafeWaitHandle"/> info to <see cref="SafeWaitHandle"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="ISafeWaitHandle"/> to convert.</param>
		/// <returns>An instance of <see cref="SafeWaitHandle"/>.</returns>
		[CanBeNull]
		public static SafeWaitHandle ToImplementation([CanBeNull] this ISafeWaitHandle abstraction)
		{
			return ((IAbstraction<SafeWaitHandle>)abstraction)?.UnsafeConvert();
		}
	}
}
