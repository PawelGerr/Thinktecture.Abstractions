using System;

namespace Thinktecture
{
   /// <summary>
   /// Provides constants and static methods for trigonometric, logarithmic, and other common mathematical functions.
   /// </summary>
   public interface IMath
   {
      /// <summary>Represents the ratio of the circumference of a circle to its diameter, specified by the constant, π.</summary>
      // ReSharper disable once InconsistentNaming
      double PI { get; }

      /// <summary>Represents the natural logarithmic base, specified by the constant, e.</summary>
      double E { get; }

#if NET5_0
      /// <summary>Represents the number of radians in one turn, specified by the constant, τ.</summary>
      double Tau { get; }
#endif

      /// <summary>
      /// Returns the <paramref name="value"/> that is betweend <paramref name="min"/> and <paramref name="max"/>.
      /// </summary>
      /// <param name="value">The value to check.</param>
      /// <param name="min">Lower boundary.</param>
      /// <param name="max">Upper boundary.</param>
      /// <returns>
      /// <paramref name="value"/> if it is between <paramref name="min"/> and <paramref name="max"/>;
      /// <paramref name="min"/> if <paramref name="value"/> is less than <paramref name="min"/>;
      /// <paramref name="max"/> if <paramref name="value"/> is greater than <paramref name="max"/>;
      /// </returns>
      byte Clamp(byte value, byte min, byte max);

      /// <summary>
      /// Returns the <paramref name="value"/> that is betweend <paramref name="min"/> and <paramref name="max"/>.
      /// </summary>
      /// <param name="value">The value to check.</param>
      /// <param name="min">Lower boundary.</param>
      /// <param name="max">Upper boundary.</param>
      /// <returns>
      /// <paramref name="value"/> if it is between <paramref name="min"/> and <paramref name="max"/>;
      /// <paramref name="min"/> if <paramref name="value"/> is less than <paramref name="min"/>;
      /// <paramref name="max"/> if <paramref name="value"/> is greater than <paramref name="max"/>;
      /// </returns>
      decimal Clamp(decimal value, decimal min, decimal max);

      /// <summary>
      /// Returns the <paramref name="value"/> that is betweend <paramref name="min"/> and <paramref name="max"/>.
      /// </summary>
      /// <param name="value">The value to check.</param>
      /// <param name="min">Lower boundary.</param>
      /// <param name="max">Upper boundary.</param>
      /// <returns>
      /// <paramref name="value"/> if it is between <paramref name="min"/> and <paramref name="max"/>;
      /// <paramref name="min"/> if <paramref name="value"/> is less than <paramref name="min"/>;
      /// <paramref name="max"/> if <paramref name="value"/> is greater than <paramref name="max"/>;
      /// </returns>
      double Clamp(double value, double min, double max);

      /// <summary>
      /// Returns the <paramref name="value"/> that is betweend <paramref name="min"/> and <paramref name="max"/>.
      /// </summary>
      /// <param name="value">The value to check.</param>
      /// <param name="min">Lower boundary.</param>
      /// <param name="max">Upper boundary.</param>
      /// <returns>
      /// <paramref name="value"/> if it is between <paramref name="min"/> and <paramref name="max"/>;
      /// <paramref name="min"/> if <paramref name="value"/> is less than <paramref name="min"/>;
      /// <paramref name="max"/> if <paramref name="value"/> is greater than <paramref name="max"/>;
      /// </returns>
      float Clamp(float value, float min, float max);

      /// <summary>
      /// Returns the <paramref name="value"/> that is betweend <paramref name="min"/> and <paramref name="max"/>.
      /// </summary>
      /// <param name="value">The value to check.</param>
      /// <param name="min">Lower boundary.</param>
      /// <param name="max">Upper boundary.</param>
      /// <returns>
      /// <paramref name="value"/> if it is between <paramref name="min"/> and <paramref name="max"/>;
      /// <paramref name="min"/> if <paramref name="value"/> is less than <paramref name="min"/>;
      /// <paramref name="max"/> if <paramref name="value"/> is greater than <paramref name="max"/>;
      /// </returns>
      int Clamp(int value, int min, int max);

      /// <summary>
      /// Returns the <paramref name="value"/> that is betweend <paramref name="min"/> and <paramref name="max"/>.
      /// </summary>
      /// <param name="value">The value to check.</param>
      /// <param name="min">Lower boundary.</param>
      /// <param name="max">Upper boundary.</param>
      /// <returns>
      /// <paramref name="value"/> if it is between <paramref name="min"/> and <paramref name="max"/>;
      /// <paramref name="min"/> if <paramref name="value"/> is less than <paramref name="min"/>;
      /// <paramref name="max"/> if <paramref name="value"/> is greater than <paramref name="max"/>;
      /// </returns>
      long Clamp(long value, long min, long max);

      /// <summary>
      /// Returns the <paramref name="value"/> that is betweend <paramref name="min"/> and <paramref name="max"/>.
      /// </summary>
      /// <param name="value">The value to check.</param>
      /// <param name="min">Lower boundary.</param>
      /// <param name="max">Upper boundary.</param>
      /// <returns>
      /// <paramref name="value"/> if it is between <paramref name="min"/> and <paramref name="max"/>;
      /// <paramref name="min"/> if <paramref name="value"/> is less than <paramref name="min"/>;
      /// <paramref name="max"/> if <paramref name="value"/> is greater than <paramref name="max"/>;
      /// </returns>
      sbyte Clamp(sbyte value, sbyte min, sbyte max);

      /// <summary>
      /// Returns the <paramref name="value"/> that is betweend <paramref name="min"/> and <paramref name="max"/>.
      /// </summary>
      /// <param name="value">The value to check.</param>
      /// <param name="min">Lower boundary.</param>
      /// <param name="max">Upper boundary.</param>
      /// <returns>
      /// <paramref name="value"/> if it is between <paramref name="min"/> and <paramref name="max"/>;
      /// <paramref name="min"/> if <paramref name="value"/> is less than <paramref name="min"/>;
      /// <paramref name="max"/> if <paramref name="value"/> is greater than <paramref name="max"/>;
      /// </returns>
      short Clamp(short value, short min, short max);

