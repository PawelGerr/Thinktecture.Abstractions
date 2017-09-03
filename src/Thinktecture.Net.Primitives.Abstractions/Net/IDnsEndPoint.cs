#if NETSTANDARD1_3 || NET45

using System.Net;
using JetBrains.Annotations;

namespace Thinktecture.Net
{
	/// <summary>Identifies a network address.</summary>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface IDnsEndPoint : IEndPoint, IAbstraction<DnsEndPoint>
	{
		/// <summary>Gets the host name or string representation of the Internet Protocol (IP) address of the host.</summary>
		/// <returns>A host name or string representation of an IP address.</returns>
		[NotNull]
		string Host { get; }

		/// <summary>Gets the port number of the <see cref="T:System.Net.DnsEndPoint" />.</summary>
		/// <returns>An integer value in the range 0 to 0xffff indicating the port number of the <see cref="T:System.Net.DnsEndPoint" />.</returns>
		int Port { get; }
	}
}

#endif
