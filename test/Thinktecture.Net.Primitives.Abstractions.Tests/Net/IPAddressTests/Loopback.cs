using System.Net;
using FluentAssertions;
using Thinktecture.Net.Adapters;
using Xunit;

namespace Thinktecture.Net.IPAddressTests
{
	public class Loopback
	{
		[Fact]
		public void Should_return_wrapper_with_corresponding_underlying_value()
		{
			IPAddressAdapter.Loopback.UnsafeConvert().Should().Be(IPAddress.Loopback);
		}
	}
}
