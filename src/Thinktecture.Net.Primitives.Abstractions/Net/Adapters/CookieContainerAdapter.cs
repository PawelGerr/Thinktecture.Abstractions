using System;
using System.ComponentModel;
using System.Net;

namespace Thinktecture.Net.Adapters
{
	/// <summary>Provides a container for a collection of <see cref="T:System.Net.CookieCollection" /> objects.</summary>
	public class CookieContainerAdapter : AbstractionAdapter, ICookieContainer
	{
		private readonly CookieContainer _container;

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
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new CookieContainer UnsafeConvert()
		{
			return _container;
		}

		/// <inheritdoc />
		public int Capacity => _container.Capacity;

		/// <inheritdoc />
		public int Count => _container.Count;

		/// <inheritdoc />
		public int MaxCookieSize => _container.MaxCookieSize;

		/// <inheritdoc />
		public int PerDomainCapacity => _container.PerDomainCapacity;

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
		public CookieContainerAdapter(CookieContainer container)
			: base(container)
		{
			_container = container ?? throw new ArgumentNullException(nameof(container));
		}

		/// <inheritdoc />
		public void Add(Uri uri, Cookie cookie)
		{
			_container.Add(uri, cookie);
		}

		/// <inheritdoc />
		public void Add(Uri uri, ICookie cookie)
		{
			_container.Add(uri, cookie.ToImplementation());
		}

		/// <inheritdoc />
		public void Add(Uri uri, CookieCollection cookies)
		{
			_container.Add(uri, cookies);
		}

		/// <inheritdoc />
		public void Add(Uri uri, ICookieCollection cookies)
		{
			_container.Add(uri, cookies.ToImplementation());
		}

		/// <inheritdoc />
		public string GetCookieHeader(Uri uri)
		{
			return _container.GetCookieHeader(uri);
		}

		/// <inheritdoc />
		public ICookieCollection GetCookies(Uri uri)
		{
			return _container.GetCookies(uri).ToInterface();
		}

		/// <inheritdoc />
		public void SetCookies(Uri uri, string cookieHeader)
		{
			_container.SetCookies(uri, cookieHeader);
		}
	}
}
