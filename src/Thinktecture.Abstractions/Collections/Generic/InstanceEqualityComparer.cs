using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Thinktecture.Collections.Generic
{
	/// <summary>
	/// Use <see cref="Object.ReferenceEquals"/> for comparison.
	/// </summary>
	/// <typeparam name="T">Type of item to compare.</typeparam>
	public class InstanceEqualityComparer<T> : IEqualityComparer<T>
	{
		/// <inheritdoc />
		public bool Equals([CanBeNull] T x, [CanBeNull] T y)
		{
			return ReferenceEquals(x, y);
		}

		/// <inheritdoc />
		public int GetHashCode([CanBeNull] T obj)
		{
			return obj?.GetHashCode() ?? 0;
		}
	}
}
