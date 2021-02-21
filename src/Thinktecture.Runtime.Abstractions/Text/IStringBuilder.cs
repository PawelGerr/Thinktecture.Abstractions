using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Runtime.Serialization;

namespace Thinktecture.Text
{
   /// <summary>Represents a mutable string of characters. This class cannot be inherited.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
   public interface IStringBuilder : IAbstraction<StringBuilder>, ISerializable
   {
      /// <summary>Gets or sets the maximum number of characters that can be contained in the memory allocated by the current instance.</summary>
      /// <returns>The maximum number of characters that can be contained in the memory allocated by the current instance. Its value can range from <see cref="P:System.Text.StringBuilder.Length" /> to <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </returns>
      /// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for a set operation is less than the current length of this instance.-or- The value specified for a set operation is greater than the maximum capacity. </exception>
      int Capacity { get; set; }

      /// <summary>Gets or sets the length of the current <see cref="T:System.Text.StringBuilder" /> object.</summary>
      /// <returns>The length of this instance.</returns>
      /// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for a set operation is less than zero or greater than <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      int Length { get; set; }

      /// <summary>Gets the maximum capacity of this instance.</summary>
      /// <returns>The maximum number of characters this instance can hold.</returns>
      int MaxCapacity { get; }

      /// <summary>Gets or sets the character at the specified character position in this instance.</summary>
      /// <returns>The Unicode character at position <paramref name="index" />.</returns>
      /// <param name="index">The position of the character. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" /> is outside the bounds of this instance while setting a character. </exception>
      /// <exception cref="T:System.IndexOutOfRangeException">
      /// <paramref name="index" /> is outside the bounds of this instance while getting a character. </exception>
      [IndexerName("Chars")]
      char this[int index] { get; set; }

      /// <summary>
      /// Appends the <paramref name="values"/> after joining them using the <paramref name="separator"/>.
      /// </summary>
      /// <param name="separator">Separator to use for joining.</param>
      /// <param name="values">Values to join and append.</param>
      /// <typeparam name="T">Type of the values.</typeparam>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      IStringBuilder AppendJoin<T>(char separator, IEnumerable<T> values);

      /// <summary>
      /// Appends the <paramref name="values"/> after joining them using the <paramref name="separator"/>.
      /// </summary>
      /// <param name="separator">Separator to use for joining.</param>
      /// <param name="values">Values to join and append.</param>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      IStringBuilder AppendJoin(char separator, object[] values);

      /// <summary>
      /// Appends the <paramref name="values"/> after joining them using the <paramref name="separator"/>.
      /// </summary>
      /// <param name="separator">Separator to use for joining.</param>
      /// <param name="values">Values to join and append.</param>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      IStringBuilder AppendJoin(char separator, string[] values);

      /// <summary>
      /// Appends the <paramref name="values"/> after joining them using the <paramref name="separator"/>.
      /// </summary>
      /// <param name="separator">Separator to use for joining.</param>
      /// <param name="values">Values to join and append.</param>
      /// <typeparam name="T">Type of the values.</typeparam>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      IStringBuilder AppendJoin<T>(string separator, IEnumerable<T> values);

      /// <summary>
      /// Appends the <paramref name="values"/> after joining them using the <paramref name="separator"/>.
      /// </summary>
      /// <param name="separator">Separator to use for joining.</param>
      /// <param name="values">Values to join and append.</param>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      IStringBuilder AppendJoin(string separator, object[] values);

      /// <summary>
      /// Appends the <paramref name="values"/> after joining them using the <paramref name="separator"/>.
      /// </summary>
      /// <param name="separator">Separator to use for joining.</param>
      /// <param name="values">Values to join and append.</param>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      IStringBuilder AppendJoin(string separator, string[] values);

      /// <summary>Appends the value to this instance.</summary>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      /// <param name="value">The span of characters to append. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Append(ReadOnlySpan<char> value);

      /// <summary>Appends the value to this instance.</summary>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      /// <param name="value">Characters to append.</param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Append(ReadOnlyMemory<char> value);

      /// <summary>Appends the content of the provided <paramref name="value"/> to this instance.</summary>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      /// <param name="value">A <see cref="StringBuilder"/> to append. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Append(StringBuilder value);

