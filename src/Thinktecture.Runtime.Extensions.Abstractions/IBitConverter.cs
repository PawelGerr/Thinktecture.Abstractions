﻿using System;
namespace Thinktecture
{
	/// <summary>
	/// Converts base data types to an array of bytes, and an array of bytes to base data types.
	/// </summary>
	public interface IBitConverter
	{
		/// <summary>Indicates the byte order ("endianness") in which data is stored in this computer architecture.</summary>
		bool IsLittleEndian { get; }

		/// <summary>
		/// Converts <paramref name="value"/> to int.
		/// </summary>
		/// <param name="value">Value to convert.</param>
		/// <returns>An integer.</returns>
		int SingleToInt32Bits(float value);

		/// <summary>
		/// Converts <paramref name="value"/> to float.
		/// </summary>
		/// <param name="value">Values to convert.</param>
		/// <returns>A float.</returns>
		float Int32BitsToSingle(int value);

		/// <summary>
		/// Writes the <paramref name="value"/> into <paramref name="destination"/>.
		/// </summary>
		/// <param name="destination">Destination to write the <paramref name="value"/> into.</param>
		/// <param name="value">Value to write into <paramref name="destination"/>.</param>
		/// <returns><c>true</c> if <paramref name="value"/> has been written successfully; otherwise <c>false</c>.</returns>
		bool TryWriteBytes(Span<byte> destination, bool value);

		/// <summary>
		/// Writes the <paramref name="value"/> into <paramref name="destination"/>.
		/// </summary>
		/// <param name="destination">Destination to write the <paramref name="value"/> into.</param>
		/// <param name="value">Value to write into <paramref name="destination"/>.</param>
		/// <returns><c>true</c> if <paramref name="value"/> has been written successfully; otherwise <c>false</c>.</returns>
		bool TryWriteBytes(Span<byte> destination, char value);

		/// <summary>
		/// Writes the <paramref name="value"/> into <paramref name="destination"/>.
		/// </summary>
		/// <param name="destination">Destination to write the <paramref name="value"/> into.</param>
		/// <param name="value">Value to write into <paramref name="destination"/>.</param>
		/// <returns><c>true</c> if <paramref name="value"/> has been written successfully; otherwise <c>false</c>.</returns>
		bool TryWriteBytes(Span<byte> destination, double value);

		/// <summary>
		/// Writes the <paramref name="value"/> into <paramref name="destination"/>.
		/// </summary>
		/// <param name="destination">Destination to write the <paramref name="value"/> into.</param>
		/// <param name="value">Value to write into <paramref name="destination"/>.</param>
		/// <returns><c>true</c> if <paramref name="value"/> has been written successfully; otherwise <c>false</c>.</returns>
		bool TryWriteBytes(Span<byte> destination, float value);

		/// <summary>
		/// Writes the <paramref name="value"/> into <paramref name="destination"/>.
		/// </summary>
		/// <param name="destination">Destination to write the <paramref name="value"/> into.</param>
		/// <param name="value">Value to write into <paramref name="destination"/>.</param>
		/// <returns><c>true</c> if <paramref name="value"/> has been written successfully; otherwise <c>false</c>.</returns>
		bool TryWriteBytes(Span<byte> destination, int value);

		/// <summary>
		/// Writes the <paramref name="value"/> into <paramref name="destination"/>.
		/// </summary>
		/// <param name="destination">Destination to write the <paramref name="value"/> into.</param>
		/// <param name="value">Value to write into <paramref name="destination"/>.</param>
		/// <returns><c>true</c> if <paramref name="value"/> has been written successfully; otherwise <c>false</c>.</returns>
		bool TryWriteBytes(Span<byte> destination, long value);

