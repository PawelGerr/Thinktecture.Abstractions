using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thinktecture.IO.FileSystem.Examples.Factories;

namespace Thinktecture.IO.FileSystem.Examples.ReadingFiles.Recommended
{
	public class ViaFile
	{
		private const string _EXAMPLE_FILE_PATH = "ReadingFiles/Example.txt";

		private readonly IFile _file;
		private readonly ICustomFactory _factory;

		public ViaFile(IFile file, ICustomFactory factory)
		{
			_file = file ?? throw new ArgumentNullException(nameof(file));
			_factory = factory ?? throw new ArgumentNullException(nameof(factory));
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
			using (IStreamReader reader = _factory.CreateReader(stream))
			{
				string content = reader.ReadToEnd();
				Console.WriteLine("[ViaFile.ReadFile_With_OpenRead] File content: " + content);
			}
		}

		public void ReadFile_With_Open()
		{
			using (IFileStream stream = _file.Open(_EXAMPLE_FILE_PATH, FileMode.Open, FileAccess.Read, FileShare.Read))
			using (IStreamReader reader = _factory.CreateReader(stream))
			{
				string content = reader.ReadToEnd();
				Console.WriteLine("[ViaFile.ReadFile_With_Open] File content: " + content);
			}
		}
	}
}
