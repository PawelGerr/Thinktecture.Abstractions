using System;
using System.IO;

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="FileSystemInfo"/>.
	/// </summary>
	public class FileSystemInfoAdapter : IFileSystemInfo
	{
		private readonly FileSystemInfo _info;

		/// <summary>
		/// Initializes a new instance of the <see cref="FileSystemInfoAdapter" /> class.
		/// </summary>
		/// <param name="info">File system info to be used by the adapter.</param>
		public FileSystemInfoAdapter(FileSystemInfo info)
		{
			if (info == null)
				throw new ArgumentNullException(nameof(info));

			_info = info;
		}

		/// <inheritdoc />
		public FileSystemInfo ToImplementation()
		{
			return _info;
		}

		/// <inheritdoc />
		public FileAttributes Attributes
		{
			get { return _info.Attributes; }
			set { _info.Attributes = value; }
		}

		/// <inheritdoc />
		public DateTime CreationTime
		{
			get { return _info.CreationTime; }
			set { _info.CreationTime = value; }
		}

		/// <inheritdoc />
		public DateTime CreationTimeUtc
		{
			get { return _info.CreationTimeUtc; }
			set { _info.CreationTimeUtc = value; }
		}

		/// <inheritdoc />
		public bool Exists => _info.Exists;

		/// <inheritdoc />
		public string Extension => _info.Extension;

		/// <inheritdoc />
		public string FullName => _info.FullName;

		/// <inheritdoc />
		public string Name => _info.Name;

		/// <inheritdoc />
		public DateTime LastAccessTime
		{
			get { return _info.LastAccessTime; }
			set { _info.LastAccessTime = value; }
		}

		/// <inheritdoc />
		public DateTime LastAccessTimeUtc
		{
			get { return _info.LastAccessTimeUtc; }
			set { _info.LastAccessTimeUtc = value; }
		}

		/// <inheritdoc />
		public DateTime LastWriteTime
		{
			get { return _info.LastWriteTime; }
			set { _info.LastWriteTime = value; }
		}

		/// <inheritdoc />
		public DateTime LastWriteTimeUtc
		{
			get { return _info.LastWriteTimeUtc; }
			set { _info.LastWriteTimeUtc = value; }
		}

		/// <inheritdoc />
		public void Delete()
		{
			_info.Delete();
		}

		/// <inheritdoc />
		public void Refresh()
		{
			_info.Refresh();
		}
	}
}