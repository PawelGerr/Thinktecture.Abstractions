using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Thinktecture.AbstractionEventHandlerLookupTests
{
	public class MapForAttachment
	{
		private readonly AbstractionEventHandlerLookup<ITestAbstraction, TestImplementation> _lookup;

		public MapForAttachment()
		{
			_lookup = new AbstractionEventHandlerLookup<ITestAbstraction, TestImplementation>();
		}

		[Fact]
		public void Should_return_null_if_handler_is_null()
		{
			var handler = _lookup.MapForAttachment(null, implementation => new TestAdapter());
			handler.Should().BeNull();
		}

		[Fact]
		public void Should_throw_argnull_if_convert_callback_is_null()
		{
			_lookup.Invoking(l => l.MapForAttachment((sender, abstraction) => { }, null))
				.ShouldThrow<ArgumentNullException>();
		}

		[Fact]
		public void Should_return_new_handler_that_delegates_calls()
		{
			var sender = new object();
			var implementation = new TestImplementation();
			var adapter = new TestAdapter();
			var calls = new List<Tuple<object, ITestAbstraction>>();

			EventHandler<ITestAbstraction> handler = (s, args) => calls.Add(new Tuple<object, ITestAbstraction>(s, args));

			var mappedHandler = _lookup.MapForAttachment(handler, impl => adapter);

			mappedHandler.Should().NotBeNull();
			mappedHandler(sender, implementation);

			calls.Should().HaveCount(1);
			calls[0].Item1.Should().Be(sender);
			calls[0].Item2.Should().Be(adapter);
		}

		[Fact]
		public void Should_return_same_handler_for_same_input()
		{
			var adapter = new TestAdapter();
			var calls = new List<Tuple<object, ITestAbstraction>>();

			EventHandler<ITestAbstraction> handler = (s, args) => calls.Add(new Tuple<object, ITestAbstraction>(s, args));

			var mappedHandler = _lookup.MapForAttachment(handler, impl => adapter);
			var mappedHandler2 = _lookup.MapForAttachment(handler, impl => adapter);

			mappedHandler.Should().Be(mappedHandler2);
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

		private class TestImplementation
		{
		}
	}
}