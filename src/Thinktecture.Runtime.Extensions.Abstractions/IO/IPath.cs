using System;
namespace Thinktecture.IO
{
	/// <summary>
	/// Performs operations on <see cref="T:System.String" /> instances that contain file or directory path information. These operations are performed in a cross-platform manner.To browse the .NET Framework source code for this type, see the Reference Source.
	/// </summary>
	public interface IPath
	{
		/// <summary>Provides a platform-specific character used to separate directory levels in a path string that reflects a hierarchical file system organization.</summary>
		/// <filterpriority>1</filterpriority>
		char DirectorySeparatorChar { get; }

		/// <summary>Provides a platform-specific alternate character used to separate directory levels in a path string that reflects a hierarchical file system organization.</summary>
		/// <filterpriority>1</filterpriority>
		char AltDirectorySeparatorChar { get; }

		/// <summary>Provides a platform-specific volume separator character.</summary>
		/// <filterpriority>1</filterpriority>
		char VolumeSeparatorChar { get; }

		/// <summary>A platform-specific separator character used to separate path strings in environment variables.</summary>
		/// <filterpriority>1</filterpriority>
		char PathSeparator { get; }

		/// <summary>Changes the extension of a path string.</summary>
		/// <returns>The modified path information.On Windows-based desktop platforms, if <paramref name="path" /> is null or an empty string (""), the path information is returned unmodified. If <paramref name="extension" /> is null, the returned string contains the specified path with its extension removed. If <paramref name="path" /> has no extension, and <paramref name="extension" /> is not null, the returned path string contains <paramref name="extension" /> appended to the end of <paramref name="path" />.</returns>
		/// <param name="path">The path information to modify. The path cannot contain any of the characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />. </param>
		/// <param name="extension">The new extension (with or without a leading period). Specify null to remove an existing extension from <paramref name="path" />. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		string? ChangeExtension(string? path, string? extension);

		/// <summary>Combines an array of strings into a path.</summary>
		/// <returns>The combined paths.</returns>
		/// <param name="paths">An array of parts of the path.</param>
		/// <exception cref="T:System.ArgumentException">One of the strings in the array contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">One of the strings in the array is null. </exception>
		string Combine(params string[] paths);

		/// <summary>
		/// Gets a path that is relative to <paramref name="relativeTo"/>.
		/// </summary>
		/// <param name="relativeTo">Path to make the <paramref name="path"/> relative to.</param>
		/// <param name="path">Path to make relative to <paramref name="relativeTo"/>.</param>
		/// <returns>Relative path.</returns>
		string GetRelativePath(string relativeTo, string path);

		/// <summary>Returns the directory information for the specified path string.</summary>
		/// <param name="path">The path of a file or directory. </param>
		/// <returns>Directory information for <paramref name="path" />, or null if <paramref name="path" /> denotes a root directory or is null. Returns <see cref="F:System.String.Empty" /> if <paramref name="path" /> does not contain directory information.</returns>
		ReadOnlySpan<char> GetDirectoryName(ReadOnlySpan<char> path);

		/// <summary>Returns the extension of the specified path string.</summary>
		/// <param name="path">The path string from which to get the extension. </param>
		/// <returns>The extension of the specified path (including the period "."), or null, or <see cref="F:System.String.Empty" />. If <paramref name="path" /> is null, <see cref="M:System.IO.Path.GetExtension(System.String)" /> returns null. If <paramref name="path" /> does not have extension information, <see cref="M:System.IO.Path.GetExtension(System.String)" /> returns <see cref="F:System.String.Empty" />.</returns>
		ReadOnlySpan<char> GetExtension(ReadOnlySpan<char> path);

		/// <summary>Returns the file name and extension of the specified path string.</summary>
		/// <returns>The characters after the last directory character in <paramref name="path" />. If the last character of <paramref name="path" /> is a directory or volume separator character, this method returns <see cref="F:System.String.Empty" />. If <paramref name="path" /> is null, this method returns null.</returns>
		/// <param name="path">The path string from which to obtain the file name and extension. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />. </exception>
		ReadOnlySpan<char> GetFileName(ReadOnlySpan<char> path);

