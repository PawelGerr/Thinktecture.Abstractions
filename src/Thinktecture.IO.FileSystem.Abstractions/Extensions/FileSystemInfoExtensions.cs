using System;
using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

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
		public static IFileSystemInfo ToInterface(this FileSystemInfo info)
		{
			return (info == null) ? null : new FileSystemInfoAdapter(info);
		}

		/// <summary>
		/// Converts file system info to <see cref="FileSystemInfo"/>.
		/// </summary>
		/// <param name="info">File system info to convert.</param>
		/// <returns>Converted file system info.</returns>
		public static FileSystemInfo ToImplementation(this IFileSystemInfo info)
		{
			return info?.UnsafeConvert();
		}
	}
}