      /// <summary>
      /// Returns the <paramref name="value"/> that is betweend <paramref name="min"/> and <paramref name="max"/>.
      /// </summary>
      /// <param name="value">The value to check.</param>
      /// <param name="min">Lower boundary.</param>
      /// <param name="max">Upper boundary.</param>
      /// <returns>
      /// <paramref name="value"/> if it is between <paramref name="min"/> and <paramref name="max"/>;
      /// <paramref name="min"/> if <paramref name="value"/> is less than <paramref name="min"/>;
      /// <paramref name="max"/> if <paramref name="value"/> is greater than <paramref name="max"/>;
      /// </returns>
      uint Clamp(uint value, uint min, uint max);

      /// <summary>
      /// Returns the <paramref name="value"/> that is betweend <paramref name="min"/> and <paramref name="max"/>.
      /// </summary>
      /// <param name="value">The value to check.</param>
      /// <param name="min">Lower boundary.</param>
      /// <param name="max">Upper boundary.</param>
      /// <returns>
      /// <paramref name="value"/> if it is between <paramref name="min"/> and <paramref name="max"/>;
      /// <paramref name="min"/> if <paramref name="value"/> is less than <paramref name="min"/>;
      /// <paramref name="max"/> if <paramref name="value"/> is greater than <paramref name="max"/>;
      /// </returns>
      ulong Clamp(ulong value, ulong min, ulong max);

      /// <summary>
      /// Returns the <paramref name="value"/> that is betweend <paramref name="min"/> and <paramref name="max"/>.
      /// </summary>
      /// <param name="value">The value to check.</param>
      /// <param name="min">Lower boundary.</param>
      /// <param name="max">Upper boundary.</param>
      /// <returns>
      /// <paramref name="value"/> if it is between <paramref name="min"/> and <paramref name="max"/>;
      /// <paramref name="min"/> if <paramref name="value"/> is less than <paramref name="min"/>;
      /// <paramref name="max"/> if <paramref name="value"/> is greater than <paramref name="max"/>;
      /// </returns>
      ushort Clamp(ushort value, ushort min, ushort max);

      /// <summary>Returns hyperbolic arc-cosine of the given number.</summary>
      double Acosh(double value);

      /// <summary>Returns hyperbolic arc-sine of the given number.</summary>
      double Asinh(double value);

      /// <summary>Returns hyperbolic arc-tangent of the given number.</summary>
      double Atanh(double value);

      /// <summary>
      /// Returns the cube root of a number.
      /// </summary>
      double Cbrt(double value);

      /// <summary>Returns the absolute value of a <see cref="T:System.Decimal" /> number.</summary>
      /// <returns>A decimal number, x, such that 0 ≤ x ≤<see cref="F:System.Decimal.MaxValue" />.</returns>
      /// <param name="value">A number that is greater than or equal to <see cref="F:System.Decimal.MinValue" />, but less than or equal to <see cref="F:System.Decimal.MaxValue" />. </param>
      decimal Abs(decimal value);

      /// <summary>Returns the absolute value of a double-precision floating-point number.</summary>
      /// <returns>A double-precision floating-point number, x, such that 0 ≤ x ≤<see cref="F:System.Double.MaxValue" />.</returns>
      /// <param name="value">A number that is greater than or equal to <see cref="F:System.Double.MinValue" />, but less than or equal to <see cref="F:System.Double.MaxValue" />.</param>
      double Abs(double value);

      /// <summary>Returns the absolute value of a 16-bit signed integer.</summary>
      /// <returns>A 16-bit signed integer, x, such that 0 ≤ x ≤<see cref="F:System.Int16.MaxValue" />.</returns>
      /// <param name="value">A number that is greater than <see cref="F:System.Int16.MinValue" />, but less than or equal to <see cref="F:System.Int16.MaxValue" />.</param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> equals <see cref="F:System.Int16.MinValue" />. </exception>
      short Abs(short value);

      /// <summary>Returns the absolute value of a 32-bit signed integer.</summary>
      /// <returns>A 32-bit signed integer, x, such that 0 ≤ x ≤<see cref="F:System.Int32.MaxValue" />.</returns>
      /// <param name="value">A number that is greater than <see cref="F:System.Int32.MinValue" />, but less than or equal to <see cref="F:System.Int32.MaxValue" />.</param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> equals <see cref="F:System.Int32.MinValue" />. </exception>
      int Abs(int value);

      /// <summary>Returns the absolute value of a 64-bit signed integer.</summary>
      /// <returns>A 64-bit signed integer, x, such that 0 ≤ x ≤<see cref="F:System.Int64.MaxValue" />.</returns>
      /// <param name="value">A number that is greater than <see cref="F:System.Int64.MinValue" />, but less than or equal to <see cref="F:System.Int64.MaxValue" />.</param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> equals <see cref="F:System.Int64.MinValue" />. </exception>
      long Abs(long value);

      /// <summary>Returns the absolute value of an 8-bit signed integer.</summary>
      /// <returns>An 8-bit signed integer, x, such that 0 ≤ x ≤<see cref="F:System.SByte.MaxValue" />.</returns>
      /// <param name="value">A number that is greater than <see cref="F:System.SByte.MinValue" />, but less than or equal to <see cref="F:System.SByte.MaxValue" />.</param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> equals <see cref="F:System.SByte.MinValue" />. </exception>
      sbyte Abs(sbyte value);

      /// <summary>Returns the absolute value of a single-precision floating-point number.</summary>
      /// <returns>A single-precision floating-point number, x, such that 0 ≤ x ≤<see cref="F:System.Single.MaxValue" />.</returns>
      /// <param name="value">A number that is greater than or equal to <see cref="F:System.Single.MinValue" />, but less than or equal to <see cref="F:System.Single.MaxValue" />.</param>
      float Abs(float value);

