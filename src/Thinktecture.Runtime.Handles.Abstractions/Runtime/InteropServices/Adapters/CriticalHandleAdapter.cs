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
		public CriticalHandle UnsafeConvert()
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
		{
			if (handle == null)
				throw new ArgumentNullException(nameof(handle));

			_instance = handle;
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