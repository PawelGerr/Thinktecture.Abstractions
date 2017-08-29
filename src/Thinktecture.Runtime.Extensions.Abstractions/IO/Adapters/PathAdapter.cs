using System.IO;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="Path"/>.
	/// </summary>
	public class PathAdapter : IPath
	{
		/// <inheritdoc />
		public string ChangeExtension(string path, string extension)
		{
			return Path.ChangeExtension(path, extension);
		}

		/// <inheritdoc />
		public string Combine(params string[] paths)
		{
			return Path.Combine(paths);
		}

		/// <inheritdoc />
		public string GetDirectoryName(string path)
		{
			return Path.GetDirectoryName(path);
		}

		/// <inheritdoc />
		public string GetExtension(string path)
		{
			return Path.GetExtension(path);
		}

		/// <inheritdoc />
		public string GetFileName(string path)
		{
			return Path.GetFileName(path);
		}

		/// <inheritdoc />
		public string GetFileNameWithoutExtension(string path)
		{
			return Path.GetFileNameWithoutExtension(path);
		}

		/// <inheritdoc />
		public char[] GetInvalidFileNameChars()
		{
			return Path.GetInvalidFileNameChars();
		}

		/// <inheritdoc />
		public char[] GetInvalidPathChars()
		{
			return Path.GetInvalidPathChars();
		}

		/// <inheritdoc />
		public string GetPathRoot(string path)
		{
			return Path.GetPathRoot(path);
		}

		/// <inheritdoc />
		public string GetRandomFileName()
		{
			return Path.GetRandomFileName();
		}

		/// <inheritdoc />
		public bool HasExtension(string path)
		{
			return Path.HasExtension(path);
		}

		/// <inheritdoc />
		public bool IsPathRooted(string path)
		{
			return Path.IsPathRooted(path);
		}
	}
}
