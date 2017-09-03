using System.IO;
using FluentAssertions;
using Thinktecture.IO.Adapters;
using Xunit;

namespace Thinktecture.IO.StreamTests
{
	public class Null
	{
		[Fact]
		public void Should_return_wrapper_for_StreamNull()
		{
			StreamAdapter.Null.UnsafeConvert().Should().Be(Stream.Null);
		}
	}
}
