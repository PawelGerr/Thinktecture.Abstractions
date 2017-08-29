using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Thinktecture.IO.FileSystem.Examples.Factories;

namespace Thinktecture.IO.FileSystem.Examples.ReadingFiles.Recommended
{
	public class ViaFileInfo
	{
		private const string _EXAMPLE_FILE_PATH = "ReadingFiles/Example.txt";

		[NotNull]
		private readonly ICustomFactory _factory;

		public ViaFileInfo([NotNull] ICustomFactory factory)
		{
			_factory = factory ?? throw new ArgumentNullException(nameof(factory));
		}

		public void ReadFile_With_OpenText()
		{
			var fileInfo = _factory.CreateFileInfo(_EXAMPLE_FILE_PATH);

			using (var reader = fileInfo.OpenText())
			{
				var content = reader.ReadToEnd();
				Console.WriteLine("[ViaFileInfo.ReadFile_With_OpenText] File content: " + content);
			}
		}

		public void ReadFile_With_OpenRead()
		{
			var fileInfo = _factory.CreateFileInfo(_EXAMPLE_FILE_PATH);

			using (var stream = fileInfo.OpenRead())
			using (var reader = _factory.CreateReader(stream))
			{
				var content = reader.ReadToEnd();
				Console.WriteLine("[ViaFileInfo.ReadFile_With_OpenRead] File content: " + content);
			}
		}

		public void ReadFile_With_Open()
		{
			var fileInfo = _factory.CreateFileInfo(_EXAMPLE_FILE_PATH);

			using (var stream = fileInfo.Open(FileMode.Open, FileAccess.Read, FileShare.Read))
			using (var reader = _factory.CreateReader(stream))
			{
				var content = reader.ReadToEnd();
				Console.WriteLine("[ViaFileInfo.ReadFile_With_Open] File content: " + content);
			}
		}
	}
}
