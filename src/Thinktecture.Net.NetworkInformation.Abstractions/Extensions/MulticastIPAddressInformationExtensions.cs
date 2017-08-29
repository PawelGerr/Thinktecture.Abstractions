#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;
using JetBrains.Annotations;
using Thinktecture.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="MulticastIPAddressInformation"/>.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public static class MulticastIPAddressInformationExtensions
	{
		/// <summary>
		/// Converts provided info to <see cref="IMulticastIPAddressInformation"/>.
		/// </summary>
		/// <param name="info">Info to convert.</param>
		/// <returns>Converted info.</returns>
		[CanBeNull]
		public static IMulticastIPAddressInformation ToInterface([CanBeNull] this MulticastIPAddressInformation info)
		{
			return (info == null) ? null : new MulticastIPAddressInformationAdapter(info);
		}

		/// <summary>
		/// Converts provided <see cref="IMulticastIPAddressInformation"/> info to <see cref="MulticastIPAddressInformation"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="IMulticastIPAddressInformation"/> to convert.</param>
		/// <returns>An instance of <see cref="MulticastIPAddressInformation"/>.</returns>
		[CanBeNull]
		public static MulticastIPAddressInformation ToImplementation([CanBeNull] this IMulticastIPAddressInformation abstraction)
		{
			return ((IAbstraction<MulticastIPAddressInformation>)abstraction)?.UnsafeConvert();
		}
	}
}

#endif
