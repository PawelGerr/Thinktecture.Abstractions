using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using JetBrains.Annotations;

// ReSharper disable AnnotationRedundancyInHierarchy
// ReSharper disable once AssignNullToNotNullAttribute

namespace Thinktecture.Collections.Generic
{
	/// <summary>
	/// Adapter for collections.
	/// </summary>
	/// <typeparam name="TItem">Item type.</typeparam>
	/// <typeparam name="TImplementation">Type of the implementation.</typeparam>
	public class CollectionAbstractionAdapter<TItem, TImplementation> : AbstractionAdapter, ICollectionAbstraction<TItem, TImplementation>
		where TImplementation : class, ICollection<TItem>
	{
		/// <summary>
		/// Inner collection.
		/// </summary>
		[NotNull]
		protected readonly TImplementation Collection;

		/// <inheritdoc />
		public int Count => Collection.Count;

		/// <inheritdoc />
		public bool IsReadOnly => Collection.IsReadOnly;

		/// <summary>
		/// Initializes new instance of <see cref="CollectionAbstractionAdapter{TAbstractionItem,TImplementationItem,TImplementation}"/>.
		/// </summary>
		/// <param name="collection">Collection to be used by the adapter.</param>
		protected CollectionAbstractionAdapter([NotNull] TImplementation collection)
			: base(collection)
		{
			Collection = collection ?? throw new ArgumentNullException(nameof(collection));
		}

		/// <inheritdoc cref="ICollectionAbstraction{TAbstractionItem,TImplementationItem,TImplementation}.UnsafeConvert" />
		[NotNull]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new TImplementation UnsafeConvert()
		{
			return Collection;
		}

		/// <inheritdoc />
		[NotNull]
		public IEnumerator<TItem> GetEnumerator()
		{
			foreach (var item in Collection)
			{
				yield return item;
			}
		}

		/// <inheritdoc />
		[NotNull]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		/// <inheritdoc cref="ICollection{T}.Add" />
		public void Add([CanBeNull] TItem item)
		{
			Collection.Add(item);
		}

		/// <inheritdoc />
		public void Clear()
		{
			Collection.Clear();
		}

		/// <inheritdoc cref="ICollection{T}.Contains" />
		public bool Contains([CanBeNull] TItem item)
		{
			return Collection.Contains(item);
		}

		/// <inheritdoc cref="ICollection{T}.CopyTo" />
		public void CopyTo([NotNull] TItem[] array, int arrayIndex)
		{
			Collection.CopyTo(array, arrayIndex);
		}

		/// <inheritdoc cref="ICollection{T}.Remove" />
		public bool Remove([CanBeNull] TItem item)
		{
			return Collection.Remove(item);
		}
	}

	/// <summary>
	/// Adapter for collections.
	/// </summary>
	/// <typeparam name="TAbstractionItem">Item type of the abstraction.</typeparam>
	/// <typeparam name="TImplementationItem">Item type of the implementation.</typeparam>
	/// <typeparam name="TImplementation">Type of the implementation.</typeparam>
	public class CollectionAbstractionAdapter<TAbstractionItem, TImplementationItem, TImplementation> : AbstractionAdapter, ICollectionAbstraction<TAbstractionItem, TImplementationItem, TImplementation>
		where TAbstractionItem : IAbstraction<TImplementationItem>
		where TImplementation : class, ICollection<TImplementationItem>
	{
		/// <summary>
		/// Inner collection.
		/// </summary>
		[NotNull]
		protected readonly TImplementation Collection;

		[NotNull]
		private readonly Func<TImplementationItem, TAbstractionItem> _toInterface;

		/// <inheritdoc />
		public int Count => Collection.Count;

		/// <inheritdoc />
		public bool IsReadOnly => Collection.IsReadOnly;

		/// <summary>
		/// Initializes new instance of <see cref="CollectionAbstractionAdapter{TAbstractionItem,TImplementationItem,TImplementation}"/>.
		/// </summary>
		/// <param name="collection">Collection to be used by the adapter.</param>
		/// <param name="toInterface">Converts an item of <typeparamref name="TImplementation"/> to type <typeparamref name="TAbstractionItem"/>.</param>
		public CollectionAbstractionAdapter([NotNull] TImplementation collection, [NotNull] Func<TImplementationItem, TAbstractionItem> toInterface)
			: base(collection)
		{
			Collection = collection ?? throw new ArgumentNullException(nameof(collection));
			_toInterface = toInterface ?? throw new ArgumentNullException(nameof(toInterface));
		}

		/// <inheritdoc cref="ICollectionAbstraction{TAbstractionItem,TImplementationItem,TImplementation}.UnsafeConvert" />
		[NotNull]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new TImplementation UnsafeConvert()
		{
			return Collection;
		}

		/// <inheritdoc />
		[NotNull]
		public IEnumerator<TAbstractionItem> GetEnumerator()
		{
			foreach (var item in Collection)
			{
				yield return _toInterface(item);
			}
		}

		/// <inheritdoc />
		[NotNull]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		/// <inheritdoc />
		public void Add([CanBeNull] TAbstractionItem item)
		{
			Collection.Add(item.ToImplementation());
		}

		/// <inheritdoc />
		public void Add([CanBeNull] TImplementationItem item)
		{
			Collection.Add(item);
		}

		/// <inheritdoc />
		public void Clear()
		{
			Collection.Clear();
		}

		/// <inheritdoc />
		public bool Contains([CanBeNull] TAbstractionItem item)
		{
			return Collection.Contains(item.ToImplementation());
		}

		/// <inheritdoc />
		public bool Contains([CanBeNull] TImplementationItem item)
		{
			return Collection.Contains(item);
		}

		/// <inheritdoc />
		public void CopyTo([NotNull] TAbstractionItem[] array, int arrayIndex)
		{
			Collection.CopyTo(array.ToImplementation<TAbstractionItem, TImplementationItem>(), arrayIndex);
		}

		/// <inheritdoc />
		public void CopyTo([NotNull] TImplementationItem[] array, int arrayIndex)
		{
			Collection.CopyTo(array, arrayIndex);
		}

		/// <inheritdoc />
		public bool Remove([CanBeNull] TAbstractionItem item)
		{
			return Collection.Remove(item.ToImplementation());
		}

		/// <inheritdoc />
		public bool Remove([CanBeNull] TImplementationItem item)
		{
			return Collection.Remove(item);
		}
	}
}
