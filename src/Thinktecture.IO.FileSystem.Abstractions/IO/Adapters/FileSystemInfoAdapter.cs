using System;
using System.ComponentModel;
using System.IO;

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="FileSystemInfo"/>.
	/// </summary>
	public class FileSystemInfoAdapter : AbstractionAdapter, IFileSystemInfo
	{
		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new FileSystemInfo UnsafeConvert()
		{
			return _instance;
		}

		private readonly FileSystemInfo _instance;

		/// <summary>
		/// Initializes a new instance of the <see cref="FileSystemInfoAdapter" /> class.
		/// </summary>
		/// <param name="info">File system info to be used by the adapter.</param>
		public FileSystemInfoAdapter(FileSystemInfo info)
			: base(info)
		{
			if (info == null)
				throw new ArgumentNullException(nameof(info));

			_instance = info;
		}

		/// <inheritdoc />
		public FileAttributes Attributes
		{
			get { return _instance.Attributes; }
			set { _instance.Attributes = value; }
		}

		/// <inheritdoc />
		public DateTime CreationTime
		{
			get { return _instance.CreationTime; }
			set { _instance.CreationTime = value; }
		}

		/// <inheritdoc />
		public DateTime CreationTimeUtc
		{
			get { return _instance.CreationTimeUtc; }
			set { _instance.CreationTimeUtc = value; }
		}

		/// <inheritdoc />
		public bool Exists => _instance.Exists;

		/// <inheritdoc />
		public string Extension => _instance.Extension;

		/// <inheritdoc />
		public string FullName => _instance.FullName;

		/// <inheritdoc />
		public string Name => _instance.Name;

		/// <inheritdoc />
		public DateTime LastAccessTime
		{
			get { return _instance.LastAccessTime; }
			set { _instance.LastAccessTime = value; }
		}

		/// <inheritdoc />
		public DateTime LastAccessTimeUtc
		{
			get { return _instance.LastAccessTimeUtc; }
			set { _instance.LastAccessTimeUtc = value; }
		}

		/// <inheritdoc />
		public DateTime LastWriteTime
		{
			get { return _instance.LastWriteTime; }
			set { _instance.LastWriteTime = value; }
		}

		/// <inheritdoc />
		public DateTime LastWriteTimeUtc
		{
			get { return _instance.LastWriteTimeUtc; }
			set { _instance.LastWriteTimeUtc = value; }
		}

		/// <inheritdoc />
		public void Delete()
		{
			_instance.Delete();
		}

		/// <inheritdoc />
		public void Refresh()
		{
			_instance.Refresh();
		}
	}
}