		/// <summary>Returns the file name of the specified path string without the extension.</summary>
		/// <returns>The string returned by <see cref="M:System.IO.Path.GetFileName(System.String)" />, minus the last period (.) and all characters following it.</returns>
		/// <param name="path">The path of the file. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		ReadOnlySpan<char> GetFileNameWithoutExtension(ReadOnlySpan<char> path);

		/// <summary>
		/// Checks whether the <paramref name="path"/> is fully qualified or not.
		/// </summary>
		/// <param name="path">Path to check.</param>
		/// <returns><c>true</c> if path is fully qualified; otherwise <c>false</c>.</returns>
		bool IsPathFullyQualified(string path);

		/// <summary>
		/// Checks whether the <paramref name="path"/> is fully qualified or not.
		/// </summary>
		/// <param name="path">Path to check.</param>
		/// <returns><c>true</c> if path is fully qualified; otherwise <c>false</c>.</returns>
		bool IsPathFullyQualified(ReadOnlySpan<char> path);

		/// <summary>Determines whether a path includes a file name extension.</summary>
		/// <returns>true if the characters that follow the last directory separator (\\ or /) or volume separator (:) in the path include a period (.) followed by one or more characters; otherwise, false.</returns>
		/// <param name="path">The path to search for an extension. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />. </exception>
		bool HasExtension(ReadOnlySpan<char> path);

		/// <summary>
		/// Concatenates 2 paths.
		/// </summary>
		/// <param name="path1">Path to concatenate with.</param>
		/// <param name="path2">Path to concatenate.</param>
		/// <returns>Concatenated path.</returns>
		string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2);

		/// <summary>
		/// Concatenates 3 paths.
		/// </summary>
		/// <param name="path1">Path to concatenate with.</param>
		/// <param name="path2">Path to concatenate.</param>
		/// <param name="path3">Another path to concatenate.</param>
		/// <returns>Concatenated path.</returns>
		string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3);

#if NETCOREAPP || NET5_0
      /// <summary>
      /// Concatenates 4 paths.
      /// </summary>
      /// <param name="path1">Path to concatenate with.</param>
      /// <param name="path2">Path to concatenate.</param>
      /// <param name="path3">Another path to concatenate.</param>
      /// <param name="path4">Another path to concatenate.</param>
      /// <returns>Concatenated path.</returns>
      string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3, ReadOnlySpan<char> path4);

      /// <summary>
      /// Concatenates 2 paths.
      /// </summary>
      /// <param name="path1">Path to concatenate with.</param>
      /// <param name="path2">Path to concatenate.</param>
      /// <returns>Concatenated path.</returns>
      string Join(string? path1, string? path2);

      /// <summary>
      /// Concatenates 3 paths.
      /// </summary>
      /// <param name="path1">Path to concatenate with.</param>
      /// <param name="path2">Path to concatenate.</param>
      /// <param name="path3">Another path to concatenate.</param>
      /// <returns>Concatenated path.</returns>
      string Join(string? path1, string? path2, string? path3);

      /// <summary>
      /// Concatenates 4 paths.
      /// </summary>
      /// <param name="path1">Path to concatenate with.</param>
      /// <param name="path2">Path to concatenate.</param>
      /// <param name="path3">Another path to concatenate.</param>
      /// <param name="path4">Another path to concatenate.</param>
      /// <returns>Concatenated path.</returns>
      string Join(string? path1, string? path2, string? path3, string? path4);

      /// <summary>
      /// Concatenates paths.
      /// </summary>
      /// <param name="paths">Paths to concatenate.</param>
      /// <returns>Concatenated path.</returns>
      string Join(params string?[] paths);

      /// <summary>
      /// Trims one trailing directory separator beyond the root of the path.
      /// </summary>
      string TrimEndingDirectorySeparator(string path);

      /// <summary>
      /// Trims one trailing directory separator beyond the root of the path.
      /// </summary>
      ReadOnlySpan<char> TrimEndingDirectorySeparator(ReadOnlySpan<char> path);

      /// <summary>
      /// Returns true if the path ends in a directory separator.
      /// </summary>
      bool EndsInDirectorySeparator(ReadOnlySpan<char> path);

      /// <summary>
      /// Returns true if the path ends in a directory separator.
      /// </summary>
      bool EndsInDirectorySeparator(string path);
