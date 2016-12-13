#if NETSTANDARD1_3 || NET45 || NET46

using System;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>
	/// Provides information about network interfaces that support Internet Protocol version 4 (IPv4).
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public class IPv4InterfacePropertiesAdapter : AbstractionAdapter, IIPv4InterfaceProperties
	{
		private readonly IPv4InterfaceProperties _props;

		/// <inheritdoc />
		public int Index => _props.Index;

		/// <inheritdoc />
		public bool IsAutomaticPrivateAddressingActive => _props.IsAutomaticPrivateAddressingActive;

		/// <inheritdoc />
		public bool IsAutomaticPrivateAddressingEnabled => _props.IsAutomaticPrivateAddressingEnabled;

		/// <inheritdoc />
		public bool IsDhcpEnabled => _props.IsDhcpEnabled;

		/// <inheritdoc />
		public bool IsForwardingEnabled => _props.IsForwardingEnabled;

		/// <inheritdoc />
		public int Mtu => _props.Mtu;

		/// <inheritdoc />
		public bool UsesWins => _props.UsesWins;

		/// <summary>
		/// Initializes new instance of <see cref="IPv4InterfacePropertiesAdapter"/>.
		/// </summary>
		/// <param name="props">Properties to be used by the adapter.</param>
		public IPv4InterfacePropertiesAdapter(IPv4InterfaceProperties props) 
			: base(props)
		{
			if (props == null)
				throw new ArgumentNullException(nameof(props));

			_props = props;
		}

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new IPv4InterfaceProperties UnsafeConvert()
		{
			return _props;
		}
	}
}

#endif