using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.Http.Headers.Adapters
{
	/// <summary>A collection of headers and their values as defined in RFC 2616.</summary>
	public class HttpHeadersAdapter : AbstractionAdapter<HttpHeaders>, IHttpHeaders
	{
		/// <summary>Initializes a new instance of the <see cref="HttpHeadersAdapter" /> class.</summary>
		/// <param name="headers">Http headers to be use by the adapter.</param>
		public HttpHeadersAdapter([NotNull] HttpHeaders headers)
			: base(headers)
		{
		}

		/// <inheritdoc />
		public void Add(string name, string value)
		{
			Implementation.Add(name, value);
		}

		/// <inheritdoc />
		public void Add(string name, IEnumerable<string> values)
		{
			Implementation.Add(name, values);
		}

		/// <inheritdoc />
		public bool TryAddWithoutValidation(string name, string value)
		{
			return Implementation.TryAddWithoutValidation(name, value);
		}

		/// <inheritdoc />
		public bool TryAddWithoutValidation(string name, IEnumerable<string> values)
		{
			return Implementation.TryAddWithoutValidation(name, values);
		}

		/// <inheritdoc />
		public void Clear()
		{
			Implementation.Clear();
		}

		/// <inheritdoc />
		public bool Remove(string name)
		{
			return Implementation.Remove(name);
		}

		/// <inheritdoc />
		public IEnumerable<string> GetValues(string name)
		{
			return Implementation.GetValues(name);
		}

		/// <inheritdoc />
		public bool TryGetValues(string name, out IEnumerable<string> values)
		{
			return Implementation.TryGetValues(name, out values);
		}

		/// <inheritdoc />
		public bool Contains(string name)
		{
			return Implementation.Contains(name);
		}

		/// <inheritdoc />
		[NotNull]
		public IEnumerator<KeyValuePair<string, IEnumerable<string>>> GetEnumerator()
		{
			return Implementation.GetEnumerator();
		}

		/// <inheritdoc />
		[NotNull]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
