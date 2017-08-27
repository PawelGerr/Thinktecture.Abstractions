using System;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Adapters
{
	/// <summary>
	/// Adapter for <see cref="BitConverter"/>.
	/// </summary>
	public class BitConverterAdapter : IBitConverter
	{
		/// <inheritdoc />
		public bool IsLittleEndian => BitConverter.IsLittleEndian;

		/// <inheritdoc />
		public long DoubleToInt64Bits(double value)
		{
			return BitConverter.DoubleToInt64Bits(value);
		}

		/// <inheritdoc />
		public byte[] GetBytes(bool value)
		{
			return BitConverter.GetBytes(value);
		}

		/// <inheritdoc />
		public byte[] GetBytes(char value)
		{
			return BitConverter.GetBytes(value);
		}

		/// <inheritdoc />
		public byte[] GetBytes(double value)
		{
			return BitConverter.GetBytes(value);
		}

		/// <inheritdoc />
		public byte[] GetBytes(short value)
		{
			return BitConverter.GetBytes(value);
		}

		/// <inheritdoc />
		public byte[] GetBytes(int value)
		{
			return BitConverter.GetBytes(value);
		}

		/// <inheritdoc />
		public byte[] GetBytes(long value)
		{
			return BitConverter.GetBytes(value);
		}

		/// <inheritdoc />
		public byte[] GetBytes(float value)
		{
			return BitConverter.GetBytes(value);
		}

		/// <inheritdoc />
		public byte[] GetBytes(ushort value)
		{
			return BitConverter.GetBytes(value);
		}

		/// <inheritdoc />
		public byte[] GetBytes(uint value)
		{
			return BitConverter.GetBytes(value);
		}

		/// <inheritdoc />
		public byte[] GetBytes(ulong value)
		{
			return BitConverter.GetBytes(value);
		}

		/// <inheritdoc />
		public double Int64BitsToDouble(long value)
		{
			return BitConverter.Int64BitsToDouble(value);
		}

		/// <inheritdoc />
		public bool ToBoolean(byte[] value, int startIndex)
		{
			return BitConverter.ToBoolean(value, startIndex);
		}

		/// <inheritdoc />
		public char ToChar(byte[] value, int startIndex)
		{
			return BitConverter.ToChar(value, startIndex);
		}

		/// <inheritdoc />
		public double ToDouble(byte[] value, int startIndex)
		{
			return BitConverter.ToDouble(value, startIndex);
		}

		/// <inheritdoc />
		public short ToInt16(byte[] value, int startIndex)
		{
			return BitConverter.ToInt16(value, startIndex);
		}

		/// <inheritdoc />
		public int ToInt32(byte[] value, int startIndex)
		{
			return BitConverter.ToInt32(value, startIndex);
		}

		/// <inheritdoc />
		public long ToInt64(byte[] value, int startIndex)
		{
			return BitConverter.ToInt64(value, startIndex);
		}

		/// <inheritdoc />
		public float ToSingle(byte[] value, int startIndex)
		{
			return BitConverter.ToSingle(value, startIndex);
		}

		/// <inheritdoc />
		public string ToString(byte[] value)
		{
			return BitConverter.ToString(value);
		}

		/// <inheritdoc />
		public string ToString(byte[] value, int startIndex)
		{
			return BitConverter.ToString(value, startIndex);
		}

		/// <inheritdoc />
		public string ToString(byte[] value, int startIndex, int length)
		{
			return BitConverter.ToString(value, startIndex, length);
		}

		/// <inheritdoc />
		public ushort ToUInt16(byte[] value, int startIndex)
		{
			return BitConverter.ToUInt16(value, startIndex);
		}

		/// <inheritdoc />
		public uint ToUInt32(byte[] value, int startIndex)
		{
			return BitConverter.ToUInt32(value, startIndex);
		}

		/// <inheritdoc />
		public ulong ToUInt64(byte[] value, int startIndex)
		{
			return BitConverter.ToUInt64(value, startIndex);
		}
	}
}
