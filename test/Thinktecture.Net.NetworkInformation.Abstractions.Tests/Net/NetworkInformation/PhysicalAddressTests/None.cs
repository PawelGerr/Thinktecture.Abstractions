using System.Net.NetworkInformation;
using FluentAssertions;
using Thinktecture.Net.NetworkInformation.Adapters;
using Xunit;

namespace Thinktecture.Net.NetworkInformation.PhysicalAddressTests
{
	public class None
	{
		[Fact]
		public void Should_return_wrapper_for_PhysicalAddressNull()
		{
			PhysicalAddressAdapter.None.UnsafeConvert().Should().Be(PhysicalAddress.None);
		}
	}
}
