using System;
using Microsoft.Win32.SafeHandles;
using Thinktecture.Runtime;

namespace Thinktecture.IO
{
	public class SafeFileHandleAdapter : SafeHandleAdapter, ISafeFileHandle
	{
		private readonly SafeFileHandle _handle;
		
		public SafeFileHandleAdapter(SafeFileHandle handle) 
			: base(handle)
		{
			if (handle == null)
				throw new ArgumentNullException(nameof(handle));

			_handle = handle;
		}

		/// <inheritdoc />
		SafeFileHandle ISafeFileHandle.ToImplementation()
		{
			return _handle;
		}
	}
}