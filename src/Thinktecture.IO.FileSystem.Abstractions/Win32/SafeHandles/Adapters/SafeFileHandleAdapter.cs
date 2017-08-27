using System;
using System.ComponentModel;
using JetBrains.Annotations;
using Microsoft.Win32.SafeHandles;
using Thinktecture.Runtime.InteropServices.Adapters;

namespace Thinktecture.Win32.SafeHandles.Adapters
{
	/// <summary>
	/// Adapter for <see cref="SafeFileHandle"/>.
	/// </summary>
	public class SafeFileHandleAdapter : SafeHandleAdapter, ISafeFileHandle
	{
		/// <inheritdoc />
		[NotNull]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new SafeFileHandle UnsafeConvert()
		{
			return Implementation;
		}

		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		[NotNull]
		protected new SafeFileHandle Implementation { get; }

		/// <summary>Initializes a new instance of the <see cref="SafeFileHandleAdapter" /> class.</summary>
		/// <param name="preexistingHandle">An <see cref="T:System.IntPtr" /> object that represents the pre-existing handle to use.</param>
		/// <param name="ownsHandle">true to reliably release the handle during the finalization phase; false to prevent reliable release (not recommended).</param>
		public SafeFileHandleAdapter(IntPtr preexistingHandle, bool ownsHandle)
			: this(new SafeFileHandle(preexistingHandle, ownsHandle))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SafeFileHandleAdapter" /> class.
		/// </summary>
		/// <param name="handle">Handle to be used by the adapter.</param>
		public SafeFileHandleAdapter([NotNull] SafeFileHandle handle)
			: base(handle)
		{
			Implementation = handle ?? throw new ArgumentNullException(nameof(handle));
		}
	}
}
