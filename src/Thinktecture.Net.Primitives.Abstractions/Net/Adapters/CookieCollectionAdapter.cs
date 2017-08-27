using System;
using System.Collections;
using System.ComponentModel;
using System.Net;
using JetBrains.Annotations;

namespace Thinktecture.Net.Adapters
{
	/// <summary>Provides a collection container for instances of the <see cref="T:System.Net.Cookie" /> class.</summary>
	public class CookieCollectionAdapter : AbstractionAdapter, ICookieCollection
	{
		private readonly CookieCollection _collection;

		/// <inheritdoc />
		public int Count => _collection.Count;

		/// <inheritdoc />
		public object SyncRoot => ((ICollection)_collection).SyncRoot;

		/// <inheritdoc />
		public bool IsSynchronized => ((ICollection)_collection).IsSynchronized;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new CookieCollection UnsafeConvert()
		{
			return _collection;
		}

		/// <inheritdoc />
		public ICookie this[string name] => _collection[name].ToInterface();

		/// <summary>Initializes a new instance of the <see cref="CookieCollectionAdapter" /> class.</summary>
		public CookieCollectionAdapter()
			: this(new CookieCollection())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="CookieCollectionAdapter" /> class.</summary>
		/// <param name="collection">The collection to be used by the adapter.</param>
		public CookieCollectionAdapter([NotNull] CookieCollection collection)
			: base(collection)
		{
			_collection = collection ?? throw new ArgumentNullException(nameof(collection));
		}

		/// <inheritdoc />
		public void Add(Cookie cookie)
		{
			_collection.Add(cookie);
		}

		/// <inheritdoc />
		public void Add(ICookie cookie)
		{
			_collection.Add(cookie.ToImplementation());
		}

		/// <inheritdoc />
		public void Add(CookieCollection cookies)
		{
			_collection.Add(cookies);
		}

		/// <inheritdoc />
		public void Add(ICookieCollection cookies)
		{
			_collection.Add(cookies.ToImplementation());
		}

		/// <inheritdoc />
		public void CopyTo(Array array, int index)
		{
			((ICollection)_collection).CopyTo(array, index);
		}

		/// <inheritdoc />
		public IEnumerator GetEnumerator()
		{
			return _collection.GetEnumerator();
		}
	}
}
