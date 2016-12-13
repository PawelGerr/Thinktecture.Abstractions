using System.Net;
using Thinktecture.Net;
using Thinktecture.Net.Adapters;

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
		public static ICookie ToInterface(this Cookie cookie)
		{
			return (cookie == null) ? null : new CookieAdapter(cookie);
		}
	}
}