      /// <summary>Appends the content of the provided <paramref name="value"/> to this instance.</summary>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      /// <param name="value">A <see cref="StringBuilder"/> to append. </param>
      /// <param name="startIndex">Index to start from.</param>
      /// <param name="count">Number of characters to append.</param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Append(StringBuilder value, int startIndex, int count);

      /// <summary>Copies the characters from a specified segment of this instance to a specified segment of a destination <see cref="T:System.Char" /> array.</summary>
      /// <param name="sourceIndex">The starting position in this instance where characters will be copied from. The index is zero-based.</param>
      /// <param name="destination">The span where characters will be copied.</param>
      /// <param name="count">The number of characters to be copied.</param>
      void CopyTo(int sourceIndex, Span<char> destination, int count);

      /// <summary>Inserts the value into this instance at the specified character position.</summary>
      /// <returns>A reference to this instance after the insert operation has completed.</returns>
      /// <param name="index">The position in this instance where insertion begins. </param>
      /// <param name="value">The value to insert. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" /> is less than zero or greater than the length of this instance.</exception>
      /// <exception cref="T:System.OutOfMemoryException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
      IStringBuilder Insert(int index, ReadOnlySpan<char> value);

      /// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
      /// <returns>true if this instance and <paramref name="span" /> have equal string, <see cref="P:System.Text.StringBuilder.Capacity" />, and <see cref="P:System.Text.StringBuilder.MaxCapacity" /> values; otherwise, false.</returns>
      /// <param name="span">An object to compare with this instance, or null. </param>
      bool Equals(ReadOnlySpan<char> span);

      /// <summary>Appends the string representation of a specified Boolean value to this instance.</summary>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      /// <param name="value">The Boolean value to append. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Append(bool value);

      /// <summary>Appends the string representation of a specified 8-bit unsigned integer to this instance.</summary>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      /// <param name="value">The value to append. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Append(byte value);

      /// <summary>Appends the string representation of a specified Unicode character to this instance.</summary>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      /// <param name="value">The Unicode character to append. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Append(char value);

      /// <summary>Appends a specified number of copies of the string representation of a Unicode character to this instance.</summary>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      /// <param name="value">The character to append. </param>
      /// <param name="repeatCount">The number of times to append <paramref name="value" />. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="repeatCount" /> is less than zero.-or- Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      /// <exception cref="T:System.OutOfMemoryException">Out of memory.</exception>
      IStringBuilder Append(char value, int repeatCount);

      /// <summary>Appends the string representation of the Unicode characters in a specified array to this instance.</summary>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      /// <param name="value">The array of characters to append. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Append(char[]? value);

      /// <summary>Appends the string representation of a specified subarray of Unicode characters to this instance.</summary>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      /// <param name="value">A character array. </param>
      /// <param name="startIndex">The starting position in <paramref name="value" />. </param>
      /// <param name="charCount">The number of characters to append. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="value" /> is null, and <paramref name="startIndex" /> and <paramref name="charCount" /> are not zero. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="charCount" /> is less than zero.-or- <paramref name="startIndex" /> is less than zero.-or- <paramref name="startIndex" /> + <paramref name="charCount" /> is greater than the length of <paramref name="value" />.-or- Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Append(char[] value, int startIndex, int charCount);

      /// <summary>Appends the string representation of a specified decimal number to this instance.</summary>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      /// <param name="value">The value to append. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Append(decimal value);

      /// <summary>Appends the string representation of a specified double-precision floating-point number to this instance.</summary>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      /// <param name="value">The value to append. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Append(double value);

      /// <summary>Appends the string representation of a specified 16-bit signed integer to this instance.</summary>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      /// <param name="value">The value to append. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Append(short value);

      /// <summary>Appends the string representation of a specified 32-bit signed integer to this instance.</summary>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      /// <param name="value">The value to append. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Append(int value);

      /// <summary>Appends the string representation of a specified 64-bit signed integer to this instance.</summary>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      /// <param name="value">The value to append. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Append(long value);

      /// <summary>Appends the straing representation of a specified object to this instance.</summary>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      /// <param name="value">The object to append. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Append(object? value);

      /// <summary>Appends the string representation of a specified 8-bit signed integer to this instance.</summary>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      /// <param name="value">The value to append. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Append(sbyte value);

