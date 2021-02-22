using System.Diagnostics.CodeAnalysis;
using System.IO;
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
		[return:NotNullIfNotNull("watcher")]
		public static IFileSystemWatcher? ToInterface(this FileSystemWatcher? watcher)
		{
			return watcher == null ? null : new FileSystemWatcherAdapter(watcher);
		}
	}
}
