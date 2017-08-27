using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="DirectoryInfo"/>.
	/// </summary>
	public class DirectoryInfoAdapter : FileSystemInfoAdapter, IDirectoryInfo
	{
		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new DirectoryInfo UnsafeConvert()
		{
			return _instance;
		}

		private readonly DirectoryInfo _instance;

		/// <summary>Initializes a new instance of the <see cref="DirectoryInfoAdapter" /> class on the specified path.</summary>
		/// <param name="path">A string specifying the path on which to create the DirectoryInfo. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="path" /> is null. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="path" /> contains invalid characters such as ", &lt;, &gt;, or |. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. The specified path, file name, or both are too long.</exception>
		public DirectoryInfoAdapter(string path)
			: this(new DirectoryInfo(path))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DirectoryInfoAdapter" /> class
		/// </summary>
		/// <param name="directoryInfo">Directory info to be used by the adapter.</param>
		public DirectoryInfoAdapter(DirectoryInfo directoryInfo)
			: base(directoryInfo)
		{
			_instance = directoryInfo ?? throw new ArgumentNullException(nameof(directoryInfo));
		}

		/// <inheritdoc />
		public IDirectoryInfo Parent => _instance.Parent.ToInterface();

		/// <inheritdoc />
		public IDirectoryInfo Root => _instance.Root.ToInterface();

		/// <inheritdoc />
		public void Create()
		{
			_instance.Create();
		}

		/// <inheritdoc />
		public IDirectoryInfo CreateSubdirectory(string path)
		{
			return _instance.CreateSubdirectory(path).ToInterface();
		}

		/// <inheritdoc />
		public void Delete(bool recursive)
		{
			_instance.Delete(recursive);
		}

		/// <inheritdoc />
		public IEnumerable<IDirectoryInfo> EnumerateDirectories()
		{
			return Convert(_instance.EnumerateDirectories());
		}

		/// <inheritdoc />
		public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern)
		{
			return Convert(_instance.EnumerateDirectories(searchPattern));
		}

		/// <inheritdoc />
		public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption)
		{
			return Convert(_instance.EnumerateDirectories(searchPattern, searchOption));
		}

		/// <inheritdoc />
		public IEnumerable<IFileInfo> EnumerateFiles()
		{
			return Convert(_instance.EnumerateFiles());
		}

		/// <inheritdoc />
		public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern)
		{
			return Convert(_instance.EnumerateFiles(searchPattern));
		}

		/// <inheritdoc />
		public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption)
		{
			return Convert(_instance.EnumerateFiles(searchPattern, searchOption));
		}

		/// <inheritdoc />
		public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos()
		{
			return Convert(_instance.EnumerateFileSystemInfos());
		}

		/// <inheritdoc />
		public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern)
		{
			return Convert(_instance.EnumerateFileSystemInfos(searchPattern));
		}

		/// <inheritdoc />
		public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption)
		{
			return Convert(_instance.EnumerateFileSystemInfos(searchPattern, searchOption));
		}

		/// <inheritdoc />
		public IDirectoryInfo[] GetDirectories()
		{
			return _instance.GetDirectories().ToInterface();
		}

		/// <inheritdoc />
		public IDirectoryInfo[] GetDirectories(string searchPattern)
		{
			return _instance.GetDirectories(searchPattern).ToInterface();
		}

		/// <inheritdoc />
		public IDirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption)
		{
			return _instance.GetDirectories(searchPattern, searchOption).ToInterface();
		}

		/// <inheritdoc />
		public IFileInfo[] GetFiles()
		{
			return _instance.GetFiles().ToInterface();
		}

		/// <inheritdoc />
		public IFileInfo[] GetFiles(string searchPattern)
		{
			return _instance.GetFiles(searchPattern).ToInterface();
		}

		/// <inheritdoc />
		public IFileInfo[] GetFiles(string searchPattern, SearchOption searchOption)
		{
			return _instance.GetFiles(searchPattern, searchOption).ToInterface();
		}

		/// <inheritdoc />
		public IFileSystemInfo[] GetFileSystemInfos()
		{
			return _instance.GetFileSystemInfos().ToInterface();
		}

		/// <inheritdoc />
		public IFileSystemInfo[] GetFileSystemInfos(string searchPattern)
		{
			return _instance.GetFileSystemInfos(searchPattern).ToInterface();
		}

		/// <inheritdoc />
		public IFileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption)
		{
			return _instance.GetFileSystemInfos(searchPattern, searchOption).ToInterface();
		}

		/// <inheritdoc />
		public void MoveTo(string destDirName)
		{
			_instance.MoveTo(destDirName);
		}

		private IEnumerable<IDirectoryInfo> Convert(IEnumerable<DirectoryInfo> infos)
		{
			foreach (var info in infos)
			{
				yield return info.ToInterface();
			}
		}

		private IEnumerable<IFileInfo> Convert(IEnumerable<FileInfo> infos)
		{
			foreach (var info in infos)
			{
				yield return info.ToInterface();
			}
		}

		private IEnumerable<IFileSystemInfo> Convert(IEnumerable<FileSystemInfo> infos)
		{
			foreach (var info in infos)
			{
				yield return info.ToInterface();
			}
		}
	}
}
