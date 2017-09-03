using System.Net;
using FluentAssertions;
using Thinktecture.Net.Adapters;
using Xunit;

namespace Thinktecture.Net.IPAddressTests
{
	public class IPv6Any
	{
		[Fact]
		public void Should_return_wrapper_with_corresponding_underlying_value()
		{
			IPAddressAdapter.IPv6Any.UnsafeConvert().Should().Be(IPAddress.IPv6Any);
		}
	}
}
