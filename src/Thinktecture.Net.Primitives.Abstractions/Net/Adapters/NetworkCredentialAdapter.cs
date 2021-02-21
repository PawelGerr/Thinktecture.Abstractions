using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Security;

// ReSharper disable AssignNullToNotNullAttribute
namespace Thinktecture.Net.Adapters
{
   /// <summary>Provides credentials for password-based authentication schemes such as basic, digest, NTLM, and Kerberos authentication.</summary>
   public class NetworkCredentialAdapter : AbstractionAdapter<NetworkCredential>, INetworkCredential
   {
      /// <inheritdoc />
      [AllowNull]
      public string Domain
      {
         get => Implementation.Domain;
         set => Implementation.Domain = value;
      }

      /// <inheritdoc />
      public SecureString SecurePassword
      {
         get => Implementation.SecurePassword;
         set => Implementation.SecurePassword = value;
      }

      /// <inheritdoc />
      [AllowNull]
      public string Password
      {
         get => Implementation.Password;
         set => Implementation.Password = value;
      }

      /// <inheritdoc />
      [AllowNull]
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

      /// <summary>Initializes a new instance of the <see cref="NetworkCredentialAdapter" /> class with the specified user name and password.</summary>
      /// <param name="userName">The user name associated with the credentials. </param>
      /// <param name="password">The password for the user name associated with the credentials. </param>
      public NetworkCredentialAdapter(string? userName, string? password)
         : this(new NetworkCredential(userName, password))
      {
      }

      /// <summary>Initializes a new instance of the <see cref="NetworkCredentialAdapter" /> class with the specified user name, password, and domain.</summary>
      /// <param name="userName">The user name associated with the credentials. </param>
      /// <param name="password">The password for the user name associated with the credentials. </param>
      /// <param name="domain">The domain associated with these credentials. </param>
      public NetworkCredentialAdapter(string? userName, string? password, string? domain)
         : this(new NetworkCredential(userName, password, domain))
      {
      }

      /// <summary>Initializes a new instance of the <see cref="NetworkCredentialAdapter" /> class.</summary>
      /// <param name="credential">Credentials to be used by the adapter. </param>
      public NetworkCredentialAdapter(NetworkCredential credential)
         : base(credential)
      {
      }

      /// <inheritdoc />
      public INetworkCredential GetCredential(Uri? uri, string? authType)
      {
         return Implementation.GetCredential(uri, authType).ToInterface();
      }

      /// <inheritdoc />
      NetworkCredential ICredentials.GetCredential(Uri? uri, string? authType)
      {
         return Implementation.GetCredential(uri, authType);
      }

      /// <inheritdoc />
      public INetworkCredential GetCredential(string? host, int port, string? authenticationType)
      {
         return Implementation.GetCredential(host, port, authenticationType).ToInterface();
      }

      /// <inheritdoc />
      NetworkCredential ICredentialsByHost.GetCredential(string? host, int port, string? authenticationType)
      {
         return Implementation.GetCredential(host, port, authenticationType);
      }
   }
}
