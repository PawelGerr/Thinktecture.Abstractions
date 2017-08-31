using System.ComponentModel;
using JetBrains.Annotations;

namespace Thinktecture
{
	/// <summary>
	/// Base class for all adapters.
	/// </summary>
	/// <typeparam name="TImplementation">Type of the implementation.</typeparam>
	public class AbstractionAdapter<TImplementation> : IAbstraction<TImplementation>
	{
		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		[NotNull]
		protected TImplementation Implementation { get; }

		/// <summary>
		/// Initializes new instance of <see cref="AbstractionAdapter{TImplementation}"/>.
		/// </summary>
		/// <param name="implementation">Implementation to be used by the adapter.</param>
		public AbstractionAdapter([NotNull] TImplementation implementation)
		{
			Implementation = implementation;
		}

		/// <inheritdoc />
		[NotNull]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public TImplementation UnsafeConvert()
		{
			return Implementation;
		}

		/// <inheritdoc />
		[NotNull]
		[EditorBrowsable(EditorBrowsableState.Never)]
		object IAbstraction.UnsafeConvert()
		{
			return UnsafeConvert();
		}

		/// <summary>
		/// Returns a string that represents the current object.
		/// </summary>
		/// <returns>A string that represents the current object.</returns>
		// ReSharper disable once AnnotationRedundancyInHierarchy
		[NotNull]
		public override string ToString()
		{
			// ReSharper disable once AssignNullToNotNullAttribute
			return Implementation.ToString();
		}

		/// <summary>
		/// Determines whether the specified object is equal to the current object.
		/// </summary>
		/// <param name="obj">The object to compare with the current object.</param>
		/// <returns><c>true</c> if the specified object is equal to the current object; otherwise, <c>false</c>.</returns>
		// ReSharper disable once AnnotationRedundancyInHierarchy
		public override bool Equals([CanBeNull] object obj)
		{
			// Use the inner implementation if and only if the other object is an adapter as well
			// because equality must be reflexive, symmetric and transitive.

			if (obj is IAbstraction<TImplementation> abstraction)
				return Implementation.Equals(abstraction.UnsafeConvert());

			if (obj is IAbstraction nonGenericAbstraction)
				return Implementation.Equals(nonGenericAbstraction.UnsafeConvert());

			// ReSharper disable once BaseObjectEqualsIsObjectEquals
			return base.Equals(obj);
		}

		/// <summary>
		/// Serves as the default hash function.
		/// </summary>
		/// <returns>A hash code for the current object.</returns>
		public override int GetHashCode()
		{
			return Implementation.GetHashCode();
		}
	}
}
