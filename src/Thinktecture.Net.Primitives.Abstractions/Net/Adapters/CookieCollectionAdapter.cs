using System;
using System.Collections;
using System.Net;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.Adapters
{
   /// <summary>Provides a collection container for instances of the <see cref="T:System.Net.Cookie" /> class.</summary>
   public class CookieCollectionAdapter : AbstractionAdapter<CookieCollection>, ICookieCollection
   {
      /// <inheritdoc />
      public int Count => Implementation.Count;

      /// <inheritdoc />
      public object SyncRoot => ((ICollection)Implementation).SyncRoot;

      /// <inheritdoc />
      public bool IsSynchronized => ((ICollection)Implementation).IsSynchronized;

      /// <inheritdoc />
      public bool IsReadOnly => Implementation.IsReadOnly;

      /// <inheritdoc />
      public ICookie? this[string name] => Implementation[name].ToInterface();

      /// <summary>Initializes a new instance of the <see cref="CookieCollectionAdapter" /> class.</summary>
      public CookieCollectionAdapter()
         : this(new CookieCollection())
      {
      }

      /// <summary>Initializes a new instance of the <see cref="CookieCollectionAdapter" /> class.</summary>
      /// <param name="collection">The collection to be used by the adapter.</param>
      public CookieCollectionAdapter(CookieCollection collection)
         : base(collection)
      {
      }

      /// <inheritdoc />
      public void Add(Cookie cookie)
      {
         Implementation.Add(cookie);
      }

      /// <inheritdoc />
      public void Add(ICookie cookie)
      {
         Implementation.Add(cookie.ToImplementation());
      }

      /// <inheritdoc />
      public void Add(CookieCollection cookies)
      {
         Implementation.Add(cookies);
      }

      /// <inheritdoc />
      public void Add(ICookieCollection cookies)
      {
         Implementation.Add(cookies.ToImplementation());
      }

      /// <inheritdoc />
      public void CopyTo(Cookie[] array, int index)
      {
         Implementation.CopyTo(array, index);
      }

      /// <inheritdoc />
      public void CopyTo(Array array, int index)
      {
         ((ICollection)Implementation).CopyTo(array, index);
      }

#if NETCOREAPP || NET5_0
      /// <inheritdoc />
      public bool Contains(Cookie cookie)
      {
         return Implementation.Contains(cookie);
      }

      /// <inheritdoc />
      public bool Remove(Cookie cookie)
      {
         return Implementation.Remove(cookie);
      }

      /// <inheritdoc />
      public void Clear()
      {
         Implementation.Clear();
      }
#endif

      /// <inheritdoc />
      public IEnumerator GetEnumerator()
      {
         return Implementation.GetEnumerator();
      }
   }
}
