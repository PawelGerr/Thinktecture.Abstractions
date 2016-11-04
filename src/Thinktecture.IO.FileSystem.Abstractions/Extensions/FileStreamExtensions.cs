using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

namespace Thinktecture
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