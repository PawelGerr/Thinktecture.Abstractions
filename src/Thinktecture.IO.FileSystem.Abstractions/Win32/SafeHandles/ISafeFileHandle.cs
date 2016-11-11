using System.ComponentModel;
using Microsoft.Win32.SafeHandles;
using Thinktecture.Runtime.InteropServices;

namespace Thinktecture.Win32.SafeHandles
{
	/// <summary>Represents a wrapper class for a file handle. </summary>
	public interface ISafeFileHandle : ISafeHandle
	{
		/// <summary>
		/// Gets inner instance of <see cref="SafeFileHandle"/>.
		/// It is not intended to be used directly. Use <see cref="SafeFileHandleExtensions.ToImplementation"/> instead.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		new SafeFileHandle UnsafeConvert();

		/// <summary>When overridden in a derived class, gets a value indicating whether the handle value is invalid.</summary>
		/// <returns>true if the handle value is invalid; otherwise, false.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		new bool IsInvalid { get; }
	}
}