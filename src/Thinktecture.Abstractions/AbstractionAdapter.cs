using System;
using System.ComponentModel;
using JetBrains.Annotations;

namespace Thinktecture
{
	/// <summary>
	/// Base class for all adapters.
	/// </summary>
	public class AbstractionAdapter : IAbstraction
	{
		[NotNull]
		private readonly object _implementation;

		/// <inheritdoc />
		[NotNull]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object UnsafeConvert()
		{
			return _implementation;
		}

		/// <summary>
		/// Initializes new instance of <see cref="AbstractionAdapter"/>.
		/// </summary>
		/// <param name="implementation">Implementation to be used by the adapter.</param>
		public AbstractionAdapter([NotNull] object implementation)
		{
			_implementation = implementation ?? throw new ArgumentNullException(nameof(implementation));
		}

		/// <summary>
		/// Returns a string that represents the current object.
		/// </summary>
		/// <returns>A string that represents the current object.</returns>
		[CanBeNull]
		public override string ToString()
		{
			return _implementation.ToString();
		}

		/// <summary>
		/// Determines whether the specified object is equal to the current object.
		/// </summary>
		/// <param name="obj">The object to compare with the current object.</param>
		/// <returns><c>true</c> if the specified object is equal to the current object; otherwise, <c>false</c>.</returns>
		public override bool Equals([CanBeNull] object obj)
		{
			// Use the inner implementation if and only if the other object is an adapter as well
			// because equality must be reflexive, symmetric and transitive.

			if (obj is IAbstraction abstraction)
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

	/// <summary>
	/// Base class for all adapters.
	/// </summary>
	/// <typeparam name="TImplementation">Type of the implementation.</typeparam>
	public class AbstractionAdapter<TImplementation> : AbstractionAdapter, IAbstraction<TImplementation>
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
			: base(implementation)
		{
			Implementation = implementation;
		}

		/// <inheritdoc />
		[NotNull]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new TImplementation UnsafeConvert()
		{
			return Implementation;
		}
	}
}
