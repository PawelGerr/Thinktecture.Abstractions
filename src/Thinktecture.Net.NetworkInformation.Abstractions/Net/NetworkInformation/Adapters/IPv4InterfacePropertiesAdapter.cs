#if NETSTANDARD1_3 || NET45 || NET46

using System;
using System.Net.NetworkInformation;
using JetBrains.Annotations;

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>
	/// Provides information about network interfaces that support Internet Protocol version 4 (IPv4).
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public class IPv4InterfacePropertiesAdapter : AbstractionAdapter<IPv4InterfaceProperties>, IIPv4InterfaceProperties
	{
		/// <inheritdoc />
		public int Index => Implementation.Index;

		/// <inheritdoc />
		public bool IsAutomaticPrivateAddressingActive => Implementation.IsAutomaticPrivateAddressingActive;

		/// <inheritdoc />
		public bool IsAutomaticPrivateAddressingEnabled => Implementation.IsAutomaticPrivateAddressingEnabled;

		/// <inheritdoc />
		public bool IsDhcpEnabled => Implementation.IsDhcpEnabled;

		/// <inheritdoc />
		public bool IsForwardingEnabled => Implementation.IsForwardingEnabled;

		/// <inheritdoc />
		public int Mtu => Implementation.Mtu;

		/// <inheritdoc />
		public bool UsesWins => Implementation.UsesWins;

		/// <summary>
		/// Initializes new instance of <see cref="IPv4InterfacePropertiesAdapter"/>.
		/// </summary>
		/// <param name="props">Properties to be used by the adapter.</param>
		public IPv4InterfacePropertiesAdapter([NotNull] IPv4InterfaceProperties props)
			: base(props)
		{
		}
	}
}

#endif
