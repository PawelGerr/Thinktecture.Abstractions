using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Versioning;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Thinktecture.Text;

namespace Thinktecture.IO
{
   /// <summary>Provides static methods for the creation, copying, deletion, moving, and opening of a single file, and aids in the creation of <see cref="T:System.IO.FileStream" /> objects.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
   public interface IFile
   {
      /// <summary>
      /// Reads all text from file.
      /// </summary>
      /// <param name="path">File path.</param>
      /// <param name="cancellationToken">Cancellation token.</param>
      /// <returns>Text read from file.</returns>
      Task<string> ReadAllTextAsync(string path, CancellationToken cancellationToken = default);

      /// <summary>
      /// Reads all text from file.
      /// </summary>
      /// <param name="path">File path.</param>
      /// <param name="encoding">Encoding.</param>
      /// <param name="cancellationToken">Cancellation token.</param>
      /// <returns>Text read from file.</returns>
      Task<string> ReadAllTextAsync(string path, IEncoding encoding, CancellationToken cancellationToken = default);

      /// <summary>
      /// Reads all text from file.
      /// </summary>
      /// <param name="path">File path.</param>
      /// <param name="encoding">Encoding.</param>
      /// <param name="cancellationToken">Cancellation token.</param>
      /// <returns>Text read from file.</returns>
      Task<string> ReadAllTextAsync(string path, Encoding encoding, CancellationToken cancellationToken = default);

      /// <summary>
      /// Writes text to file.
      /// </summary>
      /// <param name="path">File path.</param>
      /// <param name="content">Content to write.</param>
      /// <param name="cancellationToken">Cancellation token.</param>
      Task WriteAllTextAsync(string path, string content, CancellationToken cancellationToken = default);

      /// <summary>
      /// Writes text to file.
      /// </summary>
      /// <param name="path">File path.</param>
      /// <param name="content">Content to write.</param>
      /// <param name="encoding">Encoding.</param>
      /// <param name="cancellationToken">Cancellation token.</param>
      Task WriteAllTextAsync(string path, string content, IEncoding encoding, CancellationToken cancellationToken = default);

      /// <summary>
      /// Writes text to file.
      /// </summary>
      /// <param name="path">File path.</param>
      /// <param name="content">Content to write.</param>
      /// <param name="encoding">Encoding.</param>
      /// <param name="cancellationToken">Cancellation token.</param>
      Task WriteAllTextAsync(string path, string content, Encoding encoding, CancellationToken cancellationToken = default);

      /// <summary>
      /// Reads bytes from file.
      /// </summary>
      /// <param name="path">File path.</param>
      /// <param name="cancellationToken">Cancellation token.</param>
      /// <returns>Bytes read from file.</returns>
      Task<byte[]> ReadAllBytesAsync(string path, CancellationToken cancellationToken = default);

      /// <summary>
      /// Writes bytes to file.
      /// </summary>
      /// <param name="path">File path.</param>
      /// <param name="bytes">Bytes to write.</param>
      /// <param name="cancellationToken">Cancellation token.</param>
      Task WriteAllBytesAsync(string path, byte[] bytes, CancellationToken cancellationToken = default);

      /// <summary>
      /// Reads all lines from file.
      /// </summary>
      /// <param name="path">File path.</param>
      /// <param name="cancellationToken">Cancellation token.</param>
      /// <returns>Lines read from file.</returns>
      Task<string[]> ReadAllLinesAsync(string path, CancellationToken cancellationToken = default);

      /// <summary>
      /// Reads all lines from file.
      /// </summary>
      /// <param name="path">File path.</param>
      /// <param name="encoding">Encoding</param>
      /// <param name="cancellationToken">Cancellation token.</param>
      /// <returns>Lines read from file.</returns>
      Task<string[]> ReadAllLinesAsync(string path, IEncoding encoding, CancellationToken cancellationToken = default);

      /// <summary>
      /// Reads all lines from file.
      /// </summary>
      /// <param name="path">File path.</param>
      /// <param name="encoding">Encoding</param>
      /// <param name="cancellationToken">Cancellation token.</param>
      /// <returns>Lines read from file.</returns>
      Task<string[]> ReadAllLinesAsync(string path, Encoding encoding, CancellationToken cancellationToken = default);

      /// <summary>
      /// Writes all lines to file.
      /// </summary>
      /// <param name="path">File path.</param>
      /// <param name="contents">Content to write.</param>
      /// <param name="cancellationToken">Cancellation token.</param>
      Task WriteAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken = default);

      /// <summary>
      /// Writes all lines to file.
      /// </summary>
      /// <param name="path">File path.</param>
      /// <param name="contents">Content to write.</param>
      /// <param name="encoding">Encoding.</param>
      /// <param name="cancellationToken">Cancellation token.</param>
      Task WriteAllLinesAsync(string path, IEnumerable<string> contents, IEncoding encoding, CancellationToken cancellationToken = default);

