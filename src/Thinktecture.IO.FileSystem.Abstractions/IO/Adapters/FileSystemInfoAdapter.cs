using System;
using System.ComponentModel;
using System.IO;

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="FileSystemInfo"/>.
	/// </summary>
	public class FileSystemInfoAdapter : IFileSystemInfo
	{
		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public FileSystemInfo InternalInstance { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="FileSystemInfoAdapter" /> class.
		/// </summary>
		/// <param name="info">File system info to be used by the adapter.</param>
		public FileSystemInfoAdapter(FileSystemInfo info)
		{
			if (info == null)
				throw new ArgumentNullException(nameof(info));

			InternalInstance = info;
		}
		
		/// <inheritdoc />
		public FileAttributes Attributes
		{
			get { return InternalInstance.Attributes; }
			set { InternalInstance.Attributes = value; }
		}

		/// <inheritdoc />
		public DateTime CreationTime
		{
			get { return InternalInstance.CreationTime; }
			set { InternalInstance.CreationTime = value; }
		}

		/// <inheritdoc />
		public DateTime CreationTimeUtc
		{
			get { return InternalInstance.CreationTimeUtc; }
			set { InternalInstance.CreationTimeUtc = value; }
		}

		/// <inheritdoc />
		public bool Exists => InternalInstance.Exists;

		/// <inheritdoc />
		public string Extension => InternalInstance.Extension;

		/// <inheritdoc />
		public string FullName => InternalInstance.FullName;

		/// <inheritdoc />
		public string Name => InternalInstance.Name;

		/// <inheritdoc />
		public DateTime LastAccessTime
		{
			get { return InternalInstance.LastAccessTime; }
			set { InternalInstance.LastAccessTime = value; }
		}

		/// <inheritdoc />
		public DateTime LastAccessTimeUtc
		{
			get { return InternalInstance.LastAccessTimeUtc; }
			set { InternalInstance.LastAccessTimeUtc = value; }
		}

		/// <inheritdoc />
		public DateTime LastWriteTime
		{
			get { return InternalInstance.LastWriteTime; }
			set { InternalInstance.LastWriteTime = value; }
		}

		/// <inheritdoc />
		public DateTime LastWriteTimeUtc
		{
			get { return InternalInstance.LastWriteTimeUtc; }
			set { InternalInstance.LastWriteTimeUtc = value; }
		}

		/// <inheritdoc />
		public void Delete()
		{
			InternalInstance.Delete();
		}

		/// <inheritdoc />
		public void Refresh()
		{
			InternalInstance.Refresh();
		}
	}
}