      /// <summary>Appends the string representation of a specified single-precision floating-point number to this instance.</summary>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      /// <param name="value">The value to append. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Append(float value);

      /// <summary>Appends a copy of the specified string to this instance.</summary>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      /// <param name="value">The string to append. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Append(string? value);

      /// <summary>Appends a copy of a specified substring to this instance.</summary>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      /// <param name="value">The string that contains the substring to append. </param>
      /// <param name="startIndex">The starting position of the substring within <paramref name="value" />. </param>
      /// <param name="count">The number of characters in <paramref name="value" /> to append. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="value" /> is null, and <paramref name="startIndex" /> and <paramref name="count" /> are not zero. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="count" /> less than zero.-or- <paramref name="startIndex" /> less than zero.-or- <paramref name="startIndex" /> + <paramref name="count" /> is greater than the length of <paramref name="value" />.-or- Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Append(string value, int startIndex, int count);

      /// <summary>Appends the string representation of a specified 16-bit unsigned integer to this instance.</summary>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      /// <param name="value">The value to append. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Append(ushort value);

      /// <summary>Appends the string representation of a specified 32-bit unsigned integer to this instance.</summary>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      /// <param name="value">The value to append. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Append(uint value);

      /// <summary>Appends the string representation of a specified 64-bit unsigned integer to this instance.</summary>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      /// <param name="value">The value to append. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Append(ulong value);

      /// <summary>Appends the string returned by processing a composite format string, which contains zero or more format items, to this instance. Each format item is replaced by the string representation of a corresponding argument in a parameter array using a specified format provider.</summary>
      /// <returns>A reference to this instance after the append operation has completed. After the append operation, this instance contains any data that existed before the operation, suffixed by a copy of <paramref name="format" /> where any format specification is replaced by the string representation of the corresponding object argument. </returns>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <param name="format">A composite format string (see Remarks). </param>
      /// <param name="args">An array of objects to format.</param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="format" /> is null. </exception>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="format" /> is invalid. -or-The index of a format item is less than 0 (zero), or greater than or equal to the length of the <paramref name="args" /> array.</exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">The length of the expanded string would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder AppendFormat(IFormatProvider? provider, string format, params object[] args);

      /// <summary>Appends the string returned by processing a composite format string, which contains zero or more format items, to this instance. Each format item is replaced by the string representation of a corresponding argument in a parameter array.</summary>
      /// <returns>A reference to this instance with <paramref name="format" /> appended. Each format item in <paramref name="format" /> is replaced by the string representation of the corresponding object argument.</returns>
      /// <param name="format">A composite format string (see Remarks). </param>
      /// <param name="args">An array of objects to format. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="format" /> or <paramref name="args" /> is null. </exception>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="format" /> is invalid. -or-The index of a format item is less than 0 (zero), or greater than or equal to the length of the <paramref name="args" /> array.</exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">The length of the expanded string would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder AppendFormat(string format, params object[] args);

      /// <summary>Appends the string returned by processing a composite format string, which contains zero or more format items, to this instance. Each format item is replaced by the string representation of a single argument.</summary>
      /// <returns>A reference to this instance with <paramref name="format" /> appended. Each format item in <paramref name="format" /> is replaced by the string representation of <paramref name="arg0" />.</returns>
      /// <param name="format">A composite format string (see Remarks). </param>
      /// <param name="arg0">An object to format. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="format" /> is null. </exception>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="format" /> is invalid. -or-The index of a format item is less than 0 (zero), or greater than or equal to 1.</exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">The length of the expanded string would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      /// <filterpriority>2</filterpriority>
      IStringBuilder AppendFormat(string format, object arg0);

      /// <summary>Appends the string returned by processing a composite format string, which contains zero or more format items, to this instance. Each format item is replaced by the string representation of either of two arguments.</summary>
      /// <returns>A reference to this instance with <paramref name="format" /> appended. Each format item in <paramref name="format" /> is replaced by the string representation of the corresponding object argument.</returns>
      /// <param name="format">A composite format string (see Remarks). </param>
      /// <param name="arg0">The first object to format. </param>
      /// <param name="arg1">The second object to format. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="format" /> is null. </exception>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="format" /> is invalid.-or-The index of a format item is less than 0 (zero), or greater than or equal to 2. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">The length of the expanded string would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      /// <filterpriority>2</filterpriority>
      IStringBuilder AppendFormat(string format, object arg0, object arg1);

