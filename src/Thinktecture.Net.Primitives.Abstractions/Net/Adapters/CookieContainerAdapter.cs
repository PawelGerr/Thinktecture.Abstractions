using System;
using System.Net;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.Adapters
{
	/// <summary>Provides a container for a collection of <see cref="T:System.Net.CookieCollection" /> objects.</summary>
	public class CookieContainerAdapter : AbstractionAdapter<CookieContainer>, ICookieContainer
	{
		/// <summary>Represents the default maximum size, in bytes, of the <see cref="T:System.Net.Cookie" /> instances that the <see cref="T:System.Net.CookieContainer" /> can hold. This field is constant.</summary>
		// ReSharper disable once InconsistentNaming
		public const int DefaultCookieLengthLimit = CookieContainer.DefaultCookieLengthLimit;

		/// <summary>Represents the default maximum number of <see cref="T:System.Net.Cookie" /> instances that the <see cref="T:System.Net.CookieContainer" /> can hold. This field is constant.</summary>
		// ReSharper disable once InconsistentNaming
		public const int DefaultCookieLimit = CookieContainer.DefaultCookieLimit;

		/// <summary>Represents the default maximum number of <see cref="T:System.Net.Cookie" /> instances that the <see cref="T:System.Net.CookieContainer" /> can reference per domain. This field is constant.</summary>
		// ReSharper disable once InconsistentNaming
		public const int DefaultPerDomainCookieLimit = CookieContainer.DefaultPerDomainCookieLimit;

		/// <inheritdoc />
		public int Capacity => Implementation.Capacity;

		/// <inheritdoc />
		public int Count => Implementation.Count;

		/// <inheritdoc />
		public int MaxCookieSize => Implementation.MaxCookieSize;

		/// <inheritdoc />
		public int PerDomainCapacity => Implementation.PerDomainCapacity;

		/// <summary>
		/// Initializes a new instance of the <see cref="CookieContainerAdapter" /> class.
		/// </summary>
		public CookieContainerAdapter()
			: this(new CookieContainer())
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CookieContainerAdapter" /> class.
		/// </summary>
		/// <param name="container">The implementation to use by the adapter.</param>
		public CookieContainerAdapter([NotNull] CookieContainer container)
			: base(container)
		{
		}

		/// <inheritdoc />
		public void Add(Uri uri, Cookie cookie)
		{
			Implementation.Add(uri, cookie);
		}

		/// <inheritdoc />
		public void Add(Uri uri, ICookie cookie)
		{
			Implementation.Add(uri, cookie.ToImplementation());
		}

		/// <inheritdoc />
		public void Add(Uri uri, CookieCollection cookies)
		{
			Implementation.Add(uri, cookies);
		}

		/// <inheritdoc />
		public void Add(Uri uri, ICookieCollection cookies)
		{
			Implementation.Add(uri, cookies.ToImplementation());
		}

		/// <inheritdoc />
		public string GetCookieHeader(Uri uri)
		{
			return Implementation.GetCookieHeader(uri);
		}

		/// <inheritdoc />
		public ICookieCollection GetCookies(Uri uri)
		{
			return Implementation.GetCookies(uri).ToInterface();
		}

		/// <inheritdoc />
		public void SetCookies(Uri uri, string cookieHeader)
		{
			Implementation.SetCookies(uri, cookieHeader);
		}
	}
}
