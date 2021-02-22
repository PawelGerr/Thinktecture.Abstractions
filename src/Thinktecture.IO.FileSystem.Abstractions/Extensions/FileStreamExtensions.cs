using System.Diagnostics.CodeAnalysis;
using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

// ReSharper disable once CheckNamespace
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
      [return:NotNullIfNotNull("file")]
      public static IFileStream? ToInterface(this FileStream? file)
		{
			return (file == null) ? null : new FileStreamAdapter(file);
		}

		/// <summary>
		/// Converts provided <see cref="IFileStream"/> info to <see cref="FileStream"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="IFileStream"/> to convert.</param>
		/// <returns>An instance of <see cref="FileStream"/>.</returns>
      [return:NotNullIfNotNull("abstraction")]
      public static FileStream? ToImplementation(this IFileStream? abstraction)
		{
			return ((IAbstraction<FileStream>?)abstraction)?.UnsafeConvert();
		}
	}
}
