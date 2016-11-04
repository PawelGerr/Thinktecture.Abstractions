using System;
using Thinktecture.Adapters;

namespace Thinktecture
{
	public static class RandomExtensions
	{
		public static IRandom ToInterface(this Random random)
		{
			return new RandomAdapter(random);
		}
	}
}