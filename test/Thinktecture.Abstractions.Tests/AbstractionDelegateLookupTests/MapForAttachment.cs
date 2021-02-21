using System;
using System.Collections.Generic;
using FluentAssertions;
using Thinktecture.Abstractions.Tests.TestClasses;
using Xunit;

namespace Thinktecture.Abstractions.Tests.AbstractionDelegateLookupTests
{
   public class MapForAttachment
   {
      private readonly AbstractionDelegateLookup<ITestAbstraction, EventHandler<TestImplementation>> _lookup;

      public MapForAttachment()
      {
         _lookup = new AbstractionDelegateLookup<ITestAbstraction, EventHandler<TestImplementation>>();
      }

      [Fact]
      public void Should_return_null_if_handler_is_null()
      {
         var handler = _lookup.MapForAttachment(null, abstraction => ((sender, impl) => abstraction(sender, new TestAdapter())));
         handler.Should().BeNull();
      }

      [Fact]
      public void Should_throw_argnull_if_convert_callback_is_null()
      {
         _lookup.Invoking(l => l.MapForAttachment((sender, abstraction) =>
                                                  {
                                                  }, null))
                .Should().Throw<ArgumentNullException>();
      }

      [Fact]
      public void Should_return_new_handler_that_delegates_calls_if_using_eventhandler()
      {
         var sender = new object();
         var implementation = new TestImplementation();
         var adapter = new TestAdapter();
         var calls = new List<Tuple<object, ITestAbstraction>>();

         // ReSharper disable once ConvertToLocalFunction
         EventHandler<ITestAbstraction> handler = (s, args) => calls.Add(new Tuple<object, ITestAbstraction>(s, args));

         var mappedHandler = _lookup.MapForAttachment(handler, abstraction => ((s, impl) =>
                                                                               {
                                                                                  impl.Should().Be(implementation);
                                                                                  abstraction(s, adapter);
                                                                               }));

         mappedHandler.Should().NotBeNull();
         mappedHandler(sender, implementation);

         calls.Should().HaveCount(1);
         calls[0].Item1.Should().Be(sender);
         calls[0].Item2.Should().Be(adapter);
      }

      [Fact]
      public void Should_return_new_handler_that_delegates_calls_if_using_method()
      {
         var sender = new object();
         var implementation = new TestImplementation();
         var adapter = new TestAdapter();
         var calls = new List<Tuple<object, ITestAbstraction>>();

         void Handler(object s, ITestAbstraction args) => calls.Add(new Tuple<object, ITestAbstraction>(s, args));

         var mappedHandler = _lookup.MapForAttachment(Handler, abstraction => ((s, impl) => abstraction(s, adapter)));

         mappedHandler.Should().NotBeNull();
         mappedHandler(sender, implementation);

         calls.Should().HaveCount(1);
         calls[0].Item1.Should().Be(sender);
         calls[0].Item2.Should().Be(adapter);
      }

      [Fact]
      public void Should_return_same_handler_for_same_eventhandler()
      {
         var adapter = new TestAdapter();
         var calls = new List<Tuple<object, ITestAbstraction>>();

         // ReSharper disable once ConvertToLocalFunction
         EventHandler<ITestAbstraction> handler = (s, args) => calls.Add(new Tuple<object, ITestAbstraction>(s, args));

         var mappedHandler = _lookup.MapForAttachment(handler, abstraction => ((sender, implementation) => abstraction(sender, adapter)));
         var mappedHandler2 = _lookup.MapForAttachment(handler, abstration => ((sender, implementation) => abstration(sender, adapter)));

         mappedHandler.Should().Be(mappedHandler2);
      }

      [Fact]
      public void Should_return_same_handler_for_same_method()
      {
         var adapter = new TestAdapter();
         var calls = new List<Tuple<object, ITestAbstraction>>();

         void Handler(object s, ITestAbstraction args) => calls.Add(new Tuple<object, ITestAbstraction>(s, args));

         var mappedHandler = _lookup.MapForAttachment(Handler, abstraction => ((sender, implementation) => abstraction(sender, adapter)));
         var mappedHandler2 = _lookup.MapForAttachment(Handler, abstraction => ((sender, implementation) => abstraction(sender, adapter)));

         mappedHandler.Should().Be(mappedHandler2);
      }
   }
}
