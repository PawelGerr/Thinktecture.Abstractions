using System;
using System.ComponentModel;
using System.Net;

namespace Thinktecture.Net.Adapters
{
	/// <summary>Provides credentials for password-based authentication schemes such as basic, digest, NTLM, and Kerberos authentication.</summary>
	public class NetworkCredentialAdapter : INetworkCredential
	{
		private readonly NetworkCredential _credential;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public NetworkCredential UnsafeConvert()
		{
			return _credential;
		}

		/// <inheritdoc />
		public string Domain
		{
			get { return _credential.Domain; }
			set { _credential.Domain = value; }
		}

		/// <inheritdoc />
		public string Password
		{
			get { return _credential.Password; }
			set { _credential.Password = value; }
		}

		/// <inheritdoc />
		public string UserName
		{
			get { return _credential.UserName; }
			set { _credential.UserName = value; }
		}

		/// <summary>Initializes a new instance of the <see cref="NetworkCredentialAdapter" /> class.</summary>
		public NetworkCredentialAdapter()
			: this(new NetworkCredential())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="NetworkCredentialAdapter" /> class with the specified user name and password.</summary>
		/// <param name="userName">The user name associated with the credentials. </param>
		/// <param name="password">The password for the user name associated with the credentials. </param>
		public NetworkCredentialAdapter(string userName, string password)
			: this(new NetworkCredential(userName, password))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="NetworkCredentialAdapter" /> class with the specified user name, password, and domain.</summary>
		/// <param name="userName">The user name associated with the credentials. </param>
		/// <param name="password">The password for the user name associated with the credentials. </param>
		/// <param name="domain">The domain associated with these credentials. </param>
		public NetworkCredentialAdapter(string userName, string password, string domain)
			: this(new NetworkCredential(userName, password, domain))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="NetworkCredentialAdapter" /> class.</summary>
		/// <param name="credential">Credentials to be used by the adapter. </param>
		public NetworkCredentialAdapter(NetworkCredential credential)
		{
			if (credential == null)
				throw new ArgumentNullException(nameof(credential));

			_credential = credential;
		}

		/// <inheritdoc />
		public INetworkCredential GetCredential(Uri uri, string authType)
		{
			return _credential.GetCredential(uri, authType).ToInterface();
		}

		/// <inheritdoc />
		NetworkCredential ICredentials.GetCredential(Uri uri, string authType)
		{
			return _credential.GetCredential(uri, authType);
		}
	}
}