      /// <summary>
      /// Writes all lines to file.
      /// </summary>
      /// <param name="path">File path.</param>
      /// <param name="contents">Content to write.</param>
      /// <param name="encoding">Encoding.</param>
      /// <param name="cancellationToken">Cancellation token.</param>
      Task WriteAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken = default);

      /// <summary>
      /// Appends all lines to file.
      /// </summary>
      /// <param name="path">File path.</param>
      /// <param name="contents">Contents to write.</param>
      /// <param name="cancellationToken">Cancellation token.</param>
      Task AppendAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken = default);

      /// <summary>
      /// Appends all lines to file.
      /// </summary>
      /// <param name="path">File path.</param>
      /// <param name="contents">Content to write.</param>
      /// <param name="encoding">Encoding.</param>
      /// <param name="cancellationToken">Cancellation token.</param>
      Task AppendAllLinesAsync(string path, IEnumerable<string> contents, IEncoding encoding, CancellationToken cancellationToken = default);

      /// <summary>
      /// Appends all lines to file.
      /// </summary>
      /// <param name="path">File path.</param>
      /// <param name="contents">Content to write.</param>
      /// <param name="encoding">Encoding.</param>
      /// <param name="cancellationToken">Cancellation token.</param>
      Task AppendAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken = default);

      /// <summary>
      /// Appends all text to file.
      /// </summary>
      /// <param name="path">File path.</param>
      /// <param name="content">Content to write.</param>
      /// <param name="cancellationToken">Cancellation token.</param>
      Task AppendAllTextAsync(string path, string content, CancellationToken cancellationToken = default);

      /// <summary>
      /// Appends all text to file.
      /// </summary>
      /// <param name="path">File path.</param>
      /// <param name="content">Content to write.</param>
      /// <param name="encoding">Encoding.</param>
      /// <param name="cancellationToken">Cancellation token.</param>
      Task AppendAllTextAsync(string path, string content, IEncoding encoding, CancellationToken cancellationToken = default);

      /// <summary>
      /// Appends all text to file.
      /// </summary>
      /// <param name="path">File path.</param>
      /// <param name="content">Content to write.</param>
      /// <param name="encoding">Encoding.</param>
      /// <param name="cancellationToken">Cancellation token.</param>
      Task AppendAllTextAsync(string path, string content, Encoding encoding, CancellationToken cancellationToken = default);

      /// <summary>Appends lines to a file, and then closes the file. If the specified file does not exist, this method creates a file, writes the specified lines to the file, and then closes the file.</summary>
      /// <param name="path">The file to append the lines to. The file is created if it doesn't already exist.</param>
      /// <param name="contents">The lines to append to the file.</param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.</exception>
      /// <exception cref="T:System.ArgumentNullException">Either<paramref name=" path " />or <paramref name="contents" /> is null.</exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">
      /// <paramref name="path" /> is invalid (for example, the directory doesn’t exist or it is on an unmapped drive).</exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The file specified by <paramref name="path" /> was not found.</exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
      /// <exception cref="T:System.IO.PathTooLongException">
      /// <paramref name="path" /> exceeds the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format.</exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have permission to write to the file.</exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specifies a file that is read-only.-or-This operation is not supported on the current platform.-or-<paramref name="path" /> is a directory.</exception>
      void AppendAllLines(string path, IEnumerable<string> contents);

      /// <summary>Appends lines to a file by using a specified encoding, and then closes the file. If the specified file does not exist, this method creates a file, writes the specified lines to the file, and then closes the file.</summary>
      /// <param name="path">The file to append the lines to. The file is created if it doesn't already exist.</param>
      /// <param name="contents">The lines to append to the file.</param>
      /// <param name="encoding">The character encoding to use.</param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.</exception>
      /// <exception cref="T:System.ArgumentNullException">Either<paramref name=" path" />, <paramref name="contents" />, or <paramref name="encoding" /> is null.</exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">
      /// <paramref name="path" /> is invalid (for example, the directory doesn’t exist or it is on an unmapped drive).</exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The file specified by <paramref name="path" /> was not found.</exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
      /// <exception cref="T:System.IO.PathTooLongException">
      /// <paramref name="path" /> exceeds the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format.</exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specifies a file that is read-only.-or-This operation is not supported on the current platform.-or-<paramref name="path" /> is a directory.-or-The caller does not have the required permission.</exception>
      void AppendAllLines(string path, IEnumerable<string> contents, IEncoding encoding);

      /// <summary>Appends lines to a file by using a specified encoding, and then closes the file. If the specified file does not exist, this method creates a file, writes the specified lines to the file, and then closes the file.</summary>
      /// <param name="path">The file to append the lines to. The file is created if it doesn't already exist.</param>
      /// <param name="contents">The lines to append to the file.</param>
      /// <param name="encoding">The character encoding to use.</param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.</exception>
      /// <exception cref="T:System.ArgumentNullException">Either<paramref name=" path" />, <paramref name="contents" />, or <paramref name="encoding" /> is null.</exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">
      /// <paramref name="path" /> is invalid (for example, the directory doesn’t exist or it is on an unmapped drive).</exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The file specified by <paramref name="path" /> was not found.</exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
      /// <exception cref="T:System.IO.PathTooLongException">
      /// <paramref name="path" /> exceeds the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format.</exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specifies a file that is read-only.-or-This operation is not supported on the current platform.-or-<paramref name="path" /> is a directory.-or-The caller does not have the required permission.</exception>
      void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding);

