using System;
using System.ComponentModel;

namespace Thinktecture
{
	/// <summary>
	/// Provides a custom constructor for uniform resource identifiers (URIs) and modifies URIs for the <see cref="Uri"/> class.
	/// </summary>
	public interface IUriBuilder : IAbstraction
	{
		/// <summary>
		/// Gets inner instance of <see cref="UriBuilder"/>.
		/// It is not intended to be used directly. Use <see cref="UriBuilderExtensions.ToImplementation"/> instead.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		new UriBuilder UnsafeConvert();

		/// <summary>
		/// Gets or sets the fragment portion of the URI.
		/// </summary>
		string Fragment { get; set; }

		/// <summary>
		/// Gets or sets the Domain Name System (DNS) host name or IP address of a server.
		/// </summary>
		string Host { get; set; }

		/// <summary>
		/// Gets or sets the password associated with the user that accesses the URI.
		/// </summary>
		string Password { get; set; }

		/// <summary>
		/// Gets or sets the path to the resource referenced by the URI.
		/// </summary>
		string Path { get; set; }

		/// <summary>
		/// Gets or sets the port number of the URI.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">
		/// The port cannot be set to a value less than -1 or greater than 65,535.
		/// </exception>
		int Port { get; set; }

		/// <summary>
		/// Gets or sets any query information included in the URI.
		/// </summary>
		string Query { get; set; }

		/// <summary>
		/// Gets or sets the scheme name of the URI.
		/// </summary>
		string Scheme { get; set; }

#pragma warning disable 1584, 1574
		/// <summary>
		/// Gets the Uri instance constructed by the specified UriBuilder instance.
		/// </summary>
		/// <exception cref="UriFormatException">
		/// In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, FormatException, instead.
		/// The UriBuilder instance has a bad password.
		/// </exception>
		Uri Uri { get; }
#pragma warning restore 1584, 1574

		/// <summary>
		/// The user name associated with the user that accesses the URI.
		/// </summary>
		string UserName { get; set; }
	}
}