using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;

// ReSharper disable AnnotationRedundancyInHierarchy

namespace Thinktecture.Collections.Generic
{
	/// <summary>
	/// Use provided callbacks for comparison.
	/// </summary>
	/// <typeparam name="T">Type of item to compare.</typeparam>
	public class GenericEqualityComparer<T> : IEqualityComparer<T>
	{
		[NotNull]
		private readonly Func<T, T, bool> _equals;

		[NotNull]
		private readonly Func<T, int> _getHashCode;

		/// <summary>
		/// Initializes new instance of <see cref="GenericEqualityComparer{T}"/>
		/// </summary>
		/// <param name="equals">Callback for equality comparison.</param>
		/// <param name="getHashCode">Callback for computation of the hashcode</param>
		public GenericEqualityComparer([NotNull] Func<T, T, bool> equals, [NotNull] Func<T, int> getHashCode)
		{
			_equals = equals ?? throw new ArgumentNullException(nameof(equals));
			_getHashCode = getHashCode ?? throw new ArgumentNullException(nameof(getHashCode));
		}

		/// <inheritdoc />
		public bool Equals([CanBeNull] T x, [CanBeNull] T y)
		{
			return _equals(x, y);
		}

		/// <inheritdoc />
		public int GetHashCode([CanBeNull] T obj)
		{
			return _getHashCode(obj);
		}
	}
}