      /// <summary>Returns the angle whose cosine is the specified number.</summary>
      /// <returns>An angle, θ, measured in radians, such that 0 ≤θ≤π-or- <see cref="F:System.Double.NaN" /> if <paramref name="d" /> &lt; -1 or <paramref name="d" /> &gt; 1 or <paramref name="d" /> equals <see cref="F:System.Double.NaN" />.</returns>
      /// <param name="d">A number representing a cosine, where <paramref name="d" /> must be greater than or equal to -1, but less than or equal to 1. </param>
      double Acos(double d);

      /// <summary>Returns the angle whose sine is the specified number.</summary>
      /// <returns>An angle, θ, measured in radians, such that -π/2 ≤θ≤π/2 -or- <see cref="F:System.Double.NaN" /> if <paramref name="d" /> &lt; -1 or <paramref name="d" /> &gt; 1 or <paramref name="d" /> equals <see cref="F:System.Double.NaN" />.</returns>
      /// <param name="d">A number representing a sine, where <paramref name="d" /> must be greater than or equal to -1, but less than or equal to 1. </param>
      double Asin(double d);

      /// <summary>Returns the angle whose tangent is the specified number.</summary>
      /// <returns>An angle, θ, measured in radians, such that -π/2 ≤θ≤π/2.-or- <see cref="F:System.Double.NaN" /> if <paramref name="d" /> equals <see cref="F:System.Double.NaN" />, -π/2 rounded to double precision (-1.5707963267949) if <paramref name="d" /> equals <see cref="F:System.Double.NegativeInfinity" />, or π/2 rounded to double precision (1.5707963267949) if <paramref name="d" /> equals <see cref="F:System.Double.PositiveInfinity" />.</returns>
      /// <param name="d">A number representing a tangent. </param>
      double Atan(double d);

      /// <summary>Returns the angle whose tangent is the quotient of two specified numbers.</summary>
      /// <returns>An angle, θ, measured in radians, such that -π≤θ≤π, and tan(θ) = <paramref name="y" /> / <paramref name="x" />, where (<paramref name="x" />, <paramref name="y" />) is a point in the Cartesian plane. Observe the following: For (<paramref name="x" />, <paramref name="y" />) in quadrant 1, 0 &lt; θ &lt; π/2.For (<paramref name="x" />, <paramref name="y" />) in quadrant 2, π/2 &lt; θ≤π.For (<paramref name="x" />, <paramref name="y" />) in quadrant 3, -π &lt; θ &lt; -π/2.For (<paramref name="x" />, <paramref name="y" />) in quadrant 4, -π/2 &lt; θ &lt; 0.For points on the boundaries of the quadrants, the return value is the following:If y is 0 and x is not negative, θ = 0.If y is 0 and x is negative, θ = π.If y is positive and x is 0, θ = π/2.If y is negative and x is 0, θ = -π/2.If y is 0 and x is 0, θ = 0. If <paramref name="x" /> or <paramref name="y" /> is <see cref="F:System.Double.NaN" />, or if <paramref name="x" /> and <paramref name="y" /> are either <see cref="F:System.Double.PositiveInfinity" /> or <see cref="F:System.Double.NegativeInfinity" />, the method returns <see cref="F:System.Double.NaN" />.</returns>
      /// <param name="y">The y coordinate of a point. </param>
      /// <param name="x">The x coordinate of a point. </param>
      double Atan2(double y, double x);

      /// <summary>Returns the smallest integral value that is greater than or equal to the specified decimal number.</summary>
      /// <returns>The smallest integral value that is greater than or equal to <paramref name="d" />. Note that this method returns a <see cref="T:System.Decimal" /> instead of an integral type.</returns>
      /// <param name="d">A decimal number. </param>
      decimal Ceiling(decimal d);

      /// <summary>Returns the smallest integral value that is greater than or equal to the specified double-precision floating-point number.</summary>
      /// <returns>The smallest integral value that is greater than or equal to <paramref name="a" />. If <paramref name="a" /> is equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" />, or <see cref="F:System.Double.PositiveInfinity" />, that value is returned. Note that this method returns a <see cref="T:System.Double" /> instead of an integral type.</returns>
      /// <param name="a">A double-precision floating-point number. </param>
      double Ceiling(double a);

      /// <summary>Returns the cosine of the specified angle.</summary>
      /// <returns>The cosine of <paramref name="d" />. If <paramref name="d" /> is equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" />, or <see cref="F:System.Double.PositiveInfinity" />, this method returns <see cref="F:System.Double.NaN" />.</returns>
      /// <param name="d">An angle, measured in radians. </param>
      double Cos(double d);

      /// <summary>Returns the hyperbolic cosine of the specified angle.</summary>
      /// <returns>The hyperbolic cosine of <paramref name="value" />. If <paramref name="value" /> is equal to <see cref="F:System.Double.NegativeInfinity" /> or <see cref="F:System.Double.PositiveInfinity" />, <see cref="F:System.Double.PositiveInfinity" /> is returned. If <paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NaN" /> is returned.</returns>
      /// <param name="value">An angle, measured in radians. </param>
      double Cosh(double value);

      /// <summary>Returns e raised to the specified power.</summary>
      /// <returns>The number e raised to the power <paramref name="d" />. If <paramref name="d" /> equals <see cref="F:System.Double.NaN" /> or <see cref="F:System.Double.PositiveInfinity" />, that value is returned. If <paramref name="d" /> equals <see cref="F:System.Double.NegativeInfinity" />, 0 is returned.</returns>
      /// <param name="d">A number specifying a power. </param>
      double Exp(double d);

      /// <summary>Returns the largest integer less than or equal to the specified decimal number.</summary>
      /// <returns>The largest integer less than or equal to <paramref name="d" />.  Note that the method returns an integral value of type <see cref="T:System.Math" />. </returns>
      /// <param name="d">A decimal number. </param>
      decimal Floor(decimal d);

