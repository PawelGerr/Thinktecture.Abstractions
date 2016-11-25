using System.Net;
using Thinktecture.Net;
using Thinktecture.Net.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="CookieContainer"/>.
	/// </summary>
	public static class CookieContainerExtensions
	{
		/// <summary>
		/// Converts provided container to <see cref="ICookieContainer"/>.
		/// </summary>
		/// <param name="container">Container to convert.</param>
		/// <returns>Converted container.</returns>
		public static ICookieContainer ToInterface(this CookieContainer container)
		{
			return (container == null) ? null : new CookieContainerAdapter(container);
		}

		/// <summary>
		/// Converts provided container to <see cref="CookieContainer"/>.
		/// </summary>
		/// <param name="container">Container to convert.</param>
		/// <returns>Converted container.</returns>
		public static CookieContainer ToImplementation(this ICookieContainer container)
		{
			return container?.UnsafeConvert();
		}
	}
}