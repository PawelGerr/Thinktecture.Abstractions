using System;

namespace Thinktecture
{
   /// <summary>Converts a base data type to another base data type.</summary>
   public interface IConvert
   {
      /// <summary>Returns an object of the specified type and whose value is equivalent to the specified object.</summary>
      /// <returns>An object whose type is <paramref name="conversionType" /> and whose value is equivalent to <paramref name="value" />.-or-A null reference (Nothing in Visual Basic), if <paramref name="value" /> is null and <paramref name="conversionType" /> is not a value type. </returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
      /// <param name="conversionType">The type of object to return. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported.  -or-<paramref name="value" /> is null and <paramref name="conversionType" /> is a value type.-or-<paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.</exception>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in a format recognized by <paramref name="conversionType" />.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is out of the range of <paramref name="conversionType" />.</exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="conversionType" /> is null.</exception>
      object? ChangeType(object? value, Type conversionType);

      /// <summary>Returns an object of the specified type whose value is equivalent to the specified object. A parameter supplies culture-specific formatting information.</summary>
      /// <returns>An object whose type is <paramref name="conversionType" /> and whose value is equivalent to <paramref name="value" />.-or- <paramref name="value" />, if the <see cref="T:System.Type" /> of <paramref name="value" /> and <paramref name="conversionType" /> are equal.-or- A null reference (Nothing in Visual Basic), if <paramref name="value" /> is null and <paramref name="conversionType" /> is not a value type.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
      /// <param name="conversionType">The type of object to return. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. -or-<paramref name="value" /> is null and <paramref name="conversionType" /> is a value type.-or-<paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.</exception>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in a format for <paramref name="conversionType" /> recognized by <paramref name="provider" />.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is out of the range of <paramref name="conversionType" />.</exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="conversionType" /> is null.</exception>
      object? ChangeType(object? value, Type conversionType, IFormatProvider? provider);

      /// <summary>Returns an object of the specified type whose value is equivalent to the specified object.</summary>
      /// <returns>An object whose underlying type is <paramref name="typeCode" /> and whose value is equivalent to <paramref name="value" />.-or-A null reference (Nothing in Visual Basic), if <paramref name="value" /> is null and <paramref name="typeCode" /> is <see cref="F:System.TypeCode.Empty" />, <see cref="F:System.TypeCode.String" />, or <see cref="F:System.TypeCode.Object" />.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
      /// <param name="typeCode">The type of object to return. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported.  -or-<paramref name="value" /> is null and <paramref name="typeCode" /> specifies a value type.-or-<paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.</exception>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in a format recognized by the <paramref name="typeCode" /> type.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is out of the range of the <paramref name="typeCode" /> type.</exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="typeCode" /> is invalid. </exception>
      /// <filterpriority>1</filterpriority>
      object? ChangeType(object? value, TypeCode typeCode);

      /// <summary>Returns an object of the specified type whose value is equivalent to the specified object. A parameter supplies culture-specific formatting information.</summary>
      /// <returns>An object whose underlying type is <paramref name="typeCode" /> and whose value is equivalent to <paramref name="value" />.-or- A null reference (Nothing in Visual Basic), if <paramref name="value" /> is null and <paramref name="typeCode" /> is <see cref="F:System.TypeCode.Empty" />, <see cref="F:System.TypeCode.String" />, or <see cref="F:System.TypeCode.Object" />.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
      /// <param name="typeCode">The type of object to return. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported.  -or-<paramref name="value" /> is null and <paramref name="typeCode" /> specifies a value type.-or-<paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.</exception>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in a format for the <paramref name="typeCode" /> type recognized by <paramref name="provider" />.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is out of the range of the <paramref name="typeCode" /> type.</exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="typeCode" /> is invalid. </exception>
      /// <filterpriority>1</filterpriority>
      object? ChangeType(object? value, TypeCode typeCode, IFormatProvider? provider);

      /// <summary>Converts a subset of a Unicode character array, which encodes binary data as base-64 digits, to an equivalent 8-bit unsigned integer array. Parameters specify the subset in the input array and the number of elements to convert.</summary>
      /// <returns>An array of 8-bit unsigned integers equivalent to <paramref name="length" /> elements at position <paramref name="offset" /> in <paramref name="inArray" />.</returns>
      /// <param name="inArray">A Unicode character array. </param>
      /// <param name="offset">A position within <paramref name="inArray" />. </param>
      /// <param name="length">The number of elements in <paramref name="inArray" /> to convert. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="inArray" /> is null. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="offset" /> or <paramref name="length" /> is less than 0.-or- <paramref name="offset" /> plus <paramref name="length" /> indicates a position not within <paramref name="inArray" />. </exception>
      /// <exception cref="T:System.FormatException">The length of <paramref name="inArray" />, ignoring white-space characters, is not zero or a multiple of 4. -or-The format of <paramref name="inArray" /> is invalid. <paramref name="inArray" /> contains a non-base-64 character, more than two padding characters, or a non-white-space character among the padding characters. </exception>
      byte[] FromBase64CharArray(char[] inArray, int offset, int length);

      /// <summary>Converts the specified string, which encodes binary data as base-64 digits, to an equivalent 8-bit unsigned integer array.</summary>
      /// <returns>An array of 8-bit unsigned integers that is equivalent to <paramref name="s" />.</returns>
      /// <param name="s">The string to convert. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="s" /> is null. </exception>
      /// <exception cref="T:System.FormatException">The length of <paramref name="s" />, ignoring white-space characters, is not zero or a multiple of 4. -or-The format of <paramref name="s" /> is invalid. <paramref name="s" /> contains a non-base-64 character, more than two padding characters, or a non-white space-character among the padding characters.</exception>
      byte[] FromBase64String(string s);

      /// <summary>Converts a subset of an 8-bit unsigned integer array to an equivalent subset of a Unicode character array encoded with base-64 digits. Parameters specify the subsets as offsets in the input and output arrays, and the number of elements in the input array to convert.</summary>
      /// <returns>A 32-bit signed integer containing the number of bytes in <paramref name="outArray" />.</returns>
      /// <param name="inArray">An input array of 8-bit unsigned integers. </param>
      /// <param name="offsetIn">A position within <paramref name="inArray" />. </param>
      /// <param name="length">The number of elements of <paramref name="inArray" /> to convert. </param>
      /// <param name="outArray">An output array of Unicode characters. </param>
      /// <param name="offsetOut">A position within <paramref name="outArray" />. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="inArray" /> or <paramref name="outArray" /> is null. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="offsetIn" />, <paramref name="offsetOut" />, or <paramref name="length" /> is negative.-or- <paramref name="offsetIn" /> plus <paramref name="length" /> is greater than the length of <paramref name="inArray" />.-or- <paramref name="offsetOut" /> plus the number of elements to return is greater than the length of <paramref name="outArray" />. </exception>
      int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut);

      /// <summary>Converts a span of 8-bit unsigned integers to its equivalent string representation that is encoded with base-64 digits.</summary>
      /// <param name="bytes">An array of 8-bit unsigned integers. </param>
      /// <param name="options">Options.</param>
      /// <returns>The string representation, in base 64, of the contents of <paramref name="bytes" />.</returns>
      string ToBase64String(ReadOnlySpan<byte> bytes, Base64FormattingOptions options = Base64FormattingOptions.None);

      /// <summary>Converts a span of 8-bit unsigned integers to its equivalent string representation that is encoded with base-64 digits and writes it into <paramref name="chars"/>.</summary>
      /// <param name="bytes">An array of 8-bit unsigned integers. </param>
      /// <param name="charsWritten">Number of chars written into <paramref name="chars"/>.</param>
      /// <param name="options">Options.</param>
      /// <param name="chars">Span to write into.</param>
      /// <returns><c>true</c> if successfully written; otherwise <c>false</c>.</returns>
      bool TryToBase64Chars(ReadOnlySpan<byte> bytes, Span<char> chars, out int charsWritten, Base64FormattingOptions options = Base64FormattingOptions.None);

      /// <summary>
      /// Converts base-64 string to bytes and writes them to <paramref name="bytes"/>.
      /// </summary>
      /// <param name="s">String to convert.</param>
      /// <param name="bytes">Destination to write bytes into.</param>
      /// <param name="bytesWritten">Number of bytes written into <paramref name="bytes"/>.</param>
      /// <returns><c>true</c> if successfully written; otherwise <c>false</c>.</returns>
      bool TryFromBase64String(string s, Span<byte> bytes, out int bytesWritten);

      /// <summary>
      /// Converts base-64 string to bytes and writes them to <paramref name="bytes"/>.
      /// </summary>
      /// <param name="chars">Characters to convert.</param>
      /// <param name="bytes">Destination to write bytes into.</param>
      /// <param name="bytesWritten">Number of bytes written into <paramref name="bytes"/>.</param>
      /// <returns><c>true</c> if successfully written; otherwise <c>false</c>.</returns>
      bool TryFromBase64Chars(ReadOnlySpan<char> chars, Span<byte> bytes, out int bytesWritten);

      /// <summary>Converts an array of 8-bit unsigned integers to its equivalent string representation that is encoded with base-64 digits.</summary>
      /// <returns>The string representation, in base 64, of the contents of <paramref name="inArray" />.</returns>
      /// <param name="inArray">An array of 8-bit unsigned integers. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="inArray" /> is null. </exception>
      string ToBase64String(byte[] inArray);

      /// <summary>Converts a subset of an array of 8-bit unsigned integers to its equivalent string representation that is encoded with base-64 digits. Parameters specify the subset as an offset in the input array, and the number of elements in the array to convert.</summary>
      /// <returns>The string representation in base 64 of <paramref name="length" /> elements of <paramref name="inArray" />, starting at position <paramref name="offset" />.</returns>
      /// <param name="inArray">An array of 8-bit unsigned integers. </param>
      /// <param name="offset">An offset in <paramref name="inArray" />. </param>
      /// <param name="length">The number of elements of <paramref name="inArray" /> to convert. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="inArray" /> is null. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="offset" /> or <paramref name="length" /> is negative.-or- <paramref name="offset" /> plus <paramref name="length" /> is greater than the length of <paramref name="inArray" />. </exception>
      string ToBase64String(byte[] inArray, int offset, int length);

      /// <summary>Returns the specified Boolean value; no actual conversion is performed.</summary>
      /// <returns>
      /// <paramref name="value" /> is returned unchanged.</returns>
      /// <param name="value">The Boolean value to return. </param>
      bool ToBoolean(bool value);

      /// <summary>Converts the value of the specified 8-bit unsigned integer to an equivalent Boolean value.</summary>
      /// <returns>true if <paramref name="value" /> is not zero; otherwise, false.</returns>
      /// <param name="value">The 8-bit unsigned integer to convert. </param>
      bool ToBoolean(byte value);

      /// <summary>Converts the value of the specified decimal number to an equivalent Boolean value.</summary>
      /// <returns>true if <paramref name="value" /> is not zero; otherwise, false.</returns>
      /// <param name="value">The number to convert. </param>
      bool ToBoolean(decimal value);

      /// <summary>Converts the value of the specified double-precision floating-point number to an equivalent Boolean value.</summary>
      /// <returns>true if <paramref name="value" /> is not zero; otherwise, false.</returns>
      /// <param name="value">The double-precision floating-point number to convert. </param>
      bool ToBoolean(double value);

      /// <summary>Converts the value of the specified 16-bit signed integer to an equivalent Boolean value.</summary>
      /// <returns>true if <paramref name="value" /> is not zero; otherwise, false.</returns>
      /// <param name="value">The 16-bit signed integer to convert. </param>
      bool ToBoolean(short value);

