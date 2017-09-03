using System.Text;
using FluentAssertions;
using Thinktecture.Text.Adapters;
using Xunit;

namespace Thinktecture.Text.EncodingTests
{
	public class Unicode
	{
		[Fact]
		public void Should_return_wrapper_with_EncodingUnicode()
		{
			EncodingAdapter.Unicode.UnsafeConvert().Should().Be(Encoding.Unicode);
		}
	}
}
