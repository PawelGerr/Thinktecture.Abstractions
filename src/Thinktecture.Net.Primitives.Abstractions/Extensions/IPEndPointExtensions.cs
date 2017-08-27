#if NETSTANDARD1_3 || NET45 || NET46

using System.Net;
using Thinktecture.Net;
using Thinktecture.Net.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="IPEndPoint"/>.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public static class IPEndPointExtensions
	{
		/// <summary>
		/// Converts provided endpoint to <see cref="IEndPoint"/>.
		/// </summary>
		/// <param name="endPoint">Endpoint to convert.</param>
		/// <returns>Converted endpoint.</returns>
		public static IIPEndPoint ToInterface(this IPEndPoint endPoint)
		{
			return (endPoint == null) ? null : new IPEndPointAdapter(endPoint);
		}
	}
}

#endif
