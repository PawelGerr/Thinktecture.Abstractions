using System;
using System.Net;
using JetBrains.Annotations;

namespace Thinktecture.Net
{
	/// <summary>Provides a container for a collection of <see cref="T:System.Net.CookieCollection" /> objects.</summary>
	public interface ICookieContainer : IAbstraction<CookieContainer>
	{
		/// <summary>Gets and sets the number of <see cref="T:System.Net.Cookie" /> instances that a <see cref="T:System.Net.CookieContainer" /> can hold.</summary>
		/// <returns>The number of <see cref="T:System.Net.Cookie" /> instances that a <see cref="T:System.Net.CookieContainer" /> can hold. This is a hard limit and cannot be exceeded by adding a <see cref="T:System.Net.Cookie" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <see name="Capacity" /> is less than or equal to zero or (value is less than <see cref="P:System.Net.CookieContainer.PerDomainCapacity" /> and <see cref="P:System.Net.CookieContainer.PerDomainCapacity" /> is not equal to <see cref="F:System.Int32.MaxValue" />). </exception>
		int Capacity { get; }

		/// <summary>Gets the number of <see cref="T:System.Net.Cookie" /> instances that a <see cref="T:System.Net.CookieContainer" /> currently holds.</summary>
		/// <returns>The number of <see cref="T:System.Net.Cookie" /> instances that a <see cref="T:System.Net.CookieContainer" /> currently holds. This is the total of <see cref="T:System.Net.Cookie" /> instances in all domains.</returns>
		int Count { get; }

		/// <summary>Represents the maximum allowed length of a <see cref="T:System.Net.Cookie" />.</summary>
		/// <returns>The maximum allowed length, in bytes, of a <see cref="T:System.Net.Cookie" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <see name="MaxCookieSize" /> is less than or equal to zero. </exception>
		int MaxCookieSize { get; }

		/// <summary>Gets and sets the number of <see cref="T:System.Net.Cookie" /> instances that a <see cref="T:System.Net.CookieContainer" /> can hold per domain.</summary>
		/// <returns>The number of <see cref="T:System.Net.Cookie" /> instances that are allowed per domain.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <see name="PerDomainCapacity" /> is less than or equal to zero. (-or- <see name="PerDomainCapacity" /> is greater than the maximum allowable number of cookies instances, 300, and is not equal to <see cref="F:System.Int32.MaxValue" />). </exception>
		int PerDomainCapacity { get; }

		/// <summary>Adds a <see cref="T:System.Net.Cookie" /> to the <see cref="T:System.Net.CookieContainer" /> for a particular URI.</summary>
		/// <param name="uri">The URI of the <see cref="T:System.Net.Cookie" /> to be added to the <see cref="T:System.Net.CookieContainer" />. </param>
		/// <param name="cookie">The <see cref="T:System.Net.Cookie" /> to be added to the <see cref="T:System.Net.CookieContainer" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="uri" /> is null or <paramref name="cookie" /> is null. </exception>
		/// <exception cref="T:System.Net.CookieException">
		/// <paramref name="cookie" /> is larger than <see name="MaxCookieSize" />. -or- The domain for <paramref name="cookie" /> is not a valid URI. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		void Add([NotNull] Uri uri, [NotNull] Cookie cookie);

		/// <summary>Adds a <see cref="T:System.Net.Cookie" /> to the <see cref="T:System.Net.CookieContainer" /> for a particular URI.</summary>
		/// <param name="uri">The URI of the <see cref="T:System.Net.Cookie" /> to be added to the <see cref="T:System.Net.CookieContainer" />. </param>
		/// <param name="cookie">The <see cref="T:System.Net.Cookie" /> to be added to the <see cref="T:System.Net.CookieContainer" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="uri" /> is null or <paramref name="cookie" /> is null. </exception>
		/// <exception cref="T:System.Net.CookieException">
		/// <paramref name="cookie" /> is larger than <see name="MaxCookieSize" />. -or- The domain for <paramref name="cookie" /> is not a valid URI. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		void Add([NotNull] Uri uri, [NotNull] ICookie cookie);

		/// <summary>Adds the contents of a <see cref="T:System.Net.CookieCollection" /> to the <see cref="T:System.Net.CookieContainer" /> for a particular URI.</summary>
		/// <param name="uri">The URI of the <see cref="T:System.Net.CookieCollection" /> to be added to the <see cref="T:System.Net.CookieContainer" />. </param>
		/// <param name="cookies">The <see cref="T:System.Net.CookieCollection" /> to be added to the <see cref="T:System.Net.CookieContainer" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="cookies" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">The domain for one of the cookies in <paramref name="cookies" /> is null. </exception>
		/// <exception cref="T:System.Net.CookieException">One of the cookies in <paramref name="cookies" /> contains an invalid domain. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		void Add([NotNull] Uri uri, [NotNull] CookieCollection cookies);

		/// <summary>Adds the contents of a <see cref="T:System.Net.CookieCollection" /> to the <see cref="T:System.Net.CookieContainer" /> for a particular URI.</summary>
		/// <param name="uri">The URI of the <see cref="T:System.Net.CookieCollection" /> to be added to the <see cref="T:System.Net.CookieContainer" />. </param>
		/// <param name="cookies">The <see cref="T:System.Net.CookieCollection" /> to be added to the <see cref="T:System.Net.CookieContainer" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="cookies" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">The domain for one of the cookies in <paramref name="cookies" /> is null. </exception>
		/// <exception cref="T:System.Net.CookieException">One of the cookies in <paramref name="cookies" /> contains an invalid domain. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		void Add([NotNull] Uri uri, [NotNull] ICookieCollection cookies);

		/// <summary>Gets the HTTP cookie header that contains the HTTP cookies that represent the <see cref="T:System.Net.Cookie" /> instances that are associated with a specific URI.</summary>
		/// <returns>An HTTP cookie header, with strings representing <see cref="T:System.Net.Cookie" /> instances delimited by semicolons.</returns>
		/// <param name="uri">The URI of the <see cref="T:System.Net.Cookie" /> instances desired. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="uri" /> is null. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[NotNull]
		string GetCookieHeader([NotNull] Uri uri);

		/// <summary>Gets a <see cref="T:System.Net.CookieCollection" /> that contains the <see cref="T:System.Net.Cookie" /> instances that are associated with a specific URI.</summary>
		/// <returns>A <see cref="T:System.Net.CookieCollection" /> that contains the <see cref="T:System.Net.Cookie" /> instances that are associated with a specific URI.</returns>
		/// <param name="uri">The URI of the <see cref="T:System.Net.Cookie" /> instances desired. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="uri" /> is null. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[NotNull]
		ICookieCollection GetCookies([NotNull] Uri uri);

		/// <summary>Adds <see cref="T:System.Net.Cookie" /> instances for one or more cookies from an HTTP cookie header to the <see cref="T:System.Net.CookieContainer" /> for a specific URI.</summary>
		/// <param name="uri">The URI of the <see cref="T:System.Net.CookieCollection" />. </param>
		/// <param name="cookieHeader">The contents of an HTTP set-cookie header as returned by a HTTP server, with <see cref="T:System.Net.Cookie" /> instances delimited by commas. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="uri" /> is null. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="cookieHeader" /> is null. </exception>
		/// <exception cref="T:System.Net.CookieException">One of the cookies is invalid. -or- An error occurred while adding one of the cookies to the container. </exception>
		void SetCookies([NotNull] Uri uri, [NotNull] string cookieHeader);
	}
}
