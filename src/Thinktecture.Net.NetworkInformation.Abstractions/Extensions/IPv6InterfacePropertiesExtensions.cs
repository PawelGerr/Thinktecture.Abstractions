using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="IPv6InterfaceProperties"/>.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public static class IPv6InterfacePropertiesExtensions
	{
		/// <summary>
		/// Converts provided properties to <see cref="IIPv6InterfaceProperties"/>.
		/// </summary>
		/// <param name="properties">Properties to convert.</param>
		/// <returns>Converted properties.</returns>
      [return:NotNullIfNotNull("properties")]

		public static IIPv6InterfaceProperties? ToInterface(this IPv6InterfaceProperties? properties)
		{
			return (properties == null) ? null : new IPv6InterfacePropertiesAdapter(properties);
		}
	}
}
