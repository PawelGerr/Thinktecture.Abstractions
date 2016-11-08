using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Thinktecture.Runtime.InteropServices.Adapters
{
	/// <summary>
	/// Adapter for <see cref="CriticalHandle"/>.
	/// </summary>
	public class CriticalHandleAdapter : ICriticalHandle
	{
		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public CriticalHandle InternalInstance { get; }

		/// <inheritdoc />
		public bool IsClosed => InternalInstance.IsClosed;

		/// <inheritdoc />
		public bool IsInvalid => InternalInstance.IsInvalid;

		/// <summary>
		/// Initializes a new instance of the <see cref="CriticalHandleAdapter"/> class.
		/// </summary>
		/// <param name="handle">Handle to be used by the adapter.</param>
		public CriticalHandleAdapter(CriticalHandle handle)
		{
			if (handle == null)
				throw new ArgumentNullException(nameof(handle));

			InternalInstance = handle;
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
	}
}