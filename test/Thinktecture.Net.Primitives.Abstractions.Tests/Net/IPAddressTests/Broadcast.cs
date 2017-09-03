using System.Net;
using FluentAssertions;
using Thinktecture.Net.Adapters;
using Xunit;

namespace Thinktecture.Net.IPAddressTests
{
	public class Broadcast
	{
		[Fact]
		public void Should_return_wrapper_with_corresponding_underlying_value()
		{
			IPAddressAdapter.Broadcast.UnsafeConvert().Should().Be(IPAddress.Broadcast);
		}
	}
}
