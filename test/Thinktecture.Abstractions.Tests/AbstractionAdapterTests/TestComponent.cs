namespace Thinktecture.Abstractions.Tests.AbstractionAdapterTests
{
	public class TestComponent
	{
		public string ToStringResult { get; set; }
		public int GetHashCodeResult { get; set; }

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