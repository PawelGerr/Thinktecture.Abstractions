using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Thinktecture.AbstractionAdapterTests
{
	public class AbstractionAdapterTestsBase
	{
		[NotNull]
		protected readonly TestComponent Implementation;

		[NotNull]
		protected readonly AbstractionAdapter Adapter;

		protected AbstractionAdapterTestsBase()
		{
			Implementation = new TestComponent();
			Adapter = new AbstractionAdapter(Implementation);
		}
	}
}
