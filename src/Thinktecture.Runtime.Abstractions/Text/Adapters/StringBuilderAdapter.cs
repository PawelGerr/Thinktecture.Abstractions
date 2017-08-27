using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Text.Adapters
{
	/// <summary>
	/// Adapter for <see cref="StringBuilder"/>.
	/// </summary>
	public class StringBuilderAdapter : AbstractionAdapter<StringBuilder>, IStringBuilder
	{
		/// <inheritdoc />
		public int Capacity
		{
			get => Implementation.Capacity;
			set => Implementation.Capacity = value;
		}

		/// <inheritdoc />
		[IndexerName("Chars")]
		public char this[int index]
		{
			get => Implementation[index];
			set => Implementation[index] = value;
		}

		/// <inheritdoc />
		public int Length
		{
			get => Implementation.Length;
			set => Implementation.Length = value;
		}

		/// <inheritdoc />
		public int MaxCapacity => Implementation.MaxCapacity;

		/// <summary>Initializes a new instance of the <see cref="StringBuilderAdapter" /> class.</summary>
		public StringBuilderAdapter()
			: this(new StringBuilder())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StringBuilderAdapter" /> class using the specified capacity.</summary>
		/// <param name="capacity">The suggested starting size of this instance. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="capacity" /> is less than zero. </exception>
		public StringBuilderAdapter(int capacity)
			: this(new StringBuilder(capacity))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StringBuilderAdapter" /> class that starts with a specified capacity and can grow to a specified maximum.</summary>
		/// <param name="capacity">The suggested starting size of the <see cref="StringBuilderAdapter" />. </param>
		/// <param name="maxCapacity">The maximum number of characters the current string can contain. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="maxCapacity" /> is less than one, <paramref name="capacity" /> is less than zero, or <paramref name="capacity" /> is greater than <paramref name="maxCapacity" />. </exception>
		public StringBuilderAdapter(int capacity, int maxCapacity)
			: this(new StringBuilder(capacity, maxCapacity))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StringBuilderAdapter" /> class using the specified string.</summary>
		/// <param name="value">The string used to initialize the value of the instance. If <paramref name="value" /> is null, the new <see cref="StringBuilderAdapter" /> will contain the empty string (that is, it contains <see cref="F:System.String.Empty" />). </param>
		public StringBuilderAdapter([CanBeNull] string value)
			: this(new StringBuilder(value))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StringBuilderAdapter" /> class using the specified string and capacity.</summary>
		/// <param name="value">The string used to initialize the value of the instance. If <paramref name="value" /> is null, the new <see cref="StringBuilderAdapter" /> will contain the empty string (that is, it contains <see cref="F:System.String.Empty" />). </param>
		/// <param name="capacity">The suggested starting size of the <see cref="StringBuilderAdapter" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="capacity" /> is less than zero. </exception>
		public StringBuilderAdapter([CanBeNull] string value, int capacity)
			: this(new StringBuilder(value, capacity))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StringBuilderAdapter" /> class from the specified substring and capacity.</summary>
		/// <param name="value">The string that contains the substring used to initialize the value of this instance. If <paramref name="value" /> is null, the new <see cref="StringBuilderAdapter" /> will contain the empty string (that is, it contains <see cref="F:System.String.Empty" />). </param>
		/// <param name="startIndex">The position within <paramref name="value" /> where the substring begins. </param>
		/// <param name="length">The number of characters in the substring. </param>
		/// <param name="capacity">The suggested starting size of the <see cref="StringBuilderAdapter" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="capacity" /> is less than zero.-or- <paramref name="startIndex" /> plus <paramref name="length" /> is not a position within <paramref name="value" />. </exception>
		[SecuritySafeCritical]
		public StringBuilderAdapter([CanBeNull] string value, int startIndex, int length, int capacity)
			: this(new StringBuilder(value, startIndex, length, capacity))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="StringBuilderAdapter" /> class.
		/// </summary>
		/// <param name="stringBuilder"><see cref="StringBuilder"/> to be used by the adapter.</param>
		public StringBuilderAdapter([NotNull] StringBuilder stringBuilder)
			: base(stringBuilder)
		{
		}

		/// <inheritdoc />
		public IStringBuilder Append(bool value)
		{
			Implementation.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(byte value)
		{
			Implementation.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(char value)
		{
			Implementation.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(char value, int repeatCount)
		{
			Implementation.Append(value, repeatCount);
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public IStringBuilder Append(char[] value)
		{
			Implementation.Append(value);
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public IStringBuilder Append(char[] value, int startIndex, int charCount)
		{
			Implementation.Append(value, startIndex, charCount);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(decimal value)
		{
			Implementation.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(double value)
		{
			Implementation.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(short value)
		{
			Implementation.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(int value)
		{
			Implementation.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(long value)
		{
			Implementation.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(object value)
		{
			Implementation.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(sbyte value)
		{
			Implementation.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(float value)
		{
			Implementation.Append(value);
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public IStringBuilder Append(string value)
		{
			Implementation.Append(value);
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public IStringBuilder Append(string value, int startIndex, int count)
		{
			Implementation.Append(value, startIndex, count);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(ushort value)
		{
			Implementation.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(uint value)
		{
			Implementation.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(ulong value)
		{
			Implementation.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder AppendFormat(IFormatProvider provider, string format, params object[] args)
		{
			Implementation.AppendFormat(provider, format, args);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder AppendFormat(string format, params object[] args)
		{
			Implementation.AppendFormat(format, args);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder AppendLine()
		{
			Implementation.AppendLine();
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder AppendLine(string value)
		{
			Implementation.AppendLine(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Clear()
		{
			Implementation.Clear();
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
		{
			Implementation.CopyTo(sourceIndex, destination, destinationIndex, count);
		}

		/// <inheritdoc />
		public int EnsureCapacity(int capacity)
		{
			return Implementation.EnsureCapacity(capacity);
		}

		/// <inheritdoc />
		public bool Equals(IStringBuilder sb)
		{
			return Implementation.Equals(sb.ToImplementation());
		}

		/// <inheritdoc />
		public bool Equals(StringBuilder sb)
		{
			return Implementation.Equals(sb);
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, bool value)
		{
			Implementation.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, byte value)
		{
			Implementation.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public IStringBuilder Insert(int index, char value)
		{
			Implementation.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, char[] value)
		{
			Implementation.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public IStringBuilder Insert(int index, char[] value, int startIndex, int charCount)
		{
			Implementation.Insert(index, value, startIndex, charCount);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, decimal value)
		{
			Implementation.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, double value)
		{
			Implementation.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, short value)
		{
			Implementation.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, int value)
		{
			Implementation.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, long value)
		{
			Implementation.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, object value)
		{
			Implementation.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, sbyte value)
		{
			Implementation.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, float value)
		{
			Implementation.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public IStringBuilder Insert(int index, string value)
		{
			Implementation.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public IStringBuilder Insert(int index, string value, int count)
		{
			Implementation.Insert(index, value, count);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, ushort value)
		{
			Implementation.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, uint value)
		{
			Implementation.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, ulong value)
		{
			Implementation.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Remove(int startIndex, int length)
		{
			Implementation.Remove(startIndex, length);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Replace(char oldChar, char newChar)
		{
			Implementation.Replace(oldChar, newChar);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Replace(char oldChar, char newChar, int startIndex, int count)
		{
			Implementation.Replace(oldChar, newChar, startIndex, Length);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Replace(string oldValue, string newValue)
		{
			Implementation.Replace(oldValue, newValue);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Replace(string oldValue, string newValue, int startIndex, int count)
		{
			Implementation.Replace(oldValue, newValue, startIndex, count);
			return this;
		}

		/// <inheritdoc />
		public string ToString(int startIndex, int length)
		{
			return Implementation.ToString(startIndex, length);
		}
	}
}
