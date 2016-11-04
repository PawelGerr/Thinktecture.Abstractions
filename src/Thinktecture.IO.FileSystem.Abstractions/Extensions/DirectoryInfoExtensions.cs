using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.IO
{
	public static class DirectoryInfoExtensions
	{
		/// <summary>
		/// Converts provided directory info to <see cref="IDirectoryInfo"/>.
		/// </summary>
		/// <param name="directoryInfo">Directory info to convert.</param>
		/// <returns>Converted directory info.</returns>
		public static IDirectoryInfo ToInterface(this DirectoryInfo directoryInfo) 
		{
			return new DirectoryInfoAdapter(directoryInfo);
		}
	}
}