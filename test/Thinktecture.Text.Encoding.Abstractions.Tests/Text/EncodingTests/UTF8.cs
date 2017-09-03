using System.Text;
using FluentAssertions;
using Thinktecture.Text.Adapters;
using Xunit;

namespace Thinktecture.Text.EncodingTests
{
	// ReSharper disable once InconsistentNaming
	public class UTF8
	{
		[Fact]
		public void Should_return_wrapper_with_EncodingUTF8()
		{
			EncodingAdapter.UTF8.UnsafeConvert().Should().Be(Encoding.UTF8);
		}
	}
}
