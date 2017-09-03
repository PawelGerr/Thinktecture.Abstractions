using System.IO;
using FluentAssertions;
using Thinktecture.IO.Adapters;
using Xunit;

namespace Thinktecture.IO.TextReaderTests
{
	public class Null
	{
		[Fact]
		public void Should_return_wrapper_for_TextReaderNull()
		{
			TextReaderAdapter.Null.UnsafeConvert().Should().Be(TextReader.Null);
		}
	}
}
