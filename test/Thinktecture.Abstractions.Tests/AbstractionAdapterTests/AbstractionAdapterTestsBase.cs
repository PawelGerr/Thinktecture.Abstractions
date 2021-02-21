using Thinktecture.Abstractions.Tests.TestClasses;

namespace Thinktecture.Abstractions.Tests.AbstractionAdapterTests
{
	public class AbstractionAdapterTestsBase
	{
		protected readonly TestComponent Implementation;

		protected readonly AbstractionAdapter<TestComponent> Adapter;

		protected AbstractionAdapterTestsBase()
		{
			Implementation = new TestComponent();
			Adapter = new AbstractionAdapter<TestComponent>(Implementation);
		}
	}
}
