using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Thinktecture.IO.FileSystem.Examples.Factories
{
	public interface ICustomFactory
	{
		[NotNull]
		IStreamReader CreateReader([NotNull] IStream stream);

		[NotNull]
		IFileInfo CreateFileInfo([NotNull] string path);
	}
}
