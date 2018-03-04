using System;
using System.IO;
using Thinktecture.IO;
using Xunit;

namespace Thinktecture
{
	public class IntegrityTests : IntegrityTestsBase
	{
		public IntegrityTests()
			: base(GetAssembly("System.IO.FileSystem"), typeof(IFile))
		{
			ExcludeStaticMembers(typeof(File), nameof(File.ReadAllTextAsync)); // exists in netcoreapp only (not in netstandard)
			ExcludeStaticMembers(typeof(File), nameof(File.WriteAllTextAsync)); // exists in netcoreapp only (not in netstandard)
			ExcludeStaticMembers(typeof(File), nameof(File.ReadAllBytesAsync)); // exists in netcoreapp only (not in netstandard)
			ExcludeStaticMembers(typeof(File), nameof(File.WriteAllBytesAsync)); // exists in netcoreapp only (not in netstandard)
			ExcludeStaticMembers(typeof(File), nameof(File.ReadAllLinesAsync)); // exists in netcoreapp only (not in netstandard)
			ExcludeStaticMembers(typeof(File), nameof(File.WriteAllLinesAsync)); // exists in netcoreapp only (not in netstandard)
			ExcludeStaticMembers(typeof(File), nameof(File.AppendAllLinesAsync)); // exists in netcoreapp only (not in netstandard)
			ExcludeStaticMembers(typeof(File), nameof(File.AppendAllTextAsync)); // exists in netcoreapp only (not in netstandard)
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
