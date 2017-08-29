using System;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Adapters
{
	/// <summary>
	/// Adapter for <see cref="UriBuilder"/>.
	/// </summary>
	public class UriBuilderAdapter : AbstractionAdapter<UriBuilder>, IUriBuilder
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UriBuilderAdapter"/> class.
		/// </summary>
		public UriBuilderAdapter()
			: this(new UriBuilder())
		{
		}

#pragma warning disable 1584, 1574
		/// <summary>
		/// Initializes a new instance of the <see cref="UriBuilderAdapter"/> class with the specified URI.
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
		public UriBuilderAdapter([NotNull] string uri)
			: this(new UriBuilder(uri))
		{
		}
#pragma warning restore 1584, 1574

		/// <summary>
		/// Initializes a new instance of the <see cref="UriBuilderAdapter"/> class with the specified scheme and host.
		/// </summary>
		/// <param name="scheme">An Internet access protocol.</param>
		/// <param name="hostName">A DNS-style domain name or IP address.</param>
		public UriBuilderAdapter([NotNull] string scheme, [NotNull] string hostName)
			: this(new UriBuilder(scheme, hostName))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="UriBuilderAdapter"/> class with the specified scheme, host, and port.
		/// </summary>
		/// <param name="scheme">An Internet access protocol.</param>
		/// <param name="hostName">A DNS-style domain name or IP address.</param>
		/// <param name="portNumber">An IP port number for the service.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="portNumber"/> is less than -1 or greater than 65,535.</exception>
		public UriBuilderAdapter([NotNull] string scheme, [NotNull] string hostName, int portNumber)
			: this(new UriBuilder(scheme, hostName, portNumber))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="UriBuilderAdapter"/> class with the specified scheme, host, port number, and path.
		/// </summary>
		/// <param name="scheme">An Internet access protocol.</param>
		/// <param name="hostName">A DNS-style domain name or IP address.</param>
		/// <param name="portNumber">An IP port number for the service.</param>
		/// <param name="pathValue">The path to the Internet resource.</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="portNumber"/> is less than -1 or greater than 65,535.</exception>
		public UriBuilderAdapter([NotNull] string scheme, [NotNull] string hostName, int portNumber, [NotNull] string pathValue)
			: this(new UriBuilder(scheme, hostName, portNumber, pathValue))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="UriBuilderAdapter"/> class with the specified scheme, host, port number, path and query string or fragment identifier.
		/// </summary>
		/// <param name="scheme">An Internet access protocol.</param>
		/// <param name="hostName">A DNS-style domain name or IP address.</param>
		/// <param name="portNumber">An IP port number for the service.</param>
		/// <param name="path">The path to the Internet resource.</param>
		/// <param name="extraValue">A query string or fragment identifier.</param>
		/// <exception cref="ArgumentException"><paramref name="extraValue"/> is neither <c>null</c> nor <see cref="String.Empty"/>, nor does a valid fragment identifier begin with a number sign (#), nor a valid query string begin with a question mark (?).</exception>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="portNumber"/> is less than -1 or greater than 65,535.</exception>
		public UriBuilderAdapter([NotNull] string scheme, [NotNull] string hostName, int portNumber, [NotNull] string path, [CanBeNull] string extraValue)
			: this(new UriBuilder(scheme, hostName, portNumber, path, extraValue))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="UriBuilderAdapter"/> class with the specified Uri instance.
		/// </summary>
		/// <param name="uri">An instance of the Uri class.</param>
		/// <exception cref="ArgumentNullException"><paramref name="uri"/> is null.</exception>
		public UriBuilderAdapter([NotNull] Uri uri)
			: this(new UriBuilder(uri))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="UriBuilderAdapter"/> class.
		/// </summary>
		/// <param name="builder"></param>
		public UriBuilderAdapter([NotNull] UriBuilder builder)
			: base(builder)
		{
		}

		/// <inheritdoc />
		public string Fragment
		{
			get => Implementation.Fragment;
			set => Implementation.Fragment = value;
		}

		/// <inheritdoc />
		public string Host
		{
			get => Implementation.Host;
			set => Implementation.Host = value;
		}

		/// <inheritdoc />
		public string Password
		{
			get => Implementation.Password;
			set => Implementation.Password = value;
		}

		/// <inheritdoc />
		public string Path
		{
			get => Implementation.Path;
			set => Implementation.Path = value;
		}

		/// <inheritdoc />
		public int Port
		{
			get => Implementation.Port;
			set => Implementation.Port = value;
		}

		/// <inheritdoc />
		public string Query
		{
			get => Implementation.Query;
			set => Implementation.Query = value;
		}

		/// <inheritdoc />
		public string Scheme
		{
			get => Implementation.Scheme;
			set => Implementation.Scheme = value;
		}

		/// <inheritdoc />
		public Uri Uri => Implementation.Uri;

		/// <inheritdoc />
		public string UserName
		{
			get => Implementation.UserName;
			set => Implementation.UserName = value;
		}
	}
}
