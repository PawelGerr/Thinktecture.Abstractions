using System;
using System.Collections.Generic;
using System.IO;

namespace Thinktecture.IO.Adapters
{
	public class DirectoryInfoAdapter : FileSystemInfoAdapter, IDirectoryInfo
	{
		private readonly DirectoryInfo _dir;

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.DirectoryInfo" /> class on the specified path.</summary>
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

		public DirectoryInfoAdapter(DirectoryInfo dir)
			: base(dir)
		{
			if (dir == null)
				throw new ArgumentNullException(nameof(dir));

			_dir = dir;
		}

		/// <inheritdoc />
		DirectoryInfo IDirectoryInfo.ToImplementation()
		{
			return _dir;
		}

		/// <inheritdoc />
		public IDirectoryInfo Parent => _dir.Parent.ToInterface();

		/// <inheritdoc />
		public IDirectoryInfo Root => _dir.Root.ToInterface();

		/// <inheritdoc />
		public void Create()
		{
			_dir.Create();
		}

		/// <inheritdoc />
		public IDirectoryInfo CreateSubdirectory(string path)
		{
			return _dir.CreateSubdirectory(path).ToInterface();
		}

		/// <inheritdoc />
		public void Delete(bool recursive)
		{
			_dir.Delete(recursive);
		}

		/// <inheritdoc />
		public IEnumerable<IDirectoryInfo> EnumerateDirectories()
		{
			return Convert(_dir.EnumerateDirectories());
		}

		/// <inheritdoc />
		public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern)
		{
			return Convert(_dir.EnumerateDirectories(searchPattern));
		}

		/// <inheritdoc />
		public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption)
		{
			return Convert(_dir.EnumerateDirectories(searchPattern, searchOption));
		}

		/// <inheritdoc />
		public IEnumerable<IFileInfo> EnumerateFiles()
		{
			return Convert(_dir.EnumerateFiles());
		}

		/// <inheritdoc />
		public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern)
		{
			return Convert(_dir.EnumerateFiles(searchPattern));
		}

		/// <inheritdoc />
		public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption)
		{
			return Convert(_dir.EnumerateFiles(searchPattern, searchOption));
		}

		/// <inheritdoc />
		public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos()
		{
			return Convert(_dir.EnumerateFileSystemInfos());
		}

		/// <inheritdoc />
		public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern)
		{
			return Convert(_dir.EnumerateFileSystemInfos(searchPattern));
		}

		/// <inheritdoc />
		public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption)
		{
			return Convert(_dir.EnumerateFileSystemInfos(searchPattern, searchOption));
		}

		/// <inheritdoc />
		public IDirectoryInfo[] GetDirectories()
		{
			return Convert(_dir.GetDirectories());
		}

		/// <inheritdoc />
		public IDirectoryInfo[] GetDirectories(string searchPattern)
		{
			return Convert(_dir.GetDirectories(searchPattern));
		}

		/// <inheritdoc />
		public IDirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption)
		{
			return Convert(_dir.GetDirectories(searchPattern, searchOption));
		}

		/// <inheritdoc />
		public IFileInfo[] GetFiles()
		{
			return Convert(_dir.GetFiles());
		}

		/// <inheritdoc />
		public IFileInfo[] GetFiles(string searchPattern)
		{
			return Convert(_dir.GetFiles(searchPattern));
		}

		/// <inheritdoc />
		public IFileInfo[] GetFiles(string searchPattern, SearchOption searchOption)
		{
			return Convert(_dir.GetFiles(searchPattern, searchOption));
		}

		/// <inheritdoc />
		public IFileSystemInfo[] GetFileSystemInfos()
		{
			return Convert(_dir.GetFileSystemInfos());
		}

		/// <inheritdoc />
		public IFileSystemInfo[] GetFileSystemInfos(string searchPattern)
		{
			return Convert(_dir.GetFileSystemInfos(searchPattern));
		}

		/// <inheritdoc />
		public IFileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption)
		{
			return Convert(_dir.GetFileSystemInfos(searchPattern, searchOption));
		}

		/// <inheritdoc />
		public void MoveTo(string destDirName)
		{
			_dir.MoveTo(destDirName);
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