		/// <summary>
		/// Writes the <paramref name="value"/> into <paramref name="destination"/>.
		/// </summary>
		/// <param name="destination">Destination to write the <paramref name="value"/> into.</param>
		/// <param name="value">Value to write into <paramref name="destination"/>.</param>
		/// <returns><c>true</c> if <paramref name="value"/> has been written successfully; otherwise <c>false</c>.</returns>
		bool TryWriteBytes(Span<byte> destination, short value);

		/// <summary>
		/// Writes the <paramref name="value"/> into <paramref name="destination"/>.
		/// </summary>
		/// <param name="destination">Destination to write the <paramref name="value"/> into.</param>
		/// <param name="value">Value to write into <paramref name="destination"/>.</param>
		/// <returns><c>true</c> if <paramref name="value"/> has been written successfully; otherwise <c>false</c>.</returns>
		bool TryWriteBytes(Span<byte> destination, ushort value);

		/// <summary>
		/// Writes the <paramref name="value"/> into <paramref name="destination"/>.
		/// </summary>
		/// <param name="destination">Destination to write the <paramref name="value"/> into.</param>
		/// <param name="value">Value to write into <paramref name="destination"/>.</param>
		/// <returns><c>true</c> if <paramref name="value"/> has been written successfully; otherwise <c>false</c>.</returns>
		bool TryWriteBytes(Span<byte> destination, uint value);

		/// <summary>
		/// Writes the <paramref name="value"/> into <paramref name="destination"/>.
		/// </summary>
		/// <param name="destination">Destination to write the <paramref name="value"/> into.</param>
		/// <param name="value">Value to write into <paramref name="destination"/>.</param>
		/// <returns><c>true</c> if <paramref name="value"/> has been written successfully; otherwise <c>false</c>.</returns>
		bool TryWriteBytes(Span<byte> destination, ulong value);

		/// <summary>Returns a Unicode character converted from two bytes in span.</summary>
		/// <param name="value">A span of characters.</param>
		/// <returns>A character formed by two bytes.</returns>
		char ToChar(ReadOnlySpan<byte> value);

		/// <summary>Returns a 16-bit signed integer converted from two bytes in span.</summary>
		/// <param name="value">A span of bytes. </param>
		/// <returns>A 16-bit signed integer formed by two bytes.</returns>
		short ToInt16(ReadOnlySpan<byte> value);

		/// <summary>Returns a Boolean value converted from one byte at a specified position in a byte array.</summary>
		/// <param name="value">A span of bytes. </param>
		/// <returns>true if the byte in <paramref name="value" /> is nonzero; otherwise, false.</returns>
		bool ToBoolean(ReadOnlySpan<byte> value);

		/// <summary>Returns a double-precision floating point number converted from eight bytes.</summary>
		/// <param name="value">A span of bytes. </param>
		/// <returns>A double precision floating point number formed by eight bytes.</returns>
		double ToDouble(ReadOnlySpan<byte> value);

		/// <summary>Returns a 32-bit signed integer converted from four bytes.</summary>
		/// <param name="value">An array of bytes.</param>
		/// <returns>A 32-bit signed integer formed by four bytes.</returns>
		int ToInt32(ReadOnlySpan<byte> value);

		/// <summary>Returns a 64-bit signed integer converted from eight bytes.</summary>
		/// <param name="value">A span of bytes. </param>
		/// <returns>A 64-bit signed integer formed by eight bytes.</returns>
		long ToInt64(ReadOnlySpan<byte> value);

		/// <summary>Returns a single-precision floating point number converted from four bytes.</summary>
		/// <param name="value">A span of bytes.</param>
		/// <returns>A single-precision floating point number formed by four bytes.</returns>
		float ToSingle(ReadOnlySpan<byte> value);

		/// <summary>Returns a 16-bit unsigned integer converted from two bytes.</summary>
		/// <param name="value">The span of bytes.</param>
		/// <returns>A 16-bit unsigned integer formed by two bytes.</returns>
		ushort ToUInt16(ReadOnlySpan<byte> value);

