using System;
using System.Collections.Generic;

namespace Thinktecture.Collections.Generic
{
	/// <summary>
	/// Use <see cref="Object.ReferenceEquals"/> for comparison.
	/// </summary>
	/// <typeparam name="T">Type of item to compare.</typeparam>
	public class InstanceEqualityComparer<T> : IEqualityComparer<T>
	{
		/// <inheritdoc />
		public bool Equals(T x, T y)
		{
			return ReferenceEquals(x, y);
		}

		/// <inheritdoc />
		public int GetHashCode(T obj)
		{
			return obj?.GetHashCode() ?? 0;
		}
	}
}