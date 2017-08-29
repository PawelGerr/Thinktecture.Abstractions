using System;
using System.ComponentModel;
using System.Net;
using System.Net.Http;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.Http.Adapters
{
	/// <summary>The default message handler used by <see cref="T:System.Net.Http.HttpClient" />.  </summary>
	public class HttpClientHandlerAdapter : HttpMessageHandlerAdapter, IHttpClientHandler
	{
		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		[NotNull]
		protected new HttpClientHandler Implementation { get; }

		/// <inheritdoc />
		[NotNull]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new HttpClientHandler UnsafeConvert()
		{
			return Implementation;
		}

		/// <inheritdoc />
		public virtual bool SupportsAutomaticDecompression => Implementation.SupportsAutomaticDecompression;

		/// <inheritdoc />
		public bool SupportsProxy => Implementation.SupportsProxy;

		/// <inheritdoc />
		public bool SupportsRedirectConfiguration => Implementation.SupportsRedirectConfiguration;

		/// <inheritdoc />
		public bool UseCookies
		{
			get => Implementation.UseCookies;
			set => Implementation.UseCookies = value;
		}

		/// <inheritdoc />
		public ICookieContainer CookieContainer
		{
			get => Implementation.CookieContainer.ToInterface();
			set => Implementation.CookieContainer = value.ToImplementation();
		}

		/// <inheritdoc />
		public ClientCertificateOption ClientCertificateOptions
		{
			get => Implementation.ClientCertificateOptions;
			set => Implementation.ClientCertificateOptions = value;
		}

		/// <inheritdoc />
		public DecompressionMethods AutomaticDecompression
		{
			get => Implementation.AutomaticDecompression;
			set => Implementation.AutomaticDecompression = value;
		}

		/// <inheritdoc />
		public bool UseProxy
		{
			get => Implementation.UseProxy;
			set => Implementation.UseProxy = value;
		}

		/// <inheritdoc />
		public IWebProxy Proxy
		{
			get => Implementation.Proxy;
			set => Implementation.Proxy = value;
		}

		/// <inheritdoc />
		public bool PreAuthenticate
		{
			get => Implementation.PreAuthenticate;
			set => Implementation.PreAuthenticate = value;
		}

		/// <inheritdoc />
		public bool UseDefaultCredentials
		{
			get => Implementation.UseDefaultCredentials;
			set => Implementation.UseDefaultCredentials = value;
		}

		/// <inheritdoc />
		public ICredentials Credentials
		{
			get => Implementation.Credentials;
			set => Implementation.Credentials = value;
		}

		/// <inheritdoc />
		public bool AllowAutoRedirect
		{
			get => Implementation.AllowAutoRedirect;
			set => Implementation.AllowAutoRedirect = value;
		}

		/// <inheritdoc />
		public int MaxAutomaticRedirections
		{
			get => Implementation.MaxAutomaticRedirections;
			set => Implementation.MaxAutomaticRedirections = value;
		}

		/// <inheritdoc />
		public long MaxRequestContentBufferSize
		{
			get => Implementation.MaxRequestContentBufferSize;
			set => Implementation.MaxRequestContentBufferSize = value;
		}

		/// <summary>Creates an instance of a <see cref="HttpClientHandlerAdapter" /> class.</summary>
		public HttpClientHandlerAdapter()
			: this(new HttpClientHandler())
		{
		}

		/// <summary>Creates an instance of a <see cref="HttpClientHandlerAdapter" /> class.</summary>
		/// <param name="handler">The implementation to use by the adapter.</param>
		public HttpClientHandlerAdapter([NotNull] HttpClientHandler handler)
			: base(handler)
		{
			Implementation = handler ?? throw new ArgumentNullException(nameof(handler));
		}
	}
}
