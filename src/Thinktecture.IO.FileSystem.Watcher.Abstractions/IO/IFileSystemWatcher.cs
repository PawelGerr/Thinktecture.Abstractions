using System;
using System.IO;
using JetBrains.Annotations;

namespace Thinktecture.IO
{
	/// <summary>Listens to the file system change notifications and raises events when a directory, or file in a directory, changes.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	public interface IFileSystemWatcher : IAbstraction<FileSystemWatcher>, IDisposable
	{
		/// <summary>Gets or sets a value indicating whether the component is enabled.</summary>
		/// <returns>true if the component is enabled; otherwise, false. The default is false. If you are using the component on a designer in Visual Studio 2005, the default is true.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.FileSystemWatcher" /> object has been disposed.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows NT or later.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The directory specified in <see cref="P:System.IO.FileSystemWatcher.Path" /> could not be found.</exception>
		/// <exception cref="T:System.ArgumentException">
		/// <see cref="P:System.IO.FileSystemWatcher.Path" /> has not been set or is invalid.</exception>
		bool EnableRaisingEvents { get; set; }

		/// <summary>Gets or sets the filter string used to determine what files are monitored in a directory.</summary>
		/// <returns>The filter string. The default is "*.*" (Watches all files.) </returns>
		[CanBeNull]
		string Filter { [NotNull] get; [CanBeNull] set; }

		/// <summary>Gets or sets a value indicating whether subdirectories within the specified path should be monitored.</summary>
		/// <returns>true if you want to monitor subdirectories; otherwise, false. The default is false.</returns>
		bool IncludeSubdirectories { get; set; }

		/// <summary>Gets or sets the size (in bytes) of the internal buffer.</summary>
		/// <returns>The internal buffer size in bytes. The default is 8192 (8 KB).</returns>
		int InternalBufferSize { get; set; }

		/// <summary>Gets or sets the type of changes to watch for.</summary>
		/// <returns>One of the <see cref="T:System.IO.NotifyFilters" /> values. The default is the bitwise OR combination of LastWrite, FileName, and DirectoryName.</returns>
		/// <exception cref="T:System.ArgumentException">The value is not a valid bitwise OR combination of the <see cref="T:System.IO.NotifyFilters" /> values. </exception>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value that is being set is not valid.</exception>
		NotifyFilters NotifyFilter { get; set; }

		/// <summary>Gets or sets the path of the directory to watch.</summary>
		/// <returns>The path to monitor. The default is an empty string ("").</returns>
		/// <exception cref="T:System.ArgumentException">The specified path does not exist or could not be found.-or- The specified path contains wildcard characters.-or- The specified path contains invalid path characters.</exception>
		[CanBeNull]
		string Path { [CanBeNull] get; [CanBeNull] set; }

		/// <summary>
		/// Occurs when a file or directory in the specified <see cref="P:System.IO.FileSystemWatcher.Path" /> is changed.
		/// </summary>
		event FileSystemEventHandler Changed;

		/// <summary>
		/// Occurs when a file or directory in the specified <see cref="P:System.IO.FileSystemWatcher.Path" /> is created.
		/// </summary>
		event FileSystemEventHandler Created;

		/// <summary>
		/// Occurs when a file or directory in the specified <see cref="P:System.IO.FileSystemWatcher.Path" /> is deleted.
		/// </summary>
		event FileSystemEventHandler Deleted;

		/// <summary>Occurs when the instance of <see cref="T:System.IO.FileSystemWatcher" /> is unable to continue monitoring changes or when the internal buffer overflows.</summary>
		event ErrorEventHandler Error;

		/// <summary>Occurs when a file or directory in the specified <see cref="P:System.IO.FileSystemWatcher.Path" /> is renamed.</summary>
		event RenamedEventHandler Renamed;

		/// <summary>
		/// A synchronous method that returns a structure that contains specific information on the change that occurred, given the type of change you want to monitor.
		/// </summary>
		/// <param name="changeType">The <see cref="WatcherChangeTypes"/> to watch for.</param>
		/// <returns>A <see cref="WaitForChangedResult"/> that contains specific information on the change that occurred.</returns>
		WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType);

		/// <summary>
		/// A synchronous method that returns a structure that contains specific information on the change that occurred, given the type of change you want to monitor and the time (in milliseconds) to wait before timing out.
		/// </summary>
		/// <param name="changeType">The <see cref="WatcherChangeTypes"/> to watch for.</param>
		/// <param name="timeout">The time (in milliseconds) to wait before timing out.</param>
		/// <returns>A <see cref="WaitForChangedResult"/> that contains specific information on the change that occurred.</returns>
		WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType, int timeout);
	}
}
