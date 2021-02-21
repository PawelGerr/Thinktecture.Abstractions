using System;
using System.IO;
using Thinktecture.IO.Adapters;

namespace Thinktecture.IO.FileSystem.Examples.ReadingFiles.Simple
{
	public class ViaFile
	{
		private const string _EXAMPLE_FILE_PATH = "ReadingFiles/Example.txt";

		private readonly IFile _file;

		public ViaFile(IFile file)
		{
			_file = file ?? throw new ArgumentNullException(nameof(file));
		}

		public void ReadFile_With_OpenText()
		{
			using (var reader = _file.OpenText(_EXAMPLE_FILE_PATH))
			{
				var content = reader.ReadToEnd();
				Console.WriteLine("[ViaFile.ReadFile_With_OpenText] File content: " + content);
			}
		}

		public void ReadFile_With_OpenRead()
		{
			using (var stream = _file.OpenRead(_EXAMPLE_FILE_PATH))
			using (var reader = new StreamReaderAdapter(stream))
			{
				var content = reader.ReadToEnd();
				Console.WriteLine("[ViaFile.ReadFile_With_OpenRead] File content: " + content);
			}
		}

		public void ReadFile_With_Open()
		{
			using (var stream = _file.Open(_EXAMPLE_FILE_PATH, FileMode.Open, FileAccess.Read, FileShare.Read))
			using (var reader = new StreamReaderAdapter(stream))
			{
				var content = reader.ReadToEnd();
				Console.WriteLine("[ViaFile.ReadFile_With_Open] File content: " + content);
			}
		}
	}
}
