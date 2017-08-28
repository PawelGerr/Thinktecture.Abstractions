using System;
using JetBrains.Annotations;

namespace Thinktecture
{
	/// <summary>
	/// Represents a pseudo-random number generator, which is a device that produces a sequence of numbers that meet certain statistical requirements for randomness.To browse the .NET Framework source code for this type, see the Reference Source.
	/// </summary>
	public interface IRandom : IAbstraction<Random>
	{
		/// <summary>Returns a non-negative random integer.</summary>
		/// <returns>A 32-bit signed integer that is greater than or equal to 0 and less than <see cref="F:System.Int32.MaxValue" />.</returns>
		int Next();

		/// <summary>Returns a non-negative random integer that is less than the specified maximum.</summary>
		/// <returns>A 32-bit signed integer that is greater than or equal to 0, and less than <paramref name="maxValue" />; that is, the range of return values ordinarily includes 0 but not <paramref name="maxValue" />. However, if <paramref name="maxValue" /> equals 0, <paramref name="maxValue" /> is returned.</returns>
		/// <param name="maxValue">The exclusive upper bound of the random number to be generated. <paramref name="maxValue" /> must be greater than or equal to 0. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="maxValue" /> is less than 0. </exception>
		int Next(int maxValue);

		/// <summary>Returns a random integer that is within a specified range.</summary>
		/// <returns>A 32-bit signed integer greater than or equal to <paramref name="minValue" /> and less than <paramref name="maxValue" />; that is, the range of return values includes <paramref name="minValue" /> but not <paramref name="maxValue" />. If <paramref name="minValue" /> equals <paramref name="maxValue" />, <paramref name="minValue" /> is returned.</returns>
		/// <param name="minValue">The inclusive lower bound of the random number returned. </param>
		/// <param name="maxValue">The exclusive upper bound of the random number returned. <paramref name="maxValue" /> must be greater than or equal to <paramref name="minValue" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="minValue" /> is greater than <paramref name="maxValue" />. </exception>
		int Next(int minValue, int maxValue);

		/// <summary>Fills the elements of a specified array of bytes with random numbers.</summary>
		/// <param name="buffer">An array of bytes to contain random numbers. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="buffer" /> is null. </exception>
		void NextBytes([NotNull] byte[] buffer);

		/// <summary>Returns a random floating-point number that is greater than or equal to 0.0, and less than 1.0.</summary>
		/// <returns>A double-precision floating point number that is greater than or equal to 0.0, and less than 1.0.</returns>
		double NextDouble();
	}
}