#pragma warning disable 618
      /// <summary>Opens a file, appends the specified string to the file, and then closes the file. If the file does not exist, this method creates a file, writes the specified string to the file, then closes the file.</summary>
      /// <param name="path">The file to append the specified string to. </param>
      /// <param name="contents">The string to append to the file. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, the directory doesn’t exist or it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specified a file that is read-only.-or- This operation is not supported on the current platform.-or- <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void AppendAllText(string path, string contents);

      /// <summary>Appends the specified string to the file, creating the file if it does not already exist.</summary>
      /// <param name="path">The file to append the specified string to. </param>
      /// <param name="contents">The string to append to the file. </param>
      /// <param name="encoding">The character encoding to use. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, the directory doesn’t exist or it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specified a file that is read-only.-or- This operation is not supported on the current platform.-or- <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void AppendAllText(string path, string contents, IEncoding encoding);

      /// <summary>Appends the specified string to the file, creating the file if it does not already exist.</summary>
      /// <param name="path">The file to append the specified string to. </param>
      /// <param name="contents">The string to append to the file. </param>
      /// <param name="encoding">The character encoding to use. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, the directory doesn’t exist or it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specified a file that is read-only.-or- This operation is not supported on the current platform.-or- <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void AppendAllText(string path, string contents, Encoding encoding);

      /// <summary>Creates a <see cref="T:System.IO.StreamWriter" /> that appends UTF-8 encoded text to an existing file, or to a new file if the specified file does not exist.</summary>
      /// <returns>A stream writer that appends UTF-8 encoded text to the specified file or to a new file.</returns>
      /// <param name="path">The path to the file to append to. </param>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, the directory doesn’t exist or it is on an unmapped drive). </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      IStreamWriter AppendText(string path);

      /// <summary>Copies an existing file to a new file. Overwriting a file of the same name is not allowed.</summary>
      /// <param name="sourceFileName">The file to copy. </param>
      /// <param name="destFileName">The name of the destination file. This cannot be a directory or an existing file. </param>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />.-or- <paramref name="sourceFileName" /> or <paramref name="destFileName" /> specifies a directory. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The path specified in <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is invalid (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">
      /// <paramref name="sourceFileName" /> was not found. </exception>
      /// <exception cref="T:System.IO.IOException">
      /// <paramref name="destFileName" /> exists.-or- An I/O error has occurred. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is in an invalid format. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void Copy(string sourceFileName, string destFileName);

      /// <summary>Copies an existing file to a new file. Overwriting a file of the same name is allowed.</summary>
      /// <param name="sourceFileName">The file to copy. </param>
      /// <param name="destFileName">The name of the destination file. This cannot be a directory. </param>
      /// <param name="overwrite">true if the destination file can be overwritten; otherwise, false. </param>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. -or-<paramref name="destFileName" /> is read-only.</exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />.-or- <paramref name="sourceFileName" /> or <paramref name="destFileName" /> specifies a directory. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The path specified in <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is invalid (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">
      /// <paramref name="sourceFileName" /> was not found. </exception>
      /// <exception cref="T:System.IO.IOException">
      /// <paramref name="destFileName" /> exists and <paramref name="overwrite" /> is false.-or- An I/O error has occurred. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is in an invalid format. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void Copy(string sourceFileName, string destFileName, bool overwrite);

      /// <summary>Creates or overwrites a file in the specified path.</summary>
      /// <returns>A <see cref="T:System.IO.FileStream" /> that provides read/write access to the file specified in <paramref name="path" />.</returns>
      /// <param name="path">The path and name of the file to create. </param>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.-or- <paramref name="path" /> specified a file that is read-only. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while creating the file. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      IFileStream Create(string path);

      /// <summary>Creates or overwrites the specified file.</summary>
      /// <returns>A <see cref="T:System.IO.FileStream" /> with the specified buffer size that provides read/write access to the file specified in <paramref name="path" />.</returns>
      /// <param name="path">The name of the file. </param>
      /// <param name="bufferSize">The number of bytes buffered for reads and writes to the file. </param>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.-or- <paramref name="path" /> specified a file that is read-only. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while creating the file. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      IFileStream Create(string path, int bufferSize);

      /// <summary>Creates or overwrites the specified file, specifying a buffer size and a <see cref="T:System.IO.FileOptions" /> value that describes how to create or overwrite the file.</summary>
      /// <returns>A new file with the specified buffer size.</returns>
      /// <param name="path">The name of the file. </param>
      /// <param name="bufferSize">The number of bytes buffered for reads and writes to the file. </param>
      /// <param name="options">One of the <see cref="T:System.IO.FileOptions" /> values that describes how to create or overwrite the file.</param>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.-or- <paramref name="path" /> specified a file that is read-only. -or-<see cref="F:System.IO.FileOptions.Encrypted" /> is specified for <paramref name="options" /> and file encryption is not supported on the current platform.</exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive. </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while creating the file. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.-or- <paramref name="path" /> specified a file that is read-only. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.-or- <paramref name="path" /> specified a file that is read-only. </exception>
      IFileStream Create(string path, int bufferSize, FileOptions options);

      /// <summary>Creates or opens a file for writing UTF-8 encoded text.</summary>
      /// <returns>A <see cref="T:System.IO.StreamWriter" /> that writes to the specified file using UTF-8 encoding.</returns>
      /// <param name="path">The file to be opened for writing. </param>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      IStreamWriter CreateText(string path);

      /// <summary>Deletes the specified file. </summary>
      /// <param name="path">The name of the file to be deleted. Wildcard characters are not supported.</param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.IOException">The specified file is in use. -or-There is an open handle on the file, and the operating system is Windows XP or earlier. This open handle can result from enumerating directories and files. For more information, see How to: Enumerate Directories and Files.</exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.-or- The file is an executable file that is in use.-or- <paramref name="path" /> is a directory.-or- <paramref name="path" /> specified a read-only file. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void Delete(string path);

      /// <summary>Decrypts a file that was encrypted by the current account using the <see cref="M:System.IO.File.Encrypt(System.String)" /> method.</summary>
      /// <param name="path">A path that describes a file to decrypt.</param>
      /// <exception cref="T:System.ArgumentException">The <paramref name="path" /> parameter is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
      /// <exception cref="T:System.ArgumentNullException">The <paramref name="path" /> parameter is null.</exception>
      /// <exception cref="T:System.IO.DriveNotFoundException">An invalid drive was specified. </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The file described by the <paramref name="path" /> parameter could not be found.</exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. For example, the encrypted file is already open. -or-This operation is not supported on the current platform.</exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Windows NT or later.</exception>
      /// <exception cref="T:System.NotSupportedException">The file system is not NTFS.</exception>
      /// <exception cref="T:System.UnauthorizedAccessException">The <paramref name="path" /> parameter specified a file that is read-only.-or- This operation is not supported on the current platform.-or- The <paramref name="path" /> parameter specified a directory.-or- The caller does not have the required permission.</exception>
      /// <filterpriority>1</filterpriority>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