		/// <summary>Returns a 32-bit unsigned integer converted from four bytes.</summary>
		/// <param name="value">A span of bytes.</param>
		/// <returns>A 32-bit unsigned integer formed by four bytes.</returns>
		uint ToUInt32(ReadOnlySpan<byte> value);

		/// <summary>Returns a 64-bit unsigned integer converted from eight bytes.</summary>
		/// <param name="value">A span of bytes.</param>
		/// <returns>A 64-bit unsigned integer formed by the eight bytes.</returns>
		ulong ToUInt64(ReadOnlySpan<byte> value);

		/// <summary>Converts the specified double-precision floating point number to a 64-bit signed integer.</summary>
		/// <returns>A 64-bit signed integer whose value is equivalent to <paramref name="value" />.</returns>
		/// <param name="value">The number to convert. </param>
		long DoubleToInt64Bits(double value);

		/// <summary>Returns the specified Boolean value as an array of bytes.</summary>
		/// <returns>An array of bytes with length 1.</returns>
		/// <param name="value">A Boolean value. </param>
		byte[] GetBytes(bool value);

		/// <summary>Returns the specified Unicode character value as an array of bytes.</summary>
		/// <returns>An array of bytes with length 2.</returns>
		/// <param name="value">A character to convert. </param>
		byte[] GetBytes(char value);

		/// <summary>Returns the specified double-precision floating point value as an array of bytes.</summary>
		/// <returns>An array of bytes with length 8.</returns>
		/// <param name="value">The number to convert. </param>
		byte[] GetBytes(double value);

		/// <summary>Returns the specified 16-bit signed integer value as an array of bytes.</summary>
		/// <returns>An array of bytes with length 2.</returns>
		/// <param name="value">The number to convert. </param>
		byte[] GetBytes(short value);

		/// <summary>Returns the specified 32-bit signed integer value as an array of bytes.</summary>
		/// <returns>An array of bytes with length 4.</returns>
		/// <param name="value">The number to convert. </param>
		byte[] GetBytes(int value);

		/// <summary>Returns the specified 64-bit signed integer value as an array of bytes.</summary>
		/// <returns>An array of bytes with length 8.</returns>
		/// <param name="value">The number to convert. </param>
		byte[] GetBytes(long value);

		/// <summary>Returns the specified single-precision floating point value as an array of bytes.</summary>
		/// <returns>An array of bytes with length 4.</returns>
		/// <param name="value">The number to convert. </param>
		byte[] GetBytes(float value);

		/// <summary>Returns the specified 16-bit unsigned integer value as an array of bytes.</summary>
		/// <returns>An array of bytes with length 2.</returns>
		/// <param name="value">The number to convert. </param>
		byte[] GetBytes(ushort value);

		/// <summary>Returns the specified 32-bit unsigned integer value as an array of bytes.</summary>
		/// <returns>An array of bytes with length 4.</returns>
		/// <param name="value">The number to convert. </param>
		byte[] GetBytes(uint value);

		/// <summary>Returns the specified 64-bit unsigned integer value as an array of bytes.</summary>
		/// <returns>An array of bytes with length 8.</returns>
		/// <param name="value">The number to convert. </param>
		byte[] GetBytes(ulong value);

		/// <summary>Converts the specified 64-bit signed integer to a double-precision floating point number.</summary>
		/// <returns>A double-precision floating point number whose value is equivalent to <paramref name="value" />.</returns>
		/// <param name="value">The number to convert. </param>
		double Int64BitsToDouble(long value);

		/// <summary>Returns a Boolean value converted from one byte at a specified position in a byte array.</summary>
		/// <returns>true if the byte at <paramref name="startIndex" /> in <paramref name="value" /> is nonzero; otherwise, false.</returns>
		/// <param name="value">An array of bytes. </param>
		/// <param name="startIndex">The starting position within <paramref name="value" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="startIndex" /> is less than zero or greater than the length of <paramref name="value" /> minus 1. </exception>
		bool ToBoolean(byte[] value, int startIndex);

