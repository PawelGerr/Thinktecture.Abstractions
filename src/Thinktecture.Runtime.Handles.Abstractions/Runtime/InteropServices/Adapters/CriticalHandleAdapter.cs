using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Thinktecture.Runtime.InteropServices.Adapters
{
	/// <summary>
	/// Adapter for <see cref="CriticalHandle"/>.
	/// </summary>
	public class CriticalHandleAdapter : AbstractionAdapter, ICriticalHandle
	{
		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new CriticalHandle UnsafeConvert()
		{
			return _instance;
		}

		private readonly CriticalHandle _instance;

		/// <inheritdoc />
		public bool IsClosed => _instance.IsClosed;

		/// <inheritdoc />
		public bool IsInvalid => _instance.IsInvalid;

		/// <summary>
		/// Initializes a new instance of the <see cref="CriticalHandleAdapter"/> class.
		/// </summary>
		/// <param name="handle">Handle to be used by the adapter.</param>
		public CriticalHandleAdapter(CriticalHandle handle)
			: base(handle)
		{
			_instance = handle ?? throw new ArgumentNullException(nameof(handle));
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
	}
}