using Microsoft.Win32.SafeHandles;
using Thinktecture.Runtime.InteropServices;

namespace Thinktecture.Win32.SafeHandles
{
	/// <summary>
	/// Represents a wrapper class for a wait handle.
	/// </summary>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface ISafeWaitHandle : ISafeHandle, IAbstraction<SafeWaitHandle>
	{
	}
}
