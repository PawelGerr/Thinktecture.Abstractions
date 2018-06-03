using System.Runtime.InteropServices;
using System.Threading;
using Xunit;

namespace Thinktecture
{
	public class IntegrityTests : IntegrityTestsBase
	{
		public IntegrityTests()
			: base("Runtime.Handles")
		{
			ExcludedTypes.Add(typeof(CriticalHandle));
			ExcludedTypes.Add(typeof(WaitHandleExtensions));
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
