using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Thinktecture.AbstractionAdapterTests
{
	public class Equals : AbstractionAdapterTestsBase
	{
		[Fact]
		public void Should_return_true_if_comparing_with_itself()
		{
			// ReSharper disable once EqualExpressionComparison
			Adapter.Equals(Adapter).Should().BeTrue();
		}

		[Fact]
		public void Should_return_true_if_comparison_of_inner_objects_yields_true()
		{
			Adapter.Equals(new AbstractionAdapter<TestComponent>(Implementation)).Should().BeTrue();
		}

		[Fact]
		public void Should_return_true_if_comparison_of_inner_objects_yields_true_despite_the_generic()
		{
			// ReSharper disable once SuspiciousTypeConversion.Global
			Adapter.Equals(new AbstractionAdapter<object>(Implementation)).Should().BeTrue();
		}

		[Fact]
		public void Should_return_false_if_comparison_of_inner_objects_yields_false()
		{
			// ReSharper disable once SuspiciousTypeConversion.Global
			Adapter.Equals(new AbstractionAdapter<object>(new object())).Should().BeFalse();
		}

		[Fact]
		public void Should_return_false_if_comparing_abstraction_with_non_abstraction()
		{
			// ReSharper disable once SuspiciousTypeConversion.Global
			Adapter.Equals(Implementation).Should().BeFalse();
		}

		[Fact]
		public void Should_return_false_if_comparing_non_abstraction_with_abstraction()
		{
			// ReSharper disable once SuspiciousTypeConversion.Global
			Implementation.Equals(Adapter).Should().BeFalse();
		}
	}
}
