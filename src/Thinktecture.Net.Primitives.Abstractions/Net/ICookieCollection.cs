using System.Collections;
using System.Net;

namespace Thinktecture.Net
{
   /// <summary>Provides a collection container for instances of the <see cref="T:System.Net.Cookie" /> class.</summary>
   public interface ICookieCollection : IAbstraction<CookieCollection>, ICollection
   {
      /// <summary>Gets a value that indicates whether a <see cref="T:System.Net.CookieCollection" /> is read-only.</summary>
      /// <returns>true if this is a read-only <see cref="T:System.Net.CookieCollection" />; otherwise, false. The default is true.</returns>
      bool IsReadOnly { get; }

      /// <summary>Gets the <see cref="T:System.Net.Cookie" /> with a specific name from a <see cref="T:System.Net.CookieCollection" />.</summary>
      /// <returns>The <see cref="T:System.Net.Cookie" /> with a specific name from a <see cref="T:System.Net.CookieCollection" />.</returns>
      /// <param name="name">The name of the <see cref="T:System.Net.Cookie" /> to be found. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="name" /> is null. </exception>
      ICookie? this[string name] { get; }

      /// <summary>Adds a <see cref="T:System.Net.Cookie" /> to a <see cref="T:System.Net.CookieCollection" />.</summary>
      /// <param name="cookie">The <see cref="T:System.Net.Cookie" /> to be added to a <see cref="T:System.Net.CookieCollection" />. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="cookie" /> is null. </exception>
      void Add(Cookie cookie);

      /// <summary>Adds a <see cref="T:System.Net.Cookie" /> to a <see cref="T:System.Net.CookieCollection" />.</summary>
      /// <param name="cookie">The <see cref="T:System.Net.Cookie" /> to be added to a <see cref="T:System.Net.CookieCollection" />. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="cookie" /> is null. </exception>
      void Add(ICookie cookie);

      /// <summary>Adds the contents of a <see cref="T:System.Net.CookieCollection" /> to the current instance.</summary>
      /// <param name="cookies">The <see cref="T:System.Net.CookieCollection" /> to be added. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="cookies" /> is null. </exception>
      void Add(CookieCollection cookies);

      /// <summary>Adds the contents of a <see cref="ICookieCollection" /> to the current instance.</summary>
      /// <param name="cookies">The <see cref="T:System.Net.CookieCollection" /> to be added. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="cookies" /> is null. </exception>
      void Add(ICookieCollection cookies);

      /// <summary>Copies the elements of this <see cref="T:System.Net.CookieCollection" /> to a <see cref="T:System.Net.Cookie" /> array starting at the specified index of the target array.</summary>
      /// <param name="array">The target <see cref="T:System.Net.Cookie" /> array to which the <see cref="T:System.Net.CookieCollection" /> will be copied.</param>
      /// <param name="index">The zero-based index in the target <see cref="T:System.Array" /> where copying begins. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="array" /> is null. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" /> is less than zero. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="array" /> is multidimensional.-or- The number of elements in this <see cref="T:System.Net.CookieCollection" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />. </exception>
      /// <exception cref="T:System.InvalidCastException">The elements in this <see cref="T:System.Net.CookieCollection" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception>
      void CopyTo(Cookie[] array, int index);

#if NETCOREAPP || NET5_0
      /// <summary>
      /// Gets an indication whether the <paramref name="cookie"/> is in the collection or not.
      /// </summary>
      /// <param name="cookie">Cookie to check.</param>
      /// <returns><c>true</c> if <paramref name="cookie"/> is in the collection; otherwise <c>false</c>.</returns>
      bool Contains(Cookie cookie);

      /// <summary>
      /// Removes the <paramref name="cookie"/> from the collection.
      /// </summary>
      /// <param name="cookie">Cookie to remove.</param>
      /// <returns><c>true</c> if <paramref name="cookie"/> was in the collection; otherwise <c>false</c>.</returns>
      bool Remove(Cookie cookie);

      /// <summary>
      /// Deletes all cookies.
      /// </summary>
      void Clear();
#endif
   }
}
