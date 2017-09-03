using System.IO;
using FluentAssertions;
using Thinktecture.IO.Adapters;
using Xunit;

namespace Thinktecture.IO.TextWriterTests
{
	public class Null
	{
		[Fact]
		public void Should_return_wrapper_for_TextWriterNull()
		{
			TextWriterAdapter.Null.UnsafeConvert().Should().Be(TextWriter.Null);
		}
	}
}