      /// <summary>Returns the largest integer less than or equal to the specified double-precision floating-point number.</summary>
      /// <returns>The largest integer less than or equal to <paramref name="d" />. If <paramref name="d" /> is equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" />, or <see cref="F:System.Double.PositiveInfinity" />, that value is returned.</returns>
      /// <param name="d">A double-precision floating-point number. </param>
      double Floor(double d);

      /// <summary>Returns the remainder resulting from the division of a specified number by another specified number.</summary>
      /// <returns>A number equal to <paramref name="x" /> - (<paramref name="y" /> Q), where Q is the quotient of <paramref name="x" /> / <paramref name="y" /> rounded to the nearest integer (if <paramref name="x" /> / <paramref name="y" /> falls halfway between two integers, the even integer is returned).If <paramref name="x" /> - (<paramref name="y" /> Q) is zero, the value +0 is returned if <paramref name="x" /> is positive, or -0 if <paramref name="x" /> is negative.If <paramref name="y" /> = 0, <see cref="F:System.Double.NaN" /> is returned.</returns>
      /// <param name="x">A dividend. </param>
      /// <param name="y">A divisor. </param>
      // ReSharper disable once InconsistentNaming
      double IEEERemainder(double x, double y);

      /// <summary>Returns the natural (base e) logarithm of a specified number.</summary>
      /// <returns>One of the values in the following table. <paramref name="d" /> parameterReturn value Positive The natural logarithm of <paramref name="d" />; that is, ln <paramref name="d" />, or log e<paramref name="d" />Zero <see cref="F:System.Double.NegativeInfinity" />Negative <see cref="F:System.Double.NaN" />Equal to <see cref="F:System.Double.NaN" /><see cref="F:System.Double.NaN" />Equal to <see cref="F:System.Double.PositiveInfinity" /><see cref="F:System.Double.PositiveInfinity" /></returns>
      /// <param name="d">The number whose logarithm is to be found. </param>
      double Log(double d);

      /// <summary>Returns the logarithm of a specified number in a specified base.</summary>
      /// <returns>One of the values in the following table. (+Infinity denotes <see cref="F:System.Double.PositiveInfinity" />, -Infinity denotes <see cref="F:System.Double.NegativeInfinity" />, and NaN denotes <see cref="F:System.Double.NaN" />.)<paramref name="a" /><paramref name="newBase" />Return value<paramref name="a" />&gt; 0(0 &lt;<paramref name="newBase" />&lt; 1) -or-(<paramref name="newBase" />&gt; 1)lognewBase(a)<paramref name="a" />&lt; 0(any value)NaN(any value)<paramref name="newBase" />&lt; 0NaN<paramref name="a" /> != 1<paramref name="newBase" /> = 0NaN<paramref name="a" /> != 1<paramref name="newBase" /> = +InfinityNaN<paramref name="a" /> = NaN(any value)NaN(any value)<paramref name="newBase" /> = NaNNaN(any value)<paramref name="newBase" /> = 1NaN<paramref name="a" /> = 00 &lt;<paramref name="newBase" />&lt; 1 +Infinity<paramref name="a" /> = 0<paramref name="newBase" />&gt; 1-Infinity<paramref name="a" /> =  +Infinity0 &lt;<paramref name="newBase" />&lt; 1-Infinity<paramref name="a" /> =  +Infinity<paramref name="newBase" />&gt; 1+Infinity<paramref name="a" /> = 1<paramref name="newBase" /> = 00<paramref name="a" /> = 1<paramref name="newBase" /> = +Infinity0</returns>
      /// <param name="a">The number whose logarithm is to be found. </param>
      /// <param name="newBase">The base of the logarithm. </param>
      double Log(double a, double newBase);

      /// <summary>Returns the base 10 logarithm of a specified number.</summary>
      /// <returns>One of the values in the following table. <paramref name="d" /> parameter Return value Positive The base 10 log of <paramref name="d" />; that is, log 10<paramref name="d" />. Zero <see cref="F:System.Double.NegativeInfinity" />Negative <see cref="F:System.Double.NaN" />Equal to <see cref="F:System.Double.NaN" /><see cref="F:System.Double.NaN" />Equal to <see cref="F:System.Double.PositiveInfinity" /><see cref="F:System.Double.PositiveInfinity" /></returns>
      /// <param name="d">A number whose logarithm is to be found. </param>
      double Log10(double d);

      /// <summary>Returns the larger of two 8-bit unsigned integers.</summary>
      /// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
      /// <param name="val1">The first of two 8-bit unsigned integers to compare. </param>
      /// <param name="val2">The second of two 8-bit unsigned integers to compare. </param>
      byte Max(byte val1, byte val2);

      /// <summary>Returns the larger of two decimal numbers.</summary>
      /// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
      /// <param name="val1">The first of two decimal numbers to compare. </param>
      /// <param name="val2">The second of two decimal numbers to compare. </param>
      decimal Max(decimal val1, decimal val2);

      /// <summary>Returns the larger of two double-precision floating-point numbers.</summary>
      /// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger. If <paramref name="val1" />, <paramref name="val2" />, or both <paramref name="val1" /> and <paramref name="val2" /> are equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NaN" /> is returned.</returns>
      /// <param name="val1">The first of two double-precision floating-point numbers to compare. </param>
      /// <param name="val2">The second of two double-precision floating-point numbers to compare. </param>
      double Max(double val1, double val2);

      /// <summary>Returns the larger of two 16-bit signed integers.</summary>
      /// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
      /// <param name="val1">The first of two 16-bit signed integers to compare. </param>
      /// <param name="val2">The second of two 16-bit signed integers to compare. </param>
      short Max(short val1, short val2);

      /// <summary>Returns the larger of two 32-bit signed integers.</summary>
      /// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
      /// <param name="val1">The first of two 32-bit signed integers to compare. </param>
      /// <param name="val2">The second of two 32-bit signed integers to compare. </param>
      int Max(int val1, int val2);

