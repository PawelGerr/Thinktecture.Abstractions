using System.IO;
using JetBrains.Annotations;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

// ReSharper disable once CheckNamespace
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
		[CanBeNull]
		public static IFileSystemWatcher ToInterface([CanBeNull] this FileSystemWatcher watcher)
		{
			return (watcher == null) ? null : new FileSystemWatcherAdapter(watcher);
		}
	}
}