#if NET5_0
      [SupportedOSPlatform("windows")]
#endif
      void Decrypt(string path);

      /// <summary>Encrypts a file so that only the account used to encrypt the file can decrypt it.</summary>
      /// <param name="path">A path that describes a file to encrypt.</param>
      /// <exception cref="T:System.ArgumentException">The <paramref name="path" /> parameter is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />.</exception>
      /// <exception cref="T:System.ArgumentNullException">The <paramref name="path" /> parameter is null.</exception>
      /// <exception cref="T:System.IO.DriveNotFoundException">An invalid drive was specified. </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The file described by the <paramref name="path" /> parameter could not be found.</exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.-or-This operation is not supported on the current platform.</exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Windows NT or later.</exception>
      /// <exception cref="T:System.NotSupportedException">The file system is not NTFS.</exception>
      /// <exception cref="T:System.UnauthorizedAccessException">The <paramref name="path" /> parameter specified a file that is read-only.-or- This operation is not supported on the current platform.-or- The <paramref name="path" /> parameter specified a directory.-or- The caller does not have the required permission.</exception>
      /// <filterpriority>1</filterpriority>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
#if NET5_0
      [SupportedOSPlatform("windows")]
#endif
      void Encrypt(string path);

      /// <summary>Determines whether the specified file exists.</summary>
      /// <returns>true if the caller has the required permissions and <paramref name="path" /> contains the name of an existing file; otherwise, false. This method also returns false if <paramref name="path" /> is null, an invalid path, or a zero-length string. If the caller does not have sufficient permissions to read the specified file, no exception is thrown and the method returns false regardless of the existence of <paramref name="path" />.</returns>
      /// <param name="path">The file to check. </param>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      bool Exists(string path);

      /// <summary>Gets the <see cref="T:System.IO.FileAttributes" /> of the file on the path.</summary>
      /// <returns>The <see cref="T:System.IO.FileAttributes" /> of the file on the path.</returns>
      /// <param name="path">The path to the file. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is empty, contains only white spaces, or contains invalid characters. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">
      /// <paramref name="path" /> represents a file and is invalid, such as being on an unmapped drive, or the file cannot be found. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">
      /// <paramref name="path" /> represents a directory and is invalid, such as being on an unmapped drive, or the directory cannot be found.</exception>
      /// <exception cref="T:System.IO.IOException">This file is being used by another process.</exception>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      FileAttributes GetAttributes(string path);

      /// <summary>Returns the creation date and time of the specified file or directory.</summary>
      /// <returns>A <see cref="T:System.DateTime" /> structure set to the creation date and time for the specified file or directory. This value is expressed in local time.</returns>
      /// <param name="path">The file or directory for which to obtain creation date and time information. </param>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      DateTime GetCreationTime(string path);

      /// <summary>Returns the creation date and time, in coordinated universal time (UTC), of the specified file or directory.</summary>
      /// <returns>A <see cref="T:System.DateTime" /> structure set to the creation date and time for the specified file or directory. This value is expressed in UTC time.</returns>
      /// <param name="path">The file or directory for which to obtain creation date and time information. </param>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      DateTime GetCreationTimeUtc(string path);

      /// <summary>Returns the date and time the specified file or directory was last accessed.</summary>
      /// <returns>A <see cref="T:System.DateTime" /> structure set to the date and time that the specified file or directory was last accessed. This value is expressed in local time.</returns>
      /// <param name="path">The file or directory for which to obtain access date and time information. </param>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      DateTime GetLastAccessTime(string path);

      /// <summary>Returns the date and time, in coordinated universal time (UTC), that the specified file or directory was last accessed.</summary>
      /// <returns>A <see cref="T:System.DateTime" /> structure set to the date and time that the specified file or directory was last accessed. This value is expressed in UTC time.</returns>
      /// <param name="path">The file or directory for which to obtain access date and time information. </param>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      DateTime GetLastAccessTimeUtc(string path);

      /// <summary>Returns the date and time the specified file or directory was last written to.</summary>
      /// <returns>A <see cref="T:System.DateTime" /> structure set to the date and time that the specified file or directory was last written to. This value is expressed in local time.</returns>
      /// <param name="path">The file or directory for which to obtain write date and time information. </param>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      DateTime GetLastWriteTime(string path);

      /// <summary>Returns the date and time, in coordinated universal time (UTC), that the specified file or directory was last written to.</summary>
      /// <returns>A <see cref="T:System.DateTime" /> structure set to the date and time that the specified file or directory was last written to. This value is expressed in UTC time.</returns>
      /// <param name="path">The file or directory for which to obtain write date and time information. </param>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      DateTime GetLastWriteTimeUtc(string path);

      /// <summary>Moves a specified file to a new location, providing the option to specify a new file name.</summary>
      /// <param name="sourceFileName">The name of the file to move. Can include a relative or absolute path.</param>
      /// <param name="destFileName">The new path and name for the file.</param>
      /// <exception cref="T:System.IO.IOException">The destination file already exists.-or-<paramref name="sourceFileName" /> was not found. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is null. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is a zero-length string, contains only white space, or contains invalid characters as defined in <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The path specified in <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is invalid, (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is in an invalid format. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void Move(string sourceFileName, string destFileName);

#if NETCOREAPP || NET5_0
      /// <summary>Moves a specified file to a new location, providing the option to specify a new file name.</summary>
      /// <param name="sourceFileName">The name of the file to move. Can include a relative or absolute path.</param>
      /// <param name="destFileName">The new path and name for the file.</param>
      /// <param name="overwrite">Indication whether the file at destination should be overwritten or not.</param>
      /// <exception cref="T:System.IO.IOException">The destination file already exists.-or-<paramref name="sourceFileName" /> was not found. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is null. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is a zero-length string, contains only white space, or contains invalid characters as defined in <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The path specified in <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is invalid, (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is in an invalid format. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void Move(string sourceFileName, string destFileName, bool overwrite);