      /// <summary>Returns the larger of two 64-bit signed integers.</summary>
      /// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
      /// <param name="val1">The first of two 64-bit signed integers to compare. </param>
      /// <param name="val2">The second of two 64-bit signed integers to compare. </param>
      long Max(long val1, long val2);

      /// <summary>Returns the larger of two 8-bit signed integers.</summary>
      /// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
      /// <param name="val1">The first of two 8-bit signed integers to compare. </param>
      /// <param name="val2">The second of two 8-bit signed integers to compare. </param>
      sbyte Max(sbyte val1, sbyte val2);

      /// <summary>Returns the larger of two single-precision floating-point numbers.</summary>
      /// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger. If <paramref name="val1" />, or <paramref name="val2" />, or both <paramref name="val1" /> and <paramref name="val2" /> are equal to <see cref="F:System.Single.NaN" />, <see cref="F:System.Single.NaN" /> is returned.</returns>
      /// <param name="val1">The first of two single-precision floating-point numbers to compare. </param>
      /// <param name="val2">The second of two single-precision floating-point numbers to compare. </param>
      float Max(float val1, float val2);

      /// <summary>Returns the larger of two 16-bit unsigned integers.</summary>
      /// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
      /// <param name="val1">The first of two 16-bit unsigned integers to compare. </param>
      /// <param name="val2">The second of two 16-bit unsigned integers to compare. </param>
      ushort Max(ushort val1, ushort val2);

      /// <summary>Returns the larger of two 32-bit unsigned integers.</summary>
      /// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
      /// <param name="val1">The first of two 32-bit unsigned integers to compare. </param>
      /// <param name="val2">The second of two 32-bit unsigned integers to compare. </param>
      uint Max(uint val1, uint val2);

      /// <summary>Returns the larger of two 64-bit unsigned integers.</summary>
      /// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
      /// <param name="val1">The first of two 64-bit unsigned integers to compare. </param>
      /// <param name="val2">The second of two 64-bit unsigned integers to compare. </param>
      ulong Max(ulong val1, ulong val2);

      /// <summary>Returns the smaller of two 8-bit unsigned integers.</summary>
      /// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
      /// <param name="val1">The first of two 8-bit unsigned integers to compare. </param>
      /// <param name="val2">The second of two 8-bit unsigned integers to compare. </param>
      byte Min(byte val1, byte val2);

      /// <summary>Returns the smaller of two decimal numbers.</summary>
      /// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
      /// <param name="val1">The first of two decimal numbers to compare. </param>
      /// <param name="val2">The second of two decimal numbers to compare. </param>
      decimal Min(decimal val1, decimal val2);

      /// <summary>Returns the smaller of two double-precision floating-point numbers.</summary>
      /// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller. If <paramref name="val1" />, <paramref name="val2" />, or both <paramref name="val1" /> and <paramref name="val2" /> are equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NaN" /> is returned.</returns>
      /// <param name="val1">The first of two double-precision floating-point numbers to compare. </param>
      /// <param name="val2">The second of two double-precision floating-point numbers to compare. </param>
      double Min(double val1, double val2);

      /// <summary>Returns the smaller of two 16-bit signed integers.</summary>
      /// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
      /// <param name="val1">The first of two 16-bit signed integers to compare. </param>
      /// <param name="val2">The second of two 16-bit signed integers to compare. </param>
      short Min(short val1, short val2);

      /// <summary>Returns the smaller of two 32-bit signed integers.</summary>
      /// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
      /// <param name="val1">The first of two 32-bit signed integers to compare. </param>
      /// <param name="val2">The second of two 32-bit signed integers to compare. </param>
      int Min(int val1, int val2);

      /// <summary>Returns the smaller of two 64-bit signed integers.</summary>
      /// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
      /// <param name="val1">The first of two 64-bit signed integers to compare. </param>
      /// <param name="val2">The second of two 64-bit signed integers to compare. </param>
      long Min(long val1, long val2);

      /// <summary>Returns the smaller of two 8-bit signed integers.</summary>
      /// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
      /// <param name="val1">The first of two 8-bit signed integers to compare. </param>
      /// <param name="val2">The second of two 8-bit signed integers to compare. </param>
      sbyte Min(sbyte val1, sbyte val2);

      /// <summary>Returns the smaller of two single-precision floating-point numbers.</summary>
      /// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller. If <paramref name="val1" />, <paramref name="val2" />, or both <paramref name="val1" /> and <paramref name="val2" /> are equal to <see cref="F:System.Single.NaN" />, <see cref="F:System.Single.NaN" /> is returned.</returns>
      /// <param name="val1">The first of two single-precision floating-point numbers to compare. </param>
      /// <param name="val2">The second of two single-precision floating-point numbers to compare. </param>
      float Min(float val1, float val2);

      /// <summary>Returns the smaller of two 16-bit unsigned integers.</summary>
      /// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
      /// <param name="val1">The first of two 16-bit unsigned integers to compare. </param>
      /// <param name="val2">The second of two 16-bit unsigned integers to compare. </param>
      ushort Min(ushort val1, ushort val2);

      /// <summary>Returns the smaller of two 32-bit unsigned integers.</summary>
      /// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
      /// <param name="val1">The first of two 32-bit unsigned integers to compare. </param>
      /// <param name="val2">The second of two 32-bit unsigned integers to compare. </param>
      uint Min(uint val1, uint val2);

      /// <summary>Returns the smaller of two 64-bit unsigned integers.</summary>
      /// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
      /// <param name="val1">The first of two 64-bit unsigned integers to compare. </param>
      /// <param name="val2">The second of two 64-bit unsigned integers to compare. </param>
      ulong Min(ulong val1, ulong val2);

