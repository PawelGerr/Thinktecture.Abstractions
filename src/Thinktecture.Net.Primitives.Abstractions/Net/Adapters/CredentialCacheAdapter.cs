using System;
using System.Collections;
using System.Net;
// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.Adapters
{
	/// <summary>Provides storage for multiple credentials.</summary>
	public class CredentialCacheAdapter : AbstractionAdapter<CredentialCache>, ICredentialCache
	{
		/// <summary>Gets the system credentials of the application.</summary>
		/// <returns>An <see cref="T:System.Net.ICredentials" /> that represents the system credentials of the application.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="USERNAME" />
		/// </PermissionSet>
		public static ICredentials DefaultCredentials => CredentialCache.DefaultCredentials;

		/// <summary>Gets the network credentials of the current security context.</summary>
		/// <returns>An <see cref="T:System.Net.NetworkCredential" /> that represents the network credentials of the current user or application.</returns>
		public static INetworkCredential DefaultNetworkCredentials => new NetworkCredentialAdapter(CredentialCache.DefaultNetworkCredentials);

		/// <summary>
		/// Initializes new instance of <see cref="CredentialCacheAdapter"/>.
		/// </summary>
		public CredentialCacheAdapter()
			: base(new CredentialCache())
		{
		}

		/// <summary>
		/// Initializes new instance of <see cref="CredentialCacheAdapter"/>.
		/// </summary>
		/// <param name="cache">Cache to be used by the adapter.</param>
		public CredentialCacheAdapter(CredentialCache cache)
			: base(cache)
		{
		}

		/// <inheritdoc />
		public void Add(string host, int port, string authenticationType, NetworkCredential credential)
		{
			Implementation.Add(host, port, authenticationType, credential);
		}

		/// <inheritdoc />
		public void Add(string host, int port, string authenticationType, INetworkCredential credential)
		{
			Add(host, port, authenticationType, credential.ToImplementation());
		}

		/// <inheritdoc />
		public void Add(Uri uriPrefix, string authType, NetworkCredential cred)
		{
			Implementation.Add(uriPrefix, authType, cred);
		}

		/// <inheritdoc />
		public void Add(Uri uriPrefix, string authType, INetworkCredential cred)
		{
			Add(uriPrefix, authType, cred.ToImplementation());
		}

		/// <inheritdoc />
		public INetworkCredential? GetCredential(string host, int port, string authenticationType)
		{
			return Implementation.GetCredential(host, port, authenticationType).ToInterface();
		}

		/// <inheritdoc />
		public INetworkCredential? GetCredential(Uri uriPrefix, string authType)
		{
			return Implementation.GetCredential(uriPrefix, authType).ToInterface();
		}

		/// <inheritdoc />
		public IEnumerator GetEnumerator()
		{
			return Implementation.GetEnumerator();
		}

		/// <inheritdoc />
		public void Remove(string? host, int port, string? authenticationType)
		{
			Implementation.Remove(host, port, authenticationType);
		}

		/// <inheritdoc />
		public void Remove(Uri? uriPrefix, string? authType)
		{
			Implementation.Remove(uriPrefix, authType);
		}

		NetworkCredential? ICredentials.GetCredential(Uri uri, string authType)
		{
			return Implementation.GetCredential(uri, authType);
		}

		NetworkCredential? ICredentialsByHost.GetCredential(string host, int port, string authenticationType)
		{
			return Implementation.GetCredential(host, port, authenticationType);
		}
	}
}
