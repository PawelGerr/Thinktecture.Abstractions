using System.IO;
using FluentAssertions;
using Thinktecture.IO.Adapters;
using Xunit;

namespace Thinktecture.Abstractions.Tests.IO.StreamReaderTests
{
	public class Null
	{
		[Fact]
		public void Should_return_wrapper_for_StreamReaderNull()
		{
			((IAbstraction<StreamReader>)StreamReaderAdapter.Null).UnsafeConvert().Should().Be(StreamReader.Null);
		}
	}
}
