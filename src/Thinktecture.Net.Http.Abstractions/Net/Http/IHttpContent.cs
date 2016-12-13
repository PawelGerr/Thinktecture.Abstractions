using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Thinktecture.IO;
using Thinktecture.Net.Http.Headers;

namespace Thinktecture.Net.Http
{
	/// <summary>A base class representing an HTTP entity body and content headers.</summary>
	public interface IHttpContent : IAbstraction<HttpContent>, IDisposable
	{
		/// <summary>Gets the HTTP content headers as defined in RFC 2616.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpContentHeaders" />.The content headers as defined in RFC 2616.</returns>
		IHttpContentHeaders Headers { get; }

		/// <summary>Serialize the HTTP content to a string as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		Task<string> ReadAsStringAsync();

		/// <summary>Serialize the HTTP content to a byte array as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		Task<byte[]> ReadAsByteArrayAsync();

		/// <summary>Serialize the HTTP content and return a stream that represents the content as an asynchronous operation. </summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		Task<IStream> ReadAsStreamAsync();

		/// <summary>Serialize the HTTP content into a stream of bytes and copies it to the stream object provided as the <paramref name="stream" /> parameter.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task" />.The task object representing the asynchronous operation.</returns>
		/// <param name="stream">The target stream.</param>
		/// <param name="context">Information about the transport (channel binding token, for example). This parameter may be null.</param>
		Task CopyToAsync(Stream stream, TransportContext context);

		/// <summary>Serialize the HTTP content into a stream of bytes and copies it to the stream object provided as the <paramref name="stream" /> parameter.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task" />.The task object representing the asynchronous operation.</returns>
		/// <param name="stream">The target stream.</param>
		/// <param name="context">Information about the transport (channel binding token, for example). This parameter may be null.</param>
		Task CopyToAsync(Stream stream, ITransportContext context);

		/// <summary>Serialize the HTTP content into a stream of bytes and copies it to the stream object provided as the <paramref name="stream" /> parameter.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task" />.The task object representing the asynchronous operation.</returns>
		/// <param name="stream">The target stream.</param>
		/// <param name="context">Information about the transport (channel binding token, for example). This parameter may be null.</param>
		Task CopyToAsync(IStream stream, TransportContext context);

		/// <summary>Serialize the HTTP content into a stream of bytes and copies it to the stream object provided as the <paramref name="stream" /> parameter.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task" />.The task object representing the asynchronous operation.</returns>
		/// <param name="stream">The target stream.</param>
		/// <param name="context">Information about the transport (channel binding token, for example). This parameter may be null.</param>
		Task CopyToAsync(IStream stream, ITransportContext context);

		/// <summary>Serialize the HTTP content into a stream of bytes and copies it to the stream object provided as the <paramref name="stream" /> parameter.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task" />.The task object representing the asynchronous operation.</returns>
		/// <param name="stream">The target stream.</param>
		Task CopyToAsync(Stream stream);

		/// <summary>Serialize the HTTP content into a stream of bytes and copies it to the stream object provided as the <paramref name="stream" /> parameter.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task" />.The task object representing the asynchronous operation.</returns>
		/// <param name="stream">The target stream.</param>
		Task CopyToAsync(IStream stream);

		/// <summary>Serialize the HTTP content to a memory buffer as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task" />.The task object representing the asynchronous operation.</returns>
		Task LoadIntoBufferAsync();

		/// <summary>Serialize the HTTP content to a memory buffer as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task" />.The task object representing the asynchronous operation.</returns>
		/// <param name="maxBufferSize">The maximum size, in bytes, of the buffer to use.</param>
		Task LoadIntoBufferAsync(long maxBufferSize);
	}
}