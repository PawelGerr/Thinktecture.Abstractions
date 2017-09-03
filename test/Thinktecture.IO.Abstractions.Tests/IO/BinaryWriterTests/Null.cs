using System.IO;
using FluentAssertions;
using Thinktecture.IO.Adapters;
using Xunit;

namespace Thinktecture.IO.BinaryWriterTests
{
	public class Null
	{
		[Fact]
		public void Should_return_wrapper_for_BinaryWriterNull()
		{
			BinaryWriterAdapter.Null.UnsafeConvert().Should().Be(BinaryWriter.Null);
		}
	}
}
