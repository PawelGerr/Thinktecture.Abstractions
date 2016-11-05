using System;

namespace Thinktecture
{
	public interface IUriBuilder
	{
		/// <summary>
		/// Gets inner instance of <see cref="UriBuilder"/>;
		/// </summary>
		/// <returns>Instance of <see cref="UriBuilder"/>.</returns>
		UriBuilder ToImplementation();

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

		/// <summary>
		/// Gets the Uri instance constructed by the specified UriBuilder instance.
		/// </summary>
		/// <exception cref="System.UriFormatException">
		/// In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, FormatException, instead.
		/// The UriBuilder instance has a bad password.
		/// </exception>
		Uri Uri { get; }

		/// <summary>
		/// The user name associated with the user that accesses the URI.
		/// </summary>
		string UserName { get; set; }

		/// <summary>
		/// Compares an existing Uri instance with the contents of the UriBuilder for equality.
		/// </summary>
		/// <param name="rparam">The object to compare with the current instance.</param>
		/// <returns><c>true</c> if rparam represents the same Uri as the Uri constructed by this UriBuilder instance; otherwise, <c>false</c>.</returns>
		bool Equals(object rparam);

		/// <summary>
		/// Returns the hash code for the URI.
		/// </summary>
		/// <returns>The hash code generated for the URI.</returns>
		int GetHashCode();

		/// <summary>
		/// Returns the display string for the specified UriBuilder instance.
		/// </summary>
		/// <exception cref="System.UriFormatException">
		/// In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, FormatException, instead.
		/// The UriBuilder instance has a bad password.
		/// </exception>
		/// <returns>The string that contains the unescaped display string of the UriBuilder.</returns>
		string ToString();
	}
}