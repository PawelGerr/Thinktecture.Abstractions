using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.IO
{
	public static class FileStreamExtensions
	{
		/// <summary>
		/// Converts file stream to <see cref="IFileStream"/>.
		/// </summary>
		/// <param name="file">File stream to convert.</param>
		/// <returns>Converted file stream.</returns>
		public static IFileStream ToInterface(this FileStream file) 
		{
			return new FileStreamAdapter(file);
		}
	}
}