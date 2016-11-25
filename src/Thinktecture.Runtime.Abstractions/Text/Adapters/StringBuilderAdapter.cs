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
	public class StringBuilderAdapter : AbstractionAdapter, IStringBuilder
	{
		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new StringBuilder UnsafeConvert()
		{
			return _instance;
		}

		private readonly StringBuilder _instance;

		/// <inheritdoc />
		public int Capacity
		{
			get { return _instance.Capacity; }
			set { _instance.Capacity = value; }
		}

		/// <inheritdoc />
		[IndexerName("Chars")]
		public char this[int index]
		{
			get { return _instance[index]; }
			set { _instance[index] = value; }
		}

		/// <inheritdoc />
		public int Length
		{
			get { return _instance.Length; }
			set { _instance.Length = value; }
		}

		/// <inheritdoc />
		public int MaxCapacity => _instance.MaxCapacity;

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
			: base(stringBuilder)
		{
			if (stringBuilder == null)
				throw new ArgumentNullException(nameof(stringBuilder));

			_instance = stringBuilder;
		}

		/// <inheritdoc />
		public IStringBuilder Append(bool value)
		{
			_instance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(byte value)
		{
			_instance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(char value)
		{
			_instance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(char value, int repeatCount)
		{
			_instance.Append(value, repeatCount);
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public IStringBuilder Append(char[] value)
		{
			_instance.Append(value);
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public IStringBuilder Append(char[] value, int startIndex, int charCount)
		{
			_instance.Append(value, startIndex, charCount);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(Decimal value)
		{
			_instance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(double value)
		{
			_instance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(short value)
		{
			_instance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(int value)
		{
			_instance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(long value)
		{
			_instance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(object value)
		{
			_instance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(sbyte value)
		{
			_instance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(float value)
		{
			_instance.Append(value);
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public IStringBuilder Append(string value)
		{
			_instance.Append(value);
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public IStringBuilder Append(string value, int startIndex, int count)
		{
			_instance.Append(value, startIndex, count);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(ushort value)
		{
			_instance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(uint value)
		{
			_instance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Append(ulong value)
		{
			_instance.Append(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder AppendFormat(IFormatProvider provider, string format, params object[] args)
		{
			_instance.AppendFormat(provider, format, args);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder AppendFormat(string format, params object[] args)
		{
			_instance.AppendFormat(format, args);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder AppendLine()
		{
			_instance.AppendLine();
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder AppendLine(string value)
		{
			_instance.AppendLine(value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Clear()
		{
			_instance.Clear();
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
		{
			_instance.CopyTo(sourceIndex, destination, destinationIndex, count);
		}

		/// <inheritdoc />
		public int EnsureCapacity(int capacity)
		{
			return _instance.EnsureCapacity(capacity);
		}

		/// <inheritdoc />
		public bool Equals(IStringBuilder sb)
		{
			return _instance.Equals(sb.ToImplementation());
		}

		/// <inheritdoc />
		public bool Equals(StringBuilder sb)
		{
			return _instance.Equals(sb);
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, bool value)
		{
			_instance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, byte value)
		{
			_instance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public IStringBuilder Insert(int index, char value)
		{
			_instance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, char[] value)
		{
			_instance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public IStringBuilder Insert(int index, char[] value, int startIndex, int charCount)
		{
			_instance.Insert(index, value, startIndex, charCount);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, Decimal value)
		{
			_instance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, double value)
		{
			_instance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, short value)
		{
			_instance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, int value)
		{
			_instance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, long value)
		{
			_instance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, object value)
		{
			_instance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, sbyte value)
		{
			_instance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, float value)
		{
			_instance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public IStringBuilder Insert(int index, string value)
		{
			_instance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		[SecuritySafeCritical]
		public IStringBuilder Insert(int index, string value, int count)
		{
			_instance.Insert(index, value, count);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, ushort value)
		{
			_instance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, uint value)
		{
			_instance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Insert(int index, ulong value)
		{
			_instance.Insert(index, value);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Remove(int startIndex, int length)
		{
			_instance.Remove(startIndex, length);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Replace(char oldChar, char newChar)
		{
			_instance.Replace(oldChar, newChar);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Replace(char oldChar, char newChar, int startIndex, int count)
		{
			_instance.Replace(oldChar, newChar, startIndex, Length);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Replace(string oldValue, string newValue)
		{
			_instance.Replace(oldValue, newValue);
			return this;
		}

		/// <inheritdoc />
		public IStringBuilder Replace(string oldValue, string newValue, int startIndex, int count)
		{
			_instance.Replace(oldValue, newValue, startIndex, count);
			return this;
		}

		/// <inheritdoc />
		public string ToString(int startIndex, int length)
		{
			return _instance.ToString(startIndex, length);
		}
	}
}