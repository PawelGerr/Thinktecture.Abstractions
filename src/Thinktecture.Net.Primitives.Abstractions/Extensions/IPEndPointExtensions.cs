#if NETSTANDARD1_3 || NET45

using System.Net;
using JetBrains.Annotations;
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
		[CanBeNull]
		public static IIPEndPoint ToInterface([CanBeNull] this IPEndPoint endPoint)
		{
			return (endPoint == null) ? null : new IPEndPointAdapter(endPoint);
		}

		/// <summary>
		/// Converts provided <see cref="IIPEndPoint"/> info to <see cref="IPEndPoint"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="IIPEndPoint"/> to convert.</param>
		/// <returns>An instance of <see cref="IPEndPoint"/>.</returns>
		[CanBeNull]
		public static IPEndPoint ToImplementation([CanBeNull] this IIPEndPoint abstraction)
		{
			return ((IAbstraction<IPEndPoint>)abstraction)?.UnsafeConvert();
		}
	}
}

#endif
