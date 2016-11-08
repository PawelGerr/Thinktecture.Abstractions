using System;
using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="FileInfo"/>.
	/// </summary>
	public static class FileInfoExtensions
	{
		/// <summary>
		/// Converts provided file info to <see cref="IFileInfo"/>.
		/// </summary>
		/// <param name="file">File info to convert.</param>
		/// <returns>Converted file info.</returns>
		public static IFileInfo ToInterface(this FileInfo file)
		{
			return (file == null) ? null : new FileInfoAdapter(file);
		}

		/// <summary>
		/// Converts provided file info to <see cref="FileInfo"/>.
		/// </summary>
		/// <param name="file">File info to convert.</param>
		/// <returns>Converted file info.</returns>
		public static FileInfo ToImplementation(this IFileInfo file)
		{
			return file?.InternalInstance;
		}
	}
}