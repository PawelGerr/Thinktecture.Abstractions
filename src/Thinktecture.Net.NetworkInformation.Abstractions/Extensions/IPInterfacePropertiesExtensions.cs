#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;
using JetBrains.Annotations;
using Thinktecture.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="IPInterfaceProperties"/>.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public static class IPInterfacePropertiesExtensions
	{
		/// <summary>
		/// Converts provided properties to <see cref="IIPInterfaceProperties"/>.
		/// </summary>
		/// <param name="properties">Properties to convert.</param>
		/// <returns>Converted properties.</returns>
		[CanBeNull]
		public static IIPInterfaceProperties ToInterface([CanBeNull] this IPInterfaceProperties properties)
		{
			return (properties == null) ? null : new IPInterfacePropertiesAdapter(properties);
		}
	}
}

#endif
