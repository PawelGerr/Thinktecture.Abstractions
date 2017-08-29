#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;
using JetBrains.Annotations;
using Thinktecture.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="UnicastIPAddressInformation"/>.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public static class UnicastIPAddressInformationExtensions
	{
		/// <summary>
		/// Converts provided info to <see cref="IUnicastIPAddressInformation"/>.
		/// </summary>
		/// <param name="info">Info to convert.</param>
		/// <returns>Converted info.</returns>
		[CanBeNull]
		public static IUnicastIPAddressInformation ToInterface([CanBeNull] this UnicastIPAddressInformation info)
		{
			return (info == null) ? null : new UnicastIPAddressInformationAdapter(info);
		}

		/// <summary>
		/// Converts provided <see cref="IUnicastIPAddressInformation"/> info to <see cref="UnicastIPAddressInformation"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="IUnicastIPAddressInformation"/> to convert.</param>
		/// <returns>An instance of <see cref="UnicastIPAddressInformation"/>.</returns>
		[CanBeNull]
		public static UnicastIPAddressInformation ToImplementation([CanBeNull] this IUnicastIPAddressInformation abstraction)
		{
			return ((IAbstraction<UnicastIPAddressInformation>)abstraction)?.UnsafeConvert();
		}
	}
}

#endif
