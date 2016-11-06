using System;
using Microsoft.Win32.SafeHandles;
using Thinktecture.Runtime.InteropServices.Adapters;

namespace Thinktecture.Win32.SafeHandles.Adapters
{
	public class SafeFileHandleAdapter : SafeHandleAdapter, ISafeFileHandle
	{
		private readonly SafeFileHandle _handle;

		/// <summary>Initializes a new instance of the <see cref="T:Microsoft.Win32.SafeHandles.SafeFileHandle" /> class. </summary>
		/// <param name="preexistingHandle">An <see cref="T:System.IntPtr" /> object that represents the pre-existing handle to use.</param>
		/// <param name="ownsHandle">true to reliably release the handle during the finalization phase; false to prevent reliable release (not recommended).</param>
		public SafeFileHandleAdapter(IntPtr preexistingHandle, bool ownsHandle)
			: this(new SafeFileHandle(preexistingHandle, ownsHandle))
		{
		}

		public SafeFileHandleAdapter(SafeFileHandle handle)
			: base(handle)
		{
			if (handle == null)
				throw new ArgumentNullException(nameof(handle));

			_handle = handle;
		}

		/// <inheritdoc />
		SafeFileHandle ISafeFileHandle.ToImplementation()
		{
			return _handle;
		}
	}
}