      /// <summary>Appends the string returned by processing a composite format string, which contains zero or more format items, to this instance. Each format item is replaced by the string representation of either of three arguments.</summary>
      /// <returns>A reference to this instance with <paramref name="format" /> appended. Each format item in <paramref name="format" /> is replaced by the string representation of the corresponding object argument.</returns>
      /// <param name="format">A composite format string (see Remarks). </param>
      /// <param name="arg0">The first object to format. </param>
      /// <param name="arg1">The second object to format. </param>
      /// <param name="arg2">The third object to format. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="format" /> is null. </exception>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="format" /> is invalid.-or-The index of a format item is less than 0 (zero), or greater than or equal to 3.</exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">The length of the expanded string would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      /// <filterpriority>2</filterpriority>
      IStringBuilder AppendFormat(string format, object arg0, object arg1, object arg2);

      /// <summary>Appends the string returned by processing a composite format string, which contains zero or more format items, to this instance. Each format item is replaced by the string representation of a single argument using a specified format provider. </summary>
      /// <returns>A reference to this instance after the append operation has completed. After the append operation, this instance contains any data that existed before the operation, suffixed by a copy of <paramref name="format" /> in which any format specification is replaced by the string representation of <paramref name="arg0" />. </returns>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <param name="format">A composite format string (see Remarks). </param>
      /// <param name="arg0">The object to format. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="format" /> is null. </exception>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="format" /> is invalid. -or-The index of a format item is less than 0 (zero), or greater than or equal to one (1). </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">The length of the expanded string would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder AppendFormat(IFormatProvider provider, string format, object arg0);

      /// <summary>Appends the string returned by processing a composite format string, which contains zero or more format items, to this instance. Each format item is replaced by the string representation of either of two arguments using a specified format provider.</summary>
      /// <returns>A reference to this instance after the append operation has completed. After the append operation, this instance contains any data that existed before the operation, suffixed by a copy of <paramref name="format" /> where any format specification is replaced by the string representation of the corresponding object argument. </returns>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <param name="format">A composite format string (see Remarks). </param>
      /// <param name="arg0">The first object to format. </param>
      /// <param name="arg1">The second object to format. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="format" /> is null. </exception>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="format" /> is invalid. -or-The index of a format item is less than 0 (zero), or greater than or equal to 2 (two). </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">The length of the expanded string would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1);

      /// <summary>Appends the string returned by processing a composite format string, which contains zero or more format items, to this instance. Each format item is replaced by the string representation of either of three arguments using a specified format provider.</summary>
      /// <returns>A reference to this instance after the append operation has completed. After the append operation, this instance contains any data that existed before the operation, suffixed by a copy of <paramref name="format" /> where any format specification is replaced by the string representation of the corresponding object argument. </returns>
      /// <param name="provider">An object that supplies culture-specific formatting information. </param>
      /// <param name="format">A composite format string (see Remarks). </param>
      /// <param name="arg0">The first object to format. </param>
      /// <param name="arg1">The second object to format. </param>
      /// <param name="arg2">The third object to format. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="format" /> is null. </exception>
      /// <exception cref="T:System.FormatException">
      /// <paramref name="format" /> is invalid. -or-The index of a format item is less than 0 (zero), or greater than or equal to 3 (three). </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">The length of the expanded string would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1, object arg2);

      /// <summary>Appends the default line terminator to the end of the current <see cref="T:System.Text.StringBuilder" /> object.</summary>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      /// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder AppendLine();

      /// <summary>Appends a copy of the specified string followed by the default line terminator to the end of the current <see cref="T:System.Text.StringBuilder" /> object.</summary>
      /// <returns>A reference to this instance after the append operation has completed.</returns>
      /// <param name="value">The string to append. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder AppendLine(string? value);

      /// <summary>Removes all characters from the current <see cref="T:System.Text.StringBuilder" /> instance.</summary>
      /// <returns>An object whose <see cref="P:System.Text.StringBuilder.Length" /> is 0 (zero).</returns>
      IStringBuilder Clear();

