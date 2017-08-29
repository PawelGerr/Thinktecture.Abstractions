#if NETSTANDARD1_3 || NET45 || NET46

using System;
using System.Net.NetworkInformation;
using JetBrains.Annotations;

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>
	/// Provides information about network interfaces that support Internet Protocol version 6 (IPv6).
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public class IPv6InterfacePropertiesAdapter : AbstractionAdapter<IPv6InterfaceProperties>, IIPv6InterfaceProperties
	{
		/// <inheritdoc />
		public int Index => Implementation.Index;

		/// <inheritdoc />
		public int Mtu => Implementation.Mtu;

		/// <inheritdoc />
		public long GetScopeId(ScopeLevel scopeLevel)
		{
			return Implementation.GetScopeId(scopeLevel);
		}

		/// <summary>
		/// Initializes new instance of <see cref="IPv6InterfacePropertiesAdapter"/>.
		/// </summary>
		/// <param name="props">Properties to be used by the adapter.</param>
		public IPv6InterfacePropertiesAdapter([NotNull] IPv6InterfaceProperties props)
			: base(props)
		{
		}
	}
}

#endif
