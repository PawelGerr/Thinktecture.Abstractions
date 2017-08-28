using System.Net;
using JetBrains.Annotations;
using Thinktecture.Net;
using Thinktecture.Net.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="Cookie"/>.
	/// </summary>
	public static class CookieExtensions
	{
		/// <summary>
		/// Converts provided cookie to <see cref="ICookie"/>.
		/// </summary>
		/// <param name="cookie">Cookie to convert.</param>
		/// <returns>Converted cookie.</returns>
		[CanBeNull]
		public static ICookie ToInterface([CanBeNull] this Cookie cookie)
		{
			return (cookie == null) ? null : new CookieAdapter(cookie);
		}
	}
}
