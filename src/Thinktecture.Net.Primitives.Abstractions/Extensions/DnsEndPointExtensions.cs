#if NETSTANDARD1_3 || NET45

using System.Net;
using JetBrains.Annotations;
using Thinktecture.Net;
using Thinktecture.Net.Adapters;

// ReSharper disable once CheckNamespace
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
		[CanBeNull]
		public static IDnsEndPoint ToInterface([CanBeNull] this DnsEndPoint endPoint)
		{
			return (endPoint == null) ? null : new DnsEndPointAdapter(endPoint);
		}

		/// <summary>
		/// Converts provided <see cref="IDnsEndPoint"/> info to <see cref="DnsEndPoint"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="IDnsEndPoint"/> to convert.</param>
		/// <returns>An instance of <see cref="DnsEndPoint"/>.</returns>
		[CanBeNull]
		public static DnsEndPoint ToImplementation([CanBeNull] this IDnsEndPoint abstraction)
		{
			return ((IAbstraction<DnsEndPoint>)abstraction)?.UnsafeConvert();
		}
	}
}

#endif
