using System;
using System.ComponentModel;
using System.Net;

namespace Thinktecture.Net
{
	/// <summary>Provides credentials for password-based authentication schemes such as basic, digest, NTLM, and Kerberos authentication.</summary>
	public interface INetworkCredential : ICredentials
	{
		/// <summary>
		/// Gets inner instance of <see cref="Cookie"/>.
		/// It is not intended to be used directly. Use <see cref="NetworkCredentialExtensions.ToImplementation"/> instead.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		NetworkCredential UnsafeConvert();

		/// <summary>Gets or sets the domain or computer name that verifies the credentials.</summary>
		/// <returns>The name of the domain associated with the credentials.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		string Domain { get; set; }

		/// <summary>Gets or sets the password for the user name associated with the credentials.</summary>
		/// <returns>The password associated with the credentials. If this <see cref="T:System.Net.NetworkCredential" /> instance was initialized with the <see name="Password" /> parameter set to null, then the <see cref="P:System.Net.NetworkCredential.Password" /> property will return an empty string.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		string Password { get; set; }

		/// <summary>Gets or sets the user name associated with the credentials.</summary>
		/// <returns>The user name associated with the credentials.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		string UserName { get; set; }
		
		/// <summary>Returns an instance of the <see cref="T:System.Net.NetworkCredential" /> class for the specified Uniform Resource Identifier (URI) and authentication type.</summary>
		/// <returns>A <see cref="T:System.Net.NetworkCredential" /> object.</returns>
		/// <param name="uri">The URI that the client provides authentication for. </param>
		/// <param name="authType">The type of authentication requested, as defined in the <see cref="P:System.Net.IAuthenticationModule.AuthenticationType" /> property. </param>
		new INetworkCredential GetCredential(Uri uri, string authType);
	}
}