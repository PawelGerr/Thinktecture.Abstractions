using System;
using System.IO;
using Thinktecture.Win32.SafeHandles;

namespace Thinktecture.IO.Adapters
{
	public class FileStreamAdapter : StreamAdapter, IFileStream
	{
		private readonly FileStream _fileStream;

		/// <inheritdoc />
		public bool IsAsync => _fileStream.IsAsync;

		/// <inheritdoc />
		public string Name => _fileStream.Name;

		/// <inheritdoc />
		public ISafeFileHandle SafeFileHandle => _fileStream.SafeFileHandle.ToInterface();

		public FileStreamAdapter(FileStream fileStream) 
			: base(fileStream)
		{
			if (fileStream == null)
				throw new ArgumentNullException(nameof(fileStream));

			_fileStream = fileStream;
		}

		/// <inheritdoc />
		FileStream IFileStream.ToImplementation()
		{
			return _fileStream;
		}

		/// <inheritdoc />
		public void Flush(bool flushToDisk)
		{
			_fileStream.Flush(flushToDisk);
		}
	}
}