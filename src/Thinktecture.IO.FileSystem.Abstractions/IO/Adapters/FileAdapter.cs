using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Thinktecture.Text;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="File"/>.
	/// </summary>
	public class FileAdapter : IFile
	{
#if NETCOREAPP2_1
		public Task<string> ReadAllTextAsync(string path, CancellationToken cancellationToken = default)
		{
			return File.ReadAllTextAsync(path, cancellationToken);
		}

		public Task<string> ReadAllTextAsync(string path, IEncoding encoding, CancellationToken cancellationToken = default)
		{
			return File.ReadAllTextAsync(path, encoding.ToImplementation(), cancellationToken);
		}

		public Task<string> ReadAllTextAsync(string path, Encoding encoding, CancellationToken cancellationToken = default)
		{
			return File.ReadAllTextAsync(path, encoding, cancellationToken);
		}

		public Task WriteAllTextAsync(string path, string content, CancellationToken cancellationToken = default)
		{
			return File.WriteAllTextAsync(path, content, cancellationToken);
		}

		public Task WriteAllTextAsync(string path, string content, IEncoding encoding, CancellationToken cancellationToken = default)
		{
			return File.WriteAllTextAsync(path, content, encoding.ToImplementation(), cancellationToken);
		}

		public Task WriteAllTextAsync(string path, string content, Encoding encoding, CancellationToken cancellationToken = default)
		{
			return File.WriteAllTextAsync(path, content, encoding, cancellationToken);
		}

		public Task<byte[]> ReadAllBytesAsync(string path, CancellationToken cancellationToken = default)
		{
			return File.ReadAllBytesAsync(path, cancellationToken);
		}

		public Task WriteAllBytesAsync(string path, byte[] bytes, CancellationToken cancellationToken = default)
		{
			return File.WriteAllBytesAsync(path, bytes, cancellationToken);
		}

		public Task<string[]> ReadAllLinesAsync(string path, CancellationToken cancellationToken = default)
		{
			return File.ReadAllLinesAsync(path, cancellationToken);
		}

		public Task<string[]> ReadAllLinesAsync(string path, IEncoding encoding, CancellationToken cancellationToken = default)
		{
			return File.ReadAllLinesAsync(path, encoding.ToImplementation(), cancellationToken);
		}

		public Task<string[]> ReadAllLinesAsync(string path, Encoding encoding, CancellationToken cancellationToken = default)
		{
			return File.ReadAllLinesAsync(path, cancellationToken);
		}

		public Task WriteAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken = default)
		{
			return File.WriteAllLinesAsync(path, contents, cancellationToken);
		}

		public Task WriteAllLinesAsync(string path, IEnumerable<string> contents, IEncoding encoding, CancellationToken cancellationToken = default)
		{
			return File.WriteAllLinesAsync(path, contents, encoding.ToImplementation(), cancellationToken);
		}

		public Task WriteAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken = default)
		{
			return File.WriteAllLinesAsync(path, contents, encoding, cancellationToken);
		}

		public Task AppendAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken = default)
		{
			return File.AppendAllLinesAsync(path, contents, cancellationToken);
		}

		public Task AppendAllLinesAsync(string path, IEnumerable<string> contents, IEncoding encoding, CancellationToken cancellationToken = default)
		{
			return File.AppendAllLinesAsync(path, contents, encoding.ToImplementation(), cancellationToken);
		}

		public Task AppendAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken = default)
		{
			return File.AppendAllLinesAsync(path, contents, encoding, cancellationToken);
		}

		public Task AppendAllTextAsync(string path, string content, CancellationToken cancellationToken = default)
		{
			return File.AppendAllTextAsync(path, content, cancellationToken);
		}

		public Task AppendAllTextAsync(string path, string content, IEncoding encoding, CancellationToken cancellationToken = default)
		{
			return File.AppendAllTextAsync(path, content, encoding.ToImplementation(), cancellationToken);
		}

		public Task AppendAllTextAsync(string path, string content, Encoding encoding, CancellationToken cancellationToken = default)
		{
			return File.AppendAllTextAsync(path, content, encoding, cancellationToken);
		}
