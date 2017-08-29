using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Thinktecture.IO.Adapters;
using Thinktecture.IO.FileSystem.Examples.Factories;

namespace Thinktecture.IO.FileSystem.Examples
{
	public class Program
	{
		public static void Main([CanBeNull] string[] args)
		{
			ExecuteReadingFilesExample_Simple();
			ExecuteReadingFilesExample_Recommended();

			Console.WriteLine("Press ENTER to exit.");
			Console.ReadLine();
		}

		private static void ExecuteReadingFilesExample_Simple()
		{
			Console.WriteLine("== ExecuteReadingFilesExample_Simple ==");
			IFile file = new FileAdapter();

			var viaFile = new ReadingFiles.Simple.ViaFile(file);
			viaFile.ReadFile_With_OpenText();
			viaFile.ReadFile_With_OpenRead();
			viaFile.ReadFile_With_Open();

			var viaFileInfo = new ReadingFiles.Simple.ViaFileInfo();
			viaFileInfo.ReadFile_With_OpenText();
			viaFileInfo.ReadFile_With_OpenRead();
			viaFileInfo.ReadFile_With_Open();

			Console.WriteLine();
		}

		private static void ExecuteReadingFilesExample_Recommended()
		{
			Console.WriteLine("== ExecuteReadingFilesExample_Recommended ==");

			IFile file = new FileAdapter();
			ICustomFactory factory = new CustomFactory();

			var viaFile = new ReadingFiles.Recommended.ViaFile(file, factory);
			viaFile.ReadFile_With_OpenText();
			viaFile.ReadFile_With_OpenRead();
			viaFile.ReadFile_With_Open();

			var viaFileInfo = new ReadingFiles.Recommended.ViaFileInfo(factory);
			viaFileInfo.ReadFile_With_OpenText();
			viaFileInfo.ReadFile_With_OpenRead();
			viaFileInfo.ReadFile_With_Open();

			Console.WriteLine();
		}
	}
}
