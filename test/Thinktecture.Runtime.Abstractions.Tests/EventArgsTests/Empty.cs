using System;
using FluentAssertions;
using Thinktecture.Adapters;
using Xunit;

namespace Thinktecture.EventArgsTests
{
	public class Empty
	{
		[Fact]
		public void Should_return_wrapper_with_EventArgsEmpty()
		{
			EventArgsAdapter.Empty.UnsafeConvert().Should().Be(EventArgs.Empty);
		}
	}
}
