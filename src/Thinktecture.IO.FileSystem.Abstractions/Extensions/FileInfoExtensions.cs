using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.IO
{
	public static class FileInfoExtensions
	{
		/// <summary>
		/// Converts provided file info to <see cref="IFileInfo"/>.
		/// </summary>
		/// <param name="file">File info to convert.</param>
		/// <returns>Converted file info.</returns>
		public static IFileInfo ToInterface(this FileInfo file) 
		{
			return new FileInfoAdapter(file);
		}
	}
}