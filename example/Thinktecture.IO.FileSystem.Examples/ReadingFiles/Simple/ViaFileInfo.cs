using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thinktecture.IO.Adapters;

namespace Thinktecture.IO.FileSystem.Examples.ReadingFiles.Simple
{
	public class ViaFileInfo
	{
		private const string _EXAMPLE_FILE_PATH = "ReadingFiles/Example.txt";

		public void ReadFile_With_OpenText()
		{
			IFileInfo fileInfo = new FileInfoAdapter(_EXAMPLE_FILE_PATH);

			using (IStreamReader reader = fileInfo.OpenText())
			{
				string content = reader.ReadToEnd();
				Console.WriteLine("[ViaFileInfo.ReadFile_With_OpenText] File content: " + content);
			}
		}

		public void ReadFile_With_OpenRead()
		{
			IFileInfo fileInfo = new FileInfoAdapter(_EXAMPLE_FILE_PATH);

			using (IFileStream stream = fileInfo.OpenRead())
			using (IStreamReader reader = new StreamReaderAdapter(stream))
			{
				string content = reader.ReadToEnd();
				Console.WriteLine("[ViaFileInfo.ReadFile_With_OpenRead] File content: " + content);
			}
		}

		public void ReadFile_With_Open()
		{
			IFileInfo fileInfo = new FileInfoAdapter(_EXAMPLE_FILE_PATH);

			using (IFileStream stream = fileInfo.Open(FileMode.Open, FileAccess.Read, FileShare.Read))
			using (IStreamReader reader = new StreamReaderAdapter(stream))
			{
				string content = reader.ReadToEnd();
				Console.WriteLine("[ViaFileInfo.ReadFile_With_Open] File content: " + content);
			}
		}
	}
}