      /// <summary>Returns a specified number raised to the specified power.</summary>
      /// <returns>The number <paramref name="x" /> raised to the power <paramref name="y" />.</returns>
      /// <param name="x">A double-precision floating-point number to be raised to a power. </param>
      /// <param name="y">A double-precision floating-point number that specifies a power. </param>
      double Pow(double x, double y);

      /// <summary>Rounds a decimal value to the nearest integral value.</summary>
      /// <returns>The integer nearest parameter <paramref name="d" />. If the fractional component of <paramref name="d" /> is halfway between two integers, one of which is even and the other odd, the even number is returned. Note that this method returns a <see cref="T:System.Decimal" /> instead of an integral type.</returns>
      /// <param name="d">A decimal number to be rounded. </param>
      /// <exception cref="T:System.OverflowException">The result is outside the range of a <see cref="T:System.Decimal" />.</exception>
      decimal Round(decimal d);

      /// <summary>Rounds a decimal value to a specified number of fractional digits.</summary>
      /// <returns>The number nearest to <paramref name="d" /> that contains a number of fractional digits equal to <paramref name="decimals" />. </returns>
      /// <param name="d">A decimal number to be rounded. </param>
      /// <param name="decimals">The number of decimal places in the return value. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="decimals" /> is less than 0 or greater than 28. </exception>
      /// <exception cref="T:System.OverflowException">The result is outside the range of a <see cref="T:System.Decimal" />.</exception>
      decimal Round(decimal d, int decimals);

      /// <summary>Rounds a decimal value to a specified number of fractional digits. A parameter specifies how to round the value if it is midway between two numbers.</summary>
      /// <returns>The number nearest to <paramref name="d" /> that contains a number of fractional digits equal to <paramref name="decimals" />. If <paramref name="d" /> has fewer fractional digits than <paramref name="decimals" />, <paramref name="d" /> is returned unchanged.</returns>
      /// <param name="d">A decimal number to be rounded. </param>
      /// <param name="decimals">The number of decimal places in the return value. </param>
      /// <param name="mode">Specification for how to round <paramref name="d" /> if it is midway between two other numbers.</param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="decimals" /> is less than 0 or greater than 28. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="mode" /> is not a valid value of <see cref="T:System.MidpointRounding" />.</exception>
      /// <exception cref="T:System.OverflowException">The result is outside the range of a <see cref="T:System.Decimal" />.</exception>
      decimal Round(decimal d, int decimals, MidpointRounding mode);

      /// <summary>Rounds a decimal value to the nearest integer. A parameter specifies how to round the value if it is midway between two numbers.</summary>
      /// <returns>The integer nearest <paramref name="d" />. If <paramref name="d" /> is halfway between two numbers, one of which is even and the other odd, then <paramref name="mode" /> determines which of the two is returned. </returns>
      /// <param name="d">A decimal number to be rounded. </param>
      /// <param name="mode">Specification for how to round <paramref name="d" /> if it is midway between two other numbers.</param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="mode" /> is not a valid value of <see cref="T:System.MidpointRounding" />.</exception>
      /// <exception cref="T:System.OverflowException">The result is outside the range of a <see cref="T:System.Decimal" />.</exception>
      decimal Round(decimal d, MidpointRounding mode);

      /// <summary>Rounds a double-precision floating-point value to the nearest integral value.</summary>
      /// <returns>The integer nearest <paramref name="a" />. If the fractional component of <paramref name="a" /> is halfway between two integers, one of which is even and the other odd, then the even number is returned. Note that this method returns a <see cref="T:System.Double" /> instead of an integral type.</returns>
      /// <param name="a">A double-precision floating-point number to be rounded. </param>
      double Round(double a);

      /// <summary>Rounds a double-precision floating-point value to a specified number of fractional digits.</summary>
      /// <returns>The number nearest to <paramref name="value" /> that contains a number of fractional digits equal to <paramref name="digits" />.</returns>
      /// <param name="value">A double-precision floating-point number to be rounded. </param>
      /// <param name="digits">The number of fractional digits in the return value. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="digits" /> is less than 0 or greater than 15. </exception>
      double Round(double value, int digits);

      /// <summary>Rounds a double-precision floating-point value to a specified number of fractional digits. A parameter specifies how to round the value if it is midway between two numbers.</summary>
      /// <returns>The number nearest to <paramref name="value" /> that has a number of fractional digits equal to <paramref name="digits" />. If <paramref name="value" /> has fewer fractional digits than <paramref name="digits" />, <paramref name="value" /> is returned unchanged.</returns>
      /// <param name="value">A double-precision floating-point number to be rounded. </param>
      /// <param name="digits">The number of fractional digits in the return value. </param>
      /// <param name="mode">Specification for how to round <paramref name="value" /> if it is midway between two other numbers.</param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="digits" /> is less than 0 or greater than 15. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="mode" /> is not a valid value of <see cref="T:System.MidpointRounding" />.</exception>
      double Round(double value, int digits, MidpointRounding mode);

      /// <summary>Rounds a double-precision floating-point value to the nearest integer. A parameter specifies how to round the value if it is midway between two numbers.</summary>
      /// <returns>The integer nearest <paramref name="value" />. If <paramref name="value" /> is halfway between two integers, one of which is even and the other odd, then <paramref name="mode" /> determines which of the two is returned.</returns>
      /// <param name="value">A double-precision floating-point number to be rounded. </param>
      /// <param name="mode">Specification for how to round <paramref name="value" /> if it is midway between two other numbers.</param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="mode" /> is not a valid value of <see cref="T:System.MidpointRounding" />.</exception>
      double Round(double value, MidpointRounding mode);

      /// <summary>Returns a value indicating the sign of a decimal number.</summary>
      /// <returns>A number that indicates the sign of <paramref name="value" />, as shown in the following table.Return value Meaning -1 <paramref name="value" /> is less than zero. 0 <paramref name="value" /> is equal to zero. 1 <paramref name="value" /> is greater than zero. </returns>
      /// <param name="value">A signed decimal number. </param>
      int Sign(decimal value);

