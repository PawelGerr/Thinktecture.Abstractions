using System.IO;
using JetBrains.Annotations;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="FileSystemInfo"/>.
	/// </summary>
	public static class FileSystemInfoExtensions
	{
		/// <summary>
		/// Converts file system info to <see cref="IFileSystemInfo"/>.
		/// </summary>
		/// <param name="info">File system info to convert.</param>
		/// <returns>Converted file system info.</returns>
		[CanBeNull]
		public static IFileSystemInfo ToInterface([CanBeNull] this FileSystemInfo info)
		{
			return (info == null) ? null : new FileSystemInfoAdapter(info);
		}
	}
}
