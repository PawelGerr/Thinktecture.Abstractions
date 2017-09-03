using System.IO;
using FluentAssertions;
using Thinktecture.IO.Adapters;
using Xunit;

namespace Thinktecture.IO.StreamWriterTests
{
	public class Null
	{
		[Fact]
		public void Should_return_wrapper_for_StreamWriterNull()
		{
			((IAbstraction<StreamWriter>)StreamWriterAdapter.Null).UnsafeConvert().Should().Be(StreamWriter.Null);
		}
	}
}
