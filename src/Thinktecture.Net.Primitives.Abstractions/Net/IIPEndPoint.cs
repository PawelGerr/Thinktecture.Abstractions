#if NETSTANDARD1_3 || NET45 || NET46

using System.ComponentModel;
using System.Net;

namespace Thinktecture.Net
{
	/// <summary>Represents a network endpoint as an IP address and a port number.</summary>
	// ReSharper disable once InconsistentNaming
	public interface IIPEndPoint : IEndPoint
	{
		/// <summary>
		/// Gets inner instance of <see cref="IPEndPoint"/>.
		/// It is not intended to be used directly. Use <see cref="IPEndPointExtensions.ToImplementation"/> instead.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		new IPEndPoint UnsafeConvert();

		/// <summary>Gets or sets the IP address of the endpoint.</summary>
		/// <returns>An <see cref="T:System.Net.IPAddress" /> instance containing the IP address of the endpoint.</returns>
		IIPAddress Address { get; set; }
		
		/// <summary>Gets or sets the port number of the endpoint.</summary>
		/// <returns>An integer value in the range <see cref="F:System.Net.IPEndPoint.MinPort" /> to <see cref="F:System.Net.IPEndPoint.MaxPort" /> indicating the port number of the endpoint.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value that was specified for a set operation is less than <see cref="F:System.Net.IPEndPoint.MinPort" /> or greater than <see cref="F:System.Net.IPEndPoint.MaxPort" />. </exception>
		int Port { get; set; }
	}
}

#endif