using System;
using System.IO;
using Thinktecture.IO.Extensions;

namespace Thinktecture.IO
{
	public class FileInfoAdapter : FileSystemInfoAdapter, IFileInfo
	{
		private readonly FileInfo _info;

		public FileInfoAdapter(FileInfo info) 
			: base(info)
		{
			_info = info;
		}

		/// <inheritdoc />
		FileInfo IFileInfo.ToImplementation()
		{
			return _info;
		}

		/// <inheritdoc />
		public IDirectoryInfo Directory => _info.Directory.ToInterface();

		/// <inheritdoc />
		public string DirectoryName => _info.DirectoryName;
	
		/// <inheritdoc />
		public bool IsReadOnly
		{
			get { return _info.IsReadOnly; }
			set { _info.IsReadOnly = value; }
		}
		
		/// <inheritdoc />
		public long Length => _info.Length;

		/// <inheritdoc />
		public IStreamWriter AppendText()
		{
			return _info.AppendText().ToInterface();
		}

		/// <inheritdoc />
		public IFileInfo CopyTo(string destFileName)
		{
			return _info.CopyTo(destFileName).ToInterface();
		}

		/// <inheritdoc />
		public IFileInfo CopyTo(string destFileName, bool overwrite)
		{
			return _info.CopyTo(destFileName, overwrite).ToInterface();
		}

		/// <inheritdoc />
		public IFileStream Create()
		{
			return _info.Create().ToInterface();
		}

		/// <inheritdoc />
		public IStreamWriter CreateText()
		{
			return _info.CreateText().ToInterface();
		}
	
		/// <inheritdoc />
		public void MoveTo(string destFileName)
		{
			_info.MoveTo(destFileName);
		}

		/// <inheritdoc />
		public IFileStream Open(FileMode mode)
		{
			return _info.Open(mode).ToInterface();
		}

		/// <inheritdoc />
		public IFileStream Open(FileMode mode, FileAccess access)
		{
			return _info.Open(mode, access).ToInterface();
		}

		/// <inheritdoc />
		public IFileStream Open(FileMode mode, FileAccess access, FileShare share)
		{
			return _info.Open(mode, access, share).ToInterface();
		}

		/// <inheritdoc />
		public IFileStream OpenRead()
		{
			return _info.OpenRead().ToInterface();
		}

		/// <inheritdoc />
		public IStreamReader OpenText()
		{
			return _info.OpenText().ToInterface();
		}

		/// <inheritdoc />
		public IFileStream OpenWrite()
		{
			return _info.OpenWrite().ToInterface();
		}
		
	}
}