using Microsoft.Win32.SafeHandles;
using Thinktecture.Runtime.InteropServices;

namespace Thinktecture.Win32.SafeHandles
{
	/// <summary>Represents a wrapper class for a file handle. </summary>
	public interface ISafeFileHandle : ISafeHandle
	{
		/// <summary>
		/// Get inner safe file handle.
		/// </summary>
		/// <returns>A safe file handle.</returns>
		new SafeFileHandle ToImplementation();

		/// <summary>When overridden in a derived class, gets a value indicating whether the handle value is invalid.</summary>
		/// <returns>true if the handle value is invalid; otherwise, false.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		new bool IsInvalid { get; }
	}
}