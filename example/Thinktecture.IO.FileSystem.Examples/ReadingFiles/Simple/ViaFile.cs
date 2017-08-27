using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
			using (IStreamReader reader = _file.OpenText(_EXAMPLE_FILE_PATH))
			{
				string content = reader.ReadToEnd();
				Console.WriteLine("[ViaFile.ReadFile_With_OpenText] File content: " + content);
			}
		}

		public void ReadFile_With_OpenRead()
		{
			using (IFileStream stream = _file.OpenRead(_EXAMPLE_FILE_PATH))
			using (IStreamReader reader = new StreamReaderAdapter(stream))
			{
				string content = reader.ReadToEnd();
				Console.WriteLine("[ViaFile.ReadFile_With_OpenRead] File content: " + content);
			}
		}

		public void ReadFile_With_Open()
		{
			using (IFileStream stream = _file.Open(_EXAMPLE_FILE_PATH, FileMode.Open, FileAccess.Read, FileShare.Read))
			using (IStreamReader reader = new StreamReaderAdapter(stream))
			{
				string content = reader.ReadToEnd();
				Console.WriteLine("[ViaFile.ReadFile_With_Open] File content: " + content);
			}
		}
	}
}