		/// <summary>Returns a Unicode character converted from two bytes at a specified position in a byte array.</summary>
		/// <returns>A character formed by two bytes beginning at <paramref name="startIndex" />.</returns>
		/// <param name="value">An array. </param>
		/// <param name="startIndex">The starting position within <paramref name="value" />. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="startIndex" /> equals the length of <paramref name="value" /> minus 1.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="startIndex" /> is less than zero or greater than the length of <paramref name="value" /> minus 1. </exception>
		char ToChar(byte[] value, int startIndex);

		/// <summary>Returns a double-precision floating point number converted from eight bytes at a specified position in a byte array.</summary>
		/// <returns>A double precision floating point number formed by eight bytes beginning at <paramref name="startIndex" />.</returns>
		/// <param name="value">An array of bytes. </param>
		/// <param name="startIndex">The starting position within <paramref name="value" />. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="startIndex" /> is greater than or equal to the length of <paramref name="value" /> minus 7, and is less than or equal to the length of <paramref name="value" /> minus 1.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="startIndex" /> is less than zero or greater than the length of <paramref name="value" /> minus 1. </exception>
		double ToDouble(byte[] value, int startIndex);

		/// <summary>Returns a 16-bit signed integer converted from two bytes at a specified position in a byte array.</summary>
		/// <returns>A 16-bit signed integer formed by two bytes beginning at <paramref name="startIndex" />.</returns>
		/// <param name="value">An array of bytes. </param>
		/// <param name="startIndex">The starting position within <paramref name="value" />. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="startIndex" /> equals the length of <paramref name="value" /> minus 1.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="startIndex" /> is less than zero or greater than the length of <paramref name="value" /> minus 1. </exception>
		short ToInt16(byte[] value, int startIndex);

		/// <summary>Returns a 32-bit signed integer converted from four bytes at a specified position in a byte array.</summary>
		/// <returns>A 32-bit signed integer formed by four bytes beginning at <paramref name="startIndex" />.</returns>
		/// <param name="value">An array of bytes. </param>
		/// <param name="startIndex">The starting position within <paramref name="value" />. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="startIndex" /> is greater than or equal to the length of <paramref name="value" /> minus 3, and is less than or equal to the length of <paramref name="value" /> minus 1.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="startIndex" /> is less than zero or greater than the length of <paramref name="value" /> minus 1. </exception>
		int ToInt32(byte[] value, int startIndex);

		/// <summary>Returns a 64-bit signed integer converted from eight bytes at a specified position in a byte array.</summary>
		/// <returns>A 64-bit signed integer formed by eight bytes beginning at <paramref name="startIndex" />.</returns>
		/// <param name="value">An array of bytes. </param>
		/// <param name="startIndex">The starting position within <paramref name="value" />. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="startIndex" /> is greater than or equal to the length of <paramref name="value" /> minus 7, and is less than or equal to the length of <paramref name="value" /> minus 1.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="startIndex" /> is less than zero or greater than the length of <paramref name="value" /> minus 1. </exception>
		long ToInt64(byte[] value, int startIndex);

		/// <summary>Returns a single-precision floating point number converted from four bytes at a specified position in a byte array.</summary>
		/// <returns>A single-precision floating point number formed by four bytes beginning at <paramref name="startIndex" />.</returns>
		/// <param name="value">An array of bytes. </param>
		/// <param name="startIndex">The starting position within <paramref name="value" />. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="startIndex" /> is greater than or equal to the length of <paramref name="value" /> minus 3, and is less than or equal to the length of <paramref name="value" /> minus 1.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="startIndex" /> is less than zero or greater than the length of <paramref name="value" /> minus 1. </exception>
		float ToSingle(byte[] value, int startIndex);

