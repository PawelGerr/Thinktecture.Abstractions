using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Thinktecture.IO;
using Thinktecture.Net.Http.Headers;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.Http.Adapters
{
	/// <summary>A base class representing an HTTP entity body and content headers.</summary>
	public class HttpContentAdapter : AbstractionAdapter<HttpContent>, IHttpContent
	{
		/// <inheritdoc />
		public IHttpContentHeaders Headers => Implementation.Headers.ToInterface();

		/// <summary>Initializes a new instance of the <see cref="HttpContentAdapter" /> class.</summary>
		/// <param name="content">The implementation to use by the adapter.</param>
		public HttpContentAdapter([NotNull] HttpContent content)
			: base(content)
		{
		}

		/// <inheritdoc />
		public Task<string> ReadAsStringAsync()
		{
			return Implementation.ReadAsStringAsync();
		}

		/// <inheritdoc />
		public Task<byte[]> ReadAsByteArrayAsync()
		{
			return Implementation.ReadAsByteArrayAsync();
		}

		/// <inheritdoc />
		public async Task<IStream> ReadAsStreamAsync()
		{
			var stream = await Implementation.ReadAsStreamAsync().ConfigureAwait(false);
			return stream.ToInterface();
		}

		/// <inheritdoc />
		public Task CopyToAsync(Stream stream, TransportContext context)
		{
			return Implementation.CopyToAsync(stream, context);
		}

		/// <inheritdoc />
		public Task CopyToAsync(Stream stream, ITransportContext context)
		{
			return Implementation.CopyToAsync(stream, context.ToImplementation());
		}

		/// <inheritdoc />
		public Task CopyToAsync(IStream stream, TransportContext context)
		{
			return Implementation.CopyToAsync(stream.ToImplementation(), context);
		}

		/// <inheritdoc />
		public Task CopyToAsync(IStream stream, ITransportContext context)
		{
			return Implementation.CopyToAsync(stream.ToImplementation(), context.ToImplementation());
		}

		/// <inheritdoc />
		public Task CopyToAsync(Stream stream)
		{
			return Implementation.CopyToAsync(stream);
		}

		/// <inheritdoc />
		public Task CopyToAsync(IStream stream)
		{
			return Implementation.CopyToAsync(stream.ToImplementation());
		}

		/// <inheritdoc />
		public Task LoadIntoBufferAsync()
		{
			return Implementation.LoadIntoBufferAsync();
		}

		/// <inheritdoc />
		public Task LoadIntoBufferAsync(long maxBufferSize)
		{
			return Implementation.LoadIntoBufferAsync(maxBufferSize);
		}

		/// <inheritdoc />
		public void Dispose()
		{
			Implementation.Dispose();
		}
	}
}
