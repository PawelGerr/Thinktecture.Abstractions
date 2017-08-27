#if NETSTANDARD1_3 || NET45 || NET46

using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;

namespace Thinktecture.Net.Adapters
{
	/// <summary>Stores serialized information from <see cref="T:System.Net.EndPoint" /> derived classes.</summary>
	public class SocketAddressAdapter : AbstractionAdapter, ISocketAddress
	{
		private readonly SocketAddress _address;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new SocketAddress UnsafeConvert()
		{
			return _address;
		}

		/// <inheritdoc />
		public AddressFamily Family => _address.Family;

		/// <inheritdoc />
		public byte this[int offset]
		{
			get { return _address[offset]; }
			set { _address[offset] = value; }
		}

		/// <inheritdoc />
		public int Size => _address.Size;

		/// <summary>Creates a new instance of the <see cref="T:System.Net.SocketAddress" /> class for the given address family.</summary>
		/// <param name="family">An <see cref="T:System.Net.Sockets.AddressFamily" /> enumerated value. </param>
		public SocketAddressAdapter(AddressFamily family)
			: this(new SocketAddress(family))
		{
		}

		/// <summary>Creates a new instance of the <see cref="T:System.Net.SocketAddress" /> class using the specified address family and buffer size.</summary>
		/// <param name="family">An <see cref="T:System.Net.Sockets.AddressFamily" /> enumerated value. </param>
		/// <param name="size">The number of bytes to allocate for the underlying buffer. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="size" /> is less than 2. These 2 bytes are needed to store <paramref name="family" />. </exception>
		public SocketAddressAdapter(AddressFamily family, int size)
			: this(new SocketAddress(family, size))
		{
		}

		/// <summary>Creates a new instance of the <see cref="T:System.Net.SocketAddress" /> class.</summary>
		/// <param name="address">Address to be used by the adapter</param>
		public SocketAddressAdapter(SocketAddress address)
			: base(address)
		{
			if (address == null)
				throw new ArgumentNullException(nameof(address));

			_address = address;
		}
	}
}

#endif
