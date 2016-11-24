using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.IO.FileSystem.Examples.Factories
{
	public interface ICustomFactory
	{
		IStreamReader CreateReader(IStream stream);
		IFileInfo CreateFileInfo(string path);
	}
}