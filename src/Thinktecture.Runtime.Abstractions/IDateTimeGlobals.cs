using System;
using System.Globalization;

namespace Thinktecture
{
	/// <summary>
	/// Statics of <see cref="DateTime"/>.
	/// </summary>
	public interface IDateTimeGlobals
	{
		/// <summary>Represents the largest possible value of <see cref="T:System.DateTime" />. This field is read-only.</summary>
		/// <filterpriority>1</filterpriority>
		DateTime MaxValue { get; }

		/// <summary>Represents the smallest possible value of <see cref="T:System.DateTime" />. This field is read-only.</summary>
		/// <filterpriority>1</filterpriority>
		DateTime MinValue { get; }

		/// <summary>Gets a <see cref="T:System.DateTime" /> object that is set to the current date and time on this computer, expressed as the local time.</summary>
		/// <returns>An object whose value is the current local date and time.</returns>
		/// <filterpriority>1</filterpriority>
		DateTime Now { get; }

		/// <summary>Gets the current date.</summary>
		/// <returns>An object that is set to today's date, with the time component set to 00:00:00.</returns>
		/// <filterpriority>1</filterpriority>
		DateTime Today { get; }

		/// <summary>Gets a <see cref="T:System.DateTime" /> object that is set to the current date and time on this computer, expressed as the Coordinated Universal Time (UTC).</summary>
		/// <returns>An object whose value is the current UTC date and time.</returns>
		/// <filterpriority>1</filterpriority>
		DateTime UtcNow { get; }

		/// <summary>Compares two instances of <see cref="T:System.DateTime" /> and returns an integer that indicates whether the first instance is earlier than, the same as, or later than the second instance.</summary>
		/// <returns>A signed number indicating the relative values of <paramref name="t1" /> and <paramref name="t2" />.Value Type Condition Less than zero <paramref name="t1" /> is earlier than <paramref name="t2" />. Zero <paramref name="t1" /> is the same as <paramref name="t2" />. Greater than zero <paramref name="t1" /> is later than <paramref name="t2" />. </returns>
		/// <param name="t1">The first object to compare. </param>
		/// <param name="t2">The second object to compare. </param>
		/// <filterpriority>1</filterpriority>
		int Compare(DateTime t1, DateTime t2);

		/// <summary>Returns the number of days in the specified month and year.</summary>
		/// <returns>The number of days in <paramref name="month" /> for the specified <paramref name="year" />.For example, if <paramref name="month" /> equals 2 for February, the return value is 28 or 29 depending upon whether <paramref name="year" /> is a leap year.</returns>
		/// <param name="year">The year. </param>
		/// <param name="month">The month (a number ranging from 1 to 12). </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="month" /> is less than 1 or greater than 12.-or-<paramref name="year" /> is less than 1 or greater than 9999.</exception>
		/// <filterpriority>1</filterpriority>
		int DaysInMonth(int year, int month);

		/// <summary>Returns a value indicating whether two <see cref="T:System.DateTime" /> instances  have the same date and time value.</summary>
		/// <returns>true if the two values are equal; otherwise, false.</returns>
		/// <param name="t1">The first object to compare. </param>
		/// <param name="t2">The second object to compare. </param>
		/// <filterpriority>1</filterpriority>
		bool Equals(DateTime t1, DateTime t2);

		/// <summary>Deserializes a 64-bit binary value and recreates an original serialized <see cref="T:System.DateTime" /> object.</summary>
		/// <returns>An object that is equivalent to the <see cref="T:System.DateTime" /> object that was serialized by the <see cref="M:System.DateTime.ToBinary" /> method.</returns>
		/// <param name="dateData">A 64-bit signed integer that encodes the <see cref="P:System.DateTime.Kind" /> property in a 2-bit field and the <see cref="P:System.DateTime.Ticks" /> property in a 62-bit field. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="dateData" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
		/// <filterpriority>1</filterpriority>
		DateTime FromBinary(long dateData);

		/// <summary>Converts the specified Windows file time to an equivalent local time.</summary>
		/// <returns>An object that represents the local time equivalent of the date and time represented by the <paramref name="fileTime" /> parameter.</returns>
		/// <param name="fileTime">A Windows file time expressed in ticks. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="fileTime" /> is less than 0 or represents a time greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
		/// <filterpriority>1</filterpriority>
		DateTime FromFileTime(long fileTime);