      /// <summary>Returns a value indicating the sign of a double-precision floating-point number.</summary>
      /// <returns>A number that indicates the sign of <paramref name="value" />, as shown in the following table.Return value Meaning -1 <paramref name="value" /> is less than zero. 0 <paramref name="value" /> is equal to zero. 1 <paramref name="value" /> is greater than zero. </returns>
      /// <param name="value">A signed number. </param>
      /// <exception cref="T:System.ArithmeticException">
      /// <paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />. </exception>
      int Sign(double value);

      /// <summary>Returns a value indicating the sign of a 16-bit signed integer.</summary>
      /// <returns>A number that indicates the sign of <paramref name="value" />, as shown in the following table.Return value Meaning -1 <paramref name="value" /> is less than zero. 0 <paramref name="value" /> is equal to zero. 1 <paramref name="value" /> is greater than zero. </returns>
      /// <param name="value">A signed number. </param>
      int Sign(short value);

      /// <summary>Returns a value indicating the sign of a 32-bit signed integer.</summary>
      /// <returns>A number that indicates the sign of <paramref name="value" />, as shown in the following table.Return value Meaning -1 <paramref name="value" /> is less than zero. 0 <paramref name="value" /> is equal to zero. 1 <paramref name="value" /> is greater than zero. </returns>
      /// <param name="value">A signed number. </param>
      int Sign(int value);

      /// <summary>Returns a value indicating the sign of a 64-bit signed integer.</summary>
      /// <returns>A number that indicates the sign of <paramref name="value" />, as shown in the following table.Return value Meaning -1 <paramref name="value" /> is less than zero. 0 <paramref name="value" /> is equal to zero. 1 <paramref name="value" /> is greater than zero. </returns>
      /// <param name="value">A signed number. </param>
      int Sign(long value);

      /// <summary>Returns a value indicating the sign of an 8-bit signed integer.</summary>
      /// <returns>A number that indicates the sign of <paramref name="value" />, as shown in the following table.Return value Meaning -1 <paramref name="value" /> is less than zero. 0 <paramref name="value" /> is equal to zero. 1 <paramref name="value" /> is greater than zero. </returns>
      /// <param name="value">A signed number. </param>
      int Sign(sbyte value);

      /// <summary>Returns a value indicating the sign of a single-precision floating-point number.</summary>
      /// <returns>A number that indicates the sign of <paramref name="value" />, as shown in the following table.Return value Meaning -1 <paramref name="value" /> is less than zero. 0 <paramref name="value" /> is equal to zero. 1 <paramref name="value" /> is greater than zero. </returns>
      /// <param name="value">A signed number. </param>
      /// <exception cref="T:System.ArithmeticException">
      /// <paramref name="value" /> is equal to <see cref="F:System.Single.NaN" />. </exception>
      int Sign(float value);

      /// <summary>Returns the sine of the specified angle.</summary>
      /// <returns>The sine of <paramref name="a" />. If <paramref name="a" /> is equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" />, or <see cref="F:System.Double.PositiveInfinity" />, this method returns <see cref="F:System.Double.NaN" />.</returns>
      /// <param name="a">An angle, measured in radians. </param>
      double Sin(double a);

      /// <summary>Returns the hyperbolic sine of the specified angle.</summary>
      /// <returns>The hyperbolic sine of <paramref name="value" />. If <paramref name="value" /> is equal to <see cref="F:System.Double.NegativeInfinity" />, <see cref="F:System.Double.PositiveInfinity" />, or <see cref="F:System.Double.NaN" />, this method returns a <see cref="T:System.Double" /> equal to <paramref name="value" />.</returns>
      /// <param name="value">An angle, measured in radians. </param>
      double Sinh(double value);

      /// <summary>Returns the square root of a specified number.</summary>
      /// <returns>One of the values in the following table. <paramref name="d" /> parameter Return value Zero or positive The positive square root of <paramref name="d" />. Negative <see cref="F:System.Double.NaN" />Equals <see cref="F:System.Double.NaN" /><see cref="F:System.Double.NaN" />Equals <see cref="F:System.Double.PositiveInfinity" /><see cref="F:System.Double.PositiveInfinity" /></returns>
      /// <param name="d">The number whose square root is to be found. </param>
      double Sqrt(double d);

      /// <summary>Returns the tangent of the specified angle.</summary>
      /// <returns>The tangent of <paramref name="a" />. If <paramref name="a" /> is equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" />, or <see cref="F:System.Double.PositiveInfinity" />, this method returns <see cref="F:System.Double.NaN" />.</returns>
      /// <param name="a">An angle, measured in radians. </param>
      double Tan(double a);

      /// <summary>Returns the hyperbolic tangent of the specified angle.</summary>
      /// <returns>The hyperbolic tangent of <paramref name="value" />. If <paramref name="value" /> is equal to <see cref="F:System.Double.NegativeInfinity" />, this method returns -1. If value is equal to <see cref="F:System.Double.PositiveInfinity" />, this method returns 1. If <paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />, this method returns <see cref="F:System.Double.NaN" />.</returns>
      /// <param name="value">An angle, measured in radians. </param>
      double Tanh(double value);

      /// <summary>Calculates the integral part of a specified decimal number. </summary>
      /// <returns>The integral part of <paramref name="d" />; that is, the number that remains after any fractional digits have been discarded.</returns>
      /// <param name="d">A number to truncate.</param>
      decimal Truncate(decimal d);

      /// <summary>Calculates the integral part of a specified double-precision floating-point number. </summary>
      /// <returns>The integral part of <paramref name="d" />; that is, the number that remains after any fractional digits have been discarded, or one of the values listed in the following table. <paramref name="d" />Return value<see cref="F:System.Double.NaN" /><see cref="F:System.Double.NaN" /><see cref="F:System.Double.NegativeInfinity" /><see cref="F:System.Double.NegativeInfinity" /><see cref="F:System.Double.PositiveInfinity" /><see cref="F:System.Double.PositiveInfinity" /></returns>
      /// <param name="d">A number to truncate.</param>
      double Truncate(double d);

