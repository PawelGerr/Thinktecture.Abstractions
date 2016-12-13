using System.Net.Http;
using Thinktecture.Net.Http;
using Thinktecture.Net.Http.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="DelegatingHandler"/>.
	/// </summary>
	public static class DelegatingHandlerExtensions
	{
		/// <summary>
		/// Converts provided handler to <see cref="IDelegatingHandler"/>.
		/// </summary>
		/// <param name="handler">Handler to convert.</param>
		/// <returns>Converted handler.</returns>
		public static IDelegatingHandler ToInterface(this DelegatingHandler handler)
		{
			return (handler == null) ? null : new DelegatingHandlerAdapter(handler);
		}
	}
}