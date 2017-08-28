using JetBrains.Annotations;

namespace Thinktecture.IO
{
	/// <summary>
	/// Performs operations on <see cref="T:System.String" /> instances that contain file or directory path information. These operations are performed in a cross-platform manner.To browse the .NET Framework source code for this type, see the Reference Source.
	/// </summary>
	public interface IPath
	{
		/// <summary>Changes the extension of a path string.</summary>
		/// <returns>The modified path information.On Windows-based desktop platforms, if <paramref name="path" /> is null or an empty string (""), the path information is returned unmodified. If <paramref name="extension" /> is null, the returned string contains the specified path with its extension removed. If <paramref name="path" /> has no extension, and <paramref name="extension" /> is not null, the returned path string contains <paramref name="extension" /> appended to the end of <paramref name="path" />.</returns>
		/// <param name="path">The path information to modify. The path cannot contain any of the characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />. </param>
		/// <param name="extension">The new extension (with or without a leading period). Specify null to remove an existing extension from <paramref name="path" />. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		[CanBeNull]
		string ChangeExtension([CanBeNull] string path, [CanBeNull] string extension);

		/// <summary>Combines an array of strings into a path.</summary>
		/// <returns>The combined paths.</returns>
		/// <param name="paths">An array of parts of the path.</param>
		/// <exception cref="T:System.ArgumentException">One of the strings in the array contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">One of the strings in the array is null. </exception>
		[NotNull]
		string Combine([NotNull, ItemNotNull] params string[] paths);

		/// <summary>Returns the directory information for the specified path string.</summary>
		/// <returns>Directory information for <paramref name="path" />, or null if <paramref name="path" /> denotes a root directory or is null. Returns <see cref="F:System.String.Empty" /> if <paramref name="path" /> does not contain directory information.</returns>
		/// <param name="path">The path of a file or directory. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="path" /> parameter contains invalid characters, is empty, or contains only white spaces. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.IO.IOException" />, instead.The <paramref name="path" /> parameter is longer than the system-defined maximum length.</exception>
		[CanBeNull]
		string GetDirectoryName([CanBeNull] string path);

		/// <summary>Returns the extension of the specified path string.</summary>
		/// <returns>The extension of the specified path (including the period "."), or null, or <see cref="F:System.String.Empty" />. If <paramref name="path" /> is null, <see cref="M:System.IO.Path.GetExtension(System.String)" /> returns null. If <paramref name="path" /> does not have extension information, <see cref="M:System.IO.Path.GetExtension(System.String)" /> returns <see cref="F:System.String.Empty" />.</returns>
		/// <param name="path">The path string from which to get the extension. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.  </exception>
		[CanBeNull]
		string GetExtension([CanBeNull] string path);

		/// <summary>Returns the file name and extension of the specified path string.</summary>
		/// <returns>The characters after the last directory character in <paramref name="path" />. If the last character of <paramref name="path" /> is a directory or volume separator character, this method returns <see cref="F:System.String.Empty" />. If <paramref name="path" /> is null, this method returns null.</returns>
		/// <param name="path">The path string from which to obtain the file name and extension. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />. </exception>
		[CanBeNull]
		string GetFileName([CanBeNull] string path);

		/// <summary>Returns the file name of the specified path string without the extension.</summary>
		/// <returns>The string returned by <see cref="M:System.IO.Path.GetFileName(System.String)" />, minus the last period (.) and all characters following it.</returns>
		/// <param name="path">The path of the file. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
		[CanBeNull]
		string GetFileNameWithoutExtension([CanBeNull] string path);

		/// <summary>Gets an array containing the characters that are not allowed in file names.</summary>
		/// <returns>An array containing the characters that are not allowed in file names.</returns>
		[NotNull]
		char[] GetInvalidFileNameChars();

		/// <summary>Gets an array containing the characters that are not allowed in path names.</summary>
		/// <returns>An array containing the characters that are not allowed in path names.</returns>
		[NotNull]
		char[] GetInvalidPathChars();

		/// <summary>Gets the root directory information of the specified path.</summary>
		/// <returns>The root directory of <paramref name="path" />, such as "C:\", or null if <paramref name="path" /> is null, or an empty string if <paramref name="path" /> does not contain root directory information.</returns>
		/// <param name="path">The path from which to obtain root directory information. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.-or- <see cref="F:System.String.Empty" /> was passed to <paramref name="path" />. </exception>
		[CanBeNull]
		string GetPathRoot([CanBeNull] string path);

		/// <summary>Returns a random folder name or file name.</summary>
		/// <returns>A random folder name or file name.</returns>
		[NotNull]
		string GetRandomFileName();

		/// <summary>Determines whether a path includes a file name extension.</summary>
		/// <returns>true if the characters that follow the last directory separator (\\ or /) or volume separator (:) in the path include a period (.) followed by one or more characters; otherwise, false.</returns>
		/// <param name="path">The path to search for an extension. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />. </exception>
		bool HasExtension([CanBeNull] string path);

		/// <summary>Gets a value indicating whether the specified path string contains a root.</summary>
		/// <returns>true if <paramref name="path" /> contains a root; otherwise, false.</returns>
		/// <param name="path">The path to test. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />. </exception>
		bool IsPathRooted([CanBeNull] string path);
	}
}
