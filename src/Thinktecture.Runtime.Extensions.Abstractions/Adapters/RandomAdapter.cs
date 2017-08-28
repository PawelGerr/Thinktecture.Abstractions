using System;
using JetBrains.Annotations;

namespace Thinktecture.Adapters
{
	/// <summary>
	/// Adapter for <see cref="Random"/>.
	/// </summary>
	public class RandomAdapter : AbstractionAdapter<Random>, IRandom
	{
		/// <summary>Initializes a new instance of the <see cref="RandomAdapter" /> class, using a time-dependent default seed value.</summary>
		public RandomAdapter()
			: this(new Random())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="RandomAdapter" /> class, using the specified seed value.</summary>
		/// <param name="seed">A number used to calculate a starting value for the pseudo-random number sequence. If a negative number is specified, the absolute value of the number is used. </param>
		public RandomAdapter(int seed)
			: this(new Random(seed))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RandomAdapter" /> class.
		/// </summary>
		/// <param name="random">Random to be used by the adapter.</param>
		public RandomAdapter([NotNull] Random random)
			: base(random)
		{
		}

		/// <inheritdoc />
		public int Next()
		{
			return Implementation.Next();
		}

		/// <inheritdoc />
		public int Next(int maxValue)
		{
			return Implementation.Next(maxValue);
		}

		/// <inheritdoc />
		public int Next(int minValue, int maxValue)
		{
			return Implementation.Next(minValue, maxValue);
		}

		/// <inheritdoc />
		public void NextBytes(byte[] buffer)
		{
			Implementation.NextBytes(buffer);
		}

		/// <inheritdoc />
		public double NextDouble()
		{
			return Implementation.NextDouble();
		}
	}
}
