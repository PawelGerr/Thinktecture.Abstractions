using System;
using FluentAssertions;
using Xunit;

namespace Thinktecture.AbstractionDelegateLookupTests
{
	public class TryMapForDetachment
	{
		private readonly AbstractionDelegateLookup<ITestAbstraction, EventHandler<TestImplementation>> _lookup;

		public TryMapForDetachment()
		{
			_lookup = new AbstractionDelegateLookup<ITestAbstraction, EventHandler<TestImplementation>>();
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
			// ReSharper disable once ConvertToLocalFunction
			EventHandler<ITestAbstraction> handler = (s, args) => { };

			var mappedHandler = _lookup.MapForAttachment(handler, abstraction => ((sender, implementation) => abstraction(sender, new TestAdapter())));
			var mappedHandlerForDetachment = _lookup.TryMapForDetachment(handler);

			mappedHandler.Should().Be(mappedHandlerForDetachment);
		}

		[Fact]
		public void Should_return_previously_provided_method()
		{
			void Handler(object s, ITestAbstraction args)
			{
			}

			var mappedHandler = _lookup.MapForAttachment(Handler, abstraction => ((sender, implementation) => abstraction(sender, new TestAdapter())));
			var mappedHandlerForDetachment = _lookup.TryMapForDetachment(Handler);

			mappedHandler.Should().Be(mappedHandlerForDetachment);
		}

		[Fact]
		public void Should_return_null_if_number_of_detachments_is_bigger_than_attachments_using_eventhandler()
		{
			// ReSharper disable once ConvertToLocalFunction
			EventHandler<ITestAbstraction> handler = (s, args) => { };

			_lookup.MapForAttachment(handler, abstraction => ((sender, implementation) => abstraction(sender, new TestAdapter())));
			_lookup.TryMapForDetachment(handler);
			var mappedHandlerForDetachment2 = _lookup.TryMapForDetachment(handler);

			mappedHandlerForDetachment2.Should().BeNull();
		}

		[Fact]
		public void Should_return_null_if_number_of_detachments_is_bigger_than_attachments_using_method()
		{
			void Handler(object s, ITestAbstraction args)
			{
			}

			_lookup.MapForAttachment(Handler, abstraction => ((sender, implementation) => abstraction(sender, new TestAdapter())));
			_lookup.TryMapForDetachment(Handler);
			var mappedHandlerForDetachment2 = _lookup.TryMapForDetachment(Handler);

			mappedHandlerForDetachment2.Should().BeNull();
		}

		private interface ITestAbstraction : IAbstraction<TestImplementation>
		{
		}

		private class TestAdapter : ITestAbstraction
		{
			TestImplementation IAbstraction<TestImplementation>.UnsafeConvert()
			{
				throw new NotSupportedException();
			}

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
