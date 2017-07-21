using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http.Headers;
using Thinktecture.Collections.Generic;

namespace Thinktecture.Net.Http.Headers.Adapters
{
	/// <inheritdoc />
	public class HttpHeaderValueCollectionAdapter<T> : CollectionAbstractionAdapter<T, HttpHeaderValueCollection<T>>, IHttpHeaderValueCollection<T> 
		where T : class
	{
		/// <summary>Initializes a new instance of the <see cref="HttpHeaderValueCollectionAdapter{T}" /> class.</summary>
		/// <param name="httpHeaderValueCollection">Http Header Value Collection to be use by the adapter.</param>
		public HttpHeaderValueCollectionAdapter(HttpHeaderValueCollection<T> httpHeaderValueCollection) 
			: base(httpHeaderValueCollection)
		{
			
		}
		
		/// <inheritdoc />
		public void ParseAdd(string input)
		{
			Collection.ParseAdd(input);
		}

		/// <inheritdoc />
		public bool TryParseAdd(string input)
		{
			return Collection.TryParseAdd(input);
		}
	}
}