		/// <summary>Converts the specified Windows file time to an equivalent UTC time.</summary>
		/// <returns>An object that represents the UTC time equivalent of the date and time represented by the <paramref name="fileTime" /> parameter.</returns>
		/// <param name="fileTime">A Windows file time expressed in ticks. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="fileTime" /> is less than 0 or represents a time greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
		/// <filterpriority>1</filterpriority>
		DateTime FromFileTimeUtc(long fileTime);

		/// <summary>Converts the string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent.</summary>
		/// <returns>An object that is equivalent to the date and time contained in <paramref name="s" />.</returns>
		/// <param name="s">A string that contains a date and time to convert. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="s" /> is null. </exception>
		/// <exception cref="T:System.FormatException">
		/// <paramref name="s" /> does not contain a valid string representation of a date and time. </exception>
		/// <filterpriority>1</filterpriority>
		DateTime Parse(string s);

		/// <summary>Converts the string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent by using culture-specific format information.</summary>
		/// <returns>An object that is equivalent to the date and time contained in <paramref name="s" /> as specified by <paramref name="provider" />.</returns>
		/// <param name="s">A string that contains a date and time to convert. </param>
		/// <param name="provider">An object that supplies culture-specific format information about <paramref name="s" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="s" /> is null. </exception>
		/// <exception cref="T:System.FormatException">
		/// <paramref name="s" /> does not contain a valid string representation of a date and time. </exception>
		/// <filterpriority>1</filterpriority>
		DateTime Parse(string s, IFormatProvider provider);

		/// <summary>Converts the string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent by using culture-specific format information and formatting style.</summary>
		/// <returns>An object that is equivalent to the date and time contained in <paramref name="s" />, as specified by <paramref name="provider" /> and <paramref name="styles" />.</returns>
		/// <param name="s">A string that contains a date and time to convert. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. </param>
		/// <param name="styles">A bitwise combination of the enumeration values that indicates the style elements that can be present in <paramref name="s" /> for the parse operation to succeed, and that defines how to interpret the parsed date in relation to the current time zone or the current date. A typical value to specify is <see cref="F:System.Globalization.DateTimeStyles.None" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="s" /> is null. </exception>
		/// <exception cref="T:System.FormatException">
		/// <paramref name="s" /> does not contain a valid string representation of a date and time. </exception>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="styles" /> contains an invalid combination of <see cref="T:System.Globalization.DateTimeStyles" /> values. For example, both <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal" /> and <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal" />.</exception>
		/// <filterpriority>1</filterpriority>
		DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles);

		/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent using the specified format and culture-specific format information. The format of the string representation must match the specified format exactly.</summary>
		/// <returns>An object that is equivalent to the date and time contained in <paramref name="s" />, as specified by <paramref name="format" /> and <paramref name="provider" />.</returns>
		/// <param name="s">A string that contains a date and time to convert. </param>
		/// <param name="format">A format specifier that defines the required format of <paramref name="s" />. For more information, see the Remarks section. </param>
		/// <param name="provider">An object that supplies culture-specific format information about <paramref name="s" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="s" /> or <paramref name="format" /> is null. </exception>
		/// <exception cref="T:System.FormatException">
		/// <paramref name="s" /> or <paramref name="format" /> is an empty string. -or- <paramref name="s" /> does not contain a date and time that corresponds to the pattern specified in <paramref name="format" />. -or-The hour component and the AM/PM designator in <paramref name="s" /> do not agree.</exception>
		/// <filterpriority>2</filterpriority>
		DateTime ParseExact(string s, string format, IFormatProvider provider);

