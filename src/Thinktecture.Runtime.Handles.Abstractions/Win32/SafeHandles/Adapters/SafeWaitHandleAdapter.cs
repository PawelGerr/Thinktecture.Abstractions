using System;
using Microsoft.Win32.SafeHandles;
using Thinktecture.Runtime.InteropServices.Adapters;

namespace Thinktecture.Win32.SafeHandles.Adapters
{
	public class SafeWaitHandleAdapter : SafeHandleAdapter, ISafeWaitHandle
	{
		private readonly SafeWaitHandle _handle;

		public SafeWaitHandleAdapter(SafeWaitHandle handle)
			: base(handle)
		{
			if (handle == null)
				throw new ArgumentNullException(nameof(handle));

			_handle = handle;
		}

		/// <inheritdoc />
		SafeWaitHandle ISafeWaitHandle.ToImplementation()
		{
			return _handle;
		}
	}
}