#endif

		/// <inheritdoc />
		public void AppendAllLines(string path, IEnumerable<string> contents)
		{
			File.AppendAllLines(path, contents);
		}

		/// <inheritdoc />
		public void AppendAllLines(string path, IEnumerable<string> contents, IEncoding encoding)
		{
			File.AppendAllLines(path, contents, encoding.ToImplementation());
		}

		/// <inheritdoc />
		public void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding)
		{
			File.AppendAllLines(path, contents, encoding);
		}

		/// <inheritdoc />
		public void AppendAllText(string path, string contents)
		{
			File.AppendAllText(path, contents);
		}

		/// <inheritdoc />
		public void AppendAllText(string path, string contents, IEncoding encoding)
		{
			File.AppendAllText(path, contents, encoding.ToImplementation());
		}

		/// <inheritdoc />
		public void AppendAllText(string path, string contents, Encoding encoding)
		{
			File.AppendAllText(path, contents, encoding);
		}

		/// <inheritdoc />
		public IStreamWriter AppendText(string path)
		{
			return File.AppendText(path).ToInterface();
		}

		/// <inheritdoc />
		public void Copy(string sourceFileName, string destFileName)
		{
			File.Copy(sourceFileName, destFileName);
		}

		/// <inheritdoc />
		public void Copy(string sourceFileName, string destFileName, bool overwrite)
		{
			File.Copy(sourceFileName, destFileName, overwrite);
		}

		/// <inheritdoc />
		public IFileStream Create(string path)
		{
			return File.Create(path).ToInterface();
		}

		/// <inheritdoc />
		public IFileStream Create(string path, int bufferSize)
		{
			return File.Create(path, bufferSize).ToInterface();
		}

		/// <inheritdoc />
		public IFileStream Create(string path, int bufferSize, FileOptions options)
		{
			return File.Create(path, bufferSize, options).ToInterface();
		}

		/// <inheritdoc />
		public IStreamWriter CreateText(string path)
		{
			return File.CreateText(path).ToInterface();
		}

		/// <inheritdoc />
		public void Delete(string path)
		{
			File.Delete(path);
		}

#if NET46 || NETSTANDARD2_0
		/// <inheritdoc />
		public void Decrypt(string path)
		{
			File.Decrypt(path);
		}

		/// <inheritdoc />
		public void Encrypt(string path)
		{
			File.Encrypt(path);
		}
