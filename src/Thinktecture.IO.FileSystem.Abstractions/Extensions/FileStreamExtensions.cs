using System;
using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="FileStream"/>.
	/// </summary>
	public static class FileStreamExtensions
	{
		/// <summary>
		/// Converts file stream to <see cref="IFileStream"/>.
		/// </summary>
		/// <param name="file">File stream to convert.</param>
		/// <returns>Converted file stream.</returns>
		public static IFileStream ToInterface(this FileStream file)
		{
			return (file == null) ? null : new FileStreamAdapter(file);
		}

		/// <summary>
		/// Converts file stream to <see cref="FileStream"/>.
		/// </summary>
		/// <param name="file">File stream to convert.</param>
		/// <returns>Converted file stream.</returns>
		public static FileStream ToImplementation(this IFileStream file)
		{
			return file?.InternalInstance;
		}
	}
}