using System.IO;
using JetBrains.Annotations;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

// ReSharper disable once CheckNamespace
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
		[CanBeNull]
		public static IFileInfo ToInterface([CanBeNull] this FileInfo file)
		{
			return (file == null) ? null : new FileInfoAdapter(file);
		}

		/// <summary>
		/// Converts provided <see cref="IFileInfo"/> info to <see cref="FileInfo"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="IDirectoryInfo"/> to convert.</param>
		/// <returns>An instance of <see cref="FileInfo"/>.</returns>
		[CanBeNull]
		public static FileInfo ToImplementation([CanBeNull] this IFileInfo abstraction)
		{
			return ((IAbstraction<FileInfo>)abstraction)?.UnsafeConvert();
		}
	}
}
