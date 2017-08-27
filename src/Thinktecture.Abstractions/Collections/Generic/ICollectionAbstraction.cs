using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Thinktecture.Collections.Generic
{
	/// <summary>
	/// An abstraction for collections.
	/// </summary>
	/// <typeparam name="TImplementationItem">Tzpe of the item of the implementation.</typeparam>
	/// <typeparam name="TImplementation">Type of the implementation.</typeparam>
	public interface ICollectionAbstraction<TImplementationItem, out TImplementation> : ICollectionAbstraction<TImplementationItem, TImplementationItem, TImplementation>
		where TImplementation : ICollection<TImplementationItem>
	{
	}

	/// <summary>
	/// An abstraction for collections.
	/// </summary>
	/// <typeparam name="TAbstractionItem">Type of the abstraction.</typeparam>
	/// <typeparam name="TImplementationItem">Tzpe of the item of the implementation.</typeparam>
	/// <typeparam name="TImplementation">Type of the implementation.</typeparam>
	public interface ICollectionAbstraction<TAbstractionItem, in TImplementationItem, out TImplementation> : IAbstraction<TImplementation>, ICollection<TAbstractionItem>
		where TImplementation : ICollection<TImplementationItem>
	{
		/// <summary>
		/// Gets inner instance of <typeparamref name="TImplementation"/>.
		/// It is not intended to be used directly. Use <see cref="CollectionExtensions.ToImplementation{TAbstractionItem,TImplementationItem,TImplementation}"/> instead.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		new TImplementation UnsafeConvert();

		/// <summary>
		/// Adds item to collection.
		/// </summary>
		/// <param name="item">Item to add.</param>
		void Add(TImplementationItem item);

		/// <summary>
		/// Gets an indicator whether the item is in collection or not.
		/// </summary>
		/// <param name="item">Item to check for.</param>
		/// <returns><c>true</c> if the item is in collection; <c>false</c> otherwise.</returns>
		bool Contains(TImplementationItem item);

		/// <summary>
		/// Copies the collection to provided array.
		/// </summary>
		/// <param name="array">Array to copy into.</param>
		/// <param name="arrayIndex">Index to start to insert from.</param>
		void CopyTo(TImplementationItem[] array, int arrayIndex);

		/// <summary>
		/// Removes the item from collection.
		/// </summary>
		/// <param name="item">Item to remove.</param>
		/// <returns><c>true</c> if the item has been removed; <c>false</c> otherwise.</returns>
		bool Remove(TImplementationItem item);
	}
}
