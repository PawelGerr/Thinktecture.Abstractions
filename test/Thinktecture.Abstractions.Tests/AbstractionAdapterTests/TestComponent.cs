using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Thinktecture.AbstractionAdapterTests
{
	public class TestComponent
	{
		public string ToStringResult { get; set; }
		public int GetHashCodeResult { get; set; }

		[CanBeNull]
		public override string ToString()
		{
			return ToStringResult;
		}

		public override int GetHashCode()
		{
			// ReSharper disable once NonReadonlyMemberInGetHashCode
			return GetHashCodeResult;
		}
	}
}
