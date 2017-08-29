#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;
using JetBrains.Annotations;
using Thinktecture.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="IPv4InterfaceProperties"/>.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public static class IPv4InterfacePropertiesExtensions
	{
		/// <summary>
		/// Converts provided properties to <see cref="IIPv4InterfaceProperties"/>.
		/// </summary>
		/// <param name="properties">Properties to convert.</param>
		/// <returns>Converted properties.</returns>
		[CanBeNull]
		public static IIPv4InterfaceProperties ToInterface([CanBeNull] this IPv4InterfaceProperties properties)
		{
			return (properties == null) ? null : new IPv4InterfacePropertiesAdapter(properties);
		}
	}
}

#endif
