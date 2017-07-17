using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Thinktecture.Net.Http.Headers.Adapters
{
	/// <inheritdoc />
	public class HttpHeaderValueCollectionAdapter<T> : AbstractionAdapter, IHttpHeaderValueCollection<T> where T : class
	{
		private readonly HttpHeaderValueCollection<T> _httpHeaderValueCollection;

        /// <summary>Initializes a new instance of the <see cref="T:Thinktecture.Net.Http.Headers.Adapters.HttpHeaderValueCollection`1" /> class.</summary>
        /// <param name="httpHeaderValueCollection">Http Header Value Collection to be use by the adapter.</param>
        public HttpHeaderValueCollectionAdapter(HttpHeaderValueCollection<T> httpHeaderValueCollection) 
			: base(httpHeaderValueCollection)
		{
			_httpHeaderValueCollection = httpHeaderValueCollection 
				?? throw new ArgumentNullException(nameof(httpHeaderValueCollection));
		}

		/// <inheritdoc />
		public new HttpHeaderValueCollection<T> UnsafeConvert()
		{
			return _httpHeaderValueCollection;
		}

		/// <inheritdoc />
		public int Count => _httpHeaderValueCollection.Count;

		/// <inheritdoc />
		public bool IsReadOnly => _httpHeaderValueCollection.IsReadOnly;

		/// <inheritdoc />
		public void Add(T item)
		{
			_httpHeaderValueCollection.Add(item);
		}

		/// <inheritdoc />
		public void ParseAdd(string input)
		{
			_httpHeaderValueCollection.ParseAdd(input);
		}

		/// <inheritdoc />
		public bool TryParseAdd(string input)
		{
			return _httpHeaderValueCollection.TryParseAdd(input);
		}

		/// <inheritdoc />
		public void Clear()
		{
			_httpHeaderValueCollection.Clear();
		}

		/// <inheritdoc />
		public bool Contains(T item)
		{
			return _httpHeaderValueCollection.Contains(item);
		}

		/// <inheritdoc />
		public void CopyTo(T[] array, int arrayIndex)
		{
			_httpHeaderValueCollection.CopyTo(array, arrayIndex);
		}

		/// <inheritdoc />
		public bool Remove(T item)
		{
			return _httpHeaderValueCollection.Remove(item);
		}

		/// <inheritdoc />
		public IEnumerator<T> GetEnumerator()
		{
			return _httpHeaderValueCollection.GetEnumerator();
		}

		/// <inheritdoc />
		public new string ToString()
		{
			return _httpHeaderValueCollection.ToString();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}