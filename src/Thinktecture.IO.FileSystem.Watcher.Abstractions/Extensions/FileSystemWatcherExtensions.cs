using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="FileSystemWatcher"/>.
	/// </summary>
	public static class FileSystemWatcherExtensions
	{
		/// <summary>
		/// Converts provided <see cref="FileSystemWatcher"/> to <see cref="IFileSystemWatcher"/>.
		/// </summary>
		/// <param name="watcher"><see cref="FileSystemWatcher"/> to convert.</param>
		/// <returns>An instance of <see cref="IFileSystemWatcher"/>.</returns>
		public static IFileSystemWatcher ToInterface(this FileSystemWatcher watcher)
		{
			return (watcher == null) ? null : new FileSystemWatcherAdapter(watcher);
		}

		/// <summary>
		/// Converts provided <see cref="IFileSystemWatcher"/> to <see cref="FileSystemWatcher"/>.
		/// </summary>
		/// <param name="watcher"><see cref="IFileSystemWatcher"/> to convert.</param>
		/// <returns>An instance of <see cref="FileSystemWatcher"/>.</returns>
		public static FileSystemWatcher ToImplementation(this IFileSystemWatcher watcher)
		{
			return watcher?.UnsafeConvert();
		}
	}
}