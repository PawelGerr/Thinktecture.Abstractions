using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

namespace Thinktecture
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