		/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent using the specified format, culture-specific format information, and style. The format of the string representation must match the specified format exactly or an exception is thrown.</summary>
		/// <returns>An object that is equivalent to the date and time contained in <paramref name="s" />, as specified by <paramref name="format" />, <paramref name="provider" />, and <paramref name="style" />.</returns>
		/// <param name="s">A string containing a date and time to convert. </param>
		/// <param name="format">A format specifier that defines the required format of <paramref name="s" />. For more information, see the Remarks section. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. </param>
		/// <param name="style">A bitwise combination of the enumeration values that provides additional information about <paramref name="s" />, about style elements that may be present in <paramref name="s" />, or about the conversion from <paramref name="s" /> to a <see cref="T:System.DateTime" /> value. A typical value to specify is <see cref="F:System.Globalization.DateTimeStyles.None" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="s" /> or <paramref name="format" /> is null. </exception>
		/// <exception cref="T:System.FormatException">
		/// <paramref name="s" /> or <paramref name="format" /> is an empty string. -or- <paramref name="s" /> does not contain a date and time that corresponds to the pattern specified in <paramref name="format" />. -or-The hour component and the AM/PM designator in <paramref name="s" /> do not agree.</exception>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="style" /> contains an invalid combination of <see cref="T:System.Globalization.DateTimeStyles" /> values. For example, both <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal" /> and <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal" />.</exception>
		/// <filterpriority>2</filterpriority>
		DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style);

		/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent using the specified array of formats, culture-specific format information, and style. The format of the string representation must match at least one of the specified formats exactly or an exception is thrown.</summary>
		/// <returns>An object that is equivalent to the date and time contained in <paramref name="s" />, as specified by <paramref name="formats" />, <paramref name="provider" />, and <paramref name="style" />.</returns>
		/// <param name="s">A string that contains a date and time to convert. </param>
		/// <param name="formats">An array of allowable formats of <paramref name="s" />. For more information, see the Remarks section. </param>
		/// <param name="provider">An object that supplies culture-specific format information about <paramref name="s" />. </param>
		/// <param name="style">A bitwise combination of enumeration values that indicates the permitted format of <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.DateTimeStyles.None" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="s" /> or <paramref name="formats" /> is null. </exception>
		/// <exception cref="T:System.FormatException">
		/// <paramref name="s" /> is an empty string. -or- an element of <paramref name="formats" /> is an empty string. -or- <paramref name="s" /> does not contain a date and time that corresponds to any element of <paramref name="formats" />. -or-The hour component and the AM/PM designator in <paramref name="s" /> do not agree.</exception>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="style" /> contains an invalid combination of <see cref="T:System.Globalization.DateTimeStyles" /> values. For example, both <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal" /> and <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal" />.</exception>
		/// <filterpriority>2</filterpriority>
		DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style);

		/// <summary>Creates a new <see cref="T:System.DateTime" /> object that has the same number of ticks as the specified <see cref="T:System.DateTime" />, but is designated as either local time, Coordinated Universal Time (UTC), or neither, as indicated by the specified <see cref="T:System.DateTimeKind" /> value.</summary>
		/// <returns>A new object that has the same number of ticks as the object represented by the <paramref name="value" /> parameter and the <see cref="T:System.DateTimeKind" /> value specified by the <paramref name="kind" /> parameter. </returns>
		/// <param name="value">A date and time. </param>
		/// <param name="kind">One of the enumeration values that indicates whether the new object represents local time, UTC, or neither.</param>
		/// <filterpriority>2</filterpriority>
		DateTime SpecifyKind(DateTime value, DateTimeKind kind);

		/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent and returns a value that indicates whether the conversion succeeded.</summary>
		/// <returns>true if the <paramref name="s" /> parameter was converted successfully; otherwise, false.</returns>
		/// <param name="s">A string containing a date and time to convert. </param>
		/// <param name="result">When this method returns, contains the <see cref="T:System.DateTime" /> value equivalent to the date and time contained in <paramref name="s" />, if the conversion succeeded, or <see cref="F:System.DateTime.MinValue" /> if the conversion failed. The conversion fails if the <paramref name="s" /> parameter is null, is an empty string (""), or does not contain a valid string representation of a date and time. This parameter is passed uninitialized. </param>
		/// <filterpriority>1</filterpriority>
		bool TryParse(string s, out DateTime result);

		/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent using the specified culture-specific format information and formatting style, and returns a value that indicates whether the conversion succeeded.</summary>
		/// <returns>true if the <paramref name="s" /> parameter was converted successfully; otherwise, false.</returns>
		/// <param name="s">A string containing a date and time to convert. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. </param>
		/// <param name="styles">A bitwise combination of enumeration values that defines how to interpret the parsed date in relation to the current time zone or the current date. A typical value to specify is <see cref="F:System.Globalization.DateTimeStyles.None" />.</param>
		/// <param name="result">When this method returns, contains the <see cref="T:System.DateTime" /> value equivalent to the date and time contained in <paramref name="s" />, if the conversion succeeded, or <see cref="F:System.DateTime.MinValue" /> if the conversion failed. The conversion fails if the <paramref name="s" /> parameter is null, is an empty string (""), or does not contain a valid string representation of a date and time. This parameter is passed uninitialized. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="styles" /> is not a valid <see cref="T:System.Globalization.DateTimeStyles" /> value.-or-<paramref name="styles" /> contains an invalid combination of <see cref="T:System.Globalization.DateTimeStyles" /> values (for example, both <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal" /> and <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal" />).</exception>
		/// <exception cref="T:System.NotSupportedException">
		/// <paramref name="provider" /> is a neutral culture and cannot be used in a parsing operation.</exception>
		/// <filterpriority>1</filterpriority>
		bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result);

		/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent using the specified format, culture-specific format information, and style. The format of the string representation must match the specified format exactly. The method returns a value that indicates whether the conversion succeeded.</summary>
		/// <returns>true if <paramref name="s" /> was converted successfully; otherwise, false.</returns>
		/// <param name="s">A string containing a date and time to convert. </param>
		/// <param name="format">The required format of <paramref name="s" />. See the Remarks section for more information. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. </param>
		/// <param name="style">A bitwise combination of one or more enumeration values that indicate the permitted format of <paramref name="s" />. </param>
		/// <param name="result">When this method returns, contains the <see cref="T:System.DateTime" /> value equivalent to the date and time contained in <paramref name="s" />, if the conversion succeeded, or <see cref="F:System.DateTime.MinValue" /> if the conversion failed. The conversion fails if either the <paramref name="s" /> or <paramref name="format" /> parameter is null, is an empty string, or does not contain a date and time that correspond to the pattern specified in <paramref name="format" />. This parameter is passed uninitialized. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="style" /> is not a valid <see cref="T:System.Globalization.DateTimeStyles" /> value.-or-<paramref name="style" /> contains an invalid combination of <see cref="T:System.Globalization.DateTimeStyles" /> values (for example, both <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal" /> and <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal" />).</exception>
		/// <filterpriority>1</filterpriority>
		bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result);

		/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent using the specified array of formats, culture-specific format information, and style. The format of the string representation must match at least one of the specified formats exactly. The method returns a value that indicates whether the conversion succeeded.</summary>
		/// <returns>true if the <paramref name="s" /> parameter was converted successfully; otherwise, false.</returns>
		/// <param name="s">A string that contains a date and time to convert. </param>
		/// <param name="formats">An array of allowable formats of <paramref name="s" />. See the Remarks section for more information. </param>
		/// <param name="provider">An object that supplies culture-specific format information about <paramref name="s" />. </param>
		/// <param name="style">A bitwise combination of enumeration values that indicates the permitted format of <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.DateTimeStyles.None" />.</param>
		/// <param name="result">When this method returns, contains the <see cref="T:System.DateTime" /> value equivalent to the date and time contained in <paramref name="s" />, if the conversion succeeded, or <see cref="F:System.DateTime.MinValue" /> if the conversion failed. The conversion fails if <paramref name="s" /> or <paramref name="formats" /> is null, <paramref name="s" /> or an element of <paramref name="formats" /> is an empty string, or the format of <paramref name="s" /> is not exactly as specified by at least one of the format patterns in <paramref name="formats" />. This parameter is passed uninitialized. </param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="style" /> is not a valid <see cref="T:System.Globalization.DateTimeStyles" /> value.-or-<paramref name="style" /> contains an invalid combination of <see cref="T:System.Globalization.DateTimeStyles" /> values (for example, both <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal" /> and <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal" />).</exception>
		/// <filterpriority>1</filterpriority>
		bool TryParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style, out DateTime result);

#if NET45 || NET462 || NETSTANDARD2_0
		/// <summary>Returns a <see cref="T:System.DateTime" /> equivalent to the specified OLE Automation Date.</summary>
		/// <returns>An object that represents the same date and time as <paramref name="d" />.</returns>
		/// <param name="d">An OLE Automation Date value. </param>
		/// <exception cref="T:System.ArgumentException">The date is not a valid OLE Automation Date value. </exception>
		/// <filterpriority>1</filterpriority>
		// ReSharper disable once InconsistentNaming
		DateTime FromOADate(double d);
#endif

		/// <summary>Returns an indication whether the specified year is a leap year.</summary>
		/// <returns>true if <paramref name="year" /> is a leap year; otherwise, false.</returns>
		/// <param name="year">A 4-digit year. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="year" /> is less than 1 or greater than 9999.</exception>
		/// <filterpriority>1</filterpriority>
		bool IsLeapYear(int year);
	}
}
