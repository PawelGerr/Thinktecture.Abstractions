using System.IO;
using System.IO.Enumeration;
using Xunit;

namespace Thinktecture
{
	public class IntegrityTests : IntegrityTestsBase
	{
		public IntegrityTests()
			: base("IO.FileSystem")
		{
			ExcludedTypes.Add(typeof(EnumerationOptions));
			ExcludedTypes.Add(typeof(FileSystemEntry)); // struct
			ExcludedTypes.Add(typeof(FileSystemEnumerable<>)); // IEnumerable
			ExcludedTypes.Add(typeof(FileSystemEnumerator<>)); // Enumerator

			ExcludeMembers(typeof(File), nameof(File.ReadAllTextAsync)); // exists in netcoreapp only (not in netstandard)
			ExcludeMembers(typeof(File), nameof(File.WriteAllTextAsync)); // exists in netcoreapp only (not in netstandard)
			ExcludeMembers(typeof(File), nameof(File.ReadAllBytesAsync)); // exists in netcoreapp only (not in netstandard)
			ExcludeMembers(typeof(File), nameof(File.WriteAllBytesAsync)); // exists in netcoreapp only (not in netstandard)
			ExcludeMembers(typeof(File), nameof(File.ReadAllLinesAsync)); // exists in netcoreapp only (not in netstandard)
			ExcludeMembers(typeof(File), nameof(File.WriteAllLinesAsync)); // exists in netcoreapp only (not in netstandard)
			ExcludeMembers(typeof(File), nameof(File.AppendAllLinesAsync)); // exists in netcoreapp only (not in netstandard)
			ExcludeMembers(typeof(File), nameof(File.AppendAllTextAsync)); // exists in netcoreapp only (not in netstandard)

			ExcludeMembers(typeof(FileStream), nameof(FileStream.BeginRead));
			ExcludeMembers(typeof(FileStream), nameof(FileStream.EndRead));
			ExcludeMembers(typeof(FileStream), nameof(FileStream.BeginWrite));
			ExcludeMembers(typeof(FileStream), nameof(FileStream.EndWrite));

			ExcludeMembers(typeof(Stream), nameof(Stream.Synchronized));
			ExcludeMembers(typeof(Stream), nameof(Stream.Null));

#pragma warning disable 618
			ExcludeMembers(typeof(FileStream), nameof(FileStream.Handle)); // deprecated
#pragma warning restore 618
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
