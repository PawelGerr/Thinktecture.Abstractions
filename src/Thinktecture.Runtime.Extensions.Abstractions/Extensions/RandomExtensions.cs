using System;
using Thinktecture.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="Random"/>.
	/// </summary>
	public static class RandomExtensions
	{
		/// <summary>
		/// Converts provided instance of <see cref="Random"/> to <see cref="IRandom"/>.
		/// </summary>
		/// <param name="random">Instance of <see cref="Random"/> to <see cref="IRandom"/>.</param>
		/// <returns>Instance of <see cref="IRandom"/>.</returns>
		public static IRandom ToInterface(this Random random)
		{
			return (random == null) ? null : new RandomAdapter(random);
		}
		
		/// <summary>
		/// Converts provided instance of <see cref="IRandom"/> to <see cref="Random"/>.
		/// </summary>
		/// <param name="random">Instance of <see cref="IRandom"/> to <see cref="Random"/>.</param>
		/// <returns>Instance of <see cref="Random"/>.</returns>
		public static Random ToImplementation(this IRandom random)
		{
			return random?.UnsafeConvert();
		}
	}
}