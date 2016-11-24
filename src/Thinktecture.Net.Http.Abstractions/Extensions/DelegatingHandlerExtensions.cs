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
		/// Converts provided handler to <see cref="IHttpMessageHandler"/>.
		/// </summary>
		/// <param name="handler">Handler to convert.</param>
		/// <returns>Converted handler.</returns>
		public static IDelegatingHandler ToInterface(this DelegatingHandler handler)
		{
			return (handler == null) ? null : new DelegatingHandlerAdapter(handler);
		}

		/// <summary>
		/// Converts provided handler to <see cref="DelegatingHandler"/>.
		/// </summary>
		/// <param name="handler">Handler to convert.</param>
		/// <returns>Converted handler.</returns>
		public static DelegatingHandler ToImplementation(this IDelegatingHandler handler)
		{
			return handler?.UnsafeConvert();
		}
	}
}