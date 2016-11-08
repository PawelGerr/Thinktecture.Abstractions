using System;
using System.ComponentModel;

namespace Thinktecture.Adapters
{
	/// <summary>
	/// Adapter for <see cref="Random"/>.
	/// </summary>
	public class RandomAdapter : IRandom
	{
		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Random InternalInstance { get; }

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
		public RandomAdapter(Random random)
		{
			if (random == null)
				throw new ArgumentNullException(nameof(random));

			InternalInstance = random;
		}
		
		/// <inheritdoc />
		public int Next()
		{
			return InternalInstance.Next();
		}

		/// <inheritdoc />
		public int Next(int maxValue)
		{
			return InternalInstance.Next(maxValue);
		}

		/// <inheritdoc />
		public int Next(int minValue, int maxValue)
		{
			return InternalInstance.Next(minValue, maxValue);
		}

		/// <inheritdoc />
		public void NextBytes(byte[] buffer)
		{
			InternalInstance.NextBytes(buffer);
		}

		/// <inheritdoc />
		public double NextDouble()
		{
			return InternalInstance.NextDouble();
		}
	}
}