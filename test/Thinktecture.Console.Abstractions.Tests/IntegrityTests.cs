using System;
using Xunit;

namespace Thinktecture
{
	public class IntegrityTests : IntegrityTestsBase
	{
		public IntegrityTests()
			: base("Console")
		{
			CustomTypeMappings.Add(typeof(ConsoleCancelEventHandler), typeof(EventHandler<IConsoleCancelEventArgs>));
			ExcludedTypes.Add(typeof(ConsoleKeyInfo)); // struct
			ExcludeMember<EventArgs>(nameof(EventArgs.Empty));
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