      /// <summary>Copies the characters from a specified segment of this instance to a specified segment of a destination <see cref="T:System.Char" /> array.</summary>
      /// <param name="sourceIndex">The starting position in this instance where characters will be copied from. The index is zero-based.</param>
      /// <param name="destination">The array where characters will be copied.</param>
      /// <param name="destinationIndex">The starting position in <paramref name="destination" /> where characters will be copied. The index is zero-based.</param>
      /// <param name="count">The number of characters to be copied.</param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="destination" /> is null.</exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="sourceIndex" />, <paramref name="destinationIndex" />, or <paramref name="count" />, is less than zero.-or-<paramref name="sourceIndex" /> is greater than the length of this instance.</exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="sourceIndex" /> + <paramref name="count" /> is greater than the length of this instance.-or-<paramref name="destinationIndex" /> + <paramref name="count" /> is greater than the length of <paramref name="destination" />.</exception>
      void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count);

      /// <summary>Ensures that the capacity of this instance of <see cref="T:System.Text.StringBuilder" /> is at least the specified value.</summary>
      /// <returns>The new capacity of this instance.</returns>
      /// <param name="capacity">The minimum capacity to ensure. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="capacity" /> is less than zero.-or- Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      int EnsureCapacity(int capacity);

      /// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
      /// <returns>true if this instance and <paramref name="sb" /> have equal string, <see cref="P:System.Text.StringBuilder.Capacity" />, and <see cref="P:System.Text.StringBuilder.MaxCapacity" /> values; otherwise, false.</returns>
      /// <param name="sb">An object to compare with this instance, or null. </param>
      bool Equals(IStringBuilder? sb);

      /// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
      /// <returns>true if this instance and <paramref name="sb" /> have equal string, <see cref="P:System.Text.StringBuilder.Capacity" />, and <see cref="P:System.Text.StringBuilder.MaxCapacity" /> values; otherwise, false.</returns>
      /// <param name="sb">An object to compare with this instance, or null. </param>
      bool Equals(StringBuilder? sb);

      /// <summary>Inserts the string representation of a Boolean value into this instance at the specified character position.</summary>
      /// <returns>A reference to this instance after the insert operation has completed.</returns>
      /// <param name="index">The position in this instance where insertion begins. </param>
      /// <param name="value">The value to insert. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" /> is less than zero or greater than the length of this instance.</exception>
      /// <exception cref="T:System.OutOfMemoryException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
      IStringBuilder Insert(int index, bool value);

      /// <summary>Inserts the string representation of a specified 8-bit unsigned integer into this instance at the specified character position.</summary>
      /// <returns>A reference to this instance after the insert operation has completed.</returns>
      /// <param name="index">The position in this instance where insertion begins. </param>
      /// <param name="value">The value to insert. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" /> is less than zero or greater than the length of this instance. </exception>
      /// <exception cref="T:System.OutOfMemoryException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
      IStringBuilder Insert(int index, byte value);

      /// <summary>Inserts the string representation of a specified Unicode character into this instance at the specified character position.</summary>
      /// <returns>A reference to this instance after the insert operation has completed.</returns>
      /// <param name="index">The position in this instance where insertion begins. </param>
      /// <param name="value">The value to insert. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" /> is less than zero or greater than the length of this instance.-or- Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Insert(int index, char value);

      /// <summary>Inserts the string representation of a specified array of Unicode characters into this instance at the specified character position.</summary>
      /// <returns>A reference to this instance after the insert operation has completed.</returns>
      /// <param name="index">The position in this instance where insertion begins. </param>
      /// <param name="value">The character array to insert. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" /> is less than zero or greater than the length of this instance.-or- Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Insert(int index, char[]? value);

      /// <summary>Inserts the string representation of a specified subarray of Unicode characters into this instance at the specified character position.</summary>
      /// <returns>A reference to this instance after the insert operation has completed.</returns>
      /// <param name="index">The position in this instance where insertion begins. </param>
      /// <param name="value">A character array. </param>
      /// <param name="startIndex">The starting index within <paramref name="value" />. </param>
      /// <param name="charCount">The number of characters to insert. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="value" /> is null, and <paramref name="startIndex" /> and <paramref name="charCount" /> are not zero. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" />, <paramref name="startIndex" />, or <paramref name="charCount" /> is less than zero.-or- <paramref name="index" /> is greater than the length of this instance.-or- <paramref name="startIndex" /> plus <paramref name="charCount" /> is not a position within <paramref name="value" />.-or- Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Insert(int index, char[]? value, int startIndex, int charCount);