		/// <summary>Converts the numeric value of each element of a specified array of bytes to its equivalent hexadecimal string representation.</summary>
		/// <returns>A string of hexadecimal pairs separated by hyphens, where each pair represents the corresponding element in <paramref name="value" />; for example, "7F-2C-4A-00".</returns>
		/// <param name="value">An array of bytes. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="value" /> is null. </exception>
		string ToString(byte[] value);

		/// <summary>Converts the numeric value of each element of a specified subarray of bytes to its equivalent hexadecimal string representation.</summary>
		/// <returns>A string of hexadecimal pairs separated by hyphens, where each pair represents the corresponding element in a subarray of <paramref name="value" />; for example, "7F-2C-4A-00".</returns>
		/// <param name="value">An array of bytes. </param>
		/// <param name="startIndex">The starting position within <paramref name="value" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="startIndex" /> is less than zero or greater than the length of <paramref name="value" /> minus 1. </exception>
		string ToString(byte[] value, int startIndex);

		/// <summary>Converts the numeric value of each element of a specified subarray of bytes to its equivalent hexadecimal string representation.</summary>
		/// <returns>A string of hexadecimal pairs separated by hyphens, where each pair represents the corresponding element in a subarray of <paramref name="value" />; for example, "7F-2C-4A-00".</returns>
		/// <param name="value">An array of bytes. </param>
		/// <param name="startIndex">The starting position within <paramref name="value" />. </param>
		/// <param name="length">The number of array elements in <paramref name="value" /> to convert. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="startIndex" /> or <paramref name="length" /> is less than zero.-or-<paramref name="startIndex" /> is greater than zero and is greater than or equal to the length of <paramref name="value" />.</exception>
		/// <exception cref="T:System.ArgumentException">The combination of <paramref name="startIndex" /> and <paramref name="length" /> does not specify a position within <paramref name="value" />; that is, the <paramref name="startIndex" /> parameter is greater than the length of <paramref name="value" /> minus the <paramref name="length" /> parameter.</exception>
		string ToString(byte[] value, int startIndex, int length);

		/// <summary>Returns a 16-bit unsigned integer converted from two bytes at a specified position in a byte array.</summary>
		/// <returns>A 16-bit unsigned integer formed by two bytes beginning at <paramref name="startIndex" />.</returns>
		/// <param name="value">The array of bytes. </param>
		/// <param name="startIndex">The starting position within <paramref name="value" />. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="startIndex" /> equals the length of <paramref name="value" /> minus 1.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="startIndex" /> is less than zero or greater than the length of <paramref name="value" /> minus 1. </exception>
		ushort ToUInt16(byte[] value, int startIndex);

		/// <summary>Returns a 32-bit unsigned integer converted from four bytes at a specified position in a byte array.</summary>
		/// <returns>A 32-bit unsigned integer formed by four bytes beginning at <paramref name="startIndex" />.</returns>
		/// <param name="value">An array of bytes. </param>
		/// <param name="startIndex">The starting position within <paramref name="value" />. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="startIndex" /> is greater than or equal to the length of <paramref name="value" /> minus 3, and is less than or equal to the length of <paramref name="value" /> minus 1.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="startIndex" /> is less than zero or greater than the length of <paramref name="value" /> minus 1. </exception>
		uint ToUInt32(byte[] value, int startIndex);

		/// <summary>Returns a 64-bit unsigned integer converted from eight bytes at a specified position in a byte array.</summary>
		/// <returns>A 64-bit unsigned integer formed by the eight bytes beginning at <paramref name="startIndex" />.</returns>
		/// <param name="value">An array of bytes. </param>
		/// <param name="startIndex">The starting position within <paramref name="value" />. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="startIndex" /> is greater than or equal to the length of <paramref name="value" /> minus 7, and is less than or equal to the length of <paramref name="value" /> minus 1.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="startIndex" /> is less than zero or greater than the length of <paramref name="value" /> minus 1. </exception>
		ulong ToUInt64(byte[] value, int startIndex);
	}
}
