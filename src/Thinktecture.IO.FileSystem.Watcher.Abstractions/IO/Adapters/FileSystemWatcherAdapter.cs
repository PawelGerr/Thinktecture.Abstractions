using System;
using System.ComponentModel;
using System.IO;

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="FileSystemWatcher"/>.
	/// </summary>
	public class FileSystemWatcherAdapter : AbstractionAdapter, IFileSystemWatcher
	{
		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new FileSystemWatcher UnsafeConvert()
		{
			return _instance;
		}

		private readonly FileSystemWatcher _instance;

		/// <inheritdoc />
		public bool EnableRaisingEvents
		{
			get => _instance.EnableRaisingEvents;
			set => _instance.EnableRaisingEvents = value;
		}

		/// <inheritdoc />
		public string Filter
		{
			get => _instance.Filter;
			set => _instance.Filter = value;
		}

		/// <inheritdoc />
		public bool IncludeSubdirectories
		{
			get => _instance.IncludeSubdirectories;
			set => _instance.IncludeSubdirectories = value;
		}

		/// <inheritdoc />
		public int InternalBufferSize
		{
			get => _instance.InternalBufferSize;
			set => _instance.InternalBufferSize = value;
		}

		/// <inheritdoc />
		public NotifyFilters NotifyFilter
		{
			get => _instance.NotifyFilter;
			set => _instance.NotifyFilter = value;
		}

		/// <inheritdoc />
		public string Path
		{
			get => _instance.Path;
			set => _instance.Path = value;
		}

		/// <inheritdoc />
		public event FileSystemEventHandler Changed
		{
			add => _instance.Changed += value;
			remove => _instance.Changed -= value;
		}

		/// <inheritdoc />
		public event FileSystemEventHandler Created
		{
			add => _instance.Created += value;
			remove => _instance.Created -= value;
		}

		/// <inheritdoc />
		public event FileSystemEventHandler Deleted
		{
			add => _instance.Deleted += value;
			remove => _instance.Deleted -= value;
		}

		/// <inheritdoc />
		public event ErrorEventHandler Error
		{
			add => _instance.Error += value;
			remove => _instance.Error -= value;
		}

		/// <inheritdoc />
		public event RenamedEventHandler Renamed
		{
			add => _instance.Renamed += value;
			remove => _instance.Renamed -= value;
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
		public FileSystemWatcherAdapter(string path)
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
		public FileSystemWatcherAdapter(string path, string filter)
			: this(new FileSystemWatcher(path, filter))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FileSystemWatcherAdapter" /> class.
		/// </summary>
		/// <param name="watcher">Watcher to be used by the adapter.</param>
		public FileSystemWatcherAdapter(FileSystemWatcher watcher)
			: base(watcher)
		{
			_instance = watcher ?? throw new ArgumentNullException(nameof(watcher));
		}

		/// <inheritdoc />
		public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType)
		{
			return _instance.WaitForChanged(changeType);
		}

		/// <inheritdoc />
		public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType, int timeout)
		{
			return _instance.WaitForChanged(changeType, timeout);
		}

		/// <inheritdoc />
		public void Dispose()
		{
			_instance.Dispose();
		}
	}
}