      /// <summary>Inserts the string representation of a decimal number into this instance at the specified character position.</summary>
      /// <returns>A reference to this instance after the insert operation has completed.</returns>
      /// <param name="index">The position in this instance where insertion begins. </param>
      /// <param name="value">The value to insert. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" /> is less than zero or greater than the length of this instance. </exception>
      /// <exception cref="T:System.OutOfMemoryException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
      IStringBuilder Insert(int index, decimal value);

      /// <summary>Inserts the string representation of a double-precision floating-point number into this instance at the specified character position.</summary>
      /// <returns>A reference to this instance after the insert operation has completed.</returns>
      /// <param name="index">The position in this instance where insertion begins. </param>
      /// <param name="value">The value to insert. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" /> is less than zero or greater than the length of this instance. </exception>
      /// <exception cref="T:System.OutOfMemoryException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
      IStringBuilder Insert(int index, double value);

      /// <summary>Inserts the string representation of a specified 16-bit signed integer into this instance at the specified character position.</summary>
      /// <returns>A reference to this instance after the insert operation has completed.</returns>
      /// <param name="index">The position in this instance where insertion begins. </param>
      /// <param name="value">The value to insert. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" /> is less than zero or greater than the length of this instance. </exception>
      /// <exception cref="T:System.OutOfMemoryException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
      IStringBuilder Insert(int index, short value);

      /// <summary>Inserts the string representation of a specified 32-bit signed integer into this instance at the specified character position.</summary>
      /// <returns>A reference to this instance after the insert operation has completed.</returns>
      /// <param name="index">The position in this instance where insertion begins. </param>
      /// <param name="value">The value to insert. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" /> is less than zero or greater than the length of this instance. </exception>
      /// <exception cref="T:System.OutOfMemoryException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
      IStringBuilder Insert(int index, int value);

      /// <summary>Inserts the string representation of a 64-bit signed integer into this instance at the specified character position.</summary>
      /// <returns>A reference to this instance after the insert operation has completed.</returns>
      /// <param name="index">The position in this instance where insertion begins. </param>
      /// <param name="value">The value to insert. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" /> is less than zero or greater than the length of this instance. </exception>
      /// <exception cref="T:System.OutOfMemoryException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
      IStringBuilder Insert(int index, long value);

      /// <summary>Inserts the string representation of an object into this instance at the specified character position.</summary>
      /// <returns>A reference to this instance after the insert operation has completed.</returns>
      /// <param name="index">The position in this instance where insertion begins. </param>
      /// <param name="value">The object to insert, or null. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" /> is less than zero or greater than the length of this instance. </exception>
      /// <exception cref="T:System.OutOfMemoryException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
      IStringBuilder Insert(int index, object? value);

      /// <summary>Inserts the string representation of a specified 8-bit signed integer into this instance at the specified character position.</summary>
      /// <returns>A reference to this instance after the insert operation has completed.</returns>
      /// <param name="index">The position in this instance where insertion begins. </param>
      /// <param name="value">The value to insert. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" /> is less than zero or greater than the length of this instance. </exception>
      /// <exception cref="T:System.OutOfMemoryException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
      IStringBuilder Insert(int index, sbyte value);

      /// <summary>Inserts the string representation of a single-precision floating point number into this instance at the specified character position.</summary>
      /// <returns>A reference to this instance after the insert operation has completed.</returns>
      /// <param name="index">The position in this instance where insertion begins. </param>
      /// <param name="value">The value to insert. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" /> is less than zero or greater than the length of this instance. </exception>
      /// <exception cref="T:System.OutOfMemoryException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
      IStringBuilder Insert(int index, float value);