      /// <summary>Converts the value of the specified 32-bit signed integer to an equivalent Boolean value.</summary>
      /// <returns>true if <paramref name="value" /> is not zero; otherwise, false.</returns>
      /// <param name="value">The 32-bit signed integer to convert. </param>
      bool ToBoolean(int value);

      /// <summary>Converts the value of the specified 64-bit signed integer to an equivalent Boolean value.</summary>
      /// <returns>true if <paramref name="value" /> is not zero; otherwise, false.</returns>
      /// <param name="value">The 64-bit signed integer to convert. </param>
      bool ToBoolean(long value);

      /// <summary>Converts the value of a specified object to an equivalent Boolean value.</summary>
      /// <returns>true or false, which reflects the value returned by invoking the <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" /> method for the underlying type of <paramref name="value" />. If <paramref name="value" /> is null, the method returns false. </returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or null. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is a string that does not equal <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" />.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.-or-The conversion of <paramref name="value" /> to a <see cref="T:System.Boolean" /> is not supported.</exception>
      bool ToBoolean(object? value);

      /// <summary>Converts the value of the specified object to an equivalent Boolean value, using the specified culture-specific formatting information.</summary>
      /// <returns>true or false, which reflects the value returned by invoking the <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" /> method for the underlying type of <paramref name="value" />. If <paramref name="value" /> is null, the method returns false.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or null. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is a string that does not equal <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" />.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.-or-The conversion of <paramref name="value" /> to a <see cref="T:System.Boolean" /> is not supported. </exception>
      bool ToBoolean(object? value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified 8-bit signed integer to an equivalent Boolean value.</summary>
      /// <returns>true if <paramref name="value" /> is not zero; otherwise, false.</returns>
      /// <param name="value">The 8-bit signed integer to convert. </param>
      bool ToBoolean(sbyte value);

      /// <summary>Converts the value of the specified single-precision floating-point number to an equivalent Boolean value.</summary>
      /// <returns>true if <paramref name="value" /> is not zero; otherwise, false.</returns>
      /// <param name="value">The single-precision floating-point number to convert. </param>
      bool ToBoolean(float value);

      /// <summary>Converts the specified string representation of a logical value to its Boolean equivalent.</summary>
      /// <returns>true if <paramref name="value" /> equals <see cref="F:System.Boolean.TrueString" />, or false if <paramref name="value" /> equals <see cref="F:System.Boolean.FalseString" /> or null.</returns>
      /// <param name="value">A string that contains the value of either <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" />. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not equal to <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" />. </exception>
      bool ToBoolean(string? value);

      /// <summary>Converts the specified string representation of a logical value to its Boolean equivalent, using the specified culture-specific formatting information.</summary>
      /// <returns>true if <paramref name="value" /> equals <see cref="F:System.Boolean.TrueString" />, or false if <paramref name="value" /> equals <see cref="F:System.Boolean.FalseString" /> or null.</returns>
      /// <param name="value">A string that contains the value of either <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" />. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. This parameter is ignored.</param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not equal to <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" />. </exception>
      bool ToBoolean(string? value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified 16-bit unsigned integer to an equivalent Boolean value.</summary>
      /// <returns>true if <paramref name="value" /> is not zero; otherwise, false.</returns>
      /// <param name="value">The 16-bit unsigned integer to convert. </param>
      bool ToBoolean(ushort value);

      /// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent Boolean value.</summary>
      /// <returns>true if <paramref name="value" /> is not zero; otherwise, false.</returns>
      /// <param name="value">The 32-bit unsigned integer to convert. </param>
      bool ToBoolean(uint value);

      /// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent Boolean value.</summary>
      /// <returns>true if <paramref name="value" /> is not zero; otherwise, false.</returns>
      /// <param name="value">The 64-bit unsigned integer to convert. </param>
      bool ToBoolean(ulong value);

      /// <summary>Converts the specified Boolean value to the equivalent 8-bit unsigned integer.</summary>
      /// <returns>The number 1 if <paramref name="value" /> is true; otherwise, 0.</returns>
      /// <param name="value">The Boolean value to convert. </param>
      byte ToByte(bool value);

      /// <summary>Returns the specified 8-bit unsigned integer; no actual conversion is performed.</summary>
      /// <returns>
      /// <paramref name="value" /> is returned unchanged.</returns>
      /// <param name="value">The 8-bit unsigned integer to return. </param>
      byte ToByte(byte value);

      /// <summary>Converts the value of the specified Unicode character to the equivalent 8-bit unsigned integer.</summary>
      /// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The Unicode character to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is greater than <see cref="F:System.Byte.MaxValue" />. </exception>
      byte ToByte(char value);

      /// <summary>Converts the value of the specified decimal number to an equivalent 8-bit unsigned integer.</summary>
      /// <returns>
      /// <paramref name="value" />, rounded to the nearest 8-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
      /// <param name="value">The number to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Byte.MaxValue" /> or less than <see cref="F:System.Byte.MinValue" />. </exception>
      byte ToByte(decimal value);

      /// <summary>Converts the value of the specified double-precision floating-point number to an equivalent 8-bit unsigned integer.</summary>
      /// <returns>
      /// <paramref name="value" />, rounded to the nearest 8-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
      /// <param name="value">The double-precision floating-point number to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Byte.MaxValue" /> or less than <see cref="F:System.Byte.MinValue" />. </exception>
      byte ToByte(double value);

      /// <summary>Converts the value of the specified 16-bit signed integer to an equivalent 8-bit unsigned integer.</summary>
      /// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit signed integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />. </exception>
      byte ToByte(short value);

      /// <summary>Converts the value of the specified 32-bit signed integer to an equivalent 8-bit unsigned integer.</summary>
      /// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit signed integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />. </exception>
      byte ToByte(int value);

      /// <summary>Converts the value of the specified 64-bit signed integer to an equivalent 8-bit unsigned integer.</summary>
      /// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit signed integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />. </exception>
      byte ToByte(long value);

      /// <summary>Converts the value of the specified object to an 8-bit unsigned integer.</summary>
      /// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or null. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in the property format for a <see cref="T:System.Byte" /> value.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement <see cref="T:System.IConvertible" />. -or-Conversion from <paramref name="value" /> to the <see cref="T:System.Byte" /> type is not supported.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />.</exception>
      byte ToByte(object? value);

      /// <summary>Converts the value of the specified object to an 8-bit unsigned integer, using the specified culture-specific formatting information.</summary>
      /// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in the property format for a <see cref="T:System.Byte" /> value.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement <see cref="T:System.IConvertible" />. -or-Conversion from <paramref name="value" /> to the <see cref="T:System.Byte" /> type is not supported.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />.</exception>
      byte ToByte(object? value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified 8-bit signed integer to an equivalent 8-bit unsigned integer.</summary>
      /// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit signed integer to be converted. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than <see cref="F:System.Byte.MinValue" />. </exception>
      byte ToByte(sbyte value);

      /// <summary>Converts the value of the specified single-precision floating-point number to an equivalent 8-bit unsigned integer.</summary>
      /// <returns>
      /// <paramref name="value" />, rounded to the nearest 8-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
      /// <param name="value">A single-precision floating-point number. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Byte.MaxValue" /> or less than <see cref="F:System.Byte.MinValue" />. </exception>
      byte ToByte(float value);

      /// <summary>Converts the specified string representation of a number to an equivalent 8-bit unsigned integer.</summary>
      /// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />. </exception>
      byte ToByte(string? value);

      /// <summary>Converts the specified string representation of a number to an equivalent 8-bit unsigned integer, using specified culture-specific formatting information.</summary>
      /// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />. </exception>
      byte ToByte(string? value, IFormatProvider? provider);

      /// <summary>Converts the string representation of a number in a specified base to an equivalent 8-bit unsigned integer.</summary>
      /// <returns>An 8-bit unsigned integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <param name="fromBase">The base of the number in <paramref name="value" />, which must be 2, 8, 10, or 16. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="fromBase" /> is not 2, 8, 10, or 16. -or-<paramref name="value" />, which represents a non-base 10 unsigned number, is prefixed with a negative sign. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="value" /> is <see cref="F:System.String.Empty" />. </exception>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> contains a character that is not a valid digit in the base specified by <paramref name="fromBase" />. The exception message indicates that there are no digits to convert if the first character in <paramref name="value" /> is invalid; otherwise, the message indicates that <paramref name="value" /> contains invalid trailing characters.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" />, which represents a base 10 unsigned number, is prefixed with a negative sign.-or-<paramref name="value" /> represents a number that is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />.</exception>
      byte ToByte(string? value, int fromBase);

      /// <summary>Converts the value of the specified 16-bit unsigned integer to an equivalent 8-bit unsigned integer.</summary>
      /// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit unsigned integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Byte.MaxValue" />. </exception>
      byte ToByte(ushort value);

      /// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent 8-bit unsigned integer.</summary>
      /// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit unsigned integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Byte.MaxValue" />. </exception>
      byte ToByte(uint value);

      /// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent 8-bit unsigned integer.</summary>
      /// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit unsigned integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Byte.MaxValue" />. </exception>
      byte ToByte(ulong value);

      /// <summary>Converts the value of the specified 8-bit unsigned integer to its equivalent Unicode character.</summary>
      /// <returns>A Unicode character that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit unsigned integer to convert. </param>
      char ToChar(byte value);

      /// <summary>Converts the value of the specified 16-bit signed integer to its equivalent Unicode character.</summary>
      /// <returns>A Unicode character that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit signed integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than <see cref="F:System.Char.MinValue" />. </exception>
      char ToChar(short value);

      /// <summary>Converts the value of the specified 32-bit signed integer to its equivalent Unicode character.</summary>
      /// <returns>A Unicode character that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit signed integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than <see cref="F:System.Char.MinValue" /> or greater than <see cref="F:System.Char.MaxValue" />. </exception>
      char ToChar(int value);

      /// <summary>Converts the value of the specified 64-bit signed integer to its equivalent Unicode character.</summary>
      /// <returns>A Unicode character that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit signed integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than <see cref="F:System.Char.MinValue" /> or greater than <see cref="F:System.Char.MaxValue" />. </exception>
      char ToChar(long value);

      /// <summary>Converts the value of the specified object to a Unicode character.</summary>
      /// <returns>A Unicode character that is equivalent to value, or <see cref="F:System.Char.MinValue" /> if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="value" /> is a null string.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.-or-The conversion of <paramref name="value" /> to a <see cref="T:System.Char" /> is not supported. </exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than <see cref="F:System.Char.MinValue" /> or greater than <see cref="F:System.Char.MaxValue" />.</exception>
      char ToChar(object value);

      /// <summary>Converts the value of the specified object to its equivalent Unicode character, using the specified culture-specific formatting information.</summary>
      /// <returns>A Unicode character that is equivalent to <paramref name="value" />, or <see cref="F:System.Char.MinValue" /> if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="value" /> is a null string.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface. -or-The conversion of <paramref name="value" /> to a <see cref="T:System.Char" /> is not supported.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than <see cref="F:System.Char.MinValue" /> or greater than <see cref="F:System.Char.MaxValue" />.</exception>
      char ToChar(object value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified 8-bit signed integer to its equivalent Unicode character.</summary>
      /// <returns>A Unicode character that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit signed integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than <see cref="F:System.Char.MinValue" />. </exception>
      char ToChar(sbyte value);

      /// <summary>Converts the first character of a specified string to a Unicode character.</summary>
      /// <returns>A Unicode character that is equivalent to the first and only character in <paramref name="value" />.</returns>
      /// <param name="value">A string of length 1. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="value" /> is null. </exception>
      /// <exception cref="T:System.FormatException">The length of <paramref name="value" /> is not 1. </exception>
      char ToChar(string value);

      /// <summary>Converts the first character of a specified string to a Unicode character, using specified culture-specific formatting information.</summary>
      /// <returns>A Unicode character that is equivalent to the first and only character in <paramref name="value" />.</returns>
      /// <param name="value">A string of length 1 or null. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. This parameter is ignored.</param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="value" /> is null. </exception>
      /// <exception cref="T:System.FormatException">The length of <paramref name="value" /> is not 1. </exception>
      char ToChar(string value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified 16-bit unsigned integer to its equivalent Unicode character.</summary>
      /// <returns>A Unicode character that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit unsigned integer to convert. </param>
      char ToChar(ushort value);

      /// <summary>Converts the value of the specified 32-bit unsigned integer to its equivalent Unicode character.</summary>
      /// <returns>A Unicode character that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit unsigned integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Char.MaxValue" />. </exception>
      char ToChar(uint value);

      /// <summary>Converts the value of the specified 64-bit unsigned integer to its equivalent Unicode character.</summary>
      /// <returns>A Unicode character that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit unsigned integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Char.MaxValue" />. </exception>
      char ToChar(ulong value);

      /// <summary>Converts the value of the specified object to a <see cref="T:System.DateTime" /> object.</summary>
      /// <returns>The date and time equivalent of the value of <paramref name="value" />, or a date and time equivalent of <see cref="F:System.DateTime.MinValue" /> if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or null. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not a valid date and time value.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface. -or-The conversion is not supported.</exception>
      DateTime ToDateTime(object? value);

      /// <summary>Converts the value of the specified object to a <see cref="T:System.DateTime" /> object, using the specified culture-specific formatting information.</summary>
      /// <returns>The date and time equivalent of the value of <paramref name="value" />, or the date and time equivalent of <see cref="F:System.DateTime.MinValue" /> if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not a valid date and time value.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface. -or-The conversion is not supported.</exception>
      DateTime ToDateTime(object? value, IFormatProvider? provider);

      /// <summary>Converts the specified string representation of a date and time to an equivalent date and time value.</summary>
      /// <returns>The date and time equivalent of the value of <paramref name="value" />, or the date and time equivalent of <see cref="F:System.DateTime.MinValue" /> if <paramref name="value" /> is null.</returns>
      /// <param name="value">The string representation of a date and time.</param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not a properly formatted date and time string. </exception>
      DateTime ToDateTime(string? value);

      /// <summary>Converts the specified string representation of a number to an equivalent date and time, using the specified culture-specific formatting information.</summary>
      /// <returns>The date and time equivalent of the value of <paramref name="value" />, or the date and time equivalent of <see cref="F:System.DateTime.MinValue" /> if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains a date and time to convert. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not a properly formatted date and time string. </exception>
      DateTime ToDateTime(string? value, IFormatProvider? provider);

      /// <summary>Converts the specified Boolean value to the equivalent decimal number.</summary>
      /// <returns>The number 1 if <paramref name="value" /> is true; otherwise, 0.</returns>
      /// <param name="value">The Boolean value to convert. </param>
      decimal ToDecimal(bool value);

      /// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent decimal number.</summary>
      /// <returns>The decimal number that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit unsigned integer to convert. </param>
      decimal ToDecimal(byte value);

      /// <summary>Returns the specified decimal number; no actual conversion is performed.</summary>
      /// <returns>
      /// <paramref name="value" /> is returned unchanged.</returns>
      /// <param name="value">A decimal number. </param>
      decimal ToDecimal(decimal value);

      /// <summary>Converts the value of the specified double-precision floating-point number to an equivalent decimal number.</summary>
      /// <returns>A decimal number that is equivalent to <paramref name="value" />. </returns>
      /// <param name="value">The double-precision floating-point number to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Decimal.MaxValue" /> or less than <see cref="F:System.Decimal.MinValue" />. </exception>
      decimal ToDecimal(double value);

      /// <summary>Converts the value of the specified 16-bit signed integer to an equivalent decimal number.</summary>
      /// <returns>A decimal number that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit signed integer to convert. </param>
      decimal ToDecimal(short value);

      /// <summary>Converts the value of the specified 32-bit signed integer to an equivalent decimal number.</summary>
      /// <returns>A decimal number that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit signed integer to convert. </param>
      decimal ToDecimal(int value);

      /// <summary>Converts the value of the specified 64-bit signed integer to an equivalent decimal number.</summary>
      /// <returns>A decimal number that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit signed integer to convert. </param>
      decimal ToDecimal(long value);

      /// <summary>Converts the value of the specified object to an equivalent decimal number.</summary>
      /// <returns>A decimal number that is equivalent to <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or null. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in an appropriate format for a <see cref="T:System.Decimal" /> type.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface. -or-The conversion is not supported.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />.</exception>
      decimal ToDecimal(object? value);

      /// <summary>Converts the value of the specified object to an equivalent decimal number, using the specified culture-specific formatting information.</summary>
      /// <returns>A decimal number that is equivalent to <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in an appropriate format for a <see cref="T:System.Decimal" /> type.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.-or-The conversion is not supported. </exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />.</exception>
      decimal ToDecimal(object? value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified 8-bit signed integer to the equivalent decimal number.</summary>
      /// <returns>A decimal number that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit signed integer to convert. </param>
      decimal ToDecimal(sbyte value);

      /// <summary>Converts the value of the specified single-precision floating-point number to the equivalent decimal number.</summary>
      /// <returns>A decimal number that is equivalent to <paramref name="value" />. </returns>
      /// <param name="value">The single-precision floating-point number to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Decimal.MaxValue" /> or less than <see cref="F:System.Decimal.MinValue" />.</exception>
      decimal ToDecimal(float value);

      /// <summary>Converts the specified string representation of a number to an equivalent decimal number.</summary>
      /// <returns>A decimal number that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains a number to convert. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not a number in a valid format.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception>
      decimal ToDecimal(string? value);

      /// <summary>Converts the specified string representation of a number to an equivalent decimal number, using the specified culture-specific formatting information.</summary>
      /// <returns>A decimal number that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains a number to convert. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not a number in a valid format.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception>
      decimal ToDecimal(string? value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified 16-bit unsigned integer to an equivalent decimal number.</summary>
      /// <returns>The decimal number that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit unsigned integer to convert. </param>
      decimal ToDecimal(ushort value);

      /// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent decimal number.</summary>
      /// <returns>A decimal number that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit unsigned integer to convert. </param>
      decimal ToDecimal(uint value);

      /// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent decimal number.</summary>
      /// <returns>A decimal number that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit unsigned integer to convert. </param>
      decimal ToDecimal(ulong value);

      /// <summary>Converts the specified Boolean value to the equivalent double-precision floating-point number.</summary>
      /// <returns>The number 1 if <paramref name="value" /> is true; otherwise, 0.</returns>
      /// <param name="value">The Boolean value to convert. </param>
      double ToDouble(bool value);

      /// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent double-precision floating-point number.</summary>
      /// <returns>The double-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit unsigned integer to convert. </param>
      double ToDouble(byte value);

      /// <summary>Converts the value of the specified decimal number to an equivalent double-precision floating-point number.</summary>
      /// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The decimal number to convert. </param>
      double ToDouble(decimal value);

      /// <summary>Returns the specified double-precision floating-point number; no actual conversion is performed.</summary>
      /// <returns>
      /// <paramref name="value" /> is returned unchanged.</returns>
      /// <param name="value">The double-precision floating-point number to return. </param>
      double ToDouble(double value);

      /// <summary>Converts the value of the specified 16-bit signed integer to an equivalent double-precision floating-point number.</summary>
      /// <returns>A double-precision floating-point number equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit signed integer to convert. </param>
      double ToDouble(short value);

      /// <summary>Converts the value of the specified 32-bit signed integer to an equivalent double-precision floating-point number.</summary>
      /// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit signed integer to convert. </param>
      double ToDouble(int value);

      /// <summary>Converts the value of the specified 64-bit signed integer to an equivalent double-precision floating-point number.</summary>
      /// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit signed integer to convert. </param>
      double ToDouble(long value);

      /// <summary>Converts the value of the specified object to a double-precision floating-point number.</summary>
      /// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or null. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in an appropriate format for a <see cref="T:System.Double" /> type.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface. -or-The conversion is not supported.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Double.MinValue" /> or greater than <see cref="F:System.Double.MaxValue" />. </exception>
      double ToDouble(object? value);

      /// <summary>Converts the value of the specified object to an double-precision floating-point number, using the specified culture-specific formatting information.</summary>
      /// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in an appropriate format for a <see cref="T:System.Double" /> type.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface. </exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Double.MinValue" /> or greater than <see cref="F:System.Double.MaxValue" />. </exception>
      double ToDouble(object? value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified 8-bit signed integer to the equivalent double-precision floating-point number.</summary>
      /// <returns>The 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit signed integer to convert. </param>
      double ToDouble(sbyte value);

      /// <summary>Converts the value of the specified single-precision floating-point number to an equivalent double-precision floating-point number.</summary>
      /// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The single-precision floating-point number. </param>
      double ToDouble(float value);

      /// <summary>Converts the specified string representation of a number to an equivalent double-precision floating-point number.</summary>
      /// <returns>A double-precision floating-point number that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not a number in a valid format.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Double.MinValue" /> or greater than <see cref="F:System.Double.MaxValue" />. </exception>
      double ToDouble(string? value);

      /// <summary>Converts the specified string representation of a number to an equivalent double-precision floating-point number, using the specified culture-specific formatting information.</summary>
      /// <returns>A double-precision floating-point number that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not a number in a valid format.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Double.MinValue" /> or greater than <see cref="F:System.Double.MaxValue" />. </exception>
      double ToDouble(string? value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified 16-bit unsigned integer to the equivalent double-precision floating-point number.</summary>
      /// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit unsigned integer to convert. </param>
      double ToDouble(ushort value);

      /// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent double-precision floating-point number.</summary>
      /// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit unsigned integer to convert. </param>
      double ToDouble(uint value);

      /// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent double-precision floating-point number.</summary>
      /// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit unsigned integer to convert. </param>
      double ToDouble(ulong value);

      /// <summary>Converts the specified Boolean value to the equivalent 16-bit signed integer.</summary>
      /// <returns>The number 1 if <paramref name="value" /> is true; otherwise, 0.</returns>
      /// <param name="value">The Boolean value to convert. </param>
      short ToInt16(bool value);

      /// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent 16-bit signed integer.</summary>
      /// <returns>A 16-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit unsigned integer to convert. </param>
      short ToInt16(byte value);

      /// <summary>Converts the value of the specified Unicode character to the equivalent 16-bit signed integer.</summary>
      /// <returns>A 16-bit signed integer that is equivalent to <paramref name="value" />. </returns>
      /// <param name="value">The Unicode character to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" />. </exception>
      short ToInt16(char value);

      /// <summary>Converts the value of the specified decimal number to an equivalent 16-bit signed integer.</summary>
      /// <returns>
      /// <paramref name="value" />, rounded to the nearest 16-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
      /// <param name="value">The decimal number to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" /> or less than <see cref="F:System.Int16.MinValue" />. </exception>
      short ToInt16(decimal value);

      /// <summary>Converts the value of the specified double-precision floating-point number to an equivalent 16-bit signed integer.</summary>
      /// <returns>
      /// <paramref name="value" />, rounded to the nearest 16-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
      /// <param name="value">The double-precision floating-point number to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" /> or less than <see cref="F:System.Int16.MinValue" />. </exception>
      short ToInt16(double value);

      /// <summary>Returns the specified 16-bit signed integer; no actual conversion is performed.</summary>
      /// <returns>
      /// <paramref name="value" /> is returned unchanged.</returns>
      /// <param name="value">The 16-bit signed integer to return. </param>
      short ToInt16(short value);

      /// <summary>Converts the value of the specified 32-bit signed integer to an equivalent 16-bit signed integer.</summary>
      /// <returns>The 16-bit signed integer equivalent of <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit signed integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" /> or less than <see cref="F:System.Int16.MinValue" />. </exception>
      short ToInt16(int value);

      /// <summary>Converts the value of the specified 64-bit signed integer to an equivalent 16-bit signed integer.</summary>
      /// <returns>A 16-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit signed integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" /> or less than <see cref="F:System.Int16.MinValue" />. </exception>
      short ToInt16(long value);

      /// <summary>Converts the value of the specified object to a 16-bit signed integer.</summary>
      /// <returns>A 16-bit signed integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or null. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in an appropriate format for an <see cref="T:System.Int16" /> type.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface. -or-The conversion is not supported.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Int16.MinValue" /> or greater than <see cref="F:System.Int16.MaxValue" />.</exception>
      short ToInt16(object? value);

      /// <summary>Converts the value of the specified object to a 16-bit signed integer, using the specified culture-specific formatting information.</summary>
      /// <returns>A 16-bit signed integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in an appropriate format for an <see cref="T:System.Int16" /> type.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement <see cref="T:System.IConvertible" />. </exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Int16.MinValue" /> or greater than <see cref="F:System.Int16.MaxValue" />.</exception>
      short ToInt16(object? value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified 8-bit signed integer to the equivalent 16-bit signed integer.</summary>
      /// <returns>A 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit signed integer to convert. </param>
      short ToInt16(sbyte value);

      /// <summary>Converts the value of the specified single-precision floating-point number to an equivalent 16-bit signed integer.</summary>
      /// <returns>
      /// <paramref name="value" />, rounded to the nearest 16-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
      /// <param name="value">The single-precision floating-point number to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" /> or less than <see cref="F:System.Int16.MinValue" />. </exception>
      short ToInt16(float value);

      /// <summary>Converts the specified string representation of a number to an equivalent 16-bit signed integer.</summary>
      /// <returns>A 16-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Int16.MinValue" /> or greater than <see cref="F:System.Int16.MaxValue" />. </exception>
      short ToInt16(string? value);

      /// <summary>Converts the specified string representation of a number to an equivalent 16-bit signed integer, using the specified culture-specific formatting information.</summary>
      /// <returns>A 16-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Int16.MinValue" /> or greater than <see cref="F:System.Int16.MaxValue" />. </exception>
      short ToInt16(string? value, IFormatProvider? provider);

      /// <summary>Converts the string representation of a number in a specified base to an equivalent 16-bit signed integer.</summary>
      /// <returns>A 16-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <param name="fromBase">The base of the number in <paramref name="value" />, which must be 2, 8, 10, or 16. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="fromBase" /> is not 2, 8, 10, or 16. -or-<paramref name="value" />, which represents a non-base 10 signed number, is prefixed with a negative sign. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="value" /> is <see cref="F:System.String.Empty" />. </exception>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> contains a character that is not a valid digit in the base specified by <paramref name="fromBase" />. The exception message indicates that there are no digits to convert if the first character in <paramref name="value" /> is invalid; otherwise, the message indicates that <paramref name="value" /> contains invalid trailing characters.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" />, which represents a non-base 10 signed number, is prefixed with a negative sign.-or-<paramref name="value" /> represents a number that is less than <see cref="F:System.Int16.MinValue" /> or greater than <see cref="F:System.Int16.MaxValue" />.</exception>
      short ToInt16(string? value, int fromBase);

      /// <summary>Converts the value of the specified 16-bit unsigned integer to the equivalent 16-bit signed integer.</summary>
      /// <returns>A 16-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit unsigned integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" />. </exception>
      short ToInt16(ushort value);

      /// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent 16-bit signed integer.</summary>
      /// <returns>A 16-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit unsigned integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" />. </exception>
      short ToInt16(uint value);

      /// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent 16-bit signed integer.</summary>
      /// <returns>A 16-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit unsigned integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" />. </exception>
      short ToInt16(ulong value);

      /// <summary>Converts the specified Boolean value to the equivalent 32-bit signed integer.</summary>
      /// <returns>The number 1 if <paramref name="value" /> is true; otherwise, 0.</returns>
      /// <param name="value">The Boolean value to convert. </param>
      int ToInt32(bool value);

      /// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent 32-bit signed integer.</summary>
      /// <returns>A 32-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit unsigned integer to convert. </param>
      int ToInt32(byte value);

      /// <summary>Converts the value of the specified Unicode character to the equivalent 32-bit signed integer.</summary>
      /// <returns>A 32-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The Unicode character to convert. </param>
      int ToInt32(char value);

      /// <summary>Converts the value of the specified decimal number to an equivalent 32-bit signed integer.</summary>
      /// <returns>
      /// <paramref name="value" />, rounded to the nearest 32-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
      /// <param name="value">The decimal number to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Int32.MaxValue" /> or less than <see cref="F:System.Int32.MinValue" />. </exception>
      int ToInt32(decimal value);

      /// <summary>Converts the value of the specified double-precision floating-point number to an equivalent 32-bit signed integer.</summary>
      /// <returns>
      /// <paramref name="value" />, rounded to the nearest 32-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
      /// <param name="value">The double-precision floating-point number to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Int32.MaxValue" /> or less than <see cref="F:System.Int32.MinValue" />. </exception>
      int ToInt32(double value);

      /// <summary>Converts the value of the specified 16-bit signed integer to an equivalent 32-bit signed integer.</summary>
      /// <returns>A 32-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit signed integer to convert. </param>
      int ToInt32(short value);

      /// <summary>Returns the specified 32-bit signed integer; no actual conversion is performed.</summary>
      /// <returns>
      /// <paramref name="value" /> is returned unchanged.</returns>
      /// <param name="value">The 32-bit signed integer to return. </param>
      int ToInt32(int value);

      /// <summary>Converts the value of the specified 64-bit signed integer to an equivalent 32-bit signed integer.</summary>
      /// <returns>A 32-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit signed integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Int32.MaxValue" /> or less than <see cref="F:System.Int32.MinValue" />. </exception>
      int ToInt32(long value);

      /// <summary>Converts the value of the specified object to a 32-bit signed integer.</summary>
      /// <returns>A 32-bit signed integer equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or null. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in an appropriate format.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement the  <see cref="T:System.IConvertible" /> interface. -or-The conversion is not supported.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />.</exception>
      int ToInt32(object? value);

      /// <summary>Converts the value of the specified object to a 32-bit signed integer, using the specified culture-specific formatting information.</summary>
      /// <returns>A 32-bit signed integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in an appropriate format.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement <see cref="T:System.IConvertible" />. </exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />.</exception>
      int ToInt32(object? value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified 8-bit signed integer to the equivalent 32-bit signed integer.</summary>
      /// <returns>A 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit signed integer to convert. </param>
      int ToInt32(sbyte value);

      /// <summary>Converts the value of the specified single-precision floating-point number to an equivalent 32-bit signed integer.</summary>
      /// <returns>
      /// <paramref name="value" />, rounded to the nearest 32-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
      /// <param name="value">The single-precision floating-point number to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Int32.MaxValue" /> or less than <see cref="F:System.Int32.MinValue" />. </exception>
      int ToInt32(float value);

      /// <summary>Converts the specified string representation of a number to an equivalent 32-bit signed integer.</summary>
      /// <returns>A 32-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />. </exception>
      int ToInt32(string? value);

      /// <summary>Converts the specified string representation of a number to an equivalent 32-bit signed integer, using the specified culture-specific formatting information.</summary>
      /// <returns>A 32-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />. </exception>
      int ToInt32(string? value, IFormatProvider? provider);

      /// <summary>Converts the string representation of a number in a specified base to an equivalent 32-bit signed integer.</summary>
      /// <returns>A 32-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <param name="fromBase">The base of the number in <paramref name="value" />, which must be 2, 8, 10, or 16. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="fromBase" /> is not 2, 8, 10, or 16. -or-<paramref name="value" />, which represents a non-base 10 signed number, is prefixed with a negative sign. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="value" /> is <see cref="F:System.String.Empty" />. </exception>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> contains a character that is not a valid digit in the base specified by <paramref name="fromBase" />. The exception message indicates that there are no digits to convert if the first character in <paramref name="value" /> is invalid; otherwise, the message indicates that <paramref name="value" /> contains invalid trailing characters.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" />, which represents a non-base 10 signed number, is prefixed with a negative sign.-or-<paramref name="value" /> represents a number that is less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />.</exception>
      int ToInt32(string? value, int fromBase);

      /// <summary>Converts the value of the specified 16-bit unsigned integer to the equivalent 32-bit signed integer.</summary>
      /// <returns>A 32-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit unsigned integer to convert. </param>
      int ToInt32(ushort value);

      /// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent 32-bit signed integer.</summary>
      /// <returns>A 32-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit unsigned integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
      int ToInt32(uint value);

      /// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent 32-bit signed integer.</summary>
      /// <returns>A 32-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit unsigned integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
      int ToInt32(ulong value);

      /// <summary>Converts the specified Boolean value to the equivalent 64-bit signed integer.</summary>
      /// <returns>The number 1 if <paramref name="value" /> is true; otherwise, 0.</returns>
      /// <param name="value">The Boolean value to convert. </param>
      long ToInt64(bool value);

      /// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent 64-bit signed integer.</summary>
      /// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit unsigned integer to convert. </param>
      long ToInt64(byte value);

      /// <summary>Converts the value of the specified Unicode character to the equivalent 64-bit signed integer.</summary>
      /// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The Unicode character to convert. </param>
      long ToInt64(char value);

      /// <summary>Converts the value of the specified decimal number to an equivalent 64-bit signed integer.</summary>
      /// <returns>
      /// <paramref name="value" />, rounded to the nearest 64-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
      /// <param name="value">The decimal number to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Int64.MaxValue" /> or less than <see cref="F:System.Int64.MinValue" />. </exception>
      long ToInt64(decimal value);

      /// <summary>Converts the value of the specified double-precision floating-point number to an equivalent 64-bit signed integer.</summary>
      /// <returns>
      /// <paramref name="value" />, rounded to the nearest 64-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
      /// <param name="value">The double-precision floating-point number to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Int64.MaxValue" /> or less than <see cref="F:System.Int64.MinValue" />. </exception>
      long ToInt64(double value);

      /// <summary>Converts the value of the specified 16-bit signed integer to an equivalent 64-bit signed integer.</summary>
      /// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit signed integer to convert. </param>
      long ToInt64(short value);

      /// <summary>Converts the value of the specified 32-bit signed integer to an equivalent 64-bit signed integer.</summary>
      /// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit signed integer to convert. </param>
      long ToInt64(int value);

      /// <summary>Returns the specified 64-bit signed integer; no actual conversion is performed.</summary>
      /// <returns>
      /// <paramref name="value" /> is returned unchanged.</returns>
      /// <param name="value">A 64-bit signed integer. </param>
      long ToInt64(long value);

      /// <summary>Converts the value of the specified object to a 64-bit signed integer.</summary>
      /// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or null. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in an appropriate format.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface. -or-The conversion is not supported.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />.</exception>
      long ToInt64(object? value);

      /// <summary>Converts the value of the specified object to a 64-bit signed integer, using the specified culture-specific formatting information.</summary>
      /// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in an appropriate format.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.-or-The conversion is not supported. </exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />.</exception>
      long ToInt64(object? value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified 8-bit signed integer to the equivalent 64-bit signed integer.</summary>
      /// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit signed integer to convert. </param>
      long ToInt64(sbyte value);

      /// <summary>Converts the value of the specified single-precision floating-point number to an equivalent 64-bit signed integer.</summary>
      /// <returns>
      /// <paramref name="value" />, rounded to the nearest 64-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
      /// <param name="value">The single-precision floating-point number to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Int64.MaxValue" /> or less than <see cref="F:System.Int64.MinValue" />. </exception>
      long ToInt64(float value);

      /// <summary>Converts the specified string representation of a number to an equivalent 64-bit signed integer.</summary>
      /// <returns>A 64-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains a number to convert. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />. </exception>
      long ToInt64(string? value);

      /// <summary>Converts the specified string representation of a number to an equivalent 64-bit signed integer, using the specified culture-specific formatting information.</summary>
      /// <returns>A 64-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />. </exception>
      long ToInt64(string? value, IFormatProvider? provider);

      /// <summary>Converts the string representation of a number in a specified base to an equivalent 64-bit signed integer.</summary>
      /// <returns>A 64-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <param name="fromBase">The base of the number in <paramref name="value" />, which must be 2, 8, 10, or 16. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="fromBase" /> is not 2, 8, 10, or 16. -or-<paramref name="value" />, which represents a non-base 10 signed number, is prefixed with a negative sign. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="value" /> is <see cref="F:System.String.Empty" />. </exception>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> contains a character that is not a valid digit in the base specified by <paramref name="fromBase" />. The exception message indicates that there are no digits to convert if the first character in <paramref name="value" /> is invalid; otherwise, the message indicates that <paramref name="value" /> contains invalid trailing characters.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" />, which represents a non-base 10 signed number, is prefixed with a negative sign.-or-<paramref name="value" /> represents a number that is less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />.</exception>
      long ToInt64(string? value, int fromBase);

      /// <summary>Converts the value of the specified 16-bit unsigned integer to the equivalent 64-bit signed integer.</summary>
      /// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit unsigned integer to convert. </param>
      long ToInt64(ushort value);

      /// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent 64-bit signed integer.</summary>
      /// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit unsigned integer to convert. </param>
      long ToInt64(uint value);

      /// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent 64-bit signed integer.</summary>
      /// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit unsigned integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.Int64.MaxValue" />. </exception>
      long ToInt64(ulong value);

      /// <summary>Converts the specified Boolean value to the equivalent 8-bit signed integer.</summary>
      /// <returns>The number 1 if <paramref name="value" /> is true; otherwise, 0.</returns>
      /// <param name="value">The Boolean value to convert. </param>
      sbyte ToSByte(bool value);

      /// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent 8-bit signed integer.</summary>
      /// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit unsigned integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" />. </exception>
      sbyte ToSByte(byte value);

      /// <summary>Converts the value of the specified Unicode character to the equivalent 8-bit signed integer.</summary>
      /// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The Unicode character to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" />. </exception>
      sbyte ToSByte(char value);

      /// <summary>Converts the value of the specified decimal number to an equivalent 8-bit signed integer.</summary>
      /// <returns>
      /// <paramref name="value" />, rounded to the nearest 8-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
      /// <param name="value">The decimal number to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />. </exception>
      sbyte ToSByte(decimal value);

      /// <summary>Converts the value of the specified double-precision floating-point number to an equivalent 8-bit signed integer.</summary>
      /// <returns>
      /// <paramref name="value" />, rounded to the nearest 8-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
      /// <param name="value">The double-precision floating-point number to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />. </exception>
      sbyte ToSByte(double value);

      /// <summary>Converts the value of the specified 16-bit signed integer to the equivalent 8-bit signed integer.</summary>
      /// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit signed integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />. </exception>
      sbyte ToSByte(short value);

      /// <summary>Converts the value of the specified 32-bit signed integer to an equivalent 8-bit signed integer.</summary>
      /// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit signed integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />. </exception>
      sbyte ToSByte(int value);

      /// <summary>Converts the value of the specified 64-bit signed integer to an equivalent 8-bit signed integer.</summary>
      /// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit signed integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />. </exception>
      sbyte ToSByte(long value);

      /// <summary>Converts the value of the specified object to an 8-bit signed integer.</summary>
      /// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or null. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in an appropriate format. </exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface. -or-The conversion is not supported.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />.</exception>
      sbyte ToSByte(object? value);

      /// <summary>Converts the value of the specified object to an 8-bit signed integer, using the specified culture-specific formatting information.</summary>
      /// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in an appropriate format. </exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface. -or-The conversion is not supported.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />.</exception>
      sbyte ToSByte(object? value, IFormatProvider? provider);

      /// <summary>Returns the specified 8-bit signed integer; no actual conversion is performed.</summary>
      /// <returns>
      /// <paramref name="value" /> is returned unchanged.</returns>
      /// <param name="value">The 8-bit signed integer to return. </param>
      sbyte ToSByte(sbyte value);

      /// <summary>Converts the value of the specified single-precision floating-point number to an equivalent 8-bit signed integer.</summary>
      /// <returns>
      /// <paramref name="value" />, rounded to the nearest 8-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
      /// <param name="value">The single-precision floating-point number to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />. </exception>
      sbyte ToSByte(float value);

      /// <summary>Converts the specified string representation of a number to an equivalent 8-bit signed integer.</summary>
      /// <returns>An 8-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if value is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />. </exception>
      sbyte ToSByte(string? value);

      /// <summary>Converts the specified string representation of a number to an equivalent 8-bit signed integer, using the specified culture-specific formatting information.</summary>
      /// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="value" /> is null. </exception>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />. </exception>
      sbyte ToSByte(string? value, IFormatProvider? provider);

      /// <summary>Converts the string representation of a number in a specified base to an equivalent 8-bit signed integer.</summary>
      /// <returns>An 8-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <param name="fromBase">The base of the number in <paramref name="value" />, which must be 2, 8, 10, or 16. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="fromBase" /> is not 2, 8, 10, or 16. -or-<paramref name="value" />, which represents a non-base 10 signed number, is prefixed with a negative sign. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="value" /> is <see cref="F:System.String.Empty" />. </exception>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> contains a character that is not a valid digit in the base specified by <paramref name="fromBase" />. The exception message indicates that there are no digits to convert if the first character in <paramref name="value" /> is invalid; otherwise, the message indicates that <paramref name="value" /> contains invalid trailing characters.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" />, which represents a non-base 10 signed number, is prefixed with a negative sign.-or-<paramref name="value" /> represents a number that is less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />.</exception>
      sbyte ToSByte(string? value, int fromBase);

      /// <summary>Converts the value of the specified 16-bit unsigned integer to the equivalent 8-bit signed integer.</summary>
      /// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit unsigned integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" />. </exception>
      sbyte ToSByte(ushort value);

      /// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent 8-bit signed integer.</summary>
      /// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit unsigned integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />. </exception>
      sbyte ToSByte(uint value);

      /// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent 8-bit signed integer.</summary>
      /// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit unsigned integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />. </exception>
      sbyte ToSByte(ulong value);

      /// <summary>Converts the specified Boolean value to the equivalent single-precision floating-point number.</summary>
      /// <returns>The number 1 if <paramref name="value" /> is true; otherwise, 0.</returns>
      /// <param name="value">The Boolean value to convert. </param>
      float ToSingle(bool value);

      /// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent single-precision floating-point number.</summary>
      /// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit unsigned integer to convert. </param>
      float ToSingle(byte value);

      /// <summary>Converts the value of the specified decimal number to an equivalent single-precision floating-point number.</summary>
      /// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.<paramref name="value" /> is rounded using rounding to nearest. For example, when rounded to two decimals, the value 2.345 becomes 2.34 and the value 2.355 becomes 2.36.</returns>
      /// <param name="value">The decimal number to convert. </param>
      float ToSingle(decimal value);

      /// <summary>Converts the value of the specified double-precision floating-point number to an equivalent single-precision floating-point number.</summary>
      /// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.<paramref name="value" /> is rounded using rounding to nearest. For example, when rounded to two decimals, the value 2.345 becomes 2.34 and the value 2.355 becomes 2.36.</returns>
      /// <param name="value">The double-precision floating-point number to convert. </param>
      float ToSingle(double value);

      /// <summary>Converts the value of the specified 16-bit signed integer to an equivalent single-precision floating-point number.</summary>
      /// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit signed integer to convert. </param>
      float ToSingle(short value);

      /// <summary>Converts the value of the specified 32-bit signed integer to an equivalent single-precision floating-point number.</summary>
      /// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit signed integer to convert. </param>
      float ToSingle(int value);

      /// <summary>Converts the value of the specified 64-bit signed integer to an equivalent single-precision floating-point number.</summary>
      /// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit signed integer to convert. </param>
      float ToSingle(long value);

      /// <summary>Converts the value of the specified object to a single-precision floating-point number.</summary>
      /// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or null. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in an appropriate format.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface. -or-The conversion is not supported.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Single.MinValue" /> or greater than <see cref="F:System.Single.MaxValue" />.</exception>
      float ToSingle(object? value);

      /// <summary>Converts the value of the specified object to an single-precision floating-point number, using the specified culture-specific formatting information.</summary>
      /// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in an appropriate format.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement <see cref="T:System.IConvertible" />. </exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Single.MinValue" /> or greater than <see cref="F:System.Single.MaxValue" />.</exception>
      float ToSingle(object? value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified 8-bit signed integer to the equivalent single-precision floating-point number.</summary>
      /// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit signed integer to convert. </param>
      float ToSingle(sbyte value);

      /// <summary>Returns the specified single-precision floating-point number; no actual conversion is performed.</summary>
      /// <returns>
      /// <paramref name="value" /> is returned unchanged.</returns>
      /// <param name="value">The single-precision floating-point number to return. </param>
      float ToSingle(float value);

      /// <summary>Converts the specified string representation of a number to an equivalent single-precision floating-point number.</summary>
      /// <returns>A single-precision floating-point number that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not a number in a valid format.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Single.MinValue" /> or greater than <see cref="F:System.Single.MaxValue" />. </exception>
      float ToSingle(string? value);

      /// <summary>Converts the specified string representation of a number to an equivalent single-precision floating-point number, using the specified culture-specific formatting information.</summary>
      /// <returns>A single-precision floating-point number that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not a number in a valid format.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.Single.MinValue" /> or greater than <see cref="F:System.Single.MaxValue" />. </exception>
      float ToSingle(string? value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified 16-bit unsigned integer to the equivalent single-precision floating-point number.</summary>
      /// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit unsigned integer to convert. </param>
      float ToSingle(ushort value);

      /// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent single-precision floating-point number.</summary>
      /// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit unsigned integer to convert. </param>
      float ToSingle(uint value);

      /// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent single-precision floating-point number.</summary>
      /// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit unsigned integer to convert. </param>
      float ToSingle(ulong value);

      /// <summary>Converts the specified Boolean value to its equivalent string representation.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The Boolean value to convert. </param>
      string ToString(bool value);

      /// <summary>Converts the specified Boolean value to its equivalent string representation.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The Boolean value to convert. </param>
      /// <param name="provider">An instance of an object. This parameter is ignored.</param>
      string ToString(bool value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified 8-bit unsigned integer to its equivalent string representation.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit unsigned integer to convert. </param>
      string ToString(byte value);

      /// <summary>Converts the value of the specified 8-bit unsigned integer to its equivalent string representation, using the specified culture-specific formatting information.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit unsigned integer to convert. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      string ToString(byte value, IFormatProvider? provider);

      /// <summary>Converts the value of an 8-bit unsigned integer to its equivalent string representation in a specified base.</summary>
      /// <returns>The string representation of <paramref name="value" /> in base <paramref name="toBase" />.</returns>
      /// <param name="value">The 8-bit unsigned integer to convert. </param>
      /// <param name="toBase">The base of the return value, which must be 2, 8, 10, or 16. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="toBase" /> is not 2, 8, 10, or 16. </exception>
      string ToString(byte value, int toBase);

      /// <summary>Converts the value of the specified Unicode character to its equivalent string representation.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The Unicode character to convert. </param>
      string ToString(char value);

      /// <summary>Converts the value of the specified Unicode character to its equivalent string representation, using the specified culture-specific formatting information.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The Unicode character to convert. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. This parameter is ignored. </param>
      string ToString(char value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified <see cref="T:System.DateTime" /> to its equivalent string representation.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The date and time value to convert. </param>
      string ToString(DateTime value);

      /// <summary>Converts the value of the specified <see cref="T:System.DateTime" /> to its equivalent string representation, using the specified culture-specific formatting information.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The date and time value to convert. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      string ToString(DateTime value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified decimal number to its equivalent string representation.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The decimal number to convert. </param>
      string ToString(decimal value);

      /// <summary>Converts the value of the specified decimal number to its equivalent string representation, using the specified culture-specific formatting information.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The decimal number to convert. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      string ToString(decimal value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified double-precision floating-point number to its equivalent string representation.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The double-precision floating-point number to convert. </param>
      string ToString(double value);

      /// <summary>Converts the value of the specified double-precision floating-point number to its equivalent string representation.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The double-precision floating-point number to convert. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      string ToString(double value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified 16-bit signed integer to its equivalent string representation.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit signed integer to convert. </param>
      string ToString(short value);

      /// <summary>Converts the value of the specified 16-bit signed integer to its equivalent string representation, using the specified culture-specific formatting information.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit signed integer to convert. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      string ToString(short value, IFormatProvider? provider);

      /// <summary>Converts the value of a 16-bit signed integer to its equivalent string representation in a specified base.</summary>
      /// <returns>The string representation of <paramref name="value" /> in base <paramref name="toBase" />.</returns>
      /// <param name="value">The 16-bit signed integer to convert. </param>
      /// <param name="toBase">The base of the return value, which must be 2, 8, 10, or 16. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="toBase" /> is not 2, 8, 10, or 16. </exception>
      string ToString(short value, int toBase);

      /// <summary>Converts the value of the specified 32-bit signed integer to its equivalent string representation.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit signed integer to convert. </param>
      string ToString(int value);

      /// <summary>Converts the value of the specified 32-bit signed integer to its equivalent string representation, using the specified culture-specific formatting information.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit signed integer to convert. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      string ToString(int value, IFormatProvider? provider);

      /// <summary>Converts the value of a 32-bit signed integer to its equivalent string representation in a specified base.</summary>
      /// <returns>The string representation of <paramref name="value" /> in base <paramref name="toBase" />.</returns>
      /// <param name="value">The 32-bit signed integer to convert. </param>
      /// <param name="toBase">The base of the return value, which must be 2, 8, 10, or 16. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="toBase" /> is not 2, 8, 10, or 16. </exception>
      string ToString(int value, int toBase);

      /// <summary>Converts the value of the specified 64-bit signed integer to its equivalent string representation.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit signed integer to convert. </param>
      string ToString(long value);

      /// <summary>Converts the value of the specified 64-bit signed integer to its equivalent string representation, using the specified culture-specific formatting information.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit signed integer to convert. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      string ToString(long value, IFormatProvider? provider);

      /// <summary>Converts the value of a 64-bit signed integer to its equivalent string representation in a specified base.</summary>
      /// <returns>The string representation of <paramref name="value" /> in base <paramref name="toBase" />.</returns>
      /// <param name="value">The 64-bit signed integer to convert. </param>
      /// <param name="toBase">The base of the return value, which must be 2, 8, 10, or 16. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="toBase" /> is not 2, 8, 10, or 16. </exception>
      string ToString(long value, int toBase);

      /// <summary>Converts the value of the specified object to its equivalent string representation.</summary>
      /// <returns>The string representation of <paramref name="value" />, or <see cref="F:System.String.Empty" /> if <paramref name="value" /> is an object whose value is null. If <paramref name="value" /> is null, the method returns null.</returns>
      /// <param name="value">An object that supplies the value to convert, or null. </param>
      string? ToString(object? value);

      /// <summary>Converts the value of the specified object to its equivalent string representation using the specified culture-specific formatting information.</summary>
      /// <returns>The string representation of <paramref name="value" />, or <see cref="F:System.String.Empty" /> if <paramref name="value" /> is an object whose value is null. If <paramref name="value" /> is null, the method returns null. </returns>
      /// <param name="value">An object that supplies the value to convert, or null. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      string? ToString(object? value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified 8-bit signed integer to its equivalent string representation.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit signed integer to convert. </param>
      string ToString(sbyte value);

      /// <summary>Converts the value of the specified 8-bit signed integer to its equivalent string representation, using the specified culture-specific formatting information.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit signed integer to convert. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      string ToString(sbyte value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified single-precision floating-point number to its equivalent string representation.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The single-precision floating-point number to convert. </param>
      string ToString(float value);

      /// <summary>Converts the value of the specified single-precision floating-point number to its equivalent string representation, using the specified culture-specific formatting information.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The single-precision floating-point number to convert. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      string ToString(float value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified 16-bit unsigned integer to its equivalent string representation.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit unsigned integer to convert. </param>
      string ToString(ushort value);

      /// <summary>Converts the value of the specified 16-bit unsigned integer to its equivalent string representation, using the specified culture-specific formatting information.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit unsigned integer to convert. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      string ToString(ushort value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified 32-bit unsigned integer to its equivalent string representation.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit unsigned integer to convert. </param>
      string ToString(uint value);

      /// <summary>Converts the value of the specified 32-bit unsigned integer to its equivalent string representation, using the specified culture-specific formatting information.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit unsigned integer to convert. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      string ToString(uint value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified 64-bit unsigned integer to its equivalent string representation.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit unsigned integer to convert. </param>
      string ToString(ulong value);

      /// <summary>Converts the value of the specified 64-bit unsigned integer to its equivalent string representation, using the specified culture-specific formatting information.</summary>
      /// <returns>The string representation of <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit unsigned integer to convert. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      string ToString(ulong value, IFormatProvider? provider);

      /// <summary>Converts the specified Boolean value to the equivalent 16-bit unsigned integer.</summary>
      /// <returns>The number 1 if <paramref name="value" /> is true; otherwise, 0.</returns>
      /// <param name="value">The Boolean value to convert. </param>
      ushort ToUInt16(bool value);

      /// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent 16-bit unsigned integer.</summary>
      /// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit unsigned integer to convert. </param>
      ushort ToUInt16(byte value);

      /// <summary>Converts the value of the specified Unicode character to the equivalent 16-bit unsigned integer.</summary>
      /// <returns>The 16-bit unsigned integer equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The Unicode character to convert. </param>
      ushort ToUInt16(char value);

      /// <summary>Converts the value of the specified decimal number to an equivalent 16-bit unsigned integer.</summary>
      /// <returns>
      /// <paramref name="value" />, rounded to the nearest 16-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
      /// <param name="value">The decimal number to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt16.MaxValue" />. </exception>
      ushort ToUInt16(decimal value);

      /// <summary>Converts the value of the specified double-precision floating-point number to an equivalent 16-bit unsigned integer.</summary>
      /// <returns>
      /// <paramref name="value" />, rounded to the nearest 16-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
      /// <param name="value">The double-precision floating-point number to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt16.MaxValue" />. </exception>
      ushort ToUInt16(double value);

      /// <summary>Converts the value of the specified 16-bit signed integer to the equivalent 16-bit unsigned integer.</summary>
      /// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit signed integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than zero. </exception>
      ushort ToUInt16(short value);

      /// <summary>Converts the value of the specified 32-bit signed integer to an equivalent 16-bit unsigned integer.</summary>
      /// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit signed integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt16.MaxValue" />. </exception>
      ushort ToUInt16(int value);

      /// <summary>Converts the value of the specified 64-bit signed integer to an equivalent 16-bit unsigned integer.</summary>
      /// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit signed integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt16.MaxValue" />. </exception>
      ushort ToUInt16(long value);

      /// <summary>Converts the value of the specified object to a 16-bit unsigned integer.</summary>
      /// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or null. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in an appropriate format.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement the  <see cref="T:System.IConvertible" /> interface. -or-The conversion is not supported.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt16.MinValue" /> or greater than <see cref="F:System.UInt16.MaxValue" />.</exception>
      ushort ToUInt16(object? value);

      /// <summary>Converts the value of the specified object to a 16-bit unsigned integer, using the specified culture-specific formatting information.</summary>
      /// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in an appropriate format.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement the  <see cref="T:System.IConvertible" /> interface. -or-The conversion is not supported.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt16.MinValue" /> or greater than <see cref="F:System.UInt16.MaxValue" />.</exception>
      ushort ToUInt16(object? value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified 8-bit signed integer to the equivalent 16-bit unsigned integer.</summary>
      /// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit signed integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than zero. </exception>
      ushort ToUInt16(sbyte value);

      /// <summary>Converts the value of the specified single-precision floating-point number to an equivalent 16-bit unsigned integer.</summary>
      /// <returns>
      /// <paramref name="value" />, rounded to the nearest 16-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
      /// <param name="value">The single-precision floating-point number to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt16.MaxValue" />. </exception>
      ushort ToUInt16(float value);

      /// <summary>Converts the specified string representation of a number to an equivalent 16-bit unsigned integer.</summary>
      /// <returns>A 16-bit unsigned integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt16.MinValue" /> or greater than <see cref="F:System.UInt16.MaxValue" />. </exception>
      ushort ToUInt16(string? value);

      /// <summary>Converts the specified string representation of a number to an equivalent 16-bit unsigned integer, using the specified culture-specific formatting information.</summary>
      /// <returns>A 16-bit unsigned integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt16.MinValue" /> or greater than <see cref="F:System.UInt16.MaxValue" />. </exception>
      ushort ToUInt16(string? value, IFormatProvider? provider);

      /// <summary>Converts the string representation of a number in a specified base to an equivalent 16-bit unsigned integer.</summary>
      /// <returns>A 16-bit unsigned integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <param name="fromBase">The base of the number in <paramref name="value" />, which must be 2, 8, 10, or 16. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="fromBase" /> is not 2, 8, 10, or 16. -or-<paramref name="value" />, which represents a non-base 10 unsigned number, is prefixed with a negative sign. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="value" /> is <see cref="F:System.String.Empty" />. </exception>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> contains a character that is not a valid digit in the base specified by <paramref name="fromBase" />. The exception message indicates that there are no digits to convert if the first character in <paramref name="value" /> is invalid; otherwise, the message indicates that <paramref name="value" /> contains invalid trailing characters.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" />, which represents a non-base 10 unsigned number, is prefixed with a negative sign.-or-<paramref name="value" /> represents a number that is less than <see cref="F:System.UInt16.MinValue" /> or greater than <see cref="F:System.UInt16.MaxValue" />.</exception>
      ushort ToUInt16(string? value, int fromBase);

      /// <summary>Returns the specified 16-bit unsigned integer; no actual conversion is performed.</summary>
      /// <returns>
      /// <paramref name="value" /> is returned unchanged.</returns>
      /// <param name="value">The 16-bit unsigned integer to return. </param>
      ushort ToUInt16(ushort value);

      /// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent 16-bit unsigned integer.</summary>
      /// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit unsigned integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.UInt16.MaxValue" />. </exception>
      ushort ToUInt16(uint value);

      /// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent 16-bit unsigned integer.</summary>
      /// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit unsigned integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.UInt16.MaxValue" />. </exception>
      ushort ToUInt16(ulong value);

      /// <summary>Converts the specified Boolean value to the equivalent 32-bit unsigned integer.</summary>
      /// <returns>The number 1 if <paramref name="value" /> is true; otherwise, 0.</returns>
      /// <param name="value">The Boolean value to convert. </param>
      uint ToUInt32(bool value);

      /// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent 32-bit unsigned integer.</summary>
      /// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit unsigned integer to convert. </param>
      uint ToUInt32(byte value);

      /// <summary>Converts the value of the specified Unicode character to the equivalent 32-bit unsigned integer.</summary>
      /// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The Unicode character to convert. </param>
      uint ToUInt32(char value);

      /// <summary>Converts the value of the specified decimal number to an equivalent 32-bit unsigned integer.</summary>
      /// <returns>
      /// <paramref name="value" />, rounded to the nearest 32-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
      /// <param name="value">The decimal number to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt32.MaxValue" />. </exception>
      uint ToUInt32(decimal value);

      /// <summary>Converts the value of the specified double-precision floating-point number to an equivalent 32-bit unsigned integer.</summary>
      /// <returns>
      /// <paramref name="value" />, rounded to the nearest 32-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
      /// <param name="value">The double-precision floating-point number to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt32.MaxValue" />. </exception>
      uint ToUInt32(double value);

      /// <summary>Converts the value of the specified 16-bit signed integer to the equivalent 32-bit unsigned integer.</summary>
      /// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit signed integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than zero. </exception>
      uint ToUInt32(short value);

      /// <summary>Converts the value of the specified 32-bit signed integer to an equivalent 32-bit unsigned integer.</summary>
      /// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit signed integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than zero. </exception>
      uint ToUInt32(int value);

      /// <summary>Converts the value of the specified 64-bit signed integer to an equivalent 32-bit unsigned integer.</summary>
      /// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit signed integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt32.MaxValue" />. </exception>
      uint ToUInt32(long value);

      /// <summary>Converts the value of the specified object to a 32-bit unsigned integer.</summary>
      /// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or null. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in an appropriate format.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface. -or-The conversion is not supported.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt32.MinValue" /> or greater than <see cref="F:System.UInt32.MaxValue" />.</exception>
      uint ToUInt32(object? value);

      /// <summary>Converts the value of the specified object to a 32-bit unsigned integer, using the specified culture-specific formatting information.</summary>
      /// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in an appropriate format.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface. -or-The conversion is not supported.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt32.MinValue" /> or greater than <see cref="F:System.UInt32.MaxValue" />.</exception>
      uint ToUInt32(object? value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified 8-bit signed integer to the equivalent 32-bit unsigned integer.</summary>
      /// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit signed integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than zero. </exception>
      uint ToUInt32(sbyte value);

      /// <summary>Converts the value of the specified single-precision floating-point number to an equivalent 32-bit unsigned integer.</summary>
      /// <returns>
      /// <paramref name="value" />, rounded to the nearest 32-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
      /// <param name="value">The single-precision floating-point number to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt32.MaxValue" />. </exception>
      uint ToUInt32(float value);

      /// <summary>Converts the specified string representation of a number to an equivalent 32-bit unsigned integer.</summary>
      /// <returns>A 32-bit unsigned integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt32.MinValue" /> or greater than <see cref="F:System.UInt32.MaxValue" />. </exception>
      uint ToUInt32(string? value);

      /// <summary>Converts the specified string representation of a number to an equivalent 32-bit unsigned integer, using the specified culture-specific formatting information.</summary>
      /// <returns>A 32-bit unsigned integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt32.MinValue" /> or greater than <see cref="F:System.UInt32.MaxValue" />. </exception>
      uint ToUInt32(string? value, IFormatProvider? provider);

      /// <summary>Converts the string representation of a number in a specified base to an equivalent 32-bit unsigned integer.</summary>
      /// <returns>A 32-bit unsigned integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <param name="fromBase">The base of the number in <paramref name="value" />, which must be 2, 8, 10, or 16. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="fromBase" /> is not 2, 8, 10, or 16. -or-<paramref name="value" />, which represents a non-base 10 unsigned number, is prefixed with a negative sign. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="value" /> is <see cref="F:System.String.Empty" />. </exception>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> contains a character that is not a valid digit in the base specified by <paramref name="fromBase" />. The exception message indicates that there are no digits to convert if the first character in <paramref name="value" /> is invalid; otherwise, the message indicates that <paramref name="value" /> contains invalid trailing characters.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" />, which represents a non-base 10 unsigned number, is prefixed with a negative sign.-or-<paramref name="value" /> represents a number that is less than <see cref="F:System.UInt32.MinValue" /> or greater than <see cref="F:System.UInt32.MaxValue" />.</exception>
      uint ToUInt32(string? value, int fromBase);

      /// <summary>Converts the value of the specified 16-bit unsigned integer to the equivalent 32-bit unsigned integer.</summary>
      /// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit unsigned integer to convert. </param>
      uint ToUInt32(ushort value);

      /// <summary>Returns the specified 32-bit unsigned integer; no actual conversion is performed.</summary>
      /// <returns>
      /// <paramref name="value" /> is returned unchanged.</returns>
      /// <param name="value">The 32-bit unsigned integer to return. </param>
      uint ToUInt32(uint value);

      /// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent 32-bit unsigned integer.</summary>
      /// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit unsigned integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is greater than <see cref="F:System.UInt32.MaxValue" />. </exception>
      uint ToUInt32(ulong value);

      /// <summary>Converts the specified Boolean value to the equivalent 64-bit unsigned integer.</summary>
      /// <returns>The number 1 if <paramref name="value" /> is true; otherwise, 0.</returns>
      /// <param name="value">The Boolean value to convert. </param>
      ulong ToUInt64(bool value);

      /// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent 64-bit unsigned integer.</summary>
      /// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit unsigned integer to convert. </param>
      ulong ToUInt64(byte value);

      /// <summary>Converts the value of the specified Unicode character to the equivalent 64-bit unsigned integer.</summary>
      /// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The Unicode character to convert. </param>
      ulong ToUInt64(char value);

      /// <summary>Converts the value of the specified decimal number to an equivalent 64-bit unsigned integer.</summary>
      /// <returns>
      /// <paramref name="value" />, rounded to the nearest 64-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
      /// <param name="value">The decimal number to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt64.MaxValue" />. </exception>
      ulong ToUInt64(decimal value);

      /// <summary>Converts the value of the specified double-precision floating-point number to an equivalent 64-bit unsigned integer.</summary>
      /// <returns>
      /// <paramref name="value" />, rounded to the nearest 64-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
      /// <param name="value">The double-precision floating-point number to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt64.MaxValue" />. </exception>
      ulong ToUInt64(double value);

      /// <summary>Converts the value of the specified 16-bit signed integer to the equivalent 64-bit unsigned integer.</summary>
      /// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit signed integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than zero. </exception>
      ulong ToUInt64(short value);

      /// <summary>Converts the value of the specified 32-bit signed integer to an equivalent 64-bit unsigned integer.</summary>
      /// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit signed integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than zero. </exception>
      ulong ToUInt64(int value);

      /// <summary>Converts the value of the specified 64-bit signed integer to an equivalent 64-bit unsigned integer.</summary>
      /// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 64-bit signed integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than zero. </exception>
      ulong ToUInt64(long value);

      /// <summary>Converts the value of the specified object to a 64-bit unsigned integer.</summary>
      /// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or null. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in an appropriate format.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface. -or-The conversion is not supported.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt64.MinValue" /> or greater than <see cref="F:System.UInt64.MaxValue" />.</exception>
      ulong ToUInt64(object? value);

      /// <summary>Converts the value of the specified object to a 64-bit unsigned integer, using the specified culture-specific formatting information.</summary>
      /// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> is not in an appropriate format.</exception>
      /// <exception cref="T:System.InvalidCastException">
      /// <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface. -or-The conversion is not supported.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt64.MinValue" /> or greater than <see cref="F:System.UInt64.MaxValue" />.</exception>
      ulong ToUInt64(object? value, IFormatProvider? provider);

      /// <summary>Converts the value of the specified 8-bit signed integer to the equivalent 64-bit unsigned integer.</summary>
      /// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 8-bit signed integer to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than zero. </exception>
      ulong ToUInt64(sbyte value);

      /// <summary>Converts the value of the specified single-precision floating-point number to an equivalent 64-bit unsigned integer.</summary>
      /// <returns>
      /// <paramref name="value" />, rounded to the nearest 64-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
      /// <param name="value">The single-precision floating-point number to convert. </param>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt64.MaxValue" />. </exception>
      ulong ToUInt64(float value);

      /// <summary>Converts the specified string representation of a number to an equivalent 64-bit unsigned integer.</summary>
      /// <returns>A 64-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt64.MinValue" /> or greater than <see cref="F:System.UInt64.MaxValue" />. </exception>
      ulong ToUInt64(string? value);

      /// <summary>Converts the specified string representation of a number to an equivalent 64-bit unsigned integer, using the specified culture-specific formatting information.</summary>
      /// <returns>A 64-bit unsigned integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt64.MinValue" /> or greater than <see cref="F:System.UInt64.MaxValue" />. </exception>
      ulong ToUInt64(string? value, IFormatProvider? provider);

      /// <summary>Converts the string representation of a number in a specified base to an equivalent 64-bit unsigned integer.</summary>
      /// <returns>A 64-bit unsigned integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is null.</returns>
      /// <param name="value">A string that contains the number to convert. </param>
      /// <param name="fromBase">The base of the number in <paramref name="value" />, which must be 2, 8, 10, or 16. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="fromBase" /> is not 2, 8, 10, or 16. -or-<paramref name="value" />, which represents a non-base 10 unsigned number, is prefixed with a negative sign. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="value" /> is <see cref="F:System.String.Empty" />. </exception>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="value" /> contains a character that is not a valid digit in the base specified by <paramref name="fromBase" />. The exception message indicates that there are no digits to convert if the first character in <paramref name="value" /> is invalid; otherwise, the message indicates that <paramref name="value" /> contains invalid trailing characters.</exception>
      /// <exception cref="T:System.OverflowException">
      /// <paramref name="value" />, which represents a non-base 10 unsigned number, is prefixed with a negative sign.-or-<paramref name="value" /> represents a number that is less than <see cref="F:System.UInt64.MinValue" /> or greater than <see cref="F:System.UInt64.MaxValue" />.</exception>
      ulong ToUInt64(string? value, int fromBase);

      /// <summary>Converts the value of the specified 16-bit unsigned integer to the equivalent 64-bit unsigned integer.</summary>
      /// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 16-bit unsigned integer to convert. </param>
      ulong ToUInt64(ushort value);

      /// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent 64-bit unsigned integer.</summary>
      /// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
      /// <param name="value">The 32-bit unsigned integer to convert. </param>
      ulong ToUInt64(uint value);

      /// <summary>Returns the specified 64-bit unsigned integer; no actual conversion is performed.</summary>
      /// <returns>
      /// <paramref name="value" /> is returned unchanged.</returns>
      /// <param name="value">The 64-bit unsigned integer to return. </param>
      ulong ToUInt64(ulong value);

      /// <summary>Returns the <see cref="T:System.TypeCode" /> for the specified object.</summary>
      /// <returns>The <see cref="T:System.TypeCode" /> for <paramref name="value" />, or <see cref="F:System.TypeCode.Empty" /> if <paramref name="value" /> is null.</returns>
      /// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface. </param>
      /// <filterpriority>1</filterpriority>
      TypeCode GetTypeCode(object value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The Unicode character to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      bool ToBoolean(char value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The date and time value to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      bool ToBoolean(DateTime value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The date and time value to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      byte ToByte(DateTime value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The Boolean value to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      char ToChar(bool value);

      /// <summary>Returns the specified Unicode character value; no actual conversion is performed.</summary>
      /// <returns>
      /// <paramref name="value" /> is returned unchanged.</returns>
      /// <param name="value">The Unicode character to return. </param>
      /// <filterpriority>1</filterpriority>
      char ToChar(char value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The single-precision floating-point number to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      char ToChar(float value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The double-precision floating-point number to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      char ToChar(double value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The decimal number to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      char ToChar(Decimal value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The date and time value to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      char ToChar(DateTime value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The date and time value to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      short ToInt16(DateTime value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The date and time value to convert.</param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      int ToInt32(DateTime value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The date and time value to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      long ToInt64(DateTime value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The date and time value to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      sbyte ToSByte(DateTime value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The date and time value to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      ushort ToUInt16(DateTime value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The date and time value to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      uint ToUInt32(DateTime value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The date and time value to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      ulong ToUInt64(DateTime value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The Unicode character to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      float ToSingle(char value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The date and time value to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      float ToSingle(DateTime value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The Unicode character to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      double ToDouble(char value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The date and time value to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      double ToDouble(DateTime value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The Unicode character to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      decimal ToDecimal(char value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The date and time value to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      decimal ToDecimal(DateTime value);

      /// <summary>Returns the specified <see cref="T:System.DateTime" /> object; no actual conversion is performed.</summary>
      /// <returns>
      /// <paramref name="value" /> is returned unchanged.</returns>
      /// <param name="value">A date and time value. </param>
      /// <filterpriority>1</filterpriority>
      DateTime ToDateTime(DateTime value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The 8-bit signed integer to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      DateTime ToDateTime(sbyte value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The 8-bit unsigned integer to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      DateTime ToDateTime(byte value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The 16-bit signed integer to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      DateTime ToDateTime(short value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The 16-bit unsigned integer to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      DateTime ToDateTime(ushort value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The 32-bit signed integer to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      DateTime ToDateTime(int value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The 32-bit unsigned integer to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      DateTime ToDateTime(uint value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The 64-bit signed integer to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      DateTime ToDateTime(long value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The 64-bit unsigned integer to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      DateTime ToDateTime(ulong value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The Boolean value to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      DateTime ToDateTime(bool value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The Unicode character to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      DateTime ToDateTime(char value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The single-precision floating-point value to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      DateTime ToDateTime(float value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The double-precision floating-point value to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      DateTime ToDateTime(double value);

      /// <summary>Calling this method always throws <see cref="T:System.InvalidCastException" />.</summary>
      /// <returns>This conversion is not supported. No value is returned.</returns>
      /// <param name="value">The number to convert. </param>
      /// <exception cref="T:System.InvalidCastException">This conversion is not supported. </exception>
      /// <filterpriority>1</filterpriority>
      DateTime ToDateTime(decimal value);

      /// <summary>Returns the specified string instance; no actual conversion is performed.</summary>
      /// <returns>
      /// <paramref name="value" /> is returned unchanged.</returns>
      /// <param name="value">The string to return. </param>
      /// <filterpriority>1</filterpriority>
      string ToString(string value);

      /// <summary>Returns the specified string instance; no actual conversion is performed.</summary>
      /// <returns>
      /// <paramref name="value" /> is returned unchanged.</returns>
      /// <param name="value">The string to return. </param>
      /// <param name="provider">An object that supplies culture-specific formatting information. This parameter is ignored.</param>
      /// <filterpriority>1</filterpriority>
      string ToString(string value, IFormatProvider provider);

      /// <summary>Converts an array of 8-bit unsigned integers to its equivalent string representation that is encoded with base-64 digits. A parameter specifies whether to insert line breaks in the return value.</summary>
      /// <returns>The string representation in base 64 of the elements in <paramref name="inArray" />.</returns>
      /// <param name="inArray">An array of 8-bit unsigned integers. </param>
      /// <param name="options">
      /// <see cref="F:System.Base64FormattingOptions.InsertLineBreaks" /> to insert a line break every 76 characters, or <see cref="F:System.Base64FormattingOptions.None" /> to not insert line breaks.</param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="inArray" /> is null. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="options" /> is not a valid <see cref="T:System.Base64FormattingOptions" /> value. </exception>
      /// <filterpriority>1</filterpriority>
      string ToBase64String(byte[] inArray, Base64FormattingOptions options);

      /// <summary>Converts a subset of an array of 8-bit unsigned integers to its equivalent string representation that is encoded with base-64 digits. Parameters specify the subset as an offset in the input array, the number of elements in the array to convert, and whether to insert line breaks in the return value.</summary>
      /// <returns>The string representation in base 64 of <paramref name="length" /> elements of <paramref name="inArray" />, starting at position <paramref name="offset" />.</returns>
      /// <param name="inArray">An array of 8-bit unsigned integers. </param>
      /// <param name="offset">An offset in <paramref name="inArray" />. </param>
      /// <param name="length">The number of elements of <paramref name="inArray" /> to convert. </param>
      /// <param name="options">
      /// <see cref="F:System.Base64FormattingOptions.InsertLineBreaks" /> to insert a line break every 76 characters, or <see cref="F:System.Base64FormattingOptions.None" /> to not insert line breaks.</param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="inArray" /> is null. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="offset" /> or <paramref name="length" /> is negative.-or- <paramref name="offset" /> plus <paramref name="length" /> is greater than the length of <paramref name="inArray" />. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="options" /> is not a valid <see cref="T:System.Base64FormattingOptions" /> value. </exception>
      /// <filterpriority>1</filterpriority>
      string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options);

      /// <summary>Converts a subset of an 8-bit unsigned integer array to an equivalent subset of a Unicode character array encoded with base-64 digits. Parameters specify the subsets as offsets in the input and output arrays, the number of elements in the input array to convert, and whether line breaks are inserted in the output array.</summary>
      /// <returns>A 32-bit signed integer containing the number of bytes in <paramref name="outArray" />.</returns>
      /// <param name="inArray">An input array of 8-bit unsigned integers. </param>
      /// <param name="offsetIn">A position within <paramref name="inArray" />. </param>
      /// <param name="length">The number of elements of <paramref name="inArray" /> to convert. </param>
      /// <param name="outArray">An output array of Unicode characters. </param>
      /// <param name="offsetOut">A position within <paramref name="outArray" />. </param>
      /// <param name="options">
      /// <see cref="F:System.Base64FormattingOptions.InsertLineBreaks" /> to insert a line break every 76 characters, or <see cref="F:System.Base64FormattingOptions.None" /> to not insert line breaks.</param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="inArray" /> or <paramref name="outArray" /> is null. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="offsetIn" />, <paramref name="offsetOut" />, or <paramref name="length" /> is negative.-or- <paramref name="offsetIn" /> plus <paramref name="length" /> is greater than the length of <paramref name="inArray" />.-or- <paramref name="offsetOut" /> plus the number of elements to return is greater than the length of <paramref name="outArray" />. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="options" /> is not a valid <see cref="T:System.Base64FormattingOptions" /> value. </exception>
      /// <filterpriority>1</filterpriority>
      int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut, Base64FormattingOptions options);

      /// <summary>A constant that represents a database column that is absent of data; that is, database null.</summary>
      /// <filterpriority>1</filterpriority>
      // ReSharper disable once InconsistentNaming
      object DBNull { get; }

      /// <summary>Returns an indication whether the specified object is of type <see cref="T:System.DBNull" />.</summary>
      /// <returns>true if <paramref name="value" /> is of type <see cref="T:System.DBNull" />; otherwise, false.</returns>
      /// <param name="value">An object. </param>
      /// <filterpriority>1</filterpriority>
      // ReSharper disable once InconsistentNaming
      bool IsDBNull(object value);

#if NET5_0
      /// <summary>
      /// Converts the specified string, which encodes binary data as hex characters, to an equivalent 8-bit unsigned integer array.
      /// </summary>
      /// <param name="s">The string to convert.</param>
      /// <returns>An array of 8-bit unsigned integers that is equivalent to <paramref name="s"/>.</returns>
      /// <exception cref="ArgumentNullException"><paramref name="s"/> is <code>null</code>.</exception>
      /// <exception cref="FormatException">The length of <paramref name="s"/>, is not zero or a multiple of 2.</exception>
      /// <exception cref="FormatException">The format of <paramref name="s"/> is invalid. <paramref name="s"/> contains a non-hex character.</exception>
      byte[] FromHexString(string s);

      /// <summary>
      /// Converts the span, which encodes binary data as hex characters, to an equivalent 8-bit unsigned integer array.
      /// </summary>
      /// <param name="chars">The span to convert.</param>
      /// <returns>An array of 8-bit unsigned integers that is equivalent to <paramref name="chars"/>.</returns>
      /// <exception cref="FormatException">The length of <paramref name="chars"/>, is not zero or a multiple of 2.</exception>
      /// <exception cref="FormatException">The format of <paramref name="chars"/> is invalid. <paramref name="chars"/> contains a non-hex character.</exception>
      byte[] FromHexString(ReadOnlySpan<char> chars);

      /// <summary>
      /// Converts an array of 8-bit unsigned integers to its equivalent string representation that is encoded with uppercase hex characters.
      /// </summary>
      /// <param name="inArray">An array of 8-bit unsigned integers.</param>
      /// <returns>The string representation in hex of the elements in <paramref name="inArray"/>.</returns>
      /// <exception cref="ArgumentNullException"><paramref name="inArray"/> is <code>null</code>.</exception>
      /// <exception cref="ArgumentOutOfRangeException"><paramref name="inArray"/> is too large to be encoded.</exception>
      string ToHexString(byte[] inArray);

      /// <summary>
      /// Converts a subset of an array of 8-bit unsigned integers to its equivalent string representation that is encoded with uppercase hex characters.
      /// Parameters specify the subset as an offset in the input array and the number of elements in the array to convert.
      /// </summary>
      /// <param name="inArray">An array of 8-bit unsigned integers.</param>
      /// <param name="offset">An offset in <paramref name="inArray"/>.</param>
      /// <param name="length">The number of elements of <paramref name="inArray"/> to convert.</param>
      /// <returns>The string representation in hex of <paramref name="length"/> elements of <paramref name="inArray"/>, starting at position <paramref name="offset"/>.</returns>
      /// <exception cref="ArgumentNullException"><paramref name="inArray"/> is <code>null</code>.</exception>
      /// <exception cref="ArgumentOutOfRangeException"><paramref name="offset"/> or <paramref name="length"/> is negative.</exception>
      /// <exception cref="ArgumentOutOfRangeException"><paramref name="offset"/> plus <paramref name="length"/> is greater than the length of <paramref name="inArray"/>.</exception>
      /// <exception cref="ArgumentOutOfRangeException"><paramref name="inArray"/> is too large to be encoded.</exception>
      string ToHexString(byte[] inArray, int offset, int length);

      /// <summary>
      /// Converts a span of 8-bit unsigned integers to its equivalent string representation that is encoded with uppercase hex characters.
      /// </summary>
      /// <param name="bytes">A span of 8-bit unsigned integers.</param>
      /// <returns>The string representation in hex of the elements in <paramref name="bytes"/>.</returns>
      /// <exception cref="ArgumentOutOfRangeException"><paramref name="bytes"/> is too large to be encoded.</exception>
      string ToHexString(ReadOnlySpan<byte> bytes);
#endif
   }
}
