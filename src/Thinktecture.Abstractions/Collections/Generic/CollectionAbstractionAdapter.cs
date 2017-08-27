using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Thinktecture.Collections.Generic
{
	/// <summary>
	/// Adapter for collections.
	/// </summary>
	/// <typeparam name="TItem">Item type.</typeparam>
	/// <typeparam name="TImplementation">Type of the implementation.</typeparam>
	public class CollectionAbstractionAdapter<TItem, TImplementation> : AbstractionAdapter, ICollectionAbstraction<TItem, TImplementation>
		where TImplementation : ICollection<TItem>
	{
		/// <summary>
		/// Inner collection.
		/// </summary>
		protected readonly TImplementation Collection;

		/// <inheritdoc />
		public int Count => Collection.Count;

		/// <inheritdoc />
		public bool IsReadOnly => Collection.IsReadOnly;

		/// <summary>
		/// Initializes new instance of <see cref="CollectionAbstractionAdapter{TAbstractionItem,TImplementationItem,TImplementation}"/>.
		/// </summary>
		/// <param name="collection">Collection to be used by the adapter.</param>
		public CollectionAbstractionAdapter(TImplementation collection)
			: base(collection)
		{
			if (collection == null)
				throw new ArgumentNullException(nameof(collection));

			Collection = collection;
		}

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new TImplementation UnsafeConvert()
		{
			return Collection;
		}

		/// <inheritdoc />
		public IEnumerator<TItem> GetEnumerator()
		{
			foreach (var item in Collection)
			{
				yield return item;
			}
		}

		/// <inheritdoc />
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		/// <inheritdoc />
		public void Add(TItem item)
		{
			Collection.Add(item);
		}

		/// <inheritdoc />
		public void Clear()
		{
			Collection.Clear();
		}

		/// <inheritdoc />
		public bool Contains(TItem item)
		{
			return Collection.Contains(item);
		}

		/// <inheritdoc />
		public void CopyTo(TItem[] array, int arrayIndex)
		{
			Collection.CopyTo(array, arrayIndex);
		}

		/// <inheritdoc />
		public bool Remove(TItem item)
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
		where TImplementation : ICollection<TImplementationItem>
	{
		/// <summary>
		/// Inner collection.
		/// </summary>
		protected readonly TImplementation Collection;

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
		public CollectionAbstractionAdapter(TImplementation collection, Func<TImplementationItem, TAbstractionItem> toInterface)
			: base(collection)
		{
			if (collection == null)
				throw new ArgumentNullException(nameof(collection));

			Collection = collection;
			_toInterface = toInterface ?? throw new ArgumentNullException(nameof(toInterface));
		}

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new TImplementation UnsafeConvert()
		{
			return Collection;
		}

		/// <inheritdoc />
		public IEnumerator<TAbstractionItem> GetEnumerator()
		{
			foreach (var item in Collection)
			{
				yield return _toInterface(item);
			}
		}

		/// <inheritdoc />
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		/// <inheritdoc />
		public void Add(TAbstractionItem item)
		{
			Collection.Add(item.ToImplementation());
		}

		/// <inheritdoc />
		public void Add(TImplementationItem item)
		{
			Collection.Add(item);
		}

		/// <inheritdoc />
		public void Clear()
		{
			Collection.Clear();
		}

		/// <inheritdoc />
		public bool Contains(TAbstractionItem item)
		{
			return Collection.Contains(item.ToImplementation());
		}

		/// <inheritdoc />
		public bool Contains(TImplementationItem item)
		{
			return Collection.Contains(item);
		}

		/// <inheritdoc />
		public void CopyTo(TAbstractionItem[] array, int arrayIndex)
		{
			Collection.CopyTo(array.ToImplementation<TAbstractionItem, TImplementationItem>(), arrayIndex);
		}

		/// <inheritdoc />
		public void CopyTo(TImplementationItem[] array, int arrayIndex)
		{
			Collection.CopyTo(array, arrayIndex);
		}

		/// <inheritdoc />
		public bool Remove(TAbstractionItem item)
		{
			return Collection.Remove(item.ToImplementation());
		}

		/// <inheritdoc />
		public bool Remove(TImplementationItem item)
		{
			return Collection.Remove(item);
		}
	}
}
