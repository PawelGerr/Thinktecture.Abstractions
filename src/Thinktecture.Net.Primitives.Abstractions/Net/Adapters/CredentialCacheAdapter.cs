#if NETSTANDARD1_1 || NETSTANDARD1_3 || NET45 || NET46

using System;
using System.Collections;
using System.ComponentModel;
using System.Net;

namespace Thinktecture.Net.Adapters
{
	/// <summary>Provides storage for multiple credentials.</summary>
	public class CredentialCacheAdapter : ICredentialCache
	{
		private readonly CredentialCache _cache;

		/// <summary>Gets the system credentials of the application.</summary>
		/// <returns>An <see cref="T:System.Net.ICredentials" /> that represents the system credentials of the application.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="USERNAME" />
		/// </PermissionSet>
		public static ICredentials DefaultCredentials => CredentialCache.DefaultCredentials;

		/// <summary>Gets the network credentials of the current security context.</summary>
		/// <returns>An <see cref="T:System.Net.NetworkCredential" /> that represents the network credentials of the current user or application.</returns>
		public static INetworkCredential DefaultNetworkCredentials => CredentialCache.DefaultNetworkCredentials.ToInterface();

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public CredentialCache UnsafeConvert()
		{
			return _cache;
		}

		/// <summary>
		/// Initializes new instance of <see cref="CredentialCacheAdapter"/>.
		/// </summary>
		/// <param name="cache">Cache to be used by the adapter.</param>
		public CredentialCacheAdapter(CredentialCache cache)
		{
			if (cache == null)
				throw new ArgumentNullException(nameof(cache));
			_cache = cache;
		}

		/// <inheritdoc />
		public void Add(string host, int port, string authenticationType, NetworkCredential credential)
		{
			_cache.Add(host, port, authenticationType, credential);
		}

		/// <inheritdoc />
		public void Add(string host, int port, string authenticationType, INetworkCredential credential)
		{
			_cache.Add(host, port, authenticationType, credential.ToImplementation());
		}

		/// <inheritdoc />
		public void Add(Uri uriPrefix, string authType, NetworkCredential cred)
		{
			_cache.Add(uriPrefix, authType, cred);
		}

		/// <inheritdoc />
		public void Add(Uri uriPrefix, string authType, INetworkCredential cred)
		{
			_cache.Add(uriPrefix, authType, cred.ToImplementation());
		}

		/// <inheritdoc />
		public INetworkCredential GetCredential(string host, int port, string authenticationType)
		{
			return _cache.GetCredential(host, port, authenticationType).ToInterface();
		}

		/// <inheritdoc />
		public INetworkCredential GetCredential(Uri uriPrefix, string authType)
		{
			return _cache.GetCredential(uriPrefix, authType).ToInterface();
		}

		/// <inheritdoc />
		public IEnumerator GetEnumerator()
		{
			return _cache.GetEnumerator();
		}

		/// <inheritdoc />
		public void Remove(string host, int port, string authenticationType)
		{
			_cache.Remove(host, port, authenticationType);
		}

		/// <inheritdoc />
		public void Remove(Uri uriPrefix, string authType)
		{
			_cache.Remove(uriPrefix, authType);
		}

		NetworkCredential ICredentials.GetCredential(Uri uri, string authType)
		{
			return _cache.GetCredential(uri, authType);
		}

		NetworkCredential ICredentialsByHost.GetCredential(string host, int port, string authenticationType)
		{
			return _cache.GetCredential(host, port, authenticationType);
		}
	}
}

#endif