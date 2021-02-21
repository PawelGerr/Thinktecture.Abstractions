using System.Diagnostics.CodeAnalysis;
using System.Net;
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
      [return: NotNullIfNotNull("container")]
		public static ICookieContainer? ToInterface(this CookieContainer? container)
		{
			return (container == null) ? null : new CookieContainerAdapter(container);
		}
	}
}
