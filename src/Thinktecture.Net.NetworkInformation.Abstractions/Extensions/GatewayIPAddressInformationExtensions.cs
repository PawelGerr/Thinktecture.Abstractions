#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;
using JetBrains.Annotations;
using Thinktecture.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="GatewayIPAddressInformation"/>.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public static class GatewayIPAddressInformationExtensions
	{
		/// <summary>
		/// Converts provided info to <see cref="IGatewayIPAddressInformation"/>.
		/// </summary>
		/// <param name="info">Info to convert.</param>
		/// <returns>Converted info.</returns>
		[CanBeNull]
		public static IGatewayIPAddressInformation ToInterface([CanBeNull] this GatewayIPAddressInformation info)
		{
			return (info == null) ? null : new GatewayIPAddressInformationAdapter(info);
		}
	}
}

#endif
