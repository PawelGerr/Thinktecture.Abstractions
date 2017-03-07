#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="IPAddressInformation"/>.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public static class IPAddressInformationExtensions
	{
		/// <summary>
		/// Converts provided info to <see cref="IIPAddressInformation"/>.
		/// </summary>
		/// <param name="info">Info to convert.</param>
		/// <returns>Converted info.</returns>
		public static IIPAddressInformation ToInterface(this IPAddressInformation info)
		{
			return (info == null) ? null : new IPAddressInformationAdapter(info);
		}
	}
}

#endif