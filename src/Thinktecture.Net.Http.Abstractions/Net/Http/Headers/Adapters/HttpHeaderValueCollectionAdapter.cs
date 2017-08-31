using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using JetBrains.Annotations;
using Thinktecture.Collections.Generic;

namespace Thinktecture.Net.Http.Headers.Adapters
{
	/// <inheritdoc cref="IHttpHeaderValueCollection{T}" />
	public class HttpHeaderValueCollectionAdapter<T> : CollectionAbstractionAdapter<T, HttpHeaderValueCollection<T>>, IHttpHeaderValueCollection<T>
		where T : class
	{
		/// <summary>Initializes a new instance of the <see cref="HttpHeaderValueCollectionAdapter{T}" /> class.</summary>
		/// <param name="httpHeaderValueCollection">Http Header Value Collection to be use by the adapter.</param>
		public HttpHeaderValueCollectionAdapter([NotNull] HttpHeaderValueCollection<T> httpHeaderValueCollection)
			: base(httpHeaderValueCollection)
		{
		}

		/// <inheritdoc />
		public void ParseAdd(string input)
		{
			Implementation.ParseAdd(input);
		}

		/// <inheritdoc />
		public bool TryParseAdd(string input)
		{
			return Implementation.TryParseAdd(input);
		}
	}
}
