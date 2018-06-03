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

#if NETCOREAPP2_1
		/// <inheritdoc />
		public int SingleToInt32Bits(float value)
		{
			return BitConverter.SingleToInt32Bits(value);
		}

		/// <inheritdoc />
		public float Int32BitsToSingle(int value)
		{
			return BitConverter.Int32BitsToSingle(value);
		}

		/// <inheritdoc />
		public bool TryWriteBytes(Span<byte> destination, bool value)
		{
			return BitConverter.TryWriteBytes(destination, value);
		}

		/// <inheritdoc />
		public bool TryWriteBytes(Span<byte> destination, char value)
		{
			return BitConverter.TryWriteBytes(destination, value);
		}

		/// <inheritdoc />
		public bool TryWriteBytes(Span<byte> destination, double value)
		{
			return BitConverter.TryWriteBytes(destination, value);
		}

		/// <inheritdoc />
		public bool TryWriteBytes(Span<byte> destination, float value)
		{
			return BitConverter.TryWriteBytes(destination, value);
		}

		/// <inheritdoc />
		public bool TryWriteBytes(Span<byte> destination, int value)
		{
			return BitConverter.TryWriteBytes(destination, value);
		}

		/// <inheritdoc />
		public bool TryWriteBytes(Span<byte> destination, long value)
		{
			return BitConverter.TryWriteBytes(destination, value);
		}

		/// <inheritdoc />
		public bool TryWriteBytes(Span<byte> destination, short value)
		{
			return BitConverter.TryWriteBytes(destination, value);
		}

		/// <inheritdoc />
		public bool TryWriteBytes(Span<byte> destination, ushort value)
		{
			return BitConverter.TryWriteBytes(destination, value);
		}

		/// <inheritdoc />
		public bool TryWriteBytes(Span<byte> destination, uint value)
		{
			return BitConverter.TryWriteBytes(destination, value);
		}

		/// <inheritdoc />
		public bool TryWriteBytes(Span<byte> destination, ulong value)
		{
			return BitConverter.TryWriteBytes(destination, value);
		}

		/// <inheritdoc />
		public char ToChar(ReadOnlySpan<byte> value)
		{
			return BitConverter.ToChar(value);
		}

		/// <inheritdoc />
		public short ToInt16(ReadOnlySpan<byte> value)
		{
			return BitConverter.ToInt16(value);
		}

		/// <inheritdoc />
		public bool ToBoolean(ReadOnlySpan<byte> value)
		{
			return BitConverter.ToBoolean(value);
		}

		/// <inheritdoc />
		public double ToDouble(ReadOnlySpan<byte> value)
		{
			return BitConverter.ToDouble(value);
		}

		/// <inheritdoc />
		public int ToInt32(ReadOnlySpan<byte>  value)
		{
			return BitConverter.ToInt32(value);
		}

		/// <inheritdoc />
		public long ToInt64(ReadOnlySpan<byte> value)
		{
			return BitConverter.ToInt64(value);
		}

		/// <inheritdoc />
		public float ToSingle(ReadOnlySpan<byte> value)
		{
			return BitConverter.ToSingle(value);
		}

		/// <inheritdoc />
		public ushort ToUInt16(ReadOnlySpan<byte> value)
		{
			return BitConverter.ToUInt16(value);
		}

		/// <inheritdoc />
		public uint ToUInt32(ReadOnlySpan<byte> value)
		{
			return BitConverter.ToUInt32(value);
		}

		/// <inheritdoc />
		public ulong ToUInt64(ReadOnlySpan<byte> value)
		{
			return BitConverter.ToUInt64(value);
		}
#endif

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
