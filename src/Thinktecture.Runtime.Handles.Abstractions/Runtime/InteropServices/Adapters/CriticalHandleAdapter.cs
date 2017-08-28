using System;
using System.Runtime.InteropServices;
using JetBrains.Annotations;

namespace Thinktecture.Runtime.InteropServices.Adapters
{
	/// <summary>
	/// Adapter for <see cref="CriticalHandle"/>.
	/// </summary>
	public class CriticalHandleAdapter : AbstractionAdapter<CriticalHandle>, ICriticalHandle
	{
		/// <inheritdoc />
		public bool IsClosed => Implementation.IsClosed;

		/// <inheritdoc />
		public bool IsInvalid => Implementation.IsInvalid;

		/// <summary>
		/// Initializes a new instance of the <see cref="CriticalHandleAdapter"/> class.
		/// </summary>
		/// <param name="handle">Handle to be used by the adapter.</param>
		public CriticalHandleAdapter([NotNull] CriticalHandle handle)
			: base(handle)
		{
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