#endif

		/// <summary>
		/// Concatenates 2 paths.
		/// </summary>
		/// <param name="path1">Path to concatenate with.</param>
		/// <param name="path2">Path to concatenate.</param>
		/// <param name="destination">Destination to write the concatenated path into.</param>
		/// <param name="charsWritten">Number of characters written.</param>
		/// <returns><c>true</c> if success; otherwise <c>false</c>.</returns>
		bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, Span<char> destination, out int charsWritten);

		/// <summary>
		/// Concatenates 3 paths.
		/// </summary>
		/// <param name="path1">Path to concatenate with.</param>
		/// <param name="path2">Path to concatenate.</param>
		/// <param name="path3">Another path to concatenate.</param>
		/// <param name="destination">Destination to write the concatenated path into.</param>
		/// <param name="charsWritten">Number of characters written.</param>
		/// <returns><c>true</c> if success; otherwise <c>false</c>.</returns>
		bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3, Span<char> destination, out int charsWritten);

		/// <summary>Returns the absolute path for the specified path and base path.</summary>
		/// <param name="path">The file or directory for which to obtain absolute path information. </param>
		/// <param name="basePath">Base path.</param>
		/// <returns>The fully qualified location of <paramref name="path" />, such as "C:\MyFile.txt".</returns>
		string GetFullPath(string path, string basePath);

		/// <summary>Gets a value indicating whether the specified path string contains a root.</summary>
		/// <returns>true if <paramref name="path" /> contains a root; otherwise, false.</returns>
		/// <param name="path">The path to test. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />. </exception>
		bool IsPathRooted(ReadOnlySpan<char> path);

		/// <summary>Gets the root directory information of the specified path.</summary>
		/// <param name="path">The path from which to obtain root directory information. </param>
		/// <returns>The root directory of <paramref name="path" />, such as "C:\", or null if <paramref name="path" /> is null, or an empty string if <paramref name="path" /> does not contain root directory information.</returns>
		ReadOnlySpan<char> GetPathRoot(ReadOnlySpan<char> path);

		/// <summary>Returns the directory information for the specified path string.</summary>
		/// <returns>Directory information for <paramref name="path" />, or null if <paramref name="path" /> denotes a root directory or is null. Returns <see cref="F:System.String.Empty" /> if <paramref name="path" /> does not contain directory information.</returns>
		/// <param name="path">The path of a file or directory. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="path" /> parameter contains invalid characters, is empty, or contains only white spaces. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.IO.IOException" />, instead.The <paramref name="path" /> parameter is longer than the system-defined maximum length.</exception>
		string? GetDirectoryName(string? path);

		/// <summary>Returns the extension of the specified path string.</summary>
		/// <returns>The extension of the specified path (including the period "."), or null, or <see cref="F:System.String.Empty" />. If <paramref name="path" /> is null, <see cref="M:System.IO.Path.GetExtension(System.String)" /> returns null. If <paramref name="path" /> does not have extension information, <see cref="M:System.IO.Path.GetExtension(System.String)" /> returns <see cref="F:System.String.Empty" />.</returns>
		/// <param name="path">The path string from which to get the extension. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.  </exception>
		string? GetExtension(string? path);

		/// <summary>Returns the file name and extension of the specified path string.</summary>
		/// <returns>The characters after the last directory character in <paramref name="path" />. If the last character of <paramref name="path" /> is a directory or volume separator character, this method returns <see cref="F:System.String.Empty" />. If <paramref name="path" /> is null, this method returns null.</returns>
		/// <param name="path">The path string from which to obtain the file name and extension. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />. </exception>
		string? GetFileName(string? path);

		/// <summary>Returns the file name of the specified path string without the extension.</summary>
		/// <returns>The string returned by <see cref="M:System.IO.Path.GetFileName(System.String)" />, minus the last period (.) and all characters following it.</returns>
		/// <param name="path">The path of the file. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		string? GetFileNameWithoutExtension(string? path);

		/// <summary>Gets an array containing the characters that are not allowed in file names.</summary>
		/// <returns>An array containing the characters that are not allowed in file names.</returns>
		char[] GetInvalidFileNameChars();

		/// <summary>Gets an array containing the characters that are not allowed in path names.</summary>
		/// <returns>An array containing the characters that are not allowed in path names.</returns>
		char[] GetInvalidPathChars();

		/// <summary>Gets the root directory information of the specified path.</summary>
		/// <returns>The root directory of <paramref name="path" />, such as "C:\", or null if <paramref name="path" /> is null, or an empty string if <paramref name="path" /> does not contain root directory information.</returns>
		/// <param name="path">The path from which to obtain root directory information. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.-or- <see cref="F:System.String.Empty" /> was passed to <paramref name="path" />. </exception>
		string? GetPathRoot(string? path);

		/// <summary>Returns a random folder name or file name.</summary>
		/// <returns>A random folder name or file name.</returns>
		string GetRandomFileName();

		/// <summary>Determines whether a path includes a file name extension.</summary>
		/// <returns>true if the characters that follow the last directory separator (\\ or /) or volume separator (:) in the path include a period (.) followed by one or more characters; otherwise, false.</returns>
		/// <param name="path">The path to search for an extension. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />. </exception>
		bool HasExtension(string? path);

		/// <summary>Gets a value indicating whether the specified path string contains a root.</summary>
		/// <returns>true if <paramref name="path" /> contains a root; otherwise, false.</returns>
		/// <param name="path">The path to test. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />. </exception>
		bool IsPathRooted(string? path);

		/// <summary>Combines two strings into a path.</summary>
		/// <returns>The combined paths. If one of the specified paths is a zero-length string, this method returns the other path. If <paramref name="path2" /> contains an absolute path, this method returns <paramref name="path2" />.</returns>
		/// <param name="path1">The first path to combine. </param>
		/// <param name="path2">The second path to combine. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="path1" /> or <paramref name="path2" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="path1" /> or <paramref name="path2" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		string Combine(string path1, string path2);

		/// <summary>Combines three strings into a path.</summary>
		/// <returns>The combined paths.</returns>
		/// <param name="path1">The first path to combine. </param>
		/// <param name="path2">The second path to combine. </param>
		/// <param name="path3">The third path to combine.</param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="path1" />, <paramref name="path2" />, or <paramref name="path3" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="path1" />, <paramref name="path2" />, or <paramref name="path3" /> is null. </exception>
		string Combine(string path1, string path2, string path3);

		/// <summary>Combines four strings into a path.</summary>
		/// <returns>The combined paths.</returns>
		/// <param name="path1">The first path to combine. </param>
		/// <param name="path2">The second path to combine. </param>
		/// <param name="path3">The third path to combine.</param>
		/// <param name="path4">The fourth path to combine.</param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="path1" />, <paramref name="path2" />, <paramref name="path3" />, or <paramref name="path4" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="path1" />, <paramref name="path2" />, <paramref name="path3" />, or <paramref name="path4" /> is null. </exception>
		string Combine(string path1, string path2, string path3, string path4);

		/// <summary>Returns the absolute path for the specified path string.</summary>
		/// <returns>The fully qualified location of <paramref name="path" />, such as "C:\MyFile.txt".</returns>
		/// <param name="path">The file or directory for which to obtain absolute path information. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.-or- The system could not retrieve the absolute path. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permissions. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="path" /> is null. </exception>
		/// <exception cref="T:System.NotSupportedException">
		/// <paramref name="path" /> contains a colon (":") that is not part of a volume identifier (for example, "c:\"). </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" PathDiscovery="*AllFiles*" />
		/// </PermissionSet>
		string GetFullPath(string path);

		/// <summary>Returns the path of the current user's temporary folder.</summary>
		/// <returns>The path to the temporary folder, ending with a backslash.</returns>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permissions. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		string GetTempPath();

		/// <summary>Creates a uniquely named, zero-byte temporary file on disk and returns the full path of that file.</summary>
		/// <returns>The full path of the temporary file.</returns>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs, such as no unique temporary file name is available.- or -This method was unable to create a temporary file.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		string GetTempFileName();
	}
}
