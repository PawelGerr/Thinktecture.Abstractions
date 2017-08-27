using System;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Adapters
{
	/// <summary>
	/// Adapter for <see cref="Convert"/>.
	/// </summary>
	public class ConvertAdapter : IConvert
	{
		/// <inheritdoc />
		public object ChangeType(object value, Type conversionType)
		{
			return Convert.ChangeType(value, conversionType);
		}

		/// <inheritdoc />
		public object ChangeType(object value, Type conversionType, IFormatProvider provider)
		{
			return Convert.ChangeType(value, conversionType, provider);
		}

		/// <inheritdoc />
		public byte[] FromBase64CharArray(char[] inArray, int offset, int length)
		{
			return Convert.FromBase64CharArray(inArray, offset, length);
		}

		/// <inheritdoc />
		public byte[] FromBase64String(string s)
		{
			return Convert.FromBase64String(s);
		}

		/// <inheritdoc />
		public int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut)
		{
			return Convert.ToBase64CharArray(inArray, offsetIn, length, outArray, offsetOut);
		}

		/// <inheritdoc />
		public string ToBase64String(byte[] inArray)
		{
			return Convert.ToBase64String(inArray);
		}

		/// <inheritdoc />
		public string ToBase64String(byte[] inArray, int offset, int length)
		{
			return Convert.ToBase64String(inArray, offset, length);
		}

		/// <inheritdoc />
		public bool ToBoolean(bool value)
		{
			return Convert.ToBoolean(value);
		}

		/// <inheritdoc />
		public bool ToBoolean(byte value)
		{
			return Convert.ToBoolean(value);
		}

		/// <inheritdoc />
		public bool ToBoolean(decimal value)
		{
			return Convert.ToBoolean(value);
		}

		/// <inheritdoc />
		public bool ToBoolean(double value)
		{
			return Convert.ToBoolean(value);
		}

		/// <inheritdoc />
		public bool ToBoolean(short value)
		{
			return Convert.ToBoolean(value);
		}

		/// <inheritdoc />
		public bool ToBoolean(int value)
		{
			return Convert.ToBoolean(value);
		}

		/// <inheritdoc />
		public bool ToBoolean(long value)
		{
			return Convert.ToBoolean(value);
		}

		/// <inheritdoc />
		public bool ToBoolean(object value)
		{
			return Convert.ToBoolean(value);
		}

		/// <inheritdoc />
		public bool ToBoolean(object value, IFormatProvider provider)
		{
			return Convert.ToBoolean(value, provider);
		}

		/// <inheritdoc />
		public bool ToBoolean(sbyte value)
		{
			return Convert.ToBoolean(value);
		}

		/// <inheritdoc />
		public bool ToBoolean(float value)
		{
			return Convert.ToBoolean(value);
		}

		/// <inheritdoc />
		public bool ToBoolean(string value)
		{
			return Convert.ToBoolean(value);
		}

		/// <inheritdoc />
		public bool ToBoolean(string value, IFormatProvider provider)
		{
			return Convert.ToBoolean(value, provider);
		}

		/// <inheritdoc />
		public bool ToBoolean(ushort value)
		{
			return Convert.ToBoolean(value);
		}

		/// <inheritdoc />
		public bool ToBoolean(uint value)
		{
			return Convert.ToBoolean(value);
		}

		/// <inheritdoc />
		public bool ToBoolean(ulong value)
		{
			return Convert.ToBoolean(value);
		}

		/// <inheritdoc />
		public byte ToByte(bool value)
		{
			return Convert.ToByte(value);
		}

		/// <inheritdoc />
		public byte ToByte(byte value)
		{
			return Convert.ToByte(value);
		}

		/// <inheritdoc />
		public byte ToByte(char value)
		{
			return Convert.ToByte(value);
		}

		/// <inheritdoc />
		public byte ToByte(decimal value)
		{
			return Convert.ToByte(value);
		}

		/// <inheritdoc />
		public byte ToByte(double value)
		{
			return Convert.ToByte(value);
		}

		/// <inheritdoc />
		public byte ToByte(short value)
		{
			return Convert.ToByte(value);
		}

		/// <inheritdoc />
		public byte ToByte(int value)
		{
			return Convert.ToByte(value);
		}

		/// <inheritdoc />
		public byte ToByte(long value)
		{
			return Convert.ToByte(value);
		}

		/// <inheritdoc />
		public byte ToByte(object value)
		{
			return Convert.ToByte(value);
		}

		/// <inheritdoc />
		public byte ToByte(object value, IFormatProvider provider)
		{
			return Convert.ToByte(value, provider);
		}

		/// <inheritdoc />
		public byte ToByte(sbyte value)
		{
			return Convert.ToByte(value);
		}

		/// <inheritdoc />
		public byte ToByte(float value)
		{
			return Convert.ToByte(value);
		}

		/// <inheritdoc />
		public byte ToByte(string value)
		{
			return Convert.ToByte(value);
		}

		/// <inheritdoc />
		public byte ToByte(string value, IFormatProvider provider)
		{
			return Convert.ToByte(value, provider);
		}

		/// <inheritdoc />
		public byte ToByte(string value, int fromBase)
		{
			return Convert.ToByte(value);
		}

		/// <inheritdoc />
		public byte ToByte(ushort value)
		{
			return Convert.ToByte(value);
		}

		/// <inheritdoc />
		public byte ToByte(uint value)
		{
			return Convert.ToByte(value);
		}

		/// <inheritdoc />
		public byte ToByte(ulong value)
		{
			return Convert.ToByte(value);
		}

		/// <inheritdoc />
		public char ToChar(byte value)
		{
			return Convert.ToChar(value);
		}

		/// <inheritdoc />
		public char ToChar(short value)
		{
			return Convert.ToChar(value);
		}

		/// <inheritdoc />
		public char ToChar(int value)
		{
			return Convert.ToChar(value);
		}

		/// <inheritdoc />
		public char ToChar(long value)
		{
			return Convert.ToChar(value);
		}

		/// <inheritdoc />
		public char ToChar(object value)
		{
			return Convert.ToChar(value);
		}

		/// <inheritdoc />
		public char ToChar(object value, IFormatProvider provider)
		{
			return Convert.ToChar(value, provider);
		}

		/// <inheritdoc />
		public char ToChar(sbyte value)
		{
			return Convert.ToChar(value);
		}

		/// <inheritdoc />
		public char ToChar(string value)
		{
			return Convert.ToChar(value);
		}

		/// <inheritdoc />
		public char ToChar(string value, IFormatProvider provider)
		{
			return Convert.ToChar(value, provider);
		}

		/// <inheritdoc />
		public char ToChar(ushort value)
		{
			return Convert.ToChar(value);
		}

		/// <inheritdoc />
		public char ToChar(uint value)
		{
			return Convert.ToChar(value);
		}

		/// <inheritdoc />
		public char ToChar(ulong value)
		{
			return Convert.ToChar(value);
		}

		/// <inheritdoc />
		public DateTime ToDateTime(object value)
		{
			return Convert.ToDateTime(value);
		}

		/// <inheritdoc />
		public DateTime ToDateTime(object value, IFormatProvider provider)
		{
			return Convert.ToDateTime(value, provider);
		}

		/// <inheritdoc />
		public DateTime ToDateTime(string value)
		{
			return Convert.ToDateTime(value);
		}

		/// <inheritdoc />
		public DateTime ToDateTime(string value, IFormatProvider provider)
		{
			return Convert.ToDateTime(value, provider);
		}

		/// <inheritdoc />
		public decimal ToDecimal(bool value)
		{
			return Convert.ToDecimal(value);
		}

		/// <inheritdoc />
		public decimal ToDecimal(byte value)
		{
			return Convert.ToDecimal(value);
		}

		/// <inheritdoc />
		public decimal ToDecimal(decimal value)
		{
			return Convert.ToDecimal(value);
		}

		/// <inheritdoc />
		public decimal ToDecimal(double value)
		{
			return Convert.ToDecimal(value);
		}

		/// <inheritdoc />
		public decimal ToDecimal(short value)
		{
			return Convert.ToDecimal(value);
		}

		/// <inheritdoc />
		public decimal ToDecimal(int value)
		{
			return Convert.ToDecimal(value);
		}

		/// <inheritdoc />
		public decimal ToDecimal(long value)
		{
			return Convert.ToDecimal(value);
		}

		/// <inheritdoc />
		public decimal ToDecimal(object value)
		{
			return Convert.ToDecimal(value);
		}

		/// <inheritdoc />
		public decimal ToDecimal(object value, IFormatProvider provider)
		{
			return Convert.ToDecimal(value, provider);
		}

		/// <inheritdoc />
		public decimal ToDecimal(sbyte value)
		{
			return Convert.ToDecimal(value);
		}

		/// <inheritdoc />
		public decimal ToDecimal(float value)
		{
			return Convert.ToDecimal(value);
		}

		/// <inheritdoc />
		public decimal ToDecimal(string value)
		{
			return Convert.ToDecimal(value);
		}

		/// <inheritdoc />
		public decimal ToDecimal(string value, IFormatProvider provider)
		{
			return Convert.ToDecimal(value, provider);
		}

		/// <inheritdoc />
		public decimal ToDecimal(ushort value)
		{
			return Convert.ToDecimal(value);
		}

		/// <inheritdoc />
		public decimal ToDecimal(uint value)
		{
			return Convert.ToDecimal(value);
		}

		/// <inheritdoc />
		public decimal ToDecimal(ulong value)
		{
			return Convert.ToDecimal(value);
		}

		/// <inheritdoc />
		public double ToDouble(bool value)
		{
			return Convert.ToDouble(value);
		}

		/// <inheritdoc />
		public double ToDouble(byte value)
		{
			return Convert.ToDouble(value);
		}

		/// <inheritdoc />
		public double ToDouble(decimal value)
		{
			return Convert.ToDouble(value);
		}

		/// <inheritdoc />
		public double ToDouble(double value)
		{
			return Convert.ToDouble(value);
		}

		/// <inheritdoc />
		public double ToDouble(short value)
		{
			return Convert.ToDouble(value);
		}

		/// <inheritdoc />
		public double ToDouble(int value)
		{
			return Convert.ToDouble(value);
		}

		/// <inheritdoc />
		public double ToDouble(long value)
		{
			return Convert.ToDouble(value);
		}

		/// <inheritdoc />
		public double ToDouble(object value)
		{
			return Convert.ToDouble(value);
		}

		/// <inheritdoc />
		public double ToDouble(object value, IFormatProvider provider)
		{
			return Convert.ToDouble(value, provider);
		}

		/// <inheritdoc />
		public double ToDouble(sbyte value)
		{
			return Convert.ToDouble(value);
		}

		/// <inheritdoc />
		public double ToDouble(float value)
		{
			return Convert.ToDouble(value);
		}

		/// <inheritdoc />
		public double ToDouble(string value)
		{
			return Convert.ToDouble(value);
		}

		/// <inheritdoc />
		public double ToDouble(string value, IFormatProvider provider)
		{
			return Convert.ToDouble(value, provider);
		}

		/// <inheritdoc />
		public double ToDouble(ushort value)
		{
			return Convert.ToDouble(value);
		}

		/// <inheritdoc />
		public double ToDouble(uint value)
		{
			return Convert.ToDouble(value);
		}

		/// <inheritdoc />
		public double ToDouble(ulong value)
		{
			return Convert.ToDouble(value);
		}

		/// <inheritdoc />
		public short ToInt16(bool value)
		{
			return Convert.ToInt16(value);
		}

		/// <inheritdoc />
		public short ToInt16(byte value)
		{
			return Convert.ToInt16(value);
		}

		/// <inheritdoc />
		public short ToInt16(char value)
		{
			return Convert.ToInt16(value);
		}

		/// <inheritdoc />
		public short ToInt16(decimal value)
		{
			return Convert.ToInt16(value);
		}

		/// <inheritdoc />
		public short ToInt16(double value)
		{
			return Convert.ToInt16(value);
		}

		/// <inheritdoc />
		public short ToInt16(short value)
		{
			return Convert.ToInt16(value);
		}

		/// <inheritdoc />
		public short ToInt16(int value)
		{
			return Convert.ToInt16(value);
		}

		/// <inheritdoc />
		public short ToInt16(long value)
		{
			return Convert.ToInt16(value);
		}

		/// <inheritdoc />
		public short ToInt16(object value)
		{
			return Convert.ToInt16(value);
		}

		/// <inheritdoc />
		public short ToInt16(object value, IFormatProvider provider)
		{
			return Convert.ToInt16(value, provider);
		}

		/// <inheritdoc />
		public short ToInt16(sbyte value)
		{
			return Convert.ToInt16(value);
		}

		/// <inheritdoc />
		public short ToInt16(float value)
		{
			return Convert.ToInt16(value);
		}

		/// <inheritdoc />
		public short ToInt16(string value)
		{
			return Convert.ToInt16(value);
		}

		/// <inheritdoc />
		public short ToInt16(string value, IFormatProvider provider)
		{
			return Convert.ToInt16(value, provider);
		}

		/// <inheritdoc />
		public short ToInt16(string value, int fromBase)
		{
			return Convert.ToInt16(value, fromBase);
		}

		/// <inheritdoc />
		public short ToInt16(ushort value)
		{
			return Convert.ToInt16(value);
		}

		/// <inheritdoc />
		public short ToInt16(uint value)
		{
			return Convert.ToInt16(value);
		}

		/// <inheritdoc />
		public short ToInt16(ulong value)
		{
			return Convert.ToInt16(value);
		}

		/// <inheritdoc />
		public int ToInt32(bool value)
		{
			return Convert.ToInt32(value);
		}

		/// <inheritdoc />
		public int ToInt32(byte value)
		{
			return Convert.ToInt32(value);
		}

		/// <inheritdoc />
		public int ToInt32(char value)
		{
			return Convert.ToInt32(value);
		}

		/// <inheritdoc />
		public int ToInt32(decimal value)
		{
			return Convert.ToInt32(value);
		}

		/// <inheritdoc />
		public int ToInt32(double value)
		{
			return Convert.ToInt32(value);
		}

		/// <inheritdoc />
		public int ToInt32(short value)
		{
			return Convert.ToInt32(value);
		}

		/// <inheritdoc />
		public int ToInt32(int value)
		{
			return Convert.ToInt32(value);
		}

		/// <inheritdoc />
		public int ToInt32(long value)
		{
			return Convert.ToInt32(value);
		}

		/// <inheritdoc />
		public int ToInt32(object value)
		{
			return Convert.ToInt32(value);
		}

		/// <inheritdoc />
		public int ToInt32(object value, IFormatProvider provider)
		{
			return Convert.ToInt32(value, provider);
		}

		/// <inheritdoc />
		public int ToInt32(sbyte value)
		{
			return Convert.ToInt32(value);
		}

		/// <inheritdoc />
		public int ToInt32(float value)
		{
			return Convert.ToInt32(value);
		}

		/// <inheritdoc />
		public int ToInt32(string value)
		{
			return Convert.ToInt32(value);
		}

		/// <inheritdoc />
		public int ToInt32(string value, IFormatProvider provider)
		{
			return Convert.ToInt32(value, provider);
		}

		/// <inheritdoc />
		public int ToInt32(string value, int fromBase)
		{
			return Convert.ToInt32(value, fromBase);
		}

		/// <inheritdoc />
		public int ToInt32(ushort value)
		{
			return Convert.ToInt32(value);
		}

		/// <inheritdoc />
		public int ToInt32(uint value)
		{
			return Convert.ToInt32(value);
		}

		/// <inheritdoc />
		public int ToInt32(ulong value)
		{
			return Convert.ToInt32(value);
		}

		/// <inheritdoc />
		public long ToInt64(bool value)
		{
			return Convert.ToInt64(value);
		}

		/// <inheritdoc />
		public long ToInt64(byte value)
		{
			return Convert.ToInt64(value);
		}

		/// <inheritdoc />
		public long ToInt64(char value)
		{
			return Convert.ToInt64(value);
		}

		/// <inheritdoc />
		public long ToInt64(decimal value)
		{
			return Convert.ToInt64(value);
		}

		/// <inheritdoc />
		public long ToInt64(double value)
		{
			return Convert.ToInt64(value);
		}

		/// <inheritdoc />
		public long ToInt64(short value)
		{
			return Convert.ToInt64(value);
		}

		/// <inheritdoc />
		public long ToInt64(int value)
		{
			return Convert.ToInt64(value);
		}

		/// <inheritdoc />
		public long ToInt64(long value)
		{
			return Convert.ToInt64(value);
		}

		/// <inheritdoc />
		public long ToInt64(object value)
		{
			return Convert.ToInt64(value);
		}

		/// <inheritdoc />
		public long ToInt64(object value, IFormatProvider provider)
		{
			return Convert.ToInt64(value, provider);
		}

		/// <inheritdoc />
		public long ToInt64(sbyte value)
		{
			return Convert.ToInt64(value);
		}

		/// <inheritdoc />
		public long ToInt64(float value)
		{
			return Convert.ToInt64(value);
		}

		/// <inheritdoc />
		public long ToInt64(string value)
		{
			return Convert.ToInt64(value);
		}

		/// <inheritdoc />
		public long ToInt64(string value, IFormatProvider provider)
		{
			return Convert.ToInt64(value, provider);
		}

		/// <inheritdoc />
		public long ToInt64(string value, int fromBase)
		{
			return Convert.ToInt64(value, fromBase);
		}

		/// <inheritdoc />
		public long ToInt64(ushort value)
		{
			return Convert.ToInt64(value);
		}

		/// <inheritdoc />
		public long ToInt64(uint value)
		{
			return Convert.ToInt64(value);
		}

		/// <inheritdoc />
		public long ToInt64(ulong value)
		{
			return Convert.ToInt64(value);
		}

		/// <inheritdoc />
		public sbyte ToSByte(bool value)
		{
			return Convert.ToSByte(value);
		}

		/// <inheritdoc />
		public sbyte ToSByte(byte value)
		{
			return Convert.ToSByte(value);
		}

		/// <inheritdoc />
		public sbyte ToSByte(char value)
		{
			return Convert.ToSByte(value);
		}

		/// <inheritdoc />
		public sbyte ToSByte(decimal value)
		{
			return Convert.ToSByte(value);
		}

		/// <inheritdoc />
		public sbyte ToSByte(double value)
		{
			return Convert.ToSByte(value);
		}

		/// <inheritdoc />
		public sbyte ToSByte(short value)
		{
			return Convert.ToSByte(value);
		}

		/// <inheritdoc />
		public sbyte ToSByte(int value)
		{
			return Convert.ToSByte(value);
		}

		/// <inheritdoc />
		public sbyte ToSByte(long value)
		{
			return Convert.ToSByte(value);
		}

		/// <inheritdoc />
		public sbyte ToSByte(object value)
		{
			return Convert.ToSByte(value);
		}

		/// <inheritdoc />
		public sbyte ToSByte(object value, IFormatProvider provider)
		{
			return Convert.ToSByte(value, provider);
		}

		/// <inheritdoc />
		public sbyte ToSByte(sbyte value)
		{
			return Convert.ToSByte(value);
		}

		/// <inheritdoc />
		public sbyte ToSByte(float value)
		{
			return Convert.ToSByte(value);
		}

		/// <inheritdoc />
		public sbyte ToSByte(string value)
		{
			return Convert.ToSByte(value);
		}

		/// <inheritdoc />
		public sbyte ToSByte(string value, IFormatProvider provider)
		{
			return Convert.ToSByte(value);
		}

		/// <inheritdoc />
		public sbyte ToSByte(string value, int fromBase)
		{
			return Convert.ToSByte(value, fromBase);
		}

		/// <inheritdoc />
		public sbyte ToSByte(ushort value)
		{
			return Convert.ToSByte(value);
		}

		/// <inheritdoc />
		public sbyte ToSByte(uint value)
		{
			return Convert.ToSByte(value);
		}

		/// <inheritdoc />
		public sbyte ToSByte(ulong value)
		{
			return Convert.ToSByte(value);
		}

		/// <inheritdoc />
		public float ToSingle(bool value)
		{
			return Convert.ToSingle(value);
		}

		/// <inheritdoc />
		public float ToSingle(byte value)
		{
			return Convert.ToSingle(value);
		}

		/// <inheritdoc />
		public float ToSingle(decimal value)
		{
			return Convert.ToSingle(value);
		}

		/// <inheritdoc />
		public float ToSingle(double value)
		{
			return Convert.ToSingle(value);
		}

		/// <inheritdoc />
		public float ToSingle(short value)
		{
			return Convert.ToSingle(value);
		}

		/// <inheritdoc />
		public float ToSingle(int value)
		{
			return Convert.ToSingle(value);
		}

		/// <inheritdoc />
		public float ToSingle(long value)
		{
			return Convert.ToSingle(value);
		}

		/// <inheritdoc />
		public float ToSingle(object value)
		{
			return Convert.ToSingle(value);
		}

		/// <inheritdoc />
		public float ToSingle(object value, IFormatProvider provider)
		{
			return Convert.ToSingle(value, provider);
		}

		/// <inheritdoc />
		public float ToSingle(sbyte value)
		{
			return Convert.ToSingle(value);
		}

		/// <inheritdoc />
		public float ToSingle(float value)
		{
			return Convert.ToSingle(value);
		}

		/// <inheritdoc />
		public float ToSingle(string value)
		{
			return Convert.ToSingle(value);
		}

		/// <inheritdoc />
		public float ToSingle(string value, IFormatProvider provider)
		{
			return Convert.ToSingle(value, provider);
		}

		/// <inheritdoc />
		public float ToSingle(ushort value)
		{
			return Convert.ToSingle(value);
		}

		/// <inheritdoc />
		public float ToSingle(uint value)
		{
			return Convert.ToSingle(value);
		}

		/// <inheritdoc />
		public float ToSingle(ulong value)
		{
			return Convert.ToSingle(value);
		}

		/// <inheritdoc />
		public string ToString(bool value)
		{
			return Convert.ToString(value);
		}

		/// <inheritdoc />
		public string ToString(bool value, IFormatProvider provider)
		{
			return Convert.ToString(value, provider);
		}

		/// <inheritdoc />
		public string ToString(byte value)
		{
			return Convert.ToString(value);
		}

		/// <inheritdoc />
		public string ToString(byte value, IFormatProvider provider)
		{
			return Convert.ToString(value, provider);
		}

		/// <inheritdoc />
		public string ToString(byte value, int toBase)
		{
			return Convert.ToString(value, toBase);
		}

		/// <inheritdoc />
		public string ToString(char value)
		{
			return Convert.ToString(value);
		}

		/// <inheritdoc />
		public string ToString(char value, IFormatProvider provider)
		{
			return Convert.ToString(value, provider);
		}

		/// <inheritdoc />
		public string ToString(DateTime value)
		{
			// ReSharper disable once SpecifyACultureInStringConversionExplicitly
			return Convert.ToString(value);
		}

		/// <inheritdoc />
		public string ToString(DateTime value, IFormatProvider provider)
		{
			return Convert.ToString(value, provider);
		}

		/// <inheritdoc />
		public string ToString(decimal value)
		{
			// ReSharper disable once SpecifyACultureInStringConversionExplicitly
			return Convert.ToString(value);
		}

		/// <inheritdoc />
		public string ToString(decimal value, IFormatProvider provider)
		{
			return Convert.ToString(value, provider);
		}

		/// <inheritdoc />
		public string ToString(double value)
		{
			// ReSharper disable once SpecifyACultureInStringConversionExplicitly
			return Convert.ToString(value);
		}

		/// <inheritdoc />
		public string ToString(double value, IFormatProvider provider)
		{
			return Convert.ToString(value, provider);
		}

		/// <inheritdoc />
		public string ToString(short value)
		{
			return Convert.ToString(value);
		}

		/// <inheritdoc />
		public string ToString(short value, IFormatProvider provider)
		{
			return Convert.ToString(value, provider);
		}

		/// <inheritdoc />
		public string ToString(short value, int toBase)
		{
			return Convert.ToString(value, toBase);
		}

		/// <inheritdoc />
		public string ToString(int value)
		{
			return Convert.ToString(value);
		}

		/// <inheritdoc />
		public string ToString(int value, IFormatProvider provider)
		{
			return Convert.ToString(value, provider);
		}

		/// <inheritdoc />
		public string ToString(int value, int toBase)
		{
			return Convert.ToString(value, toBase);
		}

		/// <inheritdoc />
		public string ToString(long value)
		{
			return Convert.ToString(value);
		}

		/// <inheritdoc />
		public string ToString(long value, IFormatProvider provider)
		{
			return Convert.ToString(value, provider);
		}

		/// <inheritdoc />
		public string ToString(long value, int toBase)
		{
			return Convert.ToString(value, toBase);
		}

		/// <inheritdoc />
		public string ToString(object value)
		{
			return Convert.ToString(value);
		}

		/// <inheritdoc />
		public string ToString(object value, IFormatProvider provider)
		{
			return Convert.ToString(value, provider);
		}

		/// <inheritdoc />
		public string ToString(sbyte value)
		{
			return Convert.ToString(value);
		}

		/// <inheritdoc />
		public string ToString(sbyte value, IFormatProvider provider)
		{
			return Convert.ToString(value, provider);
		}

		/// <inheritdoc />
		public string ToString(float value)
		{
			// ReSharper disable once SpecifyACultureInStringConversionExplicitly
			return Convert.ToString(value);
		}

		/// <inheritdoc />
		public string ToString(float value, IFormatProvider provider)
		{
			return Convert.ToString(value, provider);
		}

		/// <inheritdoc />
		public string ToString(ushort value)
		{
			return Convert.ToString(value);
		}

		/// <inheritdoc />
		public string ToString(ushort value, IFormatProvider provider)
		{
			return Convert.ToString(value, provider);
		}

		/// <inheritdoc />
		public string ToString(uint value)
		{
			return Convert.ToString(value);
		}

		/// <inheritdoc />
		public string ToString(uint value, IFormatProvider provider)
		{
			return Convert.ToString(value, provider);
		}

		/// <inheritdoc />
		public string ToString(ulong value)
		{
			return Convert.ToString(value);
		}

		/// <inheritdoc />
		public string ToString(ulong value, IFormatProvider provider)
		{
			return Convert.ToString(value, provider);
		}

		/// <inheritdoc />
		public ushort ToUInt16(bool value)
		{
			return Convert.ToUInt16(value);
		}

		/// <inheritdoc />
		public ushort ToUInt16(byte value)
		{
			return Convert.ToUInt16(value);
		}

		/// <inheritdoc />
		public ushort ToUInt16(char value)
		{
			return Convert.ToUInt16(value);
		}

		/// <inheritdoc />
		public ushort ToUInt16(decimal value)
		{
			return Convert.ToUInt16(value);
		}

		/// <inheritdoc />
		public ushort ToUInt16(double value)
		{
			return Convert.ToUInt16(value);
		}

		/// <inheritdoc />
		public ushort ToUInt16(short value)
		{
			return Convert.ToUInt16(value);
		}

		/// <inheritdoc />
		public ushort ToUInt16(int value)
		{
			return Convert.ToUInt16(value);
		}

		/// <inheritdoc />
		public ushort ToUInt16(long value)
		{
			return Convert.ToUInt16(value);
		}

		/// <inheritdoc />
		public ushort ToUInt16(object value)
		{
			return Convert.ToUInt16(value);
		}

		/// <inheritdoc />
		public ushort ToUInt16(object value, IFormatProvider provider)
		{
			return Convert.ToUInt16(value, provider);
		}

		/// <inheritdoc />
		public ushort ToUInt16(sbyte value)
		{
			return Convert.ToUInt16(value);
		}

		/// <inheritdoc />
		public ushort ToUInt16(float value)
		{
			return Convert.ToUInt16(value);
		}

		/// <inheritdoc />
		public ushort ToUInt16(string value)
		{
			return Convert.ToUInt16(value);
		}

		/// <inheritdoc />
		public ushort ToUInt16(string value, IFormatProvider provider)
		{
			return Convert.ToUInt16(value, provider);
		}

		/// <inheritdoc />
		public ushort ToUInt16(string value, int fromBase)
		{
			return Convert.ToUInt16(value, fromBase);
		}

		/// <inheritdoc />
		public ushort ToUInt16(ushort value)
		{
			return Convert.ToUInt16(value);
		}

		/// <inheritdoc />
		public ushort ToUInt16(uint value)
		{
			return Convert.ToUInt16(value);
		}

		/// <inheritdoc />
		public ushort ToUInt16(ulong value)
		{
			return Convert.ToUInt16(value);
		}

		/// <inheritdoc />
		public uint ToUInt32(bool value)
		{
			return Convert.ToUInt32(value);
		}

		/// <inheritdoc />
		public uint ToUInt32(byte value)
		{
			return Convert.ToUInt32(value);
		}

		/// <inheritdoc />
		public uint ToUInt32(char value)
		{
			return Convert.ToUInt32(value);
		}

		/// <inheritdoc />
		public uint ToUInt32(decimal value)
		{
			return Convert.ToUInt32(value);
		}

		/// <inheritdoc />
		public uint ToUInt32(double value)
		{
			return Convert.ToUInt32(value);
		}

		/// <inheritdoc />
		public uint ToUInt32(short value)
		{
			return Convert.ToUInt32(value);
		}

		/// <inheritdoc />
		public uint ToUInt32(int value)
		{
			return Convert.ToUInt32(value);
		}

		/// <inheritdoc />
		public uint ToUInt32(long value)
		{
			return Convert.ToUInt32(value);
		}

		/// <inheritdoc />
		public uint ToUInt32(object value)
		{
			return Convert.ToUInt32(value);
		}

		/// <inheritdoc />
		public uint ToUInt32(object value, IFormatProvider provider)
		{
			return Convert.ToUInt32(value, provider);
		}

		/// <inheritdoc />
		public uint ToUInt32(sbyte value)
		{
			return Convert.ToUInt32(value);
		}

		/// <inheritdoc />
		public uint ToUInt32(float value)
		{
			return Convert.ToUInt32(value);
		}

		/// <inheritdoc />
		public uint ToUInt32(string value)
		{
			return Convert.ToUInt32(value);
		}

		/// <inheritdoc />
		public uint ToUInt32(string value, IFormatProvider provider)
		{
			return Convert.ToUInt32(value, provider);
		}

		/// <inheritdoc />
		public uint ToUInt32(string value, int fromBase)
		{
			return Convert.ToUInt32(value, fromBase);
		}

		/// <inheritdoc />
		public uint ToUInt32(ushort value)
		{
			return Convert.ToUInt32(value);
		}

		/// <inheritdoc />
		public uint ToUInt32(uint value)
		{
			return Convert.ToUInt32(value);
		}

		/// <inheritdoc />
		public uint ToUInt32(ulong value)
		{
			return Convert.ToUInt32(value);
		}

		/// <inheritdoc />
		public ulong ToUInt64(bool value)
		{
			return Convert.ToUInt64(value);
		}

		/// <inheritdoc />
		public ulong ToUInt64(byte value)
		{
			return Convert.ToUInt64(value);
		}

		/// <inheritdoc />
		public ulong ToUInt64(char value)
		{
			return Convert.ToUInt64(value);
		}

		/// <inheritdoc />
		public ulong ToUInt64(decimal value)
		{
			return Convert.ToUInt64(value);
		}

		/// <inheritdoc />
		public ulong ToUInt64(double value)
		{
			return Convert.ToUInt64(value);
		}

		/// <inheritdoc />
		public ulong ToUInt64(short value)
		{
			return Convert.ToUInt64(value);
		}

		/// <inheritdoc />
		public ulong ToUInt64(int value)
		{
			return Convert.ToUInt64(value);
		}

		/// <inheritdoc />
		public ulong ToUInt64(long value)
		{
			return Convert.ToUInt64(value);
		}

		/// <inheritdoc />
		public ulong ToUInt64(object value)
		{
			return Convert.ToUInt64(value);
		}

		/// <inheritdoc />
		public ulong ToUInt64(object value, IFormatProvider provider)
		{
			return Convert.ToUInt64(value, provider);
		}

		/// <inheritdoc />
		public ulong ToUInt64(sbyte value)
		{
			return Convert.ToUInt64(value);
		}

		/// <inheritdoc />
		public ulong ToUInt64(float value)
		{
			return Convert.ToUInt64(value);
		}

		/// <inheritdoc />
		public ulong ToUInt64(string value)
		{
			return Convert.ToUInt64(value);
		}

		/// <inheritdoc />
		public ulong ToUInt64(string value, IFormatProvider provider)
		{
			return Convert.ToUInt64(value, provider);
		}

		/// <inheritdoc />
		public ulong ToUInt64(string value, int fromBase)
		{
			return Convert.ToUInt64(value, fromBase);
		}

		/// <inheritdoc />
		public ulong ToUInt64(ushort value)
		{
			return Convert.ToUInt64(value);
		}

		/// <inheritdoc />
		public ulong ToUInt64(uint value)
		{
			return Convert.ToUInt64(value);
		}

		/// <inheritdoc />
		public ulong ToUInt64(ulong value)
		{
			return Convert.ToUInt64(value);
		}
	}
}
