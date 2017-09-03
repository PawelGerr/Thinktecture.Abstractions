using System.Text;
using FluentAssertions;
using Thinktecture.Text.Adapters;
using Xunit;

namespace Thinktecture.Text.EncodingTests
{
	public class BigEndianUnicode
	{
		[Fact]
		public void Should_return_wrapper_with_EncodingBigEndianUnicode()
		{
			EncodingAdapter.BigEndianUnicode.UnsafeConvert().Should().Be(Encoding.BigEndianUnicode);
		}
	}
}
