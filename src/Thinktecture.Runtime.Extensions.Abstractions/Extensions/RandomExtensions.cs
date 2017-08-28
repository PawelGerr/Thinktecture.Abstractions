using System;
using JetBrains.Annotations;
using Thinktecture.Adapters;

// ReSharper disable once CheckNamespace
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
		[CanBeNull]
		public static IRandom ToInterface([CanBeNull] this Random random)
		{
			return (random == null) ? null : new RandomAdapter(random);
		}
	}
}
