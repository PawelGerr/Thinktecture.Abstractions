using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Thinktecture.Runtime.InteropServices.Adapters
{
	/// <summary>
	/// Adapter for <see cref="SafeHandle"/>.
	/// </summary>
	public class SafeHandleAdapter : ISafeHandle
	{
		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public SafeHandle UnsafeConvert()
		{
			return _instance;
		}

		private readonly SafeHandle _instance;

		/// <inheritdoc />
		public bool IsClosed => _instance.IsClosed;

		/// <inheritdoc />
		public bool IsInvalid => _instance.IsInvalid;

		/// <summary>
		/// Initializes a new instance of the <see cref="CriticalHandleAdapter"/> class.
		/// </summary>
		/// <param name="handle">Handle to be use by the adapter.</param>
		public SafeHandleAdapter(SafeHandle handle)
		{
			if (handle == null)
				throw new ArgumentNullException(nameof(handle));

			_instance = handle;
		}
		
		/// <inheritdoc />
		public void DangerousAddRef(ref bool success)
		{
			_instance.DangerousAddRef(ref success);
		}

		/// <inheritdoc />
		public IntPtr DangerousGetHandle()
		{
			return _instance.DangerousGetHandle();
		}

		/// <inheritdoc />
		public void DangerousRelease()
		{
			_instance.DangerousRelease();
		}

		/// <inheritdoc />
		public void SetHandleAsInvalid()
		{
			_instance.SetHandleAsInvalid();
		}

		/// <inheritdoc />
		public void Dispose()
		{
			_instance.Dispose();
		}

		/// <inheritdoc />
		public override string ToString()
		{
			return _instance.ToString();
		}

		/// <inheritdoc />
		public override bool Equals(object obj)
		{
			return _instance.Equals(obj);
		}

		/// <inheritdoc />
		public override int GetHashCode()
		{
			return _instance.GetHashCode();
		}
	}
}