using System;

namespace Thinktecture.Adapters
{
	public class RandomAdapter : IRandom
	{
		private readonly Random _random;

		/// <summary>Initializes a new instance of the <see cref="T:System.Random" /> class, using a time-dependent default seed value.</summary>
		public RandomAdapter()
			: this(new Random())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Random" /> class, using the specified seed value.</summary>
		/// <param name="seed">A number used to calculate a starting value for the pseudo-random number sequence. If a negative number is specified, the absolute value of the number is used. </param>
		public RandomAdapter(int seed)
			: this(new Random(seed))
		{
		}

		public RandomAdapter(Random random)
		{
			if (random == null)
				throw new ArgumentNullException(nameof(random));

			_random = random;
		}

		/// <inheritdoc />
		public Random ToImplementation()
		{
			return _random;
		}

		/// <inheritdoc />
		public int Next()
		{
			return _random.Next();
		}

		/// <inheritdoc />
		public int Next(int maxValue)
		{
			return _random.Next(maxValue);
		}

		/// <inheritdoc />
		public int Next(int minValue, int maxValue)
		{
			return _random.Next(minValue, maxValue);
		}

		/// <inheritdoc />
		public void NextBytes(byte[] buffer)
		{
			_random.NextBytes(buffer);
		}

		/// <inheritdoc />
		public double NextDouble()
		{
			return _random.NextDouble();
		}
	}
}