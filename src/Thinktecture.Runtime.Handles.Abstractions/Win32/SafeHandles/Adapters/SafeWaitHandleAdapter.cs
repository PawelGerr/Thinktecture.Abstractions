using System;
using System.ComponentModel;
using Microsoft.Win32.SafeHandles;
using Thinktecture.Runtime.InteropServices.Adapters;

namespace Thinktecture.Win32.SafeHandles.Adapters
{
	/// <summary>
	/// Adapter for <see cref="SafeWaitHandle"/>.
	/// </summary>
	public class SafeWaitHandleAdapter : SafeHandleAdapter, ISafeWaitHandle
	{
		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new SafeWaitHandle UnsafeConvert()
		{
			return _instance;
		}

		private readonly SafeWaitHandle _instance;

		/// <summary>Initializes a new instance of the <see cref="SafeWaitHandleAdapter" /> class. </summary>
		/// <param name="existingHandle">An <see cref="T:System.IntPtr" /> object that represents the pre-existing handle to use.</param>
		/// <param name="ownsHandle">true to reliably release the handle during the finalization phase; false to prevent reliable release (not recommended).</param>
		public SafeWaitHandleAdapter(IntPtr existingHandle, bool ownsHandle)
			: this(new SafeWaitHandle(existingHandle, ownsHandle))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SafeWaitHandleAdapter" /> class.
		/// </summary>
		/// <param name="handle">Handle to be used by the adapter.</param>
		public SafeWaitHandleAdapter(SafeWaitHandle handle)
			: base(handle)
		{
			if (handle == null)
				throw new ArgumentNullException(nameof(handle));

			_instance = handle;
		}
	}
}