using System;
using System.ComponentModel;
using System.IO;

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="FileInfo"/>.
	/// </summary>
	public class FileInfoAdapter : FileSystemInfoAdapter, IFileInfo
	{
		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new FileInfo UnsafeConvert()
		{
			return _instance;
		}

		private readonly FileInfo _instance;

		/// <summary>Initializes a new instance of the <see cref="FileInfoAdapter" /> class, which acts as a wrapper for a file path.</summary>
		/// <param name="fileName">The fully qualified name of the new file, or the relative file name. Do not end the path with the directory separator character.</param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="fileName" /> is null. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentException">The file name is empty, contains only white spaces, or contains invalid characters. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Access to <paramref name="fileName" /> is denied. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.NotSupportedException">
		/// <paramref name="fileName" /> contains a colon (:) in the middle of the string. </exception>
		public FileInfoAdapter(string fileName)
			: this(new FileInfo(fileName))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FileInfoAdapter" /> class.
		/// </summary>
		/// <param name="info">File info to be used by the adapter.</param>
		public FileInfoAdapter(FileInfo info)
			: base(info)
		{
			if (info == null)
				throw new ArgumentNullException(nameof(info));

			_instance = info;
		}

		/// <inheritdoc />
		public IDirectoryInfo Directory => _instance.Directory.ToInterface();

		/// <inheritdoc />
		public string DirectoryName => _instance.DirectoryName;

		/// <inheritdoc />
		public bool IsReadOnly
		{
			get { return _instance.IsReadOnly; }
			set { _instance.IsReadOnly = value; }
		}

		/// <inheritdoc />
		public long Length => _instance.Length;

		/// <inheritdoc />
		public IStreamWriter AppendText()
		{
			return _instance.AppendText().ToInterface();
		}

		/// <inheritdoc />
		public IFileInfo CopyTo(string destFileName)
		{
			return _instance.CopyTo(destFileName).ToInterface();
		}

		/// <inheritdoc />
		public IFileInfo CopyTo(string destFileName, bool overwrite)
		{
			return _instance.CopyTo(destFileName, overwrite).ToInterface();
		}

		/// <inheritdoc />
		public IFileStream Create()
		{
			return _instance.Create().ToInterface();
		}

		/// <inheritdoc />
		public IStreamWriter CreateText()
		{
			return _instance.CreateText().ToInterface();
		}

		/// <inheritdoc />
		public void MoveTo(string destFileName)
		{
			_instance.MoveTo(destFileName);
		}

		/// <inheritdoc />
		public IFileStream Open(FileMode mode)
		{
			return _instance.Open(mode).ToInterface();
		}

		/// <inheritdoc />
		public IFileStream Open(FileMode mode, FileAccess access)
		{
			return _instance.Open(mode, access).ToInterface();
		}

		/// <inheritdoc />
		public IFileStream Open(FileMode mode, FileAccess access, FileShare share)
		{
			return _instance.Open(mode, access, share).ToInterface();
		}

		/// <inheritdoc />
		public IFileStream OpenRead()
		{
			return _instance.OpenRead().ToInterface();
		}

		/// <inheritdoc />
		public IStreamReader OpenText()
		{
			return _instance.OpenText().ToInterface();
		}

		/// <inheritdoc />
		public IFileStream OpenWrite()
		{
			return _instance.OpenWrite().ToInterface();
		}
	}
}