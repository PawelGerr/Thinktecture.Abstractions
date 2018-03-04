using Thinktecture.IO;
using Xunit;

namespace Thinktecture
{
	public class IntegrityTests : IntegrityTestsBase
	{
		public IntegrityTests()
			: base(GetAssembly("System.IO"), typeof(IStream))
		{
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
