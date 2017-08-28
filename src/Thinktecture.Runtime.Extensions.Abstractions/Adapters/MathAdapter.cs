using System;

namespace Thinktecture.Adapters
{
	/// <summary>
	/// Adapter for <see cref="Math"/>.
	/// </summary>
	public class MathAdapter : IMath
	{
		/// <inheritdoc />
		public double PI => Math.PI;

		/// <inheritdoc />
		public double E => Math.E;

		/// <inheritdoc />
		public decimal Abs(decimal value)
		{
			return Math.Abs(value);
		}

		/// <inheritdoc />
		public double Abs(double value)
		{
			return Math.Abs(value);
		}

		/// <inheritdoc />
		public short Abs(short value)
		{
			return Math.Abs(value);
		}

		/// <inheritdoc />
		public int Abs(int value)
		{
			return Math.Abs(value);
		}

		/// <inheritdoc />
		public long Abs(long value)
		{
			return Math.Abs(value);
		}

		/// <inheritdoc />
		public sbyte Abs(sbyte value)
		{
			return Math.Abs(value);
		}

		/// <inheritdoc />
		public float Abs(float value)
		{
			return Math.Abs(value);
		}

		/// <inheritdoc />
		public double Acos(double d)
		{
			return Math.Acos(d);
		}

		/// <inheritdoc />
		public double Asin(double d)
		{
			return Math.Asin(d);
		}

		/// <inheritdoc />
		public double Atan(double d)
		{
			return Math.Atan(d);
		}

		/// <inheritdoc />
		public double Atan2(double y, double x)
		{
			return Math.Atan2(y, x);
		}

		/// <inheritdoc />
		public decimal Ceiling(decimal d)
		{
			return Math.Ceiling(d);
		}

		/// <inheritdoc />
		public double Ceiling(double a)
		{
			return Math.Ceiling(a);
		}

		/// <inheritdoc />
		public double Cos(double d)
		{
			return Math.Cos(d);
		}

		/// <inheritdoc />
		public double Cosh(double value)
		{
			return Math.Cosh(value);
		}

		/// <inheritdoc />
		public double Exp(double d)
		{
			return Math.Exp(d);
		}

		/// <inheritdoc />
		public decimal Floor(decimal d)
		{
			return Math.Floor(d);
		}

		/// <inheritdoc />
		public double Floor(double d)
		{
			return Math.Floor(d);
		}

		/// <inheritdoc />
		public double IEEERemainder(double x, double y)
		{
			return Math.IEEERemainder(x, y);
		}

		/// <inheritdoc />
		public double Log(double d)
		{
			return Math.Log(d);
		}

		/// <inheritdoc />
		public double Log(double a, double newBase)
		{
			return Math.Log(a, newBase);
		}

		/// <inheritdoc />
		public double Log10(double d)
		{
			return Math.Log10(d);
		}

		/// <inheritdoc />
		public byte Max(byte val1, byte val2)
		{
			return Math.Max(val1, val2);
		}

		/// <inheritdoc />
		public decimal Max(decimal val1, decimal val2)
		{
			return Math.Max(val1, val2);
		}

		/// <inheritdoc />
		public double Max(double val1, double val2)
		{
			return Math.Max(val1, val2);
		}

		/// <inheritdoc />
		public short Max(short val1, short val2)
		{
			return Math.Max(val1, val2);
		}

		/// <inheritdoc />
		public int Max(int val1, int val2)
		{
			return Math.Max(val1, val2);
		}

		/// <inheritdoc />
		public long Max(long val1, long val2)
		{
			return Math.Max(val1, val2);
		}

		/// <inheritdoc />
		public sbyte Max(sbyte val1, sbyte val2)
		{
			return Math.Max(val1, val2);
		}

		/// <inheritdoc />
		public float Max(float val1, float val2)
		{
			return Math.Max(val1, val2);
		}

		/// <inheritdoc />
		public ushort Max(ushort val1, ushort val2)
		{
			return Math.Max(val1, val2);
		}

		/// <inheritdoc />
		public uint Max(uint val1, uint val2)
		{
			return Math.Max(val1, val2);
		}

