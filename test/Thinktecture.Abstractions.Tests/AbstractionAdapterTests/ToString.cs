using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Thinktecture.AbstractionAdapterTests
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
