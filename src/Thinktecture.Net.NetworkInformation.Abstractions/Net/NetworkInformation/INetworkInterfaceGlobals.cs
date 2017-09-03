#if NETSTANDARD1_3 || NET45 || NET46

using JetBrains.Annotations;

namespace Thinktecture.Net.NetworkInformation
{
	/// <summary>Provides configuration and statistical information for network interfaces.</summary>
	public interface INetworkInterfaceGlobals
	{
		/// <summary>Gets the index of the IPv4 loopback interface.</summary>
		/// <returns>A <see cref="T:System.Int32" /> that contains the index for the IPv4 loopback interface.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">This property is not valid on computers running only Ipv6.</exception>
		int LoopbackInterfaceIndex { get; }

		/// <summary>Gets the index of the IPv6 loopback interface.</summary>
		/// <returns>Returns <see cref="T:System.Int32" />.The index for the IPv6 loopback interface.</returns>
		// ReSharper disable once InconsistentNaming
		int IPv6LoopbackInterfaceIndex { get; }

		/// <summary>Returns objects that describe the network interfaces on the local computer.</summary>
		/// <returns>A <see cref="T:System.Net.NetworkInformation.NetworkInterface" /> array that contains objects that describe the available network interfaces, or an empty array if no interfaces are detected.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">A Windows system function call failed. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Net.NetworkInformation.NetworkInformationPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Access="Read" />
		/// </PermissionSet>
		[NotNull]
		INetworkInterface[] GetAllNetworkInterfaces();

		/// <summary>Indicates whether any network connection is available.</summary>
		/// <returns>true if a network connection is available; otherwise, false.</returns>
		bool GetIsNetworkAvailable();
	}
}

#endif
