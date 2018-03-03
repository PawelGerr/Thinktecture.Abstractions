using JetBrains.Annotations;

namespace Thinktecture.AbstractionAdapterTests
{
	public class AbstractionAdapterTestsBase
	{
		[NotNull]
		protected readonly TestComponent Implementation;

		[NotNull]
		protected readonly AbstractionAdapter<TestComponent> Adapter;

		protected AbstractionAdapterTestsBase()
		{
			Implementation = new TestComponent();
			Adapter = new AbstractionAdapter<TestComponent>(Implementation);
		}
	}
}
