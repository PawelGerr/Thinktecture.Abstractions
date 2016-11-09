using System;
using System.ComponentModel;
using System.IO;

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="FileSystemWatcher"/>.
	/// </summary>
	public class FileSystemWatcherAdapter : IFileSystemWatcher
	{
		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public FileSystemWatcher InternalInstance { get; }

		/// <inheritdoc />
		public bool EnableRaisingEvents
		{
			get { return InternalInstance.EnableRaisingEvents; }
			set { InternalInstance.EnableRaisingEvents = value; }
		}

		/// <inheritdoc />
		public string Filter
		{
			get { return InternalInstance.Filter; }
			set { InternalInstance.Filter = value; }
		}

		/// <inheritdoc />
		public bool IncludeSubdirectories
		{
			get { return InternalInstance.IncludeSubdirectories; }
			set { InternalInstance.IncludeSubdirectories = value; }
		}

		/// <inheritdoc />
		public int InternalBufferSize
		{
			get { return InternalInstance.InternalBufferSize; }
			set { InternalInstance.InternalBufferSize = value; }
		}

		/// <inheritdoc />
		public NotifyFilters NotifyFilter
		{
			get { return InternalInstance.NotifyFilter; }
			set { InternalInstance.NotifyFilter = value; }
		}

		/// <inheritdoc />
		public string Path
		{
			get { return InternalInstance.Path; }
			set { InternalInstance.Path = value; }
		}

		/// <inheritdoc />
		public event FileSystemEventHandler Changed
		{
			add { InternalInstance.Changed += value; }
			remove { InternalInstance.Changed -= value; }
		}

		/// <inheritdoc />
		public event FileSystemEventHandler Created
		{
			add { InternalInstance.Created += value; }
			remove { InternalInstance.Created -= value; }
		}

		/// <inheritdoc />
		public event FileSystemEventHandler Deleted
		{
			add { InternalInstance.Deleted += value; }
			remove { InternalInstance.Deleted -= value; }
		}

		/// <inheritdoc />
		public event ErrorEventHandler Error
		{
			add { InternalInstance.Error += value; }
			remove { InternalInstance.Error -= value; }
		}

		/// <inheritdoc />
		public event RenamedEventHandler Renamed
		{
			add { InternalInstance.Renamed += value; }
			remove { InternalInstance.Renamed -= value; }
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
		{
			if (watcher == null)
				throw new ArgumentNullException(nameof(watcher));

			InternalInstance = watcher;
		}

		/// <inheritdoc />
		public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType)
		{
			return InternalInstance.WaitForChanged(changeType);
		}

		/// <inheritdoc />
		public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType, int timeout)
		{
			return InternalInstance.WaitForChanged(changeType, timeout);
		}

		/// <inheritdoc />
		public void Dispose()
		{
			InternalInstance.Dispose();
		}

		/// <inheritdoc />
		public override string ToString()
		{
			return InternalInstance.ToString();
		}

		/// <inheritdoc />
		public override bool Equals(object obj)
		{
			return InternalInstance.Equals(obj);
		}

		/// <inheritdoc />
		public override int GetHashCode()
		{
			return InternalInstance.GetHashCode();
		}
	}
}