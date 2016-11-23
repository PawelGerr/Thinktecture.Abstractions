using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thinktecture.Net.Http
{
	public interface IHttpContent : IDisposable
	{
		/// <summary>Gets the HTTP content headers as defined in RFC 2616.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpContentHeaders" />.The content headers as defined in RFC 2616.</returns>
		HttpContentHeaders Headers { get; }

		/// <summary>Serialize the HTTP content to a string as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		Task<string> ReadAsStringAsync();

		/// <summary>Serialize the HTTP content to a byte array as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		Task<byte[]> ReadAsByteArrayAsync();

		/// <summary>Serialize the HTTP content and return a stream that represents the content as an asynchronous operation. </summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		Task<Stream> ReadAsStreamAsync();

		/// <summary>Serialize the HTTP content into a stream of bytes and copies it to the stream object provided as the <paramref name="stream" /> parameter.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task" />.The task object representing the asynchronous operation.</returns>
		/// <param name="stream">The target stream.</param>
		/// <param name="context">Information about the transport (channel binding token, for example). This parameter may be null.</param>
		Task CopyToAsync(Stream stream, TransportContext context);

		/// <summary>Serialize the HTTP content into a stream of bytes and copies it to the stream object provided as the <paramref name="stream" /> parameter.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task" />.The task object representing the asynchronous operation.</returns>
		/// <param name="stream">The target stream.</param>
		Task CopyToAsync(Stream stream);

		/// <summary>Serialize the HTTP content to a memory buffer as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task" />.The task object representing the asynchronous operation.</returns>
		Task LoadIntoBufferAsync();

		/// <summary>Serialize the HTTP content to a memory buffer as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task" />.The task object representing the asynchronous operation.</returns>
		/// <param name="maxBufferSize">The maximum size, in bytes, of the buffer to use.</param>
		Task LoadIntoBufferAsync(long maxBufferSize);

		/// <summary>Releases the unmanaged resources and disposes of the managed resources used by the <see cref="T:System.Net.Http.HttpContent" />.</summary>
		void Dispose();
	}

	/// <summary>A base class representing an HTTP entity body and content headers.</summary>
	public class HttpContent : IHttpContent
	{
		/// <summary>Gets the HTTP content headers as defined in RFC 2616.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.Headers.HttpContentHeaders" />.The content headers as defined in RFC 2616.</returns>
		public HttpContentHeaders Headers { get; }
		
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.HttpContent" /> class.</summary>
		public HttpContent()
		{
		}

		/// <summary>Serialize the HTTP content to a string as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		public Task<string> ReadAsStringAsync()
		{
		
		}

		/// <summary>Serialize the HTTP content to a byte array as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		public Task<byte[]> ReadAsByteArrayAsync()
		{
			
		}

		/// <summary>Serialize the HTTP content and return a stream that represents the content as an asynchronous operation. </summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		public Task<Stream> ReadAsStreamAsync()
		{
			
		}
		
		/// <summary>Serialize the HTTP content into a stream of bytes and copies it to the stream object provided as the <paramref name="stream" /> parameter.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task" />.The task object representing the asynchronous operation.</returns>
		/// <param name="stream">The target stream.</param>
		/// <param name="context">Information about the transport (channel binding token, for example). This parameter may be null.</param>
		public Task CopyToAsync(Stream stream, TransportContext context)
		{
			
		}

		/// <summary>Serialize the HTTP content into a stream of bytes and copies it to the stream object provided as the <paramref name="stream" /> parameter.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task" />.The task object representing the asynchronous operation.</returns>
		/// <param name="stream">The target stream.</param>
		public Task CopyToAsync(Stream stream)
		{
		}
		
		/// <summary>Serialize the HTTP content to a memory buffer as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task" />.The task object representing the asynchronous operation.</returns>
		public Task LoadIntoBufferAsync()
		{
		}

		/// <summary>Serialize the HTTP content to a memory buffer as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task" />.The task object representing the asynchronous operation.</returns>
		/// <param name="maxBufferSize">The maximum size, in bytes, of the buffer to use.</param>
		public Task LoadIntoBufferAsync(long maxBufferSize)
		{
		
		}

		/// <summary>Releases the unmanaged resources and disposes of the managed resources used by the <see cref="T:System.Net.Http.HttpContent" />.</summary>
		public void Dispose()
		{
		}
		
	}
}