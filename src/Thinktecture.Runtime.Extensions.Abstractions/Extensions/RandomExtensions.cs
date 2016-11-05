using System;
using Thinktecture.Adapters;

namespace Thinktecture
{
	public static class RandomExtensions
	{
		/// <summary>
		/// Converts provided instance of <see cref="Random"/> to <see cref="IRandom"/>.
		/// </summary>
		/// <param name="random">Instance of <see cref="Random"/> to <see cref="IRandom"/>.</param>
		/// <returns>Instance of <see cref="IRandom"/>.</returns>
		public static IRandom ToInterface(this Random random)
		{
			return new RandomAdapter(random);
		}
	}
}