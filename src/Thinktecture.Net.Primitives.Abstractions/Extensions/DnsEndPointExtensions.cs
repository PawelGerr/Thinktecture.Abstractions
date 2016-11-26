#if NETSTANDARD1_3 || NET45 || NET46

using System.Net;
using Thinktecture.Net;
using Thinktecture.Net.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="DnsEndPoint"/>.
	/// </summary>
	public static class DnsEndPointExtensions
	{
		/// <summary>
		/// Converts provided endpoint to <see cref="IDnsEndPoint"/>.
		/// </summary>
		/// <param name="endPoint">Endpoint to convert.</param>
		/// <returns>Converted endpoint.</returns>
		public static IDnsEndPoint ToInterface(this DnsEndPoint endPoint)
		{
			return (endPoint == null) ? null : new DnsEndPointAdapter(endPoint);
		}

		/// <summary>
		/// Converts provided endpoint to <see cref="DnsEndPoint"/>.
		/// </summary>
		/// <param name="endpoint">Endpoint to convert.</param>
		/// <returns>Converted endpoint.</returns>
		public static DnsEndPoint ToImplementation(this IDnsEndPoint endpoint)
		{
			return endpoint?.UnsafeConvert();
		}
	}
}

#endif