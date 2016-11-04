using System;

namespace Thinktecture.Adapters
{
	public class RandomAdapter : IRandom
	{
		private readonly Random _random;

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