using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;

namespace Thinktecture.Text.Adapters
{
	/// <summary>
	/// Adapter for <see cref="StringBuilder"/>.
	/// </summary>
	public class StringBuilderAdapter : IStringBuilder
	{
		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public StringBuilder InternalInstance { get; }

		/// <inheritdoc />
		public int Capacity
		{
			get { return InternalInstance.Capacity; }
			set { InternalInstance.Capacity = value; }
		}

		/// <inheritdoc />
		[IndexerName("Chars")]
		public char this[int index]
		{
			get { return InternalInstance[index]; }
			set { InternalInstance[index] = value; }
		}

		/// <inheritdoc />
		public int Length
		{
			get { return InternalInstance.Length; }
			set { InternalInstance.Length = value; }
		}

		/// <inheritdoc />
		public int MaxCapacity => InternalInstance.MaxCapacity;

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
		public StringBuilderAdapter(string value)
			: this(new StringBuilder(value))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StringBuilderAdapter" /> class using the specified string and capacity.</summary>
		/// <param name="value">The string used to initialize the value of the instance. If <paramref name="value" /> is null, the new <see cref="StringBuilderAdapter" /> will contain the empty string (that is, it contains <see cref="F:System.String.Empty" />). </param>
		/// <param name="capacity">The suggested starting size of the <see cref="StringBuilderAdapter" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="capacity" /> is less than zero. </exception>
		public StringBuilderAdapter(string value, int capacity)
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
		public StringBuilderAdapter(string value, int startIndex, int length, int capacity)
			: this(new StringBuilder(value, startIndex, length, capacity))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="StringBuilderAdapter" /> class.
		/// </summary>
		/// <param name="stringBuilder"><see cref="StringBuilder"/> to be used by the adapter.</param>
		public StringBuilderAdapter(StringBuilder stringBuilder)
		{
			if (stringBuilder == null)
				throw new ArgumentNullException(nameof(stringBuilder));

			InternalInstance = stringBuilder;
		}

		/// <inheritdoc />
		public IStringBuilder Append(bool value)
		{
			InternalInstance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(byte value)
		{
			InternalInstance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(char value)
		{
			InternalInstance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(char value, int repeatCount)
		{
			InternalInstance.Append(value, repeatCount);
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public IStringBuilder Append(char[] value)
		{
			InternalInstance.Append(value);
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public IStringBuilder Append(char[] value, int startIndex, int charCount)
		{
			InternalInstance.Append(value, startIndex, charCount);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(Decimal value)
		{
			InternalInstance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(double value)
		{
			InternalInstance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(short value)
		{
			InternalInstance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(int value)
		{
			InternalInstance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(long value)
		{
			InternalInstance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(object value)
		{
			InternalInstance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(sbyte value)
		{
			InternalInstance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(float value)
		{
			InternalInstance.Append(value);
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public IStringBuilder Append(string value)
		{
			InternalInstance.Append(value);
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public IStringBuilder Append(string value, int startIndex, int count)
		{
			InternalInstance.Append(value, startIndex, count);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(ushort value)
		{
			InternalInstance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(uint value)
		{
			InternalInstance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(ulong value)
		{
			InternalInstance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder AppendFormat(IFormatProvider provider, string format, params object[] args)
		{
			InternalInstance.AppendFormat(provider, format, args);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder AppendFormat(string format, params object[] args)
		{
			InternalInstance.AppendFormat(format, args);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder AppendLine()
		{
			InternalInstance.AppendLine();
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder AppendLine(string value)
		{
			InternalInstance.AppendLine(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Clear()
		{
			InternalInstance.Clear();
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
		{
			InternalInstance.CopyTo(sourceIndex, destination, destinationIndex, count);
		}

		/// <inheritdoc />
		public int EnsureCapacity(int capacity)
		{
			return InternalInstance.EnsureCapacity(capacity);
		}

		/// <inheritdoc />
		public bool Equals(IStringBuilder sb)
		{
			return InternalInstance.Equals(sb.ToImplementation());
		}

		/// <inheritdoc />
		public bool Equals(StringBuilder sb)
		{
			return InternalInstance.Equals(sb);
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, bool value)
		{
			InternalInstance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, byte value)
		{
			InternalInstance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public IStringBuilder Insert(int index, char value)
		{
			InternalInstance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, char[] value)
		{
			InternalInstance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public IStringBuilder Insert(int index, char[] value, int startIndex, int charCount)
		{
			InternalInstance.Insert(index, value, startIndex, charCount);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, Decimal value)
		{
			InternalInstance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, double value)
		{
			InternalInstance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, short value)
		{
			InternalInstance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, int value)
		{
			InternalInstance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, long value)
		{
			InternalInstance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, object value)
		{
			InternalInstance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, sbyte value)
		{
			InternalInstance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, float value)
		{
			InternalInstance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public IStringBuilder Insert(int index, string value)
		{
			InternalInstance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public IStringBuilder Insert(int index, string value, int count)
		{
			InternalInstance.Insert(index, value, count);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, ushort value)
		{
			InternalInstance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, uint value)
		{
			InternalInstance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, ulong value)
		{
			InternalInstance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Remove(int startIndex, int length)
		{
			InternalInstance.Remove(startIndex, length);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Replace(char oldChar, char newChar)
		{
			InternalInstance.Replace(oldChar, newChar);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Replace(char oldChar, char newChar, int startIndex, int count)
		{
			InternalInstance.Replace(oldChar, newChar, startIndex, Length);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Replace(string oldValue, string newValue)
		{
			InternalInstance.Replace(oldValue, newValue);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Replace(string oldValue, string newValue, int startIndex, int count)
		{
			InternalInstance.Replace(oldValue, newValue, startIndex, count);
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public override string ToString()
		{
			return InternalInstance.ToString();
		}

		/// <inheritdoc />
		public string ToString(int startIndex, int length)
		{
			return InternalInstance.ToString(startIndex, length);
		}

		/// <inheritdoc />
		public override bool Equals(object obj)
		{
			return InternalInstance.Equals(obj);
		}

		/// <inheritdoc />
		public override int GetHashCode()
		{
			return InternalInstance.GetHashCode();
		}
	}
}