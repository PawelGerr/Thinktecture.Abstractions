using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.AbstractionAdapterTests
{
	public class AbstractionAdapterTestsBase
	{
		protected readonly TestComponent Implementation;
		protected readonly AbstractionAdapter Adapter;

		public AbstractionAdapterTestsBase()
		{
			Implementation = new TestComponent();
			Adapter = new AbstractionAdapter(Implementation);
		}
	}
}
