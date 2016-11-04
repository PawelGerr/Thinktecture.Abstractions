using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.IO
{
	public static class FileSystemInfoExtensions
	{
		/// <summary>
		/// Converts file system info to <see cref="IFileSystemInfo"/>.
		/// </summary>
		/// <param name="info">File system info to convert.</param>
		/// <returns>Converted file system info.</returns>
		public static IFileSystemInfo ToInterface(this FileSystemInfo info)
		{
			return new FileSystemInfoAdapter(info);
		}
	}
}