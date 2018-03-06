#if NET45 || NET46 || NETSTANDARD2_0

using System.Net.NetworkInformation;
using JetBrains.Annotations;
using Thinktecture.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="NetworkAvailabilityEventArgs"/>.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public static class NetworkAvailabilityEventArgsExtensions
	{
		/// <summary>
		/// Converts provided info to <see cref="INetworkAvailabilityEventArgs"/>.
		/// </summary>
		/// <param name="eventArgs">Event args to convert.</param>
		/// <returns>Converted event args.</returns>
		[CanBeNull]
		public static INetworkAvailabilityEventArgs ToInterface([CanBeNull] this NetworkAvailabilityEventArgs eventArgs)
		{
			return (eventArgs == null) ? null : new NetworkAvailabilityEventArgsAdapter(eventArgs);
		}

		/// <summary>
		/// Converts provided <see cref="INetworkAvailabilityEventArgs"/> info to <see cref="NetworkAvailabilityEventArgs"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="INetworkAvailabilityEventArgs"/> to convert.</param>
		/// <returns>An instance of <see cref="NetworkAvailabilityEventArgs"/>.</returns>
		[CanBeNull]
		public static NetworkAvailabilityEventArgs ToImplementation([CanBeNull] this INetworkAvailabilityEventArgs abstraction)
		{
			return ((IAbstraction<NetworkAvailabilityEventArgs>)abstraction)?.UnsafeConvert();
		}
	}
}

#endif
