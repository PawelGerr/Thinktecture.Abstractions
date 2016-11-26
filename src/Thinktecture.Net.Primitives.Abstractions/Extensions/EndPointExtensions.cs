#if NETSTANDARD1_3 || NET45 || NET46

using System.Net;
using Thinktecture.Net;
using Thinktecture.Net.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="EndPoint"/>.
	/// </summary>
	public static class EndPointExtensions
	{
		/// <summary>
		/// Converts provided endpoint to <see cref="IEndPoint"/>.
		/// </summary>
		/// <param name="endPoint">Endpoint to convert.</param>
		/// <returns>Converted endpoint.</returns>
		public static IEndPoint ToInterface(this EndPoint endPoint)
		{
			return (endPoint == null) ? null : new EndPointAdapter(endPoint);
		}

		/// <summary>
		/// Converts provided endpoint to <see cref="EndPoint"/>.
		/// </summary>
		/// <param name="endPoint">Endpoint to convert.</param>
		/// <returns>Converted endpoint.</returns>
		public static EndPoint ToImplementation(this IEndPoint endPoint)
		{
			return endPoint?.UnsafeConvert();
		}
	}
}

#endif