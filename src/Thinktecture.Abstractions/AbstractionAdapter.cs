using System;
using System.ComponentModel;

namespace Thinktecture
{
	/// <summary>
	/// Base class for all adapters.
	/// </summary>
	public class AbstractionAdapter : IAbstraction
	{
		private readonly object _implementation;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object UnsafeConvert()
		{
			return _implementation;
		}

		/// <summary>
		/// Initializes new instance of <see cref="AbstractionAdapter"/>.
		/// </summary>
		/// <param name="implementation">Implementation to be used by the adapter.</param>
		public AbstractionAdapter(object implementation)
		{
			_implementation = implementation ?? throw new ArgumentNullException(nameof(implementation));
		}

		/// <summary>
		/// Returns a string that represents the current object.
		/// </summary>
		/// <returns>A string that represents the current object.</returns>
		public override string ToString()
		{
			return _implementation.ToString();
		}

		/// <summary>
		/// Determines whether the specified object is equal to the current object.
		/// </summary>
		/// <param name="obj">The object to compare with the current object.</param>
		/// <returns><c>true</c> if the specified object is equal to the current object; otherwise, <c>false</c>.</returns>
		public override bool Equals(object obj)
		{
			// Use the inner implementation if and only if the other object is an adapter as well
			// because equality must be reflexive, symmetric and transitive.

			var abstraction = obj as IAbstraction;

			if (abstraction != null)
				return _implementation.Equals(abstraction.UnsafeConvert());

			// ReSharper disable once BaseObjectEqualsIsObjectEquals
			return base.Equals(obj);
		}

		/// <summary>
		/// Serves as the default hash function.
		/// </summary>
		/// <returns>A hash code for the current object.</returns>
		public override int GetHashCode()
		{
			return _implementation.GetHashCode();
		}
	}
}