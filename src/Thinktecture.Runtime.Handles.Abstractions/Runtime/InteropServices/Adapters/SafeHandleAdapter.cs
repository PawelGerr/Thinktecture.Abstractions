using System;
using System.Runtime.InteropServices;
using JetBrains.Annotations;

namespace Thinktecture.Runtime.InteropServices.Adapters
{
	/// <summary>
	/// Adapter for <see cref="SafeHandle"/>.
	/// </summary>
	public class SafeHandleAdapter : AbstractionAdapter<SafeHandle>, ISafeHandle
	{
		/// <inheritdoc />
		public bool IsClosed => Implementation.IsClosed;

		/// <inheritdoc />
		public bool IsInvalid => Implementation.IsInvalid;

		/// <summary>
		/// Initializes a new instance of the <see cref="SafeHandleAdapter"/> class.
		/// </summary>
		/// <param name="handle">Handle to be use by the adapter.</param>
		public SafeHandleAdapter([NotNull] SafeHandle handle)
			: base(handle)
		{
		}

		/// <inheritdoc />
		public void DangerousAddRef(ref bool success)
		{
			Implementation.DangerousAddRef(ref success);
		}

		/// <inheritdoc />
		public IntPtr DangerousGetHandle()
		{
			return Implementation.DangerousGetHandle();
		}

		/// <inheritdoc />
		public void DangerousRelease()
		{
			Implementation.DangerousRelease();
		}

		/// <inheritdoc />
		public void SetHandleAsInvalid()
		{
			Implementation.SetHandleAsInvalid();
		}

		/// <inheritdoc />
		public void Dispose()
		{
			Implementation.Dispose();
		}
	}
}
