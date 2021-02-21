using FluentAssertions;
using Xunit;

namespace Thinktecture.Abstractions.Tests.AbstractionAdapterTests
{
	public class ToString : AbstractionAdapterTestsBase
	{
		[Fact]
		public void Should_return_result_of_implementation()
		{
			Implementation.ToStringResult = "test";

			var result = Adapter.ToString();

			result.Should().Be("test");
		}
	}
}
