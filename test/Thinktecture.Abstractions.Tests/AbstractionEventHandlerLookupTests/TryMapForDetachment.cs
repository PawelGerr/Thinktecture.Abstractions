using System;
using FluentAssertions;
using Xunit;

namespace Thinktecture.Abstractions.Tests.AbstractionEventHandlerLookupTests
{
	public class TryMapForDetachment
	{
		private readonly AbstractionEventHandlerLookup<ITestAbstraction, TestImplementation> _lookup;

		public TryMapForDetachment()
		{
			_lookup = new AbstractionEventHandlerLookup<ITestAbstraction, TestImplementation>();
		}

		[Fact]
		public void Should_return_null_if_handler_is_null()
		{
			var handler = _lookup.TryMapForDetachment(null);
			handler.Should().BeNull();
		}

		[Fact]
		public void Should_return_null_if_handler_is_unknown()
		{
			var handler = _lookup.TryMapForDetachment((sender, abstraction) => { });
			handler.Should().BeNull();
		}

		[Fact]
		public void Should_return_previously_provided_handler()
		{
			EventHandler<ITestAbstraction> handler = (s, args) => { };

			var mappedHandler = _lookup.MapForAttachment(handler, impl => new TestAdapter());
			var mappedHandlerForDetachment = _lookup.TryMapForDetachment(handler);

			mappedHandler.Should().Be(mappedHandlerForDetachment);
		}

		[Fact]
		public void Should_return_null_if_number_of_detachments_is_bigger_than_attachments()
		{
			EventHandler<ITestAbstraction> handler = (s, args) => { };

			_lookup.MapForAttachment(handler, impl => new TestAdapter());
			_lookup.TryMapForDetachment(handler);
			var mappedHandlerForDetachment2 = _lookup.TryMapForDetachment(handler);

			mappedHandlerForDetachment2.Should().BeNull();
		}

		private interface ITestAbstraction : IAbstraction
		{
		}

		private class TestAdapter : ITestAbstraction
		{
			public object UnsafeConvert()
			{
				throw new NotSupportedException();
			}
		}

		// ReSharper disable once ClassNeverInstantiated.Local
		private class TestImplementation
		{
		}
	}
}