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
		public SafeHandle InternalInstance { get; }

		/// <inheritdoc />
		public bool IsClosed => InternalInstance.IsClosed;

		/// <inheritdoc />
		public bool IsInvalid => InternalInstance.IsInvalid;

		/// <summary>
		/// Initializes a new instance of the <see cref="CriticalHandleAdapter"/> class.
		/// </summary>
		/// <param name="handle">Handle to be use by the adapter.</param>
		public SafeHandleAdapter(SafeHandle handle)
		{
			if (handle == null)
				throw new ArgumentNullException(nameof(handle));

			InternalInstance = handle;
		}
		
		/// <inheritdoc />
		public void DangerousAddRef(ref bool success)
		{
			InternalInstance.DangerousAddRef(ref success);
		}

		/// <inheritdoc />
		public IntPtr DangerousGetHandle()
		{
			return InternalInstance.DangerousGetHandle();
		}

		/// <inheritdoc />
		public void DangerousRelease()
		{
			InternalInstance.DangerousRelease();
		}

		/// <inheritdoc />
		public void SetHandleAsInvalid()
		{
			InternalInstance.SetHandleAsInvalid();
		}

		/// <inheritdoc />
		public void Dispose()
		{
			InternalInstance.Dispose();
		}

		/// <inheritdoc />
		public override string ToString()
		{
			return InternalInstance.ToString();
		}

		/// <inheritdoc />
		public override bool Equals(object obj)
		{
			return InternalInstance.Equals(obj);
		}

		/// <inheritdoc />
		public override int GetHashCode()
		{
			return InternalInstance.GetHashCode();
		}
	}
}