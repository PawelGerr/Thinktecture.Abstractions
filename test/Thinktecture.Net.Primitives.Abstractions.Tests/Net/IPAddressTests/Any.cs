using System.Net;
using FluentAssertions;
using Thinktecture.Net.Adapters;
using Xunit;

namespace Thinktecture.Abstractions.Tests.Net.IPAddressTests
{
	public class Any
	{
		[Fact]
		public void Should_return_wrapper_with_corresponding_underlying_value()
		{
			IPAddressAdapter.Any.UnsafeConvert().Should().Be(IPAddress.Any);
		}
	}
}
