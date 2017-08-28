using System;
using System.Collections;
using System.Net;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.Adapters
{
	/// <summary>Provides a collection container for instances of the <see cref="T:System.Net.Cookie" /> class.</summary>
	public class CookieCollectionAdapter : AbstractionAdapter<CookieCollection>, ICookieCollection
	{
		/// <inheritdoc />
		public int Count => Implementation.Count;

		/// <inheritdoc />
		[NotNull]
		public object SyncRoot => ((ICollection)Implementation).SyncRoot;

		/// <inheritdoc />
		public bool IsSynchronized => ((ICollection)Implementation).IsSynchronized;

		/// <inheritdoc />
		public ICookie this[string name] => Implementation[name].ToInterface();

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
		public void CopyTo([NotNull] Array array, int index)
		{
			((ICollection)Implementation).CopyTo(array, index);
		}

		/// <inheritdoc />
		[NotNull]
		public IEnumerator GetEnumerator()
		{
			return Implementation.GetEnumerator();
		}
	}
}
