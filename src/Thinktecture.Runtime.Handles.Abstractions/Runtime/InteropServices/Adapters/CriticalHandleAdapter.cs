using System;
using System.Runtime.InteropServices;

namespace Thinktecture.Runtime.InteropServices.Adapters
{
	/// <summary>
	/// Adapter for <see cref="CriticalHandle"/>.
	/// </summary>
	public class CriticalHandleAdapter : ICriticalHandle
	{
		private readonly CriticalHandle _handle;

		/// <inheritdoc />
		public bool IsClosed => _handle.IsClosed;

		/// <inheritdoc />
		public bool IsInvalid => _handle.IsInvalid;

		/// <summary>
		/// Initializes a new instance of the <see cref="CriticalHandleAdapter"/> class.
		/// </summary>
		/// <param name="handle">Handle to be used by the adapter.</param>
		public CriticalHandleAdapter(CriticalHandle handle)
		{
			if (handle == null)
				throw new ArgumentNullException(nameof(handle));

			_handle = handle;
		}

		/// <inheritdoc />
		public CriticalHandle ToImplementation()
		{
			return _handle;
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