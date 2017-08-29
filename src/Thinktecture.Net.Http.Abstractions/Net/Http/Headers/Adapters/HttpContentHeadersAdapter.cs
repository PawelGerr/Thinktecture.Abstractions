using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http.Headers;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.Http.Headers.Adapters
{
	/// <summary>Represents the collection of Content Headers as defined in RFC 2616.</summary>
	public class HttpContentHeadersAdapter : HttpHeadersAdapter, IHttpContentHeaders
	{
		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		[NotNull]
		protected new HttpContentHeaders Implementation { get; }

		/// <inheritdoc />
		[NotNull, EditorBrowsable(EditorBrowsableState.Never)]
		public new HttpContentHeaders UnsafeConvert()
		{
			return Implementation;
		}

		/// <inheritdoc />
		public ICollection<string> Allow => Implementation.Allow;

		/// <inheritdoc />
		public ContentDispositionHeaderValue ContentDisposition
		{
			get => Implementation.ContentDisposition;
			set => Implementation.ContentDisposition = value;
		}

		/// <inheritdoc />
		public ICollection<string> ContentEncoding => Implementation.ContentEncoding;

		/// <inheritdoc />
		public ICollection<string> ContentLanguage => Implementation.ContentLanguage;

		/// <inheritdoc />
		public long? ContentLength
		{
			get => Implementation.ContentLength;
			set => Implementation.ContentLength = value;
		}

		/// <inheritdoc />
		public Uri ContentLocation
		{
			get => Implementation.ContentLocation;
			set => Implementation.ContentLocation = value;
		}

		/// <inheritdoc />
		public byte[] ContentMD5
		{
			get => Implementation.ContentMD5;
			set => Implementation.ContentMD5 = value;
		}

		/// <inheritdoc />
		public ContentRangeHeaderValue ContentRange
		{
			get => Implementation.ContentRange;
			set => Implementation.ContentRange = value;
		}

		/// <inheritdoc />
		public MediaTypeHeaderValue ContentType
		{
			get => Implementation.ContentType;
			set => Implementation.ContentType = value;
		}

		/// <inheritdoc />
		public DateTimeOffset? Expires
		{
			get => Implementation.Expires;
			set => Implementation.Expires = value;
		}

		/// <inheritdoc />
		public DateTimeOffset? LastModified
		{
			get => Implementation.LastModified;
			set => Implementation.LastModified = value;
		}

		/// <summary>
		/// Initializes new instance of type <see cref="HttpContentHeadersAdapter"/>.
		/// </summary>
		/// <param name="headers">Headers to be used by the adapter.</param>
		public HttpContentHeadersAdapter([NotNull] HttpContentHeaders headers)
			: base(headers)
		{
			Implementation = headers ?? throw new ArgumentNullException(nameof(headers));
		}
	}
}
