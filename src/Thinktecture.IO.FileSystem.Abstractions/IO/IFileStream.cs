using System.IO;
using JetBrains.Annotations;
using Thinktecture.Win32.SafeHandles;

namespace Thinktecture.IO
{
	/// <summary>
	/// Provides a <see cref="T:System.IO.Stream" /> for a file, supporting both synchronous and asynchronous read and write operations.To browse the .NET Framework source code for this type, see the Reference Source.
	/// </summary>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface IFileStream : IStream, IAbstraction<FileStream>
	{
		/// <summary>Gets a value indicating whether the FileStream was opened asynchronously or synchronously.</summary>
		/// <returns>true if the FileStream was opened asynchronously; otherwise, false.</returns>
		bool IsAsync { get; }

		/// <summary>Gets the name of the FileStream that was passed to the constructor.</summary>
		/// <returns>A string that is the name of the FileStream.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[NotNull]
		string Name { get; }

		/// <summary>Gets a <see cref="T:Microsoft.Win32.SafeHandles.SafeFileHandle" /> object that represents the operating system file handle for the file that the current <see cref="T:System.IO.FileStream" /> object encapsulates.</summary>
		/// <returns>An object that represents the operating system file handle for the file that the current <see cref="T:System.IO.FileStream" /> object encapsulates.</returns>
		[NotNull]
		ISafeFileHandle SafeFileHandle { get; }

		/// <summary>Clears buffers for this stream and causes any buffered data to be written to the file, and also clears all intermediate file buffers.</summary>
		/// <param name="flushToDisk">true to flush all intermediate file buffers; otherwise, false. </param>
		void Flush(bool flushToDisk);
	}
}
