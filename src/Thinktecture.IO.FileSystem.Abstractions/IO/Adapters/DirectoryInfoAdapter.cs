using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="DirectoryInfo"/>.
	/// </summary>
	public class DirectoryInfoAdapter : FileSystemInfoAdapter, IDirectoryInfo
	{
		/// <inheritdoc />
		[NotNull]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new DirectoryInfo UnsafeConvert()
		{
			return Implementation;
		}

		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		[NotNull]
		protected new DirectoryInfo Implementation { get; }

		/// <summary>Initializes a new instance of the <see cref="DirectoryInfoAdapter" /> class on the specified path.</summary>
		/// <param name="path">A string specifying the path on which to create the DirectoryInfo. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="path" /> is null. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="path" /> contains invalid characters such as ", &lt;, &gt;, or |. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. The specified path, file name, or both are too long.</exception>
		public DirectoryInfoAdapter([NotNull] string path)
			: this(new DirectoryInfo(path))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DirectoryInfoAdapter" /> class
		/// </summary>
		/// <param name="directoryInfo">Directory info to be used by the adapter.</param>
		public DirectoryInfoAdapter([NotNull] DirectoryInfo directoryInfo)
			: base(directoryInfo)
		{
			Implementation = directoryInfo ?? throw new ArgumentNullException(nameof(directoryInfo));
		}

		/// <inheritdoc />
		public IDirectoryInfo Parent => Implementation.Parent.ToInterface();

		/// <inheritdoc />
		public IDirectoryInfo Root => Implementation.Root.ToInterface();

		/// <inheritdoc />
		public void Create()
		{
			Implementation.Create();
		}

		/// <inheritdoc />
		public IDirectoryInfo CreateSubdirectory(string path)
		{
			return Implementation.CreateSubdirectory(path).ToInterface();
		}

		/// <inheritdoc />
		public void Delete(bool recursive)
		{
			Implementation.Delete(recursive);
		}

		/// <inheritdoc />
		public IEnumerable<IDirectoryInfo> EnumerateDirectories()
		{
			return Convert(Implementation.EnumerateDirectories());
		}

		/// <inheritdoc />
		public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern)
		{
			return Convert(Implementation.EnumerateDirectories(searchPattern));
		}

		/// <inheritdoc />
		public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption)
		{
			return Convert(Implementation.EnumerateDirectories(searchPattern, searchOption));
		}

		/// <inheritdoc />
		public IEnumerable<IFileInfo> EnumerateFiles()
		{
			return Convert(Implementation.EnumerateFiles());
		}

		/// <inheritdoc />
		public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern)
		{
			return Convert(Implementation.EnumerateFiles(searchPattern));
		}

		/// <inheritdoc />
		public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption)
		{
			return Convert(Implementation.EnumerateFiles(searchPattern, searchOption));
		}

		/// <inheritdoc />
		public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos()
		{
			return Convert(Implementation.EnumerateFileSystemInfos());
		}

		/// <inheritdoc />
		public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern)
		{
			return Convert(Implementation.EnumerateFileSystemInfos(searchPattern));
		}

		/// <inheritdoc />
		public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption)
		{
			return Convert(Implementation.EnumerateFileSystemInfos(searchPattern, searchOption));
		}

		/// <inheritdoc />
		public IDirectoryInfo[] GetDirectories()
		{
			return Implementation.GetDirectories().ToInterface();
		}

		/// <inheritdoc />
		public IDirectoryInfo[] GetDirectories(string searchPattern)
		{
			return Implementation.GetDirectories(searchPattern).ToInterface();
		}

		/// <inheritdoc />
		public IDirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption)
		{
			return Implementation.GetDirectories(searchPattern, searchOption).ToInterface();
		}

		/// <inheritdoc />
		public IFileInfo[] GetFiles()
		{
			return Implementation.GetFiles().ToInterface();
		}

		/// <inheritdoc />
		public IFileInfo[] GetFiles(string searchPattern)
		{
			return Implementation.GetFiles(searchPattern).ToInterface();
		}

		/// <inheritdoc />
		public IFileInfo[] GetFiles(string searchPattern, SearchOption searchOption)
		{
			return Implementation.GetFiles(searchPattern, searchOption).ToInterface();
		}

		/// <inheritdoc />
		public IFileSystemInfo[] GetFileSystemInfos()
		{
			return Implementation.GetFileSystemInfos().ToInterface();
		}

		/// <inheritdoc />
		public IFileSystemInfo[] GetFileSystemInfos(string searchPattern)
		{
			return Implementation.GetFileSystemInfos(searchPattern).ToInterface();
		}

		/// <inheritdoc />
		public IFileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption)
		{
			return Implementation.GetFileSystemInfos(searchPattern, searchOption).ToInterface();
		}

		/// <inheritdoc />
		public void MoveTo(string destDirName)
		{
			Implementation.MoveTo(destDirName);
		}

		[NotNull, ItemNotNull]
		private static IEnumerable<IDirectoryInfo> Convert([NotNull, ItemNotNull] IEnumerable<DirectoryInfo> infos)
		{
			foreach (var info in infos)
			{
				yield return info.ToInterface();
			}
		}

		[NotNull, ItemNotNull]
		private static IEnumerable<IFileInfo> Convert([NotNull, ItemNotNull] IEnumerable<FileInfo> infos)
		{
			foreach (var info in infos)
			{
				yield return info.ToInterface();
			}
		}

		[NotNull, ItemNotNull]
		private static IEnumerable<IFileSystemInfo> Convert([NotNull, ItemNotNull] IEnumerable<FileSystemInfo> infos)
		{
			foreach (var info in infos)
			{
				yield return info.ToInterface();
			}
		}
	}
}
