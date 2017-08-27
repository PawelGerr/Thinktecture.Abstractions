#if NETSTANDARD1_3 || NET45 || NET46

using System;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>
	/// Provides information about network interfaces that support Internet Protocol version 6 (IPv6).
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public class IPv6InterfacePropertiesAdapter : AbstractionAdapter, IIPv6InterfaceProperties
	{
		private readonly IPv6InterfaceProperties _props;

		/// <inheritdoc />
		public int Index => _props.Index;

		/// <inheritdoc />
		public int Mtu => _props.Mtu;

		/// <inheritdoc />
		public long GetScopeId(ScopeLevel scopeLevel)
		{
			return _props.GetScopeId(scopeLevel);
		}

		/// <summary>
		/// Initializes new instance of <see cref="IPv6InterfacePropertiesAdapter"/>.
		/// </summary>
		/// <param name="props">Properties to be used by the adapter.</param>
		public IPv6InterfacePropertiesAdapter(IPv6InterfaceProperties props)
			: base(props)
		{
			_props = props ?? throw new ArgumentNullException(nameof(props));
		}

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new IPv6InterfaceProperties UnsafeConvert()
		{
			return _props;
		}
	}
}

#endif
