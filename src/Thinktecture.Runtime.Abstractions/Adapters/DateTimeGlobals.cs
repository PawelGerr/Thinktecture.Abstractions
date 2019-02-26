using System;
using System.Globalization;

namespace Thinktecture.Adapters
{
	/// <summary>
	/// Statics of <see cref="DateTime"/>.
	/// </summary>
	public class DateTimeGlobals : IDateTimeGlobals
	{
		/// <inheritdoc />
		public DateTime MaxValue => DateTime.MaxValue;

		/// <inheritdoc />
		public DateTime MinValue => DateTime.MinValue;

		/// <inheritdoc />
		public DateTime Now => DateTime.Now;

		/// <inheritdoc />
		public DateTime Today => DateTime.Today;

		/// <inheritdoc />
		public DateTime UtcNow => DateTime.UtcNow;

#if NETCOREAPP2_2
		/// <inheritdoc />
		public DateTime UnixEpoch => DateTime.UnixEpoch;
#endif

		/// <inheritdoc />
		public int Compare(DateTime t1, DateTime t2)
		{
			return DateTime.Compare(t1, t2);
		}

		/// <inheritdoc />
		public int DaysInMonth(int year, int month)
		{
			return DateTime.DaysInMonth(year, month);
		}

		/// <inheritdoc />
		public bool Equals(DateTime t1, DateTime t2)
		{
			return DateTime.Equals(t1, t2);
		}

		/// <inheritdoc />
		public DateTime FromBinary(long dateData)
		{
			return DateTime.FromBinary(dateData);
		}

		/// <inheritdoc />
		public DateTime FromFileTime(long fileTime)
		{
			return DateTime.FromFileTime(fileTime);
		}

		/// <inheritdoc />
		public DateTime FromFileTimeUtc(long fileTime)
		{
			return DateTime.FromFileTimeUtc(fileTime);
		}

#if NETCOREAPP2_2
		/// <inheritdoc />
		public DateTime Parse(ReadOnlySpan<char> s, IFormatProvider provider = null, DateTimeStyles styles = DateTimeStyles.None)
		{
			return DateTime.Parse(s, provider, styles);
		}

		/// <inheritdoc />
		public DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None)
		{
			return DateTime.ParseExact(s, format, provider, style);
		}

		/// <inheritdoc />
		public DateTime ParseExact(ReadOnlySpan<char> s, string[] formats, IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None)
		{
			return DateTime.ParseExact(s, formats, provider, style);
		}

		/// <inheritdoc />
		public bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
		{
			return DateTime.TryParse(s, provider, styles, out result);
		}

		/// <inheritdoc />
		public bool TryParse(ReadOnlySpan<char> s, out DateTime result)
		{
			return DateTime.TryParse(s, out result);
		}

		/// <inheritdoc />
		public bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, IFormatProvider provider, DateTimeStyles style, out DateTime result)
		{
			return DateTime.TryParseExact(s, format, provider, style, out result);
		}

		/// <inheritdoc />
		public bool TryParseExact(ReadOnlySpan<char> s, string[] formats, IFormatProvider provider, DateTimeStyles style, out DateTime result)
		{
			return DateTime.TryParseExact(s, formats, provider, style, out result);
		}
#endif

		/// <inheritdoc />
		public DateTime Parse(string s)
		{
			return DateTime.Parse(s);
		}

		/// <inheritdoc />
		public DateTime Parse(string s, IFormatProvider provider)
		{
			return DateTime.Parse(s, provider);
		}

		/// <inheritdoc />
		public DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles)
		{
			return DateTime.Parse(s, provider, styles);
		}

		/// <inheritdoc />
		public DateTime ParseExact(string s, string format, IFormatProvider provider)
		{
			return DateTime.ParseExact(s, format, provider);
		}

		/// <inheritdoc />
		public DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style)
		{
			return DateTime.ParseExact(s, format, provider, style);
		}

		/// <inheritdoc />
		public DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style)
		{
			return DateTime.ParseExact(s, formats, provider, style);
		}

		/// <inheritdoc />
		public DateTime SpecifyKind(DateTime value, DateTimeKind kind)
		{
			return DateTime.SpecifyKind(value, kind);
		}

		/// <inheritdoc />
		public bool TryParse(string s, out DateTime result)
		{
			return DateTime.TryParse(s, out result);
		}

		/// <inheritdoc />
		public bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
		{
			return DateTime.TryParse(s, provider, styles, out result);
		}

		/// <inheritdoc />
		public bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result)
		{
			return DateTime.TryParseExact(s, format, provider, style, out result);
		}

		/// <inheritdoc />
		public bool TryParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style, out DateTime result)
		{
			return DateTime.TryParseExact(s, formats, provider, style, out result);
		}

#if NET45 || NET462 || NETSTANDARD2_0
		/// <inheritdoc />
		public DateTime FromOADate(double d)
		{
			return DateTime.FromOADate(d);
		}

#endif

		/// <inheritdoc />
		public bool IsLeapYear(int year)
		{
			return DateTime.IsLeapYear(year);
		}
	}
}