		/// <inheritdoc />
		public ulong Max(ulong val1, ulong val2)
		{
			return Math.Max(val1, val2);
		}

		/// <inheritdoc />
		public byte Min(byte val1, byte val2)
		{
			return Math.Min(val1, val2);
		}

		/// <inheritdoc />
		public decimal Min(decimal val1, decimal val2)
		{
			return Math.Min(val1, val2);
		}

		/// <inheritdoc />
		public double Min(double val1, double val2)
		{
			return Math.Min(val1, val2);
		}

		/// <inheritdoc />
		public short Min(short val1, short val2)
		{
			return Math.Min(val1, val2);
		}

		/// <inheritdoc />
		public int Min(int val1, int val2)
		{
			return Math.Min(val1, val2);
		}

		/// <inheritdoc />
		public long Min(long val1, long val2)
		{
			return Math.Min(val1, val2);
		}

		/// <inheritdoc />
		public sbyte Min(sbyte val1, sbyte val2)
		{
			return Math.Min(val1, val2);
		}

		/// <inheritdoc />
		public float Min(float val1, float val2)
		{
			return Math.Min(val1, val2);
		}

		/// <inheritdoc />
		public ushort Min(ushort val1, ushort val2)
		{
			return Math.Min(val1, val2);
		}

		/// <inheritdoc />
		public uint Min(uint val1, uint val2)
		{
			return Math.Min(val1, val2);
		}

		/// <inheritdoc />
		public ulong Min(ulong val1, ulong val2)
		{
			return Math.Min(val1, val2);
		}

		/// <inheritdoc />
		public double Pow(double x, double y)
		{
			return Math.Pow(x, y);
		}

		/// <inheritdoc />
		public decimal Round(decimal d)
		{
			return Math.Round(d);
		}

		/// <inheritdoc />
		public decimal Round(decimal d, int decimals)
		{
			return Math.Round(d, decimals);
		}

		/// <inheritdoc />
		public decimal Round(decimal d, int decimals, MidpointRounding mode)
		{
			return Math.Round(d, decimals, mode);
		}

		/// <inheritdoc />
		public decimal Round(decimal d, MidpointRounding mode)
		{
			return Math.Round(d, mode);
		}

		/// <inheritdoc />
		public double Round(double a)
		{
			return Math.Round(a);
		}

		/// <inheritdoc />
		public double Round(double value, int digits)
		{
			return Math.Round(value, digits);
		}

		/// <inheritdoc />
		public double Round(double value, int digits, MidpointRounding mode)
		{
			return Math.Round(value, digits, mode);
		}

		/// <inheritdoc />
		public double Round(double value, MidpointRounding mode)
		{
			return Math.Round(value, mode);
		}

		/// <inheritdoc />
		public int Sign(decimal value)
		{
			return Math.Sign(value);
		}

		/// <inheritdoc />
		public int Sign(double value)
		{
			return Math.Sign(value);
		}

		/// <inheritdoc />
		public int Sign(short value)
		{
			return Math.Sign(value);
		}

		/// <inheritdoc />
		public int Sign(int value)
		{
			return Math.Sign(value);
		}

		/// <inheritdoc />
		public int Sign(long value)
		{
			return Math.Sign(value);
		}

		/// <inheritdoc />
		public int Sign(sbyte value)
		{
			return Math.Sign(value);
		}

		/// <inheritdoc />
		public int Sign(float value)
		{
			return Math.Sign(value);
		}

		/// <inheritdoc />
		public double Sin(double a)
		{
			return Math.Sin(a);
		}

		/// <inheritdoc />
		public double Sinh(double value)
		{
			return Math.Sinh(value);
		}

		/// <inheritdoc />
		public double Sqrt(double d)
		{
			return Math.Sqrt(d);
		}

		/// <inheritdoc />
		public double Tan(double a)
		{
			return Math.Tan(a);
		}

		/// <inheritdoc />
		public double Tanh(double value)
		{
			return Math.Tanh(value);
		}

		/// <inheritdoc />
		public decimal Truncate(decimal d)
		{
			return Math.Truncate(d);
		}

		/// <inheritdoc />
		public double Truncate(double d)
		{
			return Math.Truncate(d);
		}
	}
}
