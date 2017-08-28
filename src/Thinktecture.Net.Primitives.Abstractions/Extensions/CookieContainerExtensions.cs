using System.Net;
using JetBrains.Annotations;
using Thinktecture.Net;
using Thinktecture.Net.Adapters;

// ReSharper disable once CheckNamespace
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
		[CanBeNull]
		public static ICookieContainer ToInterface([CanBeNull] this CookieContainer container)
		{
			return (container == null) ? null : new CookieContainerAdapter(container);
		}
	}
}
