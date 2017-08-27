using System.IO;
using JetBrains.Annotations;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="DirectoryInfo"/>.
	/// </summary>
	public static class DirectoryInfoExtensions
	{
		/// <summary>
		/// Converts provided directory info to <see cref="IDirectoryInfo"/>.
		/// </summary>
		/// <param name="directoryInfo">Directory info to convert.</param>
		/// <returns>Converted directory info.</returns>
		[CanBeNull]
		public static IDirectoryInfo ToInterface([CanBeNull] this DirectoryInfo directoryInfo)
		{
			return (directoryInfo == null) ? null : new DirectoryInfoAdapter(directoryInfo);
		}

		/// <summary>
		/// Converts provided <see cref="IDirectoryInfo"/> info to <see cref="DirectoryInfo"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="IDirectoryInfo"/> to convert.</param>
		/// <returns>An instance of <see cref="DirectoryInfo"/>.</returns>
		[CanBeNull]
		public static DirectoryInfo ToImplementation([CanBeNull] this IDirectoryInfo abstraction)
		{
			return ((IAbstraction<DirectoryInfo>)abstraction)?.UnsafeConvert();
		}
	}
}
