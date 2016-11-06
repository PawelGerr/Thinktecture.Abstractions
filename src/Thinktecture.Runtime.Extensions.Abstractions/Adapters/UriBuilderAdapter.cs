using System;

namespace Thinktecture.Adapters
{
	public class UriBuilderAdapter : IUriBuilder
	{
		private readonly UriBuilder _builder;

		/// <summary>
		/// Initializes a new instance of the <see cref="UriBuilder"/> class.
		/// </summary>
		public UriBuilderAdapter()
			: this(new UriBuilder())
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="UriBuilder"/> class with the specified URI.
		/// </summary>
		/// <param name="uri">A URI string.</param>
		/// <exception cref="ArgumentNullException"><paramref name="uri"/> is null.</exception>
		/// <exception cref="UriFormatException">
		/// In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="FormatException"/>, instead.
		/// <paramref name="uri"/> is a zero length string or contains only spaces.
		/// -or-
		/// The parsing routine detected a scheme in an invalid form.
		/// -or-
		/// The parser detected more than two consecutive slashes in a URI that does not use the "file" scheme.
		/// -or-
		/// <paramref name="uri"/> is not a valid URI.
		/// </exception>
		public UriBuilderAdapter(string uri)
			: this(new UriBuilder(uri))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="UriBuilder"/> class with the specified scheme and host.
		/// </summary>
		/// <param name="scheme">An Internet access protocol.</param>
		/// <param name="hostName">A DNS-style domain name or IP address.</param>
		public UriBuilderAdapter(string scheme, string hostName)
			: this(new UriBuilder(scheme, hostName))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="UriBuilder"/> class with the specified scheme, host, and port.
		/// </summary>
		/// <param name="scheme">An Internet access protocol.</param>
		/// <param name="hostName">A DNS-style domain name or IP address.</param>
		/// <param name="portNumber">An IP port number for the service.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="portNumber"/> is less than -1 or greater than 65,535.</exception>
		public UriBuilderAdapter(string scheme, string hostName, int portNumber)
			: this(new UriBuilder(scheme, hostName, portNumber))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="UriBuilder"/> class with the specified scheme, host, port number, and path.
		/// </summary>
		/// <param name="scheme">An Internet access protocol.</param>
		/// <param name="hostName">A DNS-style domain name or IP address.</param>
		/// <param name="portNumber">An IP port number for the service.</param>
		/// <param name="pathValue">The path to the Internet resource.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="portNumber"/> is less than -1 or greater than 65,535.</exception>
		public UriBuilderAdapter(string scheme, string hostName, int portNumber, string pathValue)
			: this(new UriBuilder(scheme, hostName, portNumber, pathValue))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="UriBuilder"/> class with the specified scheme, host, port number, path and query string or fragment identifier.
		/// </summary>
		/// <param name="scheme">An Internet access protocol.</param>
		/// <param name="hostName">A DNS-style domain name or IP address.</param>
		/// <param name="portNumber">An IP port number for the service.</param>
		/// <param name="path">The path to the Internet resource.</param>
		/// <param name="extraValue">A query string or fragment identifier.</param>
		/// <exception cref="ArgumentException"><paramref name="extraValue"/> is neither <c>null</c> nor <see cref="String.Empty"/>, nor does a valid fragment identifier begin with a number sign (#), nor a valid query string begin with a question mark (?).</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="portNumber"/> is less than -1 or greater than 65,535.</exception>
		public UriBuilderAdapter(string scheme, string hostName, int portNumber, string path, string extraValue)
			: this(new UriBuilder(scheme, hostName, portNumber, path,extraValue))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="UriBuilder"/> class with the specified Uri instance.
		/// </summary>
		/// <param name="uri">An instance of the Uri class.</param>
		/// <exception cref="ArgumentNullException"><paramref name="uri"/> is null.</exception>
		public UriBuilderAdapter(Uri uri)
			: this(new UriBuilder(uri))
		{
		}

		public UriBuilderAdapter(UriBuilder builder)
		{
			if (builder == null)
				throw new ArgumentNullException(nameof(builder));

			_builder = builder;
		}

		/// <inheritdoc />
		public UriBuilder ToImplementation()
		{
			return _builder;
		}

		/// <inheritdoc />
		public string Fragment
		{
			get { return _builder.Fragment; }
			set { _builder.Fragment = value; }
		}

		/// <inheritdoc />
		public string Host
		{
			get { return _builder.Host; }
			set { _builder.Host = value; }
		}

		/// <inheritdoc />
		public string Password
		{
			get { return _builder.Password; }
			set { _builder.Password = value; }
		}

		/// <inheritdoc />
		public string Path
		{
			get { return _builder.Path; }
			set { _builder.Path = value; }
		}

		/// <inheritdoc />
		public int Port
		{
			get { return _builder.Port; }
			set { _builder.Port = value; }
		}

		/// <inheritdoc />
		public string Query
		{
			get { return _builder.Query; }
			set { _builder.Query = value; }
		}

		/// <inheritdoc />
		public string Scheme
		{
			get { return _builder.Scheme; }
			set { _builder.Scheme = value; }
		}

		/// <inheritdoc />
		public Uri Uri => _builder.Uri;

		/// <inheritdoc />
		public string UserName
		{
			get { return _builder.UserName; }
			set { _builder.UserName = value; }
		}
	}
}