using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Thinktecture.Net.Http.Headers
{
	/// <summary>Represents a collection of header values.</summary>
	/// <typeparam name="T">The header collection type.</typeparam>
	public interface IHttpHeaderValueCollection<T> : IAbstraction<HttpHeaderValueCollection<T>>, ICollection<T>  where T : class
	{
		/// <summary>Gets the number of headers in the <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" />.</summary>
		/// <returns>Returns <see cref="T:System.Int32" />.The number of headers in a collection</returns>
		new int Count { get; }

		/// <summary>Gets a value indicating whether the <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" /> instance is read-only.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" /> instance is read-only; otherwise, false.</returns>
		new bool IsReadOnly { get; }

		/// <summary>Adds an entry to the <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" />.</summary>
		/// <param name="item">The item to add to the header collection.</param>
		new void Add(T item);

		/// <summary>Parses and adds an entry to the <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" />.</summary>
		/// <param name="input">The entry to add.</param>
		void ParseAdd(string input);

		/// <summary>Determines whether the input could be parsed and added to the <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" />.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the <paramref name="input" /> could be parsed and added to the <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" /> instance; otherwise, false</returns>
		/// <param name="input">The entry to validate.</param>
		bool TryParseAdd(string input);

		/// <summary>Removes all entries from the <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" />.</summary>
		new void Clear();

		/// <summary>Determines if the <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" /> contains an item.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the entry is contained in the <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" /> instance; otherwise, false</returns>
		/// <param name="item">The item to find to the header collection.</param>
		new bool Contains(T item);

		/// <summary>Copies the entire <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" /> to a compatible one-dimensional <see cref="T:System.Array" />, starting at the specified index of the target array.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
		/// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		new void CopyTo(T[] array, int arrayIndex);

		/// <summary>Removes the specified item from the <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" />.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the <paramref name="item" /> was removed from the <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" /> instance; otherwise, false</returns>
		/// <param name="item">The item to remove.</param>
		new bool Remove(T item);

		/// <summary>Returns an enumerator that iterates through the <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" />.</summary>
		/// <returns>Returns <see cref="T:System.Collections.Generic.IEnumerator`1" />.An enumerator for the <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" /> instance.</returns>
		new IEnumerator<T> GetEnumerator();

		/// <summary>Returns a string that represents the current <see cref="T:Thinktecture.Net.Http.Headers.IHttpHeaderValueCollection`1" /> object. object.</summary>
		/// <returns>Returns <see cref="T:System.String" />.A string that represents the current object.</returns>
		string ToString();
	}
}