#if NETSTANDARD1_3 || NET45 || NET46

using System;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>
	/// Provides the Media Access Control (MAC) address for a network interface (adapter).
	/// </summary>
	public class PhysicalAddressAdapter : AbstractionAdapter, IPhysicalAddress
	{
		private readonly PhysicalAddress _address;

		/// <summary>
		/// Returns a new <see cref="IPhysicalAddress"/> instance with a zero length address. This field is read-only.
		/// </summary>
		public static readonly IPhysicalAddress None = PhysicalAddress.None.ToInterface();

		/// <summary>
		/// Parses the specified <see cref="string"/> and stores its contents as the address bytes of the <see cref="IPhysicalAddress"/> returned by this method.
		/// </summary>
		/// <param name="address">A String containing the address that will be used to initialize the PhysicalAddress instance returned by this method.</param>
		/// <returns>A <see cref="IPhysicalAddress"/> instance with the specified address.</returns>
		public static IPhysicalAddress Parse(string address)
		{
			return PhysicalAddress.Parse(address).ToInterface();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PhysicalAddressAdapter"/> class.
		/// </summary>
		/// <param name="address">A Byte array containing the address.</param>
		public PhysicalAddressAdapter(byte[] address)
			: this(new PhysicalAddress(address))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PhysicalAddressAdapter"/> class.
		/// </summary>
		/// <param name="address">Address to be used by the adapter.</param>
		public PhysicalAddressAdapter(PhysicalAddress address)
			: base(address)
		{
			if (address == null)
				throw new ArgumentNullException(nameof(address));

			_address = address;
		}

		/// <inheritdoc />
		public byte[] GetAddressBytes()
		{
			return _address.GetAddressBytes();
		}

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new PhysicalAddress UnsafeConvert()
		{
			return _address;
		}
	}
}

#endif