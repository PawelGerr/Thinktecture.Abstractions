using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thinktecture.IO.Adapters;

namespace Thinktecture.IO.FileSystem.Examples.Factories
{
	public class CustomFactory : ICustomFactory
	{
		public IStreamReader CreateReader(IStream stream)
		{
			if (stream == null)
				throw new ArgumentNullException(nameof(stream));

			return new StreamReaderAdapter(stream);
		}

		public IFileInfo CreateFileInfo(string path)
		{
			return new FileInfoAdapter(path);
		}
	}
}
