using System.Collections;
using System.Net;
using JetBrains.Annotations;

namespace Thinktecture.Net
{
	/// <summary>Provides a collection container for instances of the <see cref="T:System.Net.Cookie" /> class.</summary>
	public interface ICookieCollection : IAbstraction<CookieCollection>, ICollection
	{
		/// <summary>Gets the <see cref="T:System.Net.Cookie" /> with a specific name from a <see cref="T:System.Net.CookieCollection" />.</summary>
		/// <returns>The <see cref="T:System.Net.Cookie" /> with a specific name from a <see cref="T:System.Net.CookieCollection" />.</returns>
		/// <param name="name">The name of the <see cref="T:System.Net.Cookie" /> to be found. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="name" /> is null. </exception>
		[CanBeNull]
		ICookie this[[CanBeNull] string name] { get; }

		/// <summary>Adds a <see cref="T:System.Net.Cookie" /> to a <see cref="T:System.Net.CookieCollection" />.</summary>
		/// <param name="cookie">The <see cref="T:System.Net.Cookie" /> to be added to a <see cref="T:System.Net.CookieCollection" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="cookie" /> is null. </exception>
		void Add([NotNull] Cookie cookie);

		/// <summary>Adds a <see cref="T:System.Net.Cookie" /> to a <see cref="T:System.Net.CookieCollection" />.</summary>
		/// <param name="cookie">The <see cref="T:System.Net.Cookie" /> to be added to a <see cref="T:System.Net.CookieCollection" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="cookie" /> is null. </exception>
		void Add([NotNull] ICookie cookie);

		/// <summary>Adds the contents of a <see cref="T:System.Net.CookieCollection" /> to the current instance.</summary>
		/// <param name="cookies">The <see cref="T:System.Net.CookieCollection" /> to be added. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="cookies" /> is null. </exception>
		void Add([NotNull] CookieCollection cookies);

		/// <summary>Adds the contents of a <see cref="ICookieCollection" /> to the current instance.</summary>
		/// <param name="cookies">The <see cref="T:System.Net.CookieCollection" /> to be added. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="cookies" /> is null. </exception>
		void Add([NotNull] ICookieCollection cookies);
	}
}
