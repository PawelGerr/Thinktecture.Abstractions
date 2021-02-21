using System;
using System.Collections;
using System.Collections.Generic;

namespace Thinktecture.Collections.Generic
{
   /// <summary>
   /// Adapter for collections.
   /// </summary>
   /// <typeparam name="TAbstractionItem">Item type of the abstraction.</typeparam>
   /// <typeparam name="TImplementationItem">Item type of the implementation.</typeparam>
   /// <typeparam name="TImplementation">Type of the implementation.</typeparam>
   public class NotNullCollectionAbstraction<TAbstractionItem, TImplementationItem, TImplementation> : AbstractionAdapter<TImplementation>, INotNullCollectionAbstraction<TAbstractionItem, TImplementationItem, TImplementation>
      where TAbstractionItem : IAbstraction<TImplementationItem>
      where TImplementationItem : notnull
      where TImplementation : class, ICollection<TImplementationItem>
   {
      private readonly Func<TImplementationItem, TAbstractionItem> _toInterface;

      /// <inheritdoc />
      public int Count => Implementation.Count;

      /// <inheritdoc />
      public bool IsReadOnly => Implementation.IsReadOnly;

      /// <summary>
      /// Initializes new instance of <see cref="CollectionAbstractionAdapter{TAbstractionItem,TImplementationItem,TImplementation}"/>.
      /// </summary>
      /// <param name="collection">Collection to be used by the adapter.</param>
      /// <param name="toInterface">Converts an item of <typeparamref name="TImplementation"/> to type <typeparamref name="TAbstractionItem"/>.</param>
      public NotNullCollectionAbstraction(TImplementation collection, Func<TImplementationItem, TAbstractionItem> toInterface)
         : base(collection)
      {
         _toInterface = toInterface ?? throw new ArgumentNullException(nameof(toInterface));
      }

      /// <inheritdoc />
      public IEnumerator<TAbstractionItem> GetEnumerator()
      {
         foreach (var item in Implementation)
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
         Implementation.Add(item.ToImplementation());
      }

      /// <inheritdoc />
      public void Add(TImplementationItem item)
      {
         Implementation.Add(item);
      }

      /// <inheritdoc />
      public void Clear()
      {
         Implementation.Clear();
      }

      /// <inheritdoc />
      public bool Contains(TAbstractionItem item)
      {
         return Implementation.Contains(item.ToImplementation());
      }

      /// <inheritdoc />
      public bool Contains(TImplementationItem item)
      {
         return Implementation.Contains(item);
      }

      /// <inheritdoc />
      public void CopyTo(TAbstractionItem[] array, int arrayIndex)
      {
         Implementation.CopyTo(array.ToImplementation<TAbstractionItem, TImplementationItem>()!, arrayIndex);
      }

      /// <inheritdoc />
      public void CopyTo(TImplementationItem[] array, int arrayIndex)
      {
         Implementation.CopyTo(array, arrayIndex);
      }

      /// <inheritdoc />
      public bool Remove(TAbstractionItem item)
      {
         return Implementation.Remove(item.ToImplementation());
      }

      /// <inheritdoc />
      public bool Remove(TImplementationItem item)
      {
         return Implementation.Remove(item);
      }
   }
}