      /// <summary>Inserts a string into this instance at the specified character position.</summary>
      /// <returns>A reference to this instance after the insert operation has completed.</returns>
      /// <param name="index">The position in this instance where insertion begins. </param>
      /// <param name="value">The string to insert. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" /> is less than zero or greater than the current length of this instance. -or-The current length of this <see cref="T:System.Text.StringBuilder" /> object plus the length of <paramref name="value" /> exceeds <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
      IStringBuilder Insert(int index, string? value);

      /// <summary>Inserts one or more copies of a specified string into this instance at the specified character position.</summary>
      /// <returns>A reference to this instance after insertion has completed.</returns>
      /// <param name="index">The position in this instance where insertion begins. </param>
      /// <param name="value">The string to insert. </param>
      /// <param name="count">The number of times to insert <paramref name="value" />. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" /> is less than zero or greater than the current length of this instance.-or- <paramref name="count" /> is less than zero. </exception>
      /// <exception cref="T:System.OutOfMemoryException">The current length of this <see cref="T:System.Text.StringBuilder" /> object plus the length of <paramref name="value" /> times <paramref name="count" /> exceeds <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
      IStringBuilder Insert(int index, string? value, int count);

      /// <summary>Inserts the string representation of a 16-bit unsigned integer into this instance at the specified character position.</summary>
      /// <returns>A reference to this instance after the insert operation has completed.</returns>
      /// <param name="index">The position in this instance where insertion begins. </param>
      /// <param name="value">The value to insert. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" /> is less than zero or greater than the length of this instance. </exception>
      /// <exception cref="T:System.OutOfMemoryException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
      IStringBuilder Insert(int index, ushort value);

      /// <summary>Inserts the string representation of a 32-bit unsigned integer into this instance at the specified character position.</summary>
      /// <returns>A reference to this instance after the insert operation has completed.</returns>
      /// <param name="index">The position in this instance where insertion begins. </param>
      /// <param name="value">The value to insert. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" /> is less than zero or greater than the length of this instance. </exception>
      /// <exception cref="T:System.OutOfMemoryException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
      IStringBuilder Insert(int index, uint value);

      /// <summary>Inserts the string representation of a 64-bit unsigned integer into this instance at the specified character position.</summary>
      /// <returns>A reference to this instance after the insert operation has completed.</returns>
      /// <param name="index">The position in this instance where insertion begins. </param>
      /// <param name="value">The value to insert. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" /> is less than zero or greater than the length of this instance. </exception>
      /// <exception cref="T:System.OutOfMemoryException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
      IStringBuilder Insert(int index, ulong value);

      /// <summary>Removes the specified range of characters from this instance.</summary>
      /// <returns>A reference to this instance after the excise operation has completed.</returns>
      /// <param name="startIndex">The zero-based position in this instance where removal begins. </param>
      /// <param name="length">The number of characters to remove. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">If <paramref name="startIndex" /> or <paramref name="length" /> is less than zero, or <paramref name="startIndex" /> + <paramref name="length" /> is greater than the length of this instance. </exception>
      IStringBuilder Remove(int startIndex, int length);

      /// <summary>Replaces all occurrences of a specified character in this instance with another specified character.</summary>
      /// <returns>A reference to this instance with <paramref name="oldChar" /> replaced by <paramref name="newChar" />.</returns>
      /// <param name="oldChar">The character to replace. </param>
      /// <param name="newChar">The character that replaces <paramref name="oldChar" />. </param>
      IStringBuilder Replace(char oldChar, char newChar);

      /// <summary>Replaces, within a substring of this instance, all occurrences of a specified character with another specified character.</summary>
      /// <returns>A reference to this instance with <paramref name="oldChar" /> replaced by <paramref name="newChar" /> in the range from <paramref name="startIndex" /> to <paramref name="startIndex" /> + <paramref name="count" /> -1.</returns>
      /// <param name="oldChar">The character to replace. </param>
      /// <param name="newChar">The character that replaces <paramref name="oldChar" />. </param>
      /// <param name="startIndex">The position in this instance where the substring begins. </param>
      /// <param name="count">The length of the substring. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="startIndex" /> + <paramref name="count" /> is greater than the length of the value of this instance.-or- <paramref name="startIndex" /> or <paramref name="count" /> is less than zero. </exception>
      IStringBuilder Replace(char oldChar, char newChar, int startIndex, int count);

