using System;
using System.ComponentModel;
using System.Net;
using System.Net.Http;

namespace Thinktecture.Net.Http.Adapters
{
	/// <summary>The default message handler used by <see cref="T:System.Net.Http.HttpClient" />.  </summary>
	public class HttpClientHandlerAdapter : HttpMessageHandlerAdapter, IHttpClientHandler
	{
		private readonly HttpClientHandler _handler;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new HttpClientHandler UnsafeConvert()
		{
			return _handler;
		}

		/// <inheritdoc />
		public virtual bool SupportsAutomaticDecompression => _handler.SupportsAutomaticDecompression;

		/// <inheritdoc />
		public bool SupportsProxy => _handler.SupportsProxy;

		/// <inheritdoc />
		public bool SupportsRedirectConfiguration => _handler.SupportsRedirectConfiguration;

		/// <inheritdoc />
		public bool UseCookies
		{
			get { return _handler.UseCookies; }
			set { _handler.UseCookies = value; }
		}

		/// <inheritdoc />
		public ICookieContainer CookieContainer
		{
			get { return _handler.CookieContainer.ToInterface(); }
			set { _handler.CookieContainer = value.ToImplementation(); }
		}

		/// <inheritdoc />
		public ClientCertificateOption ClientCertificateOptions
		{
			get { return _handler.ClientCertificateOptions; }
			set { _handler.ClientCertificateOptions = value; }
		}

		/// <inheritdoc />
		public DecompressionMethods AutomaticDecompression
		{
			get { return _handler.AutomaticDecompression; }
			set { _handler.AutomaticDecompression = value; }
		}

		/// <inheritdoc />
		public bool UseProxy
		{
			get { return _handler.UseProxy; }
			set { _handler.UseProxy = value; }
		}

		/// <inheritdoc />
		public IWebProxy Proxy
		{
			get { return _handler.Proxy; }
			set { _handler.Proxy = value; }
		}

		/// <inheritdoc />
		public bool PreAuthenticate
		{
			get { return _handler.PreAuthenticate; }
			set { _handler.PreAuthenticate = value; }
		}

		/// <inheritdoc />
		public bool UseDefaultCredentials
		{
			get { return _handler.UseDefaultCredentials; }
			set { _handler.UseDefaultCredentials = value; }
		}

		/// <inheritdoc />
		public ICredentials Credentials
		{
			get { return _handler.Credentials; }
			set { _handler.Credentials = value; }
		}

		/// <inheritdoc />
		public bool AllowAutoRedirect
		{
			get { return _handler.AllowAutoRedirect; }
			set { _handler.AllowAutoRedirect = value; }
		}

		/// <inheritdoc />
		public int MaxAutomaticRedirections
		{
			get { return _handler.MaxAutomaticRedirections; }
			set { _handler.MaxAutomaticRedirections = value; }
		}

		/// <inheritdoc />
		public long MaxRequestContentBufferSize
		{
			get { return _handler.MaxRequestContentBufferSize; }
			set { _handler.MaxRequestContentBufferSize = value; }
		}

		/// <summary>Creates an instance of a <see cref="HttpClientHandlerAdapter" /> class.</summary>
		public HttpClientHandlerAdapter()
			: this(new HttpClientHandler())
		{
		}

		/// <summary>Creates an instance of a <see cref="HttpClientHandlerAdapter" /> class.</summary>
		public HttpClientHandlerAdapter(HttpClientHandler handler)
			: base(handler)
		{
			if (handler == null)
				throw new ArgumentNullException(nameof(handler));

			_handler = handler;
		}
	}
}