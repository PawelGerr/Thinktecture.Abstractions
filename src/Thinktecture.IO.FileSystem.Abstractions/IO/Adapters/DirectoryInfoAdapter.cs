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
		public new DirectoryInfo InternalInstance { get; }

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
			if (directoryInfo == null)
				throw new ArgumentNullException(nameof(directoryInfo));

			InternalInstance = directoryInfo;
		}
		
		/// <inheritdoc />
		public IDirectoryInfo Parent => InternalInstance.Parent.ToInterface();

		/// <inheritdoc />
		public IDirectoryInfo Root => InternalInstance.Root.ToInterface();

		/// <inheritdoc />
		public void Create()
		{
			InternalInstance.Create();
		}

		/// <inheritdoc />
		public IDirectoryInfo CreateSubdirectory(string path)
		{
			return InternalInstance.CreateSubdirectory(path).ToInterface();
		}

		/// <inheritdoc />
		public void Delete(bool recursive)
		{
			InternalInstance.Delete(recursive);
		}

		/// <inheritdoc />
		public IEnumerable<IDirectoryInfo> EnumerateDirectories()
		{
			return Convert(InternalInstance.EnumerateDirectories());
		}

		/// <inheritdoc />
		public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern)
		{
			return Convert(InternalInstance.EnumerateDirectories(searchPattern));
		}

		/// <inheritdoc />
		public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption)
		{
			return Convert(InternalInstance.EnumerateDirectories(searchPattern, searchOption));
		}

		/// <inheritdoc />
		public IEnumerable<IFileInfo> EnumerateFiles()
		{
			return Convert(InternalInstance.EnumerateFiles());
		}

		/// <inheritdoc />
		public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern)
		{
			return Convert(InternalInstance.EnumerateFiles(searchPattern));
		}

		/// <inheritdoc />
		public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption)
		{
			return Convert(InternalInstance.EnumerateFiles(searchPattern, searchOption));
		}

		/// <inheritdoc />
		public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos()
		{
			return Convert(InternalInstance.EnumerateFileSystemInfos());
		}

		/// <inheritdoc />
		public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern)
		{
			return Convert(InternalInstance.EnumerateFileSystemInfos(searchPattern));
		}

		/// <inheritdoc />
		public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption)
		{
			return Convert(InternalInstance.EnumerateFileSystemInfos(searchPattern, searchOption));
		}

		/// <inheritdoc />
		public IDirectoryInfo[] GetDirectories()
		{
			return Convert(InternalInstance.GetDirectories());
		}

		/// <inheritdoc />
		public IDirectoryInfo[] GetDirectories(string searchPattern)
		{
			return Convert(InternalInstance.GetDirectories(searchPattern));
		}

		/// <inheritdoc />
		public IDirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption)
		{
			return Convert(InternalInstance.GetDirectories(searchPattern, searchOption));
		}

		/// <inheritdoc />
		public IFileInfo[] GetFiles()
		{
			return Convert(InternalInstance.GetFiles());
		}

		/// <inheritdoc />
		public IFileInfo[] GetFiles(string searchPattern)
		{
			return Convert(InternalInstance.GetFiles(searchPattern));
		}

		/// <inheritdoc />
		public IFileInfo[] GetFiles(string searchPattern, SearchOption searchOption)
		{
			return Convert(InternalInstance.GetFiles(searchPattern, searchOption));
		}

		/// <inheritdoc />
		public IFileSystemInfo[] GetFileSystemInfos()
		{
			return Convert(InternalInstance.GetFileSystemInfos());
		}

		/// <inheritdoc />
		public IFileSystemInfo[] GetFileSystemInfos(string searchPattern)
		{
			return Convert(InternalInstance.GetFileSystemInfos(searchPattern));
		}

		/// <inheritdoc />
		public IFileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption)
		{
			return Convert(InternalInstance.GetFileSystemInfos(searchPattern, searchOption));
		}

		/// <inheritdoc />
		public void MoveTo(string destDirName)
		{
			InternalInstance.MoveTo(destDirName);
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

		private IDirectoryInfo[] Convert(DirectoryInfo[] infos)
		{
			var interfaces = new IDirectoryInfo[infos.Length];

			for (var i = 0; i < infos.Length; i++)
			{
				interfaces[i] = infos[i].ToInterface();
			}

			return interfaces;
		}

		private IFileInfo[] Convert(FileInfo[] infos)
		{
			var interfaces = new IFileInfo[infos.Length];

			for (var i = 0; i < infos.Length; i++)
			{
				interfaces[i] = infos[i].ToInterface();
			}

			return interfaces;
		}

		private IFileSystemInfo[] Convert(FileSystemInfo[] infos)
		{
			var interfaces = new IFileSystemInfo[infos.Length];

			for (var i = 0; i < infos.Length; i++)
			{
				interfaces[i] = infos[i].ToInterface();
			}

			return interfaces;
		}
	}
}