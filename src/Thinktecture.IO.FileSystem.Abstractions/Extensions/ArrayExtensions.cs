using System.Diagnostics.CodeAnalysis;
using System.IO;
using Thinktecture.IO;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
   /// <summary>
   /// Extensions for arrays.
   /// </summary>
   public static class ArrayExtensions
   {
      /// <summary>
      /// Converts an array of <see cref="DirectoryInfo"/> to an array of <see cref="IDirectoryInfo"/>.
      /// </summary>
      /// <param name="infos">Array to convert.</param>
      /// <returns>An array of <see cref="IDirectoryInfo"/>.</returns>
      [return: NotNullIfNotNull("infos")]
      public static IDirectoryInfo[]? ToInterface(this DirectoryInfo[]? infos)
      {
         if (infos == null)
            return null;

         var abstractions = new IDirectoryInfo[infos.Length];

         for (var i = 0; i < infos.Length; i++)
         {
            abstractions[i] = infos[i].ToInterface();
         }

         return abstractions;
      }

      /// <summary>
      /// Converts an array of <see cref="FileInfo"/> to an array of <see cref="IFileInfo"/>.
      /// </summary>
      /// <param name="infos">Array to convert.</param>
      /// <returns>An array of <see cref="IFileInfo"/>.</returns>
      [return: NotNullIfNotNull("infos")]
      public static IFileInfo[]? ToInterface(this FileInfo[]? infos)
      {
         if (infos == null)
            return null;

         var abstractions = new IFileInfo[infos.Length];

         for (var i = 0; i < infos.Length; i++)
         {
            abstractions[i] = infos[i].ToInterface();
         }

         return abstractions;
      }

      /// <summary>
      /// Converts an array of <see cref="FileSystemInfo"/> to an array of <see cref="IFileSystemInfo"/>.
      /// </summary>
      /// <param name="infos">Array to convert.</param>
      /// <returns>An array of <see cref="IFileSystemInfo"/>.</returns>
      [return:NotNullIfNotNull("infos")]
      public static IFileSystemInfo[]? ToInterface(this FileSystemInfo[]? infos)
      {
         if (infos == null)
            return null;

         var abstractions = new IFileSystemInfo[infos.Length];

         for (var i = 0; i < infos.Length; i++)
         {
            abstractions[i] = infos[i].ToInterface();
         }

         return abstractions;
      }
   }
}
