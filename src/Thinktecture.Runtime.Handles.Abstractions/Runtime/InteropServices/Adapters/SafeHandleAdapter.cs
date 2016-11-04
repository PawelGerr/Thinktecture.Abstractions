using System;
using System.Runtime.InteropServices;

namespace Thinktecture.Runtime.InteropServices.Adapters
{
	public class SafeHandleAdapter : ISafeHandle
	{
		private readonly SafeHandle _handle;

		/// <inheritdoc />
		public bool IsClosed => _handle.IsClosed;

		/// <inheritdoc />
		public bool IsInvalid => _handle.IsInvalid;

		public SafeHandleAdapter(SafeHandle handle)
		{
			if (handle == null)
				throw new ArgumentNullException(nameof(handle));

			_handle = handle;
		}

		/// <inheritdoc />
		public SafeHandle ToImplementation()
		{
			return _handle;
		}

		/// <inheritdoc />
		public void DangerousAddRef(ref bool success)
		{
			_handle.DangerousAddRef(ref success);
		}

		/// <inheritdoc />
		public IntPtr DangerousGetHandle()
		{
			return _handle.DangerousGetHandle();
		}

		/// <inheritdoc />
		public void DangerousRelease()
		{
			_handle.DangerousRelease();
		}

		/// <inheritdoc />
		public void SetHandleAsInvalid()
		{
			_handle.SetHandleAsInvalid();
		}

		/// <inheritdoc />
		public void Dispose()
		{
			_handle.Dispose();
		}
	}
}