using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http.Headers;

namespace Thinktecture.Net.Http.Headers.Adapters
{
	/// <summary>A collection of headers and their values as defined in RFC 2616.</summary>
	public class HttpHeadersAdapter : AbstractionAdapter, IHttpHeaders
	{
		private readonly HttpHeaders _headers;

		/// <summary>Initializes a new instance of the <see cref="HttpHeadersAdapter" /> class.</summary>
		/// <param name="headers">Http headers to be use by the adapter.</param>
		public HttpHeadersAdapter(HttpHeaders headers)
			: base(headers)
		{
			if (headers == null)
				throw new ArgumentNullException(nameof(headers));

			_headers = headers;
		}

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new HttpHeaders UnsafeConvert()
		{
			return _headers;
		}

		/// <inheritdoc />
		public void Add(string name, string value)
		{
			_headers.Add(name, value);
		}

		/// <inheritdoc />
		public void Add(string name, IEnumerable<string> values)
		{
			_headers.Add(name, values);
		}

		/// <inheritdoc />
		public bool TryAddWithoutValidation(string name, string value)
		{
			return _headers.TryAddWithoutValidation(name, value);
		}

		/// <inheritdoc />
		public bool TryAddWithoutValidation(string name, IEnumerable<string> values)
		{
			return _headers.TryAddWithoutValidation(name, values);
		}

		/// <inheritdoc />
		public void Clear()
		{
			_headers.Clear();
		}

		/// <inheritdoc />
		public bool Remove(string name)
		{
			return _headers.Remove(name);
		}

		/// <inheritdoc />
		public IEnumerable<string> GetValues(string name)
		{
			return _headers.GetValues(name);
		}

		/// <inheritdoc />
		public bool TryGetValues(string name, out IEnumerable<string> values)
		{
			return _headers.TryGetValues(name, out values);
		}

		/// <inheritdoc />
		public bool Contains(string name)
		{
			return _headers.Contains(name);
		}

		/// <inheritdoc />
		public IEnumerator<KeyValuePair<string, IEnumerable<string>>> GetEnumerator()
		{
			return _headers.GetEnumerator();
		}

		/// <inheritdoc />
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}