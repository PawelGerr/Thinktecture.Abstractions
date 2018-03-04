using System;
using System.ComponentModel;
using System.IO;
using Thinktecture.IO;
using Xunit;

namespace Thinktecture
{
	public class IntegrityTests : IntegrityTestsBase
	{
		public IntegrityTests()
			: base(GetAssembly("System.IO.FileSystem.Watcher"), typeof(IFileSystemWatcher))
		{
			ExcludedTypes.Add(typeof(ErrorEventArgs));
			ExcludedTypes.Add(typeof(ErrorEventHandler));
			ExcludedTypes.Add(typeof(FileSystemEventArgs));
			ExcludedTypes.Add(typeof(FileSystemEventHandler));
			ExcludedTypes.Add(typeof(InternalBufferOverflowException));
			ExcludedTypes.Add(typeof(RenamedEventArgs));
			ExcludedTypes.Add(typeof(RenamedEventHandler));
			ExcludedTypes.Add(typeof(WaitForChangedResult));
		}

		[Fact]
		public void Should_contain_all_types()
		{
			CheckTypes();
		}

		[Fact]
		public void Should_contain_all_members()
		{
			CheckMembers();
		}
	}
}
