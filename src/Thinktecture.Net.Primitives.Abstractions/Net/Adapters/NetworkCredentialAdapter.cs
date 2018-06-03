using System;
using System.Net;
using JetBrains.Annotations;
#if NET45 || NETSTANDARD2_0
using System.Security;

#endif

// ReSharper disable AssignNullToNotNullAttribute
namespace Thinktecture.Net.Adapters
{
	/// <summary>Provides credentials for password-based authentication schemes such as basic, digest, NTLM, and Kerberos authentication.</summary>
	public class NetworkCredentialAdapter : AbstractionAdapter<NetworkCredential>, INetworkCredential
	{
		/// <inheritdoc />
		public string Domain
		{
			get => Implementation.Domain;
			set => Implementation.Domain = value;
		}

#if NET45 || NETSTANDARD2_0
		/// <inheritdoc />
		public SecureString SecurePassword
		{
			get => Implementation.SecurePassword;
			set => Implementation.SecurePassword = value;
		}
#endif

		/// <inheritdoc />
		public string Password
		{
			get => Implementation.Password;
			set => Implementation.Password = value;
		}

		/// <inheritdoc />
		public string UserName
		{
			get => Implementation.UserName;
			set => Implementation.UserName = value;
		}

		/// <summary>Initializes a new instance of the <see cref="NetworkCredentialAdapter" /> class.</summary>
		public NetworkCredentialAdapter()
			: this(new NetworkCredential())
		{
		}

#if NET45 || NETSTANDARD2_0
		/// <summary>Initializes a new instance of the <see cref="NetworkCredentialAdapter" /> class.</summary>
		/// <param name="userName">The user name associated with the credentials. </param>
		/// <param name="password">The password for the user name associated with the credentials. </param>
		public NetworkCredentialAdapter(string userName, SecureString password)
			: this(new NetworkCredential(userName, password))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="NetworkCredentialAdapter" /> class.</summary>
		/// <param name="userName">The user name associated with the credentials. </param>
		/// <param name="password">The password for the user name associated with the credentials. </param>
		/// <param name="domain">The domain associated with these credentials. </param>
		public NetworkCredentialAdapter(string userName, SecureString password, string domain)
			: this(new NetworkCredential(userName, password, domain))
		{
		}
#endif

		/// <summary>Initializes a new instance of the <see cref="NetworkCredentialAdapter" /> class with the specified user name and password.</summary>
		/// <param name="userName">The user name associated with the credentials. </param>
		/// <param name="password">The password for the user name associated with the credentials. </param>
		public NetworkCredentialAdapter([CanBeNull] string userName, [CanBeNull] string password)
			: this(new NetworkCredential(userName, password))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="NetworkCredentialAdapter" /> class with the specified user name, password, and domain.</summary>
		/// <param name="userName">The user name associated with the credentials. </param>
		/// <param name="password">The password for the user name associated with the credentials. </param>
		/// <param name="domain">The domain associated with these credentials. </param>
		public NetworkCredentialAdapter([CanBeNull] string userName, [CanBeNull] string password, [CanBeNull] string domain)
			: this(new NetworkCredential(userName, password, domain))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="NetworkCredentialAdapter" /> class.</summary>
		/// <param name="credential">Credentials to be used by the adapter. </param>
		public NetworkCredentialAdapter([NotNull] NetworkCredential credential)
			: base(credential)
		{
		}

		/// <inheritdoc />
		public INetworkCredential GetCredential(Uri uri, string authType)
		{
			return Implementation.GetCredential(uri, authType).ToInterface();
		}

		/// <inheritdoc />
		[NotNull]
		NetworkCredential ICredentials.GetCredential([CanBeNull] Uri uri, [CanBeNull] string authType)
		{
			return Implementation.GetCredential(uri, authType);
		}

#if NETSTANDARD1_1 || NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
		/// <inheritdoc />
		public INetworkCredential GetCredential(string host, int port, string authenticationType)
		{
			return Implementation.GetCredential(host, port, authenticationType).ToInterface();
		}

		/// <inheritdoc />
		[NotNull]
		NetworkCredential ICredentialsByHost.GetCredential([CanBeNull] string host, int port, [CanBeNull] string authenticationType)
		{
			return Implementation.GetCredential(host, port, authenticationType);
		}
#endif
	}
}
