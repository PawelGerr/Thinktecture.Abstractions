#if NETSTANDARD1_3 || NET45

using System.Net;
using JetBrains.Annotations;
using Thinktecture.Net;
using Thinktecture.Net.Adapters;

// ReSharper disable once CheckNamespace
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
		[CanBeNull]
		public static IEndPoint ToInterface([CanBeNull] this EndPoint endPoint)
		{
			return (endPoint == null) ? null : new EndPointAdapter(endPoint);
		}
	}
}

#endif