      /// <summary>Replaces all occurrences of a specified string in this instance with another specified string.</summary>
      /// <returns>A reference to this instance with all instances of <paramref name="oldValue" /> replaced by <paramref name="newValue" />.</returns>
      /// <param name="oldValue">The string to replace. </param>
      /// <param name="newValue">The string that replaces <paramref name="oldValue" />, or null. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="oldValue" /> is null. </exception>
      /// <exception cref="T:System.ArgumentException">The length of <paramref name="oldValue" /> is zero. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Replace(string oldValue, string? newValue);

      /// <summary>Replaces, within a substring of this instance, all occurrences of a specified string with another specified string.</summary>
      /// <returns>A reference to this instance with all instances of <paramref name="oldValue" /> replaced by <paramref name="newValue" /> in the range from <paramref name="startIndex" /> to <paramref name="startIndex" /> + <paramref name="count" /> - 1.</returns>
      /// <param name="oldValue">The string to replace. </param>
      /// <param name="newValue">The string that replaces <paramref name="oldValue" />, or null. </param>
      /// <param name="startIndex">The position in this instance where the substring begins. </param>
      /// <param name="count">The length of the substring. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="oldValue" /> is null. </exception>
      /// <exception cref="T:System.ArgumentException">The length of <paramref name="oldValue" /> is zero. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="startIndex" /> or <paramref name="count" /> is less than zero.-or- <paramref name="startIndex" /> plus <paramref name="count" /> indicates a character position not within this instance.-or- Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      IStringBuilder Replace(string oldValue, string? newValue, int startIndex, int count);

      /// <summary>Converts the value of a substring of this instance to a <see cref="T:System.String" />.</summary>
      /// <returns>A string whose value is the same as the specified substring of this instance.</returns>
      /// <param name="startIndex">The starting position of the substring in this instance. </param>
      /// <param name="length">The length of the substring. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="startIndex" /> or <paramref name="length" /> is less than zero.-or- The sum of <paramref name="startIndex" /> and <paramref name="length" /> is greater than the length of the current instance. </exception>
      string ToString(int startIndex, int length);

      /// <summary>Appends an array of Unicode characters starting at a specified address to this instance. </summary>
      /// <returns>A reference to this instance after the append operation has completed. </returns>
      /// <param name="value">A pointer to an array of characters. </param>
      /// <param name="valueCount">The number of characters in the array. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="valueCount" /> is less than zero. -or-Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
      /// <exception cref="T:System.NullReferenceException">
      /// <paramref name="value" /> is a null pointer. </exception>
      unsafe IStringBuilder Append(char* value, int valueCount);

#if NETCOREAPP || NET5_0
      /// <summary>
      /// GetChunks returns ChunkEnumerator that follows the IEnumerable pattern and
      /// thus can be used in a C# 'foreach' statements to retrieve the data in the StringBuilder
      /// as chunks (ReadOnlyMemory) of characters.  An example use is:
      ///
      ///      foreach (ReadOnlyMemory&lt;char&gt; chunk in sb.GetChunks())
      ///         foreach (char c in chunk.Span)
      ///             { /* operation on c }
      ///
      /// It is undefined what happens if the StringBuilder is modified while the chunk
      /// enumeration is incomplete.  StringBuilder is also not thread-safe, so operating
      /// on it with concurrent threads is illegal.  Finally the ReadOnlyMemory chunks returned
      /// are NOT guarenteed to remain unchanged if the StringBuilder is modified, so do
      /// not cache them for later use either.  This API's purpose is efficiently extracting
      /// the data of a CONSTANT StringBuilder.
      ///
      /// Creating a ReadOnlySpan from a ReadOnlyMemory  (the .Span property) is expensive
      /// compared to the fetching of the character, so create a local variable for the SPAN
      /// if you need to use it in a nested for statement.  For example
      ///
      ///    foreach (ReadOnlyMemory&lt;char&gt; chunk in sb.GetChunks())
      ///    {
      ///         var span = chunk.Span;
      ///         for (int i = 0; i &lt; span.Length; i++)
      ///             { /* operation on span[i] */ }
      ///    }
      /// </summary>
      StringBuilder.ChunkEnumerator GetChunks();
#endif
   }
}