#endif

      /// <summary>Opens a <see cref="T:System.IO.FileStream" /> on the specified path with read/write access.</summary>
      /// <returns>A <see cref="T:System.IO.FileStream" /> opened in the specified mode and path, with read/write access and not shared.</returns>
      /// <param name="path">The file to open. </param>
      /// <param name="mode">A <see cref="T:System.IO.FileMode" /> value that specifies whether a file is created if one does not exist, and determines whether the contents of existing files are retained or overwritten. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specified a file that is read-only.-or- This operation is not supported on the current platform.-or- <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. -or-<paramref name="mode" /> is <see cref="F:System.IO.FileMode.Create" /> and the specified file is a hidden file.</exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="mode" /> specified an invalid value. </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path" /> was not found. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      IFileStream Open(string path, FileMode mode);

      /// <summary>Opens a <see cref="T:System.IO.FileStream" /> on the specified path, with the specified mode and access.</summary>
      /// <returns>An unshared <see cref="T:System.IO.FileStream" /> that provides access to the specified file, with the specified mode and access.</returns>
      /// <param name="path">The file to open. </param>
      /// <param name="mode">A <see cref="T:System.IO.FileMode" /> value that specifies whether a file is created if one does not exist, and determines whether the contents of existing files are retained or overwritten. </param>
      /// <param name="access">A <see cref="T:System.IO.FileAccess" /> value that specifies the operations that can be performed on the file. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />.-or- <paramref name="access" /> specified Read and <paramref name="mode" /> specified Create, CreateNew, Truncate, or Append. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specified a file that is read-only and <paramref name="access" /> is not Read.-or- <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. -or-<paramref name="mode" /> is <see cref="F:System.IO.FileMode.Create" /> and the specified file is a hidden file.</exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="mode" /> or <paramref name="access" /> specified an invalid value. </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path" /> was not found. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      IFileStream Open(string path, FileMode mode, FileAccess access);

      /// <summary>Opens a <see cref="T:System.IO.FileStream" /> on the specified path, having the specified mode with read, write, or read/write access and the specified sharing option.</summary>
      /// <returns>A <see cref="T:System.IO.FileStream" /> on the specified path, having the specified mode with read, write, or read/write access and the specified sharing option.</returns>
      /// <param name="path">The file to open. </param>
      /// <param name="mode">A <see cref="T:System.IO.FileMode" /> value that specifies whether a file is created if one does not exist, and determines whether the contents of existing files are retained or overwritten. </param>
      /// <param name="access">A <see cref="T:System.IO.FileAccess" /> value that specifies the operations that can be performed on the file. </param>
      /// <param name="share">A <see cref="T:System.IO.FileShare" /> value specifying the type of access other threads have to the file. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />.-or- <paramref name="access" /> specified Read and <paramref name="mode" /> specified Create, CreateNew, Truncate, or Append. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specified a file that is read-only and <paramref name="access" /> is not Read.-or- <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. -or-<paramref name="mode" /> is <see cref="F:System.IO.FileMode.Create" /> and the specified file is a hidden file.</exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="mode" />, <paramref name="access" />, or <paramref name="share" /> specified an invalid value. </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path" /> was not found. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      IFileStream Open(string path, FileMode mode, FileAccess access, FileShare share);

      /// <summary>Opens an existing file for reading.</summary>
      /// <returns>A read-only <see cref="T:System.IO.FileStream" /> on the specified path.</returns>
      /// <param name="path">The file to be opened for reading. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path" /> was not found. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      IFileStream OpenRead(string path);

      /// <summary>Opens an existing UTF-8 encoded text file for reading.</summary>
      /// <returns>A <see cref="T:System.IO.StreamReader" /> on the specified path.</returns>
      /// <param name="path">The file to be opened for reading. </param>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path" /> was not found. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      IStreamReader OpenText(string path);

      /// <summary>Opens an existing file or creates a new file for writing.</summary>
      /// <returns>An unshared <see cref="T:System.IO.FileStream" /> object on the specified path with <see cref="F:System.IO.FileAccess.Write" /> access.</returns>
      /// <param name="path">The file to be opened for writing. </param>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.-or- <paramref name="path" /> specified a read-only file or directory. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      IFileStream OpenWrite(string path);

      /// <summary>Opens a binary file, reads the contents of the file into a byte array, and then closes the file.</summary>
      /// <returns>A byte array containing the contents of the file.</returns>
      /// <param name="path">The file to open for reading. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">This operation is not supported on the current platform.-or- <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path" /> was not found. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      byte[] ReadAllBytes(string path);

      /// <summary>Opens a text file, reads all lines of the file, and then closes the file.</summary>
      /// <returns>A string array containing all lines of the file.</returns>
      /// <param name="path">The file to open for reading. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specified a file that is read-only.-or- This operation is not supported on the current platform.-or- <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path" /> was not found. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      string[] ReadAllLines(string path);

      /// <summary>Opens a file, reads all lines of the file with the specified encoding, and then closes the file.</summary>
      /// <returns>A string array containing all lines of the file.</returns>
      /// <param name="path">The file to open for reading. </param>
      /// <param name="encoding">The encoding applied to the contents of the file. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specified a file that is read-only.-or- This operation is not supported on the current platform.-or- <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path" /> was not found. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      string[] ReadAllLines(string path, IEncoding encoding);

      /// <summary>Opens a file, reads all lines of the file with the specified encoding, and then closes the file.</summary>
      /// <returns>A string array containing all lines of the file.</returns>
      /// <param name="path">The file to open for reading. </param>
      /// <param name="encoding">The encoding applied to the contents of the file. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specified a file that is read-only.-or- This operation is not supported on the current platform.-or- <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path" /> was not found. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      string[] ReadAllLines(string path, Encoding encoding);

      /// <summary>Opens a text file, reads all lines of the file, and then closes the file.</summary>
      /// <returns>A string containing all lines of the file.</returns>
      /// <param name="path">The file to open for reading. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specified a file that is read-only.-or- This operation is not supported on the current platform.-or- <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path" /> was not found. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      string ReadAllText(string path);

      /// <summary>Opens a file, reads all lines of the file with the specified encoding, and then closes the file.</summary>
      /// <returns>A string containing all lines of the file.</returns>
      /// <param name="path">The file to open for reading. </param>
      /// <param name="encoding">The encoding applied to the contents of the file. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specified a file that is read-only.-or- This operation is not supported on the current platform.-or- <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path" /> was not found. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      string ReadAllText(string path, IEncoding encoding);

      /// <summary>Opens a file, reads all lines of the file with the specified encoding, and then closes the file.</summary>
      /// <returns>A string containing all lines of the file.</returns>
      /// <param name="path">The file to open for reading. </param>
      /// <param name="encoding">The encoding applied to the contents of the file. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specified a file that is read-only.-or- This operation is not supported on the current platform.-or- <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path" /> was not found. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      string ReadAllText(string path, Encoding encoding);

      /// <summary>Reads the lines of a file.</summary>
      /// <returns>All the lines of the file, or the lines that are the result of a query.</returns>
      /// <param name="path">The file to read.</param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.</exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null.</exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">
      /// <paramref name="path" /> is invalid (for example, it is on an unmapped drive).</exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The file specified by <paramref name="path" /> was not found.</exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
      /// <exception cref="T:System.IO.PathTooLongException">
      /// <paramref name="path" /> exceeds the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specifies a file that is read-only.-or-This operation is not supported on the current platform.-or-<paramref name="path" /> is a directory.-or-The caller does not have the required permission.</exception>
      IEnumerable<string> ReadLines(string path);

      /// <summary>Read the lines of a file that has a specified encoding.</summary>
      /// <returns>All the lines of the file, or the lines that are the result of a query.</returns>
      /// <param name="path">The file to read.</param>
      /// <param name="encoding">The encoding that is applied to the contents of the file. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.</exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null.</exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">
      /// <paramref name="path" /> is invalid (for example, it is on an unmapped drive).</exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The file specified by <paramref name="path" /> was not found.</exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
      /// <exception cref="T:System.IO.PathTooLongException">
      /// <paramref name="path" /> exceeds the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specifies a file that is read-only.-or-This operation is not supported on the current platform.-or-<paramref name="path" /> is a directory.-or-The caller does not have the required permission.</exception>
      IEnumerable<string> ReadLines(string path, IEncoding encoding);

      /// <summary>Read the lines of a file that has a specified encoding.</summary>
      /// <returns>All the lines of the file, or the lines that are the result of a query.</returns>
      /// <param name="path">The file to read.</param>
      /// <param name="encoding">The encoding that is applied to the contents of the file. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.</exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null.</exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">
      /// <paramref name="path" /> is invalid (for example, it is on an unmapped drive).</exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The file specified by <paramref name="path" /> was not found.</exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
      /// <exception cref="T:System.IO.PathTooLongException">
      /// <paramref name="path" /> exceeds the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specifies a file that is read-only.-or-This operation is not supported on the current platform.-or-<paramref name="path" /> is a directory.-or-The caller does not have the required permission.</exception>
      IEnumerable<string> ReadLines(string path, Encoding encoding);

      /// <summary>Sets the specified <see cref="T:System.IO.FileAttributes" /> of the file on the specified path.</summary>
      /// <param name="path">The path to the file. </param>
      /// <param name="fileAttributes">A bitwise combination of the enumeration values. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is empty, contains only white spaces, contains invalid characters, or the file attribute is invalid. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The file cannot be found.</exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specified a file that is read-only.-or- This operation is not supported on the current platform.-or- <paramref name="path" /> specified a directory.-or- The caller does not have the required permission.</exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void SetAttributes(string path, FileAttributes fileAttributes);

      /// <summary>Sets the date and time the file was created.</summary>
      /// <param name="path">The file for which to set the creation date and time information. </param>
      /// <param name="creationTime">A <see cref="T:System.DateTime" /> containing the value to set for the creation date and time of <paramref name="path" />. This value is expressed in local time. </param>
      /// <exception cref="T:System.IO.FileNotFoundException">The specified path was not found. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while performing the operation. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="creationTime" /> specifies a value outside the range of dates, times, or both permitted for this operation. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void SetCreationTime(string path, DateTime creationTime);

      /// <summary>Sets the date and time, in coordinated universal time (UTC), that the file was created.</summary>
      /// <param name="path">The file for which to set the creation date and time information. </param>
      /// <param name="creationTimeUtc">A <see cref="T:System.DateTime" /> containing the value to set for the creation date and time of <paramref name="path" />. This value is expressed in UTC time. </param>
      /// <exception cref="T:System.IO.FileNotFoundException">The specified path was not found. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while performing the operation. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="creationTimeUtc" /> specifies a value outside the range of dates, times, or both permitted for this operation. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void SetCreationTimeUtc(string path, DateTime creationTimeUtc);

      /// <summary>Sets the date and time the specified file was last accessed.</summary>
      /// <param name="path">The file for which to set the access date and time information. </param>
      /// <param name="lastAccessTime">A <see cref="T:System.DateTime" /> containing the value to set for the last access date and time of <paramref name="path" />. This value is expressed in local time. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The specified path was not found. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="lastAccessTime" /> specifies a value outside the range of dates or times permitted for this operation.</exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void SetLastAccessTime(string path, DateTime lastAccessTime);

      /// <summary>Sets the date and time, in coordinated universal time (UTC), that the specified file was last accessed.</summary>
      /// <param name="path">The file for which to set the access date and time information. </param>
      /// <param name="lastAccessTimeUtc">A <see cref="T:System.DateTime" /> containing the value to set for the last access date and time of <paramref name="path" />. This value is expressed in UTC time. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The specified path was not found. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="lastAccessTimeUtc" /> specifies a value outside the range of dates or times permitted for this operation.</exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc);

      /// <summary>Sets the date and time that the specified file was last written to.</summary>
      /// <param name="path">The file for which to set the date and time information. </param>
      /// <param name="lastWriteTime">A <see cref="T:System.DateTime" /> containing the value to set for the last write date and time of <paramref name="path" />. This value is expressed in local time. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The specified path was not found. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="lastWriteTime" /> specifies a value outside the range of dates or times permitted for this operation.</exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void SetLastWriteTime(string path, DateTime lastWriteTime);

      /// <summary>Sets the date and time, in coordinated universal time (UTC), that the specified file was last written to.</summary>
      /// <param name="path">The file for which to set the date and time information. </param>
      /// <param name="lastWriteTimeUtc">A <see cref="T:System.DateTime" /> containing the value to set for the last write date and time of <paramref name="path" />. This value is expressed in UTC time. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The specified path was not found. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="lastWriteTimeUtc" /> specifies a value outside the range of dates or times permitted for this operation.</exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc);

      /// <summary>Creates a new file, writes the specified byte array to the file, and then closes the file. If the target file already exists, it is overwritten.</summary>
      /// <param name="path">The file to write to. </param>
      /// <param name="bytes">The bytes to write to the file. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null or the byte array is empty. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specified a file that is read-only.-or- This operation is not supported on the current platform.-or- <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void WriteAllBytes(string path, byte[] bytes);

      /// <summary>Creates a new file, write the specified string array to the file, and then closes the file. </summary>
      /// <param name="path">The file to write to. </param>
      /// <param name="contents">The string array to write to the file. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">Either <paramref name="path" /> or <paramref name="contents" /> is null.  </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specified a file that is read-only.-or- This operation is not supported on the current platform.-or- <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
      /// <filterpriority>1</filterpriority>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void WriteAllLines(string path, string[] contents);

      /// <summary>Creates a new file, writes the specified string array to the file by using the specified encoding, and then closes the file. </summary>
      /// <param name="path">The file to write to. </param>
      /// <param name="contents">The string array to write to the file. </param>
      /// <param name="encoding">An <see cref="T:System.Text.Encoding" /> object that represents the character encoding applied to the string array.</param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">Either <paramref name="path" /> or <paramref name="contents" /> is null.  </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specified a file that is read-only.-or- This operation is not supported on the current platform.-or- <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
      /// <filterpriority>1</filterpriority>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void WriteAllLines(string path, string[] contents, Encoding encoding);

      /// <summary>Creates a new file, writes the specified string array to the file by using the specified encoding, and then closes the file. </summary>
      /// <param name="path">The file to write to. </param>
      /// <param name="contents">The string array to write to the file. </param>
      /// <param name="encoding">An <see cref="T:System.Text.Encoding" /> object that represents the character encoding applied to the string array.</param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">Either <paramref name="path" /> or <paramref name="contents" /> is null.  </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specified a file that is read-only.-or- This operation is not supported on the current platform.-or- <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
      /// <filterpriority>1</filterpriority>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void WriteAllLines(string path, string[] contents, IEncoding encoding);

      /// <summary>Creates a new file, writes a collection of strings to the file, and then closes the file.</summary>
      /// <param name="path">The file to write to.</param>
      /// <param name="contents">The lines to write to the file.</param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.</exception>
      /// <exception cref="T:System.ArgumentNullException">Either<paramref name=" path " />or <paramref name="contents" /> is null.</exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">
      /// <paramref name="path" /> is invalid (for example, it is on an unmapped drive).</exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
      /// <exception cref="T:System.IO.PathTooLongException">
      /// <paramref name="path" /> exceeds the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format.</exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specifies a file that is read-only.-or-This operation is not supported on the current platform.-or-<paramref name="path" /> is a directory.-or-The caller does not have the required permission.</exception>
      void WriteAllLines(string path, IEnumerable<string> contents);

      /// <summary>Creates a new file by using the specified encoding, writes a collection of strings to the file, and then closes the file.</summary>
      /// <param name="path">The file to write to.</param>
      /// <param name="contents">The lines to write to the file.</param>
      /// <param name="encoding">The character encoding to use.</param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.</exception>
      /// <exception cref="T:System.ArgumentNullException">Either<paramref name=" path" />,<paramref name=" contents" />, or <paramref name="encoding" /> is null.</exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">
      /// <paramref name="path" /> is invalid (for example, it is on an unmapped drive).</exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
      /// <exception cref="T:System.IO.PathTooLongException">
      /// <paramref name="path" /> exceeds the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format.</exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specifies a file that is read-only.-or-This operation is not supported on the current platform.-or-<paramref name="path" /> is a directory.-or-The caller does not have the required permission.</exception>
      void WriteAllLines(string path, IEnumerable<string> contents, IEncoding encoding);

      /// <summary>Creates a new file by using the specified encoding, writes a collection of strings to the file, and then closes the file.</summary>
      /// <param name="path">The file to write to.</param>
      /// <param name="contents">The lines to write to the file.</param>
      /// <param name="encoding">The character encoding to use.</param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.</exception>
      /// <exception cref="T:System.ArgumentNullException">Either<paramref name=" path" />,<paramref name=" contents" />, or <paramref name="encoding" /> is null.</exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">
      /// <paramref name="path" /> is invalid (for example, it is on an unmapped drive).</exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
      /// <exception cref="T:System.IO.PathTooLongException">
      /// <paramref name="path" /> exceeds the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format.</exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specifies a file that is read-only.-or-This operation is not supported on the current platform.-or-<paramref name="path" /> is a directory.-or-The caller does not have the required permission.</exception>
      void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding);

      /// <summary>Creates a new file, writes the specified string to the file, and then closes the file. If the target file already exists, it is overwritten.</summary>
      /// <param name="path">The file to write to. </param>
      /// <param name="contents">The string to write to the file. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null or <paramref name="contents" /> is empty.  </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specified a file that is read-only.-or- This operation is not supported on the current platform.-or- <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void WriteAllText(string path, string contents);

      /// <summary>Creates a new file, writes the specified string to the file using the specified encoding, and then closes the file. If the target file already exists, it is overwritten.</summary>
      /// <param name="path">The file to write to. </param>
      /// <param name="contents">The string to write to the file. </param>
      /// <param name="encoding">The encoding to apply to the string.</param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null or <paramref name="contents" /> is empty. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specified a file that is read-only.-or- This operation is not supported on the current platform.-or- <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void WriteAllText(string path, string contents, IEncoding encoding);

      /// <summary>Creates a new file, writes the specified string to the file using the specified encoding, and then closes the file. If the target file already exists, it is overwritten.</summary>
      /// <param name="path">The file to write to. </param>
      /// <param name="contents">The string to write to the file. </param>
      /// <param name="encoding">The encoding to apply to the string.</param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="path" /> is null or <paramref name="contents" /> is empty. </exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. </exception>
      /// <exception cref="T:System.UnauthorizedAccessException">
      /// <paramref name="path" /> specified a file that is read-only.-or- This operation is not supported on the current platform.-or- <paramref name="path" /> specified a directory.-or- The caller does not have the required permission. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="path" /> is in an invalid format. </exception>
      /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void WriteAllText(string path, string contents, Encoding encoding);
