using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Thinktecture.AbstractionAdapterTests
{
	public class GetHashCode : AbstractionAdapterTestsBase
	{
		[Fact]
		public void Should_return_result_of_implementation()
		{
			Implementation.GetHashCodeResult = 42;

			var result = Adapter.GetHashCode();

			result.Should().Be(42);
		}
	}
}
