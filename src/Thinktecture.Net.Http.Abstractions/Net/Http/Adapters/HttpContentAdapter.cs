using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Thinktecture.IO;
using Thinktecture.Net.Http.Headers;

namespace Thinktecture.Net.Http.Adapters
{
	/// <summary>A base class representing an HTTP entity body and content headers.</summary>
	public class HttpContentAdapter : AbstractionAdapter, IHttpContent
	{
		private readonly HttpContent _content;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new HttpContent UnsafeConvert()
		{
			return _content;
		}

		/// <inheritdoc />
		public IHttpContentHeaders Headers => _content.Headers.ToInterface();

		/// <summary>Initializes a new instance of the <see cref="HttpContentAdapter" /> class.</summary>
		public HttpContentAdapter(HttpContent content)
			: base(content)
		{
			if (content == null)
				throw new ArgumentNullException(nameof(content));

			_content = content;
		}

		/// <inheritdoc />
		public Task<string> ReadAsStringAsync()
		{
			return _content.ReadAsStringAsync();
		}

		/// <inheritdoc />
		public Task<byte[]> ReadAsByteArrayAsync()
		{
			return _content.ReadAsByteArrayAsync();
		}

		/// <inheritdoc />
		public async Task<IStream> ReadAsStreamAsync()
		{
			return (await _content.ReadAsStreamAsync()).ToInterface();
		}

		/// <inheritdoc />
		public Task CopyToAsync(Stream stream, TransportContext context)
		{
			return _content.CopyToAsync(stream, context);
		}

		/// <inheritdoc />
		public Task CopyToAsync(Stream stream, ITransportContext context)
		{
			return _content.CopyToAsync(stream, context.ToImplementation());
		}

		/// <inheritdoc />
		public Task CopyToAsync(IStream stream, TransportContext context)
		{
			return _content.CopyToAsync(stream.ToImplementation(), context);
		}

		/// <inheritdoc />
		public Task CopyToAsync(IStream stream, ITransportContext context)
		{
			return _content.CopyToAsync(stream.ToImplementation(), context.ToImplementation());
		}

		/// <inheritdoc />
		public Task CopyToAsync(Stream stream)
		{
			return _content.CopyToAsync(stream);
		}

		/// <inheritdoc />
		public Task CopyToAsync(IStream stream)
		{
			return _content.CopyToAsync(stream.ToImplementation());
		}

		/// <inheritdoc />
		public Task LoadIntoBufferAsync()
		{
			return _content.LoadIntoBufferAsync();
		}

		/// <inheritdoc />
		public Task LoadIntoBufferAsync(long maxBufferSize)
		{
			return _content.LoadIntoBufferAsync(maxBufferSize);
		}

		/// <inheritdoc />
		public void Dispose()
		{
			_content.Dispose();
		}
	}
}