#pragma warning restore 618

      /// <summary>Replaces the contents of a specified file with the contents of another file, deleting the original file, and creating a backup of the replaced file.</summary>
      /// <param name="sourceFileName">The name of a file that replaces the file specified by <paramref name="destinationFileName" />.</param>
      /// <param name="destinationFileName">The name of the file being replaced.</param>
      /// <param name="destinationBackupFileName">The name of the backup file.</param>
      /// <exception cref="T:System.ArgumentException">The path described by the <paramref name="destinationFileName" /> parameter was not of a legal form.-or-The path described by the <paramref name="destinationBackupFileName" /> parameter was not of a legal form.</exception>
      /// <exception cref="T:System.ArgumentNullException">The <paramref name="destinationFileName" /> parameter is null.</exception>
      /// <exception cref="T:System.IO.DriveNotFoundException">An invalid drive was specified. </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The file described by the current <see cref="T:System.IO.FileInfo" /> object could not be found.-or-The file described by the <paramref name="destinationBackupFileName" /> parameter could not be found. </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.- or -The <paramref name="sourceFileName" /> and <paramref name="destinationFileName" /> parameters specify the same file.</exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.PlatformNotSupportedException">The operating system is Windows 98 Second Edition or earlier and the files system is not NTFS.</exception>
      /// <exception cref="T:System.UnauthorizedAccessException">The <paramref name="sourceFileName" /> or <paramref name="destinationFileName" /> parameter specifies a file that is read-only.-or- This operation is not supported on the current platform.-or- Source or destination parameters specify a directory instead of a file.-or- The caller does not have the required permission.</exception>
      /// <filterpriority>1</filterpriority>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName);

      /// <summary>Replaces the contents of a specified file with the contents of another file, deleting the original file, and creating a backup of the replaced file and optionally ignores merge errors.</summary>
      /// <param name="sourceFileName">The name of a file that replaces the file specified by <paramref name="destinationFileName" />.</param>
      /// <param name="destinationFileName">The name of the file being replaced.</param>
      /// <param name="destinationBackupFileName">The name of the backup file.</param>
      /// <param name="ignoreMetadataErrors">true to ignore merge errors (such as attributes and access control lists (ACLs)) from the replaced file to the replacement file; otherwise, false. </param>
      /// <exception cref="T:System.ArgumentException">The path described by the <paramref name="destinationFileName" /> parameter was not of a legal form.-or-The path described by the <paramref name="destinationBackupFileName" /> parameter was not of a legal form.</exception>
      /// <exception cref="T:System.ArgumentNullException">The <paramref name="destinationFileName" /> parameter is null.</exception>
      /// <exception cref="T:System.IO.DriveNotFoundException">An invalid drive was specified. </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">The file described by the current <see cref="T:System.IO.FileInfo" /> object could not be found.-or-The file described by the <paramref name="destinationBackupFileName" /> parameter could not be found. </exception>
      /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.- or -The <paramref name="sourceFileName" /> and <paramref name="destinationFileName" /> parameters specify the same file.</exception>
      /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
      /// <exception cref="T:System.PlatformNotSupportedException">The operating system is Windows 98 Second Edition or earlier and the files system is not NTFS.</exception>
      /// <exception cref="T:System.UnauthorizedAccessException">The <paramref name="sourceFileName" /> or <paramref name="destinationFileName" /> parameter specifies a file that is read-only.-or- This operation is not supported on the current platform.-or- Source or destination parameters specify a directory instead of a file.-or- The caller does not have the required permission.</exception>
      /// <filterpriority>1</filterpriority>
      /// <PermissionSet>
      ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
      /// </PermissionSet>
      void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors);
   }
}
