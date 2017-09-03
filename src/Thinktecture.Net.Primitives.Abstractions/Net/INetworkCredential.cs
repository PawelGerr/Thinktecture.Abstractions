using System;
using System.Net;
using JetBrains.Annotations;

namespace Thinktecture.Net
{
	/// <summary>Provides credentials for password-based authentication schemes such as basic, digest, NTLM, and Kerberos authentication.</summary>
	public interface INetworkCredential : IAbstraction<NetworkCredential>, ICredentials
#if NETSTANDARD1_1 || NETSTANDARD1_3 || NET45
		, ICredentialsByHost
#endif
	{
		/// <summary>Gets or sets the domain or computer name that verifies the credentials.</summary>
		/// <returns>The name of the domain associated with the credentials.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[CanBeNull]
		string Domain { [NotNull] get; [CanBeNull] set; }

		/// <summary>Gets or sets the password for the user name associated with the credentials.</summary>
		/// <returns>The password associated with the credentials. If this <see cref="T:System.Net.NetworkCredential" /> instance was initialized with the <see name="Password" /> parameter set to null, then the <see cref="P:System.Net.NetworkCredential.Password" /> property will return an empty string.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[CanBeNull]
		string Password { [NotNull] get; [CanBeNull] set; }

		/// <summary>Gets or sets the user name associated with the credentials.</summary>
		/// <returns>The user name associated with the credentials.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[CanBeNull]
		string UserName { [NotNull] get; [CanBeNull] set; }

		/// <summary>Returns an instance of the <see cref="T:System.Net.NetworkCredential" /> class for the specified Uniform Resource Identifier (URI) and authentication type.</summary>
		/// <returns>A <see cref="T:System.Net.NetworkCredential" /> object.</returns>
		/// <param name="uri">The URI that the client provides authentication for. </param>
		/// <param name="authType">The type of authentication requested, as defined in the <see cref="P:System.Net.IAuthenticationModule.AuthenticationType" /> property. </param>
		[NotNull]
		new INetworkCredential GetCredential([CanBeNull] Uri uri, [CanBeNull] string authType);

#if NETSTANDARD1_1 || NETSTANDARD1_3 || NET45
		/// <summary>Returns an instance of the NetworkCredential class for the specified host, port, and authentication type.</summary>
		/// <param name="host">The host computer that authenticates the client.</param>
		/// <param name="port">The port on the host that the client communicates with.</param>
		/// <param name="authenticationType">The type of authentication requested, as defined in the IAuthenticationModule.AuthenticationType property.</param>
		/// <returns>A NetworkCredential for the specified host, port, and authentication protocol, or null if there are no credentials available for the specified host, port, and authentication protocol.</returns>
		[NotNull]
		new INetworkCredential GetCredential([CanBeNull] string host, int port, [CanBeNull] string authenticationType);
#endif
	}
}
