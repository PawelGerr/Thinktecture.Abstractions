using System.IO;
using Xunit;

namespace Thinktecture.Abstractions.Tests
{
	public class IntegrityTests : IntegrityTestsBase
	{
		public IntegrityTests()
			: base("IO.FileSystem.Watcher")
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
		public void Should_contain_all_adapters()
		{
			CheckAdapters();
		}

		[Fact]
		public void Should_contain_all_adapters_constructors()
		{
			CheckConstructors();
		}

		[Fact]
		public void Should_contain_all_members()
		{
			CheckMembers();
		}
	}
}