#endif

		/// <inheritdoc />
		public bool Exists(string path)
		{
			return File.Exists(path);
		}

		/// <inheritdoc />
		public FileAttributes GetAttributes(string path)
		{
			return File.GetAttributes(path);
		}

		/// <inheritdoc />
		public DateTime GetCreationTime(string path)
		{
			return File.GetCreationTime(path);
		}

		/// <inheritdoc />
		public DateTime GetCreationTimeUtc(string path)
		{
			return File.GetCreationTimeUtc(path);
		}

		/// <inheritdoc />
		public DateTime GetLastAccessTime(string path)
		{
			return File.GetLastAccessTime(path);
		}

		/// <inheritdoc />
		public DateTime GetLastAccessTimeUtc(string path)
		{
			return File.GetLastAccessTimeUtc(path);
		}

		/// <inheritdoc />
		public DateTime GetLastWriteTime(string path)
		{
			return File.GetLastWriteTime(path);
		}

		/// <inheritdoc />
		public DateTime GetLastWriteTimeUtc(string path)
		{
			return File.GetLastWriteTimeUtc(path);
		}

		/// <inheritdoc />
		public void Move(string sourceFileName, string destFileName)
		{
			File.Move(sourceFileName, destFileName);
		}

		/// <inheritdoc />
		public IFileStream Open(string path, FileMode mode)
		{
			return File.Open(path, mode).ToInterface();
		}

		/// <inheritdoc />
		public IFileStream Open(string path, FileMode mode, FileAccess access)
		{
			return File.Open(path, mode, access).ToInterface();
		}

		/// <inheritdoc />
		public IFileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
		{
			return File.Open(path, mode, access, share).ToInterface();
		}

		/// <inheritdoc />
		public IFileStream OpenRead(string path)
		{
			return File.OpenRead(path).ToInterface();
		}

		/// <inheritdoc />
		public IStreamReader OpenText(string path)
		{
			return File.OpenText(path).ToInterface();
		}

		/// <inheritdoc />
		public IFileStream OpenWrite(string path)
		{
			return File.OpenWrite(path).ToInterface();
		}

		/// <inheritdoc />
		public byte[] ReadAllBytes(string path)
		{
			return File.ReadAllBytes(path);
		}

		/// <inheritdoc />
		public string[] ReadAllLines(string path)
		{
			return File.ReadAllLines(path);
		}

		/// <inheritdoc />
		public string[] ReadAllLines(string path, IEncoding encoding)
		{
			return File.ReadAllLines(path, encoding.ToImplementation());
		}

		/// <inheritdoc />
		public string[] ReadAllLines(string path, Encoding encoding)
		{
			return File.ReadAllLines(path, encoding);
		}

		/// <inheritdoc />
		public string ReadAllText(string path)
		{
			return File.ReadAllText(path);
		}

		/// <inheritdoc />
		public string ReadAllText(string path, IEncoding encoding)
		{
			return File.ReadAllText(path, encoding.ToImplementation());
		}

		/// <inheritdoc />
		public string ReadAllText(string path, Encoding encoding)
		{
			return File.ReadAllText(path, encoding);
		}

		/// <inheritdoc />
		public IEnumerable<string> ReadLines(string path)
		{
			return File.ReadLines(path);
		}

		/// <inheritdoc />
		public IEnumerable<string> ReadLines(string path, IEncoding encoding)
		{
			return File.ReadLines(path, encoding.ToImplementation());
		}

		/// <inheritdoc />
		public IEnumerable<string> ReadLines(string path, Encoding encoding)
		{
			return File.ReadLines(path, encoding);
		}

		/// <inheritdoc />
		public void SetAttributes(string path, FileAttributes fileAttributes)
		{
			File.SetAttributes(path, fileAttributes);
		}

		/// <inheritdoc />
		public void SetCreationTime(string path, DateTime creationTime)
		{
			File.SetCreationTime(path, creationTime);
		}

		/// <inheritdoc />
		public void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
		{
			File.SetCreationTimeUtc(path, creationTimeUtc);
		}

		/// <inheritdoc />
		public void SetLastAccessTime(string path, DateTime lastAccessTime)
		{
			File.SetLastAccessTime(path, lastAccessTime);
		}

		/// <inheritdoc />
		public void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
		{
			File.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
		}

		/// <inheritdoc />
		public void SetLastWriteTime(string path, DateTime lastWriteTime)
		{
			File.SetLastWriteTime(path, lastWriteTime);
		}

		/// <inheritdoc />
		public void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
		{
			File.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
		}

		/// <inheritdoc />
		public void WriteAllBytes(string path, byte[] bytes)
		{
			File.WriteAllBytes(path, bytes);
		}

		/// <inheritdoc />
		public void WriteAllLines(string path, string[] contents)
		{
			File.WriteAllLines(path, contents);
		}

		/// <inheritdoc />
		public void WriteAllLines(string path, string[] contents, Encoding encoding)
		{
			File.WriteAllLines(path, contents, encoding);
		}

		/// <inheritdoc />
		public void WriteAllLines(string path, string[] contents, IEncoding encoding)
		{
			File.WriteAllLines(path, contents, encoding.ToImplementation());
		}

		/// <inheritdoc />
		public void WriteAllLines(string path, IEnumerable<string> contents)
		{
			File.WriteAllLines(path, contents);
		}

		/// <inheritdoc />
		public void WriteAllLines(string path, IEnumerable<string> contents, IEncoding encoding)
		{
			File.WriteAllLines(path, contents, encoding.ToImplementation());
		}

		/// <inheritdoc />
		public void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding)
		{
			File.WriteAllLines(path, contents, encoding);
		}

		/// <inheritdoc />
		public void WriteAllText(string path, string contents)
		{
			File.WriteAllText(path, contents);
		}

		/// <inheritdoc />
		public void WriteAllText(string path, string contents, IEncoding encoding)
		{
			File.WriteAllText(path, contents, encoding.ToImplementation());
		}

		/// <inheritdoc />
		public void WriteAllText(string path, string contents, Encoding encoding)
		{
			File.WriteAllText(path, contents, encoding);
		}

#if NET46 || NETSTANDARD2_0
		/// <inheritdoc />
		public void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName)
		{
			File.Replace(sourceFileName, destinationFileName, destinationBackupFileName);
		}

		/// <inheritdoc />
		public void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
		{
			File.Replace(sourceFileName, destinationFileName, destinationBackupFileName, ignoreMetadataErrors);
		}
#endif
	}
}
