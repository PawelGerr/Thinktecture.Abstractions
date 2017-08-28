using System.IO;
using JetBrains.Annotations;

namespace Thinktecture.IO
{
	/// <summary>
	/// Provides properties and instance methods for the creation, copying, deletion, moving, and opening of files, and aids in the creation of <see cref="T:System.IO.FileStream" /> objects. This class cannot be inherited.To browse the .NET Framework source code for this type, see the Reference Source.
	/// </summary>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface IFileInfo : IFileSystemInfo, IAbstraction<FileInfo>
	{
		/// <summary>Gets an instance of the parent directory.</summary>
		/// <returns>A <see cref="T:System.IO.DirectoryInfo" /> object representing the parent directory of this file.</returns>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[CanBeNull]
		IDirectoryInfo Directory { get; }

		/// <summary>Gets a string representing the directory's full path.</summary>
		/// <returns>A string representing the directory's full path.</returns>
		/// <exception cref="T:System.ArgumentNullException">null was passed in for the directory name. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The fully qualified path is 260 or more characters.</exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[CanBeNull]
		string DirectoryName { get; }

		/// <summary>Gets or sets a value that determines if the current file is read only.</summary>
		/// <returns>true if the current file is read only; otherwise, false.</returns>
		/// <exception cref="T:System.IO.FileNotFoundException">The file described by the current <see cref="T:System.IO.FileInfo" /> object could not be found.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">This operation is not supported on the current platform.-or- The caller does not have the required permission.</exception>
		/// <exception cref="T:System.ArgumentException">The user does not have write permission, but attempted to set this property to false.</exception>
		bool IsReadOnly { get; set; }

		/// <summary>Gets the size, in bytes, of the current file.</summary>
		/// <returns>The size of the current file in bytes.</returns>
		/// <exception cref="T:System.IO.IOException">
		/// <see cref="M:System.IO.FileSystemInfo.Refresh" /> cannot update the state of the file or directory. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file does not exist.-or- The Length property is called for a directory. </exception>
		long Length { get; }

		/// <summary>Creates a <see cref="T:System.IO.StreamWriter" /> that appends text to the file represented by this instance of the <see cref="T:System.IO.FileInfo" />.</summary>
		/// <returns>A new StreamWriter.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[NotNull]
		IStreamWriter AppendText();

		/// <summary>Copies an existing file to a new file, disallowing the overwriting of an existing file.</summary>
		/// <returns>A new file with a fully qualified path.</returns>
		/// <param name="destFileName">The name of the new file to copy to. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="destFileName" /> is empty, contains only white spaces, or contains invalid characters. </exception>
		/// <exception cref="T:System.IO.IOException">An error occurs, or the destination file already exists. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="destFileName" /> is null. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">A directory path is passed in, or the file is being moved to a different drive. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The directory specified in <paramref name="destFileName" /> does not exist.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.NotSupportedException">
		/// <paramref name="destFileName" /> contains a colon (:) within the string but does not specify the volume. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[NotNull]
		IFileInfo CopyTo([NotNull] string destFileName);

		/// <summary>Copies an existing file to a new file, allowing the overwriting of an existing file.</summary>
		/// <returns>A new file, or an overwrite of an existing file if <paramref name="overwrite" /> is true. If the file exists and <paramref name="overwrite" /> is false, an <see cref="T:System.IO.IOException" /> is thrown.</returns>
		/// <param name="destFileName">The name of the new file to copy to. </param>
		/// <param name="overwrite">true to allow an existing file to be overwritten; otherwise, false. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="destFileName" /> is empty, contains only white spaces, or contains invalid characters. </exception>
		/// <exception cref="T:System.IO.IOException">An error occurs, or the destination file already exists and <paramref name="overwrite" /> is false. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="destFileName" /> is null. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The directory specified in <paramref name="destFileName" /> does not exist.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">A directory path is passed in, or the file is being moved to a different drive. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.NotSupportedException">
		/// <paramref name="destFileName" /> contains a colon (:) in the middle of the string. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[NotNull]
		IFileInfo CopyTo([NotNull] string destFileName, bool overwrite);

		/// <summary>Creates a file.</summary>
		/// <returns>A new file.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[NotNull]
		IFileStream Create();

		/// <summary>Creates a <see cref="T:System.IO.StreamWriter" /> that writes a new text file.</summary>
		/// <returns>A new StreamWriter.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">The file name is a directory. </exception>
		/// <exception cref="T:System.IO.IOException">The disk is read-only. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[NotNull]
		IStreamWriter CreateText();

		/// <summary>Moves a specified file to a new location, providing the option to specify a new file name.</summary>
		/// <param name="destFileName">The path to move the file to, which can specify a different file name. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs, such as the destination file already exists or the destination device is not ready. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="destFileName" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="destFileName" /> is empty, contains only white spaces, or contains invalid characters. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		/// <paramref name="destFileName" /> is read-only or is a directory. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file is not found. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.NotSupportedException">
		/// <paramref name="destFileName" /> contains a colon (:) in the middle of the string. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		void MoveTo([NotNull] string destFileName);

		/// <summary>Opens a file in the specified mode.</summary>
		/// <returns>A file opened in the specified mode, with read/write access and unshared.</returns>
		/// <param name="mode">A <see cref="T:System.IO.FileMode" /> constant specifying the mode (for example, Open or Append) in which to open the file. </param>
		/// <exception cref="T:System.IO.FileNotFoundException">The file is not found. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The file is read-only or is a directory. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
		/// <exception cref="T:System.IO.IOException">The file is already open. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[NotNull]
		IFileStream Open(FileMode mode);

#pragma warning disable 1584, 1734
		/// <summary>Opens a file in the specified mode with read, write, or read/write access.</summary>
		/// <returns>A <see cref="T:System.IO.FileStream" /> object opened in the specified mode and access, and unshared.</returns>
		/// <param name="mode">A <see cref="T:System.IO.FileMode" /> constant specifying the mode (for example, Open or Append) in which to open the file. </param>
		/// <param name="access">A <see cref="T:System.IO.FileAccess" /> constant specifying whether to open the file with Read, Write, or ReadWrite file access. </param>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file is not found. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		/// <paramref name="path" /> is read-only or is a directory. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
		/// <exception cref="T:System.IO.IOException">The file is already open. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[NotNull]
		IFileStream Open(FileMode mode, FileAccess access);
#pragma warning restore 1584, 1734

#pragma warning disable 1584, 1734
		/// <summary>Opens a file in the specified mode with read, write, or read/write access and the specified sharing option.</summary>
		/// <returns>A <see cref="T:System.IO.FileStream" /> object opened with the specified mode, access, and sharing options.</returns>
		/// <param name="mode">A <see cref="T:System.IO.FileMode" /> constant specifying the mode (for example, Open or Append) in which to open the file. </param>
		/// <param name="access">A <see cref="T:System.IO.FileAccess" /> constant specifying whether to open the file with Read, Write, or ReadWrite file access. </param>
		/// <param name="share">A <see cref="T:System.IO.FileShare" /> constant specifying the type of access other FileStream objects have to this file. </param>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file is not found. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		/// <paramref name="path" /> is read-only or is a directory. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
		/// <exception cref="T:System.IO.IOException">The file is already open. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[NotNull]
		IFileStream Open(FileMode mode, FileAccess access, FileShare share);

		/// <summary>Creates a read-only <see cref="T:System.IO.FileStream" />.</summary>
		/// <returns>A new read-only <see cref="T:System.IO.FileStream" /> object.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">
		/// <paramref name="path" /> is read-only or is a directory. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
		/// <exception cref="T:System.IO.IOException">The file is already open. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[NotNull]
		IFileStream OpenRead();

		/// <summary>Creates a <see cref="T:System.IO.StreamReader" /> with UTF8 encoding that reads from an existing text file.</summary>
		/// <returns>A new StreamReader with UTF8 encoding.</returns>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file is not found. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">
		/// <paramref name="path" /> is read-only or is a directory. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[NotNull]
		IStreamReader OpenText();
#pragma warning restore 1584, 1734

		/// <summary>Creates a write-only <see cref="T:System.IO.FileStream" />.</summary>
		/// <returns>A write-only unshared <see cref="T:System.IO.FileStream" /> object for a new or existing file.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">The path specified when creating an instance of the <see cref="T:System.IO.FileInfo" /> object is read-only or is a directory.  </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The path specified when creating an instance of the <see cref="T:System.IO.FileInfo" /> object is invalid, such as being on an unmapped drive. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[NotNull]
		IFileStream OpenWrite();
	}
}
