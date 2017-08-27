using System;
using System.IO;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="FileSystemInfo"/>.
	/// </summary>
	public class FileSystemInfoAdapter : AbstractionAdapter<FileSystemInfo>, IFileSystemInfo
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FileSystemInfoAdapter" /> class.
		/// </summary>
		/// <param name="info">File system info to be used by the adapter.</param>
		public FileSystemInfoAdapter([NotNull] FileSystemInfo info)
			: base(info)
		{
		}

		/// <inheritdoc />
		public FileAttributes Attributes
		{
			get => Implementation.Attributes;
			set => Implementation.Attributes = value;
		}

		/// <inheritdoc />
		public DateTime CreationTime
		{
			get => Implementation.CreationTime;
			set => Implementation.CreationTime = value;
		}

		/// <inheritdoc />
		public DateTime CreationTimeUtc
		{
			get => Implementation.CreationTimeUtc;
			set => Implementation.CreationTimeUtc = value;
		}

		/// <inheritdoc />
		public bool Exists => Implementation.Exists;

		/// <inheritdoc />
		public string Extension => Implementation.Extension;

		/// <inheritdoc />
		public string FullName => Implementation.FullName;

		/// <inheritdoc />
		public string Name => Implementation.Name;

		/// <inheritdoc />
		public DateTime LastAccessTime
		{
			get => Implementation.LastAccessTime;
			set => Implementation.LastAccessTime = value;
		}

		/// <inheritdoc />
		public DateTime LastAccessTimeUtc
		{
			get => Implementation.LastAccessTimeUtc;
			set => Implementation.LastAccessTimeUtc = value;
		}

		/// <inheritdoc />
		public DateTime LastWriteTime
		{
			get => Implementation.LastWriteTime;
			set => Implementation.LastWriteTime = value;
		}

		/// <inheritdoc />
		public DateTime LastWriteTimeUtc
		{
			get => Implementation.LastWriteTimeUtc;
			set => Implementation.LastWriteTimeUtc = value;
		}

		/// <inheritdoc />
		public void Delete()
		{
			Implementation.Delete();
		}

		/// <inheritdoc />
		public void Refresh()
		{
			Implementation.Refresh();
		}
	}
}
