using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Thinktecture.IO
{
	public class DirectoryInfoAdapter : FileSystemInfoAdapter, IDirectoryInfo
	{
		private readonly DirectoryInfo _dir;

		public DirectoryInfoAdapter(DirectoryInfo dir) :
			base(dir)
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
			return _dir.EnumerateDirectories().Select(d => d.ToInterface());
		}

		/// <inheritdoc />
		public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern)
		{
			return _dir.EnumerateDirectories(searchPattern).Select(d => d.ToInterface());
		}

		/// <inheritdoc />
		public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption)
		{
			return _dir.EnumerateDirectories(searchPattern, searchOption).Select(d => d.ToInterface());
		}

		/// <inheritdoc />
		public IEnumerable<IFileInfo> EnumerateFiles()
		{
			return _dir.EnumerateFiles().Select(f => f.ToInterface());
		}

		/// <inheritdoc />
		public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern)
		{
			return _dir.EnumerateFiles(searchPattern).Select(f => f.ToInterface());
		}

		/// <inheritdoc />
		public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption)
		{
			return _dir.EnumerateFiles(searchPattern, searchOption).Select(f => f.ToInterface());
		}

		/// <inheritdoc />
		public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos()
		{
			return _dir.EnumerateFileSystemInfos().Select(f => f.ToInterface());
		}

		/// <inheritdoc />
		public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern)
		{
			return _dir.EnumerateFileSystemInfos(searchPattern).Select(f => f.ToInterface());
		}

		/// <inheritdoc />
		public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption)
		{
			return _dir.EnumerateFileSystemInfos(searchPattern, searchOption).Select(f => f.ToInterface());
		}

		/// <inheritdoc />
		public IDirectoryInfo[] GetDirectories()
		{
			return _dir.GetDirectories().Select(d => d.ToInterface()).ToArray();
		}

		/// <inheritdoc />
		public IDirectoryInfo[] GetDirectories(string searchPattern)
		{
			return _dir.GetDirectories(searchPattern).Select(d => d.ToInterface()).ToArray();
		}

		/// <inheritdoc />
		public IDirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption)
		{
			return _dir.GetDirectories(searchPattern, searchOption).Select(d => d.ToInterface()).ToArray();
		}

		/// <inheritdoc />
		public IFileInfo[] GetFiles()
		{
			return _dir.GetFiles().Select(f => f.ToInterface()).ToArray();
		}

		/// <inheritdoc />
		public IFileInfo[] GetFiles(string searchPattern)
		{
			return _dir.GetFiles(searchPattern).Select(f => f.ToInterface()).ToArray();
		}

		/// <inheritdoc />
		public IFileInfo[] GetFiles(string searchPattern, SearchOption searchOption)
		{
			return _dir.GetFiles(searchPattern, searchOption).Select(f => f.ToInterface()).ToArray();
		}

		/// <inheritdoc />
		public IFileSystemInfo[] GetFileSystemInfos()
		{
			return _dir.GetFileSystemInfos().Select(f => f.ToInterface()).ToArray();
		}

		/// <inheritdoc />
		public IFileSystemInfo[] GetFileSystemInfos(string searchPattern)
		{
			return _dir.GetFileSystemInfos(searchPattern).Select(f => f.ToInterface()).ToArray();
		}

		/// <inheritdoc />
		public IFileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption)
		{
			return _dir.GetFileSystemInfos(searchPattern, searchOption).Select(f => f.ToInterface()).ToArray();
		}

		/// <inheritdoc />
		public void MoveTo(string destDirName)
		{
			_dir.MoveTo(destDirName);
		}
	
	}
}