      /// <summary>Produces the full product of two 32-bit numbers.</summary>
      /// <returns>The number containing the product of the specified numbers.</returns>
      /// <param name="a">The first number to multiply. </param>
      /// <param name="b">The second number to multiply. </param>
      /// <filterpriority>1</filterpriority>
      long BigMul(int a, int b);

#if NET5_0
      /// <summary>
      /// Produces the full product of two 64-bit numbers.
      /// </summary>
      /// <param name="a">The first number to multiply.</param>
      /// <param name="b">The second number to multiply.</param>
      /// <param name="low">The low 64-bit of the product of the specified numbers.</param>
      /// <returns>The high 64-bit of the product of the specified numbers.</returns>
      long BigMul(long a, long b, out long low);

      /// <summary>
      /// Produces the full product of two unsigned 64-bit numbers.
      /// </summary>
      /// <param name="a">The first number to multiply.</param>
      /// <param name="b">The second number to multiply.</param>
      /// <param name="low">The low 64-bit of the product of the specified numbers.</param>
      /// <returns>The high 64-bit of the product of the specified numbers.</returns>
      ulong BigMul(ulong a, ulong b, out ulong low);
#endif

      /// <summary>Calculates the quotient of two 32-bit signed integers and also returns the remainder in an output parameter.</summary>
      /// <returns>The quotient of the specified numbers.</returns>
      /// <param name="a">The dividend. </param>
      /// <param name="b">The divisor. </param>
      /// <param name="result">The remainder. </param>
      /// <exception cref="T:System.DivideByZeroException">
      /// <paramref name="b" /> is zero.</exception>
      /// <filterpriority>1</filterpriority>
      int DivRem(int a, int b, out int result);

      /// <summary>Calculates the quotient of two 64-bit signed integers and also returns the remainder in an output parameter.</summary>
      /// <returns>The quotient of the specified numbers.</returns>
      /// <param name="a">The dividend. </param>
      /// <param name="b">The divisor. </param>
      /// <param name="result">The remainder. </param>
      /// <exception cref="T:System.DivideByZeroException">
      /// <paramref name="b" /> is zero.</exception>
      /// <filterpriority>1</filterpriority>
      long DivRem(long a, long b, out long result);

#if NETCOREAPP || NET5_0
      /// <summary>
      /// Returns (x * y) + z, rounded as one ternary operation.
      /// </summary>
      /// <param name="x">The number to be multiplied with y.</param>
      /// <param name="y">The number to be multiplied with x.</param>
      /// <param name="z">The number to be added to the result of x multiplied by y.</param>
      /// <returns>(x * y) + z, rounded as one ternary operation.</returns>
      double FusedMultiplyAdd(double x, double y, double z);

      /// <summary>
      /// Returns the base 2 integer logarithm of a specified number.
      /// </summary>
      /// <param name="x">The number whose logarithm is to be found.</param>
      /// <returns>
      /// One of the values in the following table.
      /// - Default:	The base 2 integer log of x; that is, (int)log2(x).
      /// - Zero:	MinValue
      /// - Equal to NaN or PositiveInfinity or NegativeInfinity:	MaxValue
      /// </returns>
      int ILogB(double x);

      /// <summary>
      /// Returns the base 2 logarithm of a specified number.
      /// </summary>
      /// <param name="x">A number whose logarithm is to be found.</param>
      /// <returns>One of the values in the following table.</returns>
      double Log2(double x);

      /// <summary>
      /// Returns x * 2^n computed efficiently.
      /// </summary>
      /// <param name="x">A double-precision floating-point number that specifies the base value.</param>
      /// <param name="n">A 32-bit integer that specifies the power.</param>
      /// <returns>x * 2^n computed efficiently.</returns>
      double ScaleB(double x, int n);

      /// <summary>
      /// Returns the next smallest value that compares less than x.
      /// </summary>
      /// <param name="x">The value to decrement.</param>
      /// <returns>
      /// The next smallest value that compares less than x.
      /// -or- NegativeInfinity if x equals NegativeInfinity.
      /// -or- NaN if x equals NaN.
      /// </returns>
      double BitDecrement(double x);

      /// <summary>
      /// Returns the next largest value that compares greater than x.
      /// </summary>
      /// <param name="x">The value to increment.</param>
      /// <returns>
      /// The next largest value that compares greater than x.
      /// -or- PositiveInfinity if x equals PositiveInfinity.
      /// -or- NaN if x equals NaN.
      /// </returns>
      double BitIncrement(double x);

      /// <summary>
      /// Returns a value with the magnitude of x and the sign of y.
      /// </summary>
      /// <param name="x">A number whose magnitude is used in the result.</param>
      /// <param name="y">A number whose sign is the used in the result.</param>
      /// <returns>A value with the magnitude of x and the sign of y.</returns>
      double CopySign(double x, double y);

      /// <summary>
      /// Returns the larger magnitude of two double-precision floating-point numbers.
      /// </summary>
      /// <param name="x">The first of two double-precision floating-point numbers to compare.</param>
      /// <param name="y">The second of two double-precision floating-point numbers to compare.</param>
      /// <returns>Parameter x or y, whichever has the larger magnitude. If x, or y, or both x and y are equal to NaN, NaN is returned.</returns>
      double MaxMagnitude(double x, double y);

      /// <summary>
      /// Returns the smaller magnitude of two double-precision floating-point numbers.
      /// </summary>
      /// <param name="x">The first of two double-precision floating-point numbers to compare.</param>
      /// <param name="y">The second of two double-precision floating-point numbers to compare.</param>
      /// <returns>Parameter x or y, whichever has the smaller magnitude. If x, or y, or both x and y are equal to NaN, NaN is returned.</returns>
      double MinMagnitude(double x, double y);
#endif
   }
}
