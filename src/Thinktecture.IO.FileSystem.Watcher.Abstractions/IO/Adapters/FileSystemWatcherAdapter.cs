using System;
using System.IO;
using JetBrains.Annotations;

// ReSharper disable InheritdocInvalidUsage

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="FileSystemWatcher"/>.
	/// </summary>
	public class FileSystemWatcherAdapter : AbstractionAdapter<FileSystemWatcher>, IFileSystemWatcher
	{
		/// <inheritdoc />
		public bool EnableRaisingEvents
		{
			get => Implementation.EnableRaisingEvents;
			set => Implementation.EnableRaisingEvents = value;
		}

		/// <inheritdoc />
		public string Filter
		{
			get => Implementation.Filter;
			set => Implementation.Filter = value;
		}

		/// <inheritdoc />
		public bool IncludeSubdirectories
		{
			get => Implementation.IncludeSubdirectories;
			set => Implementation.IncludeSubdirectories = value;
		}

		/// <inheritdoc />
		public int InternalBufferSize
		{
			get => Implementation.InternalBufferSize;
			set => Implementation.InternalBufferSize = value;
		}

		/// <inheritdoc />
		public NotifyFilters NotifyFilter
		{
			get => Implementation.NotifyFilter;
			set => Implementation.NotifyFilter = value;
		}

		/// <inheritdoc />
		public string Path
		{
			get => Implementation.Path;
			set => Implementation.Path = value;
		}

		/// <inheritdoc />
		public event FileSystemEventHandler Changed
		{
			add => Implementation.Changed += value;
			remove => Implementation.Changed -= value;
		}

		/// <inheritdoc />
		public event FileSystemEventHandler Created
		{
			add => Implementation.Created += value;
			remove => Implementation.Created -= value;
		}

		/// <inheritdoc />
		public event FileSystemEventHandler Deleted
		{
			add => Implementation.Deleted += value;
			remove => Implementation.Deleted -= value;
		}

		/// <inheritdoc />
		public event ErrorEventHandler Error
		{
			add => Implementation.Error += value;
			remove => Implementation.Error -= value;
		}

		/// <inheritdoc />
		public event RenamedEventHandler Renamed
		{
			add => Implementation.Renamed += value;
			remove => Implementation.Renamed -= value;
		}

		/// <summary>Initializes a new instance of the <see cref="FileSystemWatcherAdapter" /> class.</summary>
		public FileSystemWatcherAdapter()
			: this(new FileSystemWatcher())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="FileSystemWatcherAdapter" /> class, given the specified directory to monitor.</summary>
		/// <param name="path">The directory to monitor, in standard or Universal Naming Convention (UNC) notation. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="path" /> parameter is null. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="path" /> parameter is an empty string ("").-or- The path specified through the <paramref name="path" /> parameter does not exist. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">
		/// <paramref name="path" /> is too long.</exception>
		public FileSystemWatcherAdapter([NotNull] string path)
			: this(new FileSystemWatcher(path))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="FileSystemWatcherAdapter" /> class, given the specified directory and type of files to monitor.</summary>
		/// <param name="path">The directory to monitor, in standard or Universal Naming Convention (UNC) notation. </param>
		/// <param name="filter">The type of files to watch. For example, "*.txt" watches for changes to all text files. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="path" /> parameter is null.-or- The <paramref name="filter" /> parameter is null. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="path" /> parameter is an empty string ("").-or- The path specified through the <paramref name="path" /> parameter does not exist. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">
		/// <paramref name="path" /> is too long.</exception>
		public FileSystemWatcherAdapter([NotNull] string path, [NotNull] string filter)
			: this(new FileSystemWatcher(path, filter))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FileSystemWatcherAdapter" /> class.
		/// </summary>
		/// <param name="watcher">Watcher to be used by the adapter.</param>
		public FileSystemWatcherAdapter([NotNull] FileSystemWatcher watcher)
			: base(watcher)
		{
		}

		/// <inheritdoc />
		public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType)
		{
			return Implementation.WaitForChanged(changeType);
		}

		/// <inheritdoc />
		public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType, int timeout)
		{
			return Implementation.WaitForChanged(changeType, timeout);
		}

		/// <inheritdoc />
		public void Dispose()
		{
			Implementation.Dispose();
		}
	}
}
