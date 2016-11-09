using System;
using System.ComponentModel;

namespace Thinktecture.Adapters
{
	/// <summary>
	/// Adapter for <see cref="UriBuilder"/>.
	/// </summary>
	public class UriBuilderAdapter : IUriBuilder
	{
		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public UriBuilder InternalInstance { get; }

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
		public UriBuilderAdapter(string uri)
			: this(new UriBuilder(uri))
		{
		}
#pragma warning restore 1584, 1574

		/// <summary>
		/// Initializes a new instance of the <see cref="UriBuilderAdapter"/> class with the specified scheme and host.
		/// </summary>
		/// <param name="scheme">An Internet access protocol.</param>
		/// <param name="hostName">A DNS-style domain name or IP address.</param>
		public UriBuilderAdapter(string scheme, string hostName)
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
		public UriBuilderAdapter(string scheme, string hostName, int portNumber)
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
		public UriBuilderAdapter(string scheme, string hostName, int portNumber, string pathValue)
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
		public UriBuilderAdapter(string scheme, string hostName, int portNumber, string path, string extraValue)
			: this(new UriBuilder(scheme, hostName, portNumber, path, extraValue))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="UriBuilderAdapter"/> class with the specified Uri instance.
		/// </summary>
		/// <param name="uri">An instance of the Uri class.</param>
		/// <exception cref="ArgumentNullException"><paramref name="uri"/> is null.</exception>
		public UriBuilderAdapter(Uri uri)
			: this(new UriBuilder(uri))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="UriBuilderAdapter"/> class.
		/// </summary>
		/// <param name="builder"></param>
		public UriBuilderAdapter(UriBuilder builder)
		{
			if (builder == null)
				throw new ArgumentNullException(nameof(builder));

			InternalInstance = builder;
		}

		/// <inheritdoc />
		public string Fragment
		{
			get { return InternalInstance.Fragment; }
			set { InternalInstance.Fragment = value; }
		}

		/// <inheritdoc />
		public string Host
		{
			get { return InternalInstance.Host; }
			set { InternalInstance.Host = value; }
		}

		/// <inheritdoc />
		public string Password
		{
			get { return InternalInstance.Password; }
			set { InternalInstance.Password = value; }
		}

		/// <inheritdoc />
		public string Path
		{
			get { return InternalInstance.Path; }
			set { InternalInstance.Path = value; }
		}

		/// <inheritdoc />
		public int Port
		{
			get { return InternalInstance.Port; }
			set { InternalInstance.Port = value; }
		}

		/// <inheritdoc />
		public string Query
		{
			get { return InternalInstance.Query; }
			set { InternalInstance.Query = value; }
		}

		/// <inheritdoc />
		public string Scheme
		{
			get { return InternalInstance.Scheme; }
			set { InternalInstance.Scheme = value; }
		}

		/// <inheritdoc />
		public Uri Uri => InternalInstance.Uri;

		/// <inheritdoc />
		public string UserName
		{
			get { return InternalInstance.UserName; }
			set { InternalInstance.UserName = value; }
		}

		/// <inheritdoc />
		public override bool Equals(object rparam)
		{
			return InternalInstance.Equals(rparam);
		}

		/// <inheritdoc />
		public override int GetHashCode()
		{
			return InternalInstance.GetHashCode();
		}

		/// <inheritdoc />
		public override string ToString()
		{
			return InternalInstance.ToString();
		}
	}
}