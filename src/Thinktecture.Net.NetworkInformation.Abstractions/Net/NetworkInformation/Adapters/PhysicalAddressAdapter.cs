#if NETSTANDARD1_3 || NET45 || NET46

using System;
using System.Net.NetworkInformation;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>
	/// Provides the Media Access Control (MAC) address for a network interface (adapter).
	/// </summary>
	public class PhysicalAddressAdapter : AbstractionAdapter<PhysicalAddress>, IPhysicalAddress
	{
		/// <summary>
		/// Returns a new <see cref="IPhysicalAddress"/> instance with a zero length address. This field is read-only.
		/// </summary>
		public static readonly IPhysicalAddress None = new PhysicalAddressAdapter(PhysicalAddress.None);

		/// <summary>
		/// Parses the specified <see cref="String"/> and stores its contents as the address bytes of the <see cref="IPhysicalAddress"/> returned by this method.
		/// </summary>
		/// <param name="address">A String containing the address that will be used to initialize the PhysicalAddress instance returned by this method.</param>
		/// <returns>A <see cref="IPhysicalAddress"/> instance with the specified address.</returns>
		[NotNull]
		public static IPhysicalAddress Parse([CanBeNull] string address)
		{
			return PhysicalAddress.Parse(address).ToInterface();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PhysicalAddressAdapter"/> class.
		/// </summary>
		/// <param name="address">A Byte array containing the address.</param>
		public PhysicalAddressAdapter([CanBeNull] byte[] address)
			: this(new PhysicalAddress(address))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PhysicalAddressAdapter"/> class.
		/// </summary>
		/// <param name="address">Address to be used by the adapter.</param>
		public PhysicalAddressAdapter([NotNull] PhysicalAddress address)
			: base(address)
		{
		}

		/// <inheritdoc />
		public byte[] GetAddressBytes()
		{
			return Implementation.GetAddressBytes